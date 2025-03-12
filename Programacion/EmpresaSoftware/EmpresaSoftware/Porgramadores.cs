using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Clase programador, tipo de trabajador.
class Programadores : Trabajadores
{
    protected string lenguaje;
    protected Programadores pareja;

    public Programadores(string dni, string nombre, string lenguaje)
        : base(dni, nombre) 
    {
        this.lenguaje = lenguaje;
    }

    public bool TienePareja()
    {
        return pareja != null;
    }

    // Getters y setters...
    public string GetLenguaje()
    {
        return lenguaje;
    }
    public Programadores GetPareja()
    {
        return pareja;
    }
    public void SetLenguaje(string lenguaje)
    {
        this.lenguaje = lenguaje;
    }
    public void SetPareja(Programadores p)
    {
        if(this.pareja != null)
        {
            this.pareja.pareja = null;
        }
        if(p.pareja != null)
        {
            p.pareja.pareja = null;
        }
        this.pareja = p;
        p.pareja = this;
    }

    // ToString modificado...
    public override string ToString()
    {
        string nombrePareja = "";

        if(pareja != null)
        {
            nombrePareja = pareja.nombre;
        }
        return base.ToString() + ", " + lenguaje + ", Pareja: " + nombrePareja;
    }
}