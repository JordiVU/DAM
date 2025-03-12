using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Puerta : ElementoDomotico
{
    protected bool abierta;

    public Puerta(string nombre, bool abierta) : base(nombre)
    {
        this.abierta = abierta;
    }

    // Getters y setters...
    public bool GetAbierta()
    {
        return abierta;
    }
    public void SetAbierta(bool abierta)
    {
        this.abierta = abierta;
    }

    // ToString modificado...
    public override string ToString()
    {
        if (abierta)
            return base.ToString() + ". Abierta";
        else
            return base.ToString() + ". Cerrada";
    }
}
