// Programa principal que controlara los diferents elementos.

class Program
{
    static void Main()
    {
        ElementoDomotico[] elementos = new ElementoDomotico[4];
        elementos[0] = new Puerta("Puerta de Roble", true);
        elementos[1] = new Horno("Horno", false, 0);
        elementos[2] = new Horno("Horno de Piedra", true, 190);
        elementos[3] = new Luz("Lampara", true);

        ((IEncendible)elementos[3]).Apagar();
        ((IEncendible)elementos[1]).Encender();

        Array.Sort(elementos);
    
        foreach (ElementoDomotico elemento in elementos)
        {
            Console.WriteLine(elemento);
        }
    }
}