﻿using Presentacion.Configuracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Laboratorio
{
    public partial class PantallaMenuLaboratorio : Control.Pantalla
    {
        InterfaceUsuario Interface { get; set; }

        public PantallaMenuLaboratorio()
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Control_Pedidos.PantallaMenuControlPedidos pmp = new Control_Pedidos.PantallaMenuControlPedidos(PantallaMenuPrincipal.Sesion.Login);
            pmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaPedidoFabricar ppf = new PantallaPedidoFabricar(PantallaMenuPrincipal.Sesion.Login);
            ppf.ShowDialog();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaAdministrarMateriales)))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaAdministrarMateriales();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaAdministrarProducto)))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaAdministrarProductos();
            }
        }

    }
}
