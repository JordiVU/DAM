package com.dam.ejercicios;

/**
 * Create a program called PalindromeRecursive with a function called isPalindrome that receives a string
 * (with only alphabetical letters from a to z in lower case) and recursively determines if this string is palindrome
 * or not, returning a boolean with the result. Try it with the same input values suggested for Exercise 1.
 **/

public class Recursividad {
    public static boolean Palindromo(String texto)
    {
        boolean resultado;

        // Convertimos el textos en minuscula y quitamos los espacios.
        texto = texto.toLowerCase().replace(" ", "");

        // Caso base, si es menor o igual devuelve true
        if(texto.length() <= 1)
            resultado = true;
        // Caso base, si es distinto el primer numero con el ultimo devuelve false
        else if (texto.charAt(0) != texto.charAt(texto.length() - 1))
            resultado = false;
        // Si ningun caso base se cumple, seguimos recortando el texto y haciendo llamadas.
        else
            resultado = Palindromo(texto.substring(1, texto.length() - 1));

        return resultado;
    }
}
