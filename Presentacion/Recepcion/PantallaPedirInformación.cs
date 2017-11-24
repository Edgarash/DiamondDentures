using Control;
using ControlesM;
using Entidad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presentacion.Ventas;
using Presentacion.Ventas.Entregas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Recepcion
{
    public enum BotonOpcional { NoPagados, NoEntregados }
    public partial class PantallaPedirInformación : Control.Pantalla
    {
        Validar Validacion;
        public PantallaPedirInformación()
        {
            InitializeComponent();
        }

        public RegistroProducto PedirProducto(out bool Cancelado)
        {
            InterfaceUsuario Interface = new InterfaceUsuario(this);
            Validacion = new Validar(this);
            pbIcono.BackgroundImage = Properties.Resources.IconoProceso;
            tbNumEmpleado.MaxLength = 8;
            lblInfo.Text = "Ingrese clave del producto a eliminar";
            Text = lblPedir.Text = lblTitulo.Text = "#Producto";
            AlinearCentroHorizontal(lblInfo, lblPedir);
            bool Cerrado = true;
            tbNumEmpleado.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 13 || e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    if (!Validacion.ValidarTextBox(tbNumEmpleado))
                    {
                        Close();
                        Cerrado = false;
                    }
                    if (e.KeyChar == Convert.ToChar(Keys.Escape))
                    {
                        Close();
                        Cerrado = true;
                    }
                }
                else
                {
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                        e.Handled = true;
                }
            };
            ShowDialog();
            Cancelado = Cerrado;
            RegistroProducto temp = null;
            if (!Cerrado)
                InterfaceUsuario.ObtenerUnProducto(Convert.ToInt32(tbNumEmpleado.Text), out temp);
            return temp;
        }

        public static RegistroPedido PedirUnPedido(out bool Cancelado)
        {
            PantallaPedirInformación x = new PantallaPedirInformación();
            return x.PedirPedido(out Cancelado);
        }

        public static RegistroPedido PedirUnPedidoBotonVerPedidos(out bool Cancelado, BotonOpcional Tipo)
        {
            PantallaPedirInformación x = new PantallaPedirInformación();
            x.AgregarBoton(Tipo);
            return x.PedirPedido(out Cancelado);
        }

        public RegistroMaterial PedirMaterial(out bool Cancelado)
        {
            InterfaceUsuario Interface = new InterfaceUsuario(this);
            Validacion = new Validar(this);
            pbIcono.BackgroundImage = Properties.Resources.IconoMaterial;
            tbNumEmpleado.MaxLength = 8;
            lblInfo.Text = "Ingrese clave del material a eliminar";
            Text = lblPedir.Text = lblTitulo.Text = "#material";
            AlinearCentroHorizontal(lblInfo, lblPedir);
            bool Cerrado = true;
            tbNumEmpleado.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 13 || e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    if (!Validacion.ValidarTextBox(tbNumEmpleado))
                    {
                        Close();
                        Cerrado = false;
                    }
                    if (e.KeyChar == Convert.ToChar(Keys.Escape))
                    {
                        Close();
                        Cerrado = true;
                    }
                }
                else
                {
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                        e.Handled = true;
                }
            };
            ShowDialog();
            Cancelado = Cerrado;
            RegistroMaterial temp = null;
            if (!Cerrado)
                temp = new ManejadorRegistroMaterial().ObtenerUnMaterial(Convert.ToInt32(tbNumEmpleado.Text));
            return temp;
        }

        public RegistroPedido PedirPedido(out bool Cancelado)
        {
            InterfaceUsuario Interface = new InterfaceUsuario(this);
            Validacion = new Validar(this);
            tbNumEmpleado.MaxLength = 10;
            bool Cerrado = true;
            tbNumEmpleado.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 13 || e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    if (!Validacion.ValidarTextBox(tbNumEmpleado))
                    {
                        Close();
                        Cerrado = false;
                    }
                    if (e.KeyChar == Convert.ToChar(Keys.Escape))
                    {
                        Close();
                        Cerrado = true;
                    }
                }
            };
            ShowDialog();
            Cancelado = Cerrado;
            RegistroPedido temp = null;
            if (!Cerrado)
                temp = Interface.ObtenerUnPedido(tbNumEmpleado.Text);
            return temp;
        }

        public RegistroDentista PedirDentista(out bool Cancelado)
        {
            InterfaceUsuario Interface = new InterfaceUsuario(this);
            Validacion = new Validar(this);
            pbIcono.BackgroundImage = Properties.Resources.IconoDentista;
            tbNumEmpleado.MaxLength = 10;
            lblInfo.Text = "Ingrese clave del dentista a modificar";
            Text = lblPedir.Text = lblTitulo.Text = "Cédula Dentista";
            AlinearCentroHorizontal(lblInfo, lblPedir);
            bool Cerrado = true;
            tbNumEmpleado.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 13 || e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    if (!Validacion.ValidarTextBox(tbNumEmpleado))
                    {
                        Close();
                        Cerrado = false;
                    }
                    if (e.KeyChar == Convert.ToChar(Keys.Escape))
                    {
                        Close();
                        Cerrado = true;
                    }
                }
            };
            ShowDialog();
            Cancelado = Cerrado;
            RegistroDentista temp = null;
            if (!Cerrado)
                temp = Interface.ObtenerUnDentista(tbNumEmpleado.Text);
            return temp;
        }

        private void AgregarBoton(BotonOpcional Tipo)
        {
            KuroButton temp = new KuroButton();
            temp.Text = "Ver Pedidos";
            switch (Tipo)
            {
                case BotonOpcional.NoPagados:
                    temp.Click += delegate (object sender, EventArgs e)
                     {
                         MostrarPantalla(new PantallaPedidosNoPagados());
                     };
                    break;
                case BotonOpcional.NoEntregados:
                    temp.Click += delegate (object sender, EventArgs e)
                      {
                          MostrarPantalla(new PantallaPedidosNoEntregados());
                      };
                    break;
            }
            Encabezado.Controls.Add(temp);
            temp.Size = new Size(120, 50);
            temp.Location = new Point(371, 23);
        }

        private void MostrarPantalla(Form Pantalla)
        {
            Hide();
            Pantalla.ShowDialog();
            Close();
        }
    }
}
