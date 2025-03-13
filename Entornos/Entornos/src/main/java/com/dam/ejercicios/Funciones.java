package com.dam.ejercicios;

public class Funciones {
    /**
     * Create a program called Palindrome with a function called isPalindrome. This function will take a string as
     * a parameter and return a boolean indicating if this string is a palindrome
     * (this is, a string that can be read the same backward as forward, ignoring upper or lower case, and whitespaces).
     * Test this function from the main function with the texts Hannah, Too hot to hoot and Java is the best language
     * (this last text is NOT a palindrome).
     **/
    public static boolean isPalindrome(String text)
    {
        boolean result = true;

        text = text.trim();

        String text2 = new StringBuilder(text).reverse().toString();

        if(text2.equals(text))
        {
            result = false;
        }

        return result;
    }
}
