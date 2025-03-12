using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

// Lanza la partida principal
class Partida
{
    // Desde dónde empezará a verse el mapa 
    // (esquina superior izquierda tras los bordes) 
    const int xInicioMapa = Configuracion.ANCHO_BORDE_LATERAL;
    const int yInicioMapa = Configuracion.ANCHO_BORDE_SUPERIOR;
    public void Lanzar()
    {
        int numMomias = 2;
        Sarcofago[,] sarcofagos = InicializarSarcofagos();
        char[,] mapa = InicializarMapa(sarcofagos);
        Personaje personaje = new Personaje(Configuracion.POSICION_INICIAL_X,
            Configuracion.POSICION_INICIAL_Y);
        Momia[] momias = InicializarMomias(numMomias, mapa);
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        Console.Clear();
        DibujarMarco();
        ActualizarHUD(personaje);
        do
        {
            MoverMomias(momias, mapa);
            ComprobarColisionMomias(momias, personaje);
            if (Console.KeyAvailable)
            {
                while (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey(true);
                }
                if (tecla.Key == ConsoleKey.RightArrow ||
                                tecla.Key == ConsoleKey.LeftArrow ||
                                tecla.Key == ConsoleKey.UpArrow ||
                                tecla.Key == ConsoleKey.DownArrow)
                {
                    MoverPersonaje(mapa, tecla, personaje);
                }
            }
            DibujarSarcofagos(sarcofagos);
            personaje.Dibujar();
            foreach (Momia m in momias)
                m.Dibujar();
            Thread.Sleep(Configuracion.PAUSA_BUCLE);
        }
        while (tecla.Key != ConsoleKey.Escape && personaje.GetVidas() > 0 &&
        !ComprobarTodosSarcofagos(sarcofagos, mapa, personaje));
    }

