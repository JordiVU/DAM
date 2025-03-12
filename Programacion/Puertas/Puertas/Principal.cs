class Principal
{
    static void Main()
    {
        Puerta p = new Puerta(58, 70, "azul");
        Porton pot = new Porton(80, 120, "cian");

        p.Abrir();
        pot.Desbloquear();
        pot.Abrir();

        p.MostrarInformacion();
        Console.WriteLine();
        pot.MostrarInformacion();
    }
}