using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
// Clase encargada de gestionar los diferentes trabajos que se realicen.
class Trabajo
{
    protected string tituloPractica;
    List<Apartado> apartados;

    public Trabajo(string tituloPractica)
    {
        this.tituloPractica = tituloPractica;
        apartados = new List<Apartado>();
    }

    public string GetTituloPractica()
    {
        return tituloPractica;
    }

    public List<Apartado> GetApartados()
    {
        return apartados;
    }

    public void NuevoApartado(Apartado apartados)
    {
        this.apartados.Add(apartados);
    }

    public float NotaFinal()
    {
        float notaF = 0;

        foreach (Apartado a in apartados)
        {
            notaF = (10 / a.GetCalidifacionMax() * a.GetNota()) + notaF;
        }

        return notaF;
    }

    public bool Aprobado()
    {
        bool aprobado = true;

        if (NotaFinal() < 5)
        {
            aprobado = false;
        }
        else
        {
            foreach (Apartado a in apartados)
            {
                if (a is ApartadoImportante)
                {
                    if (((ApartadoImportante)a).GetCalificacionMin() > a.GetNota());
                    {
                        aprobado = false;
                    }
                }
            }
        }
        return aprobado;
    }
}