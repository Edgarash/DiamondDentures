using ConexionBaseDeDatos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Ventas
{
    public class ManejadorVentas : Manejador
    {
        public static bool InsertarVenta(RegistroVenta Venta)
        {
            return InterfaceMySQL.InsertarVenta(Venta);
        }

        public static bool VerVentas(int IDVenta, DateTime FechaMin, DateTime FechaMax,
            string IDPedido, string Nombre, string Referencia, bool Efectivo, bool Tarjeta,
            bool Cheque, out DataTable Datos, out RegistroVenta[] Ventas)
        {
            return InterfaceMySQL.VerVentas(IDVenta, FechaMin, FechaMax,
                IDPedido, Nombre, Referencia, Efectivo, Tarjeta, Cheque, out Datos, out Ventas);
        }

        public static bool BuscarPedidosNoPagados(string IDPedido, DateTime FechaMin, DateTime FechaMax,
            string Empleado, string Dentista, bool Urgente, bool NoPagado, out RegistroPedido[] Pedidos)
        {
            return InterfaceMySQL.BuscarPedidosNoPagados(IDPedido, FechaMin, FechaMax, Empleado, Dentista,
                Urgente, NoPagado, out Pedidos);
        }

        public static bool RealizarDevolucionTicket(int IDVenta)
        {
            return InterfaceMySQL.RealizarDevolucionTicket(IDVenta);
        }

        public static DataTable UltimoCorteCaja()
        {
            return InterfaceMySQL.UltimoCorteCaja();
        }
    }
}
