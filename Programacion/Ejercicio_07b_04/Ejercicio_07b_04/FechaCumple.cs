using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FechaCumple
{
    int dia, mes, anyo;

    public FechaCumple(int dia, int mes, int anyo)
    {
        this.dia = dia;
        this.mes = mes;
        this.anyo = anyo;
    }

    public override bool Equals(object? obj)
    {
        return obj is FechaCumple cumple &&
               dia == cumple.dia &&
               mes == cumple.mes;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(dia, mes);
    }
}