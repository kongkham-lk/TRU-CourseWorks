package com.example.tipcalculatorapp;

import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.widget.EditText;
import android.widget.SeekBar;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;

import java.text.DecimalFormat;

public class MainActivity extends AppCompatActivity {
    private final DecimalFormat df = new DecimalFormat("0.00");
    private int tipPercent;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        EditText baseInput = findViewById(R.id.baseAmount_input);
        SeekBar slideBar = findViewById(R.id.sliderBar);
        TextView tipPercentDisplay = findViewById(R.id.tipPercent_display);
        TextView tipComment = findViewById(R.id.tipComment);
        TextView totalTipDisplay = findViewById(R.id.tipAmount_display);
        TextView totalChargeDisplay = findViewById(R.id.totalAmount_display);
        tipPercent = Integer.parseInt(getResources().getString(R.string.defaultTip));

        slideBar.setProgress(tipPercent);
        tipPercentDisplay.setText(getTipPercentDisplay(tipPercent));
        String[] tipCommentList = getResources().getStringArray(R.array.tipCommentList);
        determinedTipAmount(tipPercent, tipComment, tipCommentList);

        baseInput.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {

            }

            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {

            }

            @Override
            public void afterTextChanged(Editable editable) {
                String input = baseInput.getText().toString();
                if (input.isEmpty())
                    slideBar.setEnabled(false);
                else
                    slideBar.setEnabled(true);
            }
        });

        slideBar.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int i, boolean b) {
                double inputAmount = Double.parseDouble(baseInput.getText().toString());
                tipPercent = slideBar.getProgress();
                tipPercentDisplay.setText(getTipPercentDisplay(tipPercent));
                determinedTipAmount(tipPercent, tipComment, tipCommentList);
                computeFee(inputAmount, totalTipDisplay, totalChargeDisplay);
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {
                String input = baseInput.getText().toString();
                if (input.isEmpty()) {
                    baseInput.setError(getResources().getString(R.string.missingAmountError));
                    slideBar.setEnabled(false);
                }
            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {

            }
        });
    }

    private String getTipPercentDisplay(double tip) {
        return tip + getResources().getString(R.string.percentUnit);
    }

    private void determinedTipAmount(int tipPercent, TextView tipComment, String[] tipCommentList) {
        if (tipPercent < 10) {
            tipComment.setText(tipCommentList[0]);
            tipComment.setTextColor(getResources().getColor(R.color.poor));
        }
        else if (tipPercent <= 15) {
            tipComment.setText(tipCommentList[1]);
            tipComment.setTextColor(getResources().getColor(R.color.acceptable));
        }
        else if (tipPercent <= 20) {
            tipComment.setText(tipCommentList[2]);
            tipComment.setTextColor(getResources().getColor(R.color.good));
        }
        else {
            tipComment.setText(tipCommentList[3]);
            tipComment.setTextColor(getResources().getColor(R.color.amazing));
        }
    }

    private void computeFee(double inputAmount, TextView totalTipDisplay, TextView totalChargeDisplay) {
        double totalTip = inputAmount / 100 * (tipPercent == 0 ? 1 : tipPercent);
        double totalCharge = inputAmount + totalTip;

        totalTipDisplay.setText(df.format(totalTip));
        totalChargeDisplay.setText(df.format(totalCharge));
    }
}