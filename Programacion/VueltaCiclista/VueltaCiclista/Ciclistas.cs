using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase encargada de gestionar la informacion de los ciclistas.
class Ciclistas
{
    private int dorsal;
    private string nombre;
    private string equipo;

    public Ciclistas(int dorsal, string nombre, string equipo)
    {
        this.dorsal = dorsal;
        this.nombre = nombre;
        this.equipo = equipo;
    }

    public void SetDorsal(int dorsal)
    {
        this.dorsal = dorsal;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public void SetEquipo(string equipo)
    {
        this.equipo = equipo;
    }
    public int GetDorsal()
    {
        return dorsal;
    }
    public string GetNombre()
    {
        return nombre;
    }
    public string GetEquipo()
    {
        return equipo;
    }

    public override string ToString()
    {
        return dorsal + ", " + nombre + " | " + equipo;
    }
}