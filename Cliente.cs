namespace EspacioCliente {

    class Cliente {
        private string? nombre;
        private string? direccion;
        private int telefono;
        private string? datosReferenciaDireccion;

        public string? Nombre { get => Nombre; set => Nombre = value; }
        public string? Direccion { get => Direccion; set => Direccion = value; }
        public int Telefono { get => Telefono; set => Telefono = value; }
        public string? DatosReferenciaDireccion { get => DatosReferenciaDireccion; set => DatosReferenciaDireccion = value; }
    }

}