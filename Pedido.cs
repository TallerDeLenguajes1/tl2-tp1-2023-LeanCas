using EspacioCadete;
using EspacioCliente;

namespace EspacioPedido
{

    class Pedido
    {
        private int nro;
        private string obs;
        private Cliente cliente;
        private string estado;

        //tp2   Agregar una referencia a Cadete dentro de la clase Pedido

        private Cadete cadete;


        public int Nro { get => nro; set => nro = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Estado { get => estado; set => estado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        internal Cadete Cadete { get => cadete; set => cadete = value; }

        public string verDireccionCliente()
        {
            return this.cliente.Direccion;
        }

        public string verDatosCliente()
        {
            return $"Cliente : {this.cliente.Nombre}, Direccion : {this.cliente.Direccion}";
        }
    }
}