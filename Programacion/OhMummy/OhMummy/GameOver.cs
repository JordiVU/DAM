using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase para mostrar el perder
class GameOver
{
    public void Lanzar()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("______ _________________ _____ _____ _____ _____ ");
        Console.WriteLine("| ___ \\  ___| ___ \\  _  \\_   _/  ___|_   _|  ___|");
        Console.WriteLine("| |_/ / |__ | |_/ / | | | | | \\ `--.  | | | |__  ");
        Console.WriteLine("|  __/|  __||    /| | | | | |  `--. \\ | | |  __| ");
        Console.WriteLine("| |   | |___| |\\ \\| |/ / _| |_/\\__/ / | | | |___ ");
        Console.WriteLine("\\_|   \\____/\\_| \\_|___/  \\___/\\____/  \\_/ \\____/ ");
        Console.WriteLine("---------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("*Pulsa cualquier tecla para volver a la pantalla de inicio*");
        Console.ResetColor();
        Console.ReadKey(true);
    }

}