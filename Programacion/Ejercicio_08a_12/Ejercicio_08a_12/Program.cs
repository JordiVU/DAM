using System.ComponentModel;

class Program
{

    enum opcionesJuego { SALIR, AGREGAR, QUITAR, LISTAR }

    static opcionesJuego MostrarOpciones()
    {
        opcionesJuego opcion;

        Console.WriteLine("1. Añadir un nuevo juego.");
        Console.WriteLine("2. Eliminar un juego");
        Console.WriteLine("3. Mostrar los juegos.");
        Console.WriteLine("0. Salir.");
        opcion = (opcionesJuego)Convert.ToInt32(Console.ReadLine());

        return opcion;

    }
    static List<Videojuego> CargarJuegos()
    {
        List<Videojuego> juegos = new List<Videojuego>();

        if (File.Exists("PruebaJuegos.txt"))
        {
            using (StreamReader file = new StreamReader("PruebaJuegos.txt"))
            {
                string linea;

                do
                {
                    linea = file.ReadLine();
                    if (linea != null)
                    {
                        string[] texto = linea.Split(";");
                        if (texto.Length > 2)
                        {
                            juegos.Add(new VideojuegoPC(texto[0], texto[1], 
                                Convert.ToInt32(texto[2]), Convert.ToInt32(texto[3])));
                        }
                        else
                        {
                            juegos.Add(new Videojuego(texto[0], texto[1]));
                        }
                    }
                }
                while (linea != null);
            }
        }

        return juegos;
    }

    static void MostrarJuegos(List<Videojuego> juegos)
    {
        for(int i = 0; i < juegos.Count; i++)
        {
            Console.WriteLine(i + 1 + ". " + juegos[i]);
        }
        Console.WriteLine();
    }

    static void AgregarJuego(List<Videojuego> videojuegos)
    {
        Videojuego nuevo;
        string nuevoJuego;

        Console.Write("Escribe el juego a añadir: ");
        nuevoJuego = Console.ReadLine();

        string[] texto = nuevoJuego.Split(";");

        if (texto.Length == 2)
        {
            nuevo = new Videojuego(texto[0], texto[1]);
        }
        else
        {
            nuevo = new VideojuegoPC(texto[0], texto[1],
                Convert.ToInt32(texto[2]),
                Convert.ToInt32(texto[3]));
        }

        videojuegos.Add(nuevo);
    }

    static void EliminarJuego(List<Videojuego> juegos)
    {
        if (juegos.Count > 0)
        {
            int pos;

            MostrarJuegos(juegos);
            Console.Write("Posicion del videojuego a borrar: ");
            pos = Convert.ToInt32(Console.ReadLine());
            if (pos - 1 >= 0 && pos - 1 < juegos.Count)
            {
                juegos.RemoveAt(pos - 1);
            }
        }
        Console.WriteLine("No hay videojuegos.");
    }

    static void GuardarVideojuego(List<Videojuego> videojuegos)
    {
        using (StreamWriter fichero = new StreamWriter("NUEVOS.txt"))
        {
            foreach (Videojuego v in videojuegos)
            {
                fichero.WriteLine(v.AFichero());
            }
        }
    }
    static void Main()
    {
        List<Videojuego> videojuegos = CargarJuegos();
        opcionesJuego opciones;

        do
        {
            opciones = MostrarOpciones();
            switch (opciones)
            {
                case opcionesJuego.AGREGAR:
                    AgregarJuego(videojuegos);
                    break;

                case opcionesJuego.QUITAR:
                    EliminarJuego(videojuegos);
                    break;

                case opcionesJuego.LISTAR:
                    MostrarJuegos(videojuegos);
                    break;

                case opcionesJuego.SALIR:
                    GuardarVideojuego(videojuegos);
                    break;
            }
        }
        while (opciones != opcionesJuego.SALIR);
    }
}
