using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CompraInsumos : Datos
    {
        public int IDCompra { get; set; }
        public int IDInsumos { get; set; }
        public string Nombre { get; set; }
        public int IDProveedor { get; set; }
        public float SubTotal { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public CompraInsumos(int IDCompra, int IDInsumos, string Nombre, int IDProveedor, float SubTotal, int Cantidad, DateTime Fecha, string Estado)
        {
            this.IDCompra = IDCompra;
            this.IDInsumos = IDInsumos;
            this.Nombre = Nombre;
            this.IDProveedor = IDProveedor;
            this.SubTotal = SubTotal;
            this.Cantidad = Cantidad;
            this.Fecha = Fecha;
            this.Estado = Estado;
        }

        public CompraInsumos(int IDCompra, int IDInsumos, string Nombre, int IDProveedor, int Cantidad)
        {
            this.IDCompra = IDCompra;
            this.IDInsumos = IDInsumos;
            this.Nombre = Nombre;
            this.IDProveedor = IDProveedor;
            this.Cantidad = Cantidad;
        }
    }
}
