﻿using System;
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
    public partial class FinanzasVerCompraInsumos : Control.Pantalla
    {
        InterfaceUsuario Interface;
        string datos = "", subtotl = "", totl = "", fec = "";
        public FinanzasVerCompraInsumos()
        {
            InitializeComponent();
        }

        private void btnGenRep_Click(object sender, EventArgs e)
        {
            string fecha = $"{cbAño.SelectedItem}/01/01";
            DateTime fchi = DateTime.Parse(fecha).AddMonths(Convert.ToInt32(cbMes.SelectedItem) - 1);
            DateTime fchf = (fchi.AddMonths(1)).AddDays(-1);

            ParametroReporte FchI = new ParametroReporte("fchi", fchi);
            ParametroReporte FchF = new ParametroReporte("fchf", fchf);

            ManejadorReportes.MostrarPantalla(this, new PantallaVPListadoFec<ReporteInsumosComprados>("Compra Insumos", FchI, FchF));
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
