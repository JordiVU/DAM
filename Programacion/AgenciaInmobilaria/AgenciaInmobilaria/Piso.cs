using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Piso : Propiedad
{
    private int numHab;
    private int planta;

    public Piso(string desc, int superficie, int precio, Agente agentes,
        int numHab, int planta)
        : base (desc, superficie, precio, agentes)
    {
        this.numHab = numHab;
        this.planta = planta;
    }

    public void SetNumHab(int numHab)
    {
        this.numHab = numHab;
    }
    public void SetPlanta(int planta)
    {
        this.planta = planta;
    }

    public override string ToString()
    {
        return base.ToString() + ", Planta: " + planta + " | " + numHab + 
            " habitaciones" ;
    }
}
