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
using static Validaciones.Validar;

namespace Presentacion.Configuracion
{
    public partial class PantallaMaterial : Control.Pantalla
    {
        protected InterfaceUsuario Interface;
        protected Validar Validacion;
        RegistroProveedor[] Proveedores;

        public PantallaMaterial()
        {
            InitializeComponent();
            InitializeComponent2();
        }

        protected void LlenarComboBoxProveedores()
        {
            ManejadorConfiguracion.ObtenerProveedores(out Proveedores);
            if (Proveedores != null)
                foreach (RegistroProveedor x in Proveedores)
                    cbProveedores.Items.Add(x.Nombre);
            else
            {
                MensajeErrorOK("No tiene proveedores registrados\n\nFavor de registrar proveedor antes");
                Close();
            }
            cbProveedores.Sorted = true;
        }

        protected virtual void InitializeComponent3()
        {
            for (int i = 0; i < Controls.Count; i++)
                if (Controls[i].GetType() == typeof(TextBox))
                    Controls[i].KeyPress += Mayusculas;
            cbProveedores.KeyPress += Mayusculas;
            dgvProductos.ClearSelection();
            dgvProductos.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvProductos.DefaultCellStyle.SelectionForeColor = dgvProductos.DefaultCellStyle.ForeColor;
            tbPrecioBase.KeyPress += TextBox_KeyPress_ValidarSoloReales2Decimales;
            tbPrecioCompra.KeyPress += TextBox_KeyPress_ValidarSoloReales2Decimales;
            Validacion = new Validar(this);
        }

        private void dgvProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int Index = dgvProductos.CurrentCell.ColumnIndex;
            if (Index == dgvProductos.Columns["Precio"].Index)
                (e.Control as TextBox).KeyPress += TextBox_KeyPress_ValidarSoloReales2Decimales;
            if (Index == dgvProductos.Columns["Tiempo"].Index)
                (e.Control as TextBox).KeyPress += TextBox_KeyPress_ValidarSoloEnteros;
        }

        protected virtual bool CamposFaltantes
        {
            get
            {
                bool temp = Validacion.ValidarComboBox(cbProveedores);
                return Validacion.ValidarTextBox(tbClave, tbPrecioBase, tbPrecioCompra, tbNombreMaterial, tbDescripcion, tbUnidadMedida) || temp;
            }
        }

        protected virtual RegistroMaterial ObtenerRegistro
        {
            get
            {
                return new RegistroMaterial(
              Convert.ToInt32(tbClave.Text),
              tbNombreMaterial.Text,
              tbDescripcion.Text,
              Convert.ToSingle(tbPrecioBase.Text),
              Convert.ToSingle(tbPrecioCompra.Text),
              (int)nudTiempo.Value,
              ObtenerProveedor,
              tbUnidadMedida.Text,
              (int)nudCantidad.Value
              );
            }
        }

        protected virtual RegistroProveedor ObtenerProveedor
        {
            get
            {
                if (Proveedores != null)
                    for (int i = 0; i < Proveedores.Length; i++)
                        if (cbProveedores.Text == Proveedores[i].Nombre)
                            return Proveedores[i];
                return null;
            }
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
                if (!int.TryParse(dgvProductos["Clave", i].Value.ToString(), out ClavePro))
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
                if (!Error && !float.TryParse(dgvProductos["Precio", i].Value.ToString(), out Precio))
                {
                    Error = true;
                    Mensaje = "El precio establecido en " + dgvProductos["Producto", i].Value.ToString() + " no es válido";
                }
                int Tiempo = 0;
                if (!Error && !int.TryParse(dgvProductos["Tiempo", i].Value.ToString(), out Tiempo))
                {
                    Error = true;
                    Mensaje = "El tiempo establecido en " + dgvProductos["Producto", i].Value.ToString() + " no es válido";
                }
                if (!Error)
                {
                    Registro = new RegistroProMat(ClavePro, ClaveMat, Precio, Tiempo, Convert.ToBoolean(dgvProductos["Activo", i].Value));
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
                RegistroProMat[] temp;
                InterfaceUsuario.ObtenerProMat(-1, Convert.ToInt32(tbClave.Text), out temp);
                return temp;
            }
        }
    }
}