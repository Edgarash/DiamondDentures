using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroVenta  : Datos
    {
        public RegistroPedido Pedido { get; set; }
        public float Importe { get; set; }
        public float Recibido { get; set; }
        public DateTime FechaPago { get; set; }
        public RegistroUsuario Registra { get; set; }
        public string PersonaPaga { get; set; }
        public string FormaPago { get; set; }

        public RegistroVenta(RegistroPedido Pedido, float Importe, float Recibido, DateTime FechaPago, RegistroUsuario Usuario,
            string PersonaPaga, string FormaPago)
        {
            this.Pedido = Pedido;
            this.Importe = Importe;
            this.Recibido = Recibido;
            this.FechaPago = FechaPago;
            this.Registra = Usuario;
            this.PersonaPaga = PersonaPaga;
            this.FormaPago = FormaPago;
        }
    }
}
