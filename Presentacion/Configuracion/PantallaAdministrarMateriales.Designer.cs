namespace Presentacion.Configuracion
{
    partial class PantallaAdministrarMateriales
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
            this.lblPantallaUsuario = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnBuscarClave = new System.Windows.Forms.Button();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRegistrarDentista = new System.Windows.Forms.Label();
            this.btnEliminarMaterial = new System.Windows.Forms.Button();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.btnModificarMaterial = new System.Windows.Forms.Button();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.lblPantallaUsuario);
            this.Encabezado.Controls.Add(this.pbIcono);
            this.Encabezado.Size = new System.Drawing.Size(507, 93);
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.AutoSize = true;
            this.lblPantallaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblPantallaUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantallaUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPantallaUsuario.Location = new System.Drawing.Point(93, 34);
            this.lblPantallaUsuario.Name = "lblPantallaUsuario";
            this.lblPantallaUsuario.Size = new System.Drawing.Size(239, 24);
            this.lblPantallaUsuario.TabIndex = 17;
            this.lblPantallaUsuario.Text = "Administrar Materiales";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoMaterial;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcono.Location = new System.Drawing.Point(17, 16);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(60, 60);
            this.pbIcono.TabIndex = 16;
            this.pbIcono.TabStop = false;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPrecio.Location = new System.Drawing.Point(262, 146);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(91, 23);
            this.tbPrecio.TabIndex = 15;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecio_KeyPress);
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNombre.Location = new System.Drawing.Point(97, 146);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(91, 23);
            this.tbNombre.TabIndex = 16;
            // 
            // tbClave
            // 
            this.tbClave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbClave.Location = new System.Drawing.Point(97, 105);
            this.tbClave.Margin = new System.Windows.Forms.Padding(2);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(91, 23);
            this.tbClave.TabIndex = 17;
            this.tbClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClave_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(192, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(11, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblClave.Location = new System.Drawing.Point(11, 108);
            this.lblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(51, 17);
            this.lblClave.TabIndex = 14;
            this.lblClave.Text = "Clave:";
            // 
            // btnBuscarClave
            // 
            this.btnBuscarClave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarClave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarClave.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.btnBuscarClave.Location = new System.Drawing.Point(415, 105);
            this.btnBuscarClave.Name = "btnBuscarClave";
            this.btnBuscarClave.Size = new System.Drawing.Size(80, 28);
            this.btnBuscarClave.TabIndex = 18;
            this.btnBuscarClave.Text = "Buscar";
            this.btnBuscarClave.UseVisualStyleBackColor = false;
            this.btnBuscarClave.Click += new System.EventHandler(this.btnBuscarClave_Click);
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AllowUserToAddRows = false;
            this.dgvMateriales.AllowUserToDeleteRows = false;
            this.dgvMateriales.AllowUserToResizeColumns = false;
            this.dgvMateriales.AllowUserToResizeRows = false;
            this.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Nombre,
            this.Precio});
            this.dgvMateriales.Location = new System.Drawing.Point(12, 188);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.ReadOnly = true;
            this.dgvMateriales.RowHeadersVisible = false;
            this.dgvMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriales.Size = new System.Drawing.Size(483, 160);
            this.dgvMateriales.TabIndex = 19;
            this.dgvMateriales.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMateriales_CellMouseDown);
            // 
            // Clave
            // 
            this.Clave.FillWeight = 30F;
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 67.62117F;
            this.Nombre.HeaderText = "Nombre Material";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 40F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(215, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 57;
            this.label1.Text = "Modificar\r\nMaterial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(55, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 34);
            this.label4.TabIndex = 58;
            this.label4.Text = "Añadir\r\nMaterial";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegistrarDentista
            // 
            this.lblRegistrarDentista.AutoSize = true;
            this.lblRegistrarDentista.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrarDentista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegistrarDentista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarDentista.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRegistrarDentista.Location = new System.Drawing.Point(384, 421);
            this.lblRegistrarDentista.Name = "lblRegistrarDentista";
            this.lblRegistrarDentista.Size = new System.Drawing.Size(68, 34);
            this.lblRegistrarDentista.TabIndex = 59;
            this.lblRegistrarDentista.Text = "Eliminar\r\nMaterial";
            this.lblRegistrarDentista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.BackgroundImage = global::Presentacion.Properties.Resources.IconoMaterialEliminar;
            this.btnEliminarMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarMaterial.FlatAppearance.BorderSize = 0;
            this.btnEliminarMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMaterial.Location = new System.Drawing.Point(388, 358);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(60, 60);
            this.btnEliminarMaterial.TabIndex = 54;
            this.btnEliminarMaterial.UseVisualStyleBackColor = true;
            this.btnEliminarMaterial.Click += new System.EventHandler(this.btnEliminarMaterial_Click);
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.BackgroundImage = global::Presentacion.Properties.Resources.IconoMaterialAgregar;
            this.btnAgregarMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarMaterial.FlatAppearance.BorderSize = 0;
            this.btnAgregarMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMaterial.Location = new System.Drawing.Point(58, 358);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(60, 60);
            this.btnAgregarMaterial.TabIndex = 55;
            this.btnAgregarMaterial.UseVisualStyleBackColor = true;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // btnModificarMaterial
            // 
            this.btnModificarMaterial.BackgroundImage = global::Presentacion.Properties.Resources.IconoMaterialModificar;
            this.btnModificarMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarMaterial.FlatAppearance.BorderSize = 0;
            this.btnModificarMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMaterial.Location = new System.Drawing.Point(223, 358);
            this.btnModificarMaterial.Name = "btnModificarMaterial";
            this.btnModificarMaterial.Size = new System.Drawing.Size(60, 60);
            this.btnModificarMaterial.TabIndex = 56;
            this.btnModificarMaterial.UseVisualStyleBackColor = true;
            this.btnModificarMaterial.Click += new System.EventHandler(this.btnModificarMaterial_Click);
            // 
            // PantallaAdministrarMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(507, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRegistrarDentista);
            this.Controls.Add(this.btnEliminarMaterial);
            this.Controls.Add(this.btnAgregarMaterial);
            this.Controls.Add(this.btnModificarMaterial);
            this.Controls.Add(this.dgvMateriales);
            this.Controls.Add(this.btnBuscarClave);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClave);
            this.Name = "PantallaAdministrarMateriales";
            this.Load += new System.EventHandler(this.PantallaAdministrarMateriales_Load);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.lblClave, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbClave, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.tbPrecio, 0);
            this.Controls.SetChildIndex(this.btnBuscarClave, 0);
            this.Controls.SetChildIndex(this.dgvMateriales, 0);
            this.Controls.SetChildIndex(this.btnModificarMaterial, 0);
            this.Controls.SetChildIndex(this.btnAgregarMaterial, 0);
            this.Controls.SetChildIndex(this.btnEliminarMaterial, 0);
            this.Controls.SetChildIndex(this.lblRegistrarDentista, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblPantallaUsuario;
        protected System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnBuscarClave;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRegistrarDentista;
        private System.Windows.Forms.Button btnEliminarMaterial;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Button btnModificarMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}
