using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
// Programa que gestiona las diferentes solicitudes administrativas.
class Principal
{
    enum opcionSolicitud { SALIR, NUEVA, BUSCAR, MOSTRAR, PENDIENTE };
    enum tipoSolicitud { DOMICILIACION = 1, TASAS, RESERVA }
    static opcionSolicitud MostrarMenu()
    {
        opcionSolicitud opcionUsuario;
        Console.WriteLine("1. Nueva solicitud");
        Console.WriteLine("2. Buscar solicitudes por administrativo");
        Console.WriteLine("3. Mostrar listado de solicitudes");
        Console.WriteLine("4. Total pendiente de pago");
        Console.WriteLine("0. Salir");
        Console.Write("Elige una opción del menú: ");
        opcionUsuario = (opcionSolicitud)Convert.ToInt32(Console.ReadLine());
        return opcionUsuario;
    }

    static void NuevaSolicitud(List<Solicitud> solicitudes, 
        List<Administrativo> admin, ref int cant)
    {
        if (cant < solicitudes.Count)
        {
            tipoSolicitud tipo;
            string fecha, idf, dni;
            int elegido;

            // Escoger tipo de solicitud...
            Console.Write("Tipo de solicitud (1. Domiciliacion |" +
                " 2. Tasas | 3. Reserva): ");
            tipo = (tipoSolicitud)Convert.ToInt32(Console.ReadLine());

            // Rellenar datos generales...
            Console.Write("Fecha: ");
            fecha = Console.ReadLine();

            Console.Write("Identificador: ");
            idf = Console.ReadLine();
            if (cant > 0)
            {
                if (!ComprobarIdf(solicitudes, idf, cant))
                {
                    throw new Exception("Identificador repetido.");
                }
            }

            // Asignamos un administrativo...
            MostrarAdministrativo(admin);
            Console.Write("Escoge el administrativo por DNI: ");
            dni = Console.ReadLine();
            elegido = CompararAdministrativo(admin, dni);

            // Comprobacion de que el administrativo exista...
            if (elegido == -1)
            {
                throw new Exception("No se ha encontrado un administrativo" +
                    " con el DNI indicado.");
            }
            else
            {
                // Rellenar datos segun el tipo...
                if (tipo == tipoSolicitud.DOMICILIACION)
                {
                    string numCuenta;
                    Console.Write("Numero de cuenta: ");
                    numCuenta = Console.ReadLine();

                    if(numCuenta.Length > 20 && !ComprobarDigitos(numCuenta) )
                    {
                        throw new Exception("Valores superiores a los permitidos");
                    }

                    solicitudes[cant] =
                        new SolicitudDomiciliacion(fecha, idf, admin[elegido],
                        numCuenta);
                }
                else if (tipo == tipoSolicitud.TASAS)
                {
                    string concepto;
                    float importe;

                    Console.Write("Concepto: ");
                    concepto = Console.ReadLine();

                    Console.Write("Importe: ");
                    importe = Convert.ToInt32(Console.ReadLine());
                    if(importe < 0)
                    {
                        throw new Exception("El importe debe ser positivo.");
                    }

                    solicitudes[cant] =
                        new SolicitudTasas(fecha, idf, admin[elegido], concepto,
                        importe);
                }
                else if (tipo == tipoSolicitud.RESERVA)
                {
                    string reservar, fechaReserva, horaInicio;
                    int duracion;

                    Console.Write("Espacio a reservar: ");
                    reservar = Console.ReadLine();

                    Console.Write("Fecha de la reserva: ");
                    fechaReserva = Console.ReadLine();

                    Console.Write("Hora de inicio: ");
                    horaInicio = Console.ReadLine();

                    Console.Write("Duracion: ");
                    duracion = Convert.ToInt32(Console.ReadLine());

                    solicitudes[cant] = new SolicitudReserva(fecha, idf,
                        admin[elegido], reservar, fechaReserva, horaInicio, duracion);
                }
                cant++;
            }
        }
    }

    static int CompararAdministrativo(Administrativo[] admin, string dni)
    {
        // Recorremos el array buscando la coincidencia de DNI...
        for(int i = 0; i <  admin.Length; i++)
        {
            if (admin[i].GetDni() == dni)
            {
                return i;
            }
        }
        return -1;
    }
    static void MostrarAdministrativo(Administrativo[] admin)
    {
        // Mostramos todos ilos administrativos...
        foreach(Administrativo administrativo in admin)
        {
            Console.WriteLine("Nombre:" + administrativo.GetNombre());
            Console.WriteLine("DNI: " + administrativo.GetDni());
            Console.WriteLine("Telefono: " + administrativo.GetTelefono());
            Console.WriteLine();
        }
    }

    static bool ComprobarIdf(Solicitud[] solicitudes, string idf, int cant)
    {
        //Recorremos el array buscando la coincidencia de IDF...
        for (int i = 0; i < cant; i++)
        {
            if (solicitudes[i].GetIdf().Equals(idf))
            {
                return false;
            }
        }
        return true;
    }

    static bool ComprobarDigitos(string numCuenta)
    {
        // Comprobamos que cada letra este contemplada entre 0 y 9...
        foreach (char num in numCuenta)
        {
            if(num != '0' || num != '1' || num != '2' || num != '3' || num != '4'
                || num != '5' || num != '6' || num != '7' || num != '8' 
                    || num != '9')
            {
                return false;
            }
        }
        return true;
    }

    static void BuscarSolicitud(Solicitud[] solicitud, Administrativo[] admin,
        int cant)
    {
        if(cant > 0)
        {
            string dni;
            int elegido;

            // Mostramos los administrativos disponibles para escoger...
            MostrarAdministrativo(admin);
            Console.Write("Escoge el administrativo por DNI: ");
            dni = Console.ReadLine();

            // Comprobamos que exista...
            elegido = CompararAdministrativo(admin, dni);

            if(elegido == -1)
            {
                Console.WriteLine("No se ha encontrado un administrativo" +
                    "con el DNI indicado");
            }
            else
            {
                // Mostramos las solicitudes del administrativo seleccionado...
                SolicitudesAdministrativo(solicitud, admin[elegido], cant);
            }
        }
        else
        {
            Console.WriteLine("No hay solicitudes disponibles.");
        }
        Console.WriteLine();
    }

    static void SolicitudesAdministrativo(Solicitud[] solicitudes, 
        Administrativo elegido, int cant)
    {
        // Mostraremos las solicitudes del administrativo...
        bool encontrado = false;
        for(int i = 0; i < cant; i++)
        {
            if (elegido.GetDni().Equals(solicitudes[i].GetAdministrativo().
                GetDni()))
            {
                Console.WriteLine(solicitudes[i].ToString());
                encontrado = true;
            }
        }
        // Si no hay se notificara...
        if(!encontrado)
        {
            Console.WriteLine("El administrativo seleccionado no tiene" +
                "solicitudes a su cargo.");
            Console.WriteLine();
        }
    }

    static void MostrarSolicitudes(Solicitud[] solicitudes, int cant)
    {     
        if(cant > 0)
        {
            // Mostraremos todas las solicitudes con su respectivo color...
            for (int i = 0; i < cant; i++)
            {
                if (solicitudes[i] is SolicitudDomiciliacion)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(solicitudes[i]);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else if (solicitudes[i] is SolicitudTasas)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(solicitudes[i]);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(solicitudes[i]);
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("No hay solicitudes disponibles.");
            Console.WriteLine();
        }
    }

    static void PendientePago(Solicitud[] solicitudes, int cant)
    { 
        if(cant > 0)
        {
            float calc = 0;

            for(int i = 0; i < cant; i++)
            {
                if (solicitudes[i] is SolicitudTasas st)
                {
                    calc = st.GetImporte() + calc;
                }
            }

            Console.WriteLine("Total a pagar {0} euros", calc);
        }
        else
        {
            Console.WriteLine("No hay solicitudes disponibles.");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        opcionSolicitud opcionUsuario;
        List<Administrativo> admin = new List<Administrativo>();
        List<Solicitud> solicitudes = new List<Solicitud>();
        int cantidad = 0;

        admin[0] = new Administrativo("Jordi", "59182413D", "629333114");
        admin[1] = new Administrativo("Jesus", "5615123D", "626823673");
        admin[2] = new Administrativo("Helena", "78918521D", "687312734");

        do
        {
            opcionUsuario = MostrarMenu();
            switch (opcionUsuario)
            {
                case opcionSolicitud.NUEVA:
                    Console.WriteLine("\n--NUEVA SOLICITUD--");
                    try
                    {
                        NuevaSolicitud(solicitudes, admin, ref cantidad);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("ERROR: Datos incorrectos para la" +
                            " solicitud");
                        Console.WriteLine(e);
                    }
                    Console.WriteLine();
                    break;

                case opcionSolicitud.BUSCAR:
                    Console.WriteLine("\n--SOLICITUDES POR ADMINISTRATIVO--");
                    BuscarSolicitud(solicitudes, admin, cantidad);
                    break;

                case opcionSolicitud.MOSTRAR:
                    Console.WriteLine("\n--LISTADO DE SOLICITUDES--");
                    MostrarSolicitudes(solicitudes, cantidad);
                    break;

                case opcionSolicitud.PENDIENTE:
                    Console.WriteLine("\n--PENDIENTE DE PAGO--");
                    PendientePago(solicitudes, cantidad);
                    break;

                case opcionSolicitud.SALIR:
                    break;
            }
        }
        while (opcionUsuario != opcionSolicitud.SALIR);
    }
}