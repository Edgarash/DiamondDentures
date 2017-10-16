using ConexionBaseDeDatos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Ventas
{
    public class ManejadorVentas : Manejador
    {
        public static bool InsertarVenta(RegistroVenta Venta)
        {
            return InterfaceMySQL.InsertarVenta(Venta);
        }
    }
}
