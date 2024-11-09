package com.example.newsapp;

import android.util.Log;
import org.json.JSONArray;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.Callable;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;

public class NewsFetcher {

    private List<NewsModel> newsList;
    private ExecutorService executor = Executors.newSingleThreadExecutor(); // Single-thread executor

    public NewsFetcher() {
        newsList = new ArrayList<>();
    }

    // Callable task to fetch API data
    public Callable<List<NewsModel>> fetchApiNews(String apiUrl) {
        return () -> {
            HttpURLConnection urlConnection = null;
            BufferedReader reader = null;

            try {
                URL url = new URL(apiUrl);
                urlConnection = (HttpURLConnection) url.openConnection();
                urlConnection.setRequestMethod("GET");
                urlConnection.setRequestProperty("User-Agent", "Mozilla/5.0");
                urlConnection.setRequestProperty("Accept", "application/json");
                urlConnection.setConnectTimeout(10000);
                urlConnection.setReadTimeout(10000);

                // urlConnection WILL ALWAYS FAIL IF TURN ON VPN
                int responseCode = urlConnection.getResponseCode();
                Log.d("HTTP_RESPONSE", "Response Code: " + responseCode);

                if (responseCode == 200) {
                    // Reading the response
                    InputStreamReader streamReader = new InputStreamReader(urlConnection.getInputStream());
                    reader = new BufferedReader(streamReader);
                    StringBuilder response = new StringBuilder();
                    String line;
                    while ((line = reader.readLine()) != null) {
                        response.append(line);
                    }

                    // Convert response to String
                    String responseData = response.toString();
                    extractDataIntoList(responseData);  // Parse articles and populate newsList

                } else {
                    Log.e("API_ERROR", "Response Code: " + responseCode + ", Message: " + urlConnection.getResponseMessage());
                }
            } catch (Exception e) {
                Log.e("NETWORK_ERROR", "Exception: " + e.getMessage());
            } finally {
                if (urlConnection != null) {
                    urlConnection.disconnect();
                }
                if (reader != null) {
                    try {
                        reader.close();
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                }
            }
            return newsList;  // Return populated newsList
        };
    }

    // Parsing logic for the articles
    private void extractDataIntoList(String jsonResponse) {
        try {
            JSONObject jsonObject = new JSONObject(jsonResponse);
            JSONArray articlesArray = jsonObject.getJSONArray("results");

            for (int i = 0; i < articlesArray.length(); i++) {
                try {
                    JSONObject articleObject = articlesArray.getJSONObject(i);
                    String title = articleObject.getString("title");
                    String publishedAt = articleObject.getString("pubDate");
                    String author = articleObject.getString("source_name");
                    String link = articleObject.getString("link");
                    String urlToImage = articleObject.optString("image_url", "");
                    newsList.add(new NewsModel(title, publishedAt, author, link, urlToImage));
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public List<NewsModel> getNewsList(String apiUrl) {
        Future<List<NewsModel>> future = executor.submit(fetchApiNews(apiUrl));  // Submit Callable task
        try {
            return future.get();  // Wait for the task to complete and get the result
        } catch (Exception e) {
            e.printStackTrace();
            return new ArrayList<>();  // Return an empty list in case of error
        }
    }
}
