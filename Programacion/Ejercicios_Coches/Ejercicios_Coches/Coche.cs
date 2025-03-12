using System;

class Coche : Vehiculo
{
    public Coche()
    {
        marca = "";
        modelo = "";
        cilindrada = 0;
        potencia = 0;
        cantidadDeRuedas = 4;
    }

    public Coche(string m, string mdl, int c, float p)
    {
        marca = m;
        modelo = mdl;
        cilindrada = c;
        potencia = p;
    }
}