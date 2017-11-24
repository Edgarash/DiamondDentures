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

        public static bool ActualizarDentista(RegistroDentista Dentista)
        {
            return InterfaceMySQL.ActualizarDentista(Dentista);
        }

        public static bool ObtenerDentistas(out RegistroDentista[] Dentistas)
        {
            return InterfaceMySQL.ObtenerDentistas(out Dentistas);
        }

        public static bool EliminarDentista(string Cedula)
        {
            return InterfaceMySQL.EliminarDentista(Cedula);
        }
    }
}
