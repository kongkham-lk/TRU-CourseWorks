package com.example.cityexplorerapp;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;

public class CityDetail extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_city_detail);

        TextView txtCityName = findViewById(R.id.cityName);
        TextView txtCityInfo = findViewById(R.id.cityInfo);
        ImageView imgCity = findViewById(R.id.cityImg);
        ImageView backBtn = findViewById(R.id.backBtn);
        TextView backBtnLabel = findViewById(R.id.backBtnLabel);

        Intent data_in = getIntent();
        String cityName = data_in.getStringExtra(getResources().getString(R.string.cityNameKey));
        String cityInfo = data_in.getStringExtra(getResources().getString(R.string.cityInfoKey));
        int cityImgId = data_in.getIntExtra(getResources().getString(R.string.cityImgKey), -1);

        txtCityName.setText(cityName);
        txtCityInfo.setText(cityInfo);
        imgCity.setImageResource(cityImgId);

        backBtn.setOnClickListener(setOnclicked());
        backBtnLabel.setOnClickListener(setOnclicked());
    }

    private View.OnClickListener setOnclicked() {
        return new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent temp = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(temp);
            }
        };
    }
}