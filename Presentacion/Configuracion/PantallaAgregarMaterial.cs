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
    public partial class PantallaAgregarMaterial : PantallaMaterial
    {
        public PantallaAgregarMaterial()
        {
            InitializeComponent();
            InitializeComponent3();
            EstablecerClaveMaterial();
            LlenarComboBoxProveedores();
        }

        private void EstablecerClaveMaterial()
        {
            RegistroMaterial temp;
            ManejadorConfiguracion.ObtenerUltimaClaveMaterial(out temp);
            if (temp != null)
                tbClave.Text = (temp.IDMaterial + 1).ToString();
            else
                tbClave.Text = "1";
            tbClave.Enabled = false;
        }

        protected override void InitializeComponent3()
        {
            base.InitializeComponent3();
            tbClave.Enabled = true;
            Interface = new InterfaceUsuario(this);
            RegistroProducto[] Productos;
            InterfaceUsuario.ObtenerProductos(out Productos);
            tbClave.Select(tbClave.Text.Length, tbClave.Text.Length);
            for (int i = 0; i < Productos?.Length; i++)
            {
                if (Productos[i].Activo)
                {
                    int j = dgvProductos.RowCount;
                    dgvProductos.RowCount += 1;
                    dgvProductos["Clave", j].Value = Productos[i].IDProducto;
                    dgvProductos["Activo", j].Value = true;
                    dgvProductos["Producto", j].Value = Productos[i].Nombre;
                    dgvProductos["Precio", j].Value = Productos[i].PrecioBase;
                    dgvProductos["Tiempo", j].Value = Productos[i].TiempoBase;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!CamposFaltantes)
            {
                Interface = new InterfaceUsuario(this);
                if (Interface.RegistrarMaterial(ObtenerRegistro))
                {
                    string Mensaje = "";
                    if (!ActualizarProMat(out Mensaje))
                        MessageBox.Show("Material registrado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        Validar.MensajeErrorOK("El material se registró sin embargo hubo un problema al asociar los productos, favor de cambiar los parámetros modificando el material en su opción correspondiente\n\n" + Mensaje);
                    LlamarEventoCerrar();
                    Close();
                }
            }
        }
    }
}
