using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad 
{
    public class FolioProveedor : Datos
    {
        public int IDFolio { get; set; }
        public int IDCompra { get; set; }
        public int IDProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public float SubTotal { get; set; }

        public FolioProveedor(int IDFolio, int IDCompra, int IDProveedor, DateTime Fecha, int Cantidad, float SubTotal)
        {
            this.IDFolio = IDFolio;
            this.IDCompra = IDCompra;
            this.IDProveedor = IDProveedor;
            this.Fecha = Fecha;
            this.Cantidad = Cantidad;
            this.SubTotal = SubTotal;
        }

        public FolioProveedor(int IDCompra, int IDProveedor, int Cantidad, float SubTotal)
        {
            this.IDCompra = IDCompra;
            this.IDProveedor = IDProveedor;
            this.Cantidad = Cantidad;
            this.SubTotal = SubTotal;
        }
    }
}
