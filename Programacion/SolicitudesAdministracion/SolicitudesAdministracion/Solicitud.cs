using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solicitud
{
    protected string fecha;
    protected string idf;
    protected Administrativo administrativo;
    public Solicitud()
    {
        fecha = string.Empty;
        idf = string.Empty;
        administrativo = null;
    }

    public Solicitud(string fecha, string idf, Administrativo administrativo)
    {
        this.fecha = fecha;
        this.idf = idf;
        this.administrativo = administrativo;
    }

    // Getters y setters....
    public string GetFecha()
    {
        return fecha;
    }
    public string GetIdf()
    {
        return idf;
    }
    public Administrativo GetAdministrativo()
    {
        return administrativo;
    }
    public void SetFecha(string fecha)
    {
        this.fecha = fecha;
    }
    public void SetIdf(string idf)
    {
        this.idf = idf;
    }

    public override string ToString()
    {
        return "ID " + idf + ". Realizada el " + fecha + 
            ". Por" + GetAdministrativo().GetNombre() + " |";
    }
}