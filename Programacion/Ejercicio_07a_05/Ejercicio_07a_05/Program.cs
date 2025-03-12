class Ejercicio
{
    static void Main()
    {
        List<string> lista = new List<string>();
        string buscar;
        string texto;

        Console.WriteLine("Escribe un texto:");

        do
        {
            texto = Console.ReadLine();
            if(texto != "")
            {
                lista.Add(texto);
            }
        }
        while (texto != "");

        Console.WriteLine("Busca un texto:");
        buscar = Console.ReadLine();

        for(int i = 0; i < lista.Count; i++)
        {
            if (lista[i].Contains(buscar))
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
