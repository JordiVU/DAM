class Program
{
    static void Main()
    {
        using(StreamReader fichero = new StreamReader("Datos.txt"))
        {
            string linea;

            do
            {
                linea = fichero.ReadLine();
                if(linea != null)
                {
                    if (linea.Contains("programa"))
                    {
                        Console.WriteLine(linea);
                    }
                }
            }
            while (linea != null);
        }
    }
}