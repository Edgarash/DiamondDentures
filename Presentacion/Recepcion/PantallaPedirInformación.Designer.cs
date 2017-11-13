namespace Presentacion.Recepcion
{
    partial class PantallaPedirInformación
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
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.tbNumEmpleado = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPedir = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.lblTitulo);
            this.Encabezado.Controls.Add(this.pbIcono);
            this.Encabezado.Size = new System.Drawing.Size(503, 93);
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoPedidoNúmero;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcono.Location = new System.Drawing.Point(22, 16);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(60, 60);
            this.pbIcono.TabIndex = 13;
            this.pbIcono.TabStop = false;
            // 
            // tbNumEmpleado
            // 
            this.tbNumEmpleado.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumEmpleado.Location = new System.Drawing.Point(150, 183);
            this.tbNumEmpleado.Name = "tbNumEmpleado";
            this.tbNumEmpleado.ShortcutsEnabled = false;
            this.tbNumEmpleado.Size = new System.Drawing.Size(202, 43);
            this.tbNumEmpleado.TabIndex = 14;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(73, 103);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(356, 17);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "Ingrese número de pedido a Modificar / Eliminar";
            // 
            // lblPedir
            // 
            this.lblPedir.AutoSize = true;
            this.lblPedir.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedir.Location = new System.Drawing.Point(179, 135);
            this.lblPedir.Name = "lblPedir";
            this.lblPedir.Size = new System.Drawing.Size(145, 33);
            this.lblPedir.TabIndex = 12;
            this.lblPedir.Text = "# Pedido:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(96, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(93, 24);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "#Pedido";
            // 
            // PantallaPedirInformación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(503, 249);
            this.Controls.Add(this.tbNumEmpleado);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPedir);
            this.Name = "PantallaPedirInformación";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.lblPedir, 0);
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.tbNumEmpleado, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.TextBox tbNumEmpleado;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPedir;
        protected System.Windows.Forms.Label lblTitulo;
    }
}
