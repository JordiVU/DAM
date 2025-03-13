package com.dam.nacho;

import java.util.Scanner;

public class Ajedrez {
    public static void main (String[] args)
    {
        Scanner sc = new Scanner(System.in);

        int casos;
        String caracter, espacios = " ";

        casos = sc.nextInt();
        caracter = sc.nextLine();


        for(int i = 0; i < 8 * casos; i++)
        {
            if(i == 0)
            {
                System.out.println("|----------------|");
            }
            else if(i == 8 * casos)
            {
                System.out.println("|----------------|");
            }
            System.out.print("|");
            for (int j = 0; j < casos * 4; j++)
            {
                for(int b = 0; b < casos; b++)
                {
                    if(b % 2 == 0)
                        System.out.print(espacios);
                    else
                        System.out.print(caracter);
                }
                for(int b = 0; b < casos; b++)
                {
                    if(b % 2 == 0)
                        System.out.print(caracter);
                    else
                        System.out.print(espacios);
                }
            }
            System.out.print("|");
            System.out.println();
        }
    }
}
