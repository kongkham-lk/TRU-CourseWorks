package com.example.movieapp;

public class MovieModel {
    private String title;
    private String showTime;
    private int coverImg;

    public MovieModel(String title, String showTime, int coverImg) {
        this.title = title;
        this.showTime = showTime;
        this.coverImg = coverImg;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getShowTime() {
        return showTime;
    }

    public void setShowTime(String showTime) {
        this.showTime = showTime;
    }

    public int getCoverImg() {
        return coverImg;
    }

    public void setCoverImg(int coverImg) {
        this.coverImg = coverImg;
    }
}
