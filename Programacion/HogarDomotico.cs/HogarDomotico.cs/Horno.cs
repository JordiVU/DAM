using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase para controlar los hornos.
class Horno : DomoticoTemperatura
{
    public Horno(string nombre, bool encendido, int temperatura) :
        base(nombre, encendido, temperatura)
    {
    }

    // Getters y setters...
    public int GetTemperatura()
    {
        return temperatura;
    }
    public void SetTemperatura(int temperatura)
    {
        if (temperatura >= 0 && temperatura <= 250)
        {
            this.temperatura = temperatura;
        }
    }

    // Comprueba si esta encendido o no, y lo muestra...
    public override void Mostrar()
    {
        if (Consultar())
            Console.BackgroundColor = ConsoleColor.Green;
        else
            Console.BackgroundColor = ConsoleColor.Red;

        Console.Write(" ");
        Console.ResetColor();
        Console.WriteLine(" " + nombre + " " + temperatura + "ºC  ");
    }
}