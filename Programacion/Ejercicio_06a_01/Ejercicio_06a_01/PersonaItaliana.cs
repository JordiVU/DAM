using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PersonaItaliana : Persona
{

    public PersonaItaliana()
    {
        Nombre = "";
    }

    public PersonaItaliana(string nombre) : base(nombre)
    {
    }

    public new void Saludo()
    {
        Console.WriteLine("Ciao ");
    }
}
