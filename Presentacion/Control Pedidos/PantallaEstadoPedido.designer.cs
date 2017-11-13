namespace Presentacion.Control_Pedidos
{
    partial class PantallaEstadoPedido
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
            this.label16 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.lblGenerarReporte = new System.Windows.Forms.Label();
            this.btnFormaPedido = new System.Windows.Forms.Button();
            this.lblFormaPedido = new System.Windows.Forms.Label();
            this.btnTerminacion = new System.Windows.Forms.Button();
            this.lblTerminacion = new System.Windows.Forms.Label();
            this.btnConfirmacion = new System.Windows.Forms.Button();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rbTipo = new System.Windows.Forms.RadioButton();
            this.rbPedido = new System.Windows.Forms.RadioButton();
            this.rbDentista = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCancelarPedido = new System.Windows.Forms.Label();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.lblModificarPedido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModificarPedido = new System.Windows.Forms.Button();
            this.lblNuevoPedido = new System.Windows.Forms.Label();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.dtvDatos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTrabaja = new System.Windows.Forms.Label();
            this.cbLabora = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label9);
            this.Encabezado.Controls.Add(this.pbIcono);
            this.Encabezado.Size = new System.Drawing.Size(997, 93);
            // 
            // lblLabora
            // 
            this.lblLabora.AutoSize = true;
            this.lblLabora.BackColor = System.Drawing.Color.Transparent;
            this.lblLabora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLabora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabora.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLabora.Location = new System.Drawing.Point(33, 648);
            this.lblLabora.Name = "lblLabora";
            this.lblLabora.Size = new System.Drawing.Size(94, 17);
            this.lblLabora.TabIndex = 284;
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
            this.btnLabor.Location = new System.Drawing.Point(55, 588);
            this.btnLabor.Name = "btnLabor";
            this.btnLabor.Size = new System.Drawing.Size(50, 50);
            this.btnLabor.TabIndex = 20;
            this.btnLabor.UseVisualStyleBackColor = true;
            this.btnLabor.Click += new System.EventHandler(this.button10_Click);
            this.btnLabor.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnLabor.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(445, 487);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 19);
            this.label16.TabIndex = 282;
            this.label16.Text = "Documentos";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackgroundImage = global::Presentacion.Properties.Resources.IconoReportes;
            this.btnGenerarReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGenerarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Location = new System.Drawing.Point(915, 517);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(50, 50);
            this.btnGenerarReporte.TabIndex = 19;
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            this.btnGenerarReporte.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnGenerarReporte.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblGenerarReporte
            // 
            this.lblGenerarReporte.AutoSize = true;
            this.lblGenerarReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGenerarReporte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerarReporte.ForeColor = System.Drawing.Color.Black;
            this.lblGenerarReporte.Location = new System.Drawing.Point(776, 534);
            this.lblGenerarReporte.Name = "lblGenerarReporte";
            this.lblGenerarReporte.Size = new System.Drawing.Size(133, 17);
            this.lblGenerarReporte.TabIndex = 280;
            this.lblGenerarReporte.Text = "Generar Reporte";
            // 
            // btnFormaPedido
            // 
            this.btnFormaPedido.BackgroundImage = global::Presentacion.Properties.Resources.IconoInfoPedido;
            this.btnFormaPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormaPedido.FlatAppearance.BorderSize = 0;
            this.btnFormaPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFormaPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFormaPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormaPedido.Location = new System.Drawing.Point(126, 516);
            this.btnFormaPedido.Name = "btnFormaPedido";
            this.btnFormaPedido.Size = new System.Drawing.Size(50, 50);
            this.btnFormaPedido.TabIndex = 14;
            this.btnFormaPedido.UseVisualStyleBackColor = true;
            this.btnFormaPedido.Click += new System.EventHandler(this.btnFormaPedido_Click);
            this.btnFormaPedido.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnFormaPedido.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblFormaPedido
            // 
            this.lblFormaPedido.AutoSize = true;
            this.lblFormaPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblFormaPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormaPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPedido.ForeColor = System.Drawing.Color.Black;
            this.lblFormaPedido.Location = new System.Drawing.Point(32, 532);
            this.lblFormaPedido.Name = "lblFormaPedido";
            this.lblFormaPedido.Size = new System.Drawing.Size(88, 17);
            this.lblFormaPedido.TabIndex = 278;
            this.lblFormaPedido.Text = "Ver Pedido";
            // 
            // btnTerminacion
            // 
            this.btnTerminacion.BackgroundImage = global::Presentacion.Properties.Resources.IconoTerminado;
            this.btnTerminacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerminacion.FlatAppearance.BorderSize = 0;
            this.btnTerminacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTerminacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTerminacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminacion.Location = new System.Drawing.Point(697, 517);
            this.btnTerminacion.Name = "btnTerminacion";
            this.btnTerminacion.Size = new System.Drawing.Size(50, 50);
            this.btnTerminacion.TabIndex = 17;
            this.btnTerminacion.UseVisualStyleBackColor = true;
            this.btnTerminacion.Click += new System.EventHandler(this.btnTerminacion_Click);
            this.btnTerminacion.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnTerminacion.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblTerminacion
            // 
            this.lblTerminacion.AutoSize = true;
            this.lblTerminacion.BackColor = System.Drawing.Color.Transparent;
            this.lblTerminacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTerminacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminacion.ForeColor = System.Drawing.Color.Black;
            this.lblTerminacion.Location = new System.Drawing.Point(592, 533);
            this.lblTerminacion.Name = "lblTerminacion";
            this.lblTerminacion.Size = new System.Drawing.Size(99, 17);
            this.lblTerminacion.TabIndex = 276;
            this.lblTerminacion.Text = "Terminación";
            // 
            // btnConfirmacion
            // 
            this.btnConfirmacion.BackgroundImage = global::Presentacion.Properties.Resources.IconoConfirmacion;
            this.btnConfirmacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmacion.FlatAppearance.BorderSize = 0;
            this.btnConfirmacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmacion.Location = new System.Drawing.Point(505, 516);
            this.btnConfirmacion.Name = "btnConfirmacion";
            this.btnConfirmacion.Size = new System.Drawing.Size(50, 50);
            this.btnConfirmacion.TabIndex = 16;
            this.btnConfirmacion.UseVisualStyleBackColor = true;
            this.btnConfirmacion.Click += new System.EventHandler(this.btnConfirmacion_Click);
            this.btnConfirmacion.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnConfirmacion.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfirmacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacion.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmacion.Location = new System.Drawing.Point(393, 534);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(106, 17);
            this.lblConfirmacion.TabIndex = 274;
            this.lblConfirmacion.Text = "Confirmación";
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackgroundImage = global::Presentacion.Properties.Resources.IconoFactura;
            this.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Location = new System.Drawing.Point(313, 516);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(50, 50);
            this.btnFacturacion.TabIndex = 15;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            this.btnFacturacion.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnFacturacion.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.BackColor = System.Drawing.Color.Transparent;
            this.lblFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFacturacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacion.ForeColor = System.Drawing.Color.Black;
            this.lblFacturacion.Location = new System.Drawing.Point(211, 534);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(96, 17);
            this.lblFacturacion.TabIndex = 272;
            this.lblFacturacion.Text = "Facturación";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(741, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 19);
            this.label15.TabIndex = 270;
            this.label15.Text = "Pedidos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(116, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 19);
            this.label14.TabIndex = 269;
            this.label14.Text = "Buscar";
            // 
            // rbTipo
            // 
            this.rbTipo.AutoSize = true;
            this.rbTipo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipo.Location = new System.Drawing.Point(208, 158);
            this.rbTipo.Name = "rbTipo";
            this.rbTipo.Size = new System.Drawing.Size(47, 19);
            this.rbTipo.TabIndex = 7;
            this.rbTipo.Text = "Tipo";
            this.rbTipo.UseVisualStyleBackColor = true;
            // 
            // rbPedido
            // 
            this.rbPedido.AutoSize = true;
            this.rbPedido.Checked = true;
            this.rbPedido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPedido.Location = new System.Drawing.Point(35, 158);
            this.rbPedido.Name = "rbPedido";
            this.rbPedido.Size = new System.Drawing.Size(78, 19);
            this.rbPedido.TabIndex = 3;
            this.rbPedido.TabStop = true;
            this.rbPedido.Text = "Id_Pedido";
            this.rbPedido.UseVisualStyleBackColor = true;
            // 
            // rbDentista
            // 
            this.rbDentista.AutoSize = true;
            this.rbDentista.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDentista.Location = new System.Drawing.Point(119, 158);
            this.rbDentista.Name = "rbDentista";
            this.rbDentista.Size = new System.Drawing.Size(64, 19);
            this.rbDentista.TabIndex = 4;
            this.rbDentista.Text = "Cedula";
            this.rbDentista.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(267, 161);
            this.tbBuscar.MaxLength = 20;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(95, 22);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Presentacion.Properties.Resources.IconoBuscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(368, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 41);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(939, 648);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 258;
            this.label8.Text = "Salir";
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Presentacion.Properties.Resources.IconoSalir;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(933, 588);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.button5.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(411, 666);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(22, 20);
            this.lblUsuario.TabIndex = 250;
            this.lblUsuario.Text = "   ";
            // 
            // lblCancelarPedido
            // 
            this.lblCancelarPedido.AutoSize = true;
            this.lblCancelarPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCancelarPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelarPedido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCancelarPedido.Location = new System.Drawing.Point(856, 180);
            this.lblCancelarPedido.Name = "lblCancelarPedido";
            this.lblCancelarPedido.Size = new System.Drawing.Size(129, 17);
            this.lblCancelarPedido.TabIndex = 256;
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
            this.btnCancelarPedido.Location = new System.Drawing.Point(895, 127);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(50, 50);
            this.btnCancelarPedido.TabIndex = 10;
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
            this.lblModificarPedido.Location = new System.Drawing.Point(711, 180);
            this.lblModificarPedido.Name = "lblModificarPedido";
            this.lblModificarPedido.Size = new System.Drawing.Size(130, 17);
            this.lblModificarPedido.TabIndex = 254;
            this.lblModificarPedido.Text = "Modificar Pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 249;
            this.label6.Text = "Lista de pedidos";
            // 
            // btnModificarPedido
            // 
            this.btnModificarPedido.BackgroundImage = global::Presentacion.Properties.Resources.IconoPedidoModificar;
            this.btnModificarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarPedido.FlatAppearance.BorderSize = 0;
            this.btnModificarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPedido.Location = new System.Drawing.Point(751, 127);
            this.btnModificarPedido.Name = "btnModificarPedido";
            this.btnModificarPedido.Size = new System.Drawing.Size(50, 50);
            this.btnModificarPedido.TabIndex = 9;
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
            this.lblNuevoPedido.Location = new System.Drawing.Point(578, 180);
            this.lblNuevoPedido.Name = "lblNuevoPedido";
            this.lblNuevoPedido.Size = new System.Drawing.Size(108, 17);
            this.lblNuevoPedido.TabIndex = 252;
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
            this.btnNuevoPedido.Location = new System.Drawing.Point(607, 127);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(50, 50);
            this.btnNuevoPedido.TabIndex = 8;
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            this.btnNuevoPedido.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnNuevoPedido.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // dtvDatos
            // 
            this.dtvDatos.AllowUserToAddRows = false;
            this.dtvDatos.AllowUserToDeleteRows = false;
            this.dtvDatos.AllowUserToResizeColumns = false;
            this.dtvDatos.AllowUserToResizeRows = false;
            this.dtvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dtvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDatos.Location = new System.Drawing.Point(12, 230);
            this.dtvDatos.Name = "dtvDatos";
            this.dtvDatos.ReadOnly = true;
            this.dtvDatos.RowHeadersVisible = false;
            this.dtvDatos.Size = new System.Drawing.Size(973, 209);
            this.dtvDatos.TabIndex = 248;
            this.dtvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDatos_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(464, 59);
            this.label9.TabIndex = 46;
            this.label9.Text = "Estado de Pedidos";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoSemaforoFinal;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcono.Location = new System.Drawing.Point(8, 16);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(60, 60);
            this.pbIcono.TabIndex = 45;
            this.pbIcono.TabStop = false;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(828, 445);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 13;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label17.Location = new System.Drawing.Point(764, 449);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 17);
            this.label17.TabIndex = 290;
            this.label17.Text = "Estado";
            // 
            // lblTrabaja
            // 
            this.lblTrabaja.AutoSize = true;
            this.lblTrabaja.BackColor = System.Drawing.Color.Transparent;
            this.lblTrabaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTrabaja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabaja.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTrabaja.Location = new System.Drawing.Point(513, 449);
            this.lblTrabaja.Name = "lblTrabaja";
            this.lblTrabaja.Size = new System.Drawing.Size(107, 17);
            this.lblTrabaja.TabIndex = 292;
            this.lblTrabaja.Text = "Laboratorista";
            // 
            // cbLabora
            // 
            this.cbLabora.FormattingEnabled = true;
            this.cbLabora.Location = new System.Drawing.Point(626, 445);
            this.cbLabora.Name = "cbLabora";
            this.cbLabora.Size = new System.Drawing.Size(121, 24);
            this.cbLabora.TabIndex = 291;
            this.cbLabora.SelectedIndexChanged += new System.EventHandler(this.cbTrabaja_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 293;
            this.label1.Text = "Cancelado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(123, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 294;
            this.label2.Text = "Registrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(228, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 295;
            this.label3.Text = "Confirmado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSalmon;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(336, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 300;
            this.label5.Text = "Pagado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(858, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 299;
            this.label7.Text = "Facturado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(741, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 298;
            this.label10.Text = "Terminado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(621, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 14);
            this.label11.TabIndex = 297;
            this.label11.Text = "En Proceso";
            // 
            // PantallaEstadoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(997, 688);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrabaja);
            this.Controls.Add(this.cbLabora);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblLabora);
            this.Controls.Add(this.btnLabor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.lblGenerarReporte);
            this.Controls.Add(this.btnFormaPedido);
            this.Controls.Add(this.lblFormaPedido);
            this.Controls.Add(this.btnTerminacion);
            this.Controls.Add(this.lblTerminacion);
            this.Controls.Add(this.btnConfirmacion);
            this.Controls.Add(this.lblConfirmacion);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.lblFacturacion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.rbTipo);
            this.Controls.Add(this.rbPedido);
            this.Controls.Add(this.rbDentista);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCancelarPedido);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.lblModificarPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnModificarPedido);
            this.Controls.Add(this.lblNuevoPedido);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.dtvDatos);
            this.Name = "PantallaEstadoPedido";
            this.Text = "Semáforo";
            this.Load += new System.EventHandler(this.PantallaEstadoPedido_Load);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.dtvDatos, 0);
            this.Controls.SetChildIndex(this.btnNuevoPedido, 0);
            this.Controls.SetChildIndex(this.lblNuevoPedido, 0);
            this.Controls.SetChildIndex(this.btnModificarPedido, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblModificarPedido, 0);
            this.Controls.SetChildIndex(this.btnCancelarPedido, 0);
            this.Controls.SetChildIndex(this.lblCancelarPedido, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.tbBuscar, 0);
            this.Controls.SetChildIndex(this.rbDentista, 0);
            this.Controls.SetChildIndex(this.rbPedido, 0);
            this.Controls.SetChildIndex(this.rbTipo, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.lblFacturacion, 0);
            this.Controls.SetChildIndex(this.btnFacturacion, 0);
            this.Controls.SetChildIndex(this.lblConfirmacion, 0);
            this.Controls.SetChildIndex(this.btnConfirmacion, 0);
            this.Controls.SetChildIndex(this.lblTerminacion, 0);
            this.Controls.SetChildIndex(this.btnTerminacion, 0);
            this.Controls.SetChildIndex(this.lblFormaPedido, 0);
            this.Controls.SetChildIndex(this.btnFormaPedido, 0);
            this.Controls.SetChildIndex(this.lblGenerarReporte, 0);
            this.Controls.SetChildIndex(this.btnGenerarReporte, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.btnLabor, 0);
            this.Controls.SetChildIndex(this.lblLabora, 0);
            this.Controls.SetChildIndex(this.cbEstado, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.cbLabora, 0);
            this.Controls.SetChildIndex(this.lblTrabaja, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabora;
        private System.Windows.Forms.Button btnLabor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label lblGenerarReporte;
        private System.Windows.Forms.Button btnFormaPedido;
        private System.Windows.Forms.Label lblFormaPedido;
        private System.Windows.Forms.Button btnTerminacion;
        private System.Windows.Forms.Label lblTerminacion;
        private System.Windows.Forms.Button btnConfirmacion;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbTipo;
        private System.Windows.Forms.RadioButton rbPedido;
        private System.Windows.Forms.RadioButton rbDentista;
        protected System.Windows.Forms.TextBox tbBuscar;
        protected System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCancelarPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Label lblModificarPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModificarPedido;
        private System.Windows.Forms.Label lblNuevoPedido;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.DataGridView dtvDatos;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTrabaja;
        private System.Windows.Forms.ComboBox cbLabora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
