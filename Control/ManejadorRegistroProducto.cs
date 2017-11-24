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
            return InterfaceMySQL.EliminarProducto(Clave);
        }

        public bool ActualizarProducto(RegistroProducto Producto)
        {
            return InterfaceMySQL.ActualizarProducto(Producto);
        }

        public static void UltimaClaveProducto(out RegistroProducto Producto)
        {
            InterfaceMySQL.UltimaClaveProducto(out Producto);
        }

        public static bool RegistrarProducto(RegistroProducto Producto)
        {
            return InterfaceMySQL.AgregarProducto(Producto);
        }
    }
}