    private void DibujarMarco()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        // Borde superior e inferior 
        for (int i = 0; i < Configuracion.ANCHO_BORDE_SUPERIOR; i++)
        {
            Console.SetCursorPosition(0, i);
            for (int j = 0; j < Configuracion.ANCHO_PANTALLA; j++)
                Console.Write(" ");
            Console.SetCursorPosition(0, Configuracion.ALTO_PANTALLA - i - 1);
            for (int j = 0; j < Configuracion.ANCHO_PANTALLA; j++)
                Console.Write(" ");
        }
        // Bordes laterales 
        for (int i = Configuracion.ANCHO_BORDE_SUPERIOR;
            i < Configuracion.ALTO_PANTALLA - Configuracion.ANCHO_BORDE_SUPERIOR;
            i++)
        {
            Console.SetCursorPosition(0, i);
            for (int j = 0; j < Configuracion.ANCHO_BORDE_LATERAL; j++)
                Console.Write(" ");
            Console.SetCursorPosition(Configuracion.ANCHO_PANTALLA -
                Configuracion.ANCHO_BORDE_LATERAL, i);
            for (int j = 0; j < Configuracion.ANCHO_BORDE_LATERAL; j++)
                Console.Write(" ");
        }
        Console.ResetColor();
    }

    private Sarcofago[,] InicializarSarcofagos()
    {
        int iEspecial, jEspecial, contador = 0;
        Sarcofago[,] sarcofagos = new Sarcofago[5, 4];
        for (int i = 0; i < sarcofagos.GetLength(0); i++)
        {
            for (int j = 0; j < sarcofagos.GetLength(1); j++)
            {
                int x = Configuracion.ANCHO_BORDE_LATERAL
                                + j * (Configuracion.ANCHO_SARCOFAGO + 1) + 1;
                int y = Configuracion.ANCHO_BORDE_SUPERIOR +
                                i * (Configuracion.ALTO_SARCOFAGO + 1) + 1;
                sarcofagos[i, j] = new Sarcofago(x, y, tipoSarcofago.NORMAL);
            }
        }
        // Asignamos al azar una llave y tres tesoros 
        iEspecial = Configuracion.r.Next(0, sarcofagos.GetLength(0));
        jEspecial = Configuracion.r.Next(0, sarcofagos.GetLength(1));
        sarcofagos[iEspecial, jEspecial].SetTipo(tipoSarcofago.LLAVE);
        while (contador < 3)
        {
            iEspecial = Configuracion.r.Next(0, sarcofagos.GetLength(0));
            jEspecial = Configuracion.r.Next(0, sarcofagos.GetLength(1));
            if (sarcofagos[iEspecial, jEspecial].GetTipo() == tipoSarcofago.NORMAL)
            {
                sarcofagos[iEspecial, jEspecial].SetTipo(tipoSarcofago.TESORO);
                contador++;
            }
        }
        return sarcofagos;
    }
    private void DibujarSarcofagos(Sarcofago[,] sarcofagos)
    {
        for (int i = 0; i < sarcofagos.GetLength(0); i++)
        {
            for (int j = 0; j < sarcofagos.GetLength(1); j++)
            {
                sarcofagos[i, j].Dibujar();
            }
        }
    }

    private char[,] InicializarMapa(Sarcofago[,] sarcofagos)
    {
        char[,] mapa = new char[
                sarcofagos.GetLength(0) * (Configuracion.ALTO_SARCOFAGO + 1) + 1,
                sarcofagos.GetLength(1) * (Configuracion.ANCHO_SARCOFAGO + 1) + 1];
        for (int i = 0; i < mapa.GetLength(0); i++)
            for (int j = 0; j < mapa.GetLength(1); j++)
            {
                // Vemos si la coordenada (i, j) está dentro de los  
                // límites de algún sarcófago 
                bool transitable = true;
                for (int m = 0; m < sarcofagos.GetLength(0); m++)
                {
                    for (int n = 0; n < sarcofagos.GetLength(1); n++)
                    {
                        if (i + yInicioMapa >= sarcofagos[m, n].GetY() &&
                                                i + yInicioMapa < sarcofagos[m, n].GetY() +
                                                Configuracion.ALTO_SARCOFAGO &&
                                                j + xInicioMapa >= sarcofagos[m, n].GetX() &&
                                                j + xInicioMapa < sarcofagos[m, n].GetX() +
                                                Configuracion.ANCHO_SARCOFAGO)
                        {
                            transitable = false;
                        }
                    }
                }
                // Ponemos espacios en lugares transitables y otro símbolo 
                // (X por ejemplo) en los ocupados por sarcófagos) 
                if (transitable)
                    mapa[i, j] = ' ';
                else
                    mapa[i, j] = 'X';
            }
        return mapa;
    }

    private void MoverPersonaje(char[,] mapa, ConsoleKeyInfo tecla, Personaje p)
    {
        int nuevaX, nuevaY;
        // Si estamos en la casilla inicial, nos colocamos una casilla más abajo 
        if (p.GetX() == Configuracion.POSICION_INICIAL_X &&
                p.GetY() == Configuracion.POSICION_INICIAL_Y)
        {
            p.MoverA(p.GetX(), p.GetY() + 1);
        }
        // Si no, tenemos que ver si podemos movernos a esa casilla del mapa 
        else
        {
            nuevaX = p.GetX();
            nuevaY = p.GetY();
            switch (tecla.Key)
            {
                case ConsoleKey.LeftArrow:
                    nuevaX--;
                    break;
                case ConsoleKey.RightArrow:
                    nuevaX++;
                    break;
                case ConsoleKey.UpArrow:
                    nuevaY--;
                    break;
                case ConsoleKey.DownArrow:
                    nuevaY++;
                    break;
            }
            if (nuevaY >= yInicioMapa && nuevaY < yInicioMapa + mapa.GetLength(0) 
                && nuevaX >= xInicioMapa && nuevaX < xInicioMapa + mapa.GetLength(1) 
                && mapa[nuevaY - yInicioMapa, nuevaX - xInicioMapa] != 'X')
            {
                mapa[nuevaY - yInicioMapa, nuevaX - xInicioMapa] = '·';
                p.MoverA(nuevaX, nuevaY);
            }
        }
    }

    private Momia[] InicializarMomias(int total, char[,] mapa)
    {
        int x, y;
        direccionMomia direccion;
        Momia[] momias = new Momia[total];
        for (int i = 0; i < total; i++)
        {
            do
            {
                x = Configuracion.r.Next(Configuracion.ANCHO_BORDE_LATERAL,
                    Configuracion.ANCHO_PANTALLA - Configuracion.ANCHO_BORDE_LATERAL);
                y = Configuracion.r.Next(Configuracion.ANCHO_BORDE_SUPERIOR,
                    Configuracion.ALTO_PANTALLA - Configuracion.ANCHO_BORDE_SUPERIOR);
            }
            while (mapa[y - yInicioMapa, x - xInicioMapa] == 'X');

            do
            {
                direccion = (direccionMomia)Configuracion.r.Next(0, 4);
            }
            while (!MovimientoValido(x - xInicioMapa, y - yInicioMapa,
            direccion, mapa));

            momias[i] = new Momia(x, y, direccion);
        }

        return momias;
    }

    private bool MovimientoValido(int x, int y, direccionMomia direccion,
char[,] mapa)
    {
        bool resultado = true;
        // Si vamos a la izquierda pero no estamos en un pasillo horizontal 
        // o estamos en el borde izquierdo, es inválido 
        if (direccion == direccionMomia.IZQUIERDA &&
                (y % (Configuracion.ALTO_SARCOFAGO + 1) != 0 || x == 0))
            resultado = false;
        // Mismo caso para la derecha, y si estamos en el borde derecho 
        else if (direccion == direccionMomia.DERECHA &&
                (y % (Configuracion.ALTO_SARCOFAGO + 1) != 0 ||
                x == mapa.GetLength(1) - 1))
            resultado = false;
        // Mismo caso para abajo y si estamos en el borde inferior 
        else if (direccion == direccionMomia.ABAJO &&
                (x % (Configuracion.ANCHO_SARCOFAGO + 1) != 0 ||
                y == mapa.GetLength(0) - 1))
            resultado = false;
        // Mismo caso para arriba y si estamos en el borde superior 
        else if (direccion == direccionMomia.ARRIBA &&
                (x % (Configuracion.ANCHO_SARCOFAGO + 1) != 0 || y == 0))
            resultado = false;
        return resultado;
    }
    private void MoverMomias(Momia[] momias, char[,] mapa)
    {
        direccionMomia siguienteDireccion;
        for (int i = 0; i < momias.Length; i++)
        {
            // Escribimos en la posición vieja de la momia lo que hubiera 
            // antes en el mapa (espacio o huella de arqueólogo) 
            Console.SetCursorPosition(momias[i].GetX(), momias[i].GetY());
            Console.Write(mapa[momias[i].GetY() - yInicioMapa,
                momias[i].GetX() - xInicioMapa]);
            // Casillas intersección: múltiplos del ancho y alto de sarcófago 
            if ((momias[i].GetX() - xInicioMapa) %
                            (Configuracion.ANCHO_SARCOFAGO + 1) == 0 &&
                        (momias[i].GetY() - yInicioMapa) %
                        (Configuracion.ALTO_SARCOFAGO + 1) == 0)
            {
                do
                {
                    siguienteDireccion =
                        (direccionMomia)Configuracion.r.Next(0, 4);
                }
                while (!MovimientoValido(momias[i].GetX() - xInicioMapa,
                                momias[i].GetY() - yInicioMapa, siguienteDireccion, mapa));
                momias[i].SetDireccion(siguienteDireccion);
            }
            if (momias[i].GetDireccion() == direccionMomia.ARRIBA)
                momias[i].SetY(momias[i].GetY() - 1);
            else if (momias[i].GetDireccion() == direccionMomia.ABAJO)
                momias[i].SetY(momias[i].GetY() + 1);
            else if (momias[i].GetDireccion() == direccionMomia.IZQUIERDA)
                momias[i].SetX(momias[i].GetX() - 1);
            else // Derecha 
                momias[i].SetX(momias[i].GetX() + 1);
        }
    }
    private void ActualizarHUD(Personaje p)
    {
        Console.SetCursorPosition(60, 0);
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("Vidas:" + p.GetVidas());
        Console.SetCursorPosition(60, 1);
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Puntos:" + p.GetPuntos());
        Console.ResetColor();
    }
    private void ComprobarColisionMomias(Momia[] momias, Personaje p)
    {
        int i = 0;
        bool colision = false;
        while (!colision && i < momias.Length)
        {
            if (momias[i].GetX() == p.GetX() && momias[i].GetY() == p.GetY())
            {
                colision = true;
                p.PerderVida();
                p.MoverA(Configuracion.POSICION_INICIAL_X, 
                            Configuracion.POSICION_INICIAL_Y);
                ActualizarHUD(p);
            }
            else
            {
                i++;
            }
        }
    }

    private bool ComprobarSarcofago(Sarcofago s, char[,] mapa)
    {
        bool resultado = true;
        int x = s.GetX() - xInicioMapa;
        int y = s.GetY() - yInicioMapa;
        // El sarcófago estará descubierto si no encontramos ningún espacio 
        // vacío a su alrededor 
        // Comprobamos pasillo superior e inferior 
        for (int i = x - 1; i < x + Configuracion.ANCHO_SARCOFAGO; i++)
        {
            if (mapa[y - 1, i] == ' ' ||
                        mapa[y + Configuracion.ALTO_SARCOFAGO, i] == ' ')
                resultado = false;
        }
        // Comprobamos pasillo izquierdo y derecho 
        for (int i = y - 1; i < y + Configuracion.ALTO_SARCOFAGO; i++)
        {
            if (mapa[i, x - 1] == ' ' ||
                        mapa[i, x + Configuracion.ANCHO_SARCOFAGO] == ' ')
                resultado = false;
        }
        return resultado;
    }

    private bool ComprobarTodosSarcofagos(Sarcofago[,] sarcofagos,
                                            char[,] mapa, Personaje p)
    {
        bool resultado = true;
        for (int i = 0; i < sarcofagos.GetLength(0); i++)
        {
            for (int j = 0; j < sarcofagos.GetLength(1); j++)
            {
                if (!sarcofagos[i, j].GetDescubierto() &&
                                ComprobarSarcofago(sarcofagos[i, j], mapa))
                {
                    sarcofagos[i, j].SetDescubierto(true);
                    if (sarcofagos[i, j].GetTipo() == tipoSarcofago.TESORO)
                    {
                        p.IncrementarPuntos(50);
                    }
                    else if(sarcofagos[i, j].GetTipo() == tipoSarcofago.LLAVE)
                    {
                        p.IncrementarPuntos(20);
                    }
                    else
                    {
                        p.IncrementarPuntos(10);
                    }
                    ActualizarHUD(p);
                }
                if (!sarcofagos[i, j].GetDescubierto())
                {
                    resultado = false;
                }
            }
        }
        return resultado;
    }
}
