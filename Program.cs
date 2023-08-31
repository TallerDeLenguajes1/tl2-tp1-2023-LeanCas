using EspacioCadete;
using EspacioCadeteria;
using EspacioCliente;
using EspacioPedido;

Console.WriteLine("===== Sistema de pedidos =====");

int op;

List<Pedido> listaPedidos = new List<Pedido>();

do
{

    Console.WriteLine("\n\n1-Dar alta Pedido \n2-Asignar Pedidos \n3-Cambiar Pedido de estado \n4-Reasignar Pedido");

    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Pedido nuevoPedido = new Pedido();

            Console.WriteLine("Ingrese numero del pedido :");
            nuevoPedido.Nro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese observaciones del pedido :");
            nuevoPedido.Obs = Console.ReadLine();
            Console.WriteLine("Ingrese estado del pedido :");
            nuevoPedido.Estado = Console.ReadLine();

            Cliente nuevoCliente = new Cliente();

            Console.WriteLine("Ingrese nombre del cliente del pedido :");
            nuevoCliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese direccion del cliente del pedido :");
            nuevoCliente.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese datos de referencia del cliente del pedido :");
            nuevoCliente.DatosReferenciaDireccion = Console.ReadLine();
            Console.WriteLine("Ingrese telefono del cliente del pedido :");
            nuevoCliente.Telefono = int.Parse(Console.ReadLine());
            nuevoPedido.Cliente = nuevoCliente;
            listaPedidos.Add(nuevoPedido);
            break;
        case 2:
            if (listaPedidos.Count > 0)
            {
                foreach (Pedido v in listaPedidos)
                {
                    Console.WriteLine($"\n\nPedido nro : {v.Nro} \nObservaciones: {v.Obs}\nEstado: {v.Estado}\nCliente: {v.Cliente.Nombre} - telefono: {v.Cliente.Telefono}");
                }

            }
            else
            {
                Console.WriteLine("No hay pedidos cargados");
            }
            break;
        case 3:
            break;
        case 4:
            break;
    }

} while (op != 5);

