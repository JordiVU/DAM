using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Clase que gestiona las solicitudes de domiciliano.
class SolicitudDomiciliacion : Solicitud
{
    protected string numeroCuenta;

    public SolicitudDomiciliacion(string fecha, string idf, 
        Administrativo administrativo, string numeroCuenta) 
        : base(fecha, idf, administrativo)
    {
        this.numeroCuenta = numeroCuenta;
    }

    // Getters y setters...
    public string GetNumeroCuenta()
    {
        return numeroCuenta;
    }

    public void SetNumeroCuenta(string numeroCuenta)
    {
        this.numeroCuenta = numeroCuenta;
    }

    public override string ToString()
    {
        return "Cambio Domiciliación." + base.ToString() + "Núm cuenta " 
            + numeroCuenta;
    }
}