using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Circulo : IFiguraGeometrica
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}