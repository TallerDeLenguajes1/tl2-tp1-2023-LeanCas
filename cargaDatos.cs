

using EspacioCadete;
using EspacioCadeteria;

public static class AccesoDatos
{
    public static Cadeteria cargarDatosCadeteriaCSV(string filename)
    {
        string[] datosCateria;

        using (StreamReader reader = new StreamReader(filename))
        {
            datosCateria = reader.ReadLine().Split(",");
        }

        Cadeteria cadeteria = new Cadeteria(datosCateria[0], int.Parse(datosCateria[1]));

        return cadeteria;
    }

    public static List<Cadete> cargarDatosCadetesCSV(string filename)
    {
        List<Cadete> cadetes = new List<Cadete>();
        string[] datosCadete;
        string lineaCSV;
        using (StreamReader reader = new StreamReader(filename))
        {
            while ((lineaCSV = reader.ReadLine()) != null)
            {
                datosCadete = lineaCSV.Split(",");
                Cadete cadete = new Cadete(int.Parse(datosCadete[0]), datosCadete[1], datosCadete[2], int.Parse(datosCadete[3]));
                cadetes.Add(cadete);
            }
        }
        return cadetes;
    }
}