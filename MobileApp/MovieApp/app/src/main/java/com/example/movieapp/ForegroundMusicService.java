package com.example.movieapp;

import android.app.Notification;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.app.Service;
import android.content.Intent;
import android.media.MediaPlayer;
import android.os.Build;
import android.os.IBinder;

import androidx.core.app.NotificationCompat;

public class ForegroundMusicService extends Service {
    MediaPlayer mediaPlayer = null;
    public static final String CHANNEL_ID = "ForegroundServiceChannel";

    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {

        mediaPlayer = MediaPlayer.create(this, R.raw.morning_routine_lofi_study);
//        mediaPlayer.setLooping(true); // Enable looping
        mediaPlayer.start();

        create_Notification_Channel();
        Intent notificationIntent = new Intent(this, MainActivity.class);
        PendingIntent pendingIntent = PendingIntent.getActivity(this,
                10, notificationIntent, PendingIntent.FLAG_IMMUTABLE);

        // Build the foreground notification with pending intent
        Notification notification = new NotificationCompat.Builder(this, CHANNEL_ID)
                .setContentTitle("Foreground Service")
                .setContentText("Music is playing")
                .setSmallIcon(R.drawable.ic_launcher_foreground)
                .setContentIntent(pendingIntent)// Set the intent for when the user taps the notification
                .build();

        startForeground(1, notification);

        return START_NOT_STICKY;
    }


    private void create_Notification_Channel() {

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            NotificationManager manager = getSystemService(NotificationManager.class);
            NotificationChannel serviceChannel = new NotificationChannel(
                    CHANNEL_ID,
                    "Foreground Service Channel",
                    NotificationManager.IMPORTANCE_DEFAULT
            );
            manager.createNotificationChannel(serviceChannel);
        }
    }

    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }

    @Override
    public void onDestroy() {
        super.onDestroy();
        if (mediaPlayer != null) {
            mediaPlayer.stop();
            mediaPlayer.release();
        }
    }
}
