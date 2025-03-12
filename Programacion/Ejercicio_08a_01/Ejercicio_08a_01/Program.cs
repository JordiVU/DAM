class Program
{
    static void Main()
    {
        string frase;

        using(StreamWriter sw = new StreamWriter("registroDeUsuario.txt"))
        {
            do
            {
                frase = Console.ReadLine();

                if (frase != "")
                {
                    sw.WriteLine(frase);
                }
            }
            while (frase != "");
        }
    }
}