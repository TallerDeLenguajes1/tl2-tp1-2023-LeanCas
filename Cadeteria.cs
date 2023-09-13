using EspacioCadete;

namespace EspacioCadeteria
{

    class Cadeteria
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

        public double totalRecaudado()
        {
            double sum = 0;
            for (int i = 0; i < this.listadoCadetes.Count; i++)
            {
                sum += listadoCadetes[i].jornalACobrar();
            }
            return sum;
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
    }
}