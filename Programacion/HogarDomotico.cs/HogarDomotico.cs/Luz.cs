using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase para controlar las luces.
class Luz : ElementoDomotico, IEncendible
{
    protected bool encendido;

    public Luz()
    {
        encendido = false;
    }
    public Luz(string nombre, bool encendido) : base(nombre)
    {
        this.encendido = encendido;
    }

    public void Encender()
    {
        encendido = true;
    }
    public void Apagar()
    {
        encendido = false;
    }
    public bool Consultar()
    {
        return encendido;
    }

    // Getters y setters...
    public bool GetEncendido()
    {
        return encendido;
    }
    public void SetEncendido(bool encendido)
    {
        this.encendido = encendido;
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
        Console.WriteLine(" " + nombre);
    }
}