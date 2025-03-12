class Ejercicio
{
    static void MostrarNumeros(List<int> numeros)
    {
        Console.Write("Numeros: ");

        for (int i = 0; i < numeros.Count; i++)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        List<int> numeros = new List<int>();
        int num;

        Console.WriteLine("Escribe los numeros:");

        do
        {
            num = Convert.ToInt32(Console.ReadLine());
            if(num != 0)
            {
                numeros.Add(num);
            }
        }
        while (num != 0);

        MostrarNumeros(numeros);

        Console.Write("Numero que quiere borrar: ");
        num = Convert.ToInt32(Console.ReadLine());

        int i = 0;
        while(i < numeros.Count)
        {
            if (numeros[i] == num)
            {
                numeros.RemoveAt(i);
            }
            else
            {
                i++;
            }
        }

        MostrarNumeros(numeros);
    }
}