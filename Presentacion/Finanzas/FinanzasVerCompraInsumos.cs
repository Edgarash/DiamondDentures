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
    public partial class FinanzasVerCompraInsumos : Control.Pantalla
    {
        InterfaceUsuario Interface;
        string datos = "", subtotl = "", totl = "", fec = "";
        public FinanzasVerCompraInsumos()
        {
            InitializeComponent();
        }
        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            fec = cbAño.Text + "-" + cbMes.Text;
            Interface.DatosDInsumos(dtInsumos);
            Interface.DatosDTotalInsumos(txTotal);
        }
        private void ActualizarData2()
        {
            Interface = new InterfaceUsuario(this);
            subtotl = (Convert.ToInt32(txPrecUn.Text) * Convert.ToInt32(txCant.Text)).ToString();
            totl = ((Convert.ToInt32(subtotl) * 0.16) + Convert.ToInt32(subtotl)).ToString();
            txSubTot.Text = subtotl;
            txTot.Text = totl;
            Interface.DatosDRegistroPagos(dtInsumos, txNombr.Text, txDes.Text, txPrecUn.Text, txCant.Text, txSubTot.Text, txTot.Text, "1", "1", fec);
            datos = "NOMBRE: " + txNombr.Text + "\nDESCRIPCIÓN: " + txDes.Text + "\nPRECIO UNITARIO: " + txPrecUn.Text + "\nCANTIDAD: " + txCant.Text +
                "\nSUBTOTAL: " + txSubTot.Text + "\nTOTAL: " + txTot.Text + "\nESTADO: EN PROCESO" + "\nREGISTRADO: SÍ";
        }
        private void FinanzasVerCompraInsumos_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(894, 468);
            ActualizarData();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            subtotl = (Convert.ToInt32(txPrecUn.Text) * Convert.ToInt32(txCant.Text)).ToString();
            totl = ((Convert.ToInt32(subtotl) * 0.16) + Convert.ToInt32(subtotl)).ToString();
            txSubTot.Text = subtotl;
            txTot.Text = totl;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(1276, 425);
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
                    FinanzasRealizarPago frp = new FinanzasRealizarPago(datos);
                    frp.Show();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
