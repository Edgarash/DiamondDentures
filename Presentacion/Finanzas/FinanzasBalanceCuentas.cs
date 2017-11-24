using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Entidad;
using Presentacion.Reportes;

namespace Presentacion.Finanzas
{
    public partial class FinanzasBalanceCuentas : Control.Pantalla
    {
        InterfaceUsuario Interface;
        string fec = "";
        public FinanzasBalanceCuentas()
        {
            InitializeComponent();
        }
        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            fec = cbAño.Text + "-" + cbMes.Text;
            Interface.DatosDBalanceCuentasIngresos(dtIngresos, fec);
            Interface.DatosDBalanceCuentasEgresos(dtEgresos, fec);
            if (dtIngresos!=null && dtEgresos!=null)
            {
                if (dtIngresos.RowCount>0 && dtEgresos.RowCount>0)
                {
                    dtIngresos[1, dtIngresos.RowCount - 1].Style.BackColor = Color.LightGreen;
                    dtEgresos[1, dtEgresos.RowCount - 1].Style.BackColor = Color.IndianRed;
                    dtIngresos[2, dtIngresos.RowCount - 1].Style.BackColor = Color.LightGreen;
                    dtEgresos[2, dtEgresos.RowCount - 1].Style.BackColor = Color.IndianRed;
                    Interface.DatosDTotalIngresos(txTotal);
                }
            }            
        }
        private void ActualizarData2()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosDAgregarBalanceCuentasIngresos(dtIngresos,"",txIngresos.Text, fec);
        }
        private void ActualizarData3()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosDAgregarBalanceCuentasEgresos(dtEgresos, "", txEgresos.Text, fec);
        }

        private void FinanzasBalanceCuentas_Load(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarData();
        }
        
        private void btnBalanceIngresos_Click(object sender, EventArgs e)
        {
            ActualizarData2();
        }

        private void btnBalanceEgresos_Click(object sender, EventArgs e)
        {
            ActualizarData3();
        }

        private void btnGenRep_Click(object sender, EventArgs e)
        {
            string fecha = $"{cbAño.SelectedItem}/01/01";
            DateTime fchi = DateTime.Parse(fecha).AddMonths(Convert.ToInt32(cbMes.SelectedItem)-1);
            DateTime fchf = (fchi.AddMonths(1)).AddDays(-1);

            ParametroReporte Fchi_sv = new ParametroReporte("fchi", fchi, true, "SubVentas.rpt");
            ParametroReporte Fchf_sv = new ParametroReporte("fchf", fchf,true, "SubVentas.rpt");
            ParametroReporte Fchi_sg = new ParametroReporte("fchi", fchi, true, "SubGastos.rpt");
            ParametroReporte Fchf_sg = new ParametroReporte("fchf", fchf,true, "SubGastos.rpt");

            ManejadorReportes.MostrarPantalla(this, new PantallaVPListadoFec<CAN7_Balance>("Balance",fchi,fchf, Fchi_sv, Fchf_sv, Fchi_sg, Fchf_sg));
        }
    }
}
