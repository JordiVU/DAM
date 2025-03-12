using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangulo : IFiguraGeometrica
{
    private double lado;
    private double bases;

    public Rectangulo(double lado, double bases)
    {
        this.lado = lado;
        this.bases = bases;
    }

    public double CalcularArea()
    {
        return lado * bases;
    }

    public double CalcularPerimetro()
    {
        return 2 * lado + 2 * bases;
    }
}