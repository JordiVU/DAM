class Principal
{
    static void Main()
    {
        Poliza poliza1 = new Poliza(1234, 230.90f);
        Usuario usu1 = new Usuario("487216141M", "Jordi", poliza1);

        usu1.MostrarInfo();
        Console.WriteLine();
        poliza1.Mostrar();
    }
}