package com.dam.ejercicios;
import java.util.Scanner;

public class Enums {

    /**
     * Create a program called MonthEnum.java that defines an enum to store the months
     * of the year. Then, ask the user to type a month and tell him/her the number of days of this month
     * (we assume that February has 28 days).
     */
    enum meses { ENERO, FEBRERO, MARZO, ABRIL, MAYO, JUNIO, JULIO, AGOSTO, SEPTIEMBRE, OCTUBRE, NOVIEMBRE, DICIEMBRE };

    public static void MountEnum()
    {
        Scanner sc = new Scanner(System.in);

        System.out.println("Mes ha elegir:");
        meses mes = meses.valueOf(sc.nextLine());
        if(mes.ordinal() % 2 == 0 && mes != meses.FEBRERO && mes != meses.AGOSTO)
        {
            System.out.println("Tiene 30 dias");
        }
        else if(mes == meses.FEBRERO)
        {
            System.out.println("Tiene 28 dias.");
        }
        else
        {
            System.out.println("Tiene 31 dias.");
        }

    }
}
