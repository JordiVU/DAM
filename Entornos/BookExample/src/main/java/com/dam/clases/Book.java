package com.dam.clases;

public class Book {
    private String title;
    private int numPages;
    private double price;
    private Author author;

    public Book(String title, int numPages, double price)
    {
        this.title = title;
        this.numPages = numPages;
        this.price = price;
    }

    public String getTitle()
    {
        return title;
    }

    public Author getAuthor()
    {
        return author;
    }

    public void setAuthor(Author author)
    {
        this.author = author;
    }

    @Override
    public String toString() {
        return "Book{" +
                "price=" + price +
                ", numPages=" + numPages +
                ", title='" + title + '\'' +
                '}';
    }
}
