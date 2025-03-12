class Principal
{
    static Random random = new Random();
    static string Secuencia( int n, int m )
    {
        string resultado;

        if(n == m)
        {
            resultado = Convert.ToString(n);
        }
        else
        {
            resultado = Secuencia(n, m - 1) + "," + m;
        }
        return resultado;
    }

    static int CalcularTiempoRaton()
    {
        int camino = random.Next(1, 4);
        int resultado;

        if(camino == 3)
        {
            resultado = 7;
        }
        else if(camino == 2)
        {
            resultado = CalcularTiempoRaton() + 5;
        }
        else
        {
            resultado = CalcularTiempoRaton() + 3;
        }

        return resultado;
    }

    static bool EsPotencia(int n, int b)
    {
        bool resul = false;

        if (n == 1 || n == b)
        {
            resul = true;
        }
        else if(n < b || n % b != 0)
        {
            resul = false;
        }
        else
        {
            resul = EsPotencia(n / b, b);
        }
        return resul;
    }
    static bool EsBinario(string numero)
    {
        bool resul = false;
        if(numero.Length == 0)
        {
            resul = false;
        }
        else if ((numero == "1" || numero == "0") && numero.Length == 1)
        {
            resul = true;
        }
        else 
        {
            resul = (numero[0]  == '0' || numero[0] == '1') && 
                EsBinario(numero.Substring(1));
        }
        return resul;
    }

    static int RellenarCajas(int cajas)
    {
        int resultado = 0;

        if(cajas == 1)
        {
            resultado = 1;
        }
        else
        {
            resultado = 1 + RellenarCajas(cajas / 2);
        }

        return resultado;
    }
    static void Main()
    {
        int calc = 0;
        // Console.WriteLine(Secuencia(3, 7));
        /*
        for(int i = 0; i < 10; i++)
        {
            calc = CalcularTiempoRaton() + calc;
        }

        Console.WriteLine("Media de tiempo: " + calc/10f + " min");*/
        /*if(EsPotencia(14, 7))
        {
            Console.WriteLine("Si es potencia.");
        }
        else
        {
            Console.WriteLine("No es potencia.");
        }*/

        /*if(EsBinario("10111"))
        {
            Console.WriteLine("Es binario.");
        }
        else
        {
            Console.WriteLine("No es binario.");
        }*/
        int numero;

        Console.Write("Numero de cajas: ");
        numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("numero de viajes: " + RellenarCajas(numero));

    }
}