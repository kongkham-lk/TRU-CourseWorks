package com.example.newsapp;

public class NewsModel {
    private int Img;
    private String title;
    private String author;
    private String publishedTime;
    private String sourceLink;

    public NewsModel(String title, String publishedTime, String author, String sourceLink, int Img) {
        this.title = title;
        this.publishedTime = publishedTime;
        this.author = author;
        this.sourceLink = sourceLink;
        this.Img = Img;
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

    public String getSourceLink() {
        return sourceLink;
    }

    public void setSourceLink(String sourceLink) {
        this.sourceLink = sourceLink;
    }

    public int getImg() {
        return Img;
    }

    public void setImg(int img) {
        this.Img = img;
    }

    public String getPublishedTime() {
        return publishedTime;
    }

    public void setPublishedTime(String publishedTime) {
        this.publishedTime = publishedTime;
    }
}
