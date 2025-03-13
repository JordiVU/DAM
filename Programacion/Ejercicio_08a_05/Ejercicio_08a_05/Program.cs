class Program
{
    static void Main()
    {
        List<string> texto = new List<string>();
        string busca;

        using (StreamReader fichero = new StreamReader("diccionario.txt"))
        {
            string linea;

            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                {
                    texto.Add(linea);
                }
            }
            while (linea != null);
        }

        do
        {
            Console.Write("Texto a buscar: ");
            busca = Console.ReadLine();

            for (int i = 0; i < texto.Count(); i++)
            {
                if (texto[i].Contains(busca))
                {
                    Console.WriteLine(i + ". " + texto[i]);
                }
            }
        }
        while (busca != "");


    }
}