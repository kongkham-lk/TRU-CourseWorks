package com.example.newsapp;

import android.content.Context;

import com.android.volley.RequestQueue;
import com.android.volley.toolbox.Volley;

public class VolleySingleton {
    private RequestQueue requestQueue;
    private static VolleySingleton volleyInstance;

    public VolleySingleton(Context context) {
        requestQueue = Volley.newRequestQueue(context.getApplicationContext());
    }

    public static synchronized VolleySingleton getVolleyInstance(Context context) {
        if (volleyInstance == null)
            volleyInstance = new VolleySingleton(context);

        return volleyInstance;
    }

    public RequestQueue getRequestQueue() {
        return requestQueue;
    }
}
