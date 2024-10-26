package com.example.bookstoreapp;

import android.os.Bundle;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.app.AppCompatDelegate;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    ArrayList<BookModel> bookLists = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_YES);
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        // Get all the necessary data from Resource file - String
        int[] bookCovers = {
            R.drawable.cov_1,
            R.drawable.cov_2,
            R.drawable.cov_3,
            R.drawable.cov_4,
            R.drawable.cov_5,
        };
        String[] bookTitles = getResources().getStringArray(R.array.bookTitle);
        String[] bookAuthors = getResources().getStringArray(R.array.bookAuthors);
        String[] bookDescription = getResources().getStringArray(R.array.bookDescriptions);
        String[] bookPrices = getResources().getStringArray(R.array.bookPrices);
        String[] bookRatings = getResources().getStringArray(R.array.bookRatings);
        String[] bookTotalReview = getResources().getStringArray(R.array.bookTotalReview);

        // create an array of BookModel instance for binding to activity (UI) component
        for (int i = 0; i < bookTitles.length; i++)
            bookLists.add(new BookModel(bookCovers[i], bookTitles[i], bookAuthors[i], bookDescription[i], bookPrices[i], Integer.parseInt(bookRatings[i]), Integer.parseInt(bookTotalReview[i])));

        BookAdaptor bookAdaptor = new BookAdaptor(this, bookLists); // Iitialized data binder that bind data with each activity (UI) component
        RecyclerView bookRecyclerView = findViewById(R.id.bookListRecycle); // Get the customized recycle view that will be display each binded data activity component in it
        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(getApplicationContext(), LinearLayoutManager.VERTICAL, false); // initialized recycle view's layout

        bookRecyclerView.setAdapter(bookAdaptor); // pass the whole binded data activity component list to the customized recycle view
        bookRecyclerView.setLayoutManager(linearLayoutManager); // set the layout of recycle view
    }

}