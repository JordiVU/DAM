using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

class Analistas : Trabajadores
{
    protected int anyosExp;
    
    public Analistas(string dni, string nombre, int anyosExp) : 
        base(dni, nombre)
    {
        this.anyosExp = anyosExp;
    }

    // Getters y setters...
    public int GetAnyosExp()
    {
        return anyosExp;
    }
    public void SetAnyosExp(int anyosExp)
    {
        this.anyosExp = anyosExp;
    }

    // ToString modificado...
    public override string ToString()
    {
        return base.ToString() + ", " + anyosExp + " años exp.";
    }
}
