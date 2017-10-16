using ControlesM;
using Entidad;
using Presentacion.Recepcion;
using System;

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
            RegistroPedido Producto = PantallaPedirInformación.PedirUnPedido(out Cancelado);
            if (!Cancelado)
            {
                PantallaInformacionGeneral temp = new PantallaInformacionGeneral(Producto);
                temp.ShowDialog();

            }
        }
    }
}
