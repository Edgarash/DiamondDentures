using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroProducto : Datos
    {
        public int IDProducto { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int TiempoBase { get; set; }

        public float PrecioBase { get; set; }

        public float PrecioCompra { get; set; }

        public bool Activo { get; set; }

        public string UnidadMedida { get; set; }

        public int Cantidad { get; set; }

        public RegistroProducto(int IDProducto, string Nombre, string Descripcion, int TiempoBase,
            float PrecioBase, float PrecioCompra, bool Activo, string UnidadMedida, int Cantidad)
            :this(IDProducto)
        {
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.TiempoBase = TiempoBase;
            this.PrecioBase = PrecioBase;
            this.PrecioCompra = PrecioCompra;
            this.Activo = Activo;
            this.UnidadMedida = UnidadMedida;
            this.Cantidad = Cantidad;
        }

        public RegistroProducto(int IDProducto)
        {
            this.IDProducto = IDProducto;
        }
    }
}
