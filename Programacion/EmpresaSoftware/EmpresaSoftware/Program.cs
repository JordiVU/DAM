class Principal
{
    static Trabajadores[] RellenarTrabajadores()
    {
        Trabajadores[] trabajadores = new Trabajadores[7];
        trabajadores[0] = new Programadores("58721741J", "Jordi", "C#");
        trabajadores[1] = new Programadores("91351232D", "Jesus", "Python");
        trabajadores[2] = new Programadores("12359132H", "Judas", "Java");
        trabajadores[3] = new Programadores("81273183B", "Adam", "Java");
        trabajadores[4] = new Programadores("71237812F", "Eva", "C#");
        trabajadores[5] = new Analistas("19124151K", "Kayn", 10);
        trabajadores[6] = new Analistas("81284717M", "Abel", 20);

        ((Programadores)trabajadores[0]).SetPareja((Programadores)trabajadores[1]);
        ((Programadores)trabajadores[2]).SetPareja((Programadores)trabajadores[3]);


        return trabajadores;
    }
    static void MostrarParejas(Trabajadores[] trabajadores)
    {
        bool encontrado = false;

        Console.WriteLine("--PAREJAS DE PROGRAMADORES--");

        foreach (Trabajadores t in trabajadores)
        {
            if (t is Programadores tp && tp.TienePareja())
            {
                Console.WriteLine(tp);
                encontrado = true;
            }
        }
        if(!encontrado)
        {
            Console.WriteLine("No hay parejas de programadores.");
        }
        Console.WriteLine();
    }
    static void MostrarAnalistas(Trabajadores[] trabajadores)
    {
        bool encontrado = false;

        Console.WriteLine("--ANALISTAS--");
        foreach (Trabajadores t in trabajadores)
        {
            if (t is Analistas)
            {
                Console.WriteLine(t);
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            throw new Exception("No hay analistas disponibles.");
        }
        Console.WriteLine();

    }
    static Proyecto NuevoProyecto(Trabajadores[] trabajadores)
    {
        Analistas escogido;
        string titulo;
        int horas;

        Console.Write("Titulo el proyecto: ");
        titulo = Console.ReadLine();

        Console.Write("Duracion: ");
        horas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        MostrarAnalistas(trabajadores);

        escogido = EscogerAnalista(trabajadores);

        return new Proyecto(titulo, horas, escogido);
    }
    static Analistas EscogerAnalista(Trabajadores[] trabajadores)
    {
        Analistas resultado = null;

        string respuesta;

        Console.Write("Escoge un analista por DNI: ");

        respuesta = Console.ReadLine();

        for (int i = 0; i < trabajadores.Length; i++)
        {
            if (respuesta == trabajadores[i].GetDni())
            {
                resultado = (Analistas)trabajadores[i];
            }
        }
        if(resultado == null)
        {
            throw new Exception("Los datos no coinciden.");
        }

        return resultado;
    }
    static void Main()
    {
        Trabajadores[] trabajadores = RellenarTrabajadores();

        string respuesta;

        MostrarParejas(trabajadores);

        ((Programadores)trabajadores[1]).SetPareja((Programadores)trabajadores[4]);
        ((Programadores)trabajadores[2]).SetPareja((Programadores)trabajadores[3]);

        MostrarParejas(trabajadores);

        Console.WriteLine("¿Crear nuevo proyecto? (SI | NO):");
        respuesta = Console.ReadLine();


        if (respuesta == "SI")
        {
            Proyecto p;
            try
            {
                p = NuevoProyecto(trabajadores);

                Console.WriteLine("\n--PROYECTO CREADO--");
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        else
        {
            Console.WriteLine("Finalizando programa...");
        }
    }
}