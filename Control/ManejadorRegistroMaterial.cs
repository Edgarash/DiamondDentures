using System;
using Entidad;
using ConexionBaseDeDatos;

namespace Control
{
    public class ManejadorRegistroMaterial : Manejador
    {
        public bool RegistrarMaterial(RegistroMaterial Material)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.RegistrarMaterial(Material);
        }

        public RegistroMaterial[] BuscarUnMaterial(RegistroMaterial Material)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.BuscarUnMaterial(Material);
        }

        public RegistroMaterial[] ObtenerMateriales()
        {
            RegistroMaterial[] temp = null;
            InterfaceMySQL.ObtenerMateriales(out temp);
            return temp;
        }

        public RegistroMaterial ObtenerUnMaterial(int clave)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ObtenerUnMaterial(clave);
        }

        public bool ActivarMaterial(int clave)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ActivarMaterial(clave);
        }

        public bool EliminarMaterial(int clave)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.EliminarMaterial(clave);
        }

        public bool ActualizarMaterial(RegistroMaterial material)
        {
            Interface = new InterfaceBaseDeDatos();
            return Interface.ActualizarMaterial(material);
        }
    }
}