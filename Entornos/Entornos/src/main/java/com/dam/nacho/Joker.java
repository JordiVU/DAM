package com.dam.nacho;

import java.util.Arrays;
import java.util.Scanner;

public class Joker {
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        int casos;
        String texto;
        boolean gana;

        casos = sc.nextInt();
        sc.nextLine();
        for(int i = 0; i < casos; i++)
        {
            gana = true;
            texto = sc.nextLine();
            String[] numeros = texto.split(" ");

            char[] num1 = numeros[0].toCharArray();
            Arrays.sort(num1);

            char[] num2 = numeros[1].toCharArray();
            Arrays.sort(num2);

            for(int j = 0; j < num1.length; j++)
            {
                if(num1[j] != num2[j])
                {
                    gana = false;
                }
            }
            if(gana)
            {
                System.out.println("GANA");
            }
            else
            {
                System.out.println("PIERDE");
            }
        }
    }
}
