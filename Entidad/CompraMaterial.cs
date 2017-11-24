using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CompraMaterial : Datos
    {
        public int IDCompra { get; set; }
        public int IDMaterial { get; set; }
        public string Nombre { get; set; }
        public int IDProveedor { get; set; }
        public float SubTotal { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int CantidadEnviada { get; set; }

        public CompraMaterial(int IDCompra, int IDMaterial, string Nombre, int IDProveedor, float SubTotal, int Cantidad, DateTime Fecha, string Estado, int CantidadEnviada)
        {
            this.IDCompra = IDCompra;
            this.IDMaterial = IDMaterial;
            this.Nombre = Nombre;
            this.IDProveedor = IDProveedor;
            this.SubTotal = SubTotal;
            this.Cantidad = Cantidad;
            this.Fecha = Fecha;
            this.Estado = Estado;
            this.CantidadEnviada = CantidadEnviada;
        }

        public CompraMaterial(int IDCompra, int IDMaterial, string Nombre, int IDProveedor, int Cantidad)
        {
            this.IDCompra = IDCompra;
            this.IDMaterial = IDMaterial;
            this.Nombre = Nombre;
            this.IDProveedor = IDProveedor;
            this.Cantidad = Cantidad;
        }

        public CompraMaterial(int IDCompra, int IDProveedor)
        {
            this.IDCompra = IDCompra;
            this.IDProveedor = IDProveedor;
        }

        public CompraMaterial(int IDCompra, int IDProveedor, int CantidadEnviada)
        {
            this.IDCompra = IDCompra;
            this.IDProveedor = IDProveedor;
            this.IDMaterial = IDProveedor;
            this.CantidadEnviada = CantidadEnviada;
        }
    }
}
