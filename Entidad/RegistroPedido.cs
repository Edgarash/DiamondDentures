using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroPedido : Datos
    {
        public string IDPedido { get; set; }
        public string IDEmpleado { get { return RegistraPedido.Login; } }
        public RegistroUsuario RegistraPedido { get; set; }
        public string Cedula { get { return Dentista.Cedula; } }
        public RegistroDentista Dentista { get; set; }
        public int EstadoPedido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCalculada { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Entregado { get; set; }
        public string Urgencia { get; set; }
        public float CostoTotal { get; set; }
        public string Laboratorista { get { return RealizaPedido.Login; } }
        public RegistroUsuario RealizaPedido { get; set; }
        public string Pagado { get; set; }
        public float RestanteAPagar { get; set; }

        public RegistroTrabajo[] Productos { get; set; }

        public RegistroPedido(string IDPedido, RegistroUsuario RegistraPedido, RegistroDentista Dentista,
            int EstadoPedido, DateTime FechaIngreso, DateTime FechaCalculada, DateTime FechaEntrega,
            string Entregado, string Urgencia, float CostoTotal, RegistroUsuario Laboratorista, string Pagado,
            float RestanteAPagar, RegistroTrabajo[] Productos)
        {
            this.IDPedido = IDPedido;
            this.RegistraPedido = RegistraPedido;
            this.Dentista = Dentista;
            this.EstadoPedido = EstadoPedido;
            this.FechaIngreso = FechaIngreso;
            this.FechaCalculada = FechaCalculada;
            this.FechaEntrega = FechaEntrega;
            this.Entregado = Entregado;
            this.Urgencia = Urgencia;
            this.CostoTotal = CostoTotal;
            RealizaPedido = Laboratorista;
            this.Pagado = Pagado;
            this.RestanteAPagar = RestanteAPagar;
            this.Productos = Productos;
        }
    }
}
