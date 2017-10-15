using System;
using ConexionBaseDeDatos;
using Entidad;

namespace Control
{
    public sealed class ManejadorRegistroUsuario : Manejador
    {
        public ManejadorRegistroUsuario()
        {
        }
        public bool RegistrarUsuario(RegistroUsuario Usuario)
        {
            return InterfaceMySQL.RegistroUsuario(Usuario);
        }
        public bool ActualizarUsuario(string User, RegistroUsuario Usuario)
        {
            return InterfaceMySQL.ActualizarUsuario(User, Usuario);
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
            return InterfaceMySQL.RecuperarUsuario(Usuario, out Registro);
        }
        public bool ValidarEmpleado(int NumeroTrabajador)
        {
            return InterfaceMySQL.ValidarEmpleado(NumeroTrabajador);
        }

        public bool ValidarEmpleadoRegistrado(int Numero)
        {
            return InterfaceMySQL.ValidarEmpleadoRegistrado(Numero);
        }

        public string RecuperarPregunta(int NumeroEmpleado)
        {
            return InterfaceMySQL.RecuperarPregunta(NumeroEmpleado);
        }

        public bool ValidarRespuesta(int Empleado, string Resp)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ValidarRespuesta(Empleado, Resp);
        }

        public bool RecuperarUsuarioN(int Empleado, out RegistroUsuario User)
        {
            return InterfaceMySQL.RecuperarUsuarioN(Empleado, out User);
        }
    }
}
