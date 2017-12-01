using Control.Ventas;
using ControlesM;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Ventas.Entregas
{
    public partial class PantallaPedidosNoEntregados : KuroForm
    {
        RegistroPedido[] Pedidos { get; set; }
        RegistroPedido PedidoActual { get; set; }
        public PantallaPedidosNoEntregados()
        {
            InitializeComponent();
            rbAmbos.Checked = true;
            btnEjecutar_Click(btnEjecutar, new EventArgs());
            setPedidoActual();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string
                IDPedido = string.IsNullOrWhiteSpace(tbIDPedido.Text) ? null : tbIDPedido.Text,
                Nombre = string.IsNullOrWhiteSpace(tbEmpleado.Text) ? null : tbEmpleado.Text,
                Dentista = string.IsNullOrWhiteSpace(tbDentista.Text) ? null : tbDentista.Text;
            DateTime
                Min = dtpMin.Checked ? new DateTime(dtpMin.Value.Year, dtpMin.Value.Month, dtpMin.Value.Day) : DateTime.MinValue,
                Max = dtpMax.Checked ? new DateTime(dtpMax.Value.Year, dtpMax.Value.Month, dtpMax.Value.Day, 23, 59, 59, 999) : DateTime.MaxValue;
            RegistroPedido[] Pedidos;
            int Entregado = rbAmbos.Checked ? 2 : (rbEntregado.Checked ? 1 : 0);
            ManejadorVentas.BuscarPedidosNoPagados(IDPedido, Min, Max, Nombre, Dentista, cbUrgente.Checked, cbPagado.Checked, out Pedidos, Entregado);
            List<RegistroPedido> temp = new List<RegistroPedido>();
            for (int i = 0; i < Pedidos.Length; i++)
                if (Pedidos[i].EstadoPedido >= 4)
                    temp.Add(Pedidos[i]);
            this.Pedidos = temp.ToArray();
            kuroDGV1.RowCount = this.Pedidos.Length;
            for (int i = 0; i < this.Pedidos.Length; i++)
            {
                kuroDGV1[0, i].Value = Pedidos[i].IDPedido;
                kuroDGV1[1, i].Value = Pedidos[i].RegistraPedido.NombreCompleto;
                kuroDGV1[2, i].Value = Pedidos[i].Dentista.NombreCompleto;
                kuroDGV1[3, i].Value = Pedidos[i].FechaIngreso;
                kuroDGV1[4, i].Value = Pedidos[i].FechaCalculada;
                kuroDGV1[5, i].Value = Pedidos[i].Urgencia == "1" ? "SI" : "NO";
                kuroDGV1[6, i].Value = Pedidos[i].CostoTotal;
                kuroDGV1[7, i].Value = Pedidos[i].Pagado;
                kuroDGV1[8, i].Value = Pedidos[i].RestanteAPagar.ToString("C2");
                kuroDGV1[9, i].Value = Pedidos[i].Entregado == "1" ? "SI" : "NO";
            }
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            int row = kuroDGV1.CurrentRow.Index;
            bool Cancelado;
            PantallaRealizarPago.RecibirPago(Pedidos[row], out Cancelado);
            if (!Cancelado)
            {
                kuroDGV1[0, row].Value = Pedidos[row].IDPedido;
                kuroDGV1[1, row].Value = Pedidos[row].RegistraPedido.NombreCompleto;
                kuroDGV1[2, row].Value = Pedidos[row].Dentista.NombreCompleto;
                kuroDGV1[3, row].Value = Pedidos[row].FechaIngreso;
                kuroDGV1[4, row].Value = Pedidos[row].FechaCalculada;
                kuroDGV1[5, row].Value = Pedidos[row].Urgencia;
                kuroDGV1[6, row].Value = Pedidos[row].CostoTotal;
                kuroDGV1[7, row].Value = Pedidos[row].Pagado;
                kuroDGV1[8, row].Value = Pedidos[row].RestanteAPagar.ToString("C2");
            }
        }

        private void kuroDGV1_CurrentCellChanged(object sender, EventArgs e)
        {
            setPedidoActual();
            btnAbonar.Visible = PedidoActual?.RestanteAPagar > 0;
            btnEntregar.Visible = PedidoActual?.Entregado == "0";
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            bool Entregado = ManejadorVentas.EntregarPedido(PedidoActual.IDPedido, DateTime.Now);
            if (Entregado)
            {
                MessageBox.Show("Pedido entregado con éxito");
                kuroDGV1[9, kuroDGV1.CurrentRow.Index].Value = "SI";
            }
            else
                Validar.MensajeErrorOK("No se pudo registrar la entrega del pedido");
        }

        private void setPedidoActual()
        {
            int CurrentRow = kuroDGV1.CurrentRow?.Index ?? 0;
            if (kuroDGV1.RowCount > 0)
            {
                string IDPedido = kuroDGV1[0, CurrentRow].Value?.ToString();
                for (int i = 0; i < Pedidos.Length; i++)
                    if (Pedidos[i].IDPedido == IDPedido)
                        PedidoActual = Pedidos[i];
            }
        }
    }
}
