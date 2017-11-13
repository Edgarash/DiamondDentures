using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Recursos_Humanos
{
    public partial class RHumanosMenu : Control.Pantalla
    {
        public RHumanosMenu()
        {
            InitializeComponent();
        }

        private void btnPagoEmpleados_Click(object sender, EventArgs e)
        {
            RHumanosPagosEmpleado rhpe = new RHumanosPagosEmpleado();
            rhpe.Show();
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            RHumanosNominas rhn = new RHumanosNominas();
            rhn.Show();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            RHumanosAsistencia rha = new RHumanosAsistencia();
            rha.Show();
        }
    }
}
