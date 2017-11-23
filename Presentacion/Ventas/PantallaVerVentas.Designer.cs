namespace Presentacion.Ventas
{
    partial class PantallaVerVentas
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new ControlesM.KuroButton();
            this.tbIDVenta = new System.Windows.Forms.TextBox();
            this.dtpMin = new System.Windows.Forms.DateTimePicker();
            this.dtpMax = new System.Windows.Forms.DateTimePicker();
            this.tbIDPedido = new System.Windows.Forms.TextBox();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.cbEfectivo = new System.Windows.Forms.CheckBox();
            this.cbTarjeta = new System.Windows.Forms.CheckBox();
            this.cbCheque = new System.Windows.Forms.CheckBox();
            this.btnDevolucion = new ControlesM.KuroButton();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.kuroDGV1 = new ControlesM.KuroDGV();
            this.IDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "IDVenta:  ";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(213, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha Min.:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(463, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha Máx.:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 35);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 20);
            label4.TabIndex = 2;
            label4.Text = "IDPedido:  ";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 65);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(89, 20);
            label5.TabIndex = 2;
            label5.Text = "Empleado: ";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 90);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(87, 30);
            label6.TabIndex = 2;
            label6.Text = "Referencia: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(818, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.tableLayoutPanel11.SetRowSpan(this.btnBuscar, 2);
            this.btnBuscar.Size = new System.Drawing.Size(100, 54);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // tbIDVenta
            // 
            this.tbIDVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIDVenta.Location = new System.Drawing.Point(98, 3);
            this.tbIDVenta.MaxLength = 10;
            this.tbIDVenta.Name = "tbIDVenta";
            this.tbIDVenta.Size = new System.Drawing.Size(103, 26);
            this.tbIDVenta.TabIndex = 0;
            // 
            // dtpMin
            // 
            this.dtpMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpMin.Checked = false;
            this.dtpMin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMin.Location = new System.Drawing.Point(313, 3);
            this.dtpMin.Name = "dtpMin";
            this.dtpMin.ShowCheckBox = true;
            this.dtpMin.Size = new System.Drawing.Size(144, 26);
            this.dtpMin.TabIndex = 4;
            // 
            // dtpMax
            // 
            this.dtpMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpMax.Checked = false;
            this.dtpMax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMax.Location = new System.Drawing.Point(573, 3);
            this.dtpMax.Name = "dtpMax";
            this.dtpMax.ShowCheckBox = true;
            this.dtpMax.Size = new System.Drawing.Size(144, 26);
            this.dtpMax.TabIndex = 5;
            // 
            // tbIDPedido
            // 
            this.tbIDPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIDPedido.Location = new System.Drawing.Point(98, 33);
            this.tbIDPedido.MaxLength = 10;
            this.tbIDPedido.Name = "tbIDPedido";
            this.tbIDPedido.Size = new System.Drawing.Size(103, 26);
            this.tbIDPedido.TabIndex = 1;
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel11.SetColumnSpan(this.tbEmpleado, 4);
            this.tbEmpleado.Location = new System.Drawing.Point(98, 63);
            this.tbEmpleado.MaxLength = 100;
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(469, 26);
            this.tbEmpleado.TabIndex = 2;
            // 
            // tbReferencia
            // 
            this.tbReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel11.SetColumnSpan(this.tbReferencia, 4);
            this.tbReferencia.Location = new System.Drawing.Point(98, 93);
            this.tbReferencia.MaxLength = 100;
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(469, 26);
            this.tbReferencia.TabIndex = 3;
            // 
            // cbEfectivo
            // 
            this.cbEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbEfectivo.AutoSize = true;
            this.cbEfectivo.Checked = true;
            this.cbEfectivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEfectivo.Location = new System.Drawing.Point(723, 3);
            this.cbEfectivo.Name = "cbEfectivo";
            this.cbEfectivo.Size = new System.Drawing.Size(85, 24);
            this.cbEfectivo.TabIndex = 6;
            this.cbEfectivo.Text = "Efectivo";
            this.cbEfectivo.UseVisualStyleBackColor = true;
            // 
            // cbTarjeta
            // 
            this.cbTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbTarjeta.AutoSize = true;
            this.cbTarjeta.Checked = true;
            this.cbTarjeta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTarjeta.Location = new System.Drawing.Point(723, 33);
            this.cbTarjeta.Name = "cbTarjeta";
            this.cbTarjeta.Size = new System.Drawing.Size(77, 24);
            this.cbTarjeta.TabIndex = 7;
            this.cbTarjeta.Text = "Tarjeta";
            this.cbTarjeta.UseVisualStyleBackColor = true;
            // 
            // cbCheque
            // 
            this.cbCheque.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCheque.AutoSize = true;
            this.cbCheque.Checked = true;
            this.cbCheque.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCheque.Location = new System.Drawing.Point(723, 63);
            this.cbCheque.Name = "cbCheque";
            this.cbCheque.Size = new System.Drawing.Size(84, 24);
            this.cbCheque.TabIndex = 8;
            this.cbCheque.Text = "Cheque";
            this.cbCheque.UseVisualStyleBackColor = true;
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolucion.BackColor = System.Drawing.Color.White;
            this.btnDevolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDevolucion.ForeColor = System.Drawing.Color.Black;
            this.btnDevolucion.Location = new System.Drawing.Point(818, 3);
            this.btnDevolucion.Name = "btnDevolucion";
            this.tableLayoutPanel11.SetRowSpan(this.btnDevolucion, 2);
            this.btnDevolucion.Size = new System.Drawing.Size(100, 54);
            this.btnDevolucion.TabIndex = 10;
            this.btnDevolucion.Text = "Devolucion";
            this.btnDevolucion.UseVisualStyleBackColor = false;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 8;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.btnDevolucion, 7, 0);
            this.tableLayoutPanel11.Controls.Add(this.cbCheque, 6, 2);
            this.tableLayoutPanel11.Controls.Add(this.cbTarjeta, 6, 1);
            this.tableLayoutPanel11.Controls.Add(this.cbEfectivo, 6, 0);
            this.tableLayoutPanel11.Controls.Add(this.dtpMax, 5, 0);
            this.tableLayoutPanel11.Controls.Add(this.tbIDPedido, 1, 1);
            this.tableLayoutPanel11.Controls.Add(label3, 4, 0);
            this.tableLayoutPanel11.Controls.Add(this.tbIDVenta, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.dtpMin, 3, 0);
            this.tableLayoutPanel11.Controls.Add(this.tbReferencia, 1, 3);
            this.tableLayoutPanel11.Controls.Add(label2, 2, 0);
            this.tableLayoutPanel11.Controls.Add(label6, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.tbEmpleado, 1, 2);
            this.tableLayoutPanel11.Controls.Add(label4, 0, 1);
            this.tableLayoutPanel11.Controls.Add(label5, 0, 2);
            this.tableLayoutPanel11.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.kuroDGV1, 0, 4);
            this.tableLayoutPanel11.Controls.Add(this.btnBuscar, 7, 2);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 5;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(921, 328);
            this.tableLayoutPanel11.TabIndex = 8;
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
            this.IDVenta,
            this.FechaPago,
            this.IDPedido,
            this.Empleado,
            this.Importe,
            this.Referencia,
            this.FormaPago});
            this.tableLayoutPanel11.SetColumnSpan(this.kuroDGV1, 8);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kuroDGV1.DefaultCellStyle = dataGridViewCellStyle1;
            this.kuroDGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kuroDGV1.GridColor = System.Drawing.Color.Black;
            this.kuroDGV1.Location = new System.Drawing.Point(3, 123);
            this.kuroDGV1.MultiSelect = false;
            this.kuroDGV1.Name = "kuroDGV1";
            this.kuroDGV1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.kuroDGV1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kuroDGV1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.kuroDGV1.Size = new System.Drawing.Size(915, 202);
            this.kuroDGV1.TabIndex = 1;
            this.kuroDGV1.TabStop = false;
            // 
            // IDVenta
            // 
            this.IDVenta.FillWeight = 40F;
            this.IDVenta.HeaderText = "IDVenta";
            this.IDVenta.Name = "IDVenta";
            this.IDVenta.ReadOnly = true;
            // 
            // FechaPago
            // 
            this.FechaPago.HeaderText = "Fecha de Pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            // 
            // IDPedido
            // 
            this.IDPedido.FillWeight = 50F;
            this.IDPedido.HeaderText = "IDPedido";
            this.IDPedido.Name = "IDPedido";
            this.IDPedido.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.FillWeight = 50F;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Referencia
            // 
            this.Referencia.FillWeight = 80F;
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            // 
            // FormaPago
            // 
            this.FormaPago.FillWeight = 80F;
            this.FormaPago.HeaderText = "Forma de Pago";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.ReadOnly = true;
            // 
            // PantallaVerVentas
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 328);
            this.Controls.Add(this.tableLayoutPanel11);
            this.Name = "PantallaVerVentas";
            this.Text = "VerVentas";
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ControlesM.KuroButton btnBuscar;
        private System.Windows.Forms.TextBox tbIDVenta;
        private System.Windows.Forms.DateTimePicker dtpMin;
        private System.Windows.Forms.DateTimePicker dtpMax;
        private System.Windows.Forms.TextBox tbIDPedido;
        private System.Windows.Forms.TextBox tbEmpleado;
        private System.Windows.Forms.TextBox tbReferencia;
        private System.Windows.Forms.CheckBox cbEfectivo;
        private System.Windows.Forms.CheckBox cbTarjeta;
        private System.Windows.Forms.CheckBox cbCheque;
        private ControlesM.KuroButton btnDevolucion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private ControlesM.KuroDGV kuroDGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPago;
    }
}