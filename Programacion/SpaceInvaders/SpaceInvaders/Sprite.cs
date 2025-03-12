using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Clase para representar todos los sprites del juego 
 */
class Sprite
{
    // Coordenada X
    protected int x;
    // Coordenada Y
    protected int y;
    // Imagen a dibujar, formada por caracteres
    protected string imagen;

    // Obtiene la coordenada X
    public int GetX()
    {
        return x;
    }

    // Obtiene la coordenada Y
    public int GetY()
    {
        return y;
    }

    // Obtiene la imagen de la nave
    public string GetImagen()
    {
        return imagen;
    }

    // Establece la coordenada X
    public void SetX(int cx)
    {
        x = cx;
    }

    // Establece la coordenada Y
    public void SetY(int cy)
    {
        y = cy;
    }

    // Establece la imagen de la nave
    public void SetImagen(string img)
    {
        imagen = img;
    }

    // Mover la nave a una nueva posición (cx, cy)
    public void MoverA(int cx, int cy)
    {
        // Contemplamos el margen
        if (cx >= 0 && cx <= Configuracion.ANCHO_PANTALLA - imagen.Length)
        {
            // Borramos la posición actual (dibujando espacios)
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < imagen.Length; i++)
                Console.Write(" ");

            // Movemos cordenadas...
            SetX(cx);
            SetY(cy);
        }
    }
    // Detecta si el sprite actual colisiona con el que se pasa como parámetro
    public bool ColisionaCon(Sprite s)
    {
        // Consideramos los tamaños de cada sprite para ver si colisionan 
        // horizontalmente
        int tam1 = GetImagen().Length;
        int tam2 = s.GetImagen().Length;

        // Colisionarán en horizontal si uno de los sprites está contenido entre 
        // la coordenada X y la coordenada X + el tamaño del sprite del otro
        bool colisionX = (GetX() <= s.GetX() && GetX() + tam1 >= s.GetX()) ||
                         (s.GetX() <= GetX() && s.GetX() + tam2 >= GetX());
        bool colisionY = GetY() == s.GetY();

        return colisionX && colisionY;
    }

    // Dibujar la nave en sus coordenadas actuales
    public virtual void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(imagen);
    }
}
