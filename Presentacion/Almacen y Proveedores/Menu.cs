using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion;

namespace Presentacion.Almacen_y_Proveedores
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Almacen_y_Proveedores.AgregarProveedor p1 = new Almacen_y_Proveedores.AgregarProveedor();
            p1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Almacen_y_Proveedores.Inventario p2 = new Almacen_y_Proveedores.Inventario();
            p2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RequisicionMateriales p5 = new RequisicionMateriales();
            p5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerProveedores p6 = new VerProveedores();
            p6.Show();
        }
    }
}
