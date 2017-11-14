using ControlesM;
using Entidad;
using Presentacion.Recepcion;
using Presentacion.Ventas.CorteCaja;
using Presentacion.Ventas.Entregas;
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
            RegistroPedido Producto = PantallaPedirInformación.PedirUnPedidoBotonVerPedidos(out Cancelado, BotonOpcional.NoPagados);
            if (!Cancelado)
            {
                if (Producto != null)
                {
                    Hide();
                    PantallaInformacionGeneral temp = new PantallaInformacionGeneral(Producto);
                    temp.ShowDialog();
                    Show();
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("No se encontró el pedido, desea ver una lista de pedidos pendientes de pago?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        Hide();
                        PantallaPedidosNoPagados temp = new PantallaPedidosNoPagados();
                        temp.ShowDialog(this);
                        Show();
                    }
                }
            }
        }

        private void VerVentas_Click(object sender, EventArgs e)
        {
            Hide();
            PantallaVerVentas temp = new PantallaVerVentas();
            temp.ShowDialog();
            Show();
        }

        private void PantallaVentas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void HacerCorteCaja_Click(object sender, EventArgs e)
        {
            Hide();
            RealizarCorte temp = new RealizarCorte();
            temp.ShowDialog();
            Show();
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            bool Cancelado;
            RegistroPedido Producto = PantallaPedirInformación.PedirUnPedidoBotonVerPedidos(out Cancelado, BotonOpcional.NoEntregados);
            if (!Cancelado)
            {
                if (Producto != null)
                {
                    Hide();
                    PantallaInformacionGeneral temp = new PantallaInformacionGeneral(Producto);
                    temp.ShowDialog();
                    Show();
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("No se encontró el pedido, desea ver una lista de pedidos pendientes de entrega?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        Hide();
                        PantallaPedidosNoEntregados temp = new PantallaPedidosNoEntregados();
                        temp.ShowDialog(this);
                        Show();
                    }
                }
            }
        }
    }
}
