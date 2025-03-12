using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Tipo especial de enemigo que aparece ocasionalmente por la parte 
 * superior de la pantalla 
 */
class Ovni : Enemigo
{
    const int INI_X = 2;
    const int INI_Y = 1;
    // Constructor
    public Ovni()
    {
        imagen = "[-]";
        activo = false;
    }

    public void IntentarActivacion()
    {
        int num = Configuracion.random.Next(0, 100);
        if(num ==0)
        {
            activo = true;
            x = INI_X;
            y = INI_Y;
        }
    }

    public void Mover()
    {
        if(GetX() < Configuracion.ANCHO_PANTALLA - imagen.Length)
        {
            MoverA(x + 1, y);
        }
        else
        {
            MoverA(INI_X, INI_Y);
            SetActivo(false);
        }
    }
    // Redefinición del método Dibujar para el ovni
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        base.Dibujar();
        Console.ResetColor();
    }
}