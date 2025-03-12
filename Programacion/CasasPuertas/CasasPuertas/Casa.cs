using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Casa
{
    private string nombre;
    private Puerta[] puertas;

    public Casa(string nombre, Puerta[] puertas)
    {
        this.nombre = nombre;
        this.puertas = puertas;
        for (int i = 0; i < puertas.Length; i++)
        {
            this.puertas[i].SetCasa(this);
        }
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public string GetNombre()
    {
        return this.nombre;
    }

    public void MostrarCasa()
    {
        Console.WriteLine("Nombre: " + nombre);
        foreach(Puerta puerta in puertas)
        {
            Console.WriteLine("Puerta de {0} x {1}",
                puerta.GetAncho(), puerta.GetAlto());
        }
    }
}