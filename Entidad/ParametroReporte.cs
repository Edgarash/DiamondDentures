using System.Data;

namespace Entidad
{
    public class ParametroReporte
    {
        public string Nombre { get; set; }
        public string Columna { get; set; }
        public object Valor { get; set; }

        public ParametroReporte(string nombre, object valor, string columna = "")
        {
            Nombre = nombre;
            Valor = valor;
            Columna = columna;
        }
    }
}