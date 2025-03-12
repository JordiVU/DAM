using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Torres defensivas que protegen a la nave de los enemigos. 
 * Es un subtipo de sprite, donde la X y la Y representan la 
 * esquina superior izquierda de la torre 
 */
class TorreDefensiva : Sprite
{
    // Ladrillos de la torre, que se van borrando con cada disparo enemigo
    private StringBuilder[] ladrillos = {
        new StringBuilder(new String('*', Configuracion.ANCHO_TORRE)),
        new StringBuilder(new String('*', Configuracion.ANCHO_TORRE)),
        new StringBuilder(new String('*', Configuracion.ANCHO_TORRE))
    };

    // Constructor para ubicar la torre en una posición determinada
    public TorreDefensiva(int cx, int cy)
    {
        x = cx;
        y = cy;
    }
    // Comprueba si un disparo colisiona con la torre, y si es así elimina 
    // alguno de sus "ladrillos"
    public bool ColisionaCon(Disparo d)
    {
        // Miramos si la X del disparo está dentro de la anchura de la torre
        bool colisionaX = d.GetX() >= x && d.GetX() < x + ladrillos[0].Length;
        // Miramos si la Y del disparo está dentro de la altura de la torre
        bool colisionaY = d.GetY() >= y && d.GetY() < y + ladrillos.Length;

        if (colisionaX && colisionaY)
        {
            // Miramos si hay un ladrillo (asterisco) en la posición del disparo
            // Si es así, lo borramos porque ha impactado
            bool hayLadrillo = ladrillos[d.GetY() - y][d.GetX() - x] == '*';
            if (hayLadrillo)
            {
                ladrillos[d.GetY() - y][d.GetX() - x] = ' ';
                return true;
            }
        }
        return false;
    }

    // Dibujar la torre
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        for (int i = 0; i < ladrillos.Length; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write(ladrillos[i]);
        }
        Console.ResetColor();
    }
}