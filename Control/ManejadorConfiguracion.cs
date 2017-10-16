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

        public bool ActualizarProMat(RegistroProMat Registro)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ActualizarProMat(Registro);
        }

        public RegistroProMat[] ObtenerProMat(int mat, int pro)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ObtenerProMat(mat, pro);
        }
    }
}
