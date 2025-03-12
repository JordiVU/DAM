using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase que gestiona la informacion de las habitaciones.
class Habitacion
{
    protected int numeroHabitacion;
    protected string hotel;
    protected int numeroPersonas;

    public Habitacion(string hotel, int numeroHabitacion, int numeroPersonas)
    {
        this.hotel = hotel;
        this.numeroHabitacion = numeroHabitacion;
        this.numeroPersonas = numeroPersonas;
    }

    // Getters y setters...
    public int GetNumeroHabitacion()
    {
        return numeroHabitacion;
    }
    public string GetHotel()
    {
        return hotel;
    }
    public int GetNumeroPersonas()
    {
        return numeroPersonas;
    }
    public void SetNumeroHabitacion(int numeroHabitacion)
    {
        this.numeroHabitacion = numeroHabitacion;
    }
    public void SetHotel(string hotel)
    {
        this.hotel = hotel;
    }
    public void SetNumeroPersonas(int numeroPersonas)
    {
        this.numeroPersonas = numeroPersonas;
    }

    // ToString modificado...
    public override string ToString()
    {
        return hotel + ", habitación" + numeroHabitacion + ", " +
            numeroPersonas + " personas";
    }

}