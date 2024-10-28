package com.example.newsapp;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

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
        holder.newsImg.setImageResource(targetNews.getImg());
        holder.newsTitle.setText(targetNews.getTitle());
        holder.newsAuthor.setText(targetNews.getAuthor());
        holder.newsPublishedTime.setText(targetNews.getPublishedTime());
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
}
