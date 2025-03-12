class Ejercicio
{
    static void Main()
    {
        List<Libro> libros = new List<Libro>(); 
        string texto;
        int cont = 0;

        do
        {
            texto = Console.ReadLine();
            if(texto != "")
            {
                string[] separado = texto.Split(";");
                Libro nuevo = new Libro(separado[0], Convert.ToInt32(separado[1]));

                libros.Add(nuevo);
            }
        }
        while (texto != "");

        libros.Sort((p1, p2) => p1.GetTitulo().CompareTo(p2.GetTitulo()));

        foreach(Libro l in libros)
        {
            Console.WriteLine(l);
        }

        Console.WriteLine();
        List<Libro> numerosMenores = libros.FindAll(l => l.GetPaginas() > 100);

        foreach (Libro l in numerosMenores)
        {
            Console.WriteLine(l);
        }

        if(!libros.TrueForAll(l => 
            l.GetTitulo().ToLower().Contains("programacion")))
        {
            Console.WriteLine("Hay algun libro que no contiene programacion.");
        }
    }
}