package com.dam.ejercicios;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
Create a project called CarIDCheck that asks the user to enter a cad id, and checks if it's made of 4 digits followed
 by 3 uppercase letters. We are not going to check if these letters are vowels or not, we just check if
 they are uppercase.
 **/
public class RegularExpresions {
    public static void CarIDCheck(String text)
    {
        // Creamos el criterio...
        Pattern p = Pattern.compile("^\\d\\d\\d\\d[A-Z][A-Z][A-Z]$");

        // Asignamos el criterio al texto...
        Matcher m = p.matcher(text);

        // Buscamos que el texto cumpla el criterio...
        if(m.find())
            System.out.println("Todo perfe crack");
        else
            System.out.println("ERROR TERROR");
    }

    public static void CarIDCheckX(String text)
    {
        // Creamos el criterio...
        Pattern p = Pattern.compile("^\\d{4}[A-Z]{3}$");

        // Asignamos el criterio al texto...
        Matcher m = p.matcher(text);

        // Buscamos que el texto cumpla el criterio...
        if(m.find())
            System.out.println("Todo perfe crack");
        else
            System.out.println("ERROR TERROR");
    }

    /**
     * Create a program called EmailChecker that asks the user to enter an e-mail and checks if it's valid:
     * - Alphanumeric characters (at least one), followed by
     * - @ symbol and then
     * - One or more alphanumeric characters
     * - A dot
     * - One or more alphanumeric characters
     * @param email
     */
    public static void EmailChecker(String email)
    {
        Pattern p = Pattern.compile("^\\w{1,}[@]\\w{1,}[.]\\w{1,}");
        Matcher m = p.matcher(email);

        // Buscamos que el texto cumpla el criterio...
        if(m.matches())
            System.out.println("Todo perfe crack");
        else
            System.out.println("ERROR TERROR");
    }

    public static void EmailCheckerX(String email)
    {
        // Creamos el criterio...
        Pattern p = Pattern.compile("^\\w{1,}[@](gmail|hotmail|outlook){1,}[.](com|es|net)");

        // Asignamos el criterio al email...
        Matcher m = p.matcher(email);

        // Comprobamos que el texto cumpla el criterio...
        if(m.matches())
            System.out.println("Todo perfe crack");
        else
            System.out.println("ERROR TERROR");
    }
}
