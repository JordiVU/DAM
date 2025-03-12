using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Horno : ElementoDomotico, IEncendible
{
    protected bool encendido;
    protected int temperatura;

    public Horno(string nombre, bool encendido, int temperatura) : 
        base(nombre)
    {
        this.encendido = encendido;
        this.temperatura = temperatura;
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
    public int GetTemperatura()
    {
        return temperatura;
    }
    public void SetEncendido(bool encendido)
    {
        this.encendido = encendido;
    }
    public void SetTemperatura(int temperatura)
    {
        this.temperatura = temperatura;
    }

    // ToString modificado...
    public override string ToString()
    {
        if (encendido)
            return base.ToString() + ". Encendido a una temperatura de "
                + temperatura + "º.";
        else
            return base.ToString() + ". Apagado."; 
    }
}