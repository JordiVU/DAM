using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VideojuegoPC : Videojuego
{
    protected int ram;
    protected int disco;

    public VideojuegoPC(string titulo, string genero, int ram, int disco)
         : base (titulo, genero)
    {
        this.ram = ram;
        this.disco = disco;
    }

    public void SetRam(int ram)
    {
        this.ram = ram;
    }
    public void SetDiscoo(int disco)
    {
        this.disco = disco;
    }
    public int GetRam()
    {
        return ram;
    }
    public int GetDisco()
    {
        return disco;
    }

    public override string AFichero()
    {
        return base.AFichero() + ";" + ram + ";" + disco;
    }
    public override string ToString()
    {
        return base.ToString() + "|" + ram + "GB RAM," + disco + "GB HD";
    }
}