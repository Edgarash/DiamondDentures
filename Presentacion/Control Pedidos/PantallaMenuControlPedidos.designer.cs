namespace Presentacion.Control_Pedidos
{
    partial class PantallaMenuControlPedidos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLabora = new System.Windows.Forms.Label();
            this.btnLabor = new System.Windows.Forms.Button();
            this.lblReportes = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.lblCancelarPedido = new System.Windows.Forms.Label();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.lblModificarPedido = new System.Windows.Forms.Label();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.lblNuevoPedido = new System.Windows.Forms.Label();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEstadoPedido = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label9);
            this.Encabezado.Controls.Add(this.pbIcono);
            this.Encabezado.Size = new System.Drawing.Size(519, 93);
            // 
            // lblLabora
            // 
            this.lblLabora.AutoSize = true;
            this.lblLabora.BackColor = System.Drawing.Color.Transparent;
            this.lblLabora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLabora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabora.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLabora.Location = new System.Drawing.Point(211, 380);
            this.lblLabora.Name = "lblLabora";
            this.lblLabora.Size = new System.Drawing.Size(94, 17);
            this.lblLabora.TabIndex = 179;
            this.lblLabora.Text = "Laboratorio";
            // 
            // btnLabor
            // 
            this.btnLabor.BackgroundImage = global::Presentacion.Properties.Resources.IconoLabInvertido;
            this.btnLabor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLabor.FlatAppearance.BorderSize = 0;
            this.btnLabor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLabor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLabor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabor.Location = new System.Drawing.Point(206, 277);
            this.btnLabor.Name = "btnLabor";
            this.btnLabor.Size = new System.Drawing.Size(105, 100);
            this.btnLabor.TabIndex = 5;
            this.btnLabor.UseVisualStyleBackColor = true;
            this.btnLabor.Click += new System.EventHandler(this.button5_Click);
            this.btnLabor.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnLabor.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.BackColor = System.Drawing.Color.Transparent;
            this.lblReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReportes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblReportes.Location = new System.Drawing.Point(390, 380);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(75, 17);
            this.lblReportes.TabIndex = 177;
            this.lblReportes.Text = "Reportes";
            // 
            // btnReportes
            // 
            this.btnReportes.BackgroundImage = global::Presentacion.Properties.Resources.IconoFacturacion;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Location = new System.Drawing.Point(375, 277);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(105, 100);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            this.btnReportes.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnReportes.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblCancelarPedido
            // 
            this.lblCancelarPedido.AutoSize = true;
            this.lblCancelarPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCancelarPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelarPedido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCancelarPedido.Location = new System.Drawing.Point(26, 380);
            this.lblCancelarPedido.Name = "lblCancelarPedido";
            this.lblCancelarPedido.Size = new System.Drawing.Size(129, 17);
            this.lblCancelarPedido.TabIndex = 175;
            this.lblCancelarPedido.Text = "Cancelar Pedido";
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelarPedidos;
            this.btnCancelarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarPedido.FlatAppearance.BorderSize = 0;
            this.btnCancelarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPedido.Location = new System.Drawing.Point(38, 277);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(105, 100);
            this.btnCancelarPedido.TabIndex = 4;
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.button3_Click);
            this.btnCancelarPedido.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnCancelarPedido.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblModificarPedido
            // 
            this.lblModificarPedido.AutoSize = true;
            this.lblModificarPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModificarPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarPedido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblModificarPedido.Location = new System.Drawing.Point(362, 237);
            this.lblModificarPedido.Name = "lblModificarPedido";
            this.lblModificarPedido.Size = new System.Drawing.Size(130, 17);
            this.lblModificarPedido.TabIndex = 173;
            this.lblModificarPedido.Text = "Modificar Pedido";
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.BackgroundImage = global::Presentacion.Properties.Resources.IconoPedidoModificar;
            this.btnModificarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarPedido.FlatAppearance.BorderSize = 0;
            this.btnModificarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPedido.Location = new System.Drawing.Point(375, 134);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(105, 100);
            this.btnModificarPedido.TabIndex = 3;
            this.btnModificarPedido.UseVisualStyleBackColor = true;
            this.btnModificarPedido.Click += new System.EventHandler(this.button2_Click);
            this.btnModificarPedido.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnModificarPedido.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblNuevoPedido
            // 
            this.lblNuevoPedido.AutoSize = true;
            this.lblNuevoPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevoPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoPedido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNuevoPedido.Location = new System.Drawing.Point(35, 237);
            this.lblNuevoPedido.Name = "lblNuevoPedido";
            this.lblNuevoPedido.Size = new System.Drawing.Size(108, 17);
            this.lblNuevoPedido.TabIndex = 170;
            this.lblNuevoPedido.Text = "Nuevo Pedido";
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.BackgroundImage = global::Presentacion.Properties.Resources.IconoPedidoAgregar;
            this.btnNuevoPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoPedido.FlatAppearance.BorderSize = 0;
            this.btnNuevoPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNuevoPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.Location = new System.Drawing.Point(37, 134);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(105, 100);
            this.btnNuevoPedido.TabIndex = 1;
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.button1_Click);
            this.btnNuevoPedido.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnNuevoPedido.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(219, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 171;
            this.label3.Text = "Semáforo";
            // 
            // btnEstadoPedido
            // 
            this.btnEstadoPedido.BackgroundImage = global::Presentacion.Properties.Resources.IconoSemaforoFinal;
            this.btnEstadoPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstadoPedido.FlatAppearance.BorderSize = 0;
            this.btnEstadoPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEstadoPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEstadoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoPedido.Location = new System.Drawing.Point(206, 134);
            this.btnEstadoPedido.Name = "btnEstadoPedido";
            this.btnEstadoPedido.Size = new System.Drawing.Size(105, 100);
            this.btnEstadoPedido.TabIndex = 2;
            this.btnEstadoPedido.UseVisualStyleBackColor = true;
            this.btnEstadoPedido.Click += new System.EventHandler(this.btnEstadoPedido_Click);
            this.btnEstadoPedido.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnEstadoPedido.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(6, 495);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(26, 20);
            this.lblUsuario.TabIndex = 182;
            this.lblUsuario.Text = "    ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(120, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 70);
            this.label9.TabIndex = 53;
            this.label9.Text = "Menú de Control \r\nde Pedidos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoPedido;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcono.Location = new System.Drawing.Point(7, 16);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(60, 60);
            this.pbIcono.TabIndex = 51;
            this.pbIcono.TabStop = false;
            // 
            // PantallaMenuControlPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(519, 531);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblLabora);
            this.Controls.Add(this.btnLabor);
            this.Controls.Add(this.lblReportes);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.lblCancelarPedido);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.lblModificarPedido);
            this.Controls.Add(this.btnModificarPedido);
            this.Controls.Add(this.lblNuevoPedido);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEstadoPedido);
            this.Name = "PantallaMenuControlPedidos";
            this.Text = "Pantalla Menú";
            this.Load += new System.EventHandler(this.PantallaMenuControlPedidos_Load);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.btnEstadoPedido, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnNuevoPedido, 0);
            this.Controls.SetChildIndex(this.lblNuevoPedido, 0);
            this.Controls.SetChildIndex(this.btnModificarPedido, 0);
            this.Controls.SetChildIndex(this.lblModificarPedido, 0);
            this.Controls.SetChildIndex(this.btnCancelarPedido, 0);
            this.Controls.SetChildIndex(this.lblCancelarPedido, 0);
            this.Controls.SetChildIndex(this.btnReportes, 0);
            this.Controls.SetChildIndex(this.lblReportes, 0);
            this.Controls.SetChildIndex(this.btnLabor, 0);
            this.Controls.SetChildIndex(this.lblLabora, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabora;
        private System.Windows.Forms.Button btnLabor;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Label lblCancelarPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Label lblModificarPedido;
        private System.Windows.Forms.Button btnModificarPedido;
        private System.Windows.Forms.Label lblNuevoPedido;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEstadoPedido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.PictureBox pbIcono;
    }
}
