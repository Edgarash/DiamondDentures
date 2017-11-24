namespace Presentacion.Finanzas
{
    partial class FinanzasAdministracionPagos
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
            this.dtPagos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txInfo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPagos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Size = new System.Drawing.Size(724, 93);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "Administración de Pagos";
            // 
            // dtPagos
            // 
            this.dtPagos.AllowUserToAddRows = false;
            this.dtPagos.AllowUserToDeleteRows = false;
            this.dtPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtPagos.BackgroundColor = System.Drawing.Color.White;
            this.dtPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPagos.Location = new System.Drawing.Point(17, 209);
            this.dtPagos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtPagos.Name = "dtPagos";
            this.dtPagos.ReadOnly = true;
            this.dtPagos.RowHeadersVisible = false;
            this.dtPagos.Size = new System.Drawing.Size(695, 231);
            this.dtPagos.TabIndex = 28;
            this.dtPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPagos_CellClick);
            this.dtPagos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPagos_CellDoubleClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(7, 10);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 42);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(625, 448);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(87, 42);
            this.btnPagar.TabIndex = 32;
            this.btnPagar.Text = "Realizar\r\nPago...";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txInfo
            // 
            this.txInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txInfo.Location = new System.Drawing.Point(17, 456);
            this.txInfo.Name = "txInfo";
            this.txInfo.ReadOnly = true;
            this.txInfo.Size = new System.Drawing.Size(601, 27);
            this.txInfo.TabIndex = 33;
            this.txInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbBuscar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Location = new System.Drawing.Point(17, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 60);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 22);
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
            this.tbBuscar.Location = new System.Drawing.Point(397, 19);
            this.tbBuscar.MaxLength = 20;
            this.tbBuscar.Multiline = true;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(245, 24);
            this.tbBuscar.TabIndex = 49;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Presentacion.Properties.Resources.IconoBuscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(648, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 41);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txTotal
            // 
            this.txTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotal.Location = new System.Drawing.Point(17, 162);
            this.txTotal.Multiline = true;
            this.txTotal.Name = "txTotal";
            this.txTotal.ReadOnly = true;
            this.txTotal.Size = new System.Drawing.Size(695, 40);
            this.txTotal.TabIndex = 32;
            this.txTotal.Text = "FONDO = ";
            this.txTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FinanzasAdministracionPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 498);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txInfo);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dtPagos);
            this.Name = "FinanzasAdministracionPagos";
            this.Text = "FinanzasAdministracionPagos";
            this.Load += new System.EventHandler(this.FinanzasAdministracionPagos_Load);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.dtPagos, 0);
            this.Controls.SetChildIndex(this.btnPagar, 0);
            this.Controls.SetChildIndex(this.txInfo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txTotal, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPagos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dtPagos;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txInfo;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox tbBuscar;
        protected System.Windows.Forms.Button btnBuscar;
    }
}