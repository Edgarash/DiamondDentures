using Control.Ventas;
using Entidad;
using Presentacion.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Ventas
{
    public partial class PantallaRealizarPago : ControlesM.KuroForm
    {
        static bool Fuera=false;
        RegistroPedido Pedido { get; set; }
        static float Importe { get; set; }
        static float Recibido { get; set; }
        static string FormaPago { get; set; }

        public PantallaRealizarPago(RegistroPedido Pedido)
        {
            this.Pedido = Pedido;
            InitializeComponent();
            tbRecibe.KeyPress += Escape;
            tbAbono.KeyPress += Escape;
            tbRecibe.KeyPress += Validar.TextBox_KeyPress_ValidarSoloReales;
            tbAbono.KeyPress += Validar.TextBox_KeyPress_ValidarSoloReales;
            lblPedido.Text = Pedido.IDPedido;
            lblRestante.Text = Pedido.RestanteAPagar.ToString("C2");
        }

        private void Escape(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Fuera = true;
                Close();
            }
        }

        public static void RecibirPago(RegistroPedido Pedido, out bool Cancelado)
        {
            PantallaRealizarPago temp = new PantallaRealizarPago(Pedido);
            temp.ShowDialog();
            Cancelado = Fuera;
        }

        private void kuroButton1_Click(object sender, EventArgs e)
        {
            if (Recibido < Importe)
            {
                Validar.MensajeErrorOK("El Dinero Recibido No Puede Ser Menor Al Importe");
                tbAbono.Text = Recibido.ToString("N2");
            }
            else
            {
                FormaPago = rbCheque.Checked ? "CHEQUE" : (rbEfectivo.Checked ? "EFECTIVO" : "TARJETA");
                RegistroVenta Venta = new RegistroVenta(Pedido, Importe, DateTime.Today, PantallaLogin.Sesión, tbPersonaPaga.Text, FormaPago);
                ManejadorVentas.InsertarVenta(Venta);
                Pedido.RestanteAPagar -= Importe;
                Close();
            }
        }

        private void CalcularCambio(object sender, EventArgs e)
        {
            Importe = !string.IsNullOrWhiteSpace(tbAbono.Text) ? float.Parse(tbAbono.Text) : 0;
            Recibido= !string.IsNullOrWhiteSpace(tbRecibe.Text) ? float.Parse(tbRecibe.Text) : 0;
            if (Importe > Pedido.RestanteAPagar)
            {
                Validar.MensajeErrorOK("El Abono No Puede Ser Mayor Al Restante A Pagar");
                tbAbono.Text = Pedido.RestanteAPagar.ToString("N2");
            }
            else
            {
                float Cambio = (Recibido - Importe);
                lblCambio.Text = "CAMBIO: " + (Cambio < 0 ? 0 : Cambio).ToString("C2");
            }
        }
    }
}
