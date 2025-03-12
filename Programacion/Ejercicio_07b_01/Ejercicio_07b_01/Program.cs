class Program
{
    static void Main()
    {
        SortedList<string, int> alumnos = new SortedList<string, int>();

        Console.WriteLine("--RELLENA LOS DATOS--");
        for(int i = 0; i < 4; i++)
        {
            string alumno;
            int nota;

            Console.Write("Alumno:");
            alumno = Console.ReadLine();

            Console.Write("Nota:");
            nota = Convert.ToInt32(Console.ReadLine());

            alumnos.Add(alumno, nota);
            Console.WriteLine();
        }

        for(int i = 0; i < alumnos.Count; i++)
        {
            Console.WriteLine(alumnos.Keys[i] + "|" + alumnos.Values[i]);
        }
    }
}