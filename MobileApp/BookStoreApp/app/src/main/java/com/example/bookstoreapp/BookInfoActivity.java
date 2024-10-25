package com.example.bookstoreapp;

import android.content.Intent;
import android.os.Bundle;
import android.text.method.ScrollingMovementMethod;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.app.AppCompatDelegate;

public class BookInfoActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_YES);
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_book_info);

        Intent data_in = getIntent();
        int coverImg = data_in.getIntExtra(getResources().getString(R.string.keyCoverImg), -1);
        String title = data_in.getStringExtra(getResources().getString(R.string.keyTitle));
        String author = data_in.getStringExtra(getResources().getString(R.string.keyAuthor));
        String description = data_in.getStringExtra(getResources().getString(R.string.keyDescription));

        ImageView bookCover = findViewById(R.id.bookCover);
        TextView bookTitle = findViewById(R.id.bookTitle);
        TextView bookAuthor = findViewById(R.id.bookAuthor);
        TextView bookDescription = findViewById(R.id.bookDescription);
        Button btnBack = findViewById(R.id.btnBack);

        bookCover.setImageResource(coverImg);
        bookTitle.setText(title);
        bookAuthor.setText(author);
        bookDescription.setText(description);
        bookDescription.setMovementMethod(new ScrollingMovementMethod());

        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent temp = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(temp);
            }
        });
    }
}