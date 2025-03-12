using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Clase hija encargada de rellenar los apartados normales.
class ApartadoNormal : Apartado
{
    public ApartadoNormal(string titulo, float calificacionMax, float nota)
        : base(titulo, calificacionMax, nota)
    {
    }
}
