using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Porton : Puerta
{
    private bool bloqueada;

    public Porton(int ancho, int alto, string color)
    {
        this.ancho = ancho;
        this.alto = alto;
        this.color = color;
    }

    public void Bloquear()
    {
        bloqueada = true;
    }

    public void Desbloquear()
    {
        bloqueada = false;
    }
}