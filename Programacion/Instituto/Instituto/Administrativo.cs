using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Administrativo : Personal
{
    private char nivel;

    public Administrativo(string dni, string nombre, string telefono, char nivel)
        : base(dni, nombre, telefono)
    {
        this.nivel = nivel;
    }

    // Getters y setters...
    public char GetNivel()
    {
        return nivel;
    }
    public void SetNivel(char nivel)
    {
        this.nivel = nivel;
    }
}
