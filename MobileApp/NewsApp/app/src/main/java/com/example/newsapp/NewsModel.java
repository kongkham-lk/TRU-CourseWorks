package com.example.newsapp;

public class NewsModel {
    private String urlToImage;
    private String title;
    private String author;
    private String publishedAt;
    private String link;

    public NewsModel(String title, String publishedAt, String author, String link, String urlToImage) {
        this.title = title;
        this.publishedAt = publishedAt;
        this.author = author;
        this.link = link;
        this.urlToImage = urlToImage;
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

    public String getLink() {
        return link;
    }

    public void setLink(String link) {
        this.link = link;
    }

    public String getUrlToImage() {
        return urlToImage;
    }

    public void setUrlToImage(String urlToImage) {
        this.urlToImage = urlToImage;
    }

    public String getPublishedAt() {
        return publishedAt;
    }

    public void setPublishedAt(String publishedAt) {
        this.publishedAt = publishedAt;
    }

}
