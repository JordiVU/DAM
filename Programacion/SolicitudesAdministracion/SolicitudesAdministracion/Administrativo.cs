using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Administrativo
{
    protected string nombre;
    protected string dni;
    protected string telefono;

    public Administrativo(string nombre, string dni, string telefono)
    {
        this.nombre = nombre;
        this.dni = dni;
        this.telefono = telefono;
    }

    // Getters y setters...
    public string GetNombre()
    {
        return nombre;
    }
    public string GetDni()
    {
        return dni;
    }
    public string GetTelefono()
    {
        return telefono;
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public void SetDni(string dni)
    {
        this.dni = dni;
    }
    public void SetTelefono(string telefono)
    {
        this.telefono = telefono;
    }
}