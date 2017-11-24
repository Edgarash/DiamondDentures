using Control;
using Entidad;
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
    public partial class PantallaPedido : Pantalla
    {

        protected InterfaceUsuario Interface;
        protected bool AgregarDentista { get; set; }
        Timer Temporizador = new Timer();
        Validar Validacion;
        bool TemporizadorEjecutando = false;

        protected Trabajo[] Trabajos = new Trabajo[10];
        RegistroProducto[] Productos;
        RegistroProMat[] ProMat;
        protected RegistroMaterial[] Materiales { get; set; }
        ErrorProvider[] ParaTra = new ErrorProvider[10];
        public PantallaPedido()
        {
            InitializeComponent();
            InitializeComponent2();
            tbFecha.Text = DateTime.Now.ToString();
            Validacion = new Validar(this);
            tbCedula.LostFocus += TbCedula_LostFocus;
            AgregarDentista = true;
        }

        private void Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            for (; i < Trabajos.Length; i++)
                if (sender.Equals(Trabajos[i].Producto))
                    break;
            Trabajos[i].Material2.Visible = false;
            Trabajos[i].Material1.Visible = true;
            Trabajos[i].PrecioProducto.Visible = false;
            Trabajos[i].FechadeEntrega.Visible = false;
            Trabajos[i].Precio = 0;
            Trabajos[i].Terminado = false;
            Trabajos[i].Material1.Items.Clear();
            for (int j = 0; j < ProMat.Length; j++)
                if (Trabajos[i].Producto.Text == ProMat[j].Producto.Nombre)
                    Trabajos[i].Material1.Items.Add(ProMat[j].Material.Nombre);
            CalcularPrecio();
        }

        private void TbCedula_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCedula.Text))
            {
                RegistroDentista temp;
                Interface.ObtenerUnDentista(tbCedula.Text, out temp);
                if (temp == null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Dentista no registrado\n\nEs necesario para poder continuar", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        if (Validar.ValidarUnaPantalla(typeof(PantallaAgregarDentista)))
                        {
                            PantallaAgregarDentista te = new PantallaAgregarDentista();
                            Hide();
                            te.ShowDialog();
                            Show();
                        }
                    }
                }
                else
                {
                    btnDentista.BackgroundImage = Presentacion.Properties.Resources.IconoDentistaModificar;
                    lblMostrarDireccion.Text = temp.Consultorio + " " + temp.Direccion + " " + temp.Colonia;
                    lblMostrarNombreDentista.Text = temp.NombreCompleto;
                    lblMostrarRFC.Text = temp.RFC;
                    AgregarDentista = false;
                }
            }
        }

        private void btnDentista_Click(object sender, EventArgs e)
        {
            if (AgregarDentista)
            {
                if (!Validar.ValidarUnaPantalla(typeof(PantallaAgregarDentista)))
                {
                    PantallaAgregarDentista te = new PantallaAgregarDentista();
                    Hide();
                    te.ShowDialog();
                    Show();
                }
            }
            else
            {
                RegistroDentista temp;
                Interface.ObtenerUnDentista(tbCedula.Text, out temp);
                new InterfaceUsuario(this).DesplegarPantallaModificarDentista(temp, ActualizarInfoDentista);
            }
        }

        private void ActualizarInfoDentista()
        {
            TbCedula_LostFocus(tbCedula, new EventArgs());
        }

        protected virtual void InitializeComponent3()
        {
            Interface = new InterfaceUsuario(this);
            RegistroProducto[] t;
            InterfaceUsuario.ObtenerProductos(out t);
            Productos = t;
            Materiales = Interface.ObtenerMateriales();
            ProMat = InterfaceUsuario.ObtenerProMat();
            int x = 5, y = 5;
            for (int i = 0; i < Trabajos.Length; i++)
            {
                ParaTra[i] = new ErrorProvider();
                Trabajos[i] = new Trabajo();
                Trabajos[i].Location = new Point(x, y);
                y += 35;
                Trabajos[i].Visible = i < (int)nudTrabajos.Value;
                Trabajos[i].Producto.SelectedIndexChanged += Producto_SelectedIndexChanged;
                Trabajos[i].Material1.SelectedIndexChanged += Material1_SelectedIndexChanged;
                Trabajos[i].Material2.SelectedIndexChanged += Material2_SelectedIndexChanged;
                for (int j = 0; j < t.Length; j++)
                    Trabajos[i].Producto.Items.Add(t[j].Nombre);
                Panel.Controls.Add(Trabajos[i]);
            }
        }

        private void Material2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            for (; i < Trabajos.Length; i++)
                if (sender.Equals(Trabajos[i].Material2))
                    break;
            float Precio = 0;
            int Dias = 0;
            for (int j = 0; j < ProMat.Length; j++)
            {
                if (Trabajos[i].Producto.Text == ProMat[j].Producto.Nombre)
                {
                    if (Trabajos[i].Material1.Text == ProMat[j].Material.Nombre)
                    {
                        Precio += ProMat[j].PrecioFinal;
                        Dias += ProMat[j].TiempoFinal;
                    }
                    if (Trabajos[i].Material2.Text == ProMat[j].Material.Nombre)
                    {
                        Precio += ProMat[j].PrecioFinal;
                        Dias += ProMat[j].TiempoFinal;
                    }
                }
            }
            Trabajos[i].Precio = Precio;
            Trabajos[i].Fecha = DateTime.Now.AddDays(Dias);
            Trabajos[i].PrecioProducto.Text = Precio.ToString("C2");
            Trabajos[i].FechadeEntrega.Text = Trabajos[i].Fecha.ToShortDateString();
            CalcularPrecio();
            FechaPedido();
        }

        private void Material1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            for (; i < Trabajos.Length; i++)
                if (sender.Equals(Trabajos[i].Material1))
                    break;
            Trabajos[i].Material2.Visible = true;
            Trabajos[i].PrecioProducto.Visible = true;
            Trabajos[i].FechadeEntrega.Visible = true;
            Trabajos[i].Material2.Items.Clear();
            for (int j = 0; j < ProMat.Length; j++)
            {
                if (Trabajos[i].Producto.Text == ProMat[j].Producto.Nombre)
                {
                    if (Trabajos[i].Material1.Text != ProMat[j].Material.Nombre)
                        Trabajos[i].Material2.Items.Add(ProMat[j].Material.Nombre);
                    else
                    {
                        Trabajos[i].Precio = ProMat[j].PrecioFinal;
                        Trabajos[i].Fecha = DateTime.Now.AddDays(ProMat[j].TiempoFinal);
                        Trabajos[i].PrecioProducto.Text = ProMat[j].PrecioFinal.ToString("C2");
                        Trabajos[i].FechadeEntrega.Text = Trabajos[i].Fecha.ToShortDateString();
                        Trabajos[i].Terminado = true;
                    }
                }
            }
            CalcularPrecio();
            FechaPedido();
        }

        protected override void InitializeComponent2()
        {
            base.InitializeComponent2();

            Temporizador = new Timer();
            Temporizador.Interval += 1000;
            Temporizador.Tick += new EventHandler(delegate (object sender, EventArgs e)
            {
                tbFecha.Text = DateTime.Now.ToString();
            });
        }

        protected bool ActualizarFecha
        {
            get { return TemporizadorEjecutando; }
            set
            {
                if (value)
                {
                    Temporizador.Start();
                }
                else
                {
                    Temporizador.Stop();
                }
                TemporizadorEjecutando = value;
            }
        }

        protected RegistroPedido ObtenerPedido
        {
            get
            {
                return new RegistroPedido(tbClave.Text, Login.PantallaLogin.Sesión,
                    new RegistroDentista(tbCedula.Text), 1, DateTime.Now, FechaFinalEntrega,
                    new DateTime(), null, tbUrgente.Checked ? "1" : "0", PrecioFinal, null, null, PrecioFinal, ObtenerTrabajo);
            }
        }

        protected virtual bool FaltanCampos
        {
            get
            {
                bool Faltan = false;
                Faltan = Validacion.ValidarTextBox(tbClave, tbCedula) || Faltan;
                for (int i = 0; i < (int)nudTrabajos.Value; i++)
                {
                    if (Trabajos[i].Terminado)
                    {
                        ParaTra[i].SetError(Trabajos[i].Producto, "");
                        ParaTra[i].Clear();
                    }
                    else
                    {
                        ParaTra[i].SetIconAlignment(Trabajos[i].Producto, ErrorIconAlignment.MiddleRight);
                        ParaTra[i].SetError(Trabajos[i].Producto, "No se ha terminado este campo");
                        Faltan = true;
                    }
                }
                return Faltan;
            }
        }

        protected virtual RegistroTrabajo[] ObtenerTrabajo
        {
            get
            {
                RegistroTrabajo[] temp = new RegistroTrabajo[(int)nudTrabajos.Value];
                for (int i = 0; i < (int)nudTrabajos.Value; i++)
                {
                    int j = 0;
                    for (; j < Productos.Length; j++)
                        if (Productos[j].Nombre == Trabajos[i].Producto.Text)
                            break;
                    int k = 0;
                    for (; k < Materiales.Length; k++)
                        if (Materiales[k].Nombre == Trabajos[i].Material1.Text)
                            break;
                    int l = 0;
                    bool Encontrado = false;
                    if (Trabajos[i].Material2.SelectedIndex != -1)
                        for (; l < Materiales.Length; l++)
                            if (Materiales[l].Nombre == Trabajos[i].Material2.Text)
                            {
                                Encontrado = true;
                                break;
                            }
                    temp[i] = new RegistroTrabajo(tbClave.Text, Productos[j], Materiales[k], Encontrado ? Materiales[l] : null);
                }
                return temp;
            }
        }

        protected float PrecioFinal { get; set; }

        private void CalcularPrecio()
        {
            float Precio = 0;
            for (int i = 0; i < Trabajos.Length; i++)
            {
                Precio += Trabajos[i].Precio;
            }
            lblTotal.Text = Precio.ToString("C2");
            PrecioFinal = Precio;
        }

        protected DateTime FechaFinalEntrega { get; set; }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void PrecioPedido()
        {
            float Precio = 0;
            RegistroTrabajo[] temp = ObtenerTrabajo;
            for (int i = 0; i < temp.Length; i++)
                Precio += temp[i].Total;
            lblTotal.Text = "$" + Precio.ToString("N2");
        }

        protected void FechaPedido()
        {
            DateTime x;
            x = Trabajos[0].Fecha;
            for (int i = 1; i < Trabajos.Length; i++)
                if (x < Trabajos[i].Fecha)
                    x = Trabajos[i].Fecha;
            lblFechaProbable.Text = x.ToShortDateString();
            FechaFinalEntrega = x;
        }

        private void nudTrabajos_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Trabajos.Length; i++)
                Trabajos[i].Visible = i < (int)nudTrabajos.Value;
        }
    }
}