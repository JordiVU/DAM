using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trabajadores
{
    protected string dni;
    protected string nombre;

    public Trabajadores(string dni, string nombre)
    {
        this.dni = dni;
        this.nombre = nombre;
    }

    // Getters y setters...
    public string GetDni()
    {
        return dni;
    }
    public string GetNombre()
    {
        return nombre;
    }
    public void SetDni(string dni)
    {
        this.dni = dni;
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    // ToString modificado...
    public override string ToString()
    {
        return dni + ", " + nombre;
    }
}