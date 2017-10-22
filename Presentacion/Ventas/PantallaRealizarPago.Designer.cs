namespace Presentacion.Ventas
{
    partial class PantallaRealizarPago
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblRestante = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.tbRecibe = new System.Windows.Forms.TextBox();
            this.kuroButton1 = new ControlesM.KuroButton();
            this.tbPersonaPaga = new System.Windows.Forms.TextBox();
            this.tbAbono = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "#Pedido: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 20);
            label2.TabIndex = 0;
            label2.Text = "Restante A Pagar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            label4.Location = new System.Drawing.Point(13, 126);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(124, 31);
            label4.TabIndex = 0;
            label4.Text = "RECIBE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.White;
            label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(132, 123);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 37);
            label5.TabIndex = 0;
            label5.Text = "$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(218, 177);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(228, 20);
            label3.TabIndex = 0;
            label3.Text = "Se Recibe Pago A Nombre De:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            label6.Location = new System.Drawing.Point(13, 82);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(120, 31);
            label6.TabIndex = 0;
            label6.Text = "ABONO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.White;
            label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(132, 79);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(34, 37);
            label7.TabIndex = 0;
            label7.Text = "$";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCambio.Location = new System.Drawing.Point(323, 126);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(129, 31);
            this.lblCambio.TabIndex = 0;
            this.lblCambio.Text = "CAMBIO:";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(85, 13);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(64, 20);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "XXXXX";
            // 
            // lblRestante
            // 
            this.lblRestante.AutoSize = true;
            this.lblRestante.Location = new System.Drawing.Point(159, 43);
            this.lblRestante.Name = "lblRestante";
            this.lblRestante.Size = new System.Drawing.Size(64, 20);
            this.lblRestante.TabIndex = 0;
            this.lblRestante.Text = "XXXXX";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCheque);
            this.groupBox1.Controls.Add(this.rbTarjeta);
            this.groupBox1.Controls.Add(this.rbEfectivo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas De Pago";
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Location = new System.Drawing.Point(17, 85);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(96, 24);
            this.rbCheque.TabIndex = 4;
            this.rbCheque.Text = "CHEQUE";
            this.rbCheque.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(17, 55);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(98, 24);
            this.rbTarjeta.TabIndex = 3;
            this.rbTarjeta.Text = "TARJETA";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Location = new System.Drawing.Point(17, 25);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(107, 24);
            this.rbEfectivo.TabIndex = 2;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "EFECTIVO";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // tbRecibe
            // 
            this.tbRecibe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbRecibe.Location = new System.Drawing.Point(166, 123);
            this.tbRecibe.MaxLength = 7;
            this.tbRecibe.Name = "tbRecibe";
            this.tbRecibe.Size = new System.Drawing.Size(151, 38);
            this.tbRecibe.TabIndex = 1;
            this.tbRecibe.TextChanged += new System.EventHandler(this.CalcularCambio);
            // 
            // kuroButton1
            // 
            this.kuroButton1.BackColor = System.Drawing.Color.White;
            this.kuroButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.kuroButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kuroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kuroButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.kuroButton1.ForeColor = System.Drawing.Color.Black;
            this.kuroButton1.Location = new System.Drawing.Point(12, 295);
            this.kuroButton1.Name = "kuroButton1";
            this.kuroButton1.Size = new System.Drawing.Size(560, 50);
            this.kuroButton1.TabIndex = 6;
            this.kuroButton1.Text = "Aceptar";
            this.kuroButton1.UseVisualStyleBackColor = false;
            this.kuroButton1.Click += new System.EventHandler(this.kuroButton1_Click);
            // 
            // tbPersonaPaga
            // 
            this.tbPersonaPaga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPersonaPaga.Location = new System.Drawing.Point(222, 201);
            this.tbPersonaPaga.MaxLength = 50;
            this.tbPersonaPaga.Multiline = true;
            this.tbPersonaPaga.Name = "tbPersonaPaga";
            this.tbPersonaPaga.Size = new System.Drawing.Size(345, 88);
            this.tbPersonaPaga.TabIndex = 5;
            this.tbPersonaPaga.Text = "CLIENTE";
            // 
            // tbAbono
            // 
            this.tbAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbAbono.Location = new System.Drawing.Point(166, 79);
            this.tbAbono.MaxLength = 7;
            this.tbAbono.Name = "tbAbono";
            this.tbAbono.Size = new System.Drawing.Size(151, 38);
            this.tbAbono.TabIndex = 0;
            this.tbAbono.TextChanged += new System.EventHandler(this.CalcularCambio);
            // 
            // PantallaRealizarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(584, 357);
            this.Controls.Add(this.tbPersonaPaga);
            this.Controls.Add(this.kuroButton1);
            this.Controls.Add(label7);
            this.Controls.Add(label5);
            this.Controls.Add(this.tbAbono);
            this.Controls.Add(this.tbRecibe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRestante);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(label6);
            this.Controls.Add(label4);
            this.Controls.Add(label1);
            this.Name = "PantallaRealizarPago";
            this.Text = "Realizar Pago";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblRestante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.TextBox tbRecibe;
        private ControlesM.KuroButton kuroButton1;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox tbPersonaPaga;
        private System.Windows.Forms.TextBox tbAbono;
    }
}
