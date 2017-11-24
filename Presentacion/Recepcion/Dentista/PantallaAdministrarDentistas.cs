using Entidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Recepcion
{
    public partial class PantallaAdministrarDentistas : Control.Pantalla
    {
        InterfaceUsuario Interface;
        enum Busqueda { Total, Clave, Personalizada }
        Validar Validar;
        public PantallaAdministrarDentistas()
        {
            InitializeComponent();
            Interface = new InterfaceUsuario(this);
            LlenarData(Busqueda.Total);
            Validar = new Validar(this);
            InitializeComponent2();
        }

        private void btnBuscarClave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCedula.Text)
                && string.IsNullOrWhiteSpace(tbNombre.Text)
                && string.IsNullOrWhiteSpace(tbApellidos.Text)
                && string.IsNullOrWhiteSpace(tbRFC.Text))
            {
                LlenarData(Busqueda.Total);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(tbCedula.Text))
                {
                    LlenarData(Busqueda.Clave);
                    tbCedula.Focus();
                }
                else
                {
                    LlenarData(Busqueda.Personalizada);
                    tbRFC.Focus();
                }
            }
        }

        private void LlenarData(Busqueda Tipo)
        {
            RegistroDentista[] Dentistas;
            InterfaceUsuario.ObtenerDentistas(out Dentistas);
            dgvDentistas.Rows.Clear();
            switch (Tipo)
            {
                case Busqueda.Total:
                    LlenarData(Dentistas);
                    break;
                case Busqueda.Clave:
                    List<RegistroDentista> temp = new List<RegistroDentista>();
                    for (int i = 0; i < Dentistas.Length; i++)
                    {
                        if (Dentistas[i].Cedula.Contains(tbCedula.Text))
                        {
                            temp.Add(Dentistas[i]);
                        }
                    }
                    LlenarData(temp.ToArray());
                    break;
                case Busqueda.Personalizada:
                    temp = new List<RegistroDentista>();
                    for (int i = 0; i < Dentistas.Length; i++)
                    {
                        if (Dentistas[i].Nombre.Contains(tbNombre.Text)
                            && Dentistas[i].Apellidos.Contains(tbApellidos.Text)
                            && Dentistas[i].RFC.Contains(tbRFC.Text))
                            temp.Add(Dentistas[i]);
                    }
                    LlenarData(temp.ToArray());
                    break;
            }
        }

        private void LlenarData(RegistroDentista[] Dentistas)
        {
            dgvDentistas.RowCount = Dentistas.Length;
            for (int i = 0; i < Dentistas.Length; i++)
            {
                dgvDentistas["Cedula", i].Value = Dentistas[i].Cedula;
                dgvDentistas["RFC", i].Value = Dentistas[i].RFC;
                dgvDentistas["Nombre", i].Value = Dentistas[i].Nombre;
                dgvDentistas["Apellidos", i].Value = Dentistas[i].Apellidos;
                if (Dentistas[i].Activo == "0")
                    dgvDentistas.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightSalmon;
            }
        }

        private void btnAgregarDentista_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaAgregarDentista)))
            {
                Interface.DesplegarPantallaAgregarDentista(LlenarData);
            }
        }

        private void LlenarData()
        {
            LlenarData(Busqueda.Total);
        }

        private void btnModificarDentista_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(typeof(PantallaModificarDentista)))
            {
                if (dgvDentistas.SelectedRows.Count > 0)
                {
                    RegistroDentista Dentista;
                    Interface.ObtenerUnDentista(dgvDentistas["Cedula", dgvDentistas.CurrentRow.Index].Value.ToString(), out Dentista);
                    Interface.DesplegarPantallaModificarDentista(Dentista, LlenarData);
                }
            }
        }

        private void btnEliminarDentista_Click(object sender, EventArgs e)
        {
            if (dgvDentistas.SelectedRows.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("¿Realmente desea borrar este dentista?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                {
                    if (InterfaceUsuario.EliminarDentista(dgvDentistas["Cedula", dgvDentistas.CurrentRow.Index].Value.ToString()))
                        Validar.MensajeInfo("Dentista eliminado con éxito");
                    LlenarData();
                }
            }
        }
    }
}
