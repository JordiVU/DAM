using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Hardware
{
    public static void BorrarPantalla()
    {
        for (byte i = 0; i < 25; i++)
            Console.WriteLine();
    }

    public static void UnMetodo()
    {
        Console.WriteLine("Pulsa Intro para borrar");
        Console.ReadLine();
        BorrarPantalla();   // Misma clase, no hace falta "Hardware."         
        Console.WriteLine("Borrado!");
    }

    public static void EscribirCentrado(string texto)
    {
        int x, y;

        x = Console.WindowWidth / 2;
        y = Console.WindowHeight / 2;
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);
    }
    public void EscribirCentrado2(string texto)
    {
        int x, y;

        x = Console.WindowWidth / 2;
        y = Console.WindowHeight / 2;
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);
    }
}