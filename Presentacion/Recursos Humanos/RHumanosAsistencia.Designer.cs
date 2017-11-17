namespace Presentacion.Recursos_Humanos
{
    partial class RHumanosAsistencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGenRep = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dtAsistencia = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txSal = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txEnt = new System.Windows.Forms.MaskedTextBox();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAsistencia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Size = new System.Drawing.Size(601, 93);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asistencia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbBuscar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnGenRep);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 60);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Buscar: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbBuscar
            // 
            this.tbBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(280, 21);
            this.tbBuscar.MaxLength = 20;
            this.tbBuscar.Multiline = true;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(245, 24);
            this.tbBuscar.TabIndex = 49;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Presentacion.Properties.Resources.IconoBuscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(531, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 41);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnGenRep
            // 
            this.btnGenRep.Location = new System.Drawing.Point(99, 9);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(88, 42);
            this.btnGenRep.TabIndex = 30;
            this.btnGenRep.Text = "Generar \r\nReporte";
            this.btnGenRep.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(6, 9);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 42);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dtAsistencia
            // 
            this.dtAsistencia.AllowUserToAddRows = false;
            this.dtAsistencia.AllowUserToDeleteRows = false;
            this.dtAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAsistencia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtAsistencia.BackgroundColor = System.Drawing.Color.White;
            this.dtAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAsistencia.Location = new System.Drawing.Point(18, 163);
            this.dtAsistencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtAsistencia.Name = "dtAsistencia";
            this.dtAsistencia.ReadOnly = true;
            this.dtAsistencia.RowHeadersVisible = false;
            this.dtAsistencia.Size = new System.Drawing.Size(567, 192);
            this.dtAsistencia.TabIndex = 61;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txSal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txEnt);
            this.groupBox2.Controls.Add(this.cbDia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbAño);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbMes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txEmpleado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(18, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 152);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AGREGAR ASISTENCIA MANUAL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 42);
            this.button1.TabIndex = 52;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 24);
            this.comboBox1.TabIndex = 76;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(281, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 32);
            this.label10.TabIndex = 75;
            this.label10.Text = "Hora de\r\nSalida:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txSal
            // 
            this.txSal.Location = new System.Drawing.Point(361, 111);
            this.txSal.Mask = "00:00";
            this.txSal.Name = "txSal";
            this.txSal.Size = new System.Drawing.Size(37, 21);
            this.txSal.TabIndex = 74;
            this.txSal.Text = "1600";
            this.txSal.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(281, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 32);
            this.label9.TabIndex = 73;
            this.label9.Text = "Hora de\r\nEntrada:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txEnt
            // 
            this.txEnt.Location = new System.Drawing.Point(361, 73);
            this.txEnt.Mask = "00:00";
            this.txEnt.Name = "txEnt";
            this.txEnt.Size = new System.Drawing.Size(37, 21);
            this.txEnt.TabIndex = 72;
            this.txEnt.Text = "0800";
            this.txEnt.ValidatingType = typeof(System.DateTime);
            // 
            // cbDia
            // 
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDia.Location = new System.Drawing.Point(69, 73);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(47, 24);
            this.cbDia.TabIndex = 66;
            this.cbDia.Text = "15";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 71;
            this.label8.Text = "Día";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbAño
            // 
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbAño.Location = new System.Drawing.Point(161, 73);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(53, 24);
            this.cbAño.TabIndex = 70;
            this.cbAño.Text = "2017";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "Año";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMes.Location = new System.Drawing.Point(115, 73);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(47, 24);
            this.cbMes.TabIndex = 68;
            this.cbMes.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "Mes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Fecha: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Empleado: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txEmpleado
            // 
            this.txEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txEmpleado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmpleado.Location = new System.Drawing.Point(361, 33);
            this.txEmpleado.MaxLength = 20;
            this.txEmpleado.Multiline = true;
            this.txEmpleado.Name = "txEmpleado";
            this.txEmpleado.Size = new System.Drawing.Size(199, 24);
            this.txEmpleado.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Id Empleado: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RHumanosAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtAsistencia);
            this.Controls.Add(this.groupBox1);
            this.Name = "RHumanosAsistencia";
            this.Text = "RHumanosAsistencia";
            this.Load += new System.EventHandler(this.RHumanosAsistencia_Load);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dtAsistencia, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAsistencia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenRep;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dtAsistencia;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox tbBuscar;
        protected System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txSal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txEnt;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}