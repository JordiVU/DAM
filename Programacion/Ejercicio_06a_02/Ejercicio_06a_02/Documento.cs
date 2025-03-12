using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Documento
{
    protected string autor;
    protected string titulo;
    protected string ubicacion;

    /**
    public Documento()
    {
        autor = "";
        titulo = "";
        ubicacion = "";
    }
    **/

    public Documento(string a, string t, string u)
    {
        autor = a;
        titulo = t;
        ubicacion = u;
    }
    public void SetAutor(string a)
    {
        autor = a;
    }

    public void SetTitulo(string t)
    {
        titulo = t;
    }

    public void SetUbicacion(string u)
    {
        ubicacion = u;
    }

    public string GetAutor()
    {
        return autor;
    }

    public string GetTitulo()
    {
        return titulo;
    }

    public string GetUbicacion()
    {
        return ubicacion;
    }

    public override string ToString()
    {
        return autor + "," + titulo + "," + ubicacion;
    }

}
