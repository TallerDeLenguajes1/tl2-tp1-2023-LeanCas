using EspacioCadete;
using EspacioCadeteria;
using EspacioCliente;
using EspacioInforme;
using EspacioPedido;

string filenameCadeteria = "cadeteria.csv";

string filenameCadetes = "cadete.csv";

Console.WriteLine("===== Sistema de pedidos =====");

int op;

Informe informe = new Informe();

List<Pedido> listaPedidos = new List<Pedido>();

Cadeteria cadeteria = new Cadeteria();

cadeteria = AccesoDatos.cargarDatosCadeteriaCSV(filenameCadeteria);

cadeteria.ListadoCadetes = AccesoDatos.cargarDatosCadetesCSV(filenameCadetes);

int numPedido;

do
{

    Console.WriteLine("\n\n1-Dar alta Pedido \n2-Asignar Pedidos \n3-Cambiar Pedido de estado \n4-Reasignar Pedido \n5-Salir");

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
                Console.WriteLine("Listado de Pedidos");
                foreach (Pedido v in listaPedidos)
                {
                    Console.WriteLine($"\n\nPedido nro : {v.Nro} \nObservaciones: {v.Obs}\nEstado: {v.Estado}\nCliente: {v.Cliente.Nombre} - telefono: {v.Cliente.Telefono}");
                }

                Console.WriteLine("Listado de Cadetes");

                foreach (Cadete C in cadeteria.ListadoCadetes)
                {
                    Console.WriteLine($"Cadete : {C.Nombre} - ID : {C.Id} - Direccion : {C.Direccion}");
                }

                Console.WriteLine("Numero de Pedido a asignar : ");

                numPedido = int.Parse(Console.ReadLine());

                Console.WriteLine("Cadete asignado : ");

                int numCadete = int.Parse(Console.ReadLine());

                Pedido pedidoAsignar = listaPedidos.Find(pedido => pedido.Nro == numPedido);

                listaPedidos.RemoveAll(p => p.Nro == numPedido);

                Cadete cadeteAsignar = cadeteria.ListadoCadetes.Find(cadete => cadete.Id == numCadete);

                cadeteAsignar.asignarPedido(pedidoAsignar);

            }
            else
            {
                Console.WriteLine("No hay pedidos cargados");
            }
            break;
        case 3:
            if (listaPedidos.Count > 0)
            {
                Console.WriteLine("Listado de Pedidos");
                foreach (Pedido v in listaPedidos)
                {
                    Console.WriteLine($"\n\nPedido nro : {v.Nro} \nObservaciones: {v.Obs}\nEstado: {v.Estado}\nCliente: {v.Cliente.Nombre} - telefono: {v.Cliente.Telefono}");
                }

                Console.WriteLine("Que Pedido desea cambiar de estado : ");

                int numPedido2 = int.Parse(Console.ReadLine());

                bool seCambio = false;

                for (int j = 0; j < listaPedidos.Count; j++)
                {
                    if (listaPedidos[j].Nro == numPedido2)
                    {
                        Console.WriteLine("A que estado cambiara : ");

                        string estadoNuevo = Console.ReadLine();

                        listaPedidos[j].Estado = estadoNuevo;

                        seCambio = true;

                        Console.WriteLine("Se cambio con exito c:");
                    }

                }

                if (seCambio == false)
                {
                    Console.WriteLine("No se encontro el numero de pedido...");
                }

            }
            else
            {
                Console.WriteLine("No hay pedidos cargados");
            }
            break;
        case 4:
            int i = 0;
            foreach (Cadete C in cadeteria.ListadoCadetes)
            {
                Console.WriteLine($"Cadete : {C.Nombre} - ID : {C.Id} - Direccion : {C.Direccion} ");
                Console.WriteLine("Pedidos Asignados : ");
                foreach (Pedido P in cadeteria.ListadoCadetes[i].ListadoPedidos)
                {
                    Console.WriteLine($"Pedido {P.Nro} de Cliente {P.Cliente.Nombre} ");
                }
                i++;
            }

            Console.WriteLine("Cadete para reasignar su pedido : ");

            int numCadeteEliminarPedido = int.Parse(Console.ReadLine());

            Cadete cadeteEliminarPedido = cadeteria.ListadoCadetes.Find(cadete => cadete.Id == numCadeteEliminarPedido);

            foreach (Pedido P in cadeteEliminarPedido.ListadoPedidos)
            {
                Console.WriteLine($"Pedido {P.Nro} de Cliente {P.Cliente} ");
            }

            Console.WriteLine("Pedido a reasignar :");

            int numPedido3 = int.Parse(Console.ReadLine());

            Pedido PedidoMovido = null;

            for (i = 0; i < cadeteEliminarPedido.ListadoPedidos.Count; i++)
            {
                if (cadeteEliminarPedido.ListadoPedidos[i].Nro == numPedido3)
                {
                    PedidoMovido = cadeteEliminarPedido.ListadoPedidos[i];

                    cadeteEliminarPedido.ListadoPedidos.RemoveAt(i);
                }
            }

            i = 0;
            foreach (Cadete C in cadeteria.ListadoCadetes)
            {
                Console.WriteLine($"Cadete : {C.Nombre} - ID : {C.Id} - Direccion : {C.Direccion} ");
                Console.WriteLine("Pedidos Asignados : ");
                foreach (Pedido P in cadeteria.ListadoCadetes[i].ListadoPedidos)
                {
                    Console.WriteLine($"Pedido {P.Nro} de Cliente {P.Cliente} ");
                }
                i++;
            }

            Console.WriteLine("Cadete a asignar Pedido : ");

            int numCadeteAsignarPedido = int.Parse(Console.ReadLine());

            cadeteria.ListadoCadetes.Find(cadete => cadete.Id == numCadeteAsignarPedido).ListadoPedidos.Add(PedidoMovido);

            break;
    }

} while (op != 5);

informe.jornadaFinal(cadeteria);

