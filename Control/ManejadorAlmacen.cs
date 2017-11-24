using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionBaseDeDatos;
using Entidad;

namespace Control
{
    public static class ManejadorAlmacen
    {
        public static bool AgregarProveedor(RegistroProveedor Proveedor)
        {
            return InterfaceMySQL.AgregarProveedor(Proveedor);
        }

        public static bool ActualizarProveedor(RegistroProveedor Proveedor)
        {
            return InterfaceMySQL.ActualizarProveedor(Proveedor);
        }

        public static bool BorrarProveedor(RegistroProveedor Proveedor)
        {
            return InterfaceMySQL.BorrarProveedor(Proveedor);
        }

        public static bool Compra_Material(CompraMaterial Material)
        {
            return InterfaceMySQL.Compra_Material(Material);
        }

        public static bool ActualizarEDO(CompraMaterial Material)
        {
            return InterfaceMySQL.ActualizarEDO(Material);
        }

        public static bool AgregarFolios(FolioProveedor fp)
        {
            return InterfaceMySQL.AgregarFolios(fp);
        }

        public static bool ActualizarPrecio(CompraMaterial cm)
        {
            return InterfaceMySQL.ActualizarPrecio(cm);
        }

        public static bool Actualizar_Cantidad(RegistroMaterial RMaterial)
        {
            return InterfaceMySQL.Actualizar_Cantidad(RMaterial);
        }

        public static bool Actualizar_Real(RegistroMaterial RMaterial)
        {
            return InterfaceMySQL.Actualizar_Real(RMaterial);
        } 
        
        public static bool AgregarCompra(Compras compras)
        {
            return InterfaceMySQL.AgregarCompra(compras);
        }
        public static bool AgregarCompraInsumos7(Compras compras)
        {
            return InterfaceMySQL.AgregarCompraInsumos7(compras);
        }

        public static bool ActualizarCompra(Compras compras)
        {
            return InterfaceMySQL.ActualizarCompra(compras);
        }

        public static bool AgregarAlaCompra(CompraMaterial CMaterial)
        {
            return InterfaceMySQL.AgregarAlaCompra(CMaterial);
        }
        public static bool AgregarInsumosAlaCompra(CompraMaterial CMaterial)
        {
            return InterfaceMySQL.AgregarInsumosAlaCompra(CMaterial);
        }

        public static bool AgregarHistorial(HistorialMod Historial)
        {
            return InterfaceMySQL.AgregarHistorial(Historial);
        }
    }
}
