using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presentacion;
using Control;
using Validaciones;
using Presentacion.Login;
using Entidad;
using Presentacion.Recepcion;
using Presentacion.Reportes;

namespace Presentacion.Control_Pedidos
{
    public partial class PantallaMenuControlPedidos : Control.Pantalla
    {
        InterfaceUsuario Interface { get; set; }
        string Usuario { get; set; }
        string tipoUsuario = "";

        string TipoUsuario { get; set; }
        public PantallaMenuControlPedidos(string User)
        {
            InitializeComponent();
            this.Usuario = User;
            Interface = new InterfaceUsuario(this);
            tipoUsuario = Interface.ObtenerTipoUser(Usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaRegistrarPedido(null).GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaRegistrarPedido(Usuario);
            }
        }

        protected override void btnMouseLeft(object sender, EventArgs e)
        {
            base.btnMouseLeft(sender, e);
        }

        protected override void btnMouseOver(object sender, EventArgs e)
        {
            base.btnMouseOver(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            this.Close();
        }

        private void btnEstadoPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaEstadoPedido Pre = new PantallaEstadoPedido(Usuario);
            Pre.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaModificarPedido(null).GetType()))
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaCancelarPedido Ppc = new PantallaCancelarPedido();
            Ppc.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratorio.PantallaMenuLaboratorio lab = new Laboratorio.PantallaMenuLaboratorio(Usuario);
            lab.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Hide();
            PantallaMenuReportes pmr = new PantallaMenuReportes();
            pmr.ShowDialog();
            Show();
        }

        private void PantallaMenuControlPedidos_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: " + Usuario + " (" + tipoUsuario + ")";
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
    }
}
