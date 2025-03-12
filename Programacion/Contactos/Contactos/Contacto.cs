using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Clase contacto
namespace Contactos
{
    internal class Contacto
    {
        public const string FICHERO = "contactos.txt";

        private string nombre;
        private int edad;
        private string telefono;

        public Contacto(string nombre, int edad, string telefono)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.telefono = telefono;
        }

        public string AFichero()
        {
            return nombre + ";" + edad + ";" + telefono; 
        }

        public static List<Contacto> LeerContactos()
        {
            List<Contacto> contactos = new List<Contacto>();
            if(File.Exists(FICHERO))
            {
                string[] texto = File.ReadAllLines(FICHERO);
                for (int i = 0; i < texto.Length; i++)
                {
                    string[] informacion = texto[i].Split(";");
                    contactos.Add(new Contacto(informacion[0],
                        Convert.ToInt32(informacion[1]), informacion[2]));
                }
            }

            return contactos;
        }

        public static void GuararContactos(List<Contacto> contactos)
        {
            using (StreamWriter fichero = new StreamWriter(FICHERO))
            {
                for(int i = 0; i < contactos.Count; i++)
                {
                    fichero.WriteLine(contactos[i].AFichero());
                }
            }
        }

        public override string ToString()
        {
            return nombre + ", " + edad + " años, " + telefono;
        }
    }
}
