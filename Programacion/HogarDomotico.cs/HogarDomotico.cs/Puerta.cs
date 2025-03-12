using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase que gestiona las puerta.
class Puerta : ElementoDomotico
{
    protected bool abierta;

    public Puerta()
    {
        abierta = false;
    }

    public Puerta(string nombre, bool abierta) : base(nombre)
    {
        this.abierta = abierta;
    }
    
    public void AbrirPuerta()
    {
        abierta = true;
    }

    public void CerrarPuerta()
    {
        abierta = false;
    }

    // Getters y setters...
    public bool GetPuerta()
    {
        return abierta;
    }
    public void SetPuerta(bool abierta)
    {
        this.abierta = abierta;
    }

    // ToString modificado...
    public override void Mostrar()
    {
        if (abierta)
            Console.BackgroundColor = ConsoleColor.Green;
        else
            Console.BackgroundColor = ConsoleColor.Red;

        Console.Write(" ");
        Console.ResetColor();
        Console.WriteLine(" " + nombre);
    }
}