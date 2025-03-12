using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase hija encargada de gestionar los apartados mas importantes.
class ApartadoImportante : Apartado
{
    protected float calificacionMin;
    public ApartadoImportante(string titulo, float calificacionMax, float nota, 
        float calificacionMin) : base(titulo, calificacionMax, nota)
    {
        this.calificacionMin = calificacionMin;
    }

    // Getters y setters...
    public void SetCalificacionMin(float calificacionMin)
    {
        this.calificacionMin = calificacionMin;
    }
    public float GetCalificacionMin()
    {
        return calificacionMin;
    }

    public override string ToString()
    {
        return base.ToString() + "(" + calificacionMin + ")";
    }
}
