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
            tbClave.Text = Material?.IDMaterial.ToString();
            tbNombre.Text = Material?.Nombre ?? "";
            tbPrecio.Text = Material?.PrecioBase.ToString("N2");
            InitializeComponent3();
            dgvProductos.Enabled = tbClave.Enabled = tbNombre.Enabled = tbPrecio.Enabled = false;
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
                    //if (Productos[i].IDProducto == ObtenerProMat[j].ClavePro && Productos[i].Activo == 1)
                    //{
                    //    dgvProductos.RowCount += 1;
                    //    dgvProductos[0, k].Value = ObtenerProMat[j].ClavePro;
                    //    dgvProductos[1, k].Value = ObtenerProMat[j].Activo == 1 ? true : false;
                    //    dgvProductos[2, k].Value = ObtenerProMat[j].Producto;
                    //    dgvProductos[3, k].Value = ObtenerProMat[j].Precio;
                    //    Encontrado = true;
                    //    k++;
                    //}
                }
                //if (!Encontrado && Productos[i].Activo == 1)
                //{
                //    dgvProductos.RowCount += 1;
                //    dgvProductos[0, k].Value = Productos[i].IDProducto;
                //    dgvProductos[1, k].Value = false;
                //    dgvProductos[2, k].Value = Productos[i].Nombre;
                //    dgvProductos[3, k].Value = Productos[i].PrecioBase;
                //    k++;
                //}
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            if (Interface.EliminarMaterial(Convert.ToInt32(tbClave.Text)))
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
