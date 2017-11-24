using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Validaciones;
using static Validaciones.Validar;

namespace Presentacion.Recepcion
{
    public partial class PantallaDentista : Control.Pantalla
    {
        public bool AceptarCambios { get; set; }
        protected InterfaceUsuario Interface { get; set; }
        protected string[] México;
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
            tbCedula.Text = Dentista.Cedula;
            tbRFC.Text = Dentista.RFC;
            tbNombreDentista.Text = Dentista.Nombre;
            tbApellidos.Text = Dentista.Apellidos;
            tbTelefono.Text = Dentista.TelOficina;
            cbPais.Text = Dentista.Pais;
            cbEstado.Text = Dentista.Estado;
            cbMunicipio.Text = Dentista.Municipio;
            cbCiudad.Text = Dentista.Ciudad;
            tbColonia.Text = Dentista.Colonia;
            tbCalle.Text = Dentista.Direccion;
            tbCP.Text = Dentista.CodPos;
            tbEmail.Text = Dentista.Email.Split('@')[0];
            cbEmail.Text = Dentista.Email.Split('@')[1];
        }

        public virtual void InitializeComponent3()
        {
            México = Properties.Resources.Ciudades.Split('\n');
            Validacion = new Validar(this);
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].GetType() == typeof(ComboBox))
                    Controls[i].KeyPress += Mayusculas;
            }
            cbPais.SelectedIndexChanged += cbPaises_SelectedChanged;
            cbEstado.SelectedIndexChanged += cbEstado_SelectedIndexChanged;
            cbMunicipio.SelectedIndexChanged += cbMunicipio_SelectedIndexChanged;
        }

        public string Cedula { get { return tbCedula.Text; } }

        public virtual RegistroDentista ObtenerRegistroDentista
        {
            get
            {
                return
                    new RegistroDentista
                    (
                        tbCedula.Text,
                        tbRFC.Text,
                        tbNombreDentista.Text,
                        tbApellidos.Text,
                        tbTelefono.Text,
                        cbPais.Text,
                        cbEstado.Text,
                        cbMunicipio.Text,
                        cbCiudad.Text,
                        tbColonia.Text,
                        tbCalle.Text,
                        tbCP.Text,
                        tbEmail.Text + "@" + cbEmail.Text,
                        "1",
                        tbConsultorio.Text,
                        DateTime.Now
                        );
            }
        }

        protected bool FaltanCampos
        {
            get
            {
                bool Faltan = false;
                Faltan = Validacion.ValidarTextBox(tbCedula, tbRFC, tbNombreDentista, tbApellidos, tbColonia, tbCalle, tbConsultorio, tbEmail) || Faltan;
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

        private void cbPaises_SelectedChanged(object sender, EventArgs e)
        {
            cbEstado.Items.Clear();
            cbMunicipio.Items.Clear();
            cbCiudad.Items.Clear();
            cbEstado.Text = cbMunicipio.Text = cbCiudad.Text = "";
            if (cbPais.Text == "MÉXICO")
            {
                for (int i = 0; i < México.Length; i++)
                {
                    string[] temp = México[i].ToUpper().Split('\t');
                    if (!cbEstado.Items.Contains(temp[0]))
                    {
                        cbEstado.Items.Add(temp[0]);
                    }
                }
                tbCP.Mask = "00000";
            }
            else
            {
                cbEstado.Items.Add(Capitales[cbPais.SelectedIndex]);
                if (cbPais.Text == "ESTADOS UNIDOS")
                {
                    tbCP.Mask = "00000";
                }
                else
                {
                    if (cbPais.Text == "CANADÁ")
                    {
                        tbCP.Mask = ">L0>L0>L0";
                    }
                    else
                    {
                        tbCP.Mask = ">a>a>a>a>a>a>a>a>a>a";
                    }
                }
            }
            cbEstado.SelectedIndex = 0;

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMunicipio.Items.Clear();
            cbCiudad.Items.Clear();
            cbMunicipio.Text = cbCiudad.Text = "";
            if (cbPais.Text == "MÉXICO")
            {
                for (int i = 0; i < México.Length; i++)
                {
                    string[] temp = México[i].ToUpper().Split('\t');
                    if (cbEstado.Text == temp[0])
                        if (!cbMunicipio.Items.Contains(temp[1]))
                        {
                            cbMunicipio.Items.Add(temp[1]);
                        }
                }
                cbMunicipio.SelectedIndex = 0;
            }
        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCiudad.Items.Clear();
            cbCiudad.Text = "";
            if (cbPais.Text == "MÉXICO")
            {
                for (int i = 0; i < México.Length; i++)
                {
                    string[] temp = México[i].ToUpper().Split('\t');
                    if (cbEstado.Text == temp[0])
                        if (cbMunicipio.Text == temp[1])
                            if (!cbCiudad.Items.Contains(temp[2]))
                            {
                                cbCiudad.Items.Add(temp[2]);
                            }
                }
                cbCiudad.SelectedIndex = -1;
            }
        }
    }
}
