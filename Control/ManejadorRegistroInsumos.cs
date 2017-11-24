using System;
using Entidad;
using ConexionBaseDeDatos;

namespace Control
{
    public class ManejadorRegistroInsumos : Manejador
    {
        public RegistroInsumos[] ObtenerInsumos3()
        {
            RegistroInsumos[] temp = null;
            InterfaceMySQL.ObtenerInsumos3(out temp);
            return temp;
        }
        public CompraInsumos[] DetallesInsumos(int IDCompra)
        {
            CompraInsumos[] temp = null;
            InterfaceMySQL.DetallesInsumos(IDCompra, out temp);
            return temp;
        }
    }
}
