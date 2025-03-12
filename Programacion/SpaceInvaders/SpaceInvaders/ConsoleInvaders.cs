using System.Drawing;
using System;
// Progama pincipal...

class ConsoleInvaders
{
    static void Main()
    {
        Bienvenida b;

        // Ocultamos el cursor durante el juego
        Console.CursorVisible = false;
        // Comentar o no poner estas dos líneas en Mac (no funcionan)
        Console.WindowWidth = Configuracion.ANCHO_PANTALLA;
        Console.WindowHeight = Configuracion.ALTO_PANTALLA;

        do
        {
            b = new Bienvenida();
            b.Lanzar();
            if (!b.GetSalir())
            {
                Partida p = new Partida();
                p.Lanzar();
            }
        } while (!b.GetSalir());
    }
}