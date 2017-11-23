namespace Presentacion.Configuracion
{
    partial class PantallaMaterial
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
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblAceptar = new System.Windows.Forms.Label();
            this.tbNombreMaterial = new System.Windows.Forms.TextBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblProductos = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.nudTiempo = new System.Windows.Forms.NumericUpDown();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.llbUnidadMedida = new System.Windows.Forms.Label();
            this.tbUnidadMedida = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.tbPrecioCompra = new System.Windows.Forms.TextBox();
            this.tbPrecioBase = new System.Windows.Forms.TextBox();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.lblPantallaUsuario);
            this.Encabezado.Controls.Add(this.pbIcono);
            this.Encabezado.Size = new System.Drawing.Size(576, 93);
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.AutoSize = true;
            this.lblPantallaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblPantallaUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantallaUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPantallaUsuario.Location = new System.Drawing.Point(94, 34);
            this.lblPantallaUsuario.Name = "lblPantallaUsuario";
            this.lblPantallaUsuario.Size = new System.Drawing.Size(178, 24);
            this.lblPantallaUsuario.TabIndex = 15;
            this.lblPantallaUsuario.Text = "Pantalla Material";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoMaterial;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcono.Location = new System.Drawing.Point(18, 16);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(60, 60);
            this.pbIcono.TabIndex = 14;
            this.pbIcono.TabStop = false;
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioBase.Location = new System.Drawing.Point(15, 281);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(95, 17);
            this.lblPrecioBase.TabIndex = 174;
            this.lblPrecioBase.Text = "* Precio Base:";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.Location = new System.Drawing.Point(469, 639);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(81, 18);
            this.lblCancelar.TabIndex = 172;
            this.lblCancelar.Text = "Cancelar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(478, 575);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(62, 58);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblAceptar
            // 
            this.lblAceptar.AutoSize = true;
            this.lblAceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAceptar.Location = new System.Drawing.Point(375, 639);
            this.lblAceptar.Name = "lblAceptar";
            this.lblAceptar.Size = new System.Drawing.Size(73, 18);
            this.lblAceptar.TabIndex = 170;
            this.lblAceptar.Text = "Aceptar";
            // 
            // tbNombreMaterial
            // 
            this.tbNombreMaterial.BackColor = System.Drawing.SystemColors.Window;
            this.tbNombreMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreMaterial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNombreMaterial.Location = new System.Drawing.Point(18, 171);
            this.tbNombreMaterial.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tbNombreMaterial.MaxLength = 30;
            this.tbNombreMaterial.Name = "tbNombreMaterial";
            this.tbNombreMaterial.Size = new System.Drawing.Size(370, 23);
            this.tbNombreMaterial.TabIndex = 3;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(15, 151);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(131, 17);
            this.lblMaterial.TabIndex = 168;
            this.lblMaterial.Text = "* Nombre Material:";
            // 
            // tbClave
            // 
            this.tbClave.Enabled = false;
            this.tbClave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbClave.Location = new System.Drawing.Point(18, 121);
            this.tbClave.MaxLength = 8;
            this.tbClave.Name = "tbClave";
            this.tbClave.ShortcutsEnabled = false;
            this.tbClave.Size = new System.Drawing.Size(72, 23);
            this.tbClave.TabIndex = 0;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(15, 101);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(117, 17);
            this.lblClave.TabIndex = 176;
            this.lblClave.Text = "* Clave Material:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Activo,
            this.Producto,
            this.Precio,
            this.Tiempo});
            this.dgvProductos.GridColor = System.Drawing.Color.Black;
            this.dgvProductos.Location = new System.Drawing.Point(18, 347);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(536, 193);
            this.dgvProductos.TabIndex = 9;
            this.dgvProductos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProductos_EditingControlShowing);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(15, 327);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(73, 17);
            this.lblProductos.TabIndex = 174;
            this.lblProductos.Text = "Productos";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Presentacion.Properties.Resources.IconoAceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(380, 575);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(62, 58);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(409, 101);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(121, 17);
            this.lblPrecioCompra.TabIndex = 174;
            this.lblPrecioCompra.Text = "* Precio Compra:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(15, 197);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(97, 17);
            this.lblDescripcion.TabIndex = 168;
            this.lblDescripcion.Text = "* Descripción:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.tbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbDescripcion.Location = new System.Drawing.Point(18, 217);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tbDescripcion.MaxLength = 50;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(536, 61);
            this.tbDescripcion.TabIndex = 5;
            // 
            // nudTiempo
            // 
            this.nudTiempo.Location = new System.Drawing.Point(136, 303);
            this.nudTiempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTiempo.Name = "nudTiempo";
            this.nudTiempo.Size = new System.Drawing.Size(95, 21);
            this.nudTiempo.TabIndex = 7;
            this.nudTiempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(133, 281);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(102, 17);
            this.lblTiempo.TabIndex = 174;
            this.lblTiempo.Text = "* Tiempo Base:";
            // 
            // cbProveedores
            // 
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(149, 122);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(239, 24);
            this.cbProveedores.TabIndex = 1;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(146, 101);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(89, 17);
            this.lblProveedor.TabIndex = 176;
            this.lblProveedor.Text = "* Proveedor:";
            // 
            // llbUnidadMedida
            // 
            this.llbUnidadMedida.AutoSize = true;
            this.llbUnidadMedida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbUnidadMedida.Location = new System.Drawing.Point(409, 151);
            this.llbUnidadMedida.Name = "llbUnidadMedida";
            this.llbUnidadMedida.Size = new System.Drawing.Size(142, 17);
            this.llbUnidadMedida.TabIndex = 176;
            this.llbUnidadMedida.Text = "* Unidad de Medida:";
            // 
            // tbUnidadMedida
            // 
            this.tbUnidadMedida.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUnidadMedida.Location = new System.Drawing.Point(412, 171);
            this.tbUnidadMedida.MaxLength = 10;
            this.tbUnidadMedida.Name = "tbUnidadMedida";
            this.tbUnidadMedida.ShortcutsEnabled = false;
            this.tbUnidadMedida.Size = new System.Drawing.Size(139, 23);
            this.tbUnidadMedida.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(256, 281);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(167, 17);
            this.lblCantidad.TabIndex = 174;
            this.lblCantidad.Text = "* Cantidad en Almacén:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(259, 301);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(95, 21);
            this.nudCantidad.TabIndex = 8;
            // 
            // tbPrecioCompra
            // 
            this.tbPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPrecioCompra.Location = new System.Drawing.Point(412, 121);
            this.tbPrecioCompra.MaxLength = 8;
            this.tbPrecioCompra.Name = "tbPrecioCompra";
            this.tbPrecioCompra.ShortcutsEnabled = false;
            this.tbPrecioCompra.Size = new System.Drawing.Size(95, 23);
            this.tbPrecioCompra.TabIndex = 2;
            // 
            // tbPrecioBase
            // 
            this.tbPrecioBase.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPrecioBase.Location = new System.Drawing.Point(18, 301);
            this.tbPrecioBase.MaxLength = 8;
            this.tbPrecioBase.Name = "tbPrecioBase";
            this.tbPrecioBase.ShortcutsEnabled = false;
            this.tbPrecioBase.Size = new System.Drawing.Size(95, 23);
            this.tbPrecioBase.TabIndex = 6;
            // 
            // Clave
            // 
            this.Clave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Clave.Frozen = true;
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 55;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Clave.Width = 55;
            // 
            // Activo
            // 
            this.Activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Activo.Frozen = true;
            this.Activo.HeaderText = "Disponible";
            this.Activo.MinimumWidth = 70;
            this.Activo.Name = "Activo";
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.Width = 70;
            // 
            // Producto
            // 
            this.Producto.FillWeight = 0.3636033F;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 235;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 16.25805F;
            this.Precio.HeaderText = "Precio Venta";
            this.Precio.MinimumWidth = 90;
            this.Precio.Name = "Precio";
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tiempo
            // 
            this.Tiempo.FillWeight = 103.0543F;
            this.Tiempo.HeaderText = "Tiempo Final";
            this.Tiempo.MinimumWidth = 90;
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PantallaMaterial
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(576, 669);
            this.Controls.Add(this.cbProveedores);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.nudTiempo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.tbUnidadMedida);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.llbUnidadMedida);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.tbPrecioCompra);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tbPrecioBase);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblPrecioCompra);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblAceptar);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.tbNombreMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Name = "PantallaMaterial";
            this.Text = "Pantalla Material";
            this.Controls.SetChildIndex(this.lblMaterial, 0);
            this.Controls.SetChildIndex(this.tbNombreMaterial, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.tbDescripcion, 0);
            this.Controls.SetChildIndex(this.lblAceptar, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.lblCancelar, 0);
            this.Controls.SetChildIndex(this.lblPrecioBase, 0);
            this.Controls.SetChildIndex(this.lblProductos, 0);
            this.Controls.SetChildIndex(this.lblPrecioCompra, 0);
            this.Controls.SetChildIndex(this.lblTiempo, 0);
            this.Controls.SetChildIndex(this.tbPrecioBase, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.tbPrecioCompra, 0);
            this.Controls.SetChildIndex(this.lblClave, 0);
            this.Controls.SetChildIndex(this.lblProveedor, 0);
            this.Controls.SetChildIndex(this.llbUnidadMedida, 0);
            this.Controls.SetChildIndex(this.tbClave, 0);
            this.Controls.SetChildIndex(this.tbUnidadMedida, 0);
            this.Controls.SetChildIndex(this.dgvProductos, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.nudTiempo, 0);
            this.Controls.SetChildIndex(this.nudCantidad, 0);
            this.Controls.SetChildIndex(this.cbProveedores, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblPantallaUsuario;
        protected System.Windows.Forms.PictureBox pbIcono;
        protected System.Windows.Forms.Label lblPrecioBase;
        protected System.Windows.Forms.Label lblCancelar;
        protected System.Windows.Forms.Button btnCerrar;
        protected System.Windows.Forms.Label lblAceptar;
        protected System.Windows.Forms.Label lblMaterial;
        protected System.Windows.Forms.TextBox tbClave;
        protected System.Windows.Forms.Label lblClave;
        protected System.Windows.Forms.Label lblProductos;
        protected System.Windows.Forms.Button btnAceptar;
        protected System.Windows.Forms.TextBox tbNombreMaterial;
        public System.Windows.Forms.DataGridView dgvProductos;
        protected System.Windows.Forms.Label lblPrecioCompra;
        protected System.Windows.Forms.Label lblDescripcion;
        protected System.Windows.Forms.TextBox tbDescripcion;
        protected System.Windows.Forms.Label lblTiempo;
        protected System.Windows.Forms.Label lblProveedor;
        protected System.Windows.Forms.Label llbUnidadMedida;
        protected System.Windows.Forms.TextBox tbUnidadMedida;
        protected System.Windows.Forms.Label lblCantidad;
        protected System.Windows.Forms.TextBox tbPrecioCompra;
        protected System.Windows.Forms.TextBox tbPrecioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        protected System.Windows.Forms.ComboBox cbProveedores;
        protected System.Windows.Forms.NumericUpDown nudTiempo;
        protected System.Windows.Forms.NumericUpDown nudCantidad;
    }
}
