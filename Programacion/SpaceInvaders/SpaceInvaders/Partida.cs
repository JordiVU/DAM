using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Gestion de la partida.

class Partida
{
    // Lanza la partida principal
    public void Lanzar()
    {
        Console.Clear();


        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        Nave nave = new Nave(40, 20);
        BloqueEnemigos enemigos = new BloqueEnemigos();
        Ovni o = new Ovni();
        o.MoverA(1, 5);

        TorreDefensiva[] t = CrearTorres();

        // Aquí declaramos los objetos (nave, enemigos, etc)
        // y les damos una posición inicial
        do
        {
            nave.Dibujar();
            enemigos.Dibujar();
            o.Dibujar();
            for (int i = 0; i < Configuracion.TOTAL_TORRES; i++)
                t[i].Dibujar();

            Thread.Sleep(Configuracion.PAUSA_BUCLE);

            if (Console.KeyAvailable)
            {
                while (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey(true);
                }
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    nave.MoverA(nave.GetX() - 1, nave.GetY());
                }
                else if (tecla.Key == ConsoleKey.RightArrow)
                {
                    nave.MoverA(nave.GetX() + 1, nave.GetY());
                }
                else if (tecla.Key == ConsoleKey.Spacebar)
                {
                    nave.Disparar();
                }
            }
            enemigos.Mover();
            nave.MoverDisparo();
            enemigos.IntentarDisparo();
            enemigos.MoverDisparo();
            enemigos.Mover();
            MoverOvni(o);
            enemigos.ComprobarColisionConNave(nave);
            enemigos.ComprobarColisionConTorres(t);
            ActualizarHUD(nave);
        }
        while (tecla.Key != ConsoleKey.Escape && nave.GetVidas() > 0);
    }

    private void MoverOvni(Ovni o)
    {
        if(o.GetActivo())
        {
            o.Mover();
        }
        else
        {
            o.IntentarActivacion();
        }
    }

    /*
 * Actualiza el HUD del juego
 */
    public void ActualizarHUD(Nave nave)
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Puntos: {0}", nave.GetPuntos());

        Console.SetCursorPosition(Configuracion.ANCHO_PANTALLA - 10, 0);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Vidas: {0}", nave.GetVidas());

        Console.ResetColor();
    }
    private TorreDefensiva[] CrearTorres()
    {
        TorreDefensiva[] torres = new TorreDefensiva[Configuracion.TOTAL_TORRES];

        for(int i = 0; i < torres.Length; i++)
        {
            // Calculamos el tamaño de la pantalla y donde va cada torre.
            int x =
                Configuracion.ANCHO_PANTALLA / Configuracion.TOTAL_TORRES * i +
                Configuracion.ANCHO_PANTALLA / (Configuracion.TOTAL_TORRES * 2) -
                Configuracion.ANCHO_TORRE / 2;
            torres[i] = new TorreDefensiva(x, 15);
        }
        return torres;
    }
}
