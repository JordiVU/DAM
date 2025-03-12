class PruebaLibro
{
    enum tipoDocumento { DOCUMENTO=1, LIBRO, ARTICULO}
    static Documento RellenarDocumento()
    {
        Documento nuevo;
        tipoDocumento tipo;
        string titulo, autor, ubicacion, procedencia;
        int numPaginas;

        // Pedir tipo de documento: 1 --> DOCUMENTO / 2 --> LIBRO / 3 --> ARTICULO
        Console.Write("Escoge tipo (1. DOCUMENTO / 2. LIBRO / 3. ARTICULO): ");
        tipo = (tipoDocumento)Convert.ToInt32(Console.ReadLine());

        // Pedir datos generales (titulo, autor, ubicacion)
        Console.Write("Titulo: ");
        titulo = Console.ReadLine();

        Console.Write("Autor: ");
        autor = Console.ReadLine();

        Console.Write("Ubicacion: ");
        ubicacion = Console.ReadLine();

        // Si tipo --> 1, pedir numero de paginas y crear libro
        if(tipo == tipoDocumento.LIBRO)
        {
            Console.Write("Numero de paginas: ");
            numPaginas = Convert.ToInt32(Console.ReadLine());

            nuevo = new Libro(titulo, autor, ubicacion, numPaginas);
        }
        // Si no (tipo == 1), crear documento
        else if(tipo == tipoDocumento.DOCUMENTO)
        {
            nuevo = new Documento(titulo, autor, ubicacion);
        }
        else
        {
            Console.Write("Procedencia: ");
            procedencia = Console.ReadLine();

            nuevo = new Articulo(titulo, autor, ubicacion, procedencia);
        }

        return nuevo;
    }

    static void MostrarDocumentos(Documento[] documentos)
    {
        // Recorrer array
        for(int i = 0; i < documentos.Length; i++)
        {
            // Mostrar titulo y paginas de libros en rojo.
            if (documentos[i] is Libro)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(documentos[i]);
                Console.ResetColor();
                Console.WriteLine();
            }
            // Mostrar titulo de documentos en blanco
            else if (documentos[i] is Articulo)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(documentos[i]);
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(documentos[i]);
                Console.WriteLine();
            }
        }

    }
    static void Main()
    {
        Documento[] documentos = new Documento[5];

        for(int i = 0; i < documentos.Length; i++)
        {
            documentos[i] = RellenarDocumento();
            Console.WriteLine();
        }

        Console.WriteLine("--DOCUMENTOS--");
        MostrarDocumentos(documentos);

        /**
        Libro[] libros = new Libro[3];
        libros[0] = new Libro("JK Rowling", "El Principe Mestizo", "UK", 300);
        libros[1] = new Libro("George R. R. Martin", "Cancion de Hielo y Fuego", "EEUU", 500);
        libros[2] = new Libro();

        libros[2].SetAutor("Eloy Moreno");
        libros[2].SetTitulo("Tierra");
        libros[2].SetUbicacion("España");
        libros[2].SetNumPaginas(400);

        Documento doc = new Documento("Eloy Moreno", "Invisible", "España");
 
        Console.WriteLine("--LIBROS--");
        for(int i = 0; i < libros.Length; i++)
        {
            libros[i].MostrarLibros();
            libros[i].MostrarPaginas();
            Console.WriteLine();
        }
        doc.MostrarLibros();
        **/
    }
}
