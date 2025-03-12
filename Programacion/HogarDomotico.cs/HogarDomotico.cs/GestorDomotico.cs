using System.Numerics;
// Clase que gestiona todos los elementos domoticos.
class GestorDomotico
{
    private ElementoDomotico[] elementos = new ElementoDomotico[6];

    public GestorDomotico()
    {
        elementos[0] = new Puerta("Puerta principal", true);
        elementos[1] = new Horno("Horno cocina", true, 0);
        elementos[2] = new Luz("Luz salon", false);
        elementos[3] = new Luz("Luz cocina", true);
        elementos[4] = new Puerta("Puerta garaje", false);
        elementos[5] = new Calefaccion("Calefacción central", false, 20);
    }
    public void MostrarEstado()
    {
        for (int i = 0; i < elementos.Length; i++)
        {
            elementos[i].Mostrar();
        }
    }

    public ElementoDomotico GetElemento(int num)
    {
        return elementos[num];
    }

    public void ApagarTodo()
    {
        for (int i = 0; i <= 5; i++)
        {
            if (elementos[i] is IEncendible e)
            {
                e.Apagar();
            }
        }
    }
}