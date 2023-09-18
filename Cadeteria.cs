using EspacioCadete;
using EspacioPedido;

namespace EspacioCadeteria
{

    class Cadeteria
    {
        private string nombre;
        private int telefono;
        private List<Cadete> listadoCadetes;

        //TP2 Agregar ListadoPedidos en la clase Cadeteria que contenga todo los pedidos que se vayan generando

        private List<Pedido> listadoPedidos;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }
        internal List<Pedido> ListadoPedidos { get => listadoPedidos; set => listadoPedidos = value; }

        public Cadeteria()
        {
            this.listadoCadetes = new List<Cadete>();
        }

        public string datosCadeteria()
        {
            return $"Cadeteria {this.nombre}, telefono : {this.telefono}";
        }

        public int cantidadCadetes()
        {
            return this.listadoCadetes.Count;
        }


        public void cargarDatosCadeteria()
        {
            string directorioActual = Directory.GetCurrentDirectory();

            string dataPath = directorioActual + @"\cadeteria.csv";

            if (File.Exists(dataPath))
            {
                using (var reader = new StreamReader(dataPath))
                {

                    string line;

                    bool isFirstLine = true;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');

                        if (isFirstLine)
                        {
                            isFirstLine = false;

                            this.nombre = values[0].Trim();

                            this.telefono = int.Parse(values[1].Trim());

                            continue;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("El archivo cadeteria.csv no existe ");
            }

        }

        public void cargarDatosCadetes()
        {
            string directorioActual = Directory.GetCurrentDirectory();

            string dataPath = directorioActual + @"\cadete.csv";

            if (File.Exists(dataPath))
            {
                using (var reader = new StreamReader(dataPath))
                {

                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {

                        Cadete cadeteNuevo = new Cadete();

                        string[] values = line.Split(',');

                        cadeteNuevo.Id = int.Parse(values[0].Trim());

                        cadeteNuevo.Nombre = values[1].Trim();

                        cadeteNuevo.Direccion = values[2].Trim();

                        cadeteNuevo.Telefono = int.Parse(values[3].Trim());

                        this.listadoCadetes.Add(cadeteNuevo);

                    }
                }
            }
            else
            {
                Console.WriteLine("El archivo cadete.csv no existe ");
            }

        }

        //TP2 ● Agregar el método JornalACobrar en la clase Cadeteria que recibe como parámetro el id del cadete y devuelve el monto a cobrar para dicho cadete

        double JornalACobrar(int IdCadete)
        {
            Cadete cadeteEncontrado = this.listadoCadetes.FirstOrDefault(p => p.Id == IdCadete);

            int cantidadPedidos = this.listadoPedidos.Count(p => p.Cadete == cadeteEncontrado);

            if (cadeteEncontrado != null)
            {
                return cantidadPedidos * 500;
            }
            else
            {
                return -999;
            }
        }

        // TP2 Agregar el método AsignarCadeteAPedido en la clase Cadeteria que recibe como parámetro el id del cadete y el id del Pedido


        void AsignarCadeteAPedido(int idCadete, int idPedido)
        {
            Cadete cadeteEncontrado = this.listadoCadetes.FirstOrDefault(p => p.Id == idCadete);
            Pedido pedidoEncontrado = this.listadoPedidos.FirstOrDefault(p => p.Nro == idPedido);

            if (cadeteEncontrado != null && pedidoEncontrado != null)
            {
                pedidoEncontrado.Cadete = cadeteEncontrado;

                Console.WriteLine("Se agrego el cadete al pedido con exito");

            }
            else
            {
                Console.WriteLine("No fue posible agregar el pedido...");
            }

        }



    }
}