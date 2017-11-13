namespace Presentacion.Laboratorio
{
    partial class PantallaPedidoFabricar
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
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dtvDatos = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.rbTipo = new System.Windows.Forms.RadioButton();
            this.rbPedido = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntNotaTer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFabricar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label9);
            this.Encabezado.Controls.Add(this.pbIcono);
            this.Encabezado.Size = new System.Drawing.Size(738, 93);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(539, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 34);
            this.label2.TabIndex = 267;
            this.label2.Text = "Cancelar\r\nPedido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelarPedidos;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(553, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.button3.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // dtvDatos
            // 
            this.dtvDatos.AllowUserToAddRows = false;
            this.dtvDatos.AllowUserToDeleteRows = false;
            this.dtvDatos.AllowUserToResizeColumns = false;
            this.dtvDatos.AllowUserToResizeRows = false;
            this.dtvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dtvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDatos.Location = new System.Drawing.Point(12, 216);
            this.dtvDatos.Name = "dtvDatos";
            this.dtvDatos.ReadOnly = true;
            this.dtvDatos.RowHeadersVisible = false;
            this.dtvDatos.Size = new System.Drawing.Size(714, 162);
            this.dtvDatos.TabIndex = 265;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(80, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 19);
            this.label14.TabIndex = 264;
            this.label14.Text = "Buscar";
            // 
            // rbTipo
            // 
            this.rbTipo.AutoSize = true;
            this.rbTipo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipo.Location = new System.Drawing.Point(125, 143);
            this.rbTipo.Name = "rbTipo";
            this.rbTipo.Size = new System.Drawing.Size(47, 19);
            this.rbTipo.TabIndex = 4;
            this.rbTipo.Text = "Tipo";
            this.rbTipo.UseVisualStyleBackColor = true;
            // 
            // rbPedido
            // 
            this.rbPedido.AutoSize = true;
            this.rbPedido.Checked = true;
            this.rbPedido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPedido.Location = new System.Drawing.Point(41, 143);
            this.rbPedido.Name = "rbPedido";
            this.rbPedido.Size = new System.Drawing.Size(78, 19);
            this.rbPedido.TabIndex = 3;
            this.rbPedido.TabStop = true;
            this.rbPedido.Text = "Id_Pedido";
            this.rbPedido.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(179, 143);
            this.tbBuscar.MaxLength = 20;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.ShortcutsEnabled = false;
            this.tbBuscar.Size = new System.Drawing.Size(95, 22);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = global::Presentacion.Properties.Resources.IconoBuscar;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(280, 135);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(41, 41);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnRegistrar.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(627, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 34);
            this.label1.TabIndex = 257;
            this.label1.Text = "    Nota de \r\nTerminación";
            // 
            // bntNotaTer
            // 
            this.bntNotaTer.BackgroundImage = global::Presentacion.Properties.Resources.IconoTerminado;
            this.bntNotaTer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntNotaTer.FlatAppearance.BorderSize = 0;
            this.bntNotaTer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntNotaTer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntNotaTer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNotaTer.Location = new System.Drawing.Point(649, 112);
            this.bntNotaTer.Name = "bntNotaTer";
            this.bntNotaTer.Size = new System.Drawing.Size(50, 50);
            this.bntNotaTer.TabIndex = 8;
            this.bntNotaTer.UseVisualStyleBackColor = true;
            this.bntNotaTer.Click += new System.EventHandler(this.bntNotaTer_Click);
            this.bntNotaTer.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.bntNotaTer.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(448, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 255;
            this.label5.Text = "Fabricar";
            // 
            // btnFabricar
            // 
            this.btnFabricar.BackgroundImage = global::Presentacion.Properties.Resources.IconoFabricar;
            this.btnFabricar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFabricar.FlatAppearance.BorderSize = 0;
            this.btnFabricar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFabricar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFabricar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFabricar.Location = new System.Drawing.Point(457, 112);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(50, 50);
            this.btnFabricar.TabIndex = 6;
            this.btnFabricar.UseVisualStyleBackColor = true;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            this.btnFabricar.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnFabricar.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(169, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(401, 59);
            this.label9.TabIndex = 48;
            this.label9.Text = "Fabricar Pedido";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoProceso;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcono.Location = new System.Drawing.Point(10, 13);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(60, 60);
            this.pbIcono.TabIndex = 47;
            this.pbIcono.TabStop = false;
            // 
            // PantallaPedidoFabricar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(738, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtvDatos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.rbTipo);
            this.Controls.Add(this.rbPedido);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntNotaTer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFabricar);
            this.Name = "PantallaPedidoFabricar";
            this.Text = "Pantalla Fabricar Pedidos";
            this.Load += new System.EventHandler(this.PantallaPedidoFabricar_Load);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.btnFabricar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.bntNotaTer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.tbBuscar, 0);
            this.Controls.SetChildIndex(this.rbPedido, 0);
            this.Controls.SetChildIndex(this.rbTipo, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.dtvDatos, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtvDatos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbTipo;
        private System.Windows.Forms.RadioButton rbPedido;
        protected System.Windows.Forms.TextBox tbBuscar;
        protected System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntNotaTer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.PictureBox pbIcono;
    }
}
