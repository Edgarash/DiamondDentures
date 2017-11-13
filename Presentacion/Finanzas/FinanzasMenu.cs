using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Finanzas
{
    public partial class FinanzasMenu : Control.Pantalla
    {
        public FinanzasMenu()
        {
            InitializeComponent();
        }

        private void btnFinanzasVentas_Click(object sender, EventArgs e)
        {
            FinanzasVentas fv = new FinanzasVentas();
            fv.Show();
        }

        private void btnFinanzasGastos_Click(object sender, EventArgs e)
        {
            FinanzasCompras fg = new FinanzasCompras();
            fg.Show();
        }

        private void btnComIns_Click(object sender, EventArgs e)
        {
            FinanzasComprarInsumos fci = new FinanzasComprarInsumos();
            fci.Show();
        }

        private void btnVerInsumos_Click(object sender, EventArgs e)
        {
            FinanzasVerCompraInsumos fvci = new FinanzasVerCompraInsumos();
            fvci.Show();
        }

        private void btnAdmPag_Click(object sender, EventArgs e)
        {
            FinanzasAdministracionPagos fap = new FinanzasAdministracionPagos();
            fap.Show();
        }       

        private void btnRealizaPago_Click(object sender, EventArgs e)
        {
            FinanzasRealizarPago frp = new FinanzasRealizarPago("");
            frp.Show();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            FinanzasBalanceCuentas fbc = new FinanzasBalanceCuentas();
            fbc.Show();
        }
    }
}
