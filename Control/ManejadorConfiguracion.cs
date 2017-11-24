using ConexionBaseDeDatos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class ManejadorConfiguracion : Manejador
    {
        public static bool ObtenerProductos(out RegistroProducto[] Pedidos)
        {
            return InterfaceMySQL.ObtenerProductos(out Pedidos);
        }

        public static bool ObtenerUnProducto(int IDProducto, out RegistroProducto Producto)
        {
            return InterfaceMySQL.ObtenerUnProducto(IDProducto, out Producto);
        }

        public static bool ActualizarProMat(RegistroProMat Registro)
        {
            return InterfaceMySQL.ActualizarProMat(Registro);
        }

        public static bool ObtenerProMat(int Producto, int Material, out RegistroProMat[] ProMat)
        {
            return InterfaceMySQL.ObtenerProductosMateriales(Producto, Material, out ProMat);
        }

        public static bool ObtenerUltimaClaveMaterial(out RegistroMaterial Material)
        {
            return InterfaceMySQL.ObtenerUltimaClaveMaterial(out Material);
        }

        public static bool ObtenerProveedores(out RegistroProveedor[] Proveedores)
        {
            return InterfaceMySQL.ObtenerProveedores(out Proveedores);
        }
    }
}
