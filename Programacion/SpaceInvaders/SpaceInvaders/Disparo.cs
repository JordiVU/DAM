using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Clase para representar los disparos de las naves 
 */
class Disparo : Sprite
{
    private bool activo;

    public Disparo()
    {
        activo = false;
        imagen = "|";
    }

    // Establecer el disparo como activo o no
    public void SetActivo(bool a)
    {
        activo = a;
    }

    // Obtener si el disparo está activo o no
    public bool GetActivo()
    {
        return activo;
    }

    // Dibujar el disparo
    public override void Dibujar()
    {
        if (activo)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Dibujar();
            Console.ResetColor();
        }
    }
}