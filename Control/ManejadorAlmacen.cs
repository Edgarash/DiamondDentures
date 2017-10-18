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

        public static bool Compra_Material(CompraMaterial Material)
        {
            return InterfaceMySQL.Compra_Material(Material);
        }

        public static bool Actualizar_Cantidad(RegistroMaterial RMaterial)
        {
            return InterfaceMySQL.Actualizar_Cantidad(RMaterial);
        }
    }
}
