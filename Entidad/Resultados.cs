#region

using System;

#endregion

namespace Entidad
{
    public class Resultados : Datos
    {
        public string Descripcion;
        public DateTime Fecha;
        public string Id;
        public double Importe;
        public string NombreCliente;
        public string Fecha_2;

        public Resultados() {}

        public Resultados(string id, string nombreCliente, DateTime fecha, string descripcion)
        {
            Descripcion = descripcion;
            Fecha = fecha;
            Id = id;
            NombreCliente = nombreCliente;
        }

        public Resultados(string id, string nombreCliente, DateTime fecha, double importe)
        {
            Fecha = fecha;
            Id = id;
            Importe = importe;
            NombreCliente = nombreCliente;
        }

        public Resultados(string id, string nombreCliente, string fecha, string descripcion)
        {
            Descripcion = descripcion;
            Fecha_2 = fecha;
            Id = id;
            NombreCliente = nombreCliente;
        }

    }
}