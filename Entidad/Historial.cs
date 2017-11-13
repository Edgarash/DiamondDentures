using System;

namespace Entidad.Reportes
{
    public class Historial
    {
        public string Id;
        public string Descripcion;
        public string Tipo;
        public DateTime Fecha;
        public int Pedidos;

        public Historial(string id, string descripcion, string tipo, DateTime fecha, int pedidos)
        {
            Id = id;
            Descripcion = descripcion;
            Tipo = tipo;
            Fecha = fecha;
            Pedidos = pedidos;
        }
    }
}