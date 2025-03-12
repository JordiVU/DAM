class Program
{
    static void Main()
    {
        IFiguraGeometrica[] figuras = new IFiguraGeometrica[3];
        figuras[0] = new Rectangulo(8, 3);
        figuras[1] = new Cuadrado(4);
        figuras[2] = new Circulo(3.7);

        foreach (IFiguraGeometrica f in figuras)
        {
            Console.WriteLine(f);
            Console.WriteLine("Area: " + f.CalcularArea());
            Console.WriteLine("Perimetro: " + f.CalcularPerimetro());
            Console.WriteLine("----------");
        }
    }
} 