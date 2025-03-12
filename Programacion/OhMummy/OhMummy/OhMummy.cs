// Programa principal
class OhMummy
{
    static void Main()
    {
        Bienvenida b = new Bienvenida();
        GameOver g = new GameOver();
        // Configuración inicial de la consola
        Console.CursorVisible = false;
        Console.WindowWidth = Configuracion.ANCHO_PANTALLA;
        Console.WindowHeight = Configuracion.ALTO_PANTALLA;
        do
        {
            b.Lanzar();
            if (!b.GetSalir())
            {
                Partida p = new Partida();
                p.Lanzar();
                g.Lanzar();
            }
        } while (!b.GetSalir());
        Console.Clear();
    }
}