using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class Coche
{
    protected string marca;
    protected string modelo;
    protected int anyo;
    protected int precioV;

    public Coche(string marca, string modelo, int anyo, int precioV)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.anyo = anyo;
        this.precioV = precioV;
    }

    public static void SerializarJSON(List<Coche> coches)
    {
        var opciones = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(coches, opciones);
        File.WriteAllText("coches.json", jsonString);
    }

    public static List<Coche> DeserializarJSON()
    {
        string jsonString2 = File.ReadAllText("videojuegos.json");
        List<Coche> listado =
            JsonSerializer.Deserialize<List<Coche>>(jsonString2);
        return listado;
    }

    public void SetMarca(string marca)
    {
        this.marca = marca;
    }
    public void SetModelo(string modelo)
    {
        this.modelo = modelo;
    }
    public void SetAnyo(int anyo)
    {
        this.anyo = anyo;
    }
    public void SetPrecioV(int precioV)
    {
        this.precioV = precioV;
    }

    public string GetMarca()
    {
        return marca;
    }
    public string GetModelo()
    {
        return modelo;
    }
    public int GetAnyo()
    {
        return anyo;
    }
    public int GetPrecioV()
    {
        return precioV;
    }

    public override string ToString()
    {
        return base.ToString();
    }

}