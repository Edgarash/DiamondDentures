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
                RegistroDentista temp;
                if (!Interface.ObtenerUnDentista(tbCedula.Text, out temp))
                {
                    if (Interface.RegistrarDentista(ObtenerRegistroDentista))
                    {
                        MessageBox.Show("Dentista registrado correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AceptarCambios = true;
                        LlamarEventoCerrar();
                        Close();
                    }
                    else
                    {
                        Validar.MensajeErrorBaseDeDatos();
                    }
                }
                else
                {
                    Validar.MensajeErrorOK("Cédula registrada anteriormente con el nombre\n\n" + temp.NombreCompleto);
                }
            }
        }
    }
}
