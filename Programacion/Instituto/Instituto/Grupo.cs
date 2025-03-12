using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Grupo
{
    protected string grupos;
    protected char nombreG;
    protected string aula;
    protected Curso cursos;
    protected Profesor tutor;

    public Grupo(string grupos, char nombreG, string aula, Curso cursos, 
        Profesor tutor)
    {
        this.grupos = grupos;
        this.nombreG = nombreG;
        this.aula = aula;
        this.cursos = cursos;
        this.tutor = tutor;
    }

    // Getters y setters...
    public string GetGrupos()
    {
        return grupos;
    }
    public char GetNombreG()
    {
        return nombreG;
    }
    public string GetAula()
    {
        return aula;
    }
    public Profesor GetTutor()
    {
        return tutor;
    }
    public void SetGrupos(string grupos)
    {
        this.grupos = grupos;
    }
    public void SetNombreG(char nombreG)
    {
        this.nombreG = nombreG;
    }
    public void SetAula(string aula)
    {
        this.aula = aula;
    }
    public void SetProfesor(Profesor profesor)
    {
        this.SetProfesor(profesor);
    }

    // ToString...
    public override string ToString()
    {
        return grupos + " - " + cursos.GetCurso() + " " + nombreG + "(" + aula + ")" + 
            "Tutor: " + tutor.GetNombre();
    }
}