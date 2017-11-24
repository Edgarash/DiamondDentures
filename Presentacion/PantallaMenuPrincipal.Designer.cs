namespace Presentacion
{
    partial class PantallaMenuPrincipal
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
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.btnRecepcion = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.lblRecepcion = new System.Windows.Forms.Label();
            this.lblConfiguración = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSesión = new System.Windows.Forms.Label();
            this.btnSemáforo = new System.Windows.Forms.Button();
            this.btnControlPedidos = new System.Windows.Forms.Button();
            this.btnLaboratorio = new System.Windows.Forms.Button();
            this.lblControlPedidos = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.lblSemáforo = new System.Windows.Forms.Label();
            this.btnVentas = new ControlesM.KuroButton();
            this.btnAlmacen = new ControlesM.KuroButton();
            this.btnFinanzas = new ControlesM.KuroButton();
            this.btnRecursos = new ControlesM.KuroButton();
            this.btnReportes = new ControlesM.KuroButton();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.btnAlmacen);
            this.Encabezado.Controls.Add(this.btnVentas);
            this.Encabezado.Controls.Add(this.lblTituloMenu);
            this.Encabezado.Size = new System.Drawing.Size(639, 93);
            // 
            // lblTituloMenu
            // 
            this.lblTituloMenu.AutoSize = true;
            this.lblTituloMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloMenu.Font = new System.Drawing.Font("Century Gothic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenu.Location = new System.Drawing.Point(155, 21);
            this.lblTituloMenu.Name = "lblTituloMenu";
            this.lblTituloMenu.Size = new System.Drawing.Size(310, 50);
            this.lblTituloMenu.TabIndex = 0;
            this.lblTituloMenu.Text = "Menú Principal";
            // 
            // btnRecepcion
            // 
            this.btnRecepcion.BackgroundImage = global::Presentacion.Properties.Resources.IconoRecepcion;
            this.btnRecepcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecepcion.FlatAppearance.BorderSize = 0;
            this.btnRecepcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRecepcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepcion.Location = new System.Drawing.Point(62, 142);
            this.btnRecepcion.Name = "btnRecepcion";
            this.btnRecepcion.Size = new System.Drawing.Size(120, 120);
            this.btnRecepcion.TabIndex = 40;
            this.btnRecepcion.UseVisualStyleBackColor = true;
            this.btnRecepcion.Click += new System.EventHandler(this.btnRecepcion_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackgroundImage = global::Presentacion.Properties.Resources.gears;
            this.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Location = new System.Drawing.Point(253, 142);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(120, 120);
            this.btnConfiguracion.TabIndex = 40;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // lblRecepcion
            // 
            this.lblRecepcion.AutoSize = true;
            this.lblRecepcion.BackColor = System.Drawing.Color.Transparent;
            this.lblRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRecepcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecepcion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRecepcion.Location = new System.Drawing.Point(79, 276);
            this.lblRecepcion.Name = "lblRecepcion";
            this.lblRecepcion.Size = new System.Drawing.Size(86, 17);
            this.lblRecepcion.TabIndex = 54;
            this.lblRecepcion.Text = "Recepción";
            this.lblRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConfiguración
            // 
            this.lblConfiguración.AutoSize = true;
            this.lblConfiguración.BackColor = System.Drawing.Color.Transparent;
            this.lblConfiguración.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfiguración.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguración.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblConfiguración.Location = new System.Drawing.Point(258, 276);
            this.lblConfiguración.Name = "lblConfiguración";
            this.lblConfiguración.Size = new System.Drawing.Size(111, 17);
            this.lblConfiguración.TabIndex = 55;
            this.lblConfiguración.Text = "Configuración";
            this.lblConfiguración.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackgroundImage = global::Presentacion.Properties.Resources.IconoUsuario;
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Location = new System.Drawing.Point(444, 142);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(120, 120);
            this.btnUsuario.TabIndex = 40;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUsuario.Location = new System.Drawing.Point(472, 276);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 17);
            this.lblUsuario.TabIndex = 55;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSesión
            // 
            this.lblSesión.AutoSize = true;
            this.lblSesión.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesión.Location = new System.Drawing.Point(12, 493);
            this.lblSesión.Name = "lblSesión";
            this.lblSesión.Size = new System.Drawing.Size(70, 18);
            this.lblSesión.TabIndex = 56;
            this.lblSesión.Text = "Usuario";
            // 
            // btnSemáforo
            // 
            this.btnSemáforo.BackgroundImage = global::Presentacion.Properties.Resources.IconoSemaforoFinal;
            this.btnSemáforo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSemáforo.FlatAppearance.BorderSize = 0;
            this.btnSemáforo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSemáforo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSemáforo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemáforo.Location = new System.Drawing.Point(62, 310);
            this.btnSemáforo.Name = "btnSemáforo";
            this.btnSemáforo.Size = new System.Drawing.Size(120, 120);
            this.btnSemáforo.TabIndex = 40;
            this.btnSemáforo.UseVisualStyleBackColor = true;
            this.btnSemáforo.Click += new System.EventHandler(this.btnSemáforo_Click);
            // 
            // btnControlPedidos
            // 
            this.btnControlPedidos.BackgroundImage = global::Presentacion.Properties.Resources.IconoPedido;
            this.btnControlPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnControlPedidos.FlatAppearance.BorderSize = 0;
            this.btnControlPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnControlPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnControlPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlPedidos.Location = new System.Drawing.Point(253, 310);
            this.btnControlPedidos.Name = "btnControlPedidos";
            this.btnControlPedidos.Size = new System.Drawing.Size(120, 120);
            this.btnControlPedidos.TabIndex = 40;
            this.btnControlPedidos.UseVisualStyleBackColor = true;
            this.btnControlPedidos.Click += new System.EventHandler(this.btnControlPedidos_Click);
            // 
            // btnLaboratorio
            // 
            this.btnLaboratorio.BackgroundImage = global::Presentacion.Properties.Resources.IconoLabInvertido;
            this.btnLaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaboratorio.FlatAppearance.BorderSize = 0;
            this.btnLaboratorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLaboratorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaboratorio.Location = new System.Drawing.Point(444, 310);
            this.btnLaboratorio.Name = "btnLaboratorio";
            this.btnLaboratorio.Size = new System.Drawing.Size(120, 120);
            this.btnLaboratorio.TabIndex = 40;
            this.btnLaboratorio.UseVisualStyleBackColor = true;
            this.btnLaboratorio.Click += new System.EventHandler(this.btnLaboratorio_Click);
            // 
            // lblControlPedidos
            // 
            this.lblControlPedidos.AutoSize = true;
            this.lblControlPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblControlPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblControlPedidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlPedidos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblControlPedidos.Location = new System.Drawing.Point(269, 444);
            this.lblControlPedidos.Name = "lblControlPedidos";
            this.lblControlPedidos.Size = new System.Drawing.Size(88, 34);
            this.lblControlPedidos.TabIndex = 55;
            this.lblControlPedidos.Text = "Control\r\nde Pedidos";
            this.lblControlPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.lblLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLaboratorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLaboratorio.Location = new System.Drawing.Point(457, 444);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(94, 17);
            this.lblLaboratorio.TabIndex = 55;
            this.lblLaboratorio.Text = "Laboratorio";
            this.lblLaboratorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSemáforo
            // 
            this.lblSemáforo.AutoSize = true;
            this.lblSemáforo.BackColor = System.Drawing.Color.Transparent;
            this.lblSemáforo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSemáforo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemáforo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSemáforo.Location = new System.Drawing.Point(83, 444);
            this.lblSemáforo.Name = "lblSemáforo";
            this.lblSemáforo.Size = new System.Drawing.Size(79, 17);
            this.lblSemáforo.TabIndex = 54;
            this.lblSemáforo.Text = "Semáforo";
            this.lblSemáforo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.White;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Location = new System.Drawing.Point(15, 21);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(120, 50);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.kuroButton1_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.BackColor = System.Drawing.Color.White;
            this.btnAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlmacen.ForeColor = System.Drawing.Color.Black;
            this.btnAlmacen.Location = new System.Drawing.Point(507, 21);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(120, 50);
            this.btnAlmacen.TabIndex = 2;
            this.btnAlmacen.Text = "Almacen y Proveedores";
            this.btnAlmacen.UseVisualStyleBackColor = false;
            this.btnAlmacen.Click += new System.EventHandler(this.kuroButton2_Click);
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.BackColor = System.Drawing.Color.White;
            this.btnFinanzas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnFinanzas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFinanzas.ForeColor = System.Drawing.Color.Black;
            this.btnFinanzas.Location = new System.Drawing.Point(507, 86);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.Size = new System.Drawing.Size(120, 50);
            this.btnFinanzas.TabIndex = 57;
            this.btnFinanzas.Text = "Finanzas";
            this.btnFinanzas.UseVisualStyleBackColor = false;
            this.btnFinanzas.Click += new System.EventHandler(this.kuroButton3_Click);
            // 
            // btnRecursos
            // 
            this.btnRecursos.BackColor = System.Drawing.Color.White;
            this.btnRecursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRecursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRecursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRecursos.ForeColor = System.Drawing.Color.Black;
            this.btnRecursos.Location = new System.Drawing.Point(253, 86);
            this.btnRecursos.Name = "btnRecursos";
            this.btnRecursos.Size = new System.Drawing.Size(120, 50);
            this.btnRecursos.TabIndex = 58;
            this.btnRecursos.Text = "Recursos Humanos";
            this.btnRecursos.UseVisualStyleBackColor = false;
            this.btnRecursos.Click += new System.EventHandler(this.kuroButton4_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.White;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReportes.ForeColor = System.Drawing.Color.Black;
            this.btnReportes.Location = new System.Drawing.Point(12, 86);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(120, 50);
            this.btnReportes.TabIndex = 1;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // PantallaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(639, 520);
            this.Controls.Add(this.btnRecursos);
            this.Controls.Add(this.btnFinanzas);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.lblSesión);
            this.Controls.Add(this.lblSemáforo);
            this.Controls.Add(this.lblRecepcion);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblControlPedidos);
            this.Controls.Add(this.lblConfiguración);
            this.Controls.Add(this.btnLaboratorio);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnControlPedidos);
            this.Controls.Add(this.btnSemáforo);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.btnRecepcion);
            this.Name = "PantallaMenuPrincipal";
            this.Text = "Menú Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaMenuPrincipal_FormClosing);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.btnRecepcion, 0);
            this.Controls.SetChildIndex(this.btnConfiguracion, 0);
            this.Controls.SetChildIndex(this.btnSemáforo, 0);
            this.Controls.SetChildIndex(this.btnControlPedidos, 0);
            this.Controls.SetChildIndex(this.btnUsuario, 0);
            this.Controls.SetChildIndex(this.btnLaboratorio, 0);
            this.Controls.SetChildIndex(this.lblConfiguración, 0);
            this.Controls.SetChildIndex(this.lblControlPedidos, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.lblLaboratorio, 0);
            this.Controls.SetChildIndex(this.lblRecepcion, 0);
            this.Controls.SetChildIndex(this.lblSemáforo, 0);
            this.Controls.SetChildIndex(this.lblSesión, 0);
            this.Controls.SetChildIndex(this.btnReportes, 0);
            this.Controls.SetChildIndex(this.btnFinanzas, 0);
            this.Controls.SetChildIndex(this.btnRecursos, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Button btnRecepcion;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Label lblRecepcion;
        private System.Windows.Forms.Label lblConfiguración;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSesión;
        private System.Windows.Forms.Button btnSemáforo;
        private System.Windows.Forms.Button btnControlPedidos;
        private System.Windows.Forms.Button btnLaboratorio;
        private System.Windows.Forms.Label lblControlPedidos;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Label lblSemáforo;
        private ControlesM.KuroButton btnVentas;
        private ControlesM.KuroButton btnAlmacen;
        private ControlesM.KuroButton btnReportes;
        private ControlesM.KuroButton btnFinanzas;
        private ControlesM.KuroButton btnRecursos;
    }
}
