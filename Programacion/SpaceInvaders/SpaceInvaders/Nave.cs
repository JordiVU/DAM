using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

// Nave del jugador con la que se jugara.
class Nave : Sprite
{
    private Disparo[] disparos;

    // Vidas restantes
    private int vidas;

    // Puntos actuales
    private int puntos;

    // Constructor para ubicar la nave en una posición determinada
    public Nave(int cx, int cy)
    {
        disparos = new Disparo[Configuracion.MAX_DISPAROS];
        for(int i = 0; i < disparos.Length; i++)
        {
            disparos[i] = new Disparo();
        }
        vidas = Configuracion.VIDAS_INICIALES;
        puntos = 0;
        x = cx;
        y = cy;
        imagen = "/\\";
    }

    // Inicia un disparo si no está activo
    public void Disparar()
    {
        int n = 0;
        bool encontrado = false;

        while (n < disparos.Length && !encontrado)
        {
            if (!disparos[n].GetActivo())
            {
                disparos[n].MoverA(x, y - 1);
                disparos[n].SetActivo(true);
                encontrado = true;
            }
            n++;
        }
    }

    // Mueve el disparo hacia arriba
    public void MoverDisparo()
    {
        for (int i = 0; i < disparos.Length; i++)
        {
            if (disparos[i].GetActivo())
            {
                if (disparos[i].GetY() > 0)
                    disparos[i].MoverA(disparos[i].GetX(), disparos[i].GetY() - 1);
                else
                {
                    disparos[i].SetActivo(false);
                    disparos[i].MoverA(x, y);
                }
            }
        }
    }

    // Getters y setters para puntos y vidas
    public int GetVidas()
    {
        return vidas;
    }

    public int GetPuntos()
    {
        return puntos;
    }

    public void SetVidas(int vidas)
    {
        this.vidas = vidas;
    }

    public void SetPuntos(int puntos)
    {
        this.puntos = puntos;
    }

    // Redefinición del método Dibujar
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.White;
        base.Dibujar();
        foreach (Disparo d in disparos)
        {
            d.Dibujar();
        }
        Console.ResetColor();
    }
}
