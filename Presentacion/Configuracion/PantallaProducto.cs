using System;
using Entidad;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Validaciones;
using Control;

namespace Presentacion.Configuracion
{
    public partial class PantallaProducto : Pantalla
    {
        protected Validar Validacion;
        protected InterfaceUsuario Interface;

        public PantallaProducto()
        {
            InitializeComponent();
            InitializeComponent2();
        }

        protected virtual void InitializeComponent3()
        {
            Validacion = new Validar(this);
            Interface = new InterfaceUsuario(this);
        }

        protected bool ValidarCampos
        {
            get
            {
                bool Vacio = false;
                Vacio = Validacion.ValidarTextBox(tbPrecio, tbClave, tbNombre) || Vacio;
                return Vacio;
            }
        }

        protected RegistroProducto ObtenerRegistro
        {
            //get { return new RegistroProducto(0, tbNombre.Text, (int)nudDias.Value, Convert.ToSingle(tbPrecio.Text), 1); }
            get;set;
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarPrecio(sender as TextBox, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvMateriales_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvMateriales.CurrentCell.ColumnIndex == 2)
            {
                (e.Control as TextBox).KeyPress += DGVKeyPress;
            }
        }

        private void DGVKeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarPrecio(sender as TextBox, e);
        }

        protected virtual bool ActualizarProMat(out string Mensaje)
        {
            bool Error = false;
            Mensaje = "";
            Interface = new InterfaceUsuario(this);
            RegistroProMat Registro;
            for (int i = 0; i < dgvMateriales.RowCount && !Error; i++)
            {
                int ClavePro = 0;
                if (!int.TryParse(tbClave.Text, out ClavePro))
                {
                    Error = true;
                    Mensaje = "hubo un error en la clave de " + dgvMateriales[2, i].Value.ToString();
                }
                int ClaveMat = 0;
                if (!Error && !int.TryParse(dgvMateriales[0, i].Value.ToString(), out ClaveMat))
                {
                    Error = true;
                    Mensaje = "Clave de producto no válida";
                }
                float Precio = 0;
                if (!Error && !float.TryParse(dgvMateriales[3, i].Value.ToString(), out Precio))
                {
                    Error = true;
                    Mensaje = "El precio establecido en " + dgvMateriales[2, i].Value.ToString() + " no es válido";
                }
                if (!Error)
                {
                    //Registro = new RegistroProMat(ClavePro, ClaveMat, Precio, Convert.ToBoolean(dgvMateriales[1, i].Value) ? 1 : 0);
                    //if (!Interface.ActualizarProMat(Registro))
                    //{
                    //    Error = true;
                    //    Mensaje = "";
                    //}
                }
            }
            return Error;
        }

        protected virtual RegistroProMat[] ObtenerProMat
        {
            get
            {
                RegistroProMat[] temp;
                InterfaceUsuario.ObtenerProMat(Convert.ToInt32(tbClave.Text), -1, out temp);
                return temp;
            }
        }
    }
}
