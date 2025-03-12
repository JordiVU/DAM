// Programa principal encargado de ejecutar.
class Program
{
    static Alumno[] RellenarAlumnos()
    {
        Alumno[] alumnos = new Alumno[3];

        alumnos[0] = new Alumno("Jordi", new Trabajo("Practica 1 Programacion"));
        alumnos[1] = new Alumno("Santi", new Trabajo("Practica 2 BBDD"));
        alumnos[2] = new Alumno("Jorge", new Trabajo("Practica 1 LM"));

        return alumnos;

    }

    static void RellenarApartados(Alumno[] alumnos)
    {
        int tipo;
        Apartado nuevo;

        for (int i = 0; i < alumnos.Length; i++)
        {
            Console.WriteLine("ALUMNO: " + alumnos[i].GetNombre());
            do
            {
                Console.WriteLine("Escoge tipo de apartado: 1. Normal, " +
                    "2. Importante, 0.Terminar");
                tipo = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (tipo < 3 && tipo > 0)
                    {
                        string titulo;
                        float calificacionMax;
                        float nota;

                        Console.Write("Elige titulo: ");
                        titulo = Console.ReadLine();

                        Console.Write("Calificacion maxima en el apartado: ");
                        calificacionMax = Convert.ToSingle(Console.ReadLine());
                        if (calificacionMax > 10 || calificacionMax < 0)
                        {
                            throw new Exception("ERROR: Valores fuera de rango.");
                        }

                        Console.Write("Nota del alumno: ");
                        nota = Convert.ToSingle(Console.ReadLine());
                        if (nota > calificacionMax || nota < 0)
                        {
                            throw new Exception("ERROR: Valores fuera de rango.");
                        }

                        if (tipo == 2)
                        {
                            float calificacionMin;

                            Console.Write("Calificacion minima en " +
                                "el apartado: ");
                            calificacionMin = Convert.ToSingle(Console.ReadLine());
                            if (calificacionMin > calificacionMax || calificacionMin < 0)
                            {
                                throw new Exception("ERROR: Valores fuera de" +
                                    "rango.");
                            }

                            nuevo = new ApartadoImportante(titulo, calificacionMax, nota, calificacionMin);
                        }
                        else
                        {
                            nuevo = new ApartadoNormal(titulo, calificacionMax, nota);
                        }

                        alumnos[i].GetTrabajo().NuevoApartado(nuevo);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            while (tipo != 0);

            Console.WriteLine();
        }
    }

    static void Mostrar(Alumno[] alumnos)
    {
        for (int i = 0; i < alumnos.Length; i++)
        {
            Console.WriteLine("Alumno/a" + alumnos[i].GetNombre() + "\n" + "Trabajo"
                + alumnos[i].GetTrabajo().GetTituloPractica());

            foreach (Apartado a in alumnos[i].GetTrabajo().GetApartados())
            {
                Console.WriteLine(a);
            }
            if (alumnos[i].GetTrabajo().Aprobado())
            {
                Console.WriteLine("NOTA FINAL: " + alumnos[i].GetTrabajo().NotaFinal()
                    + "(APROBADO)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NOTA FINAL: " + alumnos[i].GetTrabajo().NotaFinal()
                    + "(SUSPENSO)");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Alumno[] alumnos = RellenarAlumnos();

        RellenarApartados(alumnos);

        Mostrar(alumnos);
    }
}