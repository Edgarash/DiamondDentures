using Presentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Laboratorio
{
    public partial class PantallaPedidoFabricar : Control.Pantalla
    {
        InterfaceUsuario Interface;
        Validaciones.Validar valida;
        string Usuario { get; set; }

        public PantallaPedidoFabricar(string User)
        {
            InitializeComponent();
            ActualizarData();
            Usuario = User;
        }
        protected override void btnMouseLeft(object sender, EventArgs e)
        {
            base.btnMouseLeft(sender, e);
        }

        protected override void btnMouseOver(object sender, EventArgs e)
        {
            base.btnMouseOver(sender, e);
        }

        private bool validarCancelacion(DataGridView data, int renglon)
        {
            string estado = "";
            bool stop = false;
            if (data[4, renglon].Value != null)
                estado = data[4, renglon].Value.ToString();
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

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            string usuarioActual = "";
            Interface = new InterfaceUsuario(this);
            usuarioActual = Interface.ObtenerTipoUser(Usuario);
            if (usuarioActual == "Laboratorista")
            {
                int renglon = 0;
                Interface = new InterfaceUsuario(this);
                string valor = "", estado = "", user = "";
                valor = "4";
                user = Usuario;
                if (dtvDatos.CurrentCell?.Value != null)
                {
                    renglon = Convert.ToInt32(dtvDatos.CurrentCell.RowIndex.ToString());
                    estado = dtvDatos[4, renglon].Value.ToString();
                    string id = dtvDatos[0, renglon].Value.ToString();
                    if (dtvDatos[0, renglon].Value != null)
                    {
                        if (!Interface.PedidosPorUserLaboratorio(user, estado))
                        {
                            Interface = new InterfaceUsuario(this);
                            Interface.EstadoProcesar(dtvDatos, valor, id, user);
                            ActualizarData();
                        }

                    }
                }
                else { MessageBox.Show("Pedido invalido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Solo los Laboratoristas pueden tomar un pedido \n Para asignar un pedido ve a Control de pedidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosPedidos(dtvDatos);
            valida = new Validar(this);
            valida.validarData(dtvDatos);
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
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
                    Interface.BusquedaIdPedido(dtvDatos, valor);
                    valida = new Validar(this);
                    valida.validarData(dtvDatos);
                }
                if (rbTipo.Checked)
                {
                    bool a = true;
                    Interface = new InterfaceUsuario(this);
                    if (tbBuscar.Text == "URGENTE")
                    {
                        Interface.BusquedaTipo(dtvDatos, "1");
                        a = false;
                    }
                    if (tbBuscar.Text == "NORMAL")
                    {
                        Interface.BusquedaTipo(dtvDatos, "0");
                        a = false;
                    }
                    if (a)
                    {
                        ActualizarData();
                    }
                    valida = new Validar(this);
                    valida.validarData(dtvDatos);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaMenuLaboratorio pml = new PantallaMenuLaboratorio(Usuario);
            pml.Show();
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida = new Validar(this);
            if (rbPedido.Checked)
            {
                tbBuscar.MaxLength = 10;
            }
            if (rbTipo.Checked)
            {
                valida.ValidaCampoTxb(false, e);
                tbBuscar.MaxLength = 10;
            }

        }

        private void PantallaPedidoFabricar_Load(object sender, EventArgs e)
        {
            dtvDatos.RowCount = 1;
            ActualizarData();
        }

        private void bntNotaTer_Click(object sender, EventArgs e)
        {
            PantallaNotaTerminacion pnt = new PantallaNotaTerminacion();
            Hide();
            pnt.ShowDialog();
            pnt.Close();
            Show();
        }

        /*private bool ajusteDeEstados()
        {
            bool stop = false;
            string estado = "", user = "";
            if (dtvDatos.CurrentCell != null)
            {
                int renglon = Convert.ToInt32(dtvDatos.CurrentCell.RowIndex.ToString());
                if (dtvDatos[4, renglon].Value != null)
                {
                    estado = dtvDatos[4, renglon].Value.ToString();
                    user = dtvDatos[5, renglon].Value.ToString();
                    if (estado == "Cancelado" && user == Usuario)
                    {
                        MessageBox.Show("No se puede poner en proceso un pedido cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        stop = true;
                    }
                    if (estado == "Registrado" && user == Usuario)
                        stop = false;
                    if (estado == "Confirmado" && user == Usuario)
                        stop = false;
                    if (estado == "En Proceso" && user == Usuario)
                    {
                        MessageBox.Show("No se puede poner en proceso un pedido que ya está en proceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        stop = true;
                    }
                    if (estado == "Terminado" && user == Usuario)
                    {
                        MessageBox.Show("No se puede poner en proceso un pedido terminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        stop = true;
                    }
                    if (estado == "Facturado")
                        stop = false;
                    if (estado == "Pagado")
                        stop = false;
                }
            }
            return stop;
        }*/
    }
}
