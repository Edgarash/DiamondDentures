using Control;
using Entidad;
using Presentacion.Control_Pedidos;
using Presentacion.Reportes;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Recepcion
{
    public partial class PantallaRecepcion : Pantalla
    {
        public InterfaceUsuario Interface { get; private set; }

        public PantallaRecepcion()
        {
            InitializeComponent();
            InitializeComponent2();
        }

        private void btnAgregarPedido_Click(object sender, System.EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaRegistrarPedido)))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaRegistrarPedido();
            }
        }

        private void btnModificarPedido_Click(object sender, System.EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaModificarPedido)))
            {
                Interface = new InterfaceUsuario(this);
                PantallaPedirInformación temp = new PantallaPedirInformación();
                bool Cancelado = true;
                RegistroPedido Pedido = temp.PedirPedido(out Cancelado);
                if (!Cancelado)
                {
                    if (Pedido != null)
                        Interface.DesplegarPantallaModificarPedido(Pedido);
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("El número de pedido ingresado no existe\n\n¿Desea ver una lista de pedidos existentes?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                        {
                            if (!Validar.ValidarUnaPantalla(typeof(PantallaMenuControlPedidos)))
                            {
                                Interface.DesplegarPantallaControlPedidos(PantallaMenuPrincipal.Sesion.Login);
                            }
                        }
                    }
                }
            }
        }

        private void btnGenerarOrden_Click(object sender, System.EventArgs e)
        {
            PantallaOficioConfirmacion poc = new PantallaOficioConfirmacion();
            poc.ShowDialog();
        }

        private void btnAgregarDentista_Click(object sender, System.EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaAgregarDentista)))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaAgregarDentista();
            }
        }

        private void btnModificarDentista_Click(object sender, System.EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaModificarDentista)))
            {
                Interface = new InterfaceUsuario(this);
                PantallaPedirInformación temp = new PantallaPedirInformación();
                bool Cancelado = true;
                RegistroDentista Dentista = temp.PedirDentista(out Cancelado);
                if (!Cancelado)
                {
                    if (Dentista != null)
                        Interface.DesplegarPantallaModificarDentista(Dentista);
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("El número de dentista ingresado no existe", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                        {
                            btnAdministrarDentistas.PerformClick();
                        }
                    }
                }
            }
        }

        private void btnAdministrarDentistas_Click(object sender, System.EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaAdministrarDentistas)))
            {
                Interface = new InterfaceUsuario(this);
                PantallaAdministrarDentistas temp = new PantallaAdministrarDentistas();
                Hide();
                temp.ShowDialog();
                Show();
            }
        }
    }
}
