class Program
{
    enum tipoPropiedad { SALIR, LOCAL, BUNGALOW, PISO }
    enum opciones { TIPO = 1, ORDENAR, SUPERFICIE, SALIR }

    static opciones Menu()
    {
        Console.WriteLine("Buscar por tipo.");
        Console.WriteLine("Ordenar por precio.");
        Console.WriteLine("Buscar por superficie.");
        Console.WriteLine("Salir.");
        Console.Write("Elige una opcion: ");
        return (opciones)Convert.ToInt32(Console.ReadLine());
    }
    static List<Agente> RellenarAgentes()
    {
        List<Agente> agentes = new List<Agente>();

        agentes.Add(new Agente("Jesus", "712371273"));
        agentes.Add(new Agente("Marcos", "611232412"));
        agentes.Add(new Agente("Santi", "6271273"));
        agentes.Add(new Agente("Lucia", "61263273"));

        return agentes;
    }

    static void RellenarPropiedades(List<Propiedad> propiedades, 
        List<Agente> agentes)
    {
        tipoPropiedad opciones;
        string desc;
        int superficie, precio;
        Agente agente;

        do
        {
            Console.WriteLine("Tipo de propiedad:");
            opciones = (tipoPropiedad)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Descripcion:");
            desc = Console.ReadLine();

            Console.Write("Superficie (m2):");
            superficie = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write("Precio: ");
                precio = Convert.ToInt32(Console.ReadLine());
            }
            while(!Int32.TryParse(Console.ReadLine(), out precio) ||
                precio < 0);
            
            agente = ElegirAgente(agentes);

            switch(opciones)
            {
                case tipoPropiedad.LOCAL:
                    bool aseo = false;
                    Console.WriteLine("¿Tiene aseo?");
                    string respuesta = Console.ReadLine();

                    if(respuesta.ToUpper() == "SI")
                    {
                        aseo = true;
                    }
                    propiedades.Add(new Local(desc, superficie, precio, 
                        agente, aseo));
                    break;

                case tipoPropiedad.BUNGALOW:
                    Console.WriteLine("Superficie de la terraza (m2): ");
                    int superficieT = Convert.ToInt32(Console.ReadLine());
                    propiedades.Add(new Bungalow(desc, superficie, precio, 
                        agente, superficieT));
                    break;

                case tipoPropiedad.PISO:
                    Console.WriteLine("Numero de planta: ");
                    int numPlanta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Numero de habitaciones: ");
                    int numHab = Convert.ToInt32(Console.ReadLine());
                    propiedades.Add(new Piso(desc, superficie, precio, agente,
                        numPlanta, numHab));
                    break;
            }
        }
        while (opciones != tipoPropiedad.SALIR);
    }

    static Agente ElegirAgente(List<Agente> agentes)
    {
        int posicion;
        foreach(Agente a in agentes)
        {
            Console.WriteLine(a);
        }
        Console.Write("Elige un agente:");
        posicion = Convert.ToInt32(Console.ReadLine());

        return agentes[posicion - 1];
    }

    static void BucarTipo(List<Propiedad> propiedades)
    {
        tipoPropiedad tipo;
        bool encontrado = false;

        Console.WriteLine("Tipo a buscar:");
        tipo = (tipoPropiedad)Convert.ToInt32(Console.ReadLine());

        foreach(Propiedad p in propiedades)
        {
            if(tipo == tipoPropiedad.LOCAL && p is Local || 
                tipo == tipoPropiedad.BUNGALOW && p is Bungalow ||
                tipo == tipoPropiedad.PISO && p is Piso )
            {
                encontrado = true;
                Console.WriteLine(p);
            }
        }
        if(!encontrado)
        {
            Console.WriteLine("No existen de ese tipo.");
        }
    }

    static void OrdenarPrecio(List<Propiedad> propiedades)
    {
        propiedades.Sort((p1, p2) => p1.GetPrecio().CompareTo(p2.GetPrecio()));
        propiedades.ForEach(p => Console.WriteLine(p));
    }

    static void BuscarSuperficie(List<Propiedad> propiedades)
    {
        int superficieMinima;
        bool encontrado = false;

        Console.WriteLine();
        superficieMinima = Convert.ToInt32(Console.ReadLine());

        foreach(Propiedad p in propiedades)
        {
            if(p.GetSuperficie() >= superficieMinima)
            {
                encontrado = true;
                Console.WriteLine(p);
            }
        }
        if(!encontrado)
        {
            Console.WriteLine("No se ha encontrado propiedades.");
        }
    }
    static void Main()
    {
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Agente> agentes = RellenarAgentes();

        RellenarPropiedades(propiedades, agentes);
        opciones opciones;

        do
        {
            opciones = Menu();
            switch(opciones)
            {
                case opciones.TIPO:
                    BucarTipo(propiedades);
                    break;

                case opciones.ORDENAR:
                    OrdenarPrecio(propiedades);
                    break;

                case opciones.SUPERFICIE:
                    BuscarSuperficie(propiedades);
                    break;
            }
        }
        while(opciones != opciones.SALIR);

    }
}