

namespace ControlesPersonalizados
{
    partial class Password
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPass2 = new System.Windows.Forms.TextBox();
            this.pbOjito = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOjito)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(0, 0);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(133, 13);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.TabStop = false;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // tbPass2
            // 
            this.tbPass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass2.Location = new System.Drawing.Point(3, 3);
            this.tbPass2.MaxLength = 30;
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.ShortcutsEnabled = false;
            this.tbPass2.Size = new System.Drawing.Size(100, 13);
            this.tbPass2.TabIndex = 1;
            this.tbPass2.UseSystemPasswordChar = true;
            // 
            // pbOjito
            // 
            this.pbOjito.BackColor = System.Drawing.Color.White;
            this.pbOjito.BackgroundImage = global::ControlesPersonalizados.Properties.Resources.noun_851961_cc;
            this.pbOjito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOjito.Location = new System.Drawing.Point(109, 1);
            this.pbOjito.Name = "pbOjito";
            this.pbOjito.Size = new System.Drawing.Size(22, 15);
            this.pbOjito.TabIndex = 92;
            this.pbOjito.TabStop = false;
            this.pbOjito.Click += new System.EventHandler(this.pbOjito_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbOjito);
            this.Controls.Add(this.tbPass2);
            this.Controls.Add(this.tbPassword);
            this.Name = "Password";
            this.Size = new System.Drawing.Size(133, 20);
            ((System.ComponentModel.ISupportInitialize)(this.pbOjito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPass2;
        private System.Windows.Forms.PictureBox pbOjito;
    }
}
