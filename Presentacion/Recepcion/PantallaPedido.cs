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

        public PantallaPedido()
        {
            InitializeComponent();
            InitializeComponent2();
            dgvProductos.RowsAdded += DgvProductos_RowsAdded;
            tbFecha.Text = DateTime.Now.ToString();
            Validacion = new Validar(this);
            tbTelefono.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            tbCedula.LostFocus += TbCedula_LostFocus;
            AgregarDentista = true;
        }

        protected virtual void InitializeComponent4(RegistroDentista Dentista)
        {
            tbCedula.Text = Dentista?.Cedula;
            tbRFC.Text = Dentista?.RFC;
            tbNombreDentista.Text = Dentista?.Nombre;
            tbApellidos.Text = Dentista?.Apellidos;
            tbTelefono.Text = Dentista?.TelOficina;
            cbPaíses.Text = Dentista?.Pais;
            cbEstado.Text = Dentista?.Estado;
            cbMunicipio.Text = Dentista?.Municipio;
            cbCiudad.Text = Dentista?.Ciudad;
            tbColonia.Text = Dentista?.Colonia;
            tbCalle.Text = Dentista?.Direccion;
            tbCP.Text = Dentista?.CodPos;
            tbEmail.Text = Dentista?.Email?.Split('@')[0];
            cbEmail.Text = Dentista?.Email?.Split('@')[1];
        }

        private void TbCedula_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCedula.Text))
            {
                RegistroDentista temp= null;// = Interface.ObtenerUnDentista(tbCedula.Text);
                if (temp == null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Dentista no registrado\n\n¿Desea registrarlo?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        PantallaAgregarDentista Pant = new PantallaAgregarDentista(ObtenerRegistroDentista);
                        Pant.ShowDialog();
                        if (Pant.AceptarCambios)
                        {
                            InitializeComponent4(Pant.ObtenerRegistroDentista);
                            btnDentista.BackgroundImage = Presentacion.Properties.Resources.IconoDentistaModificar;
                            AgregarDentista = false;
                        }
                    }
                    else
                    {
                        btnDentista.BackgroundImage = Presentacion.Properties.Resources.IconoDentistaAgregar;
                        AgregarDentista = true;
                    }
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Dentista registrado\n\n¿Desea rellenar campos faltantes?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        InitializeComponent4(temp);
                        btnDentista.BackgroundImage = Presentacion.Properties.Resources.IconoDentistaModificar;
                    }
                }
            }
        }

        private void btnDentista_Click(object sender, EventArgs e)
        {
            if (AgregarDentista)
            {
                PantallaAgregarDentista Pant = new PantallaAgregarDentista(ObtenerRegistroDentista);
                Pant.ShowDialog();
                if (Pant.AceptarCambios)
                {
                    InitializeComponent4(Pant.ObtenerRegistroDentista);
                    btnDentista.BackgroundImage = Presentacion.Properties.Resources.IconoDentistaModificar;
                    AgregarDentista = false;
                }
            }
            else
            {
                PantallaModificarDentista Pant = null;// new PantallaModificarDentista(Interface.ObtenerUnDentista(tbCedula.Text));
                Pant.ShowDialog();
                if (Pant.AceptarCambios)
                {
                    InitializeComponent4(Pant.ObtenerRegistroDentista);
                }
            }
        }

        private void DgvProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            LlenarProductos(dgvProductos[0, e.RowIndex] as DataGridViewComboBoxCell);
        }

        protected virtual void InitializeComponent3()
        {
            Interface = new InterfaceUsuario(this);
            RegistroProducto[] t;
            InterfaceUsuario.ObtenerProductos(out t);
            Materiales = Interface.ObtenerMateriales();
            LlenarProductos(dgvProductos[0, 0] as DataGridViewComboBoxCell);
            tbTelefono.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void LlenarProductos(DataGridViewComboBoxCell Celda)
        {
            Celda.Items.Clear();
            Interface = new InterfaceUsuario(this);
            //RegistroProMat[] ProMat = Interface.ObtenerProMat(-1, Interface.BuscarUnProducto(new RegistroProducto(-1, dgvProductos[0, (dgvProductos.CurrentCell ?? dgvProductos[0,0]).RowIndex].FormattedValue.ToString(), -1, -1, -1))?[0].IDProducto ?? -1);
            //for (int i = 0; i < Productos?.Length; i++)
            //    if (Productos[i].Activo == 1)
            //        for (int j = 0; j < ProMat.Length; j++)
            //            if (ProMat[j].Activo == 1)
            //            {
            //                (dgvProductos[Celda.ColumnIndex, Celda.RowIndex] as DataGridViewComboBoxCell).Items.Add(Productos[i].Nombre + " $" + Productos[i].PrecioBase);
            //                j = ProMat.Length;
            //            }
        }

        private void LlenarMateriales(DataGridViewComboBoxCell Celda, RegistroMaterial Material1)
        {
            Interface = new InterfaceUsuario(this);
            //if (Celda.ColumnIndex == dgvProductos.Columns["Material1"].Index || Celda.ColumnIndex == dgvProductos.Columns["Material2"].Index)
            //{
            //    Celda.Items.Clear();
            //    Celda.Value = null;
            //    (dgvProductos[dgvProductos.Columns["Material2"].Index, Celda.RowIndex] as DataGridViewComboBoxCell).Items.Clear();
            //    (dgvProductos[dgvProductos.Columns["Material2"].Index, Celda.RowIndex] as DataGridViewComboBoxCell).Value = null;
            //    dgvProductos[4, Celda.RowIndex].Value = null;
            //}
            //RegistroProMat[] temp = Interface.ObtenerProMat(-1, ObtenerProducto(Celda.RowIndex)?.IDProducto ?? -1 );
            //for (int i = 0; i < temp?.Length; i++)
            //    if (temp[i]?.Activo == 1)
            //        for (int k = 0; k < Materiales?.Length; k++)
            //            //if (temp[i]?.ClaveMat != Material1?.IDMaterial && Materiales[k].Activo == 1 && Materiales[k].Nombre == temp[i].Material)
            //            {
            //                //(dgvProductos?[Celda.ColumnIndex, Celda.RowIndex] as DataGridViewComboBoxCell).Items.Add(temp[i].Material + " $" + temp[i].Precio);
            //                //k = Materiales.Length;
            //            }
            //if (Celda.Items.Count == 0)
            //    Celda.Items.Add("");
            //if ((dgvProductos[dgvProductos.Columns["Material2"].Index, Celda.RowIndex] as DataGridViewComboBoxCell).Items.Count == 0)
            //    (dgvProductos[dgvProductos.Columns["Material2"].Index, Celda.RowIndex] as DataGridViewComboBoxCell).Items.Add("");
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
                //RegistroPedido temp = new RegistroPedido(tbClave.Text, lblUsuario.Text, tbFecha.Text, tbCedula.Text, tbRFC.Text, tbNombreDentista.Text,
                //    tbApellidos.Text, ObtenerTelefono, cbPaíses.Text, cbEstado.Text, cbMunicipio.Text, cbCiudad.Text, tbColonia.Text,
                //    tbCalle.Text, tbNumFrente.Text, tbCP.Text, tbEmail.Text + "@" + cbEmail.Text, tbFechaEntrega.Text, tbUrgente.Checked ? 1 : 0, "");
                //temp.setTrabajos(ObtenerTrabajo);
                return null;
            }
        }

        protected virtual bool FaltanCampos
        {
            get
            {
                bool Faltan = false;
                Faltan = Error || Faltan;
                Faltan = Validacion.ValidarTextBox(tbClave, tbCedula, tbRFC, tbNombreDentista, tbApellidos, tbColonia, tbCalle, tbNumFrente, tbEmail) || Faltan;
                Faltan = Validacion.ValidarComboBox(cbPaíses, cbEstado, cbMunicipio, cbCiudad, cbEmail) || Faltan;
                Faltan = Validacion.ValidarMaskedTextBox(tbFecha, tbFechaEntrega, tbCP, tbTelefono) || Faltan;
                return Faltan;
            }
        }

        protected virtual RegistroTrabajo[] ObtenerTrabajo
        {
            get
            {
                List<RegistroTrabajo> temp = new List<RegistroTrabajo>();

                for (int i = 0; i < dgvProductos.RowCount; i++)
                {
                    if (!string.IsNullOrWhiteSpace(dgvProductos[0, i].FormattedValue?.ToString()))
                    {
                        RegistroProducto Producto = ObtenerProducto(i);
                        if (!string.IsNullOrWhiteSpace(dgvProductos[1, i].FormattedValue?.ToString()))
                        {
                            RegistroProMat Mat1 = ObtenerProMat(Producto, ObtenerMaterial(1, i)), Mat2 = null;
                            if (!string.IsNullOrWhiteSpace(dgvProductos[2, i].FormattedValue?.ToString()))
                                Mat2 = ObtenerProMat(Producto, ObtenerMaterial(2, i));
                            //temp.Add(new RegistroTrabajo(Producto?.Nombre, Producto?.PrecioBase ?? 0, Mat1?.Material, Mat1?.Precio ?? 0, Mat2?.Material?? "", Mat2?.Precio ?? 0, dgvProductos[3,i].Value.ToString()));
                        }
                    }
                }
                return temp.ToArray();
            }
        }

        protected virtual RegistroProducto ObtenerProducto(int Row)
        {
            RegistroProducto temp = null;
            bool Encontrado = false;
            for (int i = 0; i < Productos.Length &&!Encontrado; i++)
            {
                dgvProductos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DataGridViewCell Celda = dgvProductos[0, Row];
                if (Productos[i].Nombre == (dgvProductos[0, Row].FormattedValue?.ToString().Split((new string[] { " $" }), StringSplitOptions.None)[0]))
                {
                    temp = Productos[i];
                    Encontrado = true;
                }
            }
            return temp;
        }

        protected virtual RegistroMaterial ObtenerMaterial(int Material, int Row)
        {
            RegistroMaterial temp = null;
            bool Encontrado = false;
            for (int i = 0; i < Materiales.Length && !Encontrado; i++)
            {
                if (Materiales[i].Nombre == (dgvProductos[Material, Row].FormattedValue?.ToString().Split((new string[] { " $" }), StringSplitOptions.None)[0]))
                {
                    temp = Materiales[i];
                    Encontrado = true;
                }
            }
            return temp;
        }

        protected virtual RegistroProMat ObtenerProMat(RegistroProducto Producto, RegistroMaterial Material)
        {
            RegistroProMat temp = null;
            //RegistroProMat[] x = Interface.ObtenerProMat((Material?.IDMaterial ?? -1), (Producto?.IDProducto ?? -1));
            //temp = x.Length > 0 ? x[0] : null;
            return temp;
        }

        protected virtual bool Error
        {
            get
            {
                bool Error = false;
                for (int i = 0; i < dgvProductos.RowCount && !Error; i++)
                {
                    if (!string.IsNullOrWhiteSpace(dgvProductos[0, i].FormattedValue?.ToString()))
                    {
                        if (string.IsNullOrWhiteSpace(dgvProductos[1, i].FormattedValue?.ToString()))
                        {
                            Error = true;
                            Validar.MensajeErrorOK("El material 1 de la fila" + (i + 1) + " no puede quedar vacío, favor de corregir");
                        }
                    }
                    else
                    {
                        if (i != dgvProductos.RowCount - 1)
                        {
                            Error = true;
                            Validar.MensajeErrorOK("La fila " + (i + 1) + " no puede quedar vacía, favor de eliminar");
                        }
                    }
                }
                return Error;
            }
        }

        protected RegistroMaterial[] Materiales { get; set; }

        protected RegistroProducto[] Productos { get; set; }

        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProductos.Columns["Producto"].Index)
            {
                LlenarMateriales(dgvProductos[dgvProductos.Columns["Material1"].Index, e.RowIndex] as DataGridViewComboBoxCell, null);
                int j = 0;
                RegistroProducto t = ObtenerProducto(e.RowIndex);
                for (int i = 0; i < Productos.Length; i++)
                {
                    if (Productos[i].Nombre == (t?.Nombre ?? ""))
                    {
                        j = i;
                        i = Productos.Length;
                    }
                }
                dgvProductos[dgvProductos.Columns["Fecha"].Index, e.RowIndex].Value = !string.IsNullOrWhiteSpace(dgvProductos[e.ColumnIndex, e.RowIndex].FormattedValue?.ToString()) ? DateTime.Today.AddDays(Productos[j].TiempoBase).ToShortDateString() : "";
                FechaPedido();
            }
            else
            {
                if (e.ColumnIndex == dgvProductos.Columns["Material1"].Index)
                {
                    int i;
                    bool Encontrado = false;
                    for (i = 0; i < Materiales.Length && !Encontrado; i++)
                    {
                        if (Materiales[i].Nombre == (dgvProductos[dgvProductos.Columns["Material1"].Index, e.RowIndex]?.FormattedValue?.ToString()?.Split((new string[] { " $"}), StringSplitOptions.None)?[0] ?? ""))
                            Encontrado = true;
                    }
                    (dgvProductos[dgvProductos.Columns["Material2"].Index, e.RowIndex] as DataGridViewComboBoxCell).Items.Clear();
                    if (Encontrado)
                    {

                        LlenarMateriales(dgvProductos[dgvProductos.Columns["Material2"].Index, e.RowIndex] as DataGridViewComboBoxCell, Materiales[i - 1]);
                    }
                }
                dgvProductos[dgvProductos.Columns["Precio"].Index, e.RowIndex].Value = "$" + CalcularPrecio(e.RowIndex).ToString("N2");
                PrecioPedido();
            }
        }

        private float CalcularPrecio(int Row)
        {
            float Precio = 0;
            //if ((ObtenerProducto(Row)?.Nombre ?? "") != "")
            //{
            //    int ClvProducto = -1;
            //    float PrecioProducto = 0;
            //    for (int i = 0; i < Productos.Length; i++)
            //    {
            //        RegistroProducto Producto = ObtenerProducto(Row);
            //            Precio += Producto.PrecioBase;
            //            PrecioProducto = Producto.PrecioBase;
            //            ClvProducto = Producto.IDProducto;
            //            i = Productos.Length;
            //    }
            //    RegistroProMat[] ProMat = Interface.ObtenerProMat(-1, ClvProducto);
            //    if ((ObtenerMaterial(1, Row)?.Nombre?? "") != "" || (ObtenerMaterial(2, Row)?.Nombre??"") != "")
            //    {
            //        bool Primero = false, Segundo = false;
            //        for (int i = 0; i < Materiales.Length; i++)
            //        {
            //            RegistroMaterial Mat1 = ObtenerMaterial(1, Row), Mat2 = ObtenerMaterial(2, Row);
            //            if (Materiales[i].Nombre == (Mat1?.Nombre ?? "") || Materiales[i].Nombre == (Mat2?.Nombre ?? ""))
            //                for (int j = 0; j < ProMat.Length && !Segundo; j++)
            //                    if (ClvProducto == ProMat[j].ClavePro && Materiales[i].IDMaterial == ProMat[j].ClaveMat)
            //                    {
            //                        if (!Segundo && Primero)
            //                            Segundo = true;
            //                        Precio += ProMat[j].PrecioFinal;
            //                        if (!Primero)
            //                        {
            //                            Primero = true;
            //                            if (string.IsNullOrWhiteSpace(dgvProductos[dgvProductos.Columns["Material2"].Index, Row]?.FormattedValue?.ToString() ?? ""))
            //                                Segundo = true;
            //                        }
            //                    }
            //        }
            //    }
            //}
            return Precio;
        }

        protected DateTime FechaFinalEntrega { get; set; }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.EndEdit();
            if (e.ColumnIndex == 0 || e.ColumnIndex ==1 || e.ColumnIndex == 2)
            {
                dgvProductos.CurrentCellDirtyStateChanged -= dgvProductos_CurrentCellDirtyStateChanged;
                SendKeys.Send("{F4}");
                dgvProductos.CurrentCellDirtyStateChanged += dgvProductos_CurrentCellDirtyStateChanged;
            }
            else
                dgvProductos.BeginEdit(true);
        }

        private void dgvProductos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvProductos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dgvProductos.EndEdit();
        }

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
            lblTotal.Location = new Point(dgvProductos.Width + dgvProductos.Location.X - lblTotal.Width, lblTotal.Location.Y);
        }

        protected void FechaPedido()
        {
            DateTime Fecha = DateTime.MinValue;
            for (int i = 0; i < dgvProductos.RowCount; i++)
            {
                string t = dgvProductos[3, i].Value?.ToString() ?? "";
                if (!string.IsNullOrWhiteSpace(t))
                {
                    DateTime temp = Convert.ToDateTime(t);
                    if (temp > Fecha)
                        Fecha = temp;
                }
            }
            tbFechaEntrega.Text = Fecha.ToShortDateString();
        }

        private void dgvProductos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            PrecioPedido();
            FechaPedido();
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

        protected virtual RegistroDentista ObtenerRegistroDentista
        {
            get
            {
                return null;
                    //new RegistroDentista(tbCedula.Text, tbRFC.Text, tbNombreDentista.Text, tbApellidos.Text, ObtenerTelefono, cbPaíses.Text,
                    //cbEstado.Text, cbMunicipio.Text, cbCiudad.Text, tbColonia.Text, tbCalle.Text, tbNumFrente.Text, tbCP.Text,
                    //tbEmail.Text + "@" + cbEmail.Text);
            }
        }
    }
}
