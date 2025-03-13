using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Persona
{
    private string nombre;
    private int edad;

    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public override string ToString()
    {
        return nombre + ";" + edad;
    }
}