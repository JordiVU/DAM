using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Programa principal encargado de recibir las opciones del usuario para controlar
 * los diferentes elementos de un hogar domotico*/

class Program
{
    static void MenuOpciones()
    {
        Console.WriteLine("-------------------------------------------------" + 
            "-----------");
        Console.WriteLine("A/B Abrir/Cerrar Pta. Princ  | C/D Abrir/Cerrar Pta." +
            " Garaje");
        Console.WriteLine("E/F On/Off Luz Salón         |" + 
             " G/H On/Off Luz Cocina");
        Console.WriteLine("I/J On/Off Horno             |" + 
            " K/L Subir/Bajar Horno");
        Console.WriteLine("M/N On/Off Calefaccion       |" + 
            " O/P Subir/Bajar Calefaccion");
        Console.WriteLine("Q. Apagar Todo               |" + 
            " S. Salir");
    }
    static void Main()
    {
        Console.CursorVisible = false;
        GestorDomotico gestor = new GestorDomotico();
        ConsoleKeyInfo opcion;
        Horno regularH;
        Calefaccion regularC;

        Console.SetCursorPosition(0, 15);
        MenuOpciones();

        do
        {
            Console.SetCursorPosition(0, 0);
            gestor.MostrarEstado();

            opcion = Console.ReadKey(true);

            switch (opcion.Key)
            {
                case ConsoleKey.A:
                    ((Puerta)gestor.GetElemento(0)).AbrirPuerta();
                    break;

                case ConsoleKey.B:
                    ((Puerta)gestor.GetElemento(0)).CerrarPuerta();
                    break;

                case ConsoleKey.C:
                    ((Puerta)gestor.GetElemento(4)).AbrirPuerta();
                    break;

                case ConsoleKey.D:
                    ((Puerta)gestor.GetElemento(4)).CerrarPuerta();
                    break;

                case ConsoleKey.E:
                    ((Luz)gestor.GetElemento(2)).Encender();
                    break;

                case ConsoleKey.F:
                    ((Luz)gestor.GetElemento(2)).Apagar();
                    break;

                case ConsoleKey.G:
                    ((Luz)gestor.GetElemento(3)).Encender();
                    break;

                case ConsoleKey.H:
                    ((Luz)gestor.GetElemento(3)).Apagar();
                    break;

                case ConsoleKey.I:
                    ((Horno)gestor.GetElemento(1)).Encender();
                    break;

                case ConsoleKey.J:
                    ((Horno)gestor.GetElemento(1)).Apagar();
                    break;

                case ConsoleKey.K:
                    regularH = (Horno)gestor.GetElemento(1);
                    regularH.SetTemperatura(regularH.GetTemperatura() + 1);
                    break;

                case ConsoleKey.L:
                    regularH = (Horno)gestor.GetElemento(1);
                    regularH.SetTemperatura(regularH.GetTemperatura() - 1);
                    break;

                case ConsoleKey.M:
                    ((Calefaccion)gestor.GetElemento(5)).Encender();
                    break;

                case ConsoleKey.N:
                    ((Calefaccion)gestor.GetElemento(5)).Apagar();
                    break;

                case ConsoleKey.O:
                    regularC = (Calefaccion)gestor.GetElemento(5);
                    regularC.SetTemperatura(regularC.GetTemperatura() + 1);
                    break;

                case ConsoleKey.P:
                    regularC = (Calefaccion)gestor.GetElemento(5);
                    regularC.SetTemperatura(regularC.GetTemperatura() - 1);
                    break;

                case ConsoleKey.Q:
                    gestor.ApagarTodo();
                    break;

                case ConsoleKey.S:
                    break;

            }
        }
        while (ConsoleKey.S != opcion.Key);
    }
}
