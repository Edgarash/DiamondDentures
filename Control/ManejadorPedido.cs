using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using ConexionBaseDeDatos;

namespace Control
{
    public class ManejadorPedido : Manejador
    {
        public static bool RegistrarPedido(RegistroPedido Pedido)
        {
            return InterfaceMySQL.RegistrarPedido(Pedido);
        }

        public RegistroPedido ObtenerUnPedido(string clavePedido)
        {
            RegistroPedido Pedido;
            InterfaceMySQL.RecuperarPedido(clavePedido, out Pedido);
            return Pedido;
        }

        public bool ActualizarPedido(RegistroPedido Pedido)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ActualizarPedido(Pedido);
        }
    }
}
