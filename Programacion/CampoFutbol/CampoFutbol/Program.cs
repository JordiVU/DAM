//Prorgraa

using System;

class Futbol
{
    static void Main()
    {
        int lineas, tamanyo, campos;
        Console.WriteLine("Cantidad de datos:");
        lineas = Convert.ToInt32(Console.ReadLine());
        do
        {
            Console.WriteLine("Tamaño del campo:");
            tamanyo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Estimacion en campos de futbol:");
            campos = Convert.ToInt32(Console.ReadLine());
            if (tamanyo >= (4050 * campos) || tamanyo <= (10800 * campos))
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        while (lineas != 0);
    }
}