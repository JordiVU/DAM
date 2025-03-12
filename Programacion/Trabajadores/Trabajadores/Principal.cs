class Principal
{
    static void Main()
    {
        Trabajador[] trabajadores = new Trabajador[5];
        trabajadores[0] = new Ingeniero();

        trabajadores[1] = new IngenieroInformatico();

        trabajadores[2] = new Analista();

        trabajadores[3] = new Programador();

        trabajadores[4] = new Trabajador();

        foreach(Trabajador t in trabajadores)
        {
            t.Saludo();
        }

        
    }
}