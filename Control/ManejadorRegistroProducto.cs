using ConexionBaseDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Control
{
    public class ManejadorRegistroProducto : Manejador
    {
        public bool EliminarProducto(int Clave)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.EliminarProducto(Clave);
        }

        public bool ActivarProducto(int Clave)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ActivarProducto(Clave);
        }

        public bool ActualizarProducto(RegistroProducto Producto)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ActualizarProducto(Producto);
        }
    }
}
