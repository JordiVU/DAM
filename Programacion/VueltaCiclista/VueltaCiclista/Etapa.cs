using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase encargada de gestionar las diferentes etapas.
class Etapa
{
    private string fecha;
    private Ciclistas[] top = new Ciclistas[3];

    public Etapa(string fecha)
    {
        this.fecha = fecha;
    }

    public void SetFecha(string fecha)
    {
        this.fecha = fecha;
    }
    public void SetCiclista(Ciclistas ciclista, int pos)
    {
        this.top[pos] = ciclista;
    }
    public Ciclistas GetCiclistaGanador()
    {
        return top[0];
    }
    public string GetFecha()
    {
        return fecha;
    }
    public override string ToString()
    {
        return fecha + "\n\t1." + top[0] + "\n\t2." + top[1] + "\n\t3." + top[2];
    }
}