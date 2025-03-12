using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Trabajador
{
    string ss;
    string nombre;
    string telefono;

    public Trabajador(string ss, string nombre, string telefono)
    {
        this.ss = ss;
        this.nombre = nombre;
        this.telefono = telefono;
    }

    public override string ToString()
    {
        return nombre + " " + telefono;
    }
}