using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Luz : ElementoDomotico, IEncendible
{
    private bool encendido;

    public Luz(string nombre, bool encendido) : base(nombre)
    {
        this.encendido = encendido;
    }

    public bool Encender()
    {
        return encendido = true;
    }
    public bool Apagar()
    {
        return encendido = false;
    }

    // Getters y setters...
    public bool GetEncendido()
    {
        return encendido;
    }
    public void SetEncendido(bool encendido)
    {
        this.encendido = encendido;
    }

    // ToString modificado...
    public override string ToString()
    {
        if (encendido)
        {
            return base.ToString() + ". Encendida.";
        }
        else
        {
            return base.ToString() + ". Apagada.";
        }
    }
}
