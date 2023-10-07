using EspacioPedido;

namespace EspacioCadete
{

    class Cadete
    {
        private int id;
        private string nombre;
        private string direccion;
        private int telefono;

        //tp2 eliminar listadopedido

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public Cadete(int id, string nombre, string direccion, int telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }


        /*public Cadete()
        {
            this.listadoPedidos = new List<Pedido>();
        }*/


        /*
        public void asignarPedido(Pedido pedido)
        {
            this.listadoPedidos.Add(pedido);
        }

        public int cantidadPedidos()
        {
            return this.listadoPedidos.Count;
        }*/

        public string verDatosCadete()
        {
            return $"Cadete ID:{this.id} - nombre : {this.nombre} - direccion : {this.direccion} - telefono : {this.telefono}";
        }

        /*public void agregarPedido(Pedido pedidoAgregar)
        {
            this.listadoPedidos.Add(pedidoAgregar);
        }

        public void eliminarPedido(int pedidoABorrar)
        {
            var x = new Pedido();
            this.listadoPedidos.RemoveAll(x => x.Nro == pedidoABorrar);
        }*/



    }

}