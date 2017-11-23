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
            tbClave.Text = Registro?.IDProducto.ToString() ?? "";
            tbPrecio.Text = Registro?.PrecioBase.ToString() ?? "";
            tbNombre.Text = Registro?.Nombre ?? "";
            nudDias.Value = Registro?.TiempoBase ?? 1;
            InitializeComponent2();
            InitializeComponent3();
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
                    //if (Materiales[i].IDMaterial == ObtenerProMat[j].ClaveMat && Materiales[i].Activo == 1)
                    //{
                    //    dgvMateriales.RowCount += 1;
                    //    dgvMateriales[0, k].Value = ObtenerProMat[j].ClaveMat;
                    //    dgvMateriales[1, k].Value = ObtenerProMat[j].Activo == 1 ? true : false;
                    //    dgvMateriales[2, k].Value = ObtenerProMat[j].Material;
                    //    dgvMateriales[3, k].Value = ObtenerProMat[j].Precio;
                    //    Encontrado = true;
                    //    k++;
                    //}
                }
                //if (!Encontrado && Materiales[i].Activo == 1)
                //{
                //    dgvMateriales.RowCount += 1;
                //    dgvMateriales[0, k].Value = Materiales[i].IDMaterial;
                //    dgvMateriales[1, k].Value = false;
                //    dgvMateriales[2, k].Value = Materiales[i].Nombre;
                //    dgvMateriales[3, k].Value = Materiales[i].PrecioBase;
                //    k++;
                //}
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
                    if (Interface.ObtenerUnProducto(Modificar.Nombre).IDProducto == Modificar.IDProducto)
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
                        Validar.MensajeErrorOK("El nombre " + Modificar.Nombre + " ya ha sido usado y no puede repetirse");
                }
                else
                {
                    Validar.MensajeErrorBaseDeDatos();
                }
            }
        }
    }
}