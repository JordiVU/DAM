class Program
{
    static void Main()
    {
        Curso[] cursos = new Curso[2];
        cursos[0] = new Curso("1º DAM");
        cursos[1] = new Curso("2º DAM");

        Personal[] personal = new Personal[4];
        personal[0] = new Administrativo("11112234A", "Jorge Cremades",
            "5123213331", 'B');        
        personal[1] = new Administrativo("11512234B", "Jordi Vazquez",
            "6112333531", 'A');
        personal[2] = new Profesor("1512234C", "Santiago Calatrava",
            "6561233523", "Castellano");
        personal[3] = new Profesor("6151234D", "JK Rowling",
            "6812045898", "Matematicas");

        Grupo[] grupos = new Grupo[2];
        grupos[0] = new Grupo("1CFSA", 'A', "A205", cursos[0], 
            (Profesor)personal[2]);
        grupos[1] = new Grupo("2CFSA", 'B', "A104", cursos[1], 
            (Profesor)personal[3]);

        foreach (Grupo grupo in grupos)
        {
            Console.WriteLine(grupo.ToString());
        }
    }
}