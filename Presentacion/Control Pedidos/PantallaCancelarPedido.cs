using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Validaciones;
using System.Windows.Forms;

namespace Presentacion.Control_Pedidos
{
    public partial class PantallaCancelarPedido : Control.Pantalla
    {
        InterfaceUsuario Interface;
        Validaciones.Validar valida;
        string Usuario { get; set; }
        public PantallaCancelarPedido()
        {
            InitializeComponent();
            ActualizarData();
        }
        protected override void btnMouseLeft(object sender, EventArgs e)
        {
            base.btnMouseLeft(sender, e);
        }

        protected override void btnMouseOver(object sender, EventArgs e)
        {
            base.btnMouseOver(sender, e);
        }

        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            Interface.ObtenerProductos(dtvDatos2);
            valida = new Validar(this);
            valida.validarData(dtvDatos2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int renglon = 0;
            string id = "";
            if (dtvDatos2.CurrentCell != null)
            {
                renglon = Convert.ToInt32(dtvDatos2.CurrentCell.RowIndex.ToString());
                if (dtvDatos2[0, renglon].Value != null)
                {
                    id = dtvDatos2[0, renglon].Value.ToString();
                    if (validarCancelacion(dtvDatos2, renglon)) { }
                    else
                    {
                        if (MessageBox.Show("Desea cancelar el pedido " + id.ToString(), "Cancelar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        == DialogResult.Yes)
                        {

                            Interface = new InterfaceUsuario(this);
                            Interface.CancelarPedido(dtvDatos2, id.ToString());
                            MessageBox.Show("Pedido cancelado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                            ActualizarData();
                        }
                    }
                }
            }
            else { MessageBox.Show("Pedido invalido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool validarCancelacion(DataGridView data, int renglon)
        {
            string estado = "";
            bool stop = false;          
            if (data[7, renglon].Value != null)
                estado = data[7, renglon].Value.ToString();
            if (estado == "Cancelado") {
                MessageBox.Show("No se puede cancelar un pedido que ya fue cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                stop = true; }
            if (estado == "En Proceso") { 
                MessageBox.Show("No se puede cancelar un pedido que está en proceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                stop = true; }
            if (estado == "Terminado") { 
                MessageBox.Show("No se puede cancelar un pedido terminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                stop = true; }
            if (estado == "Facturado") { 
                MessageBox.Show("No se puede cancelar un pedido facturado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                stop = true; }
            return stop;
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
                    Interface.BuscarIdPedido(dtvDatos2, valor);
                    valida = new Validar(this);
                    valida.validarData(dtvDatos2);
                }
                if (rbDentista.Checked)
                {
                    Interface = new InterfaceUsuario(this);
                    Interface.BuscarIdDentista(dtvDatos2, valor);
                    valida = new Validar(this);
                    valida.validarData(dtvDatos2);
                }
                if (rbTipo.Checked)
                {
                    bool a = true;
                    Interface = new InterfaceUsuario(this);
                    if (tbBuscar.Text == "URGENTE")
                    {
                        Interface.BuscarTipo(dtvDatos2, "1");
                        a = false;
                    }
                    if (tbBuscar.Text == "NORMAL")
                    {
                        Interface.BuscarTipo(dtvDatos2, "0");
                        a = false;
                    }
                    if (a)
                    {
                        ActualizarData();
                    }
                }
            }
        }
        

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaMenuControlPedidos pep = new PantallaMenuControlPedidos(Usuario);
            pep.Show();
        }

        private void PantallaCancelarPedido_Load(object sender, EventArgs e)
        {
            valida = new Validar(this);
            dtvDatos2.RowCount = 1;
            valida.validarData(dtvDatos2);
            ActualizarData();
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
    }
}
