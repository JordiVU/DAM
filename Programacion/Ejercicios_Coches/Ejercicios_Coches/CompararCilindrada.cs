using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompararCilindrada : IComparer<Vehiculo>
{
    public int Compare(Vehiculo v1, Vehiculo v2)
    {
        return v1.GetCilindrada().CompareTo(v2.GetCilindrada());
    }
}