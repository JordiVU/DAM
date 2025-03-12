using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Libro
{
    string titulo;
    float precio;
    int numPaginas;

    public string GetTitulo()
    { 
        return titulo; 
    }

    public void SetTitulo(string t)
    {
        titulo = t;
    }

    public float GetPrecio()
    {
        return precio;
    }

    public void SetPrecio(float p)
    {
        precio = p;
    }

    public int GetNumPaginas(int n)
    {
        return numPaginas;
    }
}
