using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase que gestiona las solicitudes de reserva.
class SolicitudReserva : Solicitud
{
    protected string reservar;
    protected string fechaReserva;
    protected string horaInicio;
    protected int duracion;

    public SolicitudReserva(string fecha, string idf, Administrativo administrativo,
        string reservar, string fechaReserva, string horaInicio, int duracion)
        : base(fecha, idf, administrativo)
    {
        this.reservar = reservar;
        this.fechaReserva = fechaReserva;
        this.horaInicio = horaInicio;
        this.duracion = duracion;
    }

    // Getters y setters....
    public string GetReservar()
    {
        return reservar;
    }
    public string GetFechaReserva()
    {
        return fechaReserva;
    }
    public string GetHoraInicio()
    {
        return horaInicio;
    }
    public int GetDuracion()
    {
        return duracion;
    }

    public void SetReserva(string reservar)
    {
        this.reservar = reservar;
    }

    public void SetFechaReserva(string fechaReserva)
    {
        this.fechaReserva = fechaReserva;
    }
    public void SetHoraInicio(string horaInicio)
    {
        this.horaInicio = horaInicio;
    }
    public void SetDuracion(int duracion)
    {
        this.duracion = duracion;
    }
    public override string ToString()
    {
        return "Solicitud de Reserva." + base.ToString() + "Espacio de reserva "
            + reservar + ". Fecha de la reserva " + fechaReserva + 
            ". Hora de inicio " + horaInicio + ". Duracion " + duracion;
    }
}