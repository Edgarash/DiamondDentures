using Presentacion.Configuracion;
using Presentacion.Login;
using Presentacion.Recepcion;
using System;
using System.Windows.Forms;
using Presentacion.Reportes;

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
            string Admin = "MICHEL";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PantallaMenuPrincipal(Admin, new PantallaLogin()));
            Application.Run(new PantallaLogin());
        }
    }
}
