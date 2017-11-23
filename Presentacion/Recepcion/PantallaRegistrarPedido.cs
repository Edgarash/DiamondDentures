using Entidad;
using System.Drawing;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Recepcion
{
    public partial class PantallaRegistrarPedido : Presentacion.Recepcion.PantallaPedido
    {
        public PantallaRegistrarPedido()
        {
            InitializeComponent();
            InitializeComponent2();
            InitializeComponent3();
            lblUsuario.Text = PantallaMenuPrincipal.Sesion.Nombre;
        }

        protected override void InitializeComponent3()
        {
            base.InitializeComponent3();
            ActualizarFecha = true;
        }

        private void btnRegistrar_Click(object sender, System.EventArgs e)
        {
            if (!FaltanCampos)
            {
                Interface = new InterfaceUsuario(this);
                RegistroPedido temp = ObtenerPedido, Encontrado = Interface.ObtenerUnPedido(tbClave.Text);
                if (Interface.RegistrarPedido(temp) && (Encontrado?.IDPedido ?? "") != temp.IDPedido)
                {
                    MessageBox.Show("Pedido registrado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    if ((Encontrado?.IDPedido ?? "") == temp.IDPedido)
                        Validar.MensajeErrorOK("Clave de pedido registrada anteriormente favor de cambiarla");
                    else
                        Validar.MensajeErrorBaseDeDatos();
                }
            }
        }
    }
}
