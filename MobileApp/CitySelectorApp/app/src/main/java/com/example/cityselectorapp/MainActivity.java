package com.example.cityselectorapp;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        String[] cityNames = getResources().getStringArray(R.array.citiesName);
        String[] cityInfos = getResources().getStringArray(R.array.citiesDescription);
        int[] cityImages = {
                R.drawable.toronto,
                R.drawable.vancouver,
                R.drawable.montreal,
                R.drawable.calgary,
                R.drawable.ottawa
        };

        Spinner spinner_cities = findViewById(R.id.spinner);
        ArrayAdapter<CharSequence> adaptor = ArrayAdapter.createFromResource(getApplicationContext(), R.array.citiesName, android.R.layout.simple_spinner_dropdown_item);
        spinner_cities.setAdapter(adaptor);

        spinner_cities.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                int targetPos = spinner_cities.getSelectedItemPosition();
                if (targetPos == 0) {
                    return;
                }

                Intent temp = new Intent(getApplicationContext(), CityDetail.class);
                temp.putExtra(getResources().getString(R.string.cityNameKey), cityNames[targetPos]);
                temp.putExtra(getResources().getString(R.string.cityImgKey), cityImages[targetPos-1]);
                temp.putExtra(getResources().getString(R.string.cityInfoKey), cityInfos[targetPos-1]);
                startActivity(temp);
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });
    }
}