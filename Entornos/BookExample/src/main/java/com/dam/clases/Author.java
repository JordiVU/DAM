package com.dam.clases;

import java.util.Arrays;

public class Author {
    private String name;
    private int yearBirth;
    private Book[] books = new Book[3];

    public Author(String name, int yearBirth, Book[] books)
    {
        Book[] b = new Book[3];
        b[0] = new Book("The lord of the Rings", 850, 13.50);
        b[1] = new Book("The lord of the Rings", 850, 13.50);
        b[2] = new Book("The hobbit", 345, 8.76);

        this.name = name;
        this.yearBirth = yearBirth;
        this.books = books;

        for(int i = 0; i < 3; i++) {
            this.books[i].setAuthor(this);
        }
    }

    public String getName()
    {
        return name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public int getYearBirth() {
        return yearBirth;
    }

    public void setYearBirth(int yearBirth) {
        this.yearBirth = yearBirth;
    }

    public void setBooks()
    {
        this.books = books;
    }

    public Book[] getBooks()
    {
        return books;
    }

    @Override
    public String toString() {
        return "Author: "
                + name + ", " +
                + yearBirth +
                "\n Libros:" + Arrays.toString(books);
    }
}
