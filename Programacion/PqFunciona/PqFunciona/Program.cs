// Programa que le pide al usuario un numero y hace un hexagono
using System;

class Hexagono
{
    static void Main()
    {
        int lado, espacios, asteriscos, filas;
        char simbolo;

        Console.WriteLine("Altura del Hexagono:");
        lado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Simbolo de relleno:");
        simbolo = Convert.ToChar(Console.ReadLine());
        espacios = lado - 1;
        asteriscos = lado;
        filas = 2 * lado - 1;

        for (int i = 1; i <= filas; i++)
        {
            for (int b = 1; b <= espacios; b++)
            {
                Console.Write(" ");
            }
            for (int a = 1; a <= asteriscos; a++)
            {
                Console.Write(simbolo);
            }
            Console.WriteLine();
            if (i < lado)
            {
                espacios--;
                asteriscos++;
                asteriscos++;
            }
            else
            {
                espacios++;
                asteriscos--;
                asteriscos--;
            }
        }
    }
}
