using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidad;
using Validaciones;

namespace Presentacion.Configuracion
{
    public partial class PantallaEliminarMaterial : Presentacion.Configuracion.PantallaMaterial
    {
        public PantallaEliminarMaterial(RegistroMaterial Material)
        {
            InitializeComponent();
            tbClave.Text = Material.IDMaterial.ToString();
            cbProveedores.Text = Material.Proveedor.Nombre;
            tbPrecioCompra.Text = Material.PrecioCompra.ToString();
            tbNombreMaterial.Text = Material.Nombre;
            tbUnidadMedida.Text = Material.UnidadMedida;
            tbDescripcion.Text = Material.Descripcion;
            tbPrecioBase.Text = Material.PrecioBase.ToString("N2");
            nudTiempo.Value = Material.TiempoBase;
            nudCantidad.Value = Material.Cantidad;
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
                    else
                    {
                        if (temp == typeof(ComboBox))
                            Controls[i].Enabled = false;
                    }
                }
            }
        }

        protected override void InitializeComponent3()
        {
            base.InitializeComponent3();
            RegistroProMat[] temp = ObtenerProMat;
            Interface = new InterfaceUsuario(this);
            RegistroProducto[] Productos = Interface.ObtenerProductos();
            dgvProductos.RowCount = 0;
            int k = 0;
            for (int i = 0; i < Productos.Length; i++)
            {
                bool Encontrado = false;
                for (int j = 0; j < temp?.Length && !Encontrado; j++)
                {
                    if (Productos[i].IDProducto == ObtenerProMat[j].Producto.IDProducto && Productos[i].Activo)
                    {
                        dgvProductos.RowCount += 1;
                        dgvProductos["Clave", k].Value = ObtenerProMat[j].Producto.IDProducto;
                        dgvProductos["Activo", k].Value = ObtenerProMat[j].Activo;
                        dgvProductos["Producto", k].Value = ObtenerProMat[j].Producto.Nombre;
                        dgvProductos["Precio", k].Value = ObtenerProMat[j].PrecioFinal;
                        dgvProductos["Tiempo", k].Value = ObtenerProMat[j].TiempoFinal;

                        Encontrado = true;
                        k++;
                    }
                }
                if (!Encontrado && Productos[i].Activo)
                {
                    dgvProductos.RowCount += 1;
                    dgvProductos["Clave", k].Value = Productos[i].IDProducto;
                    dgvProductos["Activo", k].Value = false;
                    dgvProductos["Producto", k].Value = Productos[i].Nombre;
                    dgvProductos["Precio", k].Value = Productos[i].PrecioBase;
                    dgvProductos["Tiempo", k].Value = Productos[i].TiempoBase;
                    k++;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            if (InterfaceUsuario.EliminarMaterial(Convert.ToInt32(tbClave.Text)))
            {
                MessageBox.Show("Material eliminado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                Validar.MensajeErrorBaseDeDatos();
            }
        }
    }
}
