using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase que gestiona las solicitudes de las tasas.
class SolicitudTasas : Solicitud
{
    protected string concepto;
    protected float importe;

    public SolicitudTasas(string fecha, string idf, Administrativo administrativo,
        string concepto, float importe) : base(fecha, idf, administrativo)
    {
        this.concepto = concepto;
        this.importe = importe;
    }

    // Getters y setters....
    public string GetConcepto()
    {
        return concepto;
    }
    public float GetImporte()
    {
        return importe;
    }
    public void SetConcepto(string concepto)
    {
        this.concepto = concepto;
    }
    public void SetImporte(float importe)
    {
        this.importe = importe;
    }

    public override string ToString()
    {
        return "Solicitud Tasas." + base.ToString() + "Concepto de la tasa "
            + concepto + ". Importa " + importe;
    }
}