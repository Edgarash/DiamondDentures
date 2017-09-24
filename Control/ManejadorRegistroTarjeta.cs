using ConexionBaseDeDatos;
using Entidad;

namespace Control
{
    public sealed class ManejadorRegistroTarjeta : Manejador
    {
        public bool AgregarRegistroTarjeta(RegistroTarjeta Tarjeta)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.RegistroTarjeta(Tarjeta);
        }

        public bool ActualizarRegistroTarjeta(RegistroTarjeta Tarjeta)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ActualizarTarjeta(Tarjeta);
        }

        public bool EliminarTarjeta(string Usuario)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.BorrarTarjeta(Usuario);
        }

        public bool ValidarDatosTarjeta(string Usuario)
        {
            bool Result = false;
            Interface = new InterfaceBaseDeDatos();
            RegistroTarjeta Registro;
            Interface.RecuperarTarjeta(Usuario, out Registro);
            if (Registro != null)
            {
                Result = Registro.Activo == (1).ToString();
            }
            return Result;
        }
    }
}