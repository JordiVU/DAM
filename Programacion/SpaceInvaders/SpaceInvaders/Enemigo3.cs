using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Subtipo de enemigo con imagen propia 
 */
class Enemigo3 : Enemigo
{
    // Constructor para indicar las coordenadas
    public Enemigo3(int cx, int cy) : base(cx, cy)
    {
        imagen = ")(";
    }

    // Redefinición del método Dibujar
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        base.Dibujar();
        Console.ResetColor();
    }
}