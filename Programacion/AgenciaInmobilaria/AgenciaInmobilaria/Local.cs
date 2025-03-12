using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Local : Propiedad
{
    private bool acceso;

    public Local(string desc, int superficie, int precio, Agente agentes,
        bool acceso)
        : base(desc, superficie, precio, agentes)
    {
        this.acceso = acceso;
    }

    public void SetAcceso(bool acceso)
    {
        this.acceso = acceso;
    }
    public bool GetAcceso()
    {
        return acceso;
    }
}