namespace Presentacion.Finanzas
{
    partial class FinanzasComprarInsumos
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
            this.txID = new System.Windows.Forms.TextBox();
            this.txNom = new System.Windows.Forms.TextBox();
            this.txCant = new System.Windows.Forms.TextBox();
            this.txDesc = new System.Windows.Forms.TextBox();
            this.txPreUni = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenRep = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Size = new System.Drawing.Size(359, 93);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Comprar Insumos";
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(78, 20);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(100, 21);
            this.txID.TabIndex = 14;
            // 
            // txNom
            // 
            this.txNom.Location = new System.Drawing.Point(78, 120);
            this.txNom.Name = "txNom";
            this.txNom.Size = new System.Drawing.Size(100, 21);
            this.txNom.TabIndex = 15;
            // 
            // txCant
            // 
            this.txCant.Location = new System.Drawing.Point(78, 180);
            this.txCant.Name = "txCant";
            this.txCant.Size = new System.Drawing.Size(100, 21);
            this.txCant.TabIndex = 17;
            // 
            // txDesc
            // 
            this.txDesc.Location = new System.Drawing.Point(193, 158);
            this.txDesc.Multiline = true;
            this.txDesc.Name = "txDesc";
            this.txDesc.Size = new System.Drawing.Size(134, 74);
            this.txDesc.TabIndex = 18;
            // 
            // txPreUni
            // 
            this.txPreUni.Location = new System.Drawing.Point(78, 237);
            this.txPreUni.Name = "txPreUni";
            this.txPreUni.Size = new System.Drawing.Size(100, 21);
            this.txPreUni.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txProveedor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnGenRep);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnComprar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txID);
            this.groupBox1.Controls.Add(this.txPreUni);
            this.groupBox1.Controls.Add(this.txNom);
            this.groupBox1.Controls.Add(this.txDesc);
            this.groupBox1.Controls.Add(this.txCant);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 274);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // txProveedor
            // 
            this.txProveedor.FormattingEnabled = true;
            this.txProveedor.Items.AddRange(new object[] {
            "NO INTEGRADO"});
            this.txProveedor.Location = new System.Drawing.Point(78, 65);
            this.txProveedor.Name = "txProveedor";
            this.txProveedor.Size = new System.Drawing.Size(100, 24);
            this.txProveedor.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Proveedor: ";
            // 
            // btnGenRep
            // 
            this.btnGenRep.Location = new System.Drawing.Point(239, 55);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(88, 42);
            this.btnGenRep.TabIndex = 26;
            this.btnGenRep.Text = "Generar \r\nReporte";
            this.btnGenRep.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(239, 238);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 20);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(239, 13);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(88, 36);
            this.btnComprar.TabIndex = 24;
            this.btnComprar.Text = "Registrar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Precio \r\nUnitario: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Descripción: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantidad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "IdCompra: ";
            // 
            // FinanzasComprarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 378);
            this.Controls.Add(this.groupBox1);
            this.Name = "FinanzasComprarInsumos";
            this.Text = "Comprar Insumos";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.TextBox txNom;
        private System.Windows.Forms.TextBox txCant;
        private System.Windows.Forms.TextBox txDesc;
        private System.Windows.Forms.TextBox txPreUni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenRep;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox txProveedor;
        private System.Windows.Forms.Label label7;
    }
}