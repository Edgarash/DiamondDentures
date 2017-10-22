using ControlesM;
using Entidad;
using Presentacion.Recepcion;
using System;
using System.Windows.Forms;

namespace Presentacion.Ventas
{
    public partial class PantallaVentas : KuroForm
    {
        public PantallaVentas()
        {
            InitializeComponent();
        }

        private void RealizarPago_Click(object sender, EventArgs e)
        {
            bool Cancelado;
            RegistroPedido Producto = PantallaPedirInformación.PedirUnPedidoNoPagado(out Cancelado);
            if (!Cancelado)
            {
                if (Producto != null)
                {
                    PantallaInformacionGeneral temp = new PantallaInformacionGeneral(Producto);
                    temp.ShowDialog();
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("No se encontró el pedido, desea ver una lista de pedidos pendientes de pago?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        PantallaPedidosNoPagados temp = new PantallaPedidosNoPagados();
                        temp.ShowDialog(this);
                    }
                }
            }
        }

        private void VerVentas_Click(object sender, EventArgs e)
        {
                PantallaVerVentas temp = new PantallaVerVentas();
                temp.ShowDialog();
        }

        private void MostrarPantallaCorteCaja()
        {
            RealizarCorte temp = new RealizarCorte();
            temp.ShowDialog();
        }

        private void PantallaVentas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MostrarPantallaCorteCaja();
            }
        }
    }
}
