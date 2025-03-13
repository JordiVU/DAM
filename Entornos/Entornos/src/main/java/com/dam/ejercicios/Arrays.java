package com.dam.ejercicios;

import java.util.Scanner;

public class Arrays
{
    public static void ArrayEncontrar(int[] numeros, int busqueda) {
        boolean found = false;
        int i = 0;

        while (!found && i < numeros.length) {
            if (numeros[i] == busqueda) {
                found = true;
            } else {
                i++;
            }
        }

        if (found) {
            System.out.println("Number found at position " + i);
        } else {
            System.out.println("Number not found");
        }
    }

    public static void ArrayContador(int[] numeros, int numContar)
    {
        int counter = 0;

        for (int j = 0; j < numeros.length; j++) {
            if (numeros[j] == numContar) {
                counter++;
            }
        }

        System.out.println("Numbe 15 has been found " + counter + " times");
    }

    public static void ArrayMaximo(int[] numeros)
    {
        int maximum = numeros[0];
        for (int e = 1; e < numeros.length; e++) {
            if (numeros[e] > maximum) {
                maximum = numeros[e];
            }
        }

        System.out.println("The maximum is " + maximum);
    }

    /**
     * Create a program called MatrixAddition that asks the user to enter two bidimensional matrices or tables of
     * 3 rows and columns, and then prints the result of adding them. In order to add two matrices, you must do it
     * cell by cell:
      */
    public static void MatrixAddition()
    {
        Scanner sc = new Scanner(System.in);

        int[][] matriz1 = new int[3][3];
        int[][] matriz2 = new int[3][3];
        int[][] result = new int[3][3];
        int contador = 1;

        // Pedir al usuario que rellene la primera matriz
        System.out.println("Primera matriz:");
        for(int i = 0; i < matriz1.length; i++)
        {
            System.out.println(contador + "º Fila:");
            for(int j = 0; j < matriz1[i].length; j++)
            {
                matriz1[i][j] = sc.nextInt();
            }
            contador++;
            System.out.println();
        }

        contador = 1;
        // Pedir al usuario que rellene la segunda matriz.
        System.out.println("Segunda matriz:");
        for(int i = 0; i < matriz2.length; i++)
        {
            System.out.println(contador + "º Fila:");
            for(int j = 0; j < matriz2[i].length; j++)
            {
                matriz2[i][j] = sc.nextInt();
            }
            contador++;
            System.out.println();
        }

        // Calcular la suma de las matrices.
        for(int i = 0; i < result.length; i++)
        {
            for(int j = 0; j < result[i].length; j++)
            {
                result[i][j] = matriz1[i][j] + matriz2[i][j];
                System.out.print(result[i][j] + " ");
            }
            System.out.println();
        }
    }
}
