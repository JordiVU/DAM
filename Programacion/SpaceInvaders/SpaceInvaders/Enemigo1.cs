using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Subtipo de enemigo con imagen propia 
 */
class Enemigo1 : Enemigo
{
    // Constructor para indicar las coordenadas
    public Enemigo1(int cx, int cy) : base(cx, cy)
    {
        imagen = "XX";
    }

    // Redefinición del método Dibujar
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        base.Dibujar();
        Console.ResetColor();
    }
}