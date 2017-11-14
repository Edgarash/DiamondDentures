namespace Presentacion.Ventas
{
    partial class PantallaVentas
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
            this.btnRealizarPago = new ControlesM.KuroButton();
            this.btnVerVentas = new ControlesM.KuroButton();
            this.btnCorteCaja = new ControlesM.KuroButton();
            this.btnEntregar = new ControlesM.KuroButton();
            this.SuspendLayout();
            // 
            // btnRealizarPago
            // 
            this.btnRealizarPago.BackColor = System.Drawing.Color.White;
            this.btnRealizarPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRealizarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRealizarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRealizarPago.ForeColor = System.Drawing.Color.Black;
            this.btnRealizarPago.Location = new System.Drawing.Point(21, 16);
            this.btnRealizarPago.Name = "btnRealizarPago";
            this.btnRealizarPago.Size = new System.Drawing.Size(120, 50);
            this.btnRealizarPago.TabIndex = 0;
            this.btnRealizarPago.Text = "Realizar Pago";
            this.btnRealizarPago.UseVisualStyleBackColor = false;
            this.btnRealizarPago.Click += new System.EventHandler(this.RealizarPago_Click);
            // 
            // btnVerVentas
            // 
            this.btnVerVentas.BackColor = System.Drawing.Color.White;
            this.btnVerVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnVerVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVerVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVerVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVerVentas.Location = new System.Drawing.Point(177, 16);
            this.btnVerVentas.Name = "btnVerVentas";
            this.btnVerVentas.Size = new System.Drawing.Size(120, 50);
            this.btnVerVentas.TabIndex = 1;
            this.btnVerVentas.Text = "Ver Ventas";
            this.btnVerVentas.UseVisualStyleBackColor = false;
            this.btnVerVentas.Click += new System.EventHandler(this.VerVentas_Click);
            // 
            // btnCorteCaja
            // 
            this.btnCorteCaja.BackColor = System.Drawing.Color.White;
            this.btnCorteCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCorteCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorteCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCorteCaja.ForeColor = System.Drawing.Color.Black;
            this.btnCorteCaja.Location = new System.Drawing.Point(21, 108);
            this.btnCorteCaja.Name = "btnCorteCaja";
            this.btnCorteCaja.Size = new System.Drawing.Size(120, 50);
            this.btnCorteCaja.TabIndex = 1;
            this.btnCorteCaja.Text = "Corte Caja";
            this.btnCorteCaja.UseVisualStyleBackColor = false;
            this.btnCorteCaja.Click += new System.EventHandler(this.HacerCorteCaja_Click);
            // 
            // btnEntregar
            // 
            this.btnEntregar.BackColor = System.Drawing.Color.White;
            this.btnEntregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEntregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEntregar.ForeColor = System.Drawing.Color.Black;
            this.btnEntregar.Location = new System.Drawing.Point(177, 108);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(120, 50);
            this.btnEntregar.TabIndex = 2;
            this.btnEntregar.Text = "Entregas";
            this.btnEntregar.UseVisualStyleBackColor = false;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // PantallaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 174);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.btnCorteCaja);
            this.Controls.Add(this.btnVerVentas);
            this.Controls.Add(this.btnRealizarPago);
            this.Name = "PantallaVentas";
            this.Text = "PantallaVentas";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PantallaVentas_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesM.KuroButton btnRealizarPago;
        private ControlesM.KuroButton btnVerVentas;
        private ControlesM.KuroButton btnCorteCaja;
        private ControlesM.KuroButton btnEntregar;
    }
}