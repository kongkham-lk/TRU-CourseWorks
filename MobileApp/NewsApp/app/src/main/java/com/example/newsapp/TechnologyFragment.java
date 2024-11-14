package com.example.newsapp;

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

import java.util.List;

public class TechnologyFragment extends Fragment {

    private RecyclerView recyclerView;
    private NewsItemAdapter newsItemAdapter;
    private List<NewsModel> newsList;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_recycle_view, container, false);

        fetchAPI();
        newsItemAdapter = new NewsItemAdapter(getContext(), newsList);

        recyclerView = view.findViewById(R.id.fragmentRecycleView);
        recyclerView.setLayoutManager(new LinearLayoutManager(getContext()));
        recyclerView.setAdapter(newsItemAdapter);
        return view;
    }

    private void fetchAPI() {

        String apiKey = BuildConfig.ApiKey_thenewsapi;
        String url = "https://newsdata.io/api/1/latest?apikey=" + apiKey + "&q=technology";

        NewsFetcher newsFetcher = new NewsFetcher();
        newsList = newsFetcher.getNewsList(url);
    }
}
