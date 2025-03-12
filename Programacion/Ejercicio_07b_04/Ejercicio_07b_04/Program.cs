class Program
{
    static void Main()
    {
        string texto;

        Console.WriteLine("Escribe las fechas de cumpleaños:");
        texto = Console.ReadLine();
        string[] fechas = texto.Split();
        string[] entero;

        HashSet<FechaCumple> cumples = new HashSet<FechaCumple>();
        for(int i = 0; i < fechas.Length; i++)
        {
            entero = fechas[i].Split("/");
            cumples.Add(new FechaCumple(Convert.ToInt32(entero[0]),
                Convert.ToInt32(entero[1]), Convert.ToInt32(entero[2])));
        }
        
        if(cumples.Count != fechas.Length)
        {
            Console.WriteLine("Hay repetidos.");
        }
        else
        {
            Console.WriteLine("No hay repetidos.");
        }
    }
}