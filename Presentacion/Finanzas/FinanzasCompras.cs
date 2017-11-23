﻿using System;
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
    public partial class FinanzasCompras : Control.Pantalla
    {
        InterfaceUsuario Interface;
        string datos = "", subtotl = "", totl = "", fec = "";
        int r = 0;
        public FinanzasCompras()
        {
            InitializeComponent();
        }
        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            fec = cbAño.Text + "-" + cbMes.Text;
            Interface.DatosDGastos(dtGastos, fec);
            Interface.DatosDTotalGastos(txTotal);
        }

        private void FinanzasGastos_Load(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            ActualizarData();
        }
    }
}
