using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase abstractca para todos los elementos sprite
abstract class Sprite
{
    protected int x;
    protected int y;
    protected string imagen;
    protected Sprite(int x, int y, string imagen)
    {
        this.x = x;
        this.y = y;
        this.imagen = imagen;
    }
    public int GetX()
    {
        return x;
    }
    public int GetY()
    {
        return y;
    }
    public string GetImagen()
    {
        return imagen;
    }
    public void SetX(int cx)
    {
        x = cx;
    }
    public void SetY(int cy)
    {
        y = cy;
    }
    public void SetImagen(string img)
    {
        imagen = img;
    }
    public virtual void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(imagen);
        Console.ResetColor();
    }
}