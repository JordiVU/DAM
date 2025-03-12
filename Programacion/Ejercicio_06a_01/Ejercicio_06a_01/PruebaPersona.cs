class PruebaPersona
{
    static void Main()
    {
        string nombre;

        Persona nombre1 = new Persona("Jesus");
        PersonaItaliana nombre2 = new PersonaItaliana("Alessandro");
        PersonaInglesa nombre3 = new PersonaInglesa("Mike");

        nombre1.Saludo();
        nombre2.Saludo();
        nombre3.Saludo();
        nombre1.Saludo("Buenas tardes");
    }
}
    