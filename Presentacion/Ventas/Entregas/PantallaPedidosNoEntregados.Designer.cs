namespace Presentacion.Ventas.Entregas
{
    partial class PantallaPedidosNoEntregados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEntregar = new ControlesM.KuroButton();
            this.btnEjecutar = new ControlesM.KuroButton();
            this.cbPagado = new System.Windows.Forms.CheckBox();
            this.cbUrgente = new System.Windows.Forms.CheckBox();
            this.dtpMax = new System.Windows.Forms.DateTimePicker();
            this.dtpMin = new System.Windows.Forms.DateTimePicker();
            this.tbIDPedido = new System.Windows.Forms.TextBox();
            this.tbDentista = new System.Windows.Forms.TextBox();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.MensajeBonito = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kuroDGV1 = new ControlesM.KuroDGV();
            this.IDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCalculada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAbonar = new ControlesM.KuroButton();
            this.rbAmbos = new System.Windows.Forms.RadioButton();
            this.rbEntregado = new System.Windows.Forms.RadioButton();
            this.rbNoEntregado = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "IDPedido: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empleado: ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dentista: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha Min. Ingreso:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha Máx. Ingreso:";
            // 
            // btnEntregar
            // 
            this.btnEntregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEntregar.BackColor = System.Drawing.Color.White;
            this.btnEntregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEntregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEntregar.ForeColor = System.Drawing.Color.Black;
            this.btnEntregar.Location = new System.Drawing.Point(729, 100);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(95, 50);
            this.btnEntregar.TabIndex = 8;
            this.btnEntregar.Text = "Entregar";
            this.btnEntregar.UseVisualStyleBackColor = false;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEjecutar.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.btnEjecutar, 2);
            this.btnEjecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEjecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEjecutar.ForeColor = System.Drawing.Color.Black;
            this.btnEjecutar.Location = new System.Drawing.Point(3, 100);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(120, 50);
            this.btnEjecutar.TabIndex = 7;
            this.btnEjecutar.Text = "Buscar";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // cbPagado
            // 
            this.cbPagado.AutoSize = true;
            this.cbPagado.Location = new System.Drawing.Point(680, 33);
            this.cbPagado.Name = "cbPagado";
            this.cbPagado.Size = new System.Drawing.Size(107, 24);
            this.cbPagado.TabIndex = 6;
            this.cbPagado.Text = "No Pagado";
            this.MensajeBonito.SetToolTip(this.cbPagado, "En caso de no estar seleccionado se mostrarán pedidos pagados y no pagados");
            this.cbPagado.UseVisualStyleBackColor = true;
            // 
            // cbUrgente
            // 
            this.cbUrgente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbUrgente.AutoSize = true;
            this.cbUrgente.Location = new System.Drawing.Point(520, 33);
            this.cbUrgente.Name = "cbUrgente";
            this.cbUrgente.Size = new System.Drawing.Size(86, 24);
            this.cbUrgente.TabIndex = 5;
            this.cbUrgente.Text = "Urgente";
            this.MensajeBonito.SetToolTip(this.cbUrgente, "En caso de no estar seleccionado se mostrarán tanto pedidos urgentes como no urge" +
        "ntes");
            this.cbUrgente.UseVisualStyleBackColor = true;
            // 
            // dtpMax
            // 
            this.dtpMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpMax.Checked = false;
            this.dtpMax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMax.Location = new System.Drawing.Point(680, 3);
            this.dtpMax.Name = "dtpMax";
            this.dtpMax.ShowCheckBox = true;
            this.dtpMax.Size = new System.Drawing.Size(144, 26);
            this.dtpMax.TabIndex = 4;
            // 
            // dtpMin
            // 
            this.dtpMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpMin.Checked = false;
            this.dtpMin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMin.Location = new System.Drawing.Point(370, 3);
            this.dtpMin.Name = "dtpMin";
            this.dtpMin.ShowCheckBox = true;
            this.dtpMin.Size = new System.Drawing.Size(144, 26);
            this.dtpMin.TabIndex = 3;
            // 
            // tbIDPedido
            // 
            this.tbIDPedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbIDPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIDPedido.Location = new System.Drawing.Point(95, 3);
            this.tbIDPedido.MaxLength = 10;
            this.tbIDPedido.Name = "tbIDPedido";
            this.tbIDPedido.Size = new System.Drawing.Size(94, 26);
            this.tbIDPedido.TabIndex = 0;
            // 
            // tbDentista
            // 
            this.tbDentista.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbDentista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.tbDentista, 3);
            this.tbDentista.Location = new System.Drawing.Point(95, 63);
            this.tbDentista.MaxLength = 100;
            this.tbDentista.Name = "tbDentista";
            this.tbDentista.Size = new System.Drawing.Size(345, 26);
            this.tbDentista.TabIndex = 2;
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.tbEmpleado, 3);
            this.tbEmpleado.Location = new System.Drawing.Point(95, 33);
            this.tbEmpleado.MaxLength = 100;
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(345, 26);
            this.tbEmpleado.TabIndex = 1;
            // 
            // MensajeBonito
            // 
            this.MensajeBonito.ShowAlways = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.kuroDGV1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEjecutar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpMin, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpMax, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbIDPedido, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbEmpleado, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbDentista, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbUrgente, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbPagado, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEntregar, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAbonar, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.rbAmbos, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.rbEntregado, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.rbNoEntregado, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 391);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // kuroDGV1
            // 
            this.kuroDGV1.AllowUserToAddRows = false;
            this.kuroDGV1.AllowUserToDeleteRows = false;
            this.kuroDGV1.AllowUserToResizeRows = false;
            this.kuroDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kuroDGV1.BackgroundColor = System.Drawing.Color.White;
            this.kuroDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kuroDGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPedido,
            this.Nombre,
            this.NombreDen,
            this.Fecha,
            this.FechaCalculada,
            this.Urgencia,
            this.CostoTotal,
            this.Pagado,
            this.Restante,
            this.Entregado});
            this.tableLayoutPanel1.SetColumnSpan(this.kuroDGV1, 7);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kuroDGV1.DefaultCellStyle = dataGridViewCellStyle3;
            this.kuroDGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kuroDGV1.GridColor = System.Drawing.Color.Black;
            this.kuroDGV1.Location = new System.Drawing.Point(3, 163);
            this.kuroDGV1.MultiSelect = false;
            this.kuroDGV1.Name = "kuroDGV1";
            this.kuroDGV1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.kuroDGV1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kuroDGV1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.kuroDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kuroDGV1.Size = new System.Drawing.Size(936, 225);
            this.kuroDGV1.TabIndex = 1;
            this.kuroDGV1.TabStop = false;
            this.kuroDGV1.CurrentCellChanged += new System.EventHandler(this.kuroDGV1_CurrentCellChanged);
            // 
            // IDPedido
            // 
            this.IDPedido.FillWeight = 50F;
            this.IDPedido.HeaderText = "IDPedido";
            this.IDPedido.Name = "IDPedido";
            this.IDPedido.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Registro Empleado";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // NombreDen
            // 
            this.NombreDen.HeaderText = "Dentista";
            this.NombreDen.Name = "NombreDen";
            this.NombreDen.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "FechaIngreso";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // FechaCalculada
            // 
            this.FechaCalculada.HeaderText = "Fecha Calculada";
            this.FechaCalculada.Name = "FechaCalculada";
            this.FechaCalculada.ReadOnly = true;
            // 
            // Urgencia
            // 
            this.Urgencia.FillWeight = 50F;
            this.Urgencia.HeaderText = "Urgencia";
            this.Urgencia.Name = "Urgencia";
            this.Urgencia.ReadOnly = true;
            // 
            // CostoTotal
            // 
            this.CostoTotal.HeaderText = "Costo Total";
            this.CostoTotal.Name = "CostoTotal";
            this.CostoTotal.ReadOnly = true;
            // 
            // Pagado
            // 
            this.Pagado.FillWeight = 50F;
            this.Pagado.HeaderText = "Pagado";
            this.Pagado.Name = "Pagado";
            this.Pagado.ReadOnly = true;
            // 
            // Restante
            // 
            this.Restante.HeaderText = "Restante";
            this.Restante.Name = "Restante";
            this.Restante.ReadOnly = true;
            // 
            // Entregado
            // 
            this.Entregado.HeaderText = "Entregado";
            this.Entregado.Name = "Entregado";
            this.Entregado.ReadOnly = true;
            // 
            // btnAbonar
            // 
            this.btnAbonar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAbonar.BackColor = System.Drawing.Color.White;
            this.btnAbonar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAbonar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbonar.ForeColor = System.Drawing.Color.Black;
            this.btnAbonar.Location = new System.Drawing.Point(830, 100);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(109, 50);
            this.btnAbonar.TabIndex = 14;
            this.btnAbonar.Text = "Abonar$$$";
            this.btnAbonar.UseVisualStyleBackColor = false;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Location = new System.Drawing.Point(830, 63);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(77, 24);
            this.rbAmbos.TabIndex = 15;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.UseVisualStyleBackColor = true;
            // 
            // rbEntregado
            // 
            this.rbEntregado.AutoSize = true;
            this.rbEntregado.Location = new System.Drawing.Point(680, 63);
            this.rbEntregado.Name = "rbEntregado";
            this.rbEntregado.Size = new System.Drawing.Size(102, 24);
            this.rbEntregado.TabIndex = 15;
            this.rbEntregado.Text = "Entregado";
            this.rbEntregado.UseVisualStyleBackColor = true;
            // 
            // rbNoEntregado
            // 
            this.rbNoEntregado.AutoSize = true;
            this.rbNoEntregado.Checked = true;
            this.rbNoEntregado.Location = new System.Drawing.Point(520, 63);
            this.rbNoEntregado.Name = "rbNoEntregado";
            this.rbNoEntregado.Size = new System.Drawing.Size(126, 24);
            this.rbNoEntregado.TabIndex = 15;
            this.rbNoEntregado.TabStop = true;
            this.rbNoEntregado.Text = "No Entregado";
            this.rbNoEntregado.UseVisualStyleBackColor = true;
            // 
            // PantallaPedidosNoEntregados
            // 
            this.AcceptButton = this.btnEjecutar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PantallaPedidosNoEntregados";
            this.Text = "PantallaPedidosNoPagados";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbIDPedido;
        private System.Windows.Forms.TextBox tbDentista;
        private System.Windows.Forms.TextBox tbEmpleado;
        private System.Windows.Forms.DateTimePicker dtpMax;
        private System.Windows.Forms.DateTimePicker dtpMin;
        private System.Windows.Forms.CheckBox cbUrgente;
        private System.Windows.Forms.CheckBox cbPagado;
        private ControlesM.KuroButton btnEjecutar;
        private ControlesM.KuroButton btnEntregar;
        private System.Windows.Forms.ToolTip MensajeBonito;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ControlesM.KuroDGV kuroDGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCalculada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ControlesM.KuroButton btnAbonar;
        private System.Windows.Forms.RadioButton rbEntregado;
        private System.Windows.Forms.RadioButton rbNoEntregado;
        private System.Windows.Forms.RadioButton rbAmbos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entregado;
    }
}