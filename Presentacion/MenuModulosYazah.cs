using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuModulosYazah : Control.Pantalla
    {
        public MenuModulosYazah()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Finanzas.FinanzasMenu fn = new Finanzas.FinanzasMenu();
            fn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recursos_Humanos.RHumanosMenu rh = new Recursos_Humanos.RHumanosMenu();
            rh.Show();
        }
    }
}
