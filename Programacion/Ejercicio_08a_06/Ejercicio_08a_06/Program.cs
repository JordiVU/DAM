class Program
{
    static void Main()
    {
        SortedSet<string> texto = new SortedSet<string>();

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

        using (StreamWriter ordenado = new StreamWriter("ordenado.txt"))
        {
            
            foreach(string t in texto)
            {
                ordenado.WriteLine(t);
            }
        }
    }
}