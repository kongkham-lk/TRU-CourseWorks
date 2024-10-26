package com.example.bookstoreapp;

import android.content.Context;
import android.content.Intent;
import android.content.res.Resources;
import android.graphics.PorterDuff;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;
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
        // Getting the specific component that will be repeated display on the custom recycle view
        View view = LayoutInflater.from(context).inflate(R.layout.book_item_list, parent, false);
        ViewHolder holder = new ViewHolder(view);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        // Get all the string array from resource String file
        BookModel targetBookItem = bookLists.get(position);
        int targetCoverImg = targetBookItem.getCoverImg();
        String targetTitle = targetBookItem.getTitle();
        String targetAuthor = targetBookItem.getAuthor();
        String targetDescription = targetBookItem.getDescription();
        int rating = targetBookItem.getRating();
        int totalReview = targetBookItem.getTotalReview();

        // binding data to each row of activity component as well as the onclick listener
        holder.coverImg.setImageResource(targetCoverImg);
        holder.title.setText(targetTitle);
        holder.author.setText(targetAuthor);
        for(int i = 0; i < rating; i++) // dynamically update star rating
            // turn rating star to yellow base on the rating number
            holder.rating[i].setColorFilter(ContextCompat.getColor(context, R.color.yellow), PorterDuff.Mode.SRC_IN);

        holder.totalReview.setText("(" + totalReview + ")");

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
        ImageView[] rating;
        TextView totalReview;
        TextView price;
        Button btnSeeMore;

        // getting the repeated section of activity component
        public ViewHolder(View itemView) {
            super(itemView);

            coverImg = itemView.findViewById(R.id.bookCover);
            title = itemView.findViewById(R.id.bookTitle);
            author = itemView.findViewById(R.id.bookAuthor);
            price = itemView.findViewById(R.id.bookPrice);
            btnSeeMore = itemView.findViewById(R.id.btnSeeMore);
            rating = new ImageView[]{
                    itemView.findViewById(R.id.star_01),
                    itemView.findViewById(R.id.star_02),
                    itemView.findViewById(R.id.star_03),
                    itemView.findViewById(R.id.star_04),
                    itemView.findViewById(R.id.star_05),
            };
            totalReview = itemView.findViewById(R.id.totalReview);
        }
    }
}
