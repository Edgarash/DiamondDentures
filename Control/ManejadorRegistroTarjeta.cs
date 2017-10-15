using ConexionBaseDeDatos;
using Entidad;

namespace Control
{
    public sealed class ManejadorRegistroTarjeta : Manejador
    {
        public bool AgregarRegistroTarjeta(RegistroTarjeta Tarjeta)
        {
            return InterfaceMySQL.RegistroTarjeta(Tarjeta);
        }

        public bool ActualizarRegistroTarjeta(RegistroTarjeta Tarjeta)
        {
            return InterfaceMySQL.ActualizarTarjeta(Tarjeta);
        }

        public bool EliminarTarjeta(string Usuario)
        {
            return InterfaceMySQL.BorrarTarjeta(Usuario);
        }

        public bool ValidarDatosTarjeta(string Usuario)
        {
            bool Result = false;
            RegistroTarjeta Registro;
            InterfaceMySQL.RecuperarTarjeta(Usuario, out Registro);
            if (Registro != null)
            {
                Result = Registro.Activo == (1).ToString();
            }
            return Result;
        }
    }
}