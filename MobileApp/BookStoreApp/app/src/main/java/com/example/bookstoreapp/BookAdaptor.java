package com.example.bookstoreapp;

import android.content.Context;
import android.content.Intent;
import android.content.res.Resources;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class BookAdaptor extends RecyclerView.Adapter<BookAdaptor.ViewHolder> {
    Context context;
    ArrayList<BookModel> bookLists;

    public BookAdaptor(Context context, ArrayList<BookModel> bookLists) {
        this.context = context;
        this.bookLists = bookLists;
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.book_item_list, parent, false);
        ViewHolder holder = new ViewHolder(view);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        BookModel targetBookItem = bookLists.get(position);
        int targetCoverImg = targetBookItem.getCoverImg();
        String targetTitle = targetBookItem.getTitle();
        String targetAuthor = targetBookItem.getAuthor();
        String targetDescription = targetBookItem.getDescription();

        holder.coverImg.setImageResource(targetCoverImg);
        holder.title.setText(targetTitle);
        holder.author.setText(targetAuthor);
        holder.description.setText(targetDescription);

        holder.btnSeeMore.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent temp = new Intent(context, BookInfoActivity.class);
                Resources resource = context.getResources();
                temp.putExtra(resource.getString(R.string.keyCoverImg), targetCoverImg);
                temp.putExtra(resource.getString(R.string.keyTitle), targetTitle);
                temp.putExtra(resource.getString(R.string.keyAuthor), targetAuthor);
                temp.putExtra(resource.getString(R.string.keyDescription), targetDescription);
                context.startActivity(temp);
            }
        });
    }

    @Override
    public int getItemCount() {
        return bookLists.size();
    }

    // Getting the UI Component for binding data
    public class ViewHolder extends RecyclerView.ViewHolder {
        ImageView coverImg;
        TextView title;
        TextView author;
        TextView description;
        Button btnSeeMore;

        public ViewHolder(View itemView) {
            super(itemView);

            coverImg = itemView.findViewById(R.id.bookCover);
            title = itemView.findViewById(R.id.bookTitle);
            author = itemView.findViewById(R.id.bookAuthor);
            description = itemView.findViewById(R.id.bookDescription);
            btnSeeMore = itemView.findViewById(R.id.btnSeeMore);
        }
    }
}
