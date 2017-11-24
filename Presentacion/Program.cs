using Presentacion.Configuracion;
using Presentacion.Login;
using Presentacion.Recepcion;
using System;
using System.Windows.Forms;
using Entidad;
using Presentacion.Almacen_y_Proveedores;
using Presentacion.Finanzas;
using Presentacion.Reportes;
using Presentacion.Ventas.CorteCaja;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] Args)
        {
            if (ConexionBaseDeDatos.InterfaceMySQL.ActualizarBaseDeDatos())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new PantallaLogin());
                Application.Run(new VerProveedores());
            }
        }
    }
}
