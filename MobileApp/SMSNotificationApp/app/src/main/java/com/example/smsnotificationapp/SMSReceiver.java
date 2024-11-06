package com.example.smsnotificationapp;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.provider.Telephony;
import android.telephony.SmsMessage;
import android.widget.Toast;

public class SMSReceiver extends BroadcastReceiver {

    @Override
    public void onReceive(Context context, Intent intent)
    {
        if (Telephony.Sms.Intents.SMS_RECEIVED_ACTION.equals(intent.getAction()))
        {
            SmsMessage[] smsMessages = Telephony.Sms.Intents.getMessagesFromIntent(intent);

            for (SmsMessage smsMessage : smsMessages)
            {
                String sender = smsMessage.getDisplayOriginatingAddress();
                String senderFormat = formatPhoneNumber(sender);
                String messageBody = smsMessage.getMessageBody();

                String strMessageNotify = "Receive a new message !!!";
                String strMessageDetail = senderFormat + ": \n" + messageBody;
                Toast.makeText(context, strMessageNotify, Toast.LENGTH_SHORT).show();
                Toast.makeText(context, strMessageDetail, Toast.LENGTH_SHORT).show();
            }
        }
    }
    public static String formatPhoneNumber(String phoneNumber) {
        return String.format("(%s) %s-%s",
                phoneNumber.substring(0, 3),
                phoneNumber.substring(3, 6),
                phoneNumber.substring(6));
    }
}
