namespace Presentacion.Recepcion
{
    partial class PantallaModificarPedido
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
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador2)).BeginInit();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.Size = new System.Drawing.Size(181, 24);
            this.lblPantallaUsuario.Text = "Modificar Pedido";
            // 
            // pbIcono
            // 
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoPedidoModificar;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            // 
            // lblAceptar
            // 
            this.lblAceptar.Size = new System.Drawing.Size(75, 18);
            this.lblAceptar.Text = "Guardar";
            // 
            // btnDentista
            // 
            this.btnDentista.FlatAppearance.BorderSize = 0;
            this.btnDentista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDentista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            // 
            // PantallaModificarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(810, 693);
            this.Name = "PantallaModificarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador2)).EndInit();
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
