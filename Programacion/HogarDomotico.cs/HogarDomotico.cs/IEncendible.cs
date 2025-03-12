using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Interfaz para los elementos que pueden apagarse y encenderse.
interface IEncendible
{
    void Encender();
    void Apagar();
    bool Consultar();
}
