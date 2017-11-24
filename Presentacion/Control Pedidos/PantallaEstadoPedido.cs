using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Control;
using ConexionBaseDeDatos;
using System.Windows.Forms;
using Validaciones;
using Presentacion.Recepcion;
using Entidad;
using Presentacion.Reportes;

namespace Presentacion.Control_Pedidos
{
    public partial class PantallaEstadoPedido : Control.Pantalla
    {
        InterfaceUsuario Interface;
        Validaciones.Validar valida;
        string cestado = "", tipoUsuario = "", clabora = "";
        string Usuario { get; set; }
        public PantallaEstadoPedido(string User)
        {
            InitializeComponent();
            ActualizarData();
            Usuario = User;
            Interface = new InterfaceUsuario(this);
            //tipoUsuario = Interface.ObtenerTipoUser(Usuario);
        }
        protected override void btnMouseLeft(object sender, EventArgs e)
        {
            base.btnMouseLeft(sender, e);
        }
        protected override void btnMouseOver(object sender, EventArgs e)
        {
            base.btnMouseOver(sender, e);
        }
        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            Recepcion.PantallaRegistrarPedido Prp = new Recepcion.PantallaRegistrarPedido();
            Prp.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaModificarPedido(null).GetType()))
            {
                RegistroPedido Pedido = null;
                Interface = new InterfaceUsuario(this);
                bool Cancelado = false;
                if (dtvDatos.CurrentCell != null)
                {
                    Pedido = Interface.ObtenerUnPedido(dtvDatos[0, dtvDatos.CurrentCell.RowIndex]?.Value?.ToString() ?? "-20");
                }
                else
                {
                    PantallaPedirInformación t = new PantallaPedirInformación();
                    Pedido = t.PedirPedido(out Cancelado);
                }
                if (!Cancelado)
                {
                    if (Pedido != null)
                        Interface.DesplegarPantallaModificarPedido(Pedido);
                    else
                        Validar.MensajeErrorOK("Pedido no válido");
                }
            }
        }
        private bool validarCancelacion(DataGridView data, int renglon)
        {
            string estado = "";
            bool stop = false;
            if (data[7, renglon].Value != null)
                estado = data[7, renglon].Value.ToString();
            if (estado == "Cancelado")
            {
                MessageBox.Show("No se puede cancelar un pedido que ya fue cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                stop = true;
            }
            if (estado == "En Proceso")
            {
                MessageBox.Show("No se puede cancelar un pedido que está en proceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                stop = true;
            }
            if (estado == "Terminado")
            {
                MessageBox.Show("No se puede cancelar un pedido terminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                stop = true;
            }
            if (estado == "Facturado")
            {
                MessageBox.Show("No se puede cancelar un pedido facturado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                stop = true;
            }
            return stop;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int renglon = 0;
            string id = "";
            if (dtvDatos.CurrentCell != null)
            {
                renglon = Convert.ToInt32(dtvDatos.CurrentCell.RowIndex.ToString());
                if (dtvDatos[0, renglon].Value != null)
                {
                    id = dtvDatos[0, renglon].Value.ToString();
                    if (validarCancelacion(dtvDatos, renglon)) { }
                    else
                    {
                        if (MessageBox.Show("Desea cancelar el pedido " + id.ToString(), "Cancelar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        == DialogResult.Yes)
                        {

                            Interface = new InterfaceUsuario(this);
                            Interface.CancelarPedido(dtvDatos, id.ToString());
                            MessageBox.Show("Pedido cancelado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                            ActualizarData();
                        }
                    }
                }
            }
            else { MessageBox.Show("Pedido invalido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            Interface.ObtenerProductos(dtvDatos);
            valida = new Validar(this);
            valida.validarData(dtvDatos);
        }
        private void ActualizarData8()
        {
            Interface = new InterfaceUsuario(this);
            Interface.CPObtenerLaboratoristas(cbLabora);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valor = tbBuscar.Text;
            if (tbBuscar.Text == "")
            {
                ActualizarData();
            }
            else
            {
                if (rbPedido.Checked)
                {
                    Interface = new InterfaceUsuario(this);
                    Interface.BuscarIdPedido(dtvDatos, valor);
                    valida = new Validar(this);
                    valida.validarData(dtvDatos);
                }
                if (rbDentista.Checked)
                {
                    Interface = new InterfaceUsuario(this);
                    Interface.BuscarIdDentista(dtvDatos, valor);
                    valida = new Validar(this);
                    valida.validarData(dtvDatos);
                }
                if (rbTipo.Checked)
                {
                    bool a = true;
                    Interface = new InterfaceUsuario(this);
                    if (tbBuscar.Text == "URGENTE")
                    {
                        Interface.BuscarTipo(dtvDatos, "1");
                        a = false;
                    }
                    if (tbBuscar.Text == "NORMAL")
                    {
                        Interface.BuscarTipo(dtvDatos, "0");
                        a = false;
                    }
                    if (a)
                    {
                        ActualizarData();
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Laboratorio.PantallaMenuLaboratorio pml = new Laboratorio.PantallaMenuLaboratorio();
            this.Hide();
            pml.ShowDialog();

        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaMenuControlPedidos pmp = new PantallaMenuControlPedidos(Usuario);
            pmp.Show();
        }
        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            int renglon = Convert.ToInt32(dtvDatos.CurrentCell.RowIndex.ToString());
            string valor = "";
            string id = dtvDatos[0, renglon].Value.ToString();
            valor = cbEstado.SelectedItem.ToString();
            if (valor == cestado) { }
            else
            {
                if (valor == "Cancelado")
                    valor = "0";
                else
                {
                    if (valor == "Registrado")
                        valor = "1";
                    else
                    {
                        if (valor == "Confirmado")
                            valor = "2";
                        else
                        {
                            if (valor == "Asignado")
                                valor = "3";
                            else
                            {
                                if (valor == "En Proceso")
                                    valor = "4";
                                else
                                {
                                    if (valor == "Terminado")
                                        valor = "5";
                                    else
                                    {
                                        if (valor == "Facturado")
                                            valor = "6";
                                        else
                                            if (valor == "Pagado")
                                            valor = "7";
                                    }
                                }
                            }
                        }
                    }
                }

                if (cestado == "Cancelado")
                    cestado = "0";
                else
                {
                    if (cestado == "Registrado")
                        cestado = "1";
                    else
                    {
                        if (cestado == "Confirmado")
                            cestado = "2";
                        else
                        {
                            if (cestado == "Asignado")
                                cestado = "3";
                            else
                            {
                                if (cestado == "En Proceso")
                                    cestado = "4";
                                else
                                {
                                    if (cestado == "Terminado")
                                        cestado = "5";
                                    else
                                    {
                                        if (cestado == "Facturado")
                                            cestado = "6";
                                        else
                                            if (cestado == "Pagado")
                                            cestado = "7";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Interface = new InterfaceUsuario(this);
            //Interface.CambiarEstado(dtvDatos, valor, cestado, id);
            ActualizarData();
        }
        private void PantallaEstadoPedido_Load(object sender, EventArgs e)
        {
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLabora.DropDownStyle = ComboBoxStyle.DropDownList;
            lblTrabaja.Visible = true;
            cbLabora.Visible = true;
            //Interface = new InterfaceUsuario(this);
            //Interface.ObtenerUsuariosActivos(cbLabora);
            //dtvDatos.RowCount = 1;
            ActualizarData();
            ActualizarData8();
            lblUsuario.Text = "Usuario: " + Usuario + " (" + tipoUsuario + ")";
            //if (dtvDatos.CurrentCell != null)
            //{
            //    int renglon = Convert.ToInt32(dtvDatos.CurrentCell.RowIndex.ToString());
            //    if (dtvDatos[7, renglon].Value != null)
            //        cestado = dtvDatos[7, renglon].Value.ToString();
            //}
            //if (dtvDatos.CurrentCell != null)
            //{
            //    int renglon = Convert.ToInt32(dtvDatos.CurrentCell.RowIndex.ToString());
            //    if (dtvDatos[8, renglon].Value != null)
            //        clabora = dtvDatos[8, renglon].Value.ToString();
            //}
            if (tipoUsuario == "Empleado")
            {
                btnLabor.Visible = false;
                lblLabora.Visible = false;
                btnModificarPedido.Visible = true;
                lblModificarPedido.Visible = true;
                btnNuevoPedido.Visible = true;
                lblNuevoPedido.Visible = true;
                btnCancelarPedido.Visible = true;
                lblCancelarPedido.Visible = true;
                lblTrabaja.Visible = false;
                cbLabora.Visible = false;
            }
            else if (tipoUsuario == "Contador")
            {
                btnLabor.Visible = false;
                lblLabora.Visible = false;
                btnModificarPedido.Visible = false;
                lblModificarPedido.Visible = false;
                btnNuevoPedido.Visible = false;
                lblNuevoPedido.Visible = false;
                btnCancelarPedido.Visible = false;
                lblCancelarPedido.Visible = false;
                lblTrabaja.Visible = false;
                cbLabora.Visible = false;
            }
            else if (tipoUsuario == "Laboratorista")
            {
                btnModificarPedido.Visible = false;
                lblModificarPedido.Visible = false;
                btnNuevoPedido.Visible = false;
                lblNuevoPedido.Visible = false;
                btnCancelarPedido.Visible = true;
                lblCancelarPedido.Visible = true;
                btnLabor.Visible = true;
                lblLabora.Visible = true;
                lblTrabaja.Visible = false;
                cbLabora.Visible = false;
            }
            else if (tipoUsuario == "Jefe Laboratorio")
            {
                btnModificarPedido.Visible = true;
                lblModificarPedido.Visible = true;
                btnNuevoPedido.Visible = true;
                lblNuevoPedido.Visible = true;
                btnCancelarPedido.Visible = true;
                lblCancelarPedido.Visible = true;
                btnLabor.Visible = true;
                lblLabora.Visible = true;
            }
            else if (tipoUsuario == "Administrador")
            {
                btnModificarPedido.Visible = true;
                lblModificarPedido.Visible = true;
                btnNuevoPedido.Visible = true;
                lblNuevoPedido.Visible = true;
                btnCancelarPedido.Visible = true;
                lblCancelarPedido.Visible = true;
                btnLabor.Visible = true;
                lblLabora.Visible = true;
            }
        }
        private void dtvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLabora.DropDownStyle = ComboBoxStyle.DropDownList;
            //if (dtvDatos.CurrentCell != null)
            //{
            //    int renglon = Convert.ToInt32(dtvDatos.CurrentCell.RowIndex.ToString());
            //    if (dtvDatos[7, renglon].Value != null)
            //        cestado = dtvDatos[7, renglon].Value.ToString();
            //    ajusteDeEstados(cbEstado);
            //}
            //if (dtvDatos.CurrentCell != null)
            //{
            //    int renglon = Convert.ToInt32(dtvDatos.CurrentCell.RowIndex.ToString());
            //    if (dtvDatos[8, renglon].Value != null)
            //        clabora = dtvDatos[8, renglon].Value.ToString();
            //}
        }
        private void ajusteDeEstados(ComboBox cb)
        {
            string estado = "";
            if (dtvDatos.CurrentCell != null)
            {
                int renglon = Convert.ToInt32(dtvDatos.CurrentCell.RowIndex.ToString());
                if (dtvDatos[7, renglon].Value != null)
                {
                    estado = dtvDatos[7, renglon].Value.ToString();
                    if (estado == "Cancelado") { cb.Items.Clear(); }
                    if (estado == "Registrado")
                    {
                        cb.Items.Clear();
                        cb.Items.Add("Cancelado");
                        cb.Items.Add("Confirmado");
                        cb.Items.Add("En Proceso");
                        cb.Items.Add("Facturado");
                        cb.Items.Add("Pagado");
                    }
                    if (estado == "Confirmado")
                    {
                        cb.Items.Clear();
                        cb.Items.Add("Cancelado");
                        cb.Items.Add("En Proceso");
                        cb.Items.Add("Facturado");
                        cb.Items.Add("Pagado");
                    }
                    if (estado == "En Proceso")
                    {
                        cb.Items.Clear();
                        cb.Items.Add("Terminado");
                        cb.Items.Add("Facturado");
                        cb.Items.Add("Pagado");
                    }
                    if (estado == "Terminado")
                    {
                        cb.Items.Clear();
                        cb.Items.Add("Facturado");
                        cb.Items.Add("Pagado");
                    }
                    if (estado == "Facturado")
                    {
                        cb.Items.Clear();
                        cb.Items.Add("Terminado");
                        cb.Items.Add("Pagado");
                    }
                    if (estado == "Pagado")
                    {
                        cb.Items.Clear();
                        cb.Items.Add("Terminado");
                    }
                }
            }
        }
        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida = new Validar(this);
            if (rbPedido.Checked)
            {
                tbBuscar.MaxLength = 10;
            }
            if (rbDentista.Checked)
            {
                valida.ValidaCampoTxb(true, e);
                tbBuscar.MaxLength = 10;
            }
            if (rbTipo.Checked)
            {
                valida.ValidaCampoTxb(false, e);
                tbBuscar.MaxLength = 10;
            }
        }
        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            if (dtvDatos.CurrentRow?.Cells["Estatus"].Value.ToString() == "Cancelado")
            {
                MessageBox.Show("El pedido ha sido cancelado", "Pedido sin pagar", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (dtvDatos.CurrentRow?.Cells["Estatus"].Value.ToString() != "Pagado" && dtvDatos.CurrentRow?.Cells["Estatus"].Value.ToString() != "Facturado")
            {
                MessageBox.Show("El pedido no se ha pagado", "Pedido sin pagar", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string clave = dtvDatos.CurrentRow?.Cells["Clave"].Value.ToString();
            PantallaCrearFactura pcf = new PantallaCrearFactura(clave);
            Hide();
            pcf.ShowDialog();
            pcf.Close();
            Show();
        }
        private void btnConfirmacion_Click(object sender, EventArgs e)
        {
            if (dtvDatos.CurrentRow?.Cells["Estatus"].Value.ToString() == "Cancelado")
                return;

            string clave = dtvDatos.CurrentRow?.Cells["Clave"].Value.ToString();
            PantallaOficioConfirmacion poc = new PantallaOficioConfirmacion(clave);
            Hide();
            poc.ShowDialog();
            poc.Close();
            Show();
        }
        private void btnTerminacion_Click(object sender, EventArgs e)
        {
            if (dtvDatos.CurrentRow?.Cells["Estatus"].Value.ToString() == "Cancelado")
                return;

            string clave = dtvDatos.CurrentRow?.Cells["Clave"].Value.ToString();
            PantallaNotaTerminacion pnt = new PantallaNotaTerminacion(clave);
            Hide();
            pnt.ShowDialog();
            pnt.Close();
            Show();
        }
        private void btnFormaPedido_Click(object sender, EventArgs e)
        {
            if (dtvDatos.CurrentRow?.Cells["Estatus"].Value.ToString() == "Cancelado")
                return;

            string clave = dtvDatos.CurrentRow?.Cells["Clave"].Value.ToString();
            PantallaFormaPedido pfp = new PantallaFormaPedido(clave);
            Hide();
            pfp.ShowDialog();
            pfp.Close();
            Show();
        }

        private void cbTrabaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLabora.DropDownStyle = ComboBoxStyle.DropDownList;
            Interface = new InterfaceUsuario(this);
            int renglon = Convert.ToInt32(dtvDatos.CurrentCell.RowIndex.ToString());
            string labora = "", estado = "", nuevo = "";
            string id = dtvDatos[0, renglon].Value.ToString();
            nuevo = cbLabora.SelectedItem.ToString();
            estado = dtvDatos[6, renglon].Value.ToString();
            labora = dtvDatos[7, renglon].Value.ToString();
            if (labora != cbLabora.SelectedText.ToString())
            {
                Interface.CambiarLaboratorista(dtvDatos, nuevo, id);
                ActualizarData();
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            PantallaGenerarRVentas pgrv = new PantallaGenerarRVentas();
            Hide();
            pgrv.ShowDialog();
            pgrv.Close();
            Show();
        }

    }
}
