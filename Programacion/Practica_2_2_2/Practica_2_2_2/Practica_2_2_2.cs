//Programa que nos ayudara ahorrar hasta lo que indique el usuario

using System;

class Ahorros
{
    static void Main()
    {
        int total, ingreso, ahorro = 0;

        Console.WriteLine("Indica el total a ahorrar:");
        total = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine("Indica la cantidad que ingresas:");
            ingreso = Convert.ToInt32(Console.ReadLine());
            ahorro = ingreso + ahorro;
        }
        while (ahorro < total);
        Console.WriteLine("Has ahorrado " + ahorro);
    }
}