using System.Collections;

class Program
{
    static void Main()
    {
        Dictionary<string, Trabajador> trabajadores = new Dictionary<string, Trabajador>();
        string ss, nombre, tlf;

        Console.WriteLine("--RELENA LOS DATOS--");
        do
        {
            Console.Write("Numero Seguridad Social:");
            ss = Console.ReadLine();

            if (ss != "")
            {
                Console.Write("Nombre:");
                nombre = Console.ReadLine();

                Console.Write("Telefono:");
                tlf = Console.ReadLine();

                trabajadores.Add(ss, new Trabajador(ss, nombre, tlf));
            }
            Console.WriteLine();
        }
        while (ss != "");

        // Forma de mostrar con Foreach
        /*foreach (KeyValuePair<string, Trabajador> dato in  trabajadores)
        {
            Console.WriteLine(dato.Key + "- " + dato.Value);
        }*/

        // Forma de mostrar Enumerador
        IDictionaryEnumerator enumerador = trabajadores.GetEnumerator();
        while (enumerador.MoveNext())
        {
            Console.WriteLine(ss + "- " + enumerador.Value);
        }
    }

    static void SegunaParte()
    {

    }
}