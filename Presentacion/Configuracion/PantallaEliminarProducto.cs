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
            tbClave.Text = Producto?.Clave.ToString();
            nudDias.Value = Producto?.Dias ?? 1;
            tbNombre.Text = Producto?.Nombre ?? "";
            tbPrecio.Text = Producto?.Precio.ToString();
            InitializeComponent3();
            dgvMateriales.Enabled = tbClave.Enabled = nudDias.Enabled = tbNombre.Enabled = tbPrecio.Enabled = false;
        }

        protected override void InitializeComponent3()
        {
            base.InitializeComponent3();
            RegistroProMat[] temp = ObtenerProMat;
            Interface = new InterfaceUsuario(this);
            RegistroMaterial[] Materiales = Interface.ObtenerMateriales();
            dgvMateriales.RowCount = 0;
            int k = 0;
            for (int i = 0; i < Materiales.Length; i++)
            {
                bool Encontrado = false;
                for (int j = 0; j < temp?.Length && !Encontrado; j++)
                {
                    if (Materiales[i].Clave == ObtenerProMat[j].ClaveMat && Materiales[i].Activo == 1)
                    {
                        dgvMateriales.RowCount += 1;
                        dgvMateriales[0, k].Value = ObtenerProMat[j].ClaveMat;
                        dgvMateriales[1, k].Value = ObtenerProMat[j].Activo == 1 ? true : false;
                        dgvMateriales[2, k].Value = ObtenerProMat[j].Material;
                        dgvMateriales[3, k].Value = ObtenerProMat[j].Precio;
                        Encontrado = true;
                        k++;
                    }
                }
                if (!Encontrado && Materiales[i].Activo == 1)
                {
                    dgvMateriales.RowCount += 1;
                    dgvMateriales[0, k].Value = Materiales[i].Clave;
                    dgvMateriales[1, k].Value = false;
                    dgvMateriales[2, k].Value = Materiales[i].Nombre;
                    dgvMateriales[3, k].Value = Materiales[i].Precio;
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
