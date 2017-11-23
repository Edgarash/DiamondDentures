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
        private void FinanzasVerCompraInsumos_Load(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarData();
        }
    }
}
