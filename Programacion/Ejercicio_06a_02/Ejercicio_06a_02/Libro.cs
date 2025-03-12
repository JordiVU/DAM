using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Libro : Documento
{
    protected int numPaginas;

    public Libro()
    {
        this.autor = "";
        this.titulo = "";
        this.ubicacion = "";
        this.numPaginas = 0;
    }
    public Libro(string autor, string titulo, string ubicacion, int numPaginas)
        : base(autor, titulo, ubicacion)
    {
        this.numPaginas = numPaginas;
    }

    public int getNumPaginas()
    {
        return numPaginas;
    }

    public void SetNumPaginas(int numPaginas)
    {
        this.numPaginas = numPaginas;
    }
    public override string ToString()
    {
        return base.ToString() + "," + numPaginas;
    }
}
