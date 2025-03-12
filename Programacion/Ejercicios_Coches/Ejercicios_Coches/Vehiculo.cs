using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Vehiculo
{
    protected string marca;
    protected string modelo;
    protected int cilindrada;
    protected float potencia;
    protected int cantidadDeRuedas;
    protected int velocidad;

    public Vehiculo()
    {
        marca = "";
        modelo = "";
        cilindrada = 0;
        potencia = 0;
    }

    public Vehiculo(string m, string mdl, int c, float p)
    {
        marca = m;
        modelo = mdl;
        cilindrada = c;
        potencia = p;
    }
    public void SetMarca(string m)
    {
        marca = m;
    }

    public void SetModelo(string mdl)
    {
        modelo = mdl;
    }

    public void SetCilindrada(int c)
    {
        cilindrada = c;
    }

    public void SetPotencia(float p)
    {
        potencia = p;
    }

    public void SetCantidadDeRuedas(int cantidadDeRuedas)
    {
        this.cantidadDeRuedas = cantidadDeRuedas;
    }

    public int GetCilindrada()
    {
        return cilindrada;
    }

    public string GetMarca()
    {
        return marca;
    }

    public void Circular()
    {
        velocidad = 50;
    }

    public void Circular(int velocidad)
    {
        this.velocidad = velocidad;
    }
    public void MostraVehiculo()
    {
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Cilindrada: " + cilindrada);
        Console.WriteLine("Potencia: " + potencia);
        Console.WriteLine("Velocidad: " + velocidad);
        Console.WriteLine("Cantidad de ruedas: " + cantidadDeRuedas);
        Console.WriteLine();
    }
}