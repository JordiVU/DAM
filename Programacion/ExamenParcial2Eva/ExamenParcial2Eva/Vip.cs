using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase que gestiona la informacion de los clientes VIP.

class Vip : Cliente
{
    protected Habitacion habitacion;

    public Vip(string dni, string nombre, int edad, Habitacion habitacion) : 
        base(dni, nombre, edad)
    {
        this.habitacion = habitacion;
    }

    // Getters y setters....
    public Habitacion GetHabitacion()
    {
        return habitacion;
    }
    public void SetHabitacion(Habitacion habitacion)
    {
        this.habitacion = habitacion;
    }

    // ToString modificado...
    public override string ToString()
    {
        return base.ToString() + habitacion.ToString();
    }

}