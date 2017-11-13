using ConexionBaseDeDatos;
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
            InterfaceMySQL.Datos(temp);
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

        #region Modulo Finanzas
        public void DatosDVentas(DataGridView temp, string fech)
        {
            InterfaceMySQL.FinanzasVerVentasGeneradas(temp, fech);
        }
        public void DatosDBuscarVentas(DataGridView temp, string busc, string idp)
        {
            InterfaceMySQL.FinanzasBusquedaVentasGeneradas(temp,busc,idp);
        }
        public void DatosDBalanceCuentasIngresos(DataGridView temp, string fec)
        {
            InterfaceMySQL.FinanzasBalanceCuentasIngresos(temp, fec);
        }
        public void DatosDAgregarBalanceCuentasIngresos(DataGridView temp, string des, string val, string fec)
        {
            InterfaceMySQL.FinanzasAgregaBalanceIngresos(temp,des,val,fec);
        }
        public void DatosDAgregarBalanceCuentasEgresos(DataGridView temp, string des, string val, string fec)
        {
            InterfaceMySQL.FinanzasAgregaBalanceEgresos(temp,des,val, fec);
        }
        public void DatosDBalanceCuentasEgresos(DataGridView temp, string fec)
        {
            InterfaceMySQL.FinanzasBalanceCuentasEgresos(temp, fec);
        }
        public void DatosDTotalVentas(TextBox temp)
        {
            InterfaceMySQL.FinanzasTotalVentas(temp);
        }
        public void DatosDGastos(DataGridView temp, string f)
        {
            InterfaceMySQL.FinanzasVerGastosGenerados(temp, f);
        }
        public void DatosDRegistroPagos(DataGridView temp, string nom, string des, string punit, string cant, string subt,
            string tot, string est, string reg, string fec)
        {
            InterfaceMySQL.FinanzasRegistrarPago(temp, nom, des, punit, cant, subt, tot, est, reg,fec);
        }
        public void DatosDTotalGastos(TextBox temp)
        {
            InterfaceMySQL.FinanzasTotalGastos(temp);
        }
        public void DatosDPagosTrab(DataGridView temp)
        {
            InterfaceMySQL.RHumanosVerPagosTrabajadores(temp);
        }
        public void DatosDTotalPagosTrab(TextBox temp)
        {
            InterfaceMySQL.RHumanosTotalPagoEmp(temp);
        }
        public void DatosComboUsuarios(ComboBox temp)
        {
            InterfaceMySQL.FinanzasObtenerUsuario(temp);
        }
        public void DatosDInsumos(DataGridView temp)
        {
            InterfaceMySQL.FinanzasVerIsumos(temp);
        }
        public void DatosDTotalInsumos(TextBox temp)
        {
            InterfaceMySQL.FinanzasTotalInsumos(temp);
        }
        public void DatosDPagos(DataGridView temp)
        {
            InterfaceMySQL.FinanzasPagos(temp);
        }
        public void DatosDBuscarAdminPagos(DataGridView temp, string idp, string nomb)
        {
            InterfaceMySQL.FinanzasBuscarAdminPagos(temp,idp,nomb);
        }
        public void DatosDTotalIngresos(TextBox temp)
        {
            InterfaceMySQL.FinanzasTotalIngresos(temp);
        }
        public void ComprarInsumos(TextBox txID, TextBox txNomb, TextBox txDesc, TextBox txCant, TextBox txPrUni, string p)
        {
            InterfaceMySQL.FinanzasComprarIsumos(txID, txNomb, txDesc, txCant, txPrUni, p);
        }
        public void AgregarCompra(TextBox txID)
        {
            InterfaceMySQL.FinanzasAgregarCompra(txID);
        }
        public void DatosDEmpleados(DataGridView temp)
        {
            InterfaceMySQL.RHumanosEmpleados(temp);
        }
        public void DatosDAsistencia(DataGridView temp)
        {
            InterfaceMySQL.RHumanosAsistencia(temp);
        }
        public void DatosDNomina(DataGridView temp)
        {
            InterfaceMySQL.RHumanosNomina(temp);
        }
        public void DatosDTotalNomina(TextBox temp)
        {
            InterfaceMySQL.RHumanosTotalNomina(temp);
        }
        public void DatosDAgregarNomina(DataGridView temp, string nemp, string fec, string nomb, string ape, string rfc,
            string mail, string dep, string pues, string dlab, string suel, string isr, string descisr, string sfinal, string pag)
        {
            InterfaceMySQL.RHumanosAgregarNomina(temp, nemp, fec, nomb, ape, rfc, mail, dep, pues, dlab, suel, isr, descisr, sfinal, pag);
        }
        public void DatosDActualizarPago(int temp)
        {
            InterfaceMySQL.FinanzasActualizarEstado(temp);
        }

        #endregion 
    }
}
