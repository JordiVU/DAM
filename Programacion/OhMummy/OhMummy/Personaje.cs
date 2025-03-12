using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase que gestiona el personaje
class Personaje : Sprite
{
    private int vidas;
    private int puntos;
    public Personaje(int cx, int cy) : base(cx, cy, "" + (char)2)
    {
        vidas = Configuracion.VIDAS_INICIALES;
        puntos = 0;
    }
    public int GetVidas()
    {
        return vidas;
    }
    public int GetPuntos()
    {
        return puntos;
    }
    public void PerderVida()
    {
        vidas--;
    }
    public void IncrementarPuntos(int cantidad)
    {
        puntos += cantidad;
    }
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        base.Dibujar();
    }

    public void MoverA(int cx, int cy)
    {
        // Borramos la posición actual (dibujando puntos) 
        Console.SetCursorPosition(x, y);
        for (int i = 0; i < imagen.Length; i++)
            Console.Write("·");
        // Movemos a esas coordenadas, una vez comprobado que son correctas 
        SetX(cx);
        SetY(cy);
    }
}