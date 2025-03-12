using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase que gestiona la informacion de los clientes.
class Cliente
{
    protected string dni;
    protected string nombre;
    protected int edad;

    public Cliente(string dni, string nombre, int edad)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.edad = edad;
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
    public int GetEdad()
    {
        return edad;
    }
    public void SetDni(string dni)
    {
        this.dni = dni;
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public void SetEdad(int edad)
    {
        if (edad > 0 && edad < 100)
        {
            this.edad = edad;
        }
        else
        {
            this.edad = 0;
        }
    }

    // ToString modificado...
    public override string ToString()
    {
        return dni + " - " + nombre + " (" + edad + " años) ";
    }

}