using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Agente
{
    protected string nombre;
    protected string telefono;

    public Agente(string nombre, string telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public void SetTelefono(string telefono)
    {
        this.telefono = telefono;
    }
    public string GetNombre()
    {
        return nombre;
    }
    public string GetTelefono()
    {
        return telefono;
    }

    public override string ToString()
    {
        return nombre + " - " + telefono;
    }
}