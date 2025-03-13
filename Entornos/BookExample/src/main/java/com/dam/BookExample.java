package com.dam;


import com.dam.clases.Author;
import com.dam.clases.Book;

public class BookExample
{
    public static void main(String[] args)
    {
        Book[] b = new Book[3];
        b[0] = new Book("The lord of the Rings", 850, 13.50);
        b[1] = new Book("The lord of the Rings", 850, 13.50);
        b[2] = new Book("The hobbit", 345, 8.76);  // Different author
        Author a = new Author("J.R.R. Tolkien", 1892, b);

        System.out.println(a);
        // The lord of the Rings, 850 pages, 13.50 eur, Tolkien
    }
}
