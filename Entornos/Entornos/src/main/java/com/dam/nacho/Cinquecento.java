package com.dam.nacho;

import java.util.Scanner;

public class Cinquecento {
    public static void main (String[] args)
    {
        Scanner sc = new Scanner(System.in);

        int casos;

        casos = sc.nextInt();

        for(int i = 0; i < casos; i++)
        {
            int anyo = sc.nextInt();
            if(anyo % 100 == 0)
            {
                System.out.println(anyo / 100);
            }
            else
            {
                System.out.println(anyo / 100 + 1);
            }
        }
    }
}
