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
    public partial class PantallaModificarDentista : Presentacion.Recepcion.PantallaDentista
    {
        
        public PantallaModificarDentista(RegistroDentista Dentista)
        {
            InitializeComponent();
            InitializeComponent2();
            InitializeComponent3();
            InitializeComponent4(Dentista);
            AceptarCambios = false;
        }

        protected override void InitializeComponent4(RegistroDentista Dentista)
        {
            tbCedula.Enabled = false;
            tbCedula.Text = Dentista?.Cedula;
            tbRFC.Text = Dentista?.RFC;
            tbNombreDentista.Text = Dentista?.Nombre;
            tbApellidos.Text = Dentista?.Apellidos;
            tbTelefono.Text = Dentista?.TelOficina;
            cbPais.Text = Dentista?.Pais;
            cbEstado.Text = Dentista?.Estado;
            cbMunicipio.Text = Dentista?.Municipio;
            cbCiudad.Text = Dentista?.Ciudad;
            tbColonia.Text = Dentista?.Colonia;
            tbCalle.Text = Dentista?.Direccion;
            tbCP.Text = Dentista?.CodPos;
            tbEmail.Text = Dentista?.Email?.Split('@')[0];
            cbEmail.Text = Dentista?.Email?.Split('@')[1];
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!FaltanCampos)
            {
                Interface = new InterfaceUsuario(this);
                if (Interface.ActualizarDentista(ObtenerRegistroDentista))
                {
                    MessageBox.Show("Dentista acutalizado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AceptarCambios = true;
                    Close();
                }
                else
                    Validar.MensajeErrorBaseDeDatos();
            }
        }
    }
}
