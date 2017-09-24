using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroTrabajo : Datos
    {
        public string Producto { get; set; }
        public float PrecioProducto { get; set; }
        public string Material1 { get; set; }
        public float PrecioMaterial1 { get; set; }
        public string Material2 { get; set; }
        public float PrecioMaterial2 { get; set; }
        public string Fecha { get; set; }
        public float Total { get { return PrecioProducto + PrecioMaterial1 + PrecioMaterial2; } }

        /// <summary>
        /// Constructor por defecto de RegistroTrabajo
        /// </summary>
        /// <param name="Producto">Producto a elaborar</param>
        /// <param name="PrecioProducto">Precio del producto</param>
        /// <param name="Material1">Primer o único material del cuál se fabricará el producto</param>
        /// <param name="PrecioMaterial1">Precio del primer material</param>
        /// <param name="Material2">Segundo material del cúal se fabricará el producto</param>
        /// <param name="PrecioMaterial2">Precio del segundo material</param>
        public RegistroTrabajo(string Producto, float PrecioProducto, string Material1, float PrecioMaterial1, string Material2, float PrecioMaterial2, string Fecha)
        {
            this.Producto = Producto;
            this.PrecioProducto = PrecioProducto;
            this.Material1 = Material1;
            this.PrecioMaterial1 = PrecioMaterial1;
            this.Material2 = Material2;
            this.PrecioMaterial2 = PrecioMaterial2;
            this.Fecha = Fecha;
        }
    }
}