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
    public partial class PantallaAgregarDentista : Presentacion.Recepcion.PantallaDentista
    {

        public PantallaAgregarDentista()
        {
            InitializeComponent();
            InitializeComponent3();
        }

        public PantallaAgregarDentista(RegistroDentista Dentista) : base(Dentista)
        {
            InitializeComponent();
            InitializeComponent3();
            AceptarCambios = false;
            tbCedula.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!FaltanCampos)
            {
                Interface = new InterfaceUsuario(this);
                RegistroDentista t = ObtenerRegistroDentista, Encontrado = Interface.ObtenerUnDentista(tbCedula.Text);
                if (Interface.RegistrarDentista(t) && Encontrado?.Cedula != tbCedula.Text)
                {
                    MessageBox.Show("Dentista registrado correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AceptarCambios = true;
                    Close();
                }
                else
                {
                    if (tbCedula.Text == Encontrado?.Cedula)
                    {
                        Validar.MensajeErrorOK("Cedula registrada anteriormente, favor de cambiarla");
                    }
                    else
                    {
                        Validar.MensajeErrorBaseDeDatos();
                    }
                }
            }
        }
    }
}
