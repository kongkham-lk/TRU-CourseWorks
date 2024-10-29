package com.example.newsapp;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;
import java.util.List;

public class SportsFragment extends Fragment {

    private RecyclerView recyclerView;
    private NewsItemAdapter newsItemAdapter;
    private List<NewsModel> newsList;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_recycle_view, container, false);

        recyclerView = view.findViewById(R.id.fragmentRecycleView);
        recyclerView.setLayoutManager(new LinearLayoutManager(getContext()));

        newsList = new ArrayList<>();
        populateNewsData(); // Populate newsList with data

        newsItemAdapter = new NewsItemAdapter(getContext(), newsList);
        recyclerView.setAdapter(newsItemAdapter);

        return view;
    }

    private void populateNewsData() {
        // Mock data for example
        for (int i = 1; i <= 20; i++)
            newsList.add(new NewsModel("Sport News Title " + i, "Just Now", "BBC", "www.google.com", R.drawable.sport));
        // Add more items as needed
    }
}
