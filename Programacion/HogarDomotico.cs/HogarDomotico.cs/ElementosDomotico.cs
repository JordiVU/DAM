using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Clase padre abstracta que indicara los elementos domoticos de un hogar.
abstract class ElementoDomotico
{
    protected string nombre;

    public ElementoDomotico()
    {
        nombre = string.Empty;
    }

    public ElementoDomotico(string nombre)
    {
        this.nombre = nombre;
    }

    // Getters y setters...
    public string GetNombre()
    {
        return nombre;
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    // Metodo abstracto Mostrar para los hijos.
    public abstract void Mostrar();
}