using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Clase abstracta padre, encargada de gestionar los apartados.
abstract class Apartado
{
    protected string titulo;
    protected float calificacionMax;
    protected float nota;

    public Apartado(string titulo, float calificacionMax, float nota)
    {
        this.titulo = titulo;
        this.calificacionMax = calificacionMax;
        this.nota = nota;
    }

    // Getters y setters...
    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }
    public void SetCalificacionMax(float calificacioMax)
    {
        this.calificacionMax = calificacioMax;
    }
    public void SetNota(float nota)
    {
        this.nota = nota;
    }

    public string GetTitulo()
    {
        return titulo;
    }
    public float GetCalidifacionMax()
    {
        return calificacionMax;
    }

    public float GetNota()
    {
        return nota;
    }

    public override string ToString()
    {
        return "- " + titulo + ": " + nota + " / " + calificacionMax;
    }
}