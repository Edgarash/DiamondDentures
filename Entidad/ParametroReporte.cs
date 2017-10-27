namespace Entidad
{
    public class ParametroReporte
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }

        public ParametroReporte(string nombre, object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
    }
}