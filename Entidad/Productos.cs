using System;

namespace Entidad
{
    public class Productos : Datos
    {
        public string Clave { get; set; }
        public string Producto { get; set; }
        public decimal PrecioProducto { get; set; }
        public string Material1 { get; set; }
        public decimal PrecioMat1 { get; set; }
        public string Material2 { get; set; }
        public decimal PrecioMat2 { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProducto { get; set; }

        public Productos(string clave, string producto, decimal precioProducto, string material1, decimal precioMat1, string material2,
                         decimal precioMat2, DateTime fecha)
        {
            Clave = clave;
            Producto = producto;
            PrecioProducto = precioProducto;
            Material1 = material1;
            PrecioMat1 = precioMat1;
            Material2 = material2;
            PrecioMat2 = precioMat2;
            Fecha = fecha;
        }

        public Productos(string clave, string producto, string material1, decimal precioMat1, string material2, decimal precioMat2, double total, int idProducto)
        {
            Clave = clave;
            Producto = producto;
            Material1 = material1;
            PrecioMat1 = precioMat1;
            Material2 = material2;
            PrecioMat2 = precioMat2;
            Total = total;
            IdProducto = idProducto;
        }
    }
}