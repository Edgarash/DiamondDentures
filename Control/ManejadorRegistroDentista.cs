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
            Interface = new InterfaceBaseDeDatos();
            return Interface.RegistrarDentista(Dentista);
        }

        public RegistroDentista ObtenerUnDentista(string Cedula)
        {
            RegistroDentista Dentista;
            InterfaceMySQL.RecuperarDentista(Cedula, out Dentista);
            return Dentista;
        }

        public bool ActualizarDentista(RegistroDentista Dentista)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ActualizarDentista(Dentista);
        }
    }
}
