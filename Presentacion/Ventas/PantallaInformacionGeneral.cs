using ControlesM;
using Entidad;

namespace Presentacion.Ventas
{
    public partial class PantallaInformacionGeneral : KuroForm
    {
        RegistroPedido Pedido { get; set; }
        public PantallaInformacionGeneral(RegistroPedido Pedido)
        {
            this.Pedido = Pedido;
            InitializeComponent();
            lblUsuario.Text = Pedido.RegistraPedido.Nombre + " " + Pedido.RegistraPedido.Apellidos;
            lblFechaEntrega.Text = Pedido.FechaCalculada.ToLongDateString();
            lblFechaRegistrado.Text = Pedido.FechaIngreso.ToLongDateString();
            lblPedido.Text = Pedido.IDPedido;
            lblDentista.Text = Pedido.Dentista.Nombre + " " + Pedido.Dentista.Apellidos;
            lblRestanteAPagar.Text = Pedido.RestanteAPagar.ToString("C2");
            btnAbonar.Visible = Pedido.RestanteAPagar > 0;
            kuroDGV1.RowCount = Pedido.Productos.Length;
            for (int i = 0; i < Pedido.Productos.Length; i++)
            {
                kuroDGV1[0, i].Value = Pedido.Productos[i].Producto.Nombre;
                kuroDGV1[1, i].Value = Pedido.Productos[i].Material1.Nombre;
                kuroDGV1[2, i].Value = Pedido.Productos[i].Material2?.Nombre;
                kuroDGV1[3, i].Value = Pedido.Productos[i].Total.ToString("C2");
            }
        }

        private void kuroButton1_Click(object sender, System.EventArgs e)
        {
            bool Cancelado = false;
            PantallaRealizarPago.RecibirPago(Pedido, out Cancelado);
            lblRestanteAPagar.Text = Pedido.RestanteAPagar.ToString("C2");
            btnAbonar.Visible = Pedido.RestanteAPagar > 0;
        }
    }
}
