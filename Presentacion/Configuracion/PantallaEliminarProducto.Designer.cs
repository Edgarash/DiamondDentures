﻿namespace Presentacion.Configuracion
{
    partial class PantallaEliminarProducto
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
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.Size = new System.Drawing.Size(194, 24);
            this.lblPantallaUsuario.Text = "Eliminar Producto";
            // 
            // pbIcono
            // 
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoProcesoEliminar;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            // 
            // lblAceptar
            // 
            this.lblAceptar.Size = new System.Drawing.Size(72, 18);
            this.lblAceptar.Text = "Eliminar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Presentacion.Properties.Resources.Basura;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PantallaEliminarProducto
            // 
            this.Name = "PantallaEliminarProducto";
            this.Text = "Eliminar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
