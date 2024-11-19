package com.example.movieapp;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import androidx.core.content.ContextCompat;

import java.util.ArrayList;

public class MovieAdaptor extends RecyclerView.Adapter<MovieAdaptor.ViewHolder> {

    Context context;
    ArrayList<MovieModel> movieList;
    ArrayList<String> selectedMovieItemList;

    public MovieAdaptor(Context context, ArrayList<MovieModel> movieList) {
        this.context = context;
        this.movieList = movieList;
        selectedMovieItemList = new ArrayList<>();
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        // Getting the specific component that will be repeated display on the custom recycle view
        View view = LayoutInflater.from(context).inflate(R.layout.movie_item, parent, false);
        ViewHolder holder = new ViewHolder(view);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        MovieModel targetMovie = movieList.get(position);
        holder.title.setText(targetMovie.getTitle());
        holder.showTime.setText(targetMovie.getShowTime());
        holder.coverImage.setImageResource(targetMovie.getCoverImg());

        holder.itemView.setOnLongClickListener(new View.OnLongClickListener() {
            @Override
            public boolean onLongClick(View view) {
                String targetTitle = holder.title.getText().toString();
                if (selectedMovieItemList.size() > 0 && selectedMovieItemList.contains(targetTitle)) {
                    holder.itemContainer.setBackground(null);
                    selectedMovieItemList.remove(targetTitle);
                    toastSelectedMovie();
                } else if (selectedMovieItemList.size() == 2) {
                    Toast.makeText(context, "Cannot Select More Than 2 Movies!", Toast.LENGTH_SHORT).show();
                    return true; // Stop further execution
                } else {
                    selectedMovieItemList.add(targetMovie.getTitle());
                    holder.itemContainer.setBackground(ContextCompat.getDrawable(context, R.drawable.selected_item));
                    toastSelectedMovie();
                }
                return true;
            }
        });
    }

    @Override
    public int getItemCount() {
        return movieList.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        TextView title;
        TextView showTime;
        ImageView coverImage;
        View itemContainer;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);

            title = itemView.findViewById(R.id.movieTitle);
            showTime = itemView.findViewById(R.id.movieShowTime);
            coverImage = itemView.findViewById(R.id.movieCover);
            itemContainer = itemView.findViewById(R.id.itemContainer);
        }
    }

    private void toastSelectedMovie() {
        if (selectedMovieItemList.size() > 0) {
            StringBuilder toastMessage = new StringBuilder("Movie Selected:\n");
            for (int i = 0; i < selectedMovieItemList.size(); i++) {
                toastMessage.append(i == 1 ? ", '" : "'").append(selectedMovieItemList.get(i)).append("'");
            }

            Toast.makeText(context, toastMessage.toString(), Toast.LENGTH_SHORT).show();
        }
    }
}
