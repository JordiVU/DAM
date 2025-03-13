package com.dam.nacho;

import java.util.Scanner;

public class Albufera {
    public static void main (String[] args)
    {
        Scanner sc = new Scanner(System.in);
        int casos, calc;

        do
        {
            casos = sc.nextInt();
            if(casos != 0) {
                calc = 0;

                for (int i = 0; i < casos; i++) {
                    int num1 = sc.nextInt();
                    int num2 = sc.nextInt();

                    calc = num1 - num2 + calc;
                }
                System.out.println(calc);
            }
        }
        while(casos != 0);
    }
}
