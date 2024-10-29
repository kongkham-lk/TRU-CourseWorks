package com.example.bookstoreapp;

import android.content.Intent;
import android.os.Bundle;
import android.text.method.ScrollingMovementMethod;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

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

        // gett all the pass_in data from main page
        Intent data_in = getIntent();
        int coverImg = data_in.getIntExtra(getResources().getString(R.string.keyCoverImg), -1);
        String title = data_in.getStringExtra(getResources().getString(R.string.keyTitle));
        String author = data_in.getStringExtra(getResources().getString(R.string.keyAuthor));
        String description = data_in.getStringExtra(getResources().getString(R.string.keyDescription));
        String price = data_in.getStringExtra(getResources().getString(R.string.keyPrice));
        int availableTotal = data_in.getIntExtra(getResources().getString(R.string.keyAvailNum), -1);
        String displayAvailTotal = availableTotal > 25 ? "25+" : String.valueOf(availableTotal);

        // getting all the activity component of the book detail page
        ImageView bookCover = findViewById(R.id.bookCover);
        TextView bookTitle = findViewById(R.id.bookTitle);
        TextView bookAuthor = findViewById(R.id.bookAuthor);
        TextView bookDescription = findViewById(R.id.bookDescription);
        TextView bookAvail = findViewById(R.id.bookAvail);
        ImageView btnBack = findViewById(R.id.btnBack);
        TextView btnBackLabel = findViewById(R.id.btbBackLabel);
        Button btnBuy = findViewById(R.id.btnBuy);

        // enable scrollable content
        bookDescription.setMovementMethod(new ScrollingMovementMethod());

        // binding the pass_in data to each component of the book detail page
        bookCover.setImageResource(coverImg);
        bookTitle.setText(title);
        bookAuthor.setText(author);
        bookDescription.setText(description);
        bookAvail.setText(getResources().getString(R.string.bookAvail) + " " + displayAvailTotal );
        btnBuy.setText(price);

        // set click listener on Back btn to go back to the prev page
        btnBack.setOnClickListener(setOnclicked(false));
        btnBackLabel.setOnClickListener(setOnclicked(false));
        btnBuy.setOnClickListener(setOnclicked(false));
    }

    private View.OnClickListener setOnclicked(boolean isPurchased) {
        return new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent temp = new Intent(getApplicationContext(), MainActivity.class);
                if (isPurchased)
                    temp.putExtra(getResources().getString(R.string.keyPurchaseFlag), true);
                startActivity(temp);
            }
        };
    }
}