using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Usuario
{
    private string dni;
    private string nombre;
    private Poliza poliza;

    public Usuario(string dni, string nombre, Poliza poliza)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.poliza = poliza;
        this.poliza.SetUsuario(this);
    }

    public Usuario()
    {
        this.dni = "";
        this.nombre = "";
        this.poliza = null;
    }

    public void SetDni (string dni)
    { 
        this.dni = dni;
    }    
    public void SetNombre (string nombre)
    { 
        this.nombre = nombre;
    }
    public string GetNombre ()
    {
        return this.nombre;
    }
    public void MostrarInfo()
    {
        Console.WriteLine("DNI: " + dni);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("ID: " + poliza.GetId());
        Console.WriteLine("Precio: " + poliza.GetPrecio());
    }
}