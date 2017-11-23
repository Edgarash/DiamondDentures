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
        public bool RegistrarProducto(RegistroProducto Registro)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.RegistrarProducto(Registro);
        }

        public RegistroProducto[] ObtenerProductos()
        {
            RegistroProducto[] temp = null;
            InterfaceMySQL.ObtenerProductos(out temp);
            return temp;
        }

        public RegistroProducto ObtenerUnProducto(string Producto)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ObtenerUnProducto(Producto);
        }

        public RegistroProducto[] BuscarUnProducto(RegistroProducto Producto)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.BuscarProducto(Producto);
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
