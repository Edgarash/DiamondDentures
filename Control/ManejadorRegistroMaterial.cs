using System;
using Entidad;
using ConexionBaseDeDatos;
using System.Windows.Forms;

namespace Control
{
    public class ManejadorRegistroMaterial : Manejador
    {
        public static bool RegistrarMaterial(RegistroMaterial Material)
        {
            return InterfaceMySQL.RegistrarMaterial(Material);
        }

        public RegistroMaterial[] ObtenerMateriales()
        {
            RegistroMaterial[] temp = null;
            InterfaceMySQL.ObtenerMateriales(out temp);
            return temp;
        }

        public RegistroMaterial[] ObtenerMateriales3()
        {
            RegistroMaterial[] temp = null;
            InterfaceMySQL.ObtenerMateriales3(out temp);
            return temp;
        }

        public RegistroMaterial[] ObtenerUnMaterial(string Nombre)
        {
            RegistroMaterial[] temp = null;
            InterfaceMySQL.ObtenerUnMaterial(Nombre, out temp);
            return temp;
        }

        public RegistroMaterial[] ObtenerUnMaterial2(string Nombre)
        {
            RegistroMaterial[] temp = null;
            InterfaceMySQL.ObtenerUnMaterial2(Nombre, out temp);
            return temp;
        }

        public RegistroMaterial[] ObtenerMateriales2()
        {
            RegistroMaterial[] temp = null;
            InterfaceMySQL.ObtenerMateriales2(out temp);
            return temp;
        }

        public HistorialMod[] SeleccHistorial()
        {
            HistorialMod[] temp = null;
            InterfaceMySQL.SeleccHistorial(out temp);
            return temp;
        }

        public RegistroProveedor[] MostrarProveedores()
        {
            RegistroProveedor[] temp = null;
            InterfaceMySQL.MostrarProveedores(out temp);
            return temp;
        }

        public FolioProveedor[] SeleccFolios()
        {
            FolioProveedor[] temp = null;
            InterfaceMySQL.SeleccFolio(out temp);
            return temp;
        }

        public FolioProveedor[] SeleccUnFolio(int IDFolio)
        {
            FolioProveedor[] temp = null;
            InterfaceMySQL.SeleccUnFolio(IDFolio, out temp);
            return temp;
        }

        public RegistroProveedor[] MostrarUnProveedor(string Nombre)
        {
            RegistroProveedor[] temp = null;
            InterfaceMySQL.MostrarUnProveedor(Nombre, out temp);
            return temp;
        }

        public Compras[] RecuperarCompras()
        {
            Compras[] temp = null;
            InterfaceMySQL.RecuperarCompras(out temp);
            return temp;
        }

        public CompraMaterial[] DetallesMaterial(int IDCompra)
        {
            CompraMaterial[] temp = null;
            InterfaceMySQL.DetallesMaterial(IDCompra, out temp);
            return temp;
        }
        public CompraMaterial[] VerDetallesPagos(DataGridView dt ,int IDCompra)
        {
            CompraMaterial[] temp = null;
            InterfaceMySQL.VerDetallesPagos(dt, IDCompra);
            return temp;
        }

        public CompraMaterial[] DetallesProveedorMaterial(int IDProveedor)
        {
            CompraMaterial[] temp = null;
            InterfaceMySQL.DetalleProveedorMaterial(IDProveedor, out temp);
            return temp;
        }

        public CompraMaterial[] MostrarUnaCompra(CompraMaterial cm)
        {
            CompraMaterial[] temp = null;
            InterfaceMySQL.MostrarUnaCompra(cm, out temp);
            return temp;
        }

        public Compras ObtenerID()
        {
            Compras temp = null;
            InterfaceMySQL.ObtenerID(out temp);
            return temp;
        }

        public RegistroMaterial[] MostrarFaltantes()
        {
            RegistroMaterial[] temp = null;
            InterfaceMySQL.MostrarFaltantes(out temp);
            return temp;
        }

        public RegistroMaterial ObtenerUnMaterial(int clave)
        {
            RegistroMaterial temp;
            InterfaceMySQL.RecuperarMaterial(clave, out temp);
            return temp;
        }

        public static bool ActualizarMaterial(RegistroMaterial Material)
        {
            return InterfaceMySQL.ActualizarMaterial(Material);
        }

        public static bool EliminarMaterial(int Clave)
        {
            return InterfaceMySQL.EliminarMaterial(Clave);
        }
    }
}