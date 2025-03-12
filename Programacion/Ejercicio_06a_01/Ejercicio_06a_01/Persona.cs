using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Persona
{   
    protected string nombre;    

    public Persona()
    {
        nombre = "";
    }

    public Persona(string p)
    {
        nombre = p;
    }
    public string Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            nombre = value;
        }
    }

    public void Saludo(string saludar)
    {
        Console.WriteLine(saludar);
    }

    public void Saludo()
    {
        Console.WriteLine("Hola, soy " + nombre);
    }
}
