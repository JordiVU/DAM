using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Videojuego
{
    protected string titulo;
    protected string genero;
    public Videojuego(string titulo, string genero)
    {
        this.titulo = titulo;
        this.genero = genero;
    }

    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }

    public void SetGenero(string genero)
    {
        this.genero = genero;
    }

    public string GetGenero()
    {
        return genero;
    }

    public string GetTitulo()
    {
        return titulo;
    }

    public override string ToString()
    {
        return titulo + "," + genero;
    }

    public virtual string AFichero()
    {
        return titulo + ";" + genero;
    }
}