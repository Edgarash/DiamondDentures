namespace Presentacion.Finanzas
{
    partial class FinanzasBalanceCuentas
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
            this.dtIngresos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.btnGenRep = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dtEgresos = new System.Windows.Forms.DataGridView();
            this.txIngresos = new System.Windows.Forms.TextBox();
            this.btnBalanceIngresos = new System.Windows.Forms.Button();
            this.btnBalanceEgresos = new System.Windows.Forms.Button();
            this.txEgresos = new System.Windows.Forms.TextBox();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtIngresos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Size = new System.Drawing.Size(506, 93);
            // 
            // dtIngresos
            // 
            this.dtIngresos.AllowUserToAddRows = false;
            this.dtIngresos.AllowUserToDeleteRows = false;
            this.dtIngresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtIngresos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtIngresos.BackgroundColor = System.Drawing.Color.White;
            this.dtIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtIngresos.Location = new System.Drawing.Point(12, 203);
            this.dtIngresos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtIngresos.Name = "dtIngresos";
            this.dtIngresos.ReadOnly = true;
            this.dtIngresos.RowHeadersVisible = false;
            this.dtIngresos.Size = new System.Drawing.Size(227, 164);
            this.dtIngresos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "Balance de Cuentas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txTotal);
            this.groupBox1.Controls.Add(this.btnGenRep);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 60);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // txTotal
            // 
            this.txTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotal.Location = new System.Drawing.Point(6, 12);
            this.txTotal.Multiline = true;
            this.txTotal.Name = "txTotal";
            this.txTotal.ReadOnly = true;
            this.txTotal.Size = new System.Drawing.Size(283, 40);
            this.txTotal.TabIndex = 31;
            this.txTotal.Text = "FONDO = ";
            // 
            // btnGenRep
            // 
            this.btnGenRep.Location = new System.Drawing.Point(388, 12);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(88, 42);
            this.btnGenRep.TabIndex = 27;
            this.btnGenRep.Text = "Generar \r\nReporte";
            this.btnGenRep.UseVisualStyleBackColor = true;
            this.btnGenRep.Click += new System.EventHandler(this.btnGenRep_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(295, 13);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 42);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dtEgresos
            // 
            this.dtEgresos.AllowUserToAddRows = false;
            this.dtEgresos.AllowUserToDeleteRows = false;
            this.dtEgresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtEgresos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtEgresos.BackgroundColor = System.Drawing.Color.White;
            this.dtEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEgresos.Location = new System.Drawing.Point(267, 203);
            this.dtEgresos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtEgresos.Name = "dtEgresos";
            this.dtEgresos.ReadOnly = true;
            this.dtEgresos.RowHeadersVisible = false;
            this.dtEgresos.Size = new System.Drawing.Size(227, 164);
            this.dtEgresos.TabIndex = 37;
            // 
            // txIngresos
            // 
            this.txIngresos.Location = new System.Drawing.Point(43, 374);
            this.txIngresos.Name = "txIngresos";
            this.txIngresos.Size = new System.Drawing.Size(100, 21);
            this.txIngresos.TabIndex = 38;
            // 
            // btnBalanceIngresos
            // 
            this.btnBalanceIngresos.Location = new System.Drawing.Point(149, 374);
            this.btnBalanceIngresos.Name = "btnBalanceIngresos";
            this.btnBalanceIngresos.Size = new System.Drawing.Size(75, 23);
            this.btnBalanceIngresos.TabIndex = 39;
            this.btnBalanceIngresos.Text = "Balance";
            this.btnBalanceIngresos.UseVisualStyleBackColor = true;
            this.btnBalanceIngresos.Click += new System.EventHandler(this.btnBalanceIngresos_Click);
            // 
            // btnBalanceEgresos
            // 
            this.btnBalanceEgresos.Location = new System.Drawing.Point(400, 372);
            this.btnBalanceEgresos.Name = "btnBalanceEgresos";
            this.btnBalanceEgresos.Size = new System.Drawing.Size(75, 23);
            this.btnBalanceEgresos.TabIndex = 41;
            this.btnBalanceEgresos.Text = "Balance";
            this.btnBalanceEgresos.UseVisualStyleBackColor = true;
            this.btnBalanceEgresos.Click += new System.EventHandler(this.btnBalanceEgresos_Click);
            // 
            // txEgresos
            // 
            this.txEgresos.Location = new System.Drawing.Point(294, 372);
            this.txEgresos.Name = "txEgresos";
            this.txEgresos.Size = new System.Drawing.Size(100, 21);
            this.txEgresos.TabIndex = 40;
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
            this.cbAño.Location = new System.Drawing.Point(157, 172);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(66, 24);
            this.cbAño.TabIndex = 74;
            this.cbAño.Text = "2017";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Año: ";
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
            this.cbMes.Location = new System.Drawing.Point(59, 172);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(47, 24);
            this.cbMes.TabIndex = 72;
            this.cbMes.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Mes: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FinanzasBalanceCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 417);
            this.Controls.Add(this.cbAño);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBalanceEgresos);
            this.Controls.Add(this.txEgresos);
            this.Controls.Add(this.btnBalanceIngresos);
            this.Controls.Add(this.txIngresos);
            this.Controls.Add(this.dtEgresos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtIngresos);
            this.Name = "FinanzasBalanceCuentas";
            this.Text = "FinanzasBalanceCuentas";
            this.Load += new System.EventHandler(this.FinanzasBalanceCuentas_Load);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.dtIngresos, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dtEgresos, 0);
            this.Controls.SetChildIndex(this.txIngresos, 0);
            this.Controls.SetChildIndex(this.btnBalanceIngresos, 0);
            this.Controls.SetChildIndex(this.txEgresos, 0);
            this.Controls.SetChildIndex(this.btnBalanceEgresos, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbMes, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cbAño, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtIngresos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEgresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtIngresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenRep;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.DataGridView dtEgresos;
        private System.Windows.Forms.TextBox txIngresos;
        private System.Windows.Forms.Button btnBalanceIngresos;
        private System.Windows.Forms.Button btnBalanceEgresos;
        private System.Windows.Forms.TextBox txEgresos;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label3;
    }
}