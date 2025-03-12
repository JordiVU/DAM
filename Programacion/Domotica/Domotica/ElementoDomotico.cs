﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Clase padre abstracta que indicara los elementos domoticos de un hogar.
abstract class ElementoDomotico : IComparable<ElementoDomotico>
{
    protected string nombre;

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

    // ToString modificado...
    public override string ToString()
    {
        return nombre;
    }

    public int CompareTo(ElementoDomotico elementoDomotico)
    {
        return this.nombre.CompareTo(elementoDomotico.nombre);
    }
}