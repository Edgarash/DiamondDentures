namespace Entidad.Reportes
{
    public class Fecha
    {
        public int Año;
        public int Dia;
        public int Mes;

        public Fecha(byte dia, byte mes, int año)
        {
            Dia = dia;
            Mes = mes;
            Año = año;
        }

        public Fecha() : this(1, 1, 2017)
        {
        }

        public string ObtenerFecha()
        {
            return $"{Dia}/{Mes}/{Año}";
        }
    }
}