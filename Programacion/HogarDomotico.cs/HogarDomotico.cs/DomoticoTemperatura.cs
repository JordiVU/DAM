using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase para los elementos domoticos que tengan temperatura.
abstract class DomoticoTemperatura : ElementoDomotico, IEncendible
{
    protected bool encendido;
    protected int temperatura;

    public DomoticoTemperatura()
    {
        encendido = false;
    }

    public DomoticoTemperatura(string nombre, bool encendido, int temperatura) :
        base(nombre)
    {
        this.encendido = encendido;
        this.temperatura = temperatura;
    }
    public void Encender()
    {
        encendido = true;
    }
    public void Apagar()
    {
        encendido = false;
    }
    public bool Consultar()
    {
        return encendido;
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
}