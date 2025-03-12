using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Libro
{
    protected string titulo;
    protected int numero;

    public Libro(string titulo, int numero)
    {
        this.titulo = titulo;
        this.numero = numero;
    }

    // Getters y setters...
    public string GetTitulo()
    {
        return titulo;
    }

    public int GetPaginas()
    {
        return numero;
    }

    // ToString modificado..
    public override string ToString()
    {
        return "Titulo: " + titulo + "| Nº Pag:" +  numero;
    }

}