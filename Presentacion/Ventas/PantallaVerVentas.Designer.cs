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
            this.kuroDGV1 = new ControlesM.KuroDGV();
            this.IDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDevolucion = new ControlesM.KuroButton();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "IDVenta:  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(189, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha Min.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(424, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha Máx.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 44);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 20);
            label4.TabIndex = 2;
            label4.Text = "IDPedido:  ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(89, 20);
            label5.TabIndex = 2;
            label5.Text = "Empleado: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 105);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(95, 20);
            label6.TabIndex = 2;
            label6.Text = "Referencia: ";
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
            this.kuroDGV1.Location = new System.Drawing.Point(0, 0);
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
            this.kuroDGV1.Size = new System.Drawing.Size(965, 368);
            this.kuroDGV1.TabIndex = 0;
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(823, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 50);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // tbIDVenta
            // 
            this.tbIDVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIDVenta.Location = new System.Drawing.Point(80, 9);
            this.tbIDVenta.MaxLength = 10;
            this.tbIDVenta.Name = "tbIDVenta";
            this.tbIDVenta.Size = new System.Drawing.Size(94, 26);
            this.tbIDVenta.TabIndex = 0;
            // 
            // dtpMin
            // 
            this.dtpMin.Checked = false;
            this.dtpMin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMin.Location = new System.Drawing.Point(286, 7);
            this.dtpMin.Name = "dtpMin";
            this.dtpMin.ShowCheckBox = true;
            this.dtpMin.Size = new System.Drawing.Size(132, 26);
            this.dtpMin.TabIndex = 4;
            // 
            // dtpMax
            // 
            this.dtpMax.Checked = false;
            this.dtpMax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMax.Location = new System.Drawing.Point(525, 7);
            this.dtpMax.Name = "dtpMax";
            this.dtpMax.ShowCheckBox = true;
            this.dtpMax.Size = new System.Drawing.Size(132, 26);
            this.dtpMax.TabIndex = 5;
            // 
            // tbIDPedido
            // 
            this.tbIDPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIDPedido.Location = new System.Drawing.Point(80, 41);
            this.tbIDPedido.MaxLength = 10;
            this.tbIDPedido.Name = "tbIDPedido";
            this.tbIDPedido.Size = new System.Drawing.Size(94, 26);
            this.tbIDPedido.TabIndex = 1;
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEmpleado.Location = new System.Drawing.Point(98, 73);
            this.tbEmpleado.MaxLength = 100;
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(382, 26);
            this.tbEmpleado.TabIndex = 2;
            // 
            // tbReferencia
            // 
            this.tbReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbReferencia.Location = new System.Drawing.Point(98, 102);
            this.tbReferencia.MaxLength = 100;
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(382, 26);
            this.tbReferencia.TabIndex = 3;
            // 
            // cbEfectivo
            // 
            this.cbEfectivo.AutoSize = true;
            this.cbEfectivo.Checked = true;
            this.cbEfectivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEfectivo.Location = new System.Drawing.Point(673, 11);
            this.cbEfectivo.Name = "cbEfectivo";
            this.cbEfectivo.Size = new System.Drawing.Size(85, 24);
            this.cbEfectivo.TabIndex = 6;
            this.cbEfectivo.Text = "Efectivo";
            this.cbEfectivo.UseVisualStyleBackColor = true;
            // 
            // cbTarjeta
            // 
            this.cbTarjeta.AutoSize = true;
            this.cbTarjeta.Checked = true;
            this.cbTarjeta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTarjeta.Location = new System.Drawing.Point(673, 40);
            this.cbTarjeta.Name = "cbTarjeta";
            this.cbTarjeta.Size = new System.Drawing.Size(77, 24);
            this.cbTarjeta.TabIndex = 7;
            this.cbTarjeta.Text = "Tarjeta";
            this.cbTarjeta.UseVisualStyleBackColor = true;
            // 
            // cbCheque
            // 
            this.cbCheque.AutoSize = true;
            this.cbCheque.Checked = true;
            this.cbCheque.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCheque.Location = new System.Drawing.Point(673, 70);
            this.cbCheque.Name = "cbCheque";
            this.cbCheque.Size = new System.Drawing.Size(84, 24);
            this.cbCheque.TabIndex = 8;
            this.cbCheque.Text = "Cheque";
            this.cbCheque.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDevolucion);
            this.splitContainer1.Panel1.Controls.Add(this.tbIDVenta);
            this.splitContainer1.Panel1.Controls.Add(this.tbIDPedido);
            this.splitContainer1.Panel1.Controls.Add(label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbCheque);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.cbTarjeta);
            this.splitContainer1.Panel1.Controls.Add(label4);
            this.splitContainer1.Panel1.Controls.Add(this.cbEfectivo);
            this.splitContainer1.Panel1.Controls.Add(label5);
            this.splitContainer1.Panel1.Controls.Add(this.dtpMax);
            this.splitContainer1.Panel1.Controls.Add(label6);
            this.splitContainer1.Panel1.Controls.Add(this.dtpMin);
            this.splitContainer1.Panel1.Controls.Add(label2);
            this.splitContainer1.Panel1.Controls.Add(this.tbReferencia);
            this.splitContainer1.Panel1.Controls.Add(label3);
            this.splitContainer1.Panel1.Controls.Add(this.tbEmpleado);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.kuroDGV1);
            this.splitContainer1.Size = new System.Drawing.Size(965, 519);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.BackColor = System.Drawing.Color.White;
            this.btnDevolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDevolucion.ForeColor = System.Drawing.Color.Black;
            this.btnDevolucion.Location = new System.Drawing.Point(922, 9);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(21, 23);
            this.btnDevolucion.TabIndex = 10;
            this.btnDevolucion.Text = "Devolucion";
            this.btnDevolucion.UseVisualStyleBackColor = false;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // PantallaVerVentas
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 519);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PantallaVerVentas";
            this.Text = "VerVentas";
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesM.KuroDGV kuroDGV1;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPago;
        private ControlesM.KuroButton btnDevolucion;
    }
}