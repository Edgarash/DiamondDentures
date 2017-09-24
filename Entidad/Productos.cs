using System;

namespace Entidad
{
    public class Productos : Datos
    {
        public string Clave;
        public string Producto;
        public decimal PrecioProducto;
        public string Material1;
        public decimal PrecioMat1;
        public string Material2;
        public decimal PrecioMat2;
        public DateTime Fecha;


        public Productos(string clave, string producto, decimal precioProducto, string material1, decimal precioMat1, string material2, decimal precioMat2, DateTime fecha)
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
    }
}