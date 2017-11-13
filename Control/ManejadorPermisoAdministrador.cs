using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public sealed class ManejadorPermisoAdministrador : Manejador
    {
        public ManejadorPermisoAdministrador()
        {

        }
        public bool PermisoObtenido(string Password)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            return Interface.ObtenerPermiso(Password);
        }
    }
}
