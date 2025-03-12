using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lanza la pantalla de bienvenida, y se guarda si
class Bienvenida
{
    private bool salir;

    public void Lanzar()
    {
        ConsoleKeyInfo tecla;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("______  _____  _____  _   _  _   _  _____  _   _  _____ ______  _____");
        Console.WriteLine("| ___ \\|_   _||  ___|| \\ | || | | ||  ___|| \\ | ||_   _||  _  \\|  _  |");
        Console.WriteLine("| |_/ /  | |  | |__  |  \\| || | | || |__  |  \\| |  | |  | | | || | | |");
        Console.WriteLine("| ___ \\  | |  |  __| | . ` || | | ||  __| | . ` |  | |  | | | || | | |");
        Console.WriteLine("| |_/ / _| |_ | |___ | |\\  |\\ \\_/ /| |___ | |\\  | _| |_ | |/ / \\ \\_/ /");
        Console.WriteLine("\\____/  \\___/ \\____/ \\_| \\_/ \\___/ \\____/ \\_| \\_/ \\___/ |___/   \\___/ ");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Tendras que manejar a un arqueólogo que debe" +
            "ir descubriendo los sarcófagos de una cripta sin \r\n que le atrapen" +
            " las momias que hay deambulando por los pasillos.");
        // Completa aquí el código para mostrar el título
        // e instrucciones del juego
        Console.ResetColor();
        do
        {
            tecla = Console.ReadKey(true);
            if (tecla.Key == ConsoleKey.Escape)
                salir = true;
            else if (tecla.Key == ConsoleKey.Enter)
                salir = false;
        }
        while (tecla.Key != ConsoleKey.Escape && tecla.Key != ConsoleKey.Enter);
    }
    // Obtiene si queremos salir del juego
    public bool GetSalir()
    {
        return salir;
    }
}