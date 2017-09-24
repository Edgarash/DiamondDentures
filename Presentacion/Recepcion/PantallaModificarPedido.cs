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
            tbClave.Enabled = tbFecha.Enabled = false;
            tbClave.Text = Pedido?.Clave ?? "";
            lblUsuario.Text = Pedido?.Usuario ?? "";
            tbFecha.Text = Pedido?.Fecha ?? "";
            tbCedula.Text = Pedido?.Cedula ?? "";
            tbRFC.Text = Pedido?.RFC ?? "";
            tbNombreDentista.Text = Pedido?.NombreDentista ?? "";
            tbApellidos.Text = Pedido?.ApellidosDentista ?? "";
            tbTelefono.Text = Pedido?.Telefono ?? "";
            cbPaíses.Text = Pedido?.Pais ?? "";
            cbEstado.Text = Pedido?.Estado ?? "";
            cbMunicipio.Text = Pedido?.Municipio ?? "";
            cbCiudad.Text = Pedido?.Ciudad ?? "";
            tbColonia.Text = Pedido?.Colonia ?? "";
            tbCalle.Text = Pedido?.Calle ?? "";
            tbNumFrente.Text = Pedido?.NumeroFrente ?? "";
            tbCP.Text = Pedido?.CP ?? "";
            tbEmail.Text = Pedido?.Email?.Split('@')?[0] ?? "";
            cbEmail.Text = Pedido?.Email?.Split('@')?[1] ?? "";
            for (int i = 0; i < Pedido?.Trabajos?.Length; i++)
            {
                dgvProductos.RowCount += 1;
                DataGridViewComboBoxCell temp = dgvProductos[0, i] as DataGridViewComboBoxCell;
                string temp2 = Pedido.Trabajos[i].Producto + " $" + Pedido.Trabajos[i].PrecioProducto;
                if (!temp.Items.Contains(temp2))
                    temp.Items.Add(temp2);
                temp.Value = temp2;
                temp = dgvProductos[1, i] as DataGridViewComboBoxCell;
                temp2 = Pedido.Trabajos[i].Material1 + " $" + Pedido.Trabajos[i].PrecioMaterial1;
                if (!temp.Items.Contains(temp2))
                    temp.Items.Add(temp2);
                temp.Value = temp2;
                if (!string.IsNullOrWhiteSpace(Pedido.Trabajos[i].Material2))
                {
                    temp = temp = dgvProductos[2, i] as DataGridViewComboBoxCell;
                    temp2 = Pedido.Trabajos[i].Material2 + " $" + Pedido.Trabajos[i].PrecioMaterial2;
                    if (!temp.Items.Contains(temp2))
                        temp.Items.Add(temp2);
                    temp.Value = temp2;
                }
                dgvProductos[3, i].Value = Pedido.Trabajos[i].Fecha;
                dgvProductos[4, i].Value = "$" + Pedido.Trabajos[i].Total.ToString("N2");
            }
            tbFechaEntrega.Text = Pedido?.FechaEntrega;
            tbUrgente.Checked = Pedido?.Urgente == 1;
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
