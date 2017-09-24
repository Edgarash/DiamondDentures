using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Control;
using Entidad.Reportes;
using static Control.ManejadorContabilidad;

namespace Presentacion.Reportes
{
    internal class PantallaBuscarFactura : Pantalla
    {
        public List<Factura> Facturas;
        private bool Seleccionable;

        public PantallaBuscarFactura(bool seleccionable)
        {
            InitializeComponent();
            ActivarFechas();
            Reiniciar();

            Seleccionable = seleccionable;
            if (seleccionable)
            {
                dgvTabla.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                dgvTabla.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            }
            else
            {
                dgvTabla.DefaultCellStyle.SelectionBackColor = SystemColors.Window;
                dgvTabla.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            }
        }

        #region Metodos

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
            txtNumeroFactura.Clear();
            txtNombreCliente.Clear();
            dtpFechaA.Value = DateTime.Today.AddMonths(-6);
            dtpFechaB.Value = DateTime.Today;
        }

        private void BuscarFacturas()
        {
            int numeroPedido = -1;
            if (!string.IsNullOrWhiteSpace(txtNumeroFactura.Text))
                numeroPedido = int.Parse(txtNumeroFactura.Text);

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

           Facturas =
                ConsultarFactura(new DatosBusqueda(fechaA, fechaB, numeroPedido, chkActivar.Checked, nombreCliente));

            dgvTabla.Rows.Clear();
            if (Facturas != null)
                foreach (Factura resultado in Facturas)
                {
                    dgvTabla.RowCount++;
                    dgvTabla["cid", dgvTabla.RowCount - 1].Value = resultado.FacturaId;
                    dgvTabla["ccliente", dgvTabla.RowCount - 1].Value = resultado.NombreCliente;
                    dgvTabla["cimporte", dgvTabla.RowCount - 1].Value = resultado.Importe;
                    dgvTabla["cfecha", dgvTabla.RowCount - 1].Value = resultado.FechaEmision.ToShortDateString();
                }

            if (dgvTabla.RowCount > 0)
                dgvTabla.Rows[0].Selected = true;
        }

        #endregion

        #region UI Componentes

        private Label label1;
        private Button btnLimpiar;
        private Button btnBuscar;
        private DateTimePicker dtpFechaA;
        private TextBox txtNumeroFactura;
        private TextBox txtNombreCliente;
        private Label label6;
        private Label label5;
        private Label label12;
        private Label label4;
        private Label label2;
        private Label label7;
        private DataGridView dgvTabla;
        private Label label8;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label14;
        private Label label13;
        private DateTimePicker dtpFechaB;
        private Label label9;
        private CheckBox chkActivar;
        private DataGridViewTextBoxColumn cid;
        private DataGridViewTextBoxColumn ccliente;
        private DataGridViewTextBoxColumn cfecha;
        private DataGridViewTextBoxColumn cimporte;
        private PictureBox pictureBox1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaBuscarFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaA = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
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
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar factura";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
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
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(409, 181);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 60);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaA
            // 
            this.dtpFechaA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaA.Location = new System.Drawing.Point(41, 257);
            this.dtpFechaA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaA.Name = "dtpFechaA";
            this.dtpFechaA.Size = new System.Drawing.Size(93, 21);
            this.dtpFechaA.TabIndex = 24;
            this.dtpFechaA.Value = new System.DateTime(2017, 3, 30, 20, 51, 0, 0);
            this.dtpFechaA.ValueChanged += new System.EventHandler(this.dtpFechaA_ValueChanged);
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(41, 208);
            this.txtNumeroFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(304, 21);
            this.txtNumeroFactura.TabIndex = 22;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(41, 162);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.label12.Size = new System.Drawing.Size(525, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Para realizar una consulta se deben ingresar los criterios de busqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID de factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Intervalo de tiempo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 138);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.ccliente,
            this.cfecha,
            this.cimporte});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabla.Location = new System.Drawing.Point(43, 316);
            this.dgvTabla.MultiSelect = false;
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.Size = new System.Drawing.Size(560, 150);
            this.dgvTabla.TabIndex = 28;
            this.dgvTabla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_RowEnter);
            // 
            // cid
            // 
            this.cid.FillWeight = 30F;
            this.cid.HeaderText = "ID";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // ccliente
            // 
            this.ccliente.HeaderText = "Nombre de cliente";
            this.ccliente.Name = "ccliente";
            this.ccliente.ReadOnly = true;
            // 
            // cfecha
            // 
            this.cfecha.FillWeight = 60F;
            this.cfecha.HeaderText = "Fecha de emision";
            this.cfecha.Name = "cfecha";
            this.cfecha.ReadOnly = true;
            // 
            // cimporte
            // 
            this.cimporte.FillWeight = 75F;
            this.cimporte.HeaderText = "Importe";
            this.cimporte.Name = "cimporte";
            this.cimporte.ReadOnly = true;
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
            this.btnCancelar.Location = new System.Drawing.Point(343, 482);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 60);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.TabStop = false;
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
            this.btnAceptar.TabStop = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(339, 546);
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
            this.dtpFechaB.Location = new System.Drawing.Point(183, 257);
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
            this.label9.Location = new System.Drawing.Point(147, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 42);
            this.label9.TabIndex = 33;
            this.label9.Text = "-";
            // 
            // chkActivar
            // 
            this.chkActivar.AutoSize = true;
            this.chkActivar.Location = new System.Drawing.Point(282, 257);
            this.chkActivar.Name = "chkActivar";
            this.chkActivar.Size = new System.Drawing.Size(66, 20);
            this.chkActivar.TabIndex = 34;
            this.chkActivar.Text = "Activar";
            this.chkActivar.UseVisualStyleBackColor = true;
            this.chkActivar.CheckedChanged += new System.EventHandler(this.chkActivar_CheckedChanged);
            // 
            // PantallaBuscarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(615, 581);
            this.Controls.Add(this.chkActivar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFechaB);
            this.Controls.Add(this.dtpFechaA);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Name = "PantallaBuscarFactura";
            this.Text = "Buscar factura";
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtNombreCliente, 0);
            this.Controls.SetChildIndex(this.dtpFechaA, 0);
            this.Controls.SetChildIndex(this.dtpFechaB, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.dgvTabla, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.txtNumeroFactura, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.chkActivar, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Eventos

        private void txtNumeroPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                BuscarFacturas();
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFacturas();
        }

        private void chkActivar_CheckedChanged(object sender, EventArgs e)
        {
            ActivarFechas();
        }

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

        private void dgvTabla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvTabla.RowCount <= 0)
            {
                MessageBox.Show("No se ha encontrado ningun pedido","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            Hide();
        }

   private void btnCancelar_Click(object sender, EventArgs e)
   {
       Facturas = null;
            Hide();
   }

        #endregion

     
    }
}