using EspacioPedido;

namespace EspacioCadete
{

    class Cadete
    {
        private int id;
        private string nombre;
        private string direccion;
        private int telefono;
        private List<Pedido> listadoPedidos;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        internal List<Pedido> ListadoPedidos { get => listadoPedidos; set => listadoPedidos = value; }

        public double jornalACobrar()
        {
            return (this.listadoPedidos.Count * 500);
        }

        public int cantidadPedidos()
        {
            return this.listadoPedidos.Count;
        }

        public string verDatosCadete()
        {
            return $"Cadete ID:{this.id} - nombre : {this.nombre} - direccion : {this.direccion} - telefono : {this.telefono}";
        }

        public void agregarPedido(Pedido pedidoAgregar)
        {
            this.listadoPedidos.Add(pedidoAgregar);
        }

        public void eliminarPedido(int pedidoABorrar)
        {
            var x = new Pedido();
            this.listadoPedidos.RemoveAll(x => x.Nro == pedidoABorrar);
        }



    }

}