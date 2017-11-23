namespace Presentacion.Recursos_Humanos
{
    partial class RHumanosMenu
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
            this.btnNomina = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label9);
            this.Encabezado.Size = new System.Drawing.Size(280, 93);
            // 
            // btnNomina
            // 
            this.btnNomina.Location = new System.Drawing.Point(162, 110);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(92, 62);
            this.btnNomina.TabIndex = 59;
            this.btnNomina.Text = "Nómina";
            this.btnNomina.UseVisualStyleBackColor = true;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 17.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(20, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 56);
            this.label9.TabIndex = 60;
            this.label9.Text = "Menú de\r\nRecursos Humanos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(41, 110);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(92, 62);
            this.btnAsistencia.TabIndex = 60;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // RHumanosMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 187);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.btnNomina);
            this.Name = "RHumanosMenu";
            this.Text = "RHumanosMenu";
            this.Controls.SetChildIndex(this.btnNomina, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.btnAsistencia, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNomina;
        private System.Windows.Forms.Button btnAsistencia;
    }
}