using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Poliza
{
    private int id;
    private float precio;
    private Usuario usuarios;

    public Poliza ()
    {
        this.id = 0;
        this.precio = 0;
    }

    public Poliza(int id, float precio)
    {
        this.id = id;
        this.precio = precio;
    }

    public void SetPrecio (float precio)
    {
        this.precio = precio;
    }
    public void SetPrecio (int id)
    {
        this.id = id;
    }
    public int GetId ()
    {
        return this.id;
    }
    public float GetPrecio ()
    {
        return this.precio;
    }

    public void SetUsuario (Usuario usuarios)
    {
        this.usuarios = usuarios;
    }

    public void Mostrar()
    {
        Console.WriteLine("Poliza " + id + " - " + precio + " euros/año");
        Console.WriteLine("Contratada por " + usuarios.GetNombre());
    }
}
