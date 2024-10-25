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

        for (int i = 0; i < bookTitles.length; i++)
            bookLists.add(new BookModel(bookCovers[i], bookTitles[i], bookAuthors[i], bookDescription[i]));

        BookAdaptor bookAdaptor = new BookAdaptor(this, bookLists);
        RecyclerView bookRecyclerView = findViewById(R.id.bookListRecycle);
        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(getApplicationContext(), LinearLayoutManager.VERTICAL, false);

        bookRecyclerView.setAdapter(bookAdaptor);
        bookRecyclerView.setLayoutManager(linearLayoutManager);
    }

}