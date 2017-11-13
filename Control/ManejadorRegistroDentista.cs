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
            Interface = new InterfaceBaseDeDatos();
            return Interface.ObtenerUnDentista(Cedula);
        }

        public bool ActualizarDentista(RegistroDentista Dentista)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ActualizarDentista(Dentista);
        }
    }
}
