using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Puerta
{
    protected int ancho;
    protected int alto;
    protected string color;
    protected bool abierta;

    public Puerta()
    {
        ancho = 0;
        alto = 0;
        color = "blanco";
        abierta = false;
    }

    public Puerta(int ancho, int alto, string color)
    {
        this.ancho = ancho;
        this.alto = alto;
        this.color = color;
    }

    public void Abrir()
    {
        abierta = true;
    }

    public void Cerrar()
    {
        abierta = false;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Abierta: {0}", abierta);
    }

    // Getters & setters

    public void SetAncho(int ancho)
    {
        this.ancho = ancho;
    }

    public void SetAlto(int alto)
    {
        this.alto = alto;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public int GetAncho()
    {
        return ancho;
    }

    public int GetAlto()
    {
        return alto;
    }

    public string GetColor()
    {
        return color;
    }
}
