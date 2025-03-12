using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
// Clase para gestionar los proyectos software de la empresa.
class Proyecto
{
    protected string titulo;
    protected int horas;
    protected Analistas analista;

    public Proyecto(string titulo, int horas, Analistas analista)
    {
        this.titulo = titulo;
        this.horas = horas;
        this.analista = analista;
    }

    // Getters y setters...
    public string GetTitulo()
    {
        return titulo;
    }
    public int GetHoras()
    {
        return horas;
    }
    public void SetTitulo(string titulo)
    {
        this.titulo = titulo;
    }
    public void SetHoras(int horas)
    {
        this.horas = horas;
    }

    // ToString modificado...
    public override string ToString()
    {
        return titulo + " (" + horas + " horas), Supervisor: " + analista;
    }
}
