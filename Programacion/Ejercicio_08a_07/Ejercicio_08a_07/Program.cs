class Program
{
    static void Main()
    {
        List<Persona> list = new List<Persona>();
        string[] texto;
        string linea;

        using (StreamReader fichero = new StreamReader("prueba.txt"))
        {
            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                {
                    texto = linea.Split(';');
                    list.Add(new Persona(texto[0], Convert.ToInt32(texto[1])));
                }
            }
            while (linea != null);

            foreach (Persona p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
