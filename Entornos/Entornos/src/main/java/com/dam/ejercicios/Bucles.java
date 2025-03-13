package com.dam.ejercicios;

public class Bucles
{
    public static void BucleFor()
    {
        int espacios = 0, asteriscos = 5;

        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < espacios; j++)
            {
                System.out.print(" ");
            }

            for(int j = 0; j < asteriscos; j++)
            {
                System.out.print("*");
            }

            espacios++;
            asteriscos--;
            System.out.println();
        }
    }
}
