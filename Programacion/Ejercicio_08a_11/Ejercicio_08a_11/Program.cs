class Program
{
    static void Main()
    {
        string nombre;

        Console.Write("Nombre del fichero: ");
        nombre = Console.ReadLine();

        try
        {
            string[] fichero = File.ReadAllLines(nombre);
            File.WriteAllLines("copia_de_" + nombre, fichero);
        }
        catch (FileNotFoundException f)
        {
            Console.WriteLine("ERROR TERROR: El fichero no existe.");
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR TERROR" + e);
        }
    }
}