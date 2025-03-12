using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PersonaInglesa : Persona
{

    public PersonaInglesa()
    {
        Nombre = "";
    }

    public PersonaInglesa(string nombre) : base(nombre)
    {
    }

    public new void Saludo()
    {
        Console.WriteLine("Hi, i am " + nombre);
    }
}
