using ConexionBaseDeDatos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public sealed class ManejadorUsuario : Manejador
    {
        public bool RecuperarUsuario(string Usuario, out RegistroUsuario RegistroUsuario)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.RecuperarUsuario(Usuario, out RegistroUsuario);
        }

        public bool RegistrarEmpleado(int NumeroEmpleado)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.RegistrarEmpleado(NumeroEmpleado);
        }

        public bool EliminarTarjeta(string Usuario)
        {
            ManejadorRegistroTarjeta Temporal = new ManejadorRegistroTarjeta();
            return Temporal.EliminarTarjeta(Usuario);
        }

        public bool HayAdministradores(out int Conteo)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.HayAdministradores(out Conteo);
        }

        public bool BorrarUsuario(string Usuario)
        {
            ManejadorRegistroUsuario Temporal = new ManejadorRegistroUsuario();
            return Temporal.BorrarUsuario(Usuario);
        }

        public bool ActivarUsuario(string Usuario)
        {
            ManejadorRegistroUsuario Temporal = new ManejadorRegistroUsuario();
            return Temporal.ActivarUsuario(Usuario);
        }

        public bool AgregarRegistroTarjeta(RegistroTarjeta Tarjeta)
        {
            ManejadorRegistroTarjeta Temporal = new ManejadorRegistroTarjeta();
            return Temporal.AgregarRegistroTarjeta(Tarjeta);
        }

        public bool RecuperarTarjeta(string Usuario, out RegistroTarjeta RegistroTarjeta)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.RecuperarTarjeta(Usuario, out RegistroTarjeta);
        }

        public string RecuperarContraseña(int NumEmpleado)
        {
            string temp = "";
            Interface = new InterfaceBaseDeDatos();
            Interface.RecuperarContraseña(NumEmpleado, out temp);
            return temp;
        }

        public void ObtenerUsuarios(DataGridView temp)
        {
            Interface = new InterfaceBaseDeDatos();
            Interface.Datos(temp);
        }
    }
}
