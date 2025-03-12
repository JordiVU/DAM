using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Moto : Vehiculo
{
    public Moto()
    {
        marca = "";
        modelo = "";
        cilindrada = 0;
        potencia = 0;
        cantidadDeRuedas = 2;
    }

    public Moto(string m, string mdl, int c, float p)
    {
        marca = m;
        modelo = mdl;
        cilindrada = c;
        potencia = p;
    }
}
