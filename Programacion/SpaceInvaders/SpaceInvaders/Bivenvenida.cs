using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Mensaje para la pantalla de bienvenida.
class Bienvenida
{
    private bool salir;

    // Lanza la pantalla de bienvenida, y se guarda si 
    // queremos salir o jugar en la variable "salir"
    public void Lanzar()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        for (int i = 0; i < 5; i++)
            Console.WriteLine();
        Console.WriteLine("*************************************************************************************************");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine(" _____ ______   ___   _____  _____   _____  _   _  _   _   ___  ______  _____ ______  _____ \r");
        Console.WriteLine("/  ___|| ___ \\ / _ \\ /  __ \\|  ___| |_   _|| \\ | || | | | / _ \\ |  _  \\|  ___|| ___ \\/  ___|\r");
        Console.WriteLine("\\ `--. | |_/ // /_\\ \\| /  \\/| |__     | |  |  \\| || | | |/ /_\\ \\| | | || |__  | |_/ /\\ `--. \r");
        Console.WriteLine(" `--. \\|  __/ |  _  || |    |  __|    | |  | . ` || | | ||  _  || | | ||  __| |    /  `--. \\\r");
        Console.WriteLine("/\\__/ /| |    | | | || \\__/\\| |___   _| |_ | |\\  |\\ \\_/ /| | | || |/ / | |___ | |\\ \\ /\\__/ /\r");
        Console.WriteLine("\\____/ \\_|    \\_| |_/ \\____/\\____/   \\___/ \\_| \\_/ \\___/ \\_| |_/|___/  \\____/ \\_| \\_|\\____/ \r");
        Console.WriteLine();
        Console.WriteLine("Pulse Intro para jugar o Esc para salir");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("*************************************************************************************************");

        Console.ResetColor();

        ConsoleKeyInfo tecla = Console.ReadKey(true);
        if (tecla.Key == ConsoleKey.Escape)
            salir = true;
        else if (tecla.Key == ConsoleKey.Enter)
            salir = false;
        else
        {
            Console.WriteLine("Opción incorrecta. Saliendo del juego");
            salir = true;
        }
    }

    // Obtiene si queremos salir del juego
    public bool GetSalir()
    {
        return salir;
    }
}