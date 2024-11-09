package com.example.newsapp;

import android.content.Context;
import android.graphics.drawable.Drawable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.bumptech.glide.Glide;

import java.io.InputStream;
import java.net.URL;
import java.util.List;

public class NewsItemAdapter extends RecyclerView.Adapter<NewsItemAdapter.ViewHolder> {
    Context context;
    List<NewsModel> newsList;

    public NewsItemAdapter(Context context, List<NewsModel> newsList) {
        this.context = context;
        this.newsList = newsList;
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.news_item, parent, false);
        ViewHolder holder = new ViewHolder(view);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull NewsItemAdapter.ViewHolder holder, int position) {
        NewsModel targetNews = newsList.get(position);
        String url = targetNews.getUrlToImage();
        Glide.with(context)
                .load(url)
                .placeholder(R.drawable.loader) // optional placeholder
                .error(R.drawable.error)       // optional error image
                .into(holder.newsImg);
//        Picasso.get()
//                .load(targetNews.getUrlToImage())
//                .placeholder(R.drawable.loader) // optional placeholder
//                .error(R.drawable.error)       // optional error image
//                .into(holder.newsImg);
//        holder.newsImg.setImageDrawable(LoadImageFromWebOperations(targetNews.getUrlToImage()));
//        WebView web = (WebView) (holder.newsImg);
//        web.loadUrl(url);
//        ImageLoader imageLoader = ImageLoader.getInstance();
//        Bitmap bitmap = imageLoader.loadImageSync(url);
//        holder.newsImg.setImageBitmap(bitmap);
        holder.newsTitle.setText(targetNews.getTitle());
        holder.newsAuthor.setText(targetNews.getAuthor());
        holder.newsPublishedTime.setText(targetNews.getPublishedAt());
    }

    @Override
    public int getItemCount() {
        return newsList.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        ImageView newsImg;
        TextView newsTitle;
        TextView newsAuthor;
        TextView newsPublishedTime;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);

            newsImg = itemView.findViewById(R.id.newsImg);
            newsTitle = itemView.findViewById(R.id.newsTitle);
            newsAuthor = itemView.findViewById(R.id.newsAuthor);
            newsPublishedTime = itemView.findViewById(R.id.newsPublishedTime);
        }
    }

    public static Drawable LoadImageFromWebOperations(String url) {
        try {
            InputStream is = (InputStream) new URL(url).getContent();
            Drawable d = Drawable.createFromStream(is, "src name");
            return d;
        } catch (Exception e) {
            return null;
        }
    }

}
