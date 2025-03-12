using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Configuraciones del juego.
class Configuracion
{
    public const int ANCHO_PANTALLA = 81;
    public const int ALTO_PANTALLA = 27;
    public const int PAUSA_BUCLE = 70;
    public const int VIDAS_INICIALES = 3;
    public const int ANCHO_SARCOFAGO = 10;
    public const int ALTO_SARCOFAGO = 3;
    public const int ANCHO_BORDE_SUPERIOR = 3;
    public const int ANCHO_BORDE_LATERAL = 18;
    public static Random r = new Random();
    public const int POSICION_INICIAL_X = Configuracion.ANCHO_PANTALLA / 2;
    public const int POSICION_INICIAL_Y = Configuracion.ANCHO_BORDE_SUPERIOR - 1;

}