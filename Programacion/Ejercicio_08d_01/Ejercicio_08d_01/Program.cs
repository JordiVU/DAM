class Program
{
    static void Main(string[] args)
    {
        List<Coche> coches = Coche.DeserializarJSON();

        // AÑadir/Mostrar

        Coche.SerializarJSON(coches);
    }
}
