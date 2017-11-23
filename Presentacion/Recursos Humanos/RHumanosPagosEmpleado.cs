using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Finanzas;

namespace Presentacion.Recursos_Humanos
{
    public partial class RHumanosPagosEmpleado : Control.Pantalla
    {
        InterfaceUsuario Interface;
        string datos = "", subtotl = "", totl = "", fec = "";
        public RHumanosPagosEmpleado()
        {
            InitializeComponent();
        }

        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            fec = cbAño.Text + "-" + cbMes.Text;
            Interface.DatosDPagosTrab(dtPagoEmp);
            Interface.DatosDTotalPagosTrab(txTotal);
        }
        private void ActualizarData2()
        {
            subtotl = (Convert.ToInt32(txPrecUn.Text) * Convert.ToInt32(txCant.Text)).ToString();
            totl = ((Convert.ToInt32(subtotl) * 0.16) + Convert.ToInt32(subtotl)).ToString();
            txSubTot.Text = subtotl;
            txTot.Text = totl;
            Interface = new InterfaceUsuario(this);
            /*Interface.DatosDRegistroPagos(dtPagoEmp, txNombr.Text, txDes.Text, txPrecUn.Text, txCant.Text, txSubTot.Text, txTot.Text, "1", "1","");
            datos = "NOMBRE: " + txNombr.Text + "\nDESCRIPCIÓN: " + txDes.Text + "\nPRECIO UNITARIO: " + txPrecUn.Text + "\nCANTIDAD: " + txCant.Text +
                "\nSUBTOTAL: " + txSubTot.Text + "\nTOTAL: " + txTot.Text + "\nESTADO: EN PROCESO" + "\nREGISTRADO: SÍ";*/
        }
        private void RHumanosPagosEmpleado_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(753, 503);
            ActualizarData();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            ActualizarData2();
            DialogResult result = MessageBox.Show("Hay pagos pendientes por efectuar, ¿Desea ir a la pantalla Administración de pagos?",
                "Pago registrado", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    this.WindowState = FormWindowState.Minimized;
                    FinanzasRealizarPago frp = new FinanzasRealizarPago(datos,"");
                    frp.Show();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1164, 503);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            subtotl = (Convert.ToInt32(txPrecUn.Text) * Convert.ToInt32(txCant.Text)).ToString();
            totl = ((Convert.ToInt32(subtotl) * 0.16) + Convert.ToInt32(subtotl)).ToString();
            txSubTot.Text = subtotl;
            txTot.Text = totl;
        }
    }
}
