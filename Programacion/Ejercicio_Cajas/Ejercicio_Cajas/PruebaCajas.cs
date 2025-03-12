using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PruebaCajas
{
    private int capacidad;

    public PruebaCajas()
    {
        capacidad = 0;
    }

    public PruebaCajas(int capacidad)
    {
        this.capacidad = capacidad;
    }

    public int GetCapacidad()
    {
        return capacidad;
    }

    public void SetCapacidad(int capacidad)
    {
        if (capacidad < 250)
        {
            this.capacidad = capacidad;
        }
        else
        {
            throw new Exception("Valor no valido!");
        }
    }

    public void MostrarCajas()
    {
        Console.WriteLine("Caja de " + capacidad + " l");
    }
}