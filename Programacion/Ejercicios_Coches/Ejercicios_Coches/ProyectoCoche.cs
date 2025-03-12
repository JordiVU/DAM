using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Prueba
{
    static void Main()
    {
        Vehiculo[] vehiculos = new Vehiculo[4];
        vehiculos[0] = new Vehiculo("Camion", "G30", 8300, 931.34F);
        vehiculos[1] = new Coche("Fiat", "G500", 4600, 532.42F);
        vehiculos[2] = new Moto("Ninja", "P120", 6400, 654.23F);
        vehiculos[3] = new Moto("Ninja", "J102", 5900, 654.23F);

        Array.Sort(vehiculos, (v1, v2) =>
        {
            int resultado = v1.GetMarca().CompareTo(v2.GetMarca());
            if (resultado == 0)
            {
                resultado = -v1.GetCilindrada().CompareTo(v2.GetCilindrada());
            }
            return resultado;
        });

        foreach (Vehiculo vehiculo in vehiculos)
        {
            vehiculo.MostraVehiculo();
        }
    }
}
