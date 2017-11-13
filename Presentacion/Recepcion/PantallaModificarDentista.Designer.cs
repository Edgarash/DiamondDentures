namespace Presentacion.Recepcion
{
    partial class PantallaModificarDentista
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
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.Size = new System.Drawing.Size(323, 24);
            this.lblPantallaUsuario.Text = "Modificar Información Dentista";
            // 
            // pbIcono
            // 
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoDentistaModificar;
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
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.Size = new System.Drawing.Size(168, 24);
            // 
            // cbPais
            // 
            this.cbPais.Size = new System.Drawing.Size(168, 24);
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.Size = new System.Drawing.Size(189, 24);
            // 
            // cbCiudad
            // 
            this.cbCiudad.Size = new System.Drawing.Size(161, 24);
            // 
            // cbEmail
            // 
            this.cbEmail.Size = new System.Drawing.Size(131, 24);
            // 
            // Encabezado
            // 
            this.Encabezado.Size = new System.Drawing.Size(591, 93);
            // 
            // PantallaModificarDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(591, 477);
            this.Name = "PantallaModificarDentista";
            this.Text = "Modificar Información Dentista";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
