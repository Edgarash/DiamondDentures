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
using Validaciones;


namespace Presentacion.Finanzas
{
    public partial class FinanzasVentas : Control.Pantalla
    {
        InterfaceUsuario Interface;
        string fec = "";
        public FinanzasVentas()
        {
            InitializeComponent();
        }
        protected override void btnMouseLeft(object sender, EventArgs e)
        {
            base.btnMouseLeft(sender, e);
        }

        protected override void btnMouseOver(object sender, EventArgs e)
        {
            base.btnMouseOver(sender, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            fec = cbAño.Text + "-" + cbMes.Text;
            Interface.DatosDVentas(dtVentas, fec);
            Interface.DatosDTotalVentas(txTotal);
        }
        private void ActualizarData7()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosDBuscarVentas(dtVentas,tbBuscar.Text,tbBuscar.Text);
        }

        private void FinanzasVentasGeneradas_Load(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarData7();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarData7();
        }

        private void btnGenRep_Click(object sender, EventArgs e)
        {
            string fecha = $"{cbAño.SelectedItem}/01/01";
            DateTime fchi = DateTime.Parse(fecha).AddMonths(Convert.ToInt32(cbMes.SelectedItem) - 1);
            DateTime fchf = (fchi.AddMonths(1)).AddDays(-1);

            ParametroReporte FchI = new ParametroReporte("FchIni", fchi);
            ParametroReporte FchF = new ParametroReporte("FchFin", fchf);

            ManejadorReportes.MostrarPantalla(this, new PantallaVPListadoFec<ReporteVentas>("Ventas", FchI, FchF));
        }
    }
}
