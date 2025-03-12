using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Articulo : Documento
{
    protected string procedencia;

    public Articulo()
    {
        procedencia = "";
    }

    public Articulo(string titulo, string autor, string ubicacion, 
        string procedencia) : base(titulo, autor, ubicacion)
    { 
        this.procedencia = procedencia;
    }

    public string GetProcedencia()
    {
        return procedencia;
    }

    public void SetProcedencia(string procedencia)
    {
        this.procedencia = procedencia;
    }

    public override string ToString()
    {
        return base.ToString() + "," + procedencia;
    }
}
