class Program
{
    static void Main()
    {
        string nombre;

        Console.Write("Nombre del fichero: ");
        nombre = Console.ReadLine();
        int cont = 0;

        if (File.Exists(nombre))
        {
            using (StreamReader fichero = new StreamReader(nombre))
            {
                string linea;
                ConsoleKeyInfo tecla = new ConsoleKeyInfo();

                do
                {
                    linea = fichero.ReadLine();
                    Console.WriteLine(linea);
                    cont++;

                    if (cont == 24)
                    {
                        Console.WriteLine("Pulsa enter para continuar...");
                        Console.ReadLine();
                        cont = 0;
                    }
                }
                while (linea != null);
            }
        }
        else
        {
            Console.WriteLine("El fichero no existe.");
        }
    }
}