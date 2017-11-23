using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Compras : Datos
    {
        public int IDCompra { get; set; }
        public string Empleado { get; set; }
        public float Total { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaSurtido { get; set; }
        public string Estado { get; set; }

        public Compras(int IDCompra, string Empleado, float Total, DateTime Fecha, string Tipo, DateTime FechaSurtido, string Estado)
        {
            this.IDCompra = IDCompra;
            this.Empleado = Empleado;
            this.Total = Total;
            this.Fecha = Fecha;
            this.Tipo = Tipo;
            this.FechaSurtido = FechaSurtido;
            this.Estado = Estado;
        }

        public Compras(int IDCompra)
        {
            this.IDCompra = IDCompra;
        }

        public Compras(int IDCompra, float Total, DateTime Fecha)
        {
            this.IDCompra = IDCompra;
            this.Total = Total;
            this.FechaSurtido = FechaSurtido;
        }
    }
}
