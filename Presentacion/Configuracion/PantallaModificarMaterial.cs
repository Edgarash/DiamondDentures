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
            tbClave.Text = Material.IDMaterial.ToString();
            tbClave.Enabled = false;
            cbProveedores.Text = Material.Proveedor.Nombre;
            tbNombreMaterial.Text = Material.Nombre;
            tbUnidadMedida.Text = Material.UnidadMedida;
            tbDescripcion.Text = Material.Descripcion;
            tbPrecioBase.Text = Material.PrecioBase.ToString();
            tbPrecioCompra.Text = Material.PrecioCompra.ToString();
            nudTiempo.Value = Material.TiempoBase;
            nudCantidad.Value = Material.Cantidad;
            InitializeComponent();
            InitializeComponent2();
            InitializeComponent3();
            LlenarComboBoxProveedores();
        }

        protected override void InitializeComponent3()
        {
            base.InitializeComponent3();
            RegistroProMat[] temp = ObtenerProMat;
            Interface = new InterfaceUsuario(this);
            RegistroProducto[] Productos;
            InterfaceUsuario.ObtenerProductos(out Productos);
            dgvProductos.RowCount = 0;
            int k = 0;
            for (int i = 0; i < Productos.Length; i++)
            {
                bool Encontrado = false;
                for (int j = 0; j < temp?.Length && !Encontrado; j++)
                {
                    if (Productos[i].IDProducto == temp[j].Producto.IDProducto && Productos[i].Activo)
                    {
                        dgvProductos.RowCount += 1;
                        dgvProductos["Clave", k].Value = temp[j].Producto.IDProducto;
                        dgvProductos["Activo", k].Value = temp[j].Activo ? true : false;
                        dgvProductos["Producto", k].Value = temp[j].Producto.Nombre;
                        dgvProductos["Precio", k].Value = temp[j].PrecioFinal;
                        dgvProductos["Tiempo", k].Value = temp[j].TiempoFinal;
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!CamposFaltantes)
            {
                Interface = new InterfaceUsuario(this);
                RegistroMaterial Modificar = ObtenerRegistro;
                Modificar.IDMaterial = Convert.ToInt32(tbClave.Text);
                if (InterfaceUsuario.ActualizarMaterial(Modificar))
                {
                    string Mensaje = "";
                    if (!ActualizarProMat(out Mensaje))
                        MessageBox.Show("Material actualizado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        Validar.MensajeErrorBaseDeDatos();
                    LlamarEventoCerrar();
                    Close();
                }
            }
        }
    }
}
