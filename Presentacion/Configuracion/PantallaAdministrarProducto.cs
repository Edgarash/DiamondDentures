using Control;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Configuracion
{
    public partial class PantallaAdministrarProducto : Pantalla
    {
        InterfaceUsuario Interface;
        enum Búsqueda { Total, Clave, Personalizada };
        RegistroProducto[] Productos;

        public PantallaAdministrarProducto()
        {
            InitializeComponent();
            InitializeComponent2();
            InterfaceUsuario.ObtenerProductos(out Productos);
            LlenarData(Búsqueda.Total);
        }

        private void LlenarData(Búsqueda Tipo)
        {
            int Col = 0, Ren = 0;
            if (dgvProductos.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dgvProductos.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
            }
            dgvProductos.Rows.Clear();
            Interface = new InterfaceUsuario(this);
            RegistroProducto[] temp = null;
            if (Tipo == Búsqueda.Total)
            {
                InterfaceUsuario.ObtenerProductos(out temp);
            }
            else
            {
                if (Tipo == Búsqueda.Clave)
                {
                    List<RegistroProducto> x = new List<RegistroProducto>();
                    for (int i = 0; i < Productos.Length; i++)
                    {
                        if (Productos[i].IDProducto.ToString() == tbClave.Text)
                        {
                            x.Add(Productos[i]);
                        }
                    }
                    temp = x.ToArray();
                }
                else
                {
                    if (Tipo == Búsqueda.Personalizada)
                    {
                        List<RegistroProducto> x = new List<RegistroProducto>();
                        for (int i = 0; i < Productos.Length; i++)
                        {
                            if (Productos[i].Nombre.Contains(tbNombre.Text))
                            {
                                x.Add(Productos[i]);
                            }
                        }
                        temp = x.ToArray();
                    }
                }
            }
            if (temp != null)
            {
                dgvProductos.RowCount = temp.Length;
                for (int i = 0; i < temp.Length; i++)
                {
                    dgvProductos[0, i].Value = temp[i].IDProducto;
                    dgvProductos[1, i].Value = temp[i].Nombre;
                    dgvProductos[2, i].Value = temp[i].TiempoBase + " Dias";
                    dgvProductos[3, i].Value = "$" + temp[i].PrecioBase.ToString();
                    //dgvProductos.Rows[i].DefaultCellStyle.BackColor = temp[i].Activo == 0 ? Color.LightSalmon : Color.LightGreen;
                }
            }
            if (dgvProductos.SelectedCells.Count > 0)
            {
                dgvProductos.CurrentCell = dgvProductos[Col >= dgvProductos.ColumnCount ? 0 : Col, Ren >= dgvProductos.RowCount ? 0 : Ren];
                dgvProductos.Focus();
            }
        }

        private void LlenarData()
        {
            LlenarData(Búsqueda.Total);
        }

        private void btnBuscarClave_Click(object sender, EventArgs e)
        {
            if (tbClave.Text != "")
            {
                LlenarData(Búsqueda.Clave);
                tbClave.Clear();
                tbClave.Focus();
            }
            else
            {
                if (tbNombre.Text != "")
                    LlenarData(Búsqueda.Personalizada);
                else
                    LlenarData(Búsqueda.Total);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            if (!Validar.ValidarUnaPantalla(typeof(PantallaAgregarProducto)))
                Interface.DesplegarPantallaAgregarProducto(LlenarData);
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            if (DialogResult.Yes == MessageBox.Show("Realmente desea eliminar el producto " + dgvProductos[1, dgvProductos.SelectedCells[0].RowIndex].Value + "?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                if (Interface.EliminarProducto(Convert.ToInt32(dgvProductos[0, dgvProductos.SelectedCells[0].RowIndex].Value)))
                {
                    MessageBox.Show("Producto eliminado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarData(Búsqueda.Total);
                }
                else
                    Validar.MensajeErrorBaseDeDatos();
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaModificarProducto)))
            {
                Interface = new InterfaceUsuario(this);
                RegistroProducto Producto;
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    InterfaceUsuario.ObtenerUnProducto(Convert.ToInt32(dgvProductos["Clave", dgvProductos.CurrentRow.Index].Value), out Producto);
                    Interface.DesplegarPantallaModificarProducto(Producto, LlenarData);
                }
            }
        }
    }
}
