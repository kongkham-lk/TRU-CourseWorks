package com.example.bookstoreapp;

public class BookModel {
    private int coverImg;
    private String title;
    private String author;
    private String description;
    private String price;
    private int rating;
    private int totalReview;

    public BookModel(int coverImg, String title, String author, String description, String price, int rating, int totalRating) {
        this.coverImg = coverImg;
        this.title = title;
        this.author = author;
        this.description = description;
        this.price = price;
        this.rating = rating;
        this.totalReview = totalRating;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public int getCoverImg() {
        return coverImg;
    }

    public void setCoverImg(int coverImg) {
        this.coverImg = coverImg;
    }

    public String getPrice() {
        return price;
    }

    public void setPrice(String price) {
        this.price = price;
    }

    public int getRating() {
        return rating;
    }

    public void setRating(int rating) {
        this.rating = rating;
    }

    public int getTotalReview() {
        return totalReview;
    }

    public void setTotalReview(int totalRating) {
        this.totalReview = totalRating;
    }
}
