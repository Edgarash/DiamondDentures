using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class ManejadorPrincipal : Manejador
    {
        public void DesplegarPantallaRecepcion(Pantalla PantallaRecepcion)
        {
            PantallaRecepcion.Show();
        }

        public void ObtenerUsuarios(DataGridView temp)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.Datos(temp);
        }

        public void ObtenerProductos(DataGridView temp)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.Datos2(temp);
        }

        public void BuscarIdPedido(DataGridView temp, string valor)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.BuscarIdPedido(temp, valor);
        }
        public void BuscarIdDentista(DataGridView temp, string cedula)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.BuscarIdDentista(temp, cedula);
        }
        public void BuscarTipo(DataGridView temp, string valor)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.BuscarTipo(temp, valor);
        }
        public void BusquedaIdPedido(DataGridView temp, string valor)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.BusquedaIdPedido(temp, valor);
        }
        public void BusquedaTipo(DataGridView temp, string valor)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.BusquedaTipo(temp, valor);
        }
        public void CambiarLaboratorista(DataGridView temp, string valor, string a, string id)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.CambiarLaboratorista(temp, valor, a, id);
        }
        public void CambiarEstado(DataGridView temp, string valor, string a, string id)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.CambiarEstado(temp, valor, a, id);
        }
        public void EstadoProcesar(DataGridView temp, string valor, string id,string user)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.EstadoProcesar(temp, valor, id, user);
        }
        public void CancelarPedido(DataGridView temp, string id)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.CancelarPedido(temp, id);
        }
        public void CancelarPieza(DataGridView temp, string id)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.CancelarPieza(temp, id);
        }
        public void ObtenerNombrePieza(DataGridView temp, string id)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.ObtenerNombrePieza(temp, id);
        }
        public void DatosPedidos(DataGridView temp)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.DatosPedidos(temp);
        }
        public void DatosProductos(DataGridView temp)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.DatosProductos(temp);
        }

        public void ObtenerIdPiezas(DataGridView temp)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.ObtenerIdPiezas(temp);
        }
        public string ObtenerTipoUser(string usuario)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            return Interface.ObtenerTipoUser(usuario);
        }
        public void ObtenerUsuariosActivos(ComboBox cbtrabaja)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            Interface.ObtenerUsuariosActivos(cbtrabaja);
        }
        public bool PedidosEnProcesoPorUsuario(string usuario, string estado)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            return Interface.PedidosEnProcesoPorUsuario(usuario, estado);
        }
        public bool PedidosPorUserLaboratorio(string usuario, string estado)
        {
            Interface = new ConexionBaseDeDatos.InterfaceBaseDeDatos();
            return Interface.PedidosPorUserLaboratorio(usuario, estado);
        }
    }
}
