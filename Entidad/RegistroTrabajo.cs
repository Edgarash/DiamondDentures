using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroTrabajo : Datos
    {
        public string IDPedido { get; set; }
        public int IDProducto { get { return Producto.IDProducto; } }
        public RegistroProducto Producto { get; set; }
        public int IDMaterial1 { get { return Material1.IDMaterial; } }
        public RegistroMaterial Material1 { get; set; }
        public int IDMaterial2 { get { return Material2.IDMaterial; } }
        public RegistroMaterial Material2 { get; set; }
        public float Total { get { return Producto.PrecioBase + Material1.PrecioBase + (Material2?.PrecioBase??0); } }


        public RegistroTrabajo(string IDPedido, RegistroProducto Producto, RegistroMaterial Material1, RegistroMaterial Material2)
        {
            this.IDPedido = IDPedido;
            this.Producto = Producto;
            this.Material1 = Material1;
            this.Material2 = Material2;
        }
    }
}