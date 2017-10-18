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
    public partial class SolicitarMaterial : Form
    {
        public SolicitarMaterial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                CompraMaterial CMaterial = new CompraMaterial(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToDateTime(textBox5.Text), "Pendiente");
                ManejadorAlmacen.Compra_Material(CMaterial);
                MessageBox.Show("Registro agregado con exito");
            }
            else
            {
                MessageBox.Show("No deben quedar campos vacios");
            }
        }
    }
}
