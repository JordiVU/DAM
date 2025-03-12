using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bungalow : Propiedad
{
    private int supTerraza;

    public Bungalow(string desc, int superficie, int precio, Agente agentes, 
        int supTerraza)
        : base(desc, superficie, precio, agentes)
    {
        this.supTerraza = supTerraza;
    }

    public void SetSupTerraza(int supTerraza)
    {
        this.supTerraza = supTerraza;
    }
    public int GetSupTerraza()
    {
        return supTerraza;
    }

    public override string ToString()
    {
        return base.ToString() + ", " + supTerraza + " m2 - Terraza";
    }
}