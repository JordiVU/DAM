class Program
{
    static void Main()
    {
        HashSet<string> ganadores = new HashSet<string>();
        ganadores.Add("Alcaraz");
        ganadores.Add("Alcaraz");
        ganadores.Add("Djokovic");
        ganadores.Add("Djokovic");
        ganadores.Add("Djokovic");
        ganadores.Add("Djokovic");
        ganadores.Add("Federer");
        ganadores.Add("Murray");
        ganadores.Add("Murray");
        ganadores.Add("Djokovic");

        foreach(string s in ganadores)
        {
            Console.WriteLine(s);
        }
    }
}