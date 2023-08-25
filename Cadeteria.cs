using EspacioCadete;

namespace EspacioCadeteria {

    class cadeteria {
        private string nombre;
        private int telefono;
        private List<Cadete> listadoCadetes;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        internal List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }
    }
}