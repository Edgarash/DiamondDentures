namespace Presentacion.Recepcion
{
    partial class PantallaAdministrarDentistas
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
            this.tbRFC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.lblNumeroCasa = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnBuscarClave = new System.Windows.Forms.Button();
            this.dgvDentistas = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistrarDentista = new System.Windows.Forms.Label();
            this.btnModificarDentista = new System.Windows.Forms.Button();
            this.btnAgregarDentista = new System.Windows.Forms.Button();
            this.btnEliminarDentista = new System.Windows.Forms.Button();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDentistas)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.lblPantallaUsuario);
            this.Encabezado.Controls.Add(this.pbIcono);
            this.Encabezado.Size = new System.Drawing.Size(699, 93);
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.AutoSize = true;
            this.lblPantallaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblPantallaUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantallaUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPantallaUsuario.Location = new System.Drawing.Point(97, 34);
            this.lblPantallaUsuario.Name = "lblPantallaUsuario";
            this.lblPantallaUsuario.Size = new System.Drawing.Size(230, 24);
            this.lblPantallaUsuario.TabIndex = 19;
            this.lblPantallaUsuario.Text = "Administrar Dentistas";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoDentista;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcono.Location = new System.Drawing.Point(21, 16);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(60, 60);
            this.pbIcono.TabIndex = 18;
            this.pbIcono.TabStop = false;
            // 
            // tbRFC
            // 
            this.tbRFC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRFC.Location = new System.Drawing.Point(12, 175);
            this.tbRFC.MaxLength = 6;
            this.tbRFC.Name = "tbRFC";
            this.tbRFC.ShortcutsEnabled = false;
            this.tbRFC.Size = new System.Drawing.Size(204, 27);
            this.tbRFC.TabIndex = 148;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 150;
            this.label6.Text = "* RFC:";
            // 
            // tbCedula
            // 
            this.tbCedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedula.Location = new System.Drawing.Point(12, 124);
            this.tbCedula.MaxLength = 6;
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.ShortcutsEnabled = false;
            this.tbCedula.Size = new System.Drawing.Size(122, 27);
            this.tbCedula.TabIndex = 149;
            // 
            // lblNumeroCasa
            // 
            this.lblNumeroCasa.AutoSize = true;
            this.lblNumeroCasa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCasa.Location = new System.Drawing.Point(12, 103);
            this.lblNumeroCasa.Name = "lblNumeroCasa";
            this.lblNumeroCasa.Size = new System.Drawing.Size(144, 21);
            this.lblNumeroCasa.TabIndex = 151;
            this.lblNumeroCasa.Text = "*Número Cédula:";
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(222, 175);
            this.tbNombre.MaxLength = 30;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ShortcutsEnabled = false;
            this.tbNombre.Size = new System.Drawing.Size(230, 27);
            this.tbNombre.TabIndex = 165;
            // 
            // tbApellidos
            // 
            this.tbApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidos.Location = new System.Drawing.Point(458, 175);
            this.tbApellidos.Margin = new System.Windows.Forms.Padding(3, 3, 10, 6);
            this.tbApellidos.MaxLength = 80;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.ShortcutsEnabled = false;
            this.tbApellidos.Size = new System.Drawing.Size(230, 27);
            this.tbApellidos.TabIndex = 166;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 163;
            this.label5.Text = "*  Apellidos";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(219, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(156, 21);
            this.lblEmail.TabIndex = 164;
            this.lblEmail.Text = "*  Nombe Dentista:";
            // 
            // btnBuscarClave
            // 
            this.btnBuscarClave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarClave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarClave.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.btnBuscarClave.Location = new System.Drawing.Point(608, 103);
            this.btnBuscarClave.Name = "btnBuscarClave";
            this.btnBuscarClave.Size = new System.Drawing.Size(80, 28);
            this.btnBuscarClave.TabIndex = 167;
            this.btnBuscarClave.Text = "Buscar";
            this.btnBuscarClave.UseVisualStyleBackColor = false;
            this.btnBuscarClave.Click += new System.EventHandler(this.btnBuscarClave_Click);
            // 
            // dgvDentistas
            // 
            this.dgvDentistas.AllowUserToAddRows = false;
            this.dgvDentistas.AllowUserToDeleteRows = false;
            this.dgvDentistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDentistas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDentistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDentistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.RFC,
            this.Nombre,
            this.Apellidos});
            this.dgvDentistas.Location = new System.Drawing.Point(12, 208);
            this.dgvDentistas.Name = "dgvDentistas";
            this.dgvDentistas.ReadOnly = true;
            this.dgvDentistas.RowHeadersVisible = false;
            this.dgvDentistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDentistas.Size = new System.Drawing.Size(676, 165);
            this.dgvDentistas.TabIndex = 168;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            this.RFC.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Dentista";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(268, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 34);
            this.label2.TabIndex = 171;
            this.label2.Text = "Modificar\r\nInformación Dentista";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegistrarDentista
            // 
            this.lblRegistrarDentista.AutoSize = true;
            this.lblRegistrarDentista.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrarDentista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegistrarDentista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarDentista.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRegistrarDentista.Location = new System.Drawing.Point(9, 451);
            this.lblRegistrarDentista.Name = "lblRegistrarDentista";
            this.lblRegistrarDentista.Size = new System.Drawing.Size(160, 34);
            this.lblRegistrarDentista.TabIndex = 172;
            this.lblRegistrarDentista.Text = "Agregar\r\nInformación Dentista";
            this.lblRegistrarDentista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificarDentista
            // 
            this.btnModificarDentista.BackgroundImage = global::Presentacion.Properties.Resources.IconoDentistaModificar;
            this.btnModificarDentista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarDentista.FlatAppearance.BorderSize = 0;
            this.btnModificarDentista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarDentista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarDentista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDentista.Location = new System.Drawing.Point(318, 379);
            this.btnModificarDentista.Name = "btnModificarDentista";
            this.btnModificarDentista.Size = new System.Drawing.Size(60, 60);
            this.btnModificarDentista.TabIndex = 169;
            this.btnModificarDentista.UseVisualStyleBackColor = true;
            this.btnModificarDentista.Click += new System.EventHandler(this.btnModificarDentista_Click);
            // 
            // btnAgregarDentista
            // 
            this.btnAgregarDentista.BackgroundImage = global::Presentacion.Properties.Resources.IconoDentistaAgregar;
            this.btnAgregarDentista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarDentista.FlatAppearance.BorderSize = 0;
            this.btnAgregarDentista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDentista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDentista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDentista.Location = new System.Drawing.Point(59, 379);
            this.btnAgregarDentista.Name = "btnAgregarDentista";
            this.btnAgregarDentista.Size = new System.Drawing.Size(60, 60);
            this.btnAgregarDentista.TabIndex = 170;
            this.btnAgregarDentista.UseVisualStyleBackColor = true;
            this.btnAgregarDentista.Click += new System.EventHandler(this.btnAgregarDentista_Click);
            // 
            // btnEliminarDentista
            // 
            this.btnEliminarDentista.BackgroundImage = global::Presentacion.Properties.Resources.IconoDentistaEliminar;
            this.btnEliminarDentista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarDentista.FlatAppearance.BorderSize = 0;
            this.btnEliminarDentista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarDentista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarDentista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDentista.Location = new System.Drawing.Point(577, 379);
            this.btnEliminarDentista.Name = "btnEliminarDentista";
            this.btnEliminarDentista.Size = new System.Drawing.Size(60, 60);
            this.btnEliminarDentista.TabIndex = 169;
            this.btnEliminarDentista.UseVisualStyleBackColor = true;
            this.btnEliminarDentista.Click += new System.EventHandler(this.btnEliminarDentista_Click);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEliminar.Location = new System.Drawing.Point(527, 451);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(160, 34);
            this.lblEliminar.TabIndex = 171;
            this.lblEliminar.Text = "Eliminar\r\nInformación Dentista";
            this.lblEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PantallaAdministrarDentistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(699, 494);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarDentista);
            this.Controls.Add(this.lblRegistrarDentista);
            this.Controls.Add(this.btnModificarDentista);
            this.Controls.Add(this.btnAgregarDentista);
            this.Controls.Add(this.dgvDentistas);
            this.Controls.Add(this.btnBuscarClave);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbRFC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.lblNumeroCasa);
            this.Name = "PantallaAdministrarDentistas";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.lblNumeroCasa, 0);
            this.Controls.SetChildIndex(this.tbCedula, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbRFC, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbApellidos, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.btnBuscarClave, 0);
            this.Controls.SetChildIndex(this.dgvDentistas, 0);
            this.Controls.SetChildIndex(this.btnAgregarDentista, 0);
            this.Controls.SetChildIndex(this.btnModificarDentista, 0);
            this.Controls.SetChildIndex(this.lblRegistrarDentista, 0);
            this.Controls.SetChildIndex(this.btnEliminarDentista, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblEliminar, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDentistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblPantallaUsuario;
        protected System.Windows.Forms.PictureBox pbIcono;
        protected System.Windows.Forms.TextBox tbRFC;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox tbCedula;
        protected System.Windows.Forms.Label lblNumeroCasa;
        protected System.Windows.Forms.TextBox tbNombre;
        protected System.Windows.Forms.TextBox tbApellidos;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnBuscarClave;
        private System.Windows.Forms.DataGridView dgvDentistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistrarDentista;
        private System.Windows.Forms.Button btnModificarDentista;
        private System.Windows.Forms.Button btnAgregarDentista;
        private System.Windows.Forms.Button btnEliminarDentista;
        private System.Windows.Forms.Label lblEliminar;
    }
}
