package com.dam.nacho;
import java.util.Scanner;

public class Romanos {

    public static void EscudosRomanos() {
        Scanner sc = new Scanner(System.in);
        int calc, raiz, num, legionarios;

        do {
            num = sc.nextInt();

            if(num != 0) {
                legionarios = num;
                calc = 0;
                while (legionarios > 0) {
                    raiz = (int) Math.sqrt(legionarios);
                    legionarios = legionarios - raiz * raiz;
                    calc = (raiz * raiz) + (raiz * 4) + calc;
                }
                System.out.println(calc);
            }
        }
        while (num != 0);
    }
}
