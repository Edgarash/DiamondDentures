using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroMaterial : Datos
    {
        public int IDMaterial { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float PrecioBase { get; set; }
        public float PrecioCompra { get; set; }
        public int TiempoBase { get; set; }
        public int IDProveedor { get { return Proveedor.IDProveedor; } }
        public RegistroProveedor Proveedor { get; set; }
        public string UnidadMedida { get; set; }
        public int Cantidad { get; set; }
        public int Faltantes { get; set; }

        public RegistroMaterial(int IDMaterial, string Nombre,string Descripcion, float PrecioBase, float PrecioCompra,
            int TiempoBase,RegistroProveedor Proveedor, string UnidadMedida, int Cantidad):
            this(IDMaterial)
        {
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.PrecioBase = PrecioBase;
            this.PrecioCompra = PrecioCompra;
            this.TiempoBase = TiempoBase;
            this.Proveedor = Proveedor;
            this.UnidadMedida = UnidadMedida;
            this.Cantidad = Cantidad;
        }

        public RegistroMaterial(int IDMaterial)
        {
            this.IDMaterial = IDMaterial;
        }

        public RegistroMaterial(int IDMaterial, int Cantidad):this(IDMaterial)
        {
            this.Cantidad = Cantidad;
        }

        public RegistroMaterial(int IDMaterial, string Nombre, int Faltantes)
            :this(IDMaterial)
        {
            this.Nombre = Nombre;
            this.Faltantes = Faltantes;
        }
    }
}
