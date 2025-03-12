using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Clase que gestiona los sarcofagos.
enum tipoSarcofago { NORMAL, LLAVE, TESORO }
class Sarcofago : Sprite
{
    tipoSarcofago tipo;
    bool descubierto;
    public Sarcofago(int cx, int cy, tipoSarcofago tipo) : base(cx, cy, "")
    {
        this.tipo = tipo;
        this.descubierto = false;
    }
    public tipoSarcofago GetTipo()
    {
        return tipo;
    }
    public void SetTipo(tipoSarcofago tipo)
    {
        this.tipo = tipo;
    }
    public bool GetDescubierto()
    {
        return descubierto;
    }
    public void SetDescubierto(bool descubierto)
    {
        this.descubierto = descubierto;
    }

    public override void Dibujar()
    {
        if (!descubierto)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }
        else if(tipo == tipoSarcofago.NORMAL)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
        }
        else if (tipo == tipoSarcofago.LLAVE)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
        }
        for (int j = 0; j < Configuracion.ALTO_SARCOFAGO; j++)
        {
            Console.SetCursorPosition(x, y + j);
            for (int k = 0; k < Configuracion.ANCHO_SARCOFAGO; k++)
                Console.Write(" ");
        }
        Console.ResetColor();
    }

}
