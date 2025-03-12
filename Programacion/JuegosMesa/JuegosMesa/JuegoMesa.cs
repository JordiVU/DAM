using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase que gestiona la informacion de los juegos de mesa
class JuegoMesa
{
    public enum tipoJuego { ROL = 1, INFANTIL, AZAR, PUZZLE, OTROS }

    private string nombre;
    private float precio;
    private tipoJuego tipo;
    private int minEdad;
    private int minJugadores;
    private int maxJugadores;

    public JuegoMesa()
    {
        nombre = "";
        precio = 1;
        tipo = tipoJuego.OTROS;
        minEdad = 0;
        minJugadores = 0;
        maxJugadores = 0;
    }
    public JuegoMesa(string nombre, float precio, tipoJuego tipo, int minEdad,
            int minJugadores, int maxJugadores)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.tipo = tipo;
        this.minEdad = minEdad;
        this.minJugadores = minJugadores;
        this.maxJugadores = maxJugadores;
    }

    // Mostrar toda la informacion del juego.

    public void Mostrar()
    {
        Console.WriteLine(nombre + "(" + tipo + "):" + precio + ", min " + 
            minEdad + " años, Jugadores " + minJugadores + "-" + maxJugadores);
    }

    // Getters y Setters...

    public string GetNombre()
    {
        return nombre;
    }

    public float GetPrecio()
    {
        return precio;
    }

    public tipoJuego GetTipo()
    {
        return tipo;
    }

    public int GetMinEdad()
    {
        return minEdad;
    }

    public int GetMinJugadores()
    {
        return minJugadores;
    }

    public int GetMaxJugadores()
    {
        return maxJugadores;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetPrecio(float precio)
    {
        if(precio > 1)
        {
            this.precio = precio;
        }
        else
        {
            this.precio = 1;
        }
    }

    public void SetTipo(tipoJuego tipo)
    {
        if(tipo == tipoJuego.ROL || tipo == tipoJuego.OTROS || 
            tipo == tipoJuego.AZAR || tipo == tipoJuego.PUZZLE ||
            tipo == tipoJuego.INFANTIL)
        {
            this.tipo = tipo;
        }
        else
        {
            this.tipo = tipoJuego.OTROS;
        }
    }

    public void SetMinEdad(int minEdad)
    {
        if(minEdad > 0)
        {
            this.minEdad = minEdad;
        }
        else
        {
            this.minEdad = 0;
        }
    }

    public void SetMinJugadores(int minJugadores)
    {
        if (minJugadores > 0)
        {
            this.minJugadores = minJugadores;
        }
        else
        {
            this.minJugadores = 0;
        }
    }

    public void SetMaxJugadores(int  maxJugadores)
    {
        if (maxJugadores > 0)
        {
            this.maxJugadores = maxJugadores;
        }
        else
        {
            this.maxJugadores = 0;
        }
    }
}
