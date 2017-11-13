using System;
using ConexionBaseDeDatos;

namespace Control
{
    public class ManejadorBorrarFactura : Manejador
    {
        public static void CancelarFactura(int facturaId)
        {
            InterfaceBaseDeDatos.CancelarFactura(facturaId);
        }
    }
}
