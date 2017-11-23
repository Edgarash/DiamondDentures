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

        public static bool ActualizarProveedor(RegistroProveedor Proveedor)
        {
            EjecutarProcedimientoAlmacenado("ActualizarProveedor", TipoConsulta.DevuelveInt, Parametro("id", Proveedor.IDProveedor),
                Parametro("nom", Proveedor.Nombre), Parametro("tel", Proveedor.Telefono), Parametro("email", Proveedor.Correo),
                Parametro("dir", Proveedor.Direccion), Parametro("descripcion", Proveedor.Descripcion));
            return OperacionRealizada;
        }

        public static bool BorrarProveedor(RegistroProveedor proveedor)
        {
            EjecutarProcedimientoAlmacenado("BorrarProveedor", TipoConsulta.DevuelveInt, Parametro("id", proveedor.IDProveedor));
            return OperacionRealizada;
        }

        public static bool AgregarHistorial(HistorialMod Hist)
        {
            EjecutarProcedimientoAlmacenado("AgregarHistorial", TipoConsulta.DevuelveInt, Parametro("idm", Hist.Id),
                Parametro("cant", Hist.Cantidad), Parametro("cantr", Hist.CantidadReal));
            return OperacionRealizada;
        }

        public static bool AgregarFolios(FolioProveedor fp)
        {
            EjecutarProcedimientoAlmacenado("AgregarFolio", TipoConsulta.DevuelveInt, Parametro("idc", fp.IDCompra),
                Parametro("idprov", fp.IDProveedor), Parametro("cant", fp.Cantidad), Parametro("subt", fp.SubTotal));
            return OperacionRealizada;
        }

        public static bool SeleccFolio(out FolioProveedor[] fpr)
        {
            EjecutarProcedimientoAlmacenado("SelecFolio", TipoConsulta.DevuelveReader,
                Parametro("", null));
            bool Exito = OperacionRealizada2;
            fpr = RellenarFolios();
            return Exito;
        }

        public static bool SeleccUnFolio(int IDFolio, out FolioProveedor[] fpr)
        {
            EjecutarProcedimientoAlmacenado("SelecUnFolio", TipoConsulta.DevuelveReader,
                Parametro("id", IDFolio));
            bool Exito = OperacionRealizada2;
            fpr = RellenarFolios();
            return Exito;
        }

        private static FolioProveedor[] RellenarFolios()
        {
            FolioProveedor[] Proveedor = new FolioProveedor[TablaDeResultados.Rows.Count];
            DataTable Mats = TablaDeResultados;
            for (int i = 0; i < Proveedor.Length; i++)
            {
                DataRow x = Mats.Rows[i];
                Proveedor[i] = new FolioProveedor
                    (
                    Convert.ToInt32(x["IDFolio"].ToString()),
                    Convert.ToInt32(x["IDCompra"].ToString()),
                    Convert.ToInt32(x["IDProveedor"].ToString()),
                    Convert.ToDateTime(x["Fecha"].ToString()),
                    Convert.ToInt32(x["Cantidad"].ToString()),
                    Convert.ToSingle(x["Subtotal"].ToString())
                    );
            }
            return Proveedor;
        }

        public static bool SeleccHistorial(out HistorialMod[] Histo)
        {
            EjecutarProcedimientoAlmacenado("SeleHistorial", TipoConsulta.DevuelveReader,
                Parametro("", null));
            bool Exito = OperacionRealizada2;
            Histo = RellenarHistorial();
            return Exito;
        }

        private static HistorialMod[] RellenarHistorial()
        {
            HistorialMod[] Historial = new HistorialMod[TablaDeResultados.Rows.Count];
            DataTable Mats = TablaDeResultados;
            for (int i = 0; i < Historial.Length; i++)
            {
                DataRow x = Mats.Rows[i];
                Historial[i] = new HistorialMod
                    (
                    Convert.ToInt32(x["Id"].ToString()),
                    Convert.ToInt32(x["Cantidad"].ToString()),
                    Convert.ToInt32(x["CantidadReal"].ToString()),
                    Convert.ToInt32(x["Faltantes"].ToString()),
                    Convert.ToDateTime(x["Fecha"].ToString())
                    );
            }
            return Historial;
        }

        public static bool ActualizarCompra(Compras Material)
        {
            EjecutarProcedimientoAlmacenado("ActDatos", TipoConsulta.DevuelveInt, Parametro("tot", Material.Total), Parametro("fech", Material.Fecha), Parametro("idc", Material.IDCompra));
            return OperacionRealizada;
        }

        public static bool ActualizarEDO(CompraMaterial Material)
        {
            EjecutarProcedimientoAlmacenado("ActualizarEstado", TipoConsulta.DevuelveInt, Parametro("idc", Material.IDCompra), Parametro("idp", Material.IDProveedor));
            return OperacionRealizada;
        }

        public static bool MostrarProveedores(out RegistroProveedor[] Proveedor)
        {
            EjecutarProcedimientoAlmacenado("VerProveedores", TipoConsulta.DevuelveReader,
                Parametro("", null));
            bool Exito = OperacionRealizada2;
            Proveedor = RellenarProveedor();
            return Exito;
        }

        public static bool MostrarUnProveedor(string Nombre, out RegistroProveedor[] Proveedor)
        {
            EjecutarProcedimientoAlmacenado("UnProveedor", TipoConsulta.DevuelveReader,
                Parametro("nom", Nombre));
            bool Exito = OperacionRealizada2;
            Proveedor = RellenarProveedor();
            return Exito;
        }

        public static bool DetalleProveedorMaterial(int IDProveedor, out CompraMaterial[] Proveedor)
        {
            EjecutarProcedimientoAlmacenado("DetalleMatProv", TipoConsulta.DevuelveReader,
                Parametro("id", IDProveedor));
            bool Exito = OperacionRealizada2;
            Proveedor = RellenarDetallesMateriales();
            return Exito;
        }

        public static bool MostrarUnaCompra(CompraMaterial cm, out CompraMaterial[] Proveedor)
        {
            EjecutarProcedimientoAlmacenado("UnaCompra", TipoConsulta.DevuelveReader,
                Parametro("id", cm.IDCompra), Parametro("idprov", cm.IDProveedor));
            bool Exito = OperacionRealizada2;
            Proveedor = RellenarDetallesMateriales();
            return Exito;
        }

        private static RegistroProveedor[] RellenarProveedor()
        {
            RegistroProveedor[] Proveedores = new RegistroProveedor[TablaDeResultados.Rows.Count];
            DataTable Mats = TablaDeResultados;
            for (int i = 0; i < Proveedores.Length; i++)
            {
                DataRow x = Mats.Rows[i];
                Proveedores[i] = new RegistroProveedor
                    (
                    Convert.ToInt32(x["IDProveedor"].ToString()),
                    x["Nombre"].ToString(),
                    x["Telefono"].ToString(),
                    x["Correo"].ToString(),
                    x["Direccion"].ToString(),
                    x["Descripcion"].ToString()
                    );
            }
            return Proveedores;
        }

        public static bool AgregarCompra(Compras compras)
        {
            EjecutarProcedimientoAlmacenado("AgregarCompra", TipoConsulta.DevuelveInt, Parametro("idcompra", compras.IDCompra));
            return OperacionRealizada;
        }

        public static bool ObtenerID(out Compras Compra)
        {
            EjecutarProcedimientoAlmacenado("ObtenerIdCompra", TipoConsulta.DevuelveReader,
            Parametro("", null));

            bool Exito = OperacionRealizada2;
            Compra = DarID();
            return Exito;
        }

        public static Compras DarID()
        {
            Compras[] x = RellenarCompra();
            Compras temp = x.Length > 0 ? x[0] : null;
            RegistrosAfectados = temp != null ? 1 : 0;
            return temp;
        }

        public static Compras[] RellenarCompra()
        {
            Compras[] Comprar = new Compras[TablaDeResultados.Rows.Count];
            DataTable Mats = TablaDeResultados;
            for (int i = 0; i < Comprar.Length; i++)
            {
                DataRow x = Mats.Rows[i];
                Comprar[i] = new Compras
                    (
                    Convert.ToInt32(x[0].ToString())
                    );
            }
            return Comprar;
        }

        public static bool AgregarAlaCompra(CompraMaterial CMaterial)
        {
            EjecutarProcedimientoAlmacenado("Estaweasegurovatronar", TipoConsulta.DevuelveInt, Parametro("idcompra", CMaterial.IDCompra), Parametro("id", CMaterial.IDMaterial),
                Parametro("nom", CMaterial.Nombre), Parametro("idprov", CMaterial.IDProveedor), Parametro("cantidad", CMaterial.Cantidad));
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
                Parametro("cantreal", RMaterial.Cantidad));
            return OperacionRealizada;
        }

        public static bool Actualizar_Real(RegistroMaterial RMaterial)
        {
            EjecutarProcedimientoAlmacenado("ActualizarCantidades", TipoConsulta.DevuelveInt, Parametro("id", RMaterial.IDMaterial),
                Parametro("cantreal", RMaterial.Cantidad));
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

        public static bool RecuperarCompras(out Compras[] Compra)
        {
            EjecutarProcedimientoAlmacenado("VerCompras", TipoConsulta.DevuelveReader,
                Parametro("", null));
            bool Exito = OperacionRealizada2;
            Compra = RellenarCompras();
            return Exito;
        }

        private static Compras[] RellenarCompras()
        {
            Compras[] Comprar = new Compras[TablaDeResultados.Rows.Count];
            DataTable Mats = TablaDeResultados;
            for (int i = 0; i < Comprar.Length; i++)
            {
                DataRow x = Mats.Rows[i];
                Comprar[i] = new Compras
                    (
                    Convert.ToInt32(x["IDCompra"].ToString()),
                    x["Empleado"].ToString(),
                    Convert.ToSingle(x["Total"].ToString()),
                    Convert.ToDateTime(x["Fecha"].ToString()),
                    x["Tipo"].ToString(),
                    Convert.ToDateTime(x["FechaSurtido"].ToString()),
                    x["Estado"].ToString()
                    );
            }
            return Comprar;
        }

        public static bool ActualizarPrecio(CompraMaterial cm)
        {
            EjecutarProcedimientoAlmacenado("ActualizarPrecio", TipoConsulta.DevuelveReader,
                Parametro("id", cm.IDCompra), Parametro("idmat", cm.IDMaterial), Parametro("cant", cm.Cantidad));
            return OperacionRealizada;
        }

        public static bool DetallesMaterial(int IDCompra, out CompraMaterial[] Material)
        {
            EjecutarProcedimientoAlmacenado("VerDetalles", TipoConsulta.DevuelveReader,
                Parametro("id", IDCompra));
            bool Exito = OperacionRealizada2;
            Material = RellenarDetallesMateriales();
            return Exito;
        }

        private static CompraMaterial[] RellenarDetallesMateriales()
        {
            CompraMaterial[] Materiales = new CompraMaterial[TablaDeResultados.Rows.Count];
            DataTable Mats = TablaDeResultados;
            for (int i = 0; i < Materiales.Length; i++)
            {
                DataRow x = Mats.Rows[i];
                Materiales[i] = new CompraMaterial
                    (
                    Convert.ToInt32(x["IDCompra"].ToString()),
                    Convert.ToInt32(x["IDMaterial"].ToString()),
                    x["Nombre"].ToString(),
                    Convert.ToInt32(x["IDProveedor"].ToString()),
                    Convert.ToSingle(x["Subtotal"].ToString()),
                    Convert.ToInt32(x["Cantidad"].ToString()),
                    Convert.ToDateTime(x["Fecha"].ToString()),
                    x["Estado"].ToString()
                    );
            }
            return Materiales;
        }

        public static bool ObtenerMateriales2(out RegistroMaterial[] Materiales)
        {
            EjecutarProcedimientoAlmacenado("ObtenerMateriales2", TipoConsulta.DevuelveReader,
                Parametro("", null));
            bool Exito = OperacionRealizada2;
            Materiales = RellenarMateriales3();
            return Exito;
        }

        public static bool ObtenerMateriales3(out RegistroMaterial[] Materiales)
        {
            EjecutarProcedimientoAlmacenado("ObtenerMateriales3", TipoConsulta.DevuelveReader,
                Parametro("", null));
            bool Exito = OperacionRealizada2;
            Materiales = RellenarMateriales3();
            return Exito;
        }

        public static bool ObtenerUnMaterial(string Nombre, out RegistroMaterial[] Materiales)
        {
            EjecutarProcedimientoAlmacenado("ObtenerUnMaterial", TipoConsulta.DevuelveReader,
                Parametro("nom", Nombre));
            bool Exito = OperacionRealizada2;
            Materiales = RellenarMateriales3();
            return Exito;
        }

        public static bool ObtenerUnMaterial2(string Nombre, out RegistroMaterial[] Materiales)
        {
            EjecutarProcedimientoAlmacenado("ObtenerUnMaterial2", TipoConsulta.DevuelveReader,
                Parametro("nom", Nombre));
            bool Exito = OperacionRealizada2;
            Materiales = RellenarMateriales3();
            return Exito;
        }

        private static RegistroMaterial[] RellenarMateriales3()
        {
            RegistroMaterial[] Materiales = new RegistroMaterial[TablaDeResultados.Rows.Count];
            DataTable Mats = TablaDeResultados;
            for (int i = 0; i < Materiales.Length; i++)
            {
                DataRow x = Mats.Rows[i];
                RegistroProveedor Proveedor;
                RecuperarProveedor(Convert.ToInt32(x["Proveedor"].ToString()), out Proveedor);
                Materiales[i] = new RegistroMaterial
                    (
                    Convert.ToInt32(x["IDMaterial"].ToString()),
                    x["Nombre"].ToString(),
                    x["Descripcion"].ToString(),
                    Convert.ToSingle(x["PrecioBase"].ToString()),
                    Convert.ToSingle(x["PrecioCompra"].ToString()),
                    Convert.ToInt32(x["TiempoBase"].ToString()),
                    Proveedor,
                    x["UnidadMedida"].ToString(),
                    Convert.ToInt32(x["Cantidad"].ToString())
                    );
            }
            return Materiales;
        }

        public static bool FinanzasVerMaterialesDeProveedor(DataGridView temp, string id)
        {
            EjecutarProcedimientoAlmacenado("FinanzasVerMaterialesDeProveedor", TipoConsulta.DevuelveReader,
                Parametro("id", id));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }

    }
}