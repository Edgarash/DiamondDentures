using Control;
using Entidad;
using Presentacion.Configuracion;
using Presentacion.Control_Pedidos;
using Presentacion.Laboratorio;
using Presentacion.Login;
using Presentacion.Recepcion;
using System;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion
{
    public partial class PantallaMenuPrincipal : Pantalla
    {
        PantallaLogin Pantalla;
        string Usuario;
        InterfaceUsuario Interface;
        string TipoUsuario { get; set; }

        public PantallaMenuPrincipal(string Login, PantallaLogin Pantalla)
        {
            Interface = new InterfaceUsuario(this);
            RegistroUsuario temp;
            Interface.RecuperarUsuario(Login, out temp);
            PantallaLogin.Sesión = temp;
            InitializeComponent();
            InitializeComponent2();
            InitializeComponent3();
            Usuario = Login;
            TipoUsuario = temp?.Departamento;
            this.Pantalla = Pantalla;
            lblSesión.Text = "Usuario: " + Usuario + " (" + temp?.Departamento + ")";
            MouseEnter += PantallaMenuPrincipal_GotFocus;
        }

        private void PantallaMenuPrincipal_GotFocus(object sender, EventArgs e)
        {
            bool Cambió = false;
            lblSesión.Text = "Usuario: " + Usuario + " (" + TipoUsuario + ")";
            Cambió = TipoUsuario != PantallaLogin.Sesión?.Departamento;
            if (Cambió)
                InitializeComponent3();
        }

        private void InitializeComponent3()
        {
            InitializeComponent4();
            switch (PantallaLogin.Sesión?.Departamento)
            {
                case "Empleado":
                    btnControlPedidos.Location = new System.Drawing.Point(253, 142);
                    lblConfiguración.Visible = btnConfiguracion.Visible = false;
                    lblControlPedidos.Location = new System.Drawing.Point(269, 276);
                    lblLaboratorio.Visible = btnLaboratorio.Visible = false;
                    btnSemáforo.Location = new System.Drawing.Point(253, 310);
                    lblSemáforo.Location = new System.Drawing.Point((btnSemáforo.Location.X + btnSemáforo.Width / 2) - lblSemáforo.Width / 2, 444);
                    break;
                case "Laboratorista":
                    btnLaboratorio.Location = new System.Drawing.Point(62, 142);
                    lblLaboratorio.Location = new System.Drawing.Point((btnLaboratorio.Location.X + btnLaboratorio.Width / 2) - lblLaboratorio.Width / 2, 276);
                    btnRecepcion.Visible = lblRecepcion.Visible = false;
                    btnSemáforo.Location = new System.Drawing.Point(253, 142);
                    lblSemáforo.Location = new System.Drawing.Point((btnSemáforo.Location.X + btnSemáforo.Width / 2) - lblSemáforo.Width / 2, 276);
                    btnConfiguracion.Visible = lblConfiguración.Visible = false;
                    break;
                case "Jefe Laboratorio":
                    btnLaboratorio.Location = new System.Drawing.Point(62, 142);
                    lblLaboratorio.Location = new System.Drawing.Point((btnLaboratorio.Location.X + btnLaboratorio.Width / 2) - lblLaboratorio.Width / 2, 276);
                    btnRecepcion.Visible = lblRecepcion.Visible = false;
                    btnSemáforo.Location = new System.Drawing.Point(253, 142);
                    lblSemáforo.Location = new System.Drawing.Point((btnSemáforo.Location.X + btnSemáforo.Width / 2) - lblSemáforo.Width / 2, 276);
                    btnControlPedidos.Location = new System.Drawing.Point(btnControlPedidos.Location.X+110, btnControlPedidos.Location.Y);
                    lblControlPedidos.Location = new System.Drawing.Point((btnControlPedidos.Location.X + btnControlPedidos.Width / 2) - lblControlPedidos.Width / 2, 444);
                    btnConfiguracion.Location = new System.Drawing.Point(btnConfiguracion.Location.X - 110, 310);
                    lblConfiguración.Location = new System.Drawing.Point((btnConfiguracion.Location.X + btnConfiguracion.Width / 2) - lblConfiguración.Width / 2, 444);
                    break;
                case "Contador":
                    btnConfiguracion.Visible = lblConfiguración.Visible = false;
                    btnLaboratorio.Visible = lblLaboratorio.Visible = false;
                    btnRecepcion.Visible = lblRecepcion.Visible = false;
                    btnSemáforo.Location = new System.Drawing.Point(253, 142);
                    lblSemáforo.Location = new System.Drawing.Point((btnSemáforo.Location.X + btnSemáforo.Width / 2) - lblSemáforo.Width / 2, 276);
                    btnControlPedidos.Location = new System.Drawing.Point(62, 142);
                    lblControlPedidos.Location = new System.Drawing.Point((btnControlPedidos.Location.X + btnControlPedidos.Width / 2) - lblControlPedidos.Width / 2, 276);
                    Size = new System.Drawing.Size(642, 388);
                    lblSesión.Location = new System.Drawing.Point(12, 324);
                    break;
            }
            TipoUsuario = PantallaLogin.Sesión?.Departamento;
        }

        private void InitializeComponent4()
        {
            btnRecepcion.Visible = btnConfiguracion.Visible = btnUsuario.Visible = true;
            lblRecepcion.Visible = lblConfiguración.Visible = lblUsuario.Visible = true;
            btnSemáforo.Visible = btnControlPedidos.Visible = btnLaboratorio.Visible = true;
            lblSemáforo.Visible = lblControlPedidos.Visible = lblLaboratorio.Visible = true;

            this.Size = new System.Drawing.Size(642, 559);

            this.lblUsuario.Location = new System.Drawing.Point(472, 276);
            this.btnRecepcion.Location = new System.Drawing.Point(62, 142);
            this.btnConfiguracion.Location = new System.Drawing.Point(253, 142);
            this.lblRecepcion.Location = new System.Drawing.Point(79, 276);
            this.lblConfiguración.Location = new System.Drawing.Point(258, 276);
            this.btnUsuario.Location = new System.Drawing.Point(444, 142);
            this.lblUsuario.Location = new System.Drawing.Point(472, 276);
            this.lblSesión.Location = new System.Drawing.Point(12, 493);
            this.btnSemáforo.Location = new System.Drawing.Point(62, 310);
            this.btnControlPedidos.Location = new System.Drawing.Point(253, 310);
            this.btnLaboratorio.Location = new System.Drawing.Point(444, 310);
            this.lblControlPedidos.Location = new System.Drawing.Point(269, 444);
            this.lblLaboratorio.Location = new System.Drawing.Point(457, 444);
            this.lblSemáforo.Location = new System.Drawing.Point(83, 444);
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaRecepcion("").GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaRecepcion(Usuario);
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new Presentacion.Usuario.PantallaMenuUsuario("").GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaMenuUsuario(Usuario);
            }
        }

        private void PantallaMenuPrincipal_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaConfiguracion("").GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaConfiguracion(Usuario);
            }
        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaMenuLaboratorio(null).GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaLaboratorio(Usuario);
            }
        }

        private void btnControlPedidos_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaMenuControlPedidos(null).GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaControlPedidos(Usuario);
            }
        }

        private void btnSemáforo_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaEstadoPedido(Usuario).GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaEstadoPedido(Usuario);
            }
        }
    }
}
