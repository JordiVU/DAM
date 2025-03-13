package com.dam.ejercicios;
import java.util.Scanner;

public class Excepciones {
    /**
     * Create a program called CalculateDensity that asks the user to type a weight (in grams) and a volume (in liters).
     * Then, the program must output the density, which is calculated by dividing weight / volume. The program must
     * catch every type of possible exception: NumberFormatException and ArithmeticException whenever they can be thrown.
     * You can only use Scanner.nextLine method to get the user input in this exercise.
     **/
    public static void CalculateDensity() {
        Scanner sc = new Scanner(System.in);
        String texto1, texto2;
        int gramos, volumen;
        float calc;
        boolean error = false;

        do {
            try {
                // El usuario introduce los datos en string y los pasamos a entero.
                System.out.println("Escribe un peso en gramos:");
                texto1 = sc.nextLine();
                gramos = Integer.parseInt(texto1);

                System.out.println("Escribe un volumen en litros:");
                texto2 = sc.nextLine();
                volumen = Integer.parseInt(texto2);

                // Calculamos el resultado
                calc = (float) gramos / volumen;

                // Mostramos el resultado
                System.out.println(calc);

            } catch (NumberFormatException eFormat) {
                // Excepcion si introduce un numero mal...
                System.out.println("Error al introducir el numero:" + eFormat.getMessage());
                error = true;

            } catch (ArithmeticException eCalc) {
                // Excepcion si calcula arimeticamente mal...
                System.out.println("Error al realizar la operacion:" + eCalc.getMessage());
                error = true;
            } catch (Exception e) {
                // Excepcion general...
                System.out.println("Error TERROR: " + e.getMessage());
                error = true;
            }
        }
        // Repetimos el bucle si ha saltado una excepcion...
        while(error);
        }
}
