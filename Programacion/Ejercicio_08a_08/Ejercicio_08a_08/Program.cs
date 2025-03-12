class Program
{
    static void Main()
    {
        Console.WriteLine("Escribe el texto:");

        using (StreamWriter texto = new StreamWriter("log.txt", true))
        {
            string linea;
            do
            {
                linea = Console.ReadLine();
                if(linea != null)
                {
                    texto.WriteLine(linea);
                }
            }
            while (linea != "");
        }
    }
}