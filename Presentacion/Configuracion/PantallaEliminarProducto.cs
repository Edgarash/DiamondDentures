using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Control;
using Entidad;
using Validaciones;

namespace Presentacion.Configuracion
{
    public partial class PantallaEliminarProducto : Presentacion.Configuracion.PantallaProducto
    {
        public PantallaEliminarProducto(RegistroProducto Producto)
        {
            InitializeComponent();
            tbClave.Text = Producto.IDProducto.ToString();
            tbNombre.Text = Producto.Nombre;
            tbUnidadMedida.Text = Producto.UnidadMedida;
            tbDescripcion.Text = Producto.Descripcion;
            nudDias.Value = Producto.TiempoBase;
            tbPrecio.Text = Producto.PrecioBase.ToString();
            nudCantidad.Value = Producto.Cantidad;
            InitializeComponent3();
            for (int i = 0; i < Controls.Count; i++)
            {
                Type temp = Controls[i].GetType();
                if (temp == typeof(TextBox))
                    Controls[i].Enabled = false;
                else
                {
                    if (temp == typeof(NumericUpDown))
                        Controls[i].Enabled = false;
                }
            }
        }

        protected override void InitializeComponent3()
        {
            base.InitializeComponent3();
            RegistroProMat[] temp = ObtenerProMat();
            Interface = new InterfaceUsuario(this);
            RegistroMaterial[] Materiales = Interface.ObtenerMateriales();
            dgvMateriales.RowCount = 0;
            int k = 0;
            for (int i = 0; i < Materiales.Length; i++)
            {
                bool Encontrado = false;
                for (int j = 0; j < temp?.Length && !Encontrado; j++)
                {
                    if (Materiales[i].IDMaterial == temp[j].Material.IDMaterial)
                    {
                        dgvMateriales.RowCount += 1;
                        dgvMateriales["Clave", k].Value = temp[j].Material.IDMaterial;
                        dgvMateriales["Activo", k].Value = temp[j].Activo;
                        dgvMateriales["Materiales", k].Value = temp[j].Material.Nombre;
                        dgvMateriales["Precio", k].Value = temp[j].PrecioFinal;
                        dgvMateriales["Tiempo", k].Value = temp[j].TiempoFinal;
                        Encontrado = true;
                        k++;
                    }
                }
                if (!Encontrado)
                {
                    dgvMateriales.RowCount += 1;
                    dgvMateriales["Clave", k].Value = Materiales[i].IDMaterial;
                    dgvMateriales["Activo", k].Value = true;
                    dgvMateriales["Materiales", k].Value = Materiales[i].Nombre;
                    dgvMateriales["Precio", k].Value = Materiales[i].PrecioBase;
                    dgvMateriales["Tiempo", k].Value = Materiales[i].TiempoBase;
                    k++;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            if (Interface.EliminarProducto(Convert.ToInt32(tbClave.Text)))
            {
                MessageBox.Show("Producto eliminado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                Validar.MensajeErrorBaseDeDatos();
            }
        }
    }
}
