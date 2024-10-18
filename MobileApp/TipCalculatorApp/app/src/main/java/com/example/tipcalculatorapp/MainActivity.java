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
    private double inputAmount;
    private String defaultVal;
    String[] tipCommentList;
    EditText baseInput;
    SeekBar slideBar;
    TextView tipPercentDisplay;
    TextView tipComment;
    TextView totalTipDisplay;
    TextView totalChargeDisplay;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        baseInput = findViewById(R.id.baseAmount_input);
        slideBar = findViewById(R.id.sliderBar);
        tipPercentDisplay = findViewById(R.id.tipPercent_display);
        tipComment = findViewById(R.id.tipComment);
        totalTipDisplay = findViewById(R.id.tipAmount_display);
        totalChargeDisplay = findViewById(R.id.totalAmount_display);

        tipPercent = Integer.parseInt(getResources().getString(R.string.defaultTip));
        defaultVal = getResources().getString(R.string.defaultVal);

        slideBar.setProgress(tipPercent);
        tipPercentDisplay.setText(getTipPercentDisplay(tipPercent));
        tipCommentList = getResources().getStringArray(R.array.tipCommentList);
        determinedTipAmount();

        baseInput.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {

            }

            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {

            }

            @Override
            public void afterTextChanged(Editable editable) {
                if (isBaseAmountInputEmpty()) {
                    slideBar.setEnabled(false);
                    resetTotalFee();
                }
                else {
                    slideBar.setEnabled(true);
                    inputAmount = Double.parseDouble(baseInput.getText().toString());
                    computeFee(); // Update total fee when input change as well
                }
            }
        });

        slideBar.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int i, boolean b) {
                tipPercent = slideBar.getProgress();
                tipPercentDisplay.setText(getTipPercentDisplay(tipPercent));
                determinedTipAmount();
                computeFee(); // Update total fee when slider bar update
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {
                if (isBaseAmountInputEmpty()) { // warn user when no base amount input
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

    private void determinedTipAmount() {
        if (tipPercent < 10) {
            tipComment.setText(tipCommentList[0]);
            tipComment.setTextColor(getResources().getColor(R.color.poor));
        } else if (tipPercent <= 15) {
            tipComment.setText(tipCommentList[1]);
            tipComment.setTextColor(getResources().getColor(R.color.acceptable));
        } else if (tipPercent <= 20) {
            tipComment.setText(tipCommentList[2]);
            tipComment.setTextColor(getResources().getColor(R.color.good));
        } else {
            tipComment.setText(tipCommentList[3]);
            tipComment.setTextColor(getResources().getColor(R.color.amazing));
        }
    }

    private void computeFee() {
        double totalTip = inputAmount / 100 * (tipPercent == 0 ? 1 : tipPercent);
        double totalCharge = inputAmount + totalTip;

        totalTipDisplay.setText(df.format(totalTip));
        totalChargeDisplay.setText(df.format(totalCharge));
    }

    private boolean isBaseAmountInputEmpty() {
        return baseInput.getText().toString().isEmpty();
    }

    private void resetTotalFee() {
        totalTipDisplay.setText(defaultVal);
        totalChargeDisplay.setText(defaultVal);
    }
}