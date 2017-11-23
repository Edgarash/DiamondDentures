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
    public partial class PantallaAgregarProducto : PantallaProducto
    {
        public PantallaAgregarProducto()
        {
            InitializeComponent();
            InitializeComponent2();
            InitializeComponent3();
            UltimaClaveProducto();
        }

        private void UltimaClaveProducto()
        {
            RegistroProducto temp;
            ManejadorRegistroProducto.UltimaClaveProducto(out temp);
            tbClave.Text = (temp.IDProducto + 1).ToString();
            tbClave.Enabled = false;
        }

        protected override void InitializeComponent3()
        {
            base.InitializeComponent3();
            Interface = new InterfaceUsuario(this);
            RegistroProducto[] Productos = Interface.ObtenerProductos();
            tbClave.Enabled = true;
            tbClave.Text = Productos?.Length > 0 ? (Productos?[Productos.Length - 1]?.IDProducto + 1)?.ToString() : "0";
            RegistroMaterial[] Materiales = Interface.ObtenerMateriales();
            for (int i = 0; i < Materiales?.Length; i++)
            {
                int j = dgvMateriales.RowCount;
                dgvMateriales.RowCount += 1;
                dgvMateriales["Clave", j].Value = Materiales[i].IDMaterial;
                dgvMateriales["Activo", j].Value = true;
                dgvMateriales["Materiales", j].Value = Materiales[i].Nombre;
                dgvMateriales["Precio", j].Value = Materiales[i].PrecioBase;
                dgvMateriales["Tiempo", j].Value = Materiales[i].TiempoBase;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos)
            {
                Interface = new InterfaceUsuario(this);
                RegistroProducto temp = ObtenerRegistro;
                if (Interface.RegistrarProducto(temp))
                {
                    string Mensaje = "";
                    if (!ActualizarProMat(out Mensaje))
                        MessageBox.Show("Producto registrado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        Validar.MensajeErrorOK("El producto se registró sin embargo hubo un problema al asociar los materiales, favor de cambiar los parámetros modificando el producto en su opción correspondiente\n\n" + Mensaje);
                    Close();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
