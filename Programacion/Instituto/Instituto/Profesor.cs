using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Profesor : Personal
{
    protected string especialidad;

    public Profesor(string dni, string nombre, string telefono, 
        string especialidad) : base(dni, nombre, telefono)
    {
        this.especialidad = especialidad;
    }

    // Getters y setters...
    public string GetEspecialidad()
    {
        return especialidad;
    }
    public void SetEspecialidad(string especialidad)
    {
        this.especialidad = especialidad;
    }
}
