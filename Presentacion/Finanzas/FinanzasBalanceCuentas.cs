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
                   // txTotal.Text = "Fondo = $ " + (Convert.ToInt32(dtIngresos[2, dtIngresos.RowCount - 1].Value) - Convert.ToInt32(dtEgresos[2, dtEgresos.RowCount - 1].Value)).ToString();
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
    }
}
