using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using EspacioCadete;
using EspacioCadeteria;
namespace EspacioAccesoDatos
{

    public abstract class AccesoADatos
    {
        public Cadeteria cadeteria;
        public abstract Cadeteria CargarInfoCadeteria();
    }

    public class AccesoCsv : AccesoADatos
    {
        public override Cadeteria CargarInfoCadeteria()
        {
            try
            {
                using (StreamReader reader = new StreamReader("cadeteria.csv"))
                {
                    string[] datos = reader.ReadLine().Split(',');
                    // Asumiendo que Nombre, telefono y NroPedidosCreados están definidos en Cadeteria.
                    string Nombre = datos[0];
                    int Telefono = int.Parse(datos[1]);
                    cadeteria = new Cadeteria(Nombre, Telefono);
                    cadeteria.ListadoCadetes = CargarCadetes();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la información de la cadetería: " + ex.Message);
            }
            return cadeteria;
        }

        public List<Cadete> CargarCadetes()
        {
            List<Cadete> cadetes = new List<Cadete>(); // Nueva lista de cadetes

            try
            {
                using (StreamReader reader = new StreamReader("cadetes.csv"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] datosCadete = line.Split(',');
                        int id = int.Parse(datosCadete[0]);
                        string nombre = datosCadete[1];
                        string direccion = datosCadete[2];
                        int telefono = int.Parse(datosCadete[3]);

                        Cadete cadete = new Cadete(id, nombre, direccion, telefono);
                        cadetes.Add(cadete); // Agrega el cadete a la nueva lista
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la lista de cadetes: " + ex.Message);
            }

            return cadetes; // Devuelve la lista de cadetes
        }

    }
    public class AccesoJson : AccesoADatos
    {
        public override Cadeteria CargarInfoCadeteria()
        {

            string contenido = File.ReadAllText("cadeteria.json");
            cadeteria = JsonSerializer.Deserialize<Cadeteria>(contenido);

            return cadeteria;

        }


    }
}

