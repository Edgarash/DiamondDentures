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
        public bool RegistrarPedido(RegistroPedido Pedido)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.RegistrarPedido(Pedido);
        }

        public RegistroPedido ObtenerUnPedido(string clavePedido)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ObtenerUnPedido(clavePedido);
        }

        public bool ActualizarPedido(RegistroPedido Pedido)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ActualizarPedido(Pedido);
        }
    }
}
