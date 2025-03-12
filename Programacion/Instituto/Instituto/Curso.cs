using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Curso
{
    protected string cursos;

    public Curso(string cursos)
    {
        this.cursos = cursos;
    }

    public string GetCurso()
    {
        return cursos;
    }
}