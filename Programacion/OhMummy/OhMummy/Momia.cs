using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase que gestiona a la momia
enum direccionMomia { IZQUIERDA, DERECHA, ARRIBA, ABAJO }
class Momia : Sprite
{
    direccionMomia direccion;
    public Momia(int cx, int cy, direccionMomia direccion)
    : base(cx, cy, "" + (char)20)
    {
        this.direccion = direccion;
    }
    public direccionMomia GetDireccion()
    {
        return direccion;
    }
    public void SetDireccion(direccionMomia direccion)
    {
        this.direccion = direccion;
    }
    // Redefinición del método Dibujar
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        base.Dibujar();
    }
}