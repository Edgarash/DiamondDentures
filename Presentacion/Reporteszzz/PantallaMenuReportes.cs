using System.ComponentModel;
using Control;

namespace Presentacion.Reportes
{
    class PantallaMenuReportes : Pantalla
    {




        public PantallaMenuReportes()
        {
            InitializeComponent();
        }

        #region UI

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReportesVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNotaTerminacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOficioConfirmacion;
        private System.Windows.Forms.Label label2;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaMenuReportes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReportesVentas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNotaTerminacion = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOficioConfirmacion = new System.Windows.Forms.Button();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Controls.Add(this.pictureBox1);
            this.Encabezado.Size = new System.Drawing.Size(643, 93);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(93, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu de reportes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccione una opcion:";
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackgroundImage = global::Presentacion.Properties.Resources.IconoContabilidad;
            this.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Location = new System.Drawing.Point(69, 179);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(60, 60);
            this.btnFacturacion.TabIndex = 24;
            this.btnFacturacion.TabStop = false;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(52, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Facturacion";
            // 
            // btnReportesVentas
            // 
            this.btnReportesVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportesVentas.BackgroundImage")));
            this.btnReportesVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportesVentas.FlatAppearance.BorderSize = 0;
            this.btnReportesVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesVentas.Location = new System.Drawing.Point(263, 179);
            this.btnReportesVentas.Name = "btnReportesVentas";
            this.btnReportesVentas.Size = new System.Drawing.Size(60, 60);
            this.btnReportesVentas.TabIndex = 26;
            this.btnReportesVentas.TabStop = false;
            this.btnReportesVentas.UseVisualStyleBackColor = true;
            this.btnReportesVentas.Click += new System.EventHandler(this.btnReportesVentas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(210, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Reportes de ventas";
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(410, 331);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 30;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(373, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Regresar al menu";
            // 
            // btnNotaTerminacion
            // 
            this.btnNotaTerminacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotaTerminacion.BackgroundImage")));
            this.btnNotaTerminacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotaTerminacion.FlatAppearance.BorderSize = 0;
            this.btnNotaTerminacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaTerminacion.Location = new System.Drawing.Point(471, 179);
            this.btnNotaTerminacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNotaTerminacion.Name = "btnNotaTerminacion";
            this.btnNotaTerminacion.Size = new System.Drawing.Size(60, 60);
            this.btnNotaTerminacion.TabIndex = 36;
            this.btnNotaTerminacion.TabStop = false;
            this.btnNotaTerminacion.UseVisualStyleBackColor = true;
            this.btnNotaTerminacion.Click += new System.EventHandler(this.btnNotaTerminacion_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(420, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Nota de terminacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Oficio de confirmacion";
            // 
            // btnOficioConfirmacion
            // 
            this.btnOficioConfirmacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOficioConfirmacion.BackgroundImage")));
            this.btnOficioConfirmacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOficioConfirmacion.FlatAppearance.BorderSize = 0;
            this.btnOficioConfirmacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOficioConfirmacion.Location = new System.Drawing.Point(165, 331);
            this.btnOficioConfirmacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOficioConfirmacion.Name = "btnOficioConfirmacion";
            this.btnOficioConfirmacion.Size = new System.Drawing.Size(60, 60);
            this.btnOficioConfirmacion.TabIndex = 36;
            this.btnOficioConfirmacion.TabStop = false;
            this.btnOficioConfirmacion.UseVisualStyleBackColor = true;
            this.btnOficioConfirmacion.Click += new System.EventHandler(this.btnOficioConfirmacion_Click);
            // 
            // PantallaMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(643, 507);
            this.Controls.Add(this.btnOficioConfirmacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNotaTerminacion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnReportesVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Name = "PantallaMenuReportes";
            this.Text = "Menu de reportes";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnFacturacion, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnReportesVentas, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.btnNotaTerminacion, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnOficioConfirmacion, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Eventos

        private void btnReportesVentas_Click(object sender, System.EventArgs e)
        {
            PantallaGenerarRVentas pgrv = new PantallaGenerarRVentas();
            Hide();
            pgrv.ShowDialog();
            pgrv.Close();
            Show();
        }

        private void btnFacturacion_Click(object sender, System.EventArgs e)
        {
            PantallaContabilidad pc = new PantallaContabilidad();
            Hide();
            pc.ShowDialog();
            pc.Close();
            Show();
        }

        private void btnNotaTerminacion_Click(object sender, System.EventArgs e)
        {
            PantallaNotaTerminacion pnt = new PantallaNotaTerminacion();
            Hide();
            pnt.ShowDialog();
            pnt.Close();
            Show();
        }

        private void btnOficioConfirmacion_Click(object sender, System.EventArgs e)
        {
            PantallaOficioConfirmacion pof = new PantallaOficioConfirmacion();
            Hide();
            pof.ShowDialog();
            pof.Close();
            Show();
        }

        #endregion

       
    }
}
