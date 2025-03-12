using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Configuracion inicial del juego.

class Configuracion
{
    public const int ANCHO_PANTALLA = 80;
    public const int ALTO_PANTALLA = 25;
    public const int ANCHO_TORRE = 6;
    public const int TOTAL_TORRES = 4;
    public const int PAUSA_BUCLE = 70;
    public const int SEPARACION_ENEMIGOS = 5;
    public const int MAX_DISPAROS = 5;
    public const int VIDAS_INICIALES = 3;
    public const int PUNTOS_ENEMIGO1 = 10;
    public const int PUNTOS_ENEMIGO2 = 20;
    public const int PUNTOS_ENEMIGO3 = 30;
    public const int PUNTOS_OVNI = 100;

    // Generador de números aleatorios
    public static Random random = new Random();
}