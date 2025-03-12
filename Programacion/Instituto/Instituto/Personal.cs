using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Personal
{
    protected string dni;
    protected string nombre;
    protected string telefono;

    public Personal(string dni, string nombre, string telefono)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.telefono = telefono;
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
    public string GetTelefono()
    {
        return telefono;
    }
    public void SetDni(string dni)
    {
        this.dni = dni;
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public void SetTelefono(string telefono)
    {
        this.telefono = telefono;
    }
}