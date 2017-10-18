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
        public float SubTotal { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public CompraMaterial(int IDCompra, int IDMaterial, string Nombre, int Cantidad, DateTime Fecha, string Estado)
        {
            this.IDCompra = IDCompra;
            this.IDMaterial = IDMaterial;
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
            this.Fecha = Fecha;
            this.Estado = Estado;
        }
    }
}
