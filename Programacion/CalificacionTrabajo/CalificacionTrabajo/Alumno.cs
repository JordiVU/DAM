using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase que gestiona los diferentes alumnos.
class Alumno
{
    protected string nombre;
    protected Trabajo trabajos;

    public Alumno(string nombre, Trabajo trabajos)
    {
        this.nombre = nombre;
        this.trabajos = trabajos;
    }

    // Getters y setters...
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public void SetTrabajos(Trabajo trabajos)
    {
        this.trabajos = trabajos;
    }

    public Trabajo GetTrabajo()
    {
        return trabajos;
    }
    public string GetNombre()
    {
        return nombre;
    }
}
