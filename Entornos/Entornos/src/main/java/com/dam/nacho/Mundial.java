package com.dam.nacho;

import java.util.Scanner;


public class Mundial {
    public static void main ( String[] args)
    {
        Scanner sc = new Scanner(System.in);

        int casos;

        casos = sc.nextInt();

        for(int i = 0; i < casos; i++)
        {
            int equipo = sc.nextInt();
            int num1 = sc.nextInt();
            int num2 = sc.nextInt();
            int num3 = sc.nextInt();
            int num4 = sc.nextInt();
            int num5 = sc.nextInt();
            int num6 = sc.nextInt();

            int calc = num1 + num2 + num3 + num4 + num5 + num6;
            System.out.println(equipo - calc);
        }
    }
}
