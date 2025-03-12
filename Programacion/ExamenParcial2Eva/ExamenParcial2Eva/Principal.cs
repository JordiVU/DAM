/* Programa que gestiona a los clientes junto a sus habitaciones asociadas a
 los clientes VIP, de un parque de atracciones.
*/
class Principal
{
    enum opcionSolicitud { SALIR, NUEVA, BUSCARC, BUSCARH, LISTAR };

    static opcionSolicitud MostrarMenu()
    {
        opcionSolicitud opcionUsuario;
        Console.WriteLine();
        Console.WriteLine("1. Nuevo cliente");
        Console.WriteLine("2. Buscar por cliente");
        Console.WriteLine("3. Buscar por habitacion");
        Console.WriteLine("4. Listar clientes");
        Console.WriteLine("0. Salir");
        Console.Write("Elige una opción del menú: ");
        opcionUsuario = (opcionSolicitud)Convert.ToInt32(Console.ReadLine());
        return opcionUsuario;
    }
    static Habitacion[] CrearHabitaciones()
    {
        // Creamos un array con las habitaciones que se van a usar...
        Habitacion[] habitaciones = new Habitacion[4];
        habitaciones[0] = new Habitacion("Marina D'or", 303, 4);
        habitaciones[1] = new Habitacion("Jordi Express", 401, 2);
        habitaciones[2] = new Habitacion("Marina D'or", 101, 5);
        habitaciones[3] = new Habitacion("Jorge El Tacaño", 245, 2);

        return habitaciones;
    }
    static void NuevoCliente(Cliente[] clientes ,Habitacion[] habitaciones,
        ref int cant)
    {
        string tipo, dni, nombre;
        int edad;
        Cliente cliente;

        // El usuario introduce el tipo de cliente que desea...
        Console.Write("Cliente normal o VIP?: ");
        tipo = Console.ReadLine();

        // Rellenamos la informacion principal de cliente...
        Console.Write("DNI: ");
        dni = Console.ReadLine();

        // Comprobamos que el DNI no exista ya....
        if (cant < 0)
        {
            ComprobarDni(clientes, dni);
        }

        Console.Write("Nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Edad: ");
        edad = Convert.ToInt32(Console.ReadLine()) - 1;

        if(tipo == "VIP")
        {
            int numHabitacion;
            MostrarHabitaciones(habitaciones);
            do
            {
                Console.Write("Escoger habitacion: ");
                numHabitacion = Convert.ToInt32(Console.ReadLine());

                clientes[cant] = new Vip(dni, nombre, edad,
                    habitaciones[numHabitacion]);
            }
            while (numHabitacion > habitaciones.Length 
            || numHabitacion < 1);
        }
        else
        {
            clientes[cant] = new Cliente(dni, nombre, edad);
        }

        cant++;
    }
    static void MostrarHabitaciones(Habitacion[] habitaciones)
    {
        int contador = 1;

        for (int i = 0; i < habitaciones.Length; i++)
        {
            Console.WriteLine(contador + ". " + habitaciones[i]);
            contador++;
        }
    }
    static void ComprobarDni(Cliente[] clientes, string dni)
    {
        foreach (Cliente c in clientes)
        {
            if (c.GetDni() == dni)
                throw new Exception("El ID de solicitud ya existe");
        }
    }
    static void BucarCliente(Cliente[] clientes, Habitacion[] habitaciones,
        int cant)
    {
        if (cant > 0)
        {
            string dni;

            Console.Write("DNI del cliente: ");
            dni = Console.ReadLine();

            ComprobarDni(clientes, dni);

            MostrarCliente(clientes, habitaciones, dni, cant);
        }
        else
        {
            Console.WriteLine("No existen clientes.");
        }
    }
    static void MostrarCliente(Cliente[] clientes, Habitacion[] habitaciones,
        string dni, int cant)
    {
        bool encontrado = false;
        for(int i = 0; i < cant; i++)
        {
            if (clientes[i].GetDni() == dni)
            {
                Console.WriteLine(clientes[i]);
                encontrado = true;
            }
        }
        if(!encontrado)
        {
            Console.WriteLine("No hay clientes con ese dni.");
        }
    }
    static void ListarClientes(Cliente[] clientes, Habitacion[] habitaciones,
        int cant)
    {
        if(cant > 0)
        {
            for(int i = 0; i < cant; i++)
            {
                if (clientes[i] is Vip)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(clientes[i]);
                Console.ResetColor();
            }
        }
        else
        {
            Console.WriteLine("No hay clientes...");
        }

    }
    static void Main()
    {
        opcionSolicitud opcionUsuario;
        Habitacion[] habitaciones = CrearHabitaciones();
        Cliente[] clientes = new Cliente[20];
        int cant = 0;

        do
        {
            opcionUsuario = MostrarMenu();
            switch (opcionUsuario)
            {
                case opcionSolicitud.NUEVA:
                    try
                    {
                        NuevoCliente(clientes, habitaciones, ref cant);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    break;

                case opcionSolicitud.BUSCARC:
                    BucarCliente(clientes, habitaciones, cant);
                    break;

                case opcionSolicitud.BUSCARH:
                    //BuscarHabitacion(clientes, habitaciones, cant);
                    break;

                case opcionSolicitud.LISTAR:
                    ListarClientes(clientes, habitaciones, cant);
                    break;
            }
        }
        while (opcionUsuario != opcionSolicitud.SALIR);

    }
}
