package com.example.movieapp;

import android.content.Intent;
import android.os.Build;
import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.app.AppCompatDelegate;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ArrayList<MovieModel> movieList;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_YES);
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        populateMovieList();

        MovieAdaptor movieAdaptor = new MovieAdaptor(this, movieList);
        RecyclerView recyclerView = findViewById(R.id.movieListView);
        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(getApplicationContext(), LinearLayoutManager.VERTICAL, false);

        recyclerView.setAdapter(movieAdaptor);
        recyclerView.setLayoutManager(linearLayoutManager);

        // start music service to place background music
        Intent intent =new Intent( MainActivity.this, ForegroundMusicService.class);
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            startForegroundService(intent);
        }
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();

        // release resource when close app
        Intent intent =new Intent( MainActivity.this, ForegroundMusicService.class);
        stopService(intent);
    }

    // generate demo movie list to display on screen
    private void populateMovieList() {
        String[] movieTitleList = getResources().getStringArray(R.array.movieTitleList);
        String[] showTimeList = getResources().getStringArray(R.array.showTimeList);
        int[] coverList = {
                R.drawable.img_0,
                R.drawable.img_1,
                R.drawable.img_2,
                R.drawable.img_3,
                R.drawable.img_4,
                R.drawable.img_5,
                R.drawable.img_6,
                R.drawable.img_7,
                R.drawable.img_8,
                R.drawable.img_9
        };

        movieList = new ArrayList<>();
        for (int i = 0; i < movieTitleList.length; i++)
            movieList.add(new MovieModel(movieTitleList[i], showTimeList[i], coverList[i]));
    }
}