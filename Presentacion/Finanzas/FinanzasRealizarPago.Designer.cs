namespace Presentacion.Finanzas
{
    partial class FinanzasRealizarPago
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
            this.txNumCuenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnGenRep = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txDatos = new System.Windows.Forms.RichTextBox();
            this.txBanco = new System.Windows.Forms.TextBox();
            this.txBeneficiario = new System.Windows.Forms.TextBox();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label3);
            this.Encabezado.Size = new System.Drawing.Size(306, 93);
            // 
            // txNumCuenta
            // 
            this.txNumCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txNumCuenta.Location = new System.Drawing.Point(14, 247);
            this.txNumCuenta.MaxLength = 50;
            this.txNumCuenta.Name = "txNumCuenta";
            this.txNumCuenta.ShortcutsEnabled = false;
            this.txNumCuenta.Size = new System.Drawing.Size(152, 21);
            this.txNumCuenta.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "Banco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Beneficiario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "N° de Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 36);
            this.label3.TabIndex = 30;
            this.label3.Text = "Realizar Pago";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(208, 172);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(88, 41);
            this.btnPagar.TabIndex = 84;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnGenRep
            // 
            this.btnGenRep.Location = new System.Drawing.Point(208, 227);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(88, 42);
            this.btnGenRep.TabIndex = 85;
            this.btnGenRep.Text = "Generar \r\nReporte";
            this.btnGenRep.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 21);
            this.button1.TabIndex = 86;
            this.button1.Text = "Ver Pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(209, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 21);
            this.button2.TabIndex = 88;
            this.button2.Text = "ocultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txDatos
            // 
            this.txDatos.Location = new System.Drawing.Point(316, 101);
            this.txDatos.Name = "txDatos";
            this.txDatos.Size = new System.Drawing.Size(170, 172);
            this.txDatos.TabIndex = 87;
            this.txDatos.Text = "";
            // 
            // txBanco
            // 
            this.txBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txBanco.Location = new System.Drawing.Point(12, 192);
            this.txBanco.MaxLength = 50;
            this.txBanco.Name = "txBanco";
            this.txBanco.ShortcutsEnabled = false;
            this.txBanco.Size = new System.Drawing.Size(152, 21);
            this.txBanco.TabIndex = 89;
            // 
            // txBeneficiario
            // 
            this.txBeneficiario.Location = new System.Drawing.Point(11, 134);
            this.txBeneficiario.Name = "txBeneficiario";
            this.txBeneficiario.Size = new System.Drawing.Size(153, 21);
            this.txBeneficiario.TabIndex = 90;
            // 
            // FinanzasRealizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 285);
            this.Controls.Add(this.txBeneficiario);
            this.Controls.Add(this.txBanco);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenRep);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txNumCuenta);
            this.Name = "FinanzasRealizarPago";
            this.Text = "FinanzasRealizarPago";
            this.Load += new System.EventHandler(this.FinanzasRealizarPago_Load);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.txNumCuenta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnPagar, 0);
            this.Controls.SetChildIndex(this.btnGenRep, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txDatos, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.txBanco, 0);
            this.Controls.SetChildIndex(this.txBeneficiario, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txNumCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnGenRep;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txDatos;
        protected System.Windows.Forms.TextBox txBanco;
        private System.Windows.Forms.TextBox txBeneficiario;
    }
}