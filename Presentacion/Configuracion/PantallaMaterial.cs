using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Configuracion
{
    public partial class PantallaMaterial : Control.Pantalla
    {
        protected InterfaceUsuario Interface;
        protected Validar Validacion;

        public PantallaMaterial()
        {
            InitializeComponent();
            InitializeComponent2();
        }

        protected virtual void InitializeComponent3()
        {
            dgvProductos.ClearSelection();
            dgvProductos.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvProductos.DefaultCellStyle.SelectionForeColor = dgvProductos.DefaultCellStyle.ForeColor;
            Validacion = new Validar(this);
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarPrecio(sender as TextBox, e);
        }

        private void dgvProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvProductos.CurrentCell.ColumnIndex == 2)
                (e.Control as TextBox).KeyPress += ValidandoPrecios;
        }

        private void ValidandoPrecios(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarPrecio(sender as TextBox, e);
        }

        protected virtual bool CamposFaltantes
        {
            get
            {
                return Validacion.ValidarTextBox(tbClave, tbPrecio, tbNombre);
            }
        }

        protected RegistroMaterial ObtenerRegistro
        {
            //get
            //{
            //    return new RegistroMaterial(Convert.ToInt32(!string.IsNullOrWhiteSpace(tbClave.Text) ? tbClave.Text : "0"), tbNombre.Text, Convert.ToSingle(tbPrecio.Text), 1);
            //}
            get;set;
        }

        private void tbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarSoloNumeros(sender as TextBox, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual bool ActualizarProMat(out string Mensaje)
        {
            bool Error = false;
            Mensaje = "";
            Interface = new InterfaceUsuario(this);
            RegistroProMat Registro;
            for (int i = 0; i < dgvProductos.RowCount && !Error; i++)
            {
                int ClavePro = 0;
                if (!int.TryParse(dgvProductos[0, i].Value.ToString(), out ClavePro))
                {
                    Error = true;
                    Mensaje = "hubo un error en la clave de " + dgvProductos[2, i].Value.ToString();
                }
                int ClaveMat = 0;
                if (!Error && !int.TryParse(tbClave.Text, out ClaveMat))
                {
                    Error = true;
                    Mensaje = "Clave de material no válida";
                }
                float Precio = 0;
                if (!Error && !float.TryParse(dgvProductos[3, i].Value.ToString(), out Precio))
                {
                    Error = true;
                    Mensaje = "El precio establecido en " + dgvProductos[2, i].Value.ToString() + " no es válido";
                }
                if (!Error)
                {
                    Registro = new RegistroProMat(ClavePro, ClaveMat, Precio, Convert.ToBoolean(dgvProductos[1, i].Value) ? 1 : 0);
                    if (!Interface.ActualizarProMat(Registro))
                    {
                        Error = true;
                        Mensaje = "";
                    }
                }
            }
            return Error;
        }

        protected virtual RegistroProMat[] ObtenerProMat
        {
            get
            {
                Interface = new InterfaceUsuario(this);
                return Interface.ObtenerProMat(Convert.ToInt32(string.IsNullOrWhiteSpace(tbClave.Text) ? "-1" : tbClave.Text), -1);
            }
        }
    }
}