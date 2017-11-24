namespace Presentacion.Finanzas
{
    partial class FinanzasMenu
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
            this.btnFinanzasVentas = new System.Windows.Forms.Button();
            this.btnFinanzasGastos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnComIns = new System.Windows.Forms.Button();
            this.btnVerInsumos = new System.Windows.Forms.Button();
            this.btnAdmPag = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label9);
            this.Encabezado.Size = new System.Drawing.Size(284, 93);
            // 
            // btnFinanzasVentas
            // 
            this.btnFinanzasVentas.Location = new System.Drawing.Point(31, 132);
            this.btnFinanzasVentas.Name = "btnFinanzasVentas";
            this.btnFinanzasVentas.Size = new System.Drawing.Size(92, 62);
            this.btnFinanzasVentas.TabIndex = 9;
            this.btnFinanzasVentas.Text = "Consulta Ventas";
            this.btnFinanzasVentas.UseVisualStyleBackColor = true;
            this.btnFinanzasVentas.Click += new System.EventHandler(this.btnFinanzasVentas_Click);
            // 
            // btnFinanzasGastos
            // 
            this.btnFinanzasGastos.Location = new System.Drawing.Point(31, 228);
            this.btnFinanzasGastos.Name = "btnFinanzasGastos";
            this.btnFinanzasGastos.Size = new System.Drawing.Size(92, 62);
            this.btnFinanzasGastos.TabIndex = 10;
            this.btnFinanzasGastos.Text = "Consulta Compras";
            this.btnFinanzasGastos.UseVisualStyleBackColor = true;
            this.btnFinanzasGastos.Click += new System.EventHandler(this.btnFinanzasGastos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 17.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(26, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 28);
            this.label9.TabIndex = 57;
            this.label9.Text = "Menú de Finanzas";
            // 
            // btnComIns
            // 
            this.btnComIns.Location = new System.Drawing.Point(162, 112);
            this.btnComIns.Name = "btnComIns";
            this.btnComIns.Size = new System.Drawing.Size(92, 62);
            this.btnComIns.TabIndex = 12;
            this.btnComIns.Text = "Comprar Insumos";
            this.btnComIns.UseVisualStyleBackColor = true;
            this.btnComIns.Click += new System.EventHandler(this.btnComIns_Click);
            // 
            // btnVerInsumos
            // 
            this.btnVerInsumos.Location = new System.Drawing.Point(162, 180);
            this.btnVerInsumos.Name = "btnVerInsumos";
            this.btnVerInsumos.Size = new System.Drawing.Size(92, 62);
            this.btnVerInsumos.TabIndex = 13;
            this.btnVerInsumos.Text = "Colsulta Ver Insumos";
            this.btnVerInsumos.UseVisualStyleBackColor = true;
            this.btnVerInsumos.Click += new System.EventHandler(this.btnVerInsumos_Click);
            // 
            // btnAdmPag
            // 
            this.btnAdmPag.Location = new System.Drawing.Point(162, 248);
            this.btnAdmPag.Name = "btnAdmPag";
            this.btnAdmPag.Size = new System.Drawing.Size(92, 62);
            this.btnAdmPag.TabIndex = 14;
            this.btnAdmPag.Text = "Administrar pagos";
            this.btnAdmPag.UseVisualStyleBackColor = true;
            this.btnAdmPag.Click += new System.EventHandler(this.btnAdmPag_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(0, 309);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(18, 12);
            this.btnBalance.TabIndex = 16;
            this.btnBalance.Text = "Balance Cuentas";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // FinanzasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnAdmPag);
            this.Controls.Add(this.btnVerInsumos);
            this.Controls.Add(this.btnComIns);
            this.Controls.Add(this.btnFinanzasGastos);
            this.Controls.Add(this.btnFinanzasVentas);
            this.Name = "FinanzasMenu";
            this.Text = "FinanzasMenu";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.btnFinanzasVentas, 0);
            this.Controls.SetChildIndex(this.btnFinanzasGastos, 0);
            this.Controls.SetChildIndex(this.btnComIns, 0);
            this.Controls.SetChildIndex(this.btnVerInsumos, 0);
            this.Controls.SetChildIndex(this.btnAdmPag, 0);
            this.Controls.SetChildIndex(this.btnBalance, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinanzasVentas;
        private System.Windows.Forms.Button btnFinanzasGastos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnComIns;
        private System.Windows.Forms.Button btnVerInsumos;
        private System.Windows.Forms.Button btnAdmPag;
        private System.Windows.Forms.Button btnBalance;
    }
}