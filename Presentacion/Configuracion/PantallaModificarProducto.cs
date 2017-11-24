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
    public partial class PantallaModificarProducto : Presentacion.Configuracion.PantallaProducto
    {
        public PantallaModificarProducto(RegistroProducto Registro)
        {
            InitializeComponent();
            tbClave.Text = Registro.IDProducto.ToString();
            tbClave.Enabled = false;
            tbNombre.Text = Registro.Nombre;
            tbUnidadMedida.Text = Registro.UnidadMedida;
            tbDescripcion.Text = Registro.Descripcion;
            nudDias.Value = Registro.TiempoBase;
            tbPrecio.Text = Registro.PrecioBase.ToString();
            nudCantidad.Value = Registro.Cantidad;
            InitializeComponent2();
            InitializeComponent3();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos)
            {
                Interface = new InterfaceUsuario(this);
                RegistroProducto Modificar = ObtenerRegistro;
                Modificar.IDProducto = Convert.ToInt32(tbClave.Text);
                if (Interface.ActualizarProducto(Modificar))
                {
                    string msg = "";
                    if (!ActualizarProMat(out msg))
                        MessageBox.Show("Producto actualizado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        Validar.MensajeErrorBaseDeDatos();
                    LlamarEventoCerrar();
                    Close();
                }
                else
                {
                    Validar.MensajeErrorBaseDeDatos();
                }
            }
        }
    }
}