
using EspacioCadeteria;

namespace EspacioInforme;
public class Informe
{
    public void jornadaFinal(Cadeteria cadeteria)
    {
        Console.WriteLine("\t Informe");
        Console.WriteLine("Total recaudado : " + cadeteria.totalRecaudado());
        cadeteria.cantidadPedidosPorCadete();
    }
}