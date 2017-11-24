using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using ConexionBaseDeDatos;

namespace Control
{
    public class ManejadorRegistroDentista : Manejador
    {
        public bool RegistrarDentista(RegistroDentista Dentista)
        {
            return InterfaceMySQL.RegistrarDentista(Dentista);
        }

        public static bool ObtenerUnDentista(string Cedula, out RegistroDentista Dentista)
        {
            return InterfaceMySQL.RecuperarDentista(Cedula, out Dentista);
        }

        public bool ActualizarDentista(RegistroDentista Dentista)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ActualizarDentista(Dentista);
        }
    }
}
