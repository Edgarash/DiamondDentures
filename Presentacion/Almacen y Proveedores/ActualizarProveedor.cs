using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Control;

namespace Presentacion.Almacen_y_Proveedores
{
    public partial class ActualizarProveedor : Form
    {

        public ActualizarProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtNombre.Text != "" && txtTel.Text != "" && txtCorreo.Text != "" && txtDir.Text != "" && txtDes.Text != "")
            {
                RegistroProveedor proveedor = new RegistroProveedor(Convert.ToInt32(txtID.Text), txtNombre.Text, txtTel.Text, txtCorreo.Text, txtDir.Text, txtDes.Text);
                ManejadorAlmacen.ActualizarProveedor(proveedor);
                MessageBox.Show("Registro actualizado con exito");
            }
            else
            {
                MessageBox.Show("No deben quedar campos vacios");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroProveedor proveedor = new RegistroProveedor(Convert.ToInt32(txtID.Text));
            ManejadorAlmacen.BorrarProveedor(proveedor);
            MessageBox.Show("Registro borrado con exito");
        }
    }
}
