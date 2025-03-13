package com.dam.ejercicios;
import java.util.Scanner;
import java.util.Arrays;

public class EjerciciosString {
    public static void SortJoin()
    {
        Scanner sc = new Scanner(System.in);
        String texto;

        System.out.println("Escribe nombres separados por espacios:");
        texto = sc.nextLine();
        String[] partes = texto.split(" ");

        Arrays.sort(partes);
        System.out.println(String.join(",", partes));
    }
}
