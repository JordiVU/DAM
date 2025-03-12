using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        string[] texto = File.ReadAllLines("log.txt");
        Array.Sort(texto);
        File.WriteAllLines("fichero.txt", texto);
    }
}