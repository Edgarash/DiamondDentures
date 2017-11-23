using System.Data;

namespace Entidad
{
    public class ParametroReporte
    {
        public string Nombre { get; set; }
        public string Columna { get; set; }
        public object Valor { get; set; }
        public string Subreporte { get; set; }
       public bool EsSubreporte { get; set; }

        public ParametroReporte(string nombre, object valor, bool esSubreporte = false, string subreporte = "")
        {
            Nombre = nombre;
            Valor = valor;
            Subreporte = subreporte;
            EsSubreporte = esSubreporte;
        }

        public ParametroReporte(string nombre, object valor, string columna)
        {
            Nombre = nombre;
            Valor = valor;
            Columna = columna;
        }
    }
}