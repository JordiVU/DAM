package com.dam.ejercicios;

import java.util.Scanner;

public class Control {

    public static void GroupPeople(){
        /**
         * Create a program called GroupPeople that asks the user to enter how many people is going to attend
         * to a conference. The program must create groups of (preferably) 50 people.
         * Whenever this is not possible, then it will attempt to create groups of 10 people,
         * and finally it will create groups of 1 person. The program must output how many groups of
         * each category are necessary. For instance, if 78 people are going to attend to the conference,
         * then we need 1 group of 50 people, 2 groups of 10 people and 8 groups of 1 people.
         */
        Scanner sc = new Scanner(System.in);

        int groups, cincuenta = 0, diez = 0, uno = 0;

        System.out.println("Cantidad de personas:");
        groups = sc.nextInt();
        do{
            // Comprobacion si los grupos son mas o igual que 50.
            if(groups >= 50)
            {
                groups = groups - 50;
                // Sumamos un grupo a 50 y restamos 50 personas.
                cincuenta++;
            }
            // Comrpobacio si los grupos son mas o igual que 10, pero menor que 50.
            else if(groups >= 10)
            {
                groups = groups - 10;
                // Sumamos un grupo a 10 y restamos 10 personas.
                diez++;
            }
            // El resto de personas que no entran en el grupo de 10 ni 50.
            else
            {
                groups = groups - 1;
                // Sumas un grupo a 1 y restamos 1 persona.
                uno++;
            }
        }
        while(groups != 0);

        // Mostrar por pantalla el resultado.
        System.out.printf("Habran %d grupo de 50, %d grupo de 10 y %d grupo de uno",
                cincuenta, diez, uno);
    }

    public static void GramOunceConverter2(){
        /**
         * Create a program called GramOunceConverter2 that will be an improved version of a
         * previous exercise. In this case, the user will type a weight (float), and a unit
         * (g for grams, o for ounces). Then, depending on the unit chosen, the program will
         * convert the weight to the opposite unit. For instance, if the user types a weight
         * of 33 and chooses o as unit, then the program must convert 33 ounces to grams.
         * You must solve this program using a switch structure.
         * If the unit is other than g or o, then the program must output an error message:
         * "Unexpected unit", with no final result.
         */

        Scanner sc = new Scanner(System.in);

        float weight, calc;
        String unit;

        //Pedimos al usuario la cantidad y el tipo de unidad.
        System.out.println("Escribe la cantidad:");
        weight = sc.nextFloat();
        System.out.println("Escribe el tipo de unidad:");
        unit = sc.next();

        // Si es una g pasamos de gramos a onzas.
        if(unit.equals("g"))
        {
            calc = weight / (float)28.35;
            System.out.println(calc);
        }
        // Si es una o pasamos de onzas a gramos.
        else if(unit.equals("o"))
        {
            calc = weight * (float)28.35;
            System.out.println(calc);
        }
        // Cualquier otra letra no es aceptada.
        else
        {
            System.out.println("Unexpected unit");
        }
    }
    public static void MarckCheck(){

        Scanner sc = new Scanner(System.in);

        int op1, op2, op3;

        op1 = sc.nextInt();
        op2 = sc.nextInt();
        op3 = sc.nextInt();

        // Check if they are greater than or equal to 4.
        if(op1 >= 4 && op2 >= 4 && op3 >= 4)
        {
            System.out.println("All marks are greater or equal than 4");
        }
        // Check if they are less than or equal to 5.
        else if(op1 <= 4 && op2 <= 4 && op3 <= 4)
        {
            System.out.println("No mark is greater or equal than 4");
        }
        // Check if they
        else
        {
            System.out.println("Some marks are not greater or equal than 4");
        }
    }
}
