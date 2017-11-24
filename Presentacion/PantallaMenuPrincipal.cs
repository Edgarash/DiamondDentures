using Control;
using Entidad;
using Presentacion.Configuracion;
using Presentacion.Control_Pedidos;
using Presentacion.Laboratorio;
using Presentacion.Login;
using Presentacion.Recepcion;
using Presentacion.Usuario;
using Presentacion.Ventas;
using System;
using System.Windows.Forms;
using Presentacion.Reportes;
using Validaciones;

namespace Presentacion
{
    public partial class PantallaMenuPrincipal : Pantalla
    {
        PantallaLogin Pantalla;
        public static RegistroUsuario Sesion;
        InterfaceUsuario Interface;

        public PantallaMenuPrincipal(string Login, PantallaLogin Pantalla)
        {
            Interface = new InterfaceUsuario(this);
            RegistroUsuario temp;
            Interface.RecuperarUsuario(Login, out temp);
            PantallaLogin.Sesión = temp;
            InitializeComponent();
            InitializeComponent2();
            InitializeComponent3();
            Interface.RecuperarUsuario(Login, out Sesion);
            this.Pantalla = Pantalla;
            lblSesión.Text = "Usuario: " + Sesion?.Nombre + " (" + Sesion?.Departamento + ")";
            MouseEnter += PantallaMenuPrincipal_GotFocus;
        }

        private void PantallaMenuPrincipal_GotFocus(object sender, EventArgs e)
        {
            bool Cambió = false;
            lblSesión.Text = "Usuario: " + Sesion?.Login + " (" + Sesion?.Departamento + ")";
            Cambió = Sesion?.Departamento != PantallaLogin.Sesión?.Departamento;
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
            if (!Validar.ValidarUnaPantalla(typeof(PantallaRecepcion)))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaRecepcion();
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaMenuUsuario)))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaMenuUsuario();
            }
        }

        private void PantallaMenuPrincipal_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaConfiguracion)))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaConfiguracion();
            }
        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaMenuLaboratorio)))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaLaboratorio(PantallaMenuPrincipal.Sesion.Login);
            }
        }

        private void btnControlPedidos_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaMenuControlPedidos)))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaControlPedidos(PantallaMenuPrincipal.Sesion.Login);
            }
        }

        private void btnSemáforo_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaEstadoPedido)))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaEstadoPedido(PantallaMenuPrincipal.Sesion.Login);
            }
        }

        private void kuroButton1_Click(object sender, EventArgs e)
        {
            Hide();
            new PantallaVentas().ShowDialog(this);
            Show();
        }

        private void kuroButton2_Click(object sender, EventArgs e)
        {
            Almacen_y_Proveedores.Menu abrir = new Almacen_y_Proveedores.Menu();
            abrir.Show();
        }

        private void kuroButton3_Click(object sender, EventArgs e)
        {
            Finanzas.FinanzasMenu fm = new Finanzas.FinanzasMenu();
            fm.Show();
        }

        private void kuroButton4_Click(object sender, EventArgs e)
        {
            Recursos_Humanos.RHumanosMenu rhm = new Recursos_Humanos.RHumanosMenu();
            rhm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ManejadorReportes.MostrarPantalla(this, new PantallaMenuReportes());
        }
    }
}
