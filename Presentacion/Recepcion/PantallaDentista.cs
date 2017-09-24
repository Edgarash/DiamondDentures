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
    public partial class PantallaDentista : Control.Pantalla
    {
        public bool AceptarCambios { get; set; }
        protected InterfaceUsuario Interface { get; set; }
        Validar Validacion;
        public PantallaDentista()
        {
            InitializeComponent();
            InitializeComponent2();
        }

        public PantallaDentista(RegistroDentista Dentista):this()
        {
            InitializeComponent4(Dentista);
        }

        protected virtual void InitializeComponent4(RegistroDentista Dentista)
        {
            tbCedula.Enabled = false;
            tbCedula.Text = Dentista?.Cedula;
            tbRFC.Text = Dentista?.RFC;
            tbNombreDentista.Text = Dentista?.Nombre;
            tbApellidos.Text = Dentista?.Apellidos;
            tbTelefono.Text = Dentista?.Telefono;
            cbPais.Text = Dentista?.Pais;
            cbEstado.Text = Dentista?.Estado;
            cbMunicipio.Text = Dentista?.Municipio;
            cbCiudad.Text = Dentista?.Ciudad;
            tbColonia.Text = Dentista?.Colonia;
            tbCalle.Text = Dentista?.Calle;
            tbNumFrente.Text = Dentista?.NumFrente;
            tbCP.Text = Dentista?.CP;
            tbEmail.Text = Dentista?.Email?.Split('@')[0];
            cbEmail.Text = Dentista?.Email?.Split('@')[1];
        }

        public virtual void InitializeComponent3()
        {
            Validacion = new Validar(this);
        }

        public string Cedula { get { return tbCedula.Text; } }

        public virtual RegistroDentista ObtenerRegistroDentista
        {
            get
            {
                return new RegistroDentista(tbCedula.Text, tbRFC.Text, tbNombreDentista.Text, tbApellidos.Text, ObtenerTelefono, cbPais.Text,
                    cbEstado.Text, cbMunicipio.Text, cbCiudad.Text, tbColonia.Text, tbCalle.Text, tbNumFrente.Text, tbCP.Text,
                    tbEmail.Text + "@" + cbEmail.Text);
            }
        }

        protected bool FaltanCampos
        {
            get
            {
                bool Faltan = false;
                Faltan = Validacion.ValidarTextBox(tbCedula, tbRFC, tbNombreDentista, tbApellidos, tbColonia, tbCalle, tbNumFrente, tbEmail) || Faltan;
                Faltan = Validacion.ValidarMaskedTextBox(tbTelefono) || Faltan;
                Faltan = Validacion.ValidarComboBox(cbEstado, cbMunicipio, cbCiudad, cbEmail, cbPais) || Faltan;
                return Faltan;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected string ObtenerTelefono
        {
            get
            {
                string temp = "";
                for (int i = 0; i < tbTelefono.Text.Length; i++)
                {
                    if (char.IsDigit(tbTelefono.Text[i]))
                    {
                        temp += tbTelefono.Text[i];
                    }
                }
                return temp;
            }
        }
    }
}
