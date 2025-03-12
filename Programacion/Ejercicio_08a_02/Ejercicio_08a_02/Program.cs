class Program
{
    static void Main()
    {
        string linea;

        using (StreamReader fichero = new StreamReader("registroDeUsuario.txt"))
        {
            for (int i = 0; i < 3; i++)
            {
                linea = fichero.ReadLine();

                if (linea != null)
                {
                    Console.WriteLine("Leído: {0}", linea);
                }
            }
        }
    }
}