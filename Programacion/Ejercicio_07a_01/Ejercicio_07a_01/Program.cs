class Ejercicio
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();

        for (int i = 0; i < 5; i++)
        {
            pila.Push(Convert.ToInt32(Console.ReadLine()));
        }

        while(pila.Count() > 0)
        {
            Console.WriteLine(pila.Pop());
        }
    }
}