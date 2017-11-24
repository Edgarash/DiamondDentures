using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Recepcion
{
    public partial class PantallaModificarPedido : PantallaPedido
    {
        public PantallaModificarPedido(RegistroPedido Pedido)
        {
            InitializeComponent();
            InitializeComponent2();
            if (Pedido != null)
            {
                InitializeComponent3();
                InitializeComponent4(Pedido);
                PrecioPedido();
                FechaPedido();
            }
            tbUrgente.Enabled = false;
        }

        private void InitializeComponent4(RegistroPedido Pedido)
        {
            tbClave.Text = Pedido.IDPedido.ToString();
            tbClave.Enabled = false;
            tbCedula.Text = Pedido.Dentista.Cedula;
            nudTrabajos.Value = Pedido.Productos.Length;
            for (int i = 0; i < (int)nudTrabajos.Value; i++)
            {
                Trabajos[i].Producto.Text = Pedido.Productos[i].Producto.Nombre;
                Trabajos[i].Material1.Text = Pedido.Productos[i].Material1?.Nombre;
                Trabajos[i].Material2.Text = Pedido.Productos[i].Material2?.Nombre;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!FaltanCampos)
            {
                Interface = new InterfaceUsuario(this);
                if (Interface.ActualizarPedido(ObtenerPedido))
                {
                    MessageBox.Show("Pedido actualizado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                    Validar.MensajeErrorBaseDeDatos();
            }
        }
    }
}
