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
    public partial class PantallaModificarMaterial : PantallaMaterial
    {
        public PantallaModificarMaterial(RegistroMaterial Material)
        {
            tbClave.Enabled = false;
            tbClave.Text = Material?.IDMaterial.ToString();
            tbNombre.Text = Material?.Nombre ?? "";
            tbPrecio.Text = Material?.PrecioBase.ToString();
            InitializeComponent();
            InitializeComponent2();
            InitializeComponent3();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!CamposFaltantes)
            {
                Interface = new InterfaceUsuario(this);
                RegistroMaterial Modificar = ObtenerRegistro;
                Modificar.IDMaterial = Convert.ToInt32(tbClave.Text);
                if (Interface.ActualizarMaterial(Modificar))
                {
                    //RegistroMaterial[] temp = Interface.BuscarUnMaterial(new RegistroMaterial(-1, tbNombre.Text, -1, -1));
                    //bool Repetido = false;
                    //for (int i = 0; i < temp.Length && !Repetido; i++)
                    //    if (temp[i].IDMaterial != Modificar.IDMaterial && tbNombre.Text.ToUpper() == temp[i].Nombre.ToUpper())
                    //        Repetido = true;
                    //if (!Repetido)
                    //{
                    //    string Mensaje = "";
                    //    if (!ActualizarProMat(out Mensaje))
                    //        MessageBox.Show("Material actualizado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    else
                    //        Validar.MensajeErrorBaseDeDatos();
                    //    LlamarEventoCerrar();
                    //    Close();
                    //}
                    //else
                    //{
                    //    Validar.MensajeErrorOK("El nombre de " + tbNombre.Text + " ya se encuentra registrado en la base de datos como otro material");
                    //}
                }
            }
        }
    }
}
