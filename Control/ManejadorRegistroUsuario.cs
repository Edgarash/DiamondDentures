using ConexionBaseDeDatos;
using Entidad;

namespace Control
{
    public sealed class ManejadorRegistroUsuario : Manejador
    {
        public ManejadorRegistroUsuario()
        {
            Interface = new InterfaceBaseDeDatos();
        }
        public bool RegistrarUsuario(RegistroUsuario Usuario)
        {
            return Interface.RegistroUsuario(Usuario);
        }
        public bool ActualizarUsuario(string User, RegistroUsuario Usuario)
        {
            return Interface.ActualizarUsuario(User, Usuario);
        }
        public bool BorrarUsuario(string Usuario)
        {
            return Interface.BorrarUsuario(Usuario);
        }
        public bool ActivarUsuario(string Usuario)
        {
            return Interface.ActivarUsuario(Usuario);
        }
        public bool ValidarUsuario(string Usuario)
        {
            RegistroUsuario Registro;
            return Interface.RecuperarUsuario(Usuario, out Registro);
        }
        public bool ValidarEmpleado(int NumeroTrabajador)
        {
            return Interface.ValidarEmpleado(NumeroTrabajador);
        }

        public bool ValidarEmpleadoRegistrado(int Numero)
        {
            return Interface.ValidarEmpleadoRegistrado(Numero);
        }

        public string RecuperarPregunta(int NumeroEmpleado)
        {
            return Interface.RecuperarPregunta(NumeroEmpleado);
        }

        public bool ValidarRespuesta(int Empleado, string Resp)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ValidarRespuesta(Empleado, Resp);
        }
    }
}
