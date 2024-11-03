package com.example.newsapp;

import android.app.ProgressDialog;
import android.content.Context;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.android.volley.DefaultRetryPolicy;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.VolleyLog;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.google.gson.Gson;
import com.google.gson.JsonObject;

import org.json.JSONArray;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class TechnologyFragment extends Fragment {

    private RecyclerView recyclerView;
    private NewsItemAdapter newsItemAdapter;
    private List<NewsModel> newsList;
    private RequestQueue requestQueue;
    private final Context mainActivityContext;

    public TechnologyFragment(Context context) {
        mainActivityContext = context;
    }


    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_recycle_view, container, false);

        recyclerView = view.findViewById(R.id.fragmentRecycleView);
        recyclerView.setLayoutManager(new LinearLayoutManager(getContext()));

        newsList = new ArrayList<>();
//        populateNewsData(); // Populate newsList with data

//        Context mainContext = getContext().getApplicationContext();
        requestQueue = Volley.newRequestQueue(mainActivityContext);
//        requestQueue = VolleySingleton.getVolleyInstance(mainActivityContext).getRequestQueue();
//        fetchNewsList();
//        fetchNews();
        String url = "https://newsapi.org/v2/everything?q=Apple&from=2024-11-01?country=us&sortBy=popularity&apiKey=191ed1d038f44e3ab9313c7aec710768";

        StringRequest stringRequest = new StringRequest(
            Request.Method.GET,
            url,
            new Response.Listener<String>() {
                @Override
                public void onResponse(String response) {
                    try {
                        JSONObject jsonRes = new JSONObject(response);
                        JSONArray articles = jsonRes.getJSONArray("articles");
                        for (int i = 0; i < articles.length(); i++) {
                            JSONObject jsonObject = articles.getJSONObject(i);
                            String title = jsonObject.getString("title");
                            String publishedAt = jsonObject.getString("publishedAt");
                            String author = jsonObject.getString("author");
                            String url = jsonObject.getString("url");
                            String urlToImage = jsonObject.getString("urlToImage");
                            String description = jsonObject.getString("description");
                            newsList.add(new NewsModel(title, publishedAt, author, url, urlToImage, description));
                        }
//                            newsItemAdapter.notifyDataSetChanged();
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                }
            }, new Response.ErrorListener() {
                @Override
                public void onErrorResponse(VolleyError error) {
                    // Print error message
                    error.printStackTrace();
                    // Optionally, log error details
                    Log.e("Volley Error", "Error: " + error.toString());
                }
            });
        requestQueue.add(stringRequest);
        return view;
    }

    private void fetchNewsList() {
        String url = "https://newsapi.org/v2/everything?q=Apple&from=2024-11-01?country=us&sortBy=popularity&apiKey=191ed1d038f44e3ab9313c7aec710768";
        JsonArrayRequest jsonArrayRequest = new JsonArrayRequest(
                Request.Method.GET,
                url,
                null,
                getResponseListener(),
                getResponseErrorListener());
        newsItemAdapter = new NewsItemAdapter(getContext(), newsList);
        recyclerView.setAdapter(newsItemAdapter);
        requestQueue.add(jsonArrayRequest);

//        JsonObjectRequest jsonObjectRequest = new JsonObjectRequest(
//                Request.Method.GET,
//                url,
//                null,
//                new Response.Listener<JSONObject>() {
//                    @Override
//                    public void onResponse(JSONObject response)
//                    {
//                        try {
//                            JSONArray articles = response.getJSONArray("articles");
//                            for (int i = 0; i < articles.length(); i++) {
//                                JSONObject jsonObject = articles.getJSONObject(i);
//                                String title = jsonObject.getString("title");
//                                String publishedAt = jsonObject.getString("publishedAt");
//                                String author = jsonObject.getString("author");
//                                String url = jsonObject.getString("url");
//                                String urlToImage = jsonObject.getString("urlToImage");
//                                String description = jsonObject.getString("description");
//                                newsList.add(new NewsModel(title, publishedAt, author, url, urlToImage, description));
//                            }
//                            newsItemAdapter.notifyDataSetChanged();
//                        } catch (Exception e) {
//                            e.printStackTrace();
//                        }
//                    }
//                },
//                new Response.ErrorListener() {
//                    @Override
//                    public void onErrorResponse(VolleyError error)
//                    {
//                        // Print error message
//                        error.printStackTrace();
//                        // Optionally, log error details
//                        Log.e("Volley Error", "Error: " + error.toString());
//                    }
//                });
//        jsonObjectRequest.setRetryPolicy(new DefaultRetryPolicy(
//                5000, // Timeout in milliseconds
//                DefaultRetryPolicy.DEFAULT_MAX_RETRIES,
//                DefaultRetryPolicy.DEFAULT_BACKOFF_MULT
//        ));
//        newsItemAdapter = new NewsItemAdapter(getContext(), newsList);
//        recyclerView.setAdapter(newsItemAdapter);
//        requestQueue.add(jsonObjectRequest);
    };

    private Response.Listener<JSONArray> getResponseListener() {
        return new Response.Listener<JSONArray>() {
            @Override
            public void onResponse(JSONArray response) {
                JSONArray resNewsList = null;
                try {
                    JSONObject article = response.getJSONObject(0);
                    resNewsList = article.getJSONArray("articles");
                } catch (Exception e) {
                    e.printStackTrace();
                }

                if (resNewsList != null) {
                    for (int i = 0; i < resNewsList.length(); i++) {
                        try {
                            JSONObject jsonObject = response.getJSONObject(i);
                            String title = jsonObject.getString("title");
                            String publishedAt = jsonObject.getString("publishedAt");
                            String author = jsonObject.getString("author");
                            String url = jsonObject.getString("url");
                            int urlToImage = jsonObject.getInt("urlToImage");
                            String description = jsonObject.getString("description");
                            newsList.add(new NewsModel(title, publishedAt, author, url, String.valueOf(urlToImage), description));
                        } catch (Exception e) {
                            e.printStackTrace();
                        }
                    }
                }
            }
        };
    }

    private Response.ErrorListener getResponseErrorListener() {
        return new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error)
            {
                // Print error message
                error.printStackTrace();
                // Optionally, log error details
                Log.e("Volley Error", "Error: " + error.toString());
            }
        };
    }

    private void fetchNews() {
        String url = "https://newsapi.org/v2/everything?q=Apple&from=2024-11-01?country=us&sortBy=popularity&apiKey=191ed1d038f44e3ab9313c7aec710768";
        JsonObjectRequest jsonObjectRequest = new JsonObjectRequest(
                Request.Method.GET,
                url,
                null,
                new Response.Listener<JSONObject>() {
                    @Override
                    public void onResponse(JSONObject response) {
                        JSONArray resNewsList = null;
                        try {
//                            JSONObject article = response.getJSONObject(0);
                            resNewsList = response.getJSONArray("articles");
                        } catch (Exception e) {
                            e.printStackTrace();
                        }
                        Gson gson = new Gson();
                        NewsModel newsItem = gson.fromJson(String.valueOf(resNewsList), NewsModel.class);
                        newsList.add(newsItem);                    }
                }, new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {

                    }
                });
        newsItemAdapter = new NewsItemAdapter(getContext(), newsList);
        recyclerView.setAdapter(newsItemAdapter);
        requestQueue.add(jsonObjectRequest);
    }

    private void populateNewsData() {
        // Mock data for example
        for (int i = 1; i <= 20; i++)
            newsList.add(new NewsModel("Tech News Title " + i, "Just Now", "BBC", "www.google.com", String.valueOf(R.drawable.tech), null));
        // Add more items as needed
    }
}
