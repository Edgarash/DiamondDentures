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
        public int IDProveedor { get; set; }
        public string UnidadMedida { get; set; }
        public int Cantidad { get; set; }
        public int CantidadReal { get; set; }
        public int Faltantes { get; set; }

        public RegistroMaterial(int IDMaterial, string Nombre,string Descripcion, float PrecioBase, float PrecioCompra,
            int TiempoBase, int IDProveedor, string UnidadMedida, int Cantidad, int CantidadReal)
        {
            this.IDMaterial = IDMaterial;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.PrecioBase = PrecioBase;
            this.PrecioCompra = PrecioCompra;
            this.TiempoBase = TiempoBase;
            this.IDProveedor = IDProveedor;
            this.UnidadMedida = UnidadMedida;
            this.Cantidad = Cantidad;
            this.CantidadReal = CantidadReal;
        }

        public RegistroMaterial(int IDMaterial, int CantidadReal)
        {
            this.IDMaterial = IDMaterial;
            this.CantidadReal = CantidadReal;
        }

        public RegistroMaterial(int IDMaterial, string Nombre, int Faltantes)
        {
            this.IDMaterial = IDMaterial;
            this.Nombre = Nombre;
            this.Faltantes = Faltantes;
        }

        public RegistroMaterial(int IDMaterial, string Nombre, string Descripcion, float PrecioBase, float PrecioCompra,
            int TiempoBase, int IDProveedor, string UnidadMedida, int Cantidad)
        {
            this.IDMaterial = IDMaterial;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.PrecioBase = PrecioBase;
            this.PrecioCompra = PrecioCompra;
            this.TiempoBase = TiempoBase;
            this.IDProveedor = IDProveedor;
            this.UnidadMedida = UnidadMedida;
            this.Cantidad = Cantidad;
        }
    }
}
