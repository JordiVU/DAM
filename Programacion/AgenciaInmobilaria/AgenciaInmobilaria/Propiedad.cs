using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

abstract class Propiedad
{
    protected string desc;
    protected int superficie;
    protected int precio;
    protected Agente agentes;
    public Propiedad(string desc, int superficie, int precio, Agente agentes)
    {
        this.desc = desc;
        this.superficie = superficie;
        this.precio = precio;
        this.agentes = agentes;
    }

    public void SetDesc(string desc)
    {
        this.desc = desc;
    }
    public void SetSuperficie(int superficie)
    {
        this.superficie = superficie;
    }
    public void SetPreci(int precio)
    {
        this.precio = precio;
    }
    public string GetDesc()
    {
        return desc;
    }
    public int GetSuperficie()
    {
        return superficie;
    }
    public int GetPrecio()
    {
        return precio;
    }

    public override string ToString()
    {
        return desc + " ( " +superficie + "m2, " + precio + " eur.)";
    }
}