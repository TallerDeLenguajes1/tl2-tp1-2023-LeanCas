using EspacioCliente;

namespace EspacioPedido {

    class Pedido {
        private int nro;
        private string? obs;
        private Cliente cliente;
        private string estado;

        public int Nro { get => nro; set => nro = value; }
        public string? Obs { get => obs; set => obs = value; }
        public string Estado { get => estado; set => estado = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }

        public string? verDireccionCliente (){
            return this.cliente.Direccion;
        }

        public string? verDatosCliente (){
            return $"Cliente : {this.cliente.Nombre}, Direccion : {this.cliente.Direccion}";
        }
    }
}