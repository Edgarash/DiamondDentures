using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConexionBaseDeDatos
{
    /// <summary>
    /// Describe los métodos para accesar a una base de datos de MySQL
    /// </summary>
    public static partial class InterfaceMySQL
    {
        //En esta clase sólo Rolland deberá meter sólo los métodos y atributos que 

        public static bool AgregarProveedor(RegistroProveedor Proveedor)
        {
            EjecutarProcedimientoAlmacenado("AgregarProveedor", TipoConsulta.DevuelveInt, Parametro("id", Proveedor.IDProveedor),
                Parametro("nom", Proveedor.Nombre), Parametro("tel", Proveedor.Telefono), Parametro("email", Proveedor.Correo), 
                Parametro("dir", Proveedor.Direccion), Parametro("descripcion", Proveedor.Descripcion));
            return OperacionRealizada;
        }

        public static bool Compra_Material(CompraMaterial CMaterial)
        {
            EjecutarProcedimientoAlmacenado("ComprarMateriales", TipoConsulta.DevuelveInt, Parametro("idC", CMaterial.IDCompra),
                Parametro("idM", CMaterial.IDCompra), Parametro("Nombre", CMaterial.Nombre), Parametro("Cantidad", CMaterial.Cantidad),
                Parametro("Fecha", CMaterial.Fecha), Parametro("Estado", CMaterial.Estado));
            return OperacionRealizada;
        }

        public static bool Actualizar_Cantidad(RegistroMaterial RMaterial)
        {
            EjecutarProcedimientoAlmacenado("ManejarCantidades", TipoConsulta.DevuelveInt, Parametro("id", RMaterial.IDMaterial),
                Parametro("cantreal", RMaterial.CantidadReal));
            return OperacionRealizada;
        }


        public static bool MostrarFaltantes (out RegistroMaterial[] Materiales)
        {
            EjecutarProcedimientoAlmacenado("MostrarFaltantes", TipoConsulta.DevuelveReader,
                Parametro("", null));
            bool Exito = OperacionRealizada2;
            Materiales = RellenarMateriales2();
            return Exito;
        }

        private static RegistroMaterial[] RellenarMateriales2()
        {
            RegistroMaterial[] Materiales = new RegistroMaterial[TablaDeResultados.Rows.Count];
            DataTable Mats = TablaDeResultados;
            for (int i = 0; i < Materiales.Length; i++)
            {
                DataRow x = Mats.Rows[i];
                Materiales[i] = new RegistroMaterial
                    (
                    Convert.ToInt32(x["IDMaterial"].ToString()),
                    x["Nombre"].ToString(),
                    Convert.ToInt32(x["Faltantes"].ToString())
                    );
            }
            return Materiales;
        }

    }
}