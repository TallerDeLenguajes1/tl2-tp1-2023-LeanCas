using EspacioCadete;

namespace EspacioCadeteria
{

    public class Cadeteria
    {
        private string nombre;
        private int telefono;
        private List<Cadete> listadoCadetes;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

        public Cadeteria()
        {
            this.listadoCadetes = new List<Cadete>();
        }

        public Cadeteria(string nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public string datosCadeteria()
        {
            return $"Cadeteria {this.nombre}, telefono : {this.telefono}";
        }

        public int cantidadCadetes()
        {
            return this.listadoCadetes.Count;
        }




        public int cantidadPedidos()
        {
            int sum = 0;
            for (int i = 0; i < this.listadoCadetes.Count; i++)
            {
                sum += listadoCadetes[i].cantidadPedidos();
            }
            return sum;
        }

        public void cantidadPedidosPorCadete()
        {
            for (int i = 0; i < this.listadoCadetes.Count; i++)
            {
                Console.WriteLine("\n\nID :" + this.listadoCadetes[i].Id + " Nombre : " + this.listadoCadetes[i].Nombre + " Cantidad de Pedidos " + listadoCadetes[i].cantidadPedidos());
            }
        }

        public double totalRecaudado()
        {
            double sum = 0;
            for (int i = 0; i < this.listadoCadetes.Count; i++)
            {
                sum += listadoCadetes[i].jornalACobrar();
            }
            return sum;
        }


    }
}