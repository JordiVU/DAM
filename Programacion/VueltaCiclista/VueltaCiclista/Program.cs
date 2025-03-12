using System.Globalization;
// Programa principal
class Program
{
    static List<Ciclistas> RellenarCiclitas(List<Ciclistas> ciclistas)
    {
        ciclistas.Add(new Ciclistas(10, "Jordi Vázquez", "Fnatic"));
        ciclistas.Add(new Ciclistas(14, "Jorge Ramirez", "G2"));
        ciclistas.Add(new Ciclistas(7, "Santiago Colombian", "KOI"));
        ciclistas.Add(new Ciclistas(11, "Alvaro Maxista", "Samsung"));
        ciclistas.Add(new Ciclistas(22, "Hector Fitt", "SKT"));

        return ciclistas;
    }

    static void ComprobarFecha(string fecha)
    {
        string[] separado = fecha.Split('-');

        if(fecha.Length != 10 || separado[0].Length != 4 || 
            separado[1].Length != 2 || 
            separado[2].Length != 2 )
        {
            throw new Exception("ERROR: Formato de fecha equivocado.");
        }
        else
        {
            string junto;

            junto = string.Join("", separado);

            foreach(char s in junto)
            {
                if(s > '9' || s < '0')
                {
                    throw new Exception("ERROR: Caracter no valido.");
                }
            }
        }
    }

    static void MostrarCiclistas(List<Ciclistas> ciclistas)
    {
        for(int i  = 0; i < ciclistas.Count; i++)
        {
            Console.WriteLine(i + 1 + ". " + ciclistas[i]);
        }
    }

    static void ElegirPodium(List<Ciclistas> ciclistas, SortedList<string, Etapa>
        etapas, string fecha)
    {
        List<Ciclistas> elegidos = new List<Ciclistas>();
        int eleccion;
        Etapa nueva;

        do
        {
            MostrarCiclistas(ciclistas);
            eleccion = Convert.ToInt32(Console.ReadLine());

            if (elegidos.Contains(ciclistas[eleccion - 1]))
            {
                Console.WriteLine("ERROR: No puedes repetir ciclista, escoge otro.");
            }
            else
            {
                elegidos.Add(ciclistas[eleccion - 1]);
            }
        }
        while(elegidos.Count != 3);

        nueva = new Etapa(fecha);

        for(int i = 0; i < 3; i++)
            nueva.SetCiclista(elegidos[i], i);

        etapas.Add(fecha, nueva);
    }
    
    static void MostrarEtapas(SortedList<string, Etapa> etapas)
    {
        if (etapas.Count > 0)
        {
            Console.WriteLine("--ETAPAS--");
            for (int i = 0; i < etapas.Count; i++)
            {
                Console.WriteLine(etapas.Values[i]);
            }
        }
        else
        {
            Console.WriteLine("No existen etapas.");
        }
    }
    static void MostrarGanadores(SortedList<string, Etapa> etapas)
    {
        if (etapas.Count > 0)
        {
            Console.WriteLine("--GANADORES--");
            HashSet<Ciclistas> ganadores = new HashSet<Ciclistas>();

            for (int i = 0; i < etapas.Count; i++)
            {
                ganadores.Add(etapas.Values[i].GetCiclistaGanador());
            }

            foreach (Ciclistas c in ganadores)
            {
                Console.WriteLine(c);
            }
        }
    }
    static void Main()
    {
        List<Ciclistas> ciclistas = new List<Ciclistas>();
        ciclistas = RellenarCiclitas(ciclistas);
        SortedList<string, Etapa> etapas
            = new SortedList<string, Etapa>();
        string fecha = null;

        do
        {
            try
            {
                Console.WriteLine("Fecha de la etapa:");
                fecha = Console.ReadLine();
                if (fecha != "")
                {
                    ComprobarFecha(fecha);

                    ElegirPodium(ciclistas, etapas, fecha);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        while (fecha != "");

        MostrarEtapas(etapas);
        Console.WriteLine();
        MostrarGanadores(etapas);
    }
}