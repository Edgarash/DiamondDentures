using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ConexionBaseDeDatos;
using Control;
using Entidad;
using Entidad.Reportes;
using static Control.ManejadorContabilidad;
using Validaciones;

namespace Presentacion.Reportes
{
    internal class PantallaBuscarPedido : Pantalla
    {
        public static Factura Factura;      
        public string Renglon;

        public PantallaBuscarPedido()
        {
            InitializeComponent();
            ActivarFechas();
            Reiniciar();
        }

        #region UI

        private DataGridViewTextBoxColumn cid;
        private DataGridViewTextBoxColumn cnombrecliente;
        private DataGridViewTextBoxColumn cfecha;
        private DataGridViewTextBoxColumn ccedula;
        private Button btnAceptar;
        private Button btnBuscar;
        private Button btnCancelar;
        private Button btnLimpiar;
        private CheckBox chkActivar;
        private DataGridView dgvTabla;
        private DateTimePicker dtpFechaA;
        private DateTimePicker dtpFechaB;
        private Label label1;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private TextBox txtNombreCliente;
        private TextBox txtNumeroPedido;

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaA = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombrecliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFechaB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.chkActivar = new System.Windows.Forms.CheckBox();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Controls.Add(this.pictureBox1);
            this.Encabezado.Size = new System.Drawing.Size(615, 93);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.IconoBuscarPedido;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(93, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar pedido";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::Presentacion.Properties.Resources.eraser_46865;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(517, 181);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(60, 60);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::Presentacion.Properties.Resources.Multimedia_communication_flat_mobile_Technology_08_38_512;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(409, 181);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 60);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaA
            // 
            this.dtpFechaA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaA.Location = new System.Drawing.Point(43, 263);
            this.dtpFechaA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaA.Name = "dtpFechaA";
            this.dtpFechaA.Size = new System.Drawing.Size(93, 21);
            this.dtpFechaA.TabIndex = 24;
            this.dtpFechaA.Value = new System.DateTime(2017, 3, 30, 20, 51, 0, 0);
            this.dtpFechaA.ValueChanged += new System.EventHandler(this.dtpFechaA_ValueChanged);
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(42, 158);
            this.txtNumeroPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroPedido.MaxLength = 11;
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(304, 21);
            this.txtNumeroPedido.TabIndex = 22;
            this.txtNumeroPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPedido_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(42, 209);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCliente.MaxLength = 45;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(304, 21);
            this.txtNombreCliente.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Limpiar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Buscar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(534, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Para realizar una consulta se pueden ingresar los criterios de busqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Numero de pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Intervalo de tiempo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nombre del cliente:";
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.AllowUserToResizeColumns = false;
            this.dgvTabla.AllowUserToResizeRows = false;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.cnombrecliente,
            this.cfecha,
            this.ccedula});
            this.dgvTabla.Location = new System.Drawing.Point(43, 316);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(560, 150);
            this.dgvTabla.TabIndex = 28;
            // 
            // cid
            // 
            this.cid.FillWeight = 30F;
            this.cid.HeaderText = "N° pedido";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // cnombrecliente
            // 
            this.cnombrecliente.HeaderText = "Nombre del cliente";
            this.cnombrecliente.Name = "cnombrecliente";
            this.cnombrecliente.ReadOnly = true;
            // 
            // cfecha
            // 
            this.cfecha.FillWeight = 50F;
            this.cfecha.HeaderText = "Fecha";
            this.cfecha.Name = "cfecha";
            this.cfecha.ReadOnly = true;
            // 
            // ccedula
            // 
            this.ccedula.FillWeight = 50F;
            this.ccedula.HeaderText = "Cedula";
            this.ccedula.Name = "ccedula";
            this.ccedula.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Resultados de búsqueda";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(344, 482);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 60);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Presentacion.Properties.Resources.IconoAceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(234, 482);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(60, 60);
            this.btnAceptar.TabIndex = 32;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(340, 546);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Cancelar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(234, 546);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Aceptar";
            // 
            // dtpFechaB
            // 
            this.dtpFechaB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaB.Location = new System.Drawing.Point(191, 263);
            this.dtpFechaB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaB.Name = "dtpFechaB";
            this.dtpFechaB.Size = new System.Drawing.Size(93, 21);
            this.dtpFechaB.TabIndex = 24;
            this.dtpFechaB.Value = new System.DateTime(2017, 4, 30, 20, 51, 0, 0);
            this.dtpFechaB.ValueChanged += new System.EventHandler(this.dtpFechaB_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(146, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 42);
            this.label9.TabIndex = 33;
            this.label9.Text = "-";
            // 
            // chkActivar
            // 
            this.chkActivar.AutoSize = true;
            this.chkActivar.Location = new System.Drawing.Point(290, 263);
            this.chkActivar.Name = "chkActivar";
            this.chkActivar.Size = new System.Drawing.Size(66, 20);
            this.chkActivar.TabIndex = 34;
            this.chkActivar.Text = "Activar";
            this.chkActivar.UseVisualStyleBackColor = true;
            this.chkActivar.CheckedChanged += new System.EventHandler(this.chkActivar_CheckedChanged);
            // 
            // PantallaBuscarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(615, 581);
            this.Controls.Add(this.chkActivar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtpFechaB);
            this.Controls.Add(this.dtpFechaA);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Name = "PantallaBuscarPedido";
            this.Text = "Buscar pedido";
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtNombreCliente, 0);
            this.Controls.SetChildIndex(this.dtpFechaA, 0);
            this.Controls.SetChildIndex(this.dtpFechaB, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.dgvTabla, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtNumeroPedido, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.chkActivar, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ActivarFechas()
        {
            if (chkActivar.Checked)
            {
                dtpFechaA.Enabled = true;
                dtpFechaB.Enabled = true;
            }
            else
            {
                dtpFechaA.Enabled = false;
                dtpFechaB.Enabled = false;
            }
        }

        private void Reiniciar()
        {
            txtNumeroPedido.Clear();
            txtNombreCliente.Clear();
            dtpFechaA.Value = DateTime.Today.AddMonths(-6);
            dtpFechaB.Value = DateTime.Today;
        }

        private void BuscarPedido()
        {
            int numeroPedido = -1;
            if (!string.IsNullOrWhiteSpace(txtNumeroPedido.Text))
                numeroPedido = int.Parse(txtNumeroPedido.Text);

            string nombreCliente = "";
            if (!string.IsNullOrWhiteSpace(txtNombreCliente.Text))
                nombreCliente = txtNombreCliente.Text;

            DateTime fechaA = DateTime.MinValue;
            DateTime fechaB = DateTime.MaxValue;

            if (chkActivar.Checked)
            {
                fechaA = dtpFechaA.Value;
                fechaB = dtpFechaB.Value;
            }

            List<Pedidos> pedidos = ConsultarPedido(new DatosBusqueda(fechaA, fechaB, numeroPedido, chkActivar.Checked, nombreCliente));

            dgvTabla.Rows.Clear();
            foreach (Pedidos pedido in pedidos)
            {
                dgvTabla.RowCount++;
                dgvTabla["cid", dgvTabla.RowCount - 1].Value = pedido.Clave;
                dgvTabla["cnombrecliente", dgvTabla.RowCount - 1].Value = pedido.NombrDen;
                dgvTabla["ccedula", dgvTabla.RowCount - 1].Value = pedido.Cedula;
                dgvTabla["cfecha", dgvTabla.RowCount - 1].Value = pedido.Fecha;
            }

            if (dgvTabla.RowCount <= 0)
                return;

            dgvTabla.Rows[0].Selected = true;
            dgvTabla.Refresh();
        }

        private void SeleccionarPedido(string facturaId)
        {
            Factura = ConsultarFactura(facturaId);
        }
        
        #region Eventos

        private void txtNumeroPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarPedido();
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPedido();
        }

        private void chkActivar_CheckedChanged(object sender, EventArgs e) => ActivarFechas();

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void dtpFechaA_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaB.MinDate = dtpFechaA.Value;
        }

        private void dtpFechaB_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaA.MaxDate = dtpFechaB.Value;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvTabla.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No se han encontrado pedidos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (dgvTabla.SelectedRows[0].Cells["cid"].Value != null)
            {
                Renglon = dgvTabla.SelectedRows[0].Cells["cid"].Value.ToString();
            }
            if (!string.IsNullOrWhiteSpace(Renglon))
            {
                SeleccionarPedido(Renglon);
                Hide();
            }
            else
            {
                Validar.MensajeErrorOK("No se ha seleccionado un pedido.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}