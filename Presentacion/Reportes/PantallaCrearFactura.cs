using System;
using System.ComponentModel;
using System.Windows.Forms;
using Control;
using Entidad;
using Entidad.Reportes;
using static Control.ManejadorContabilidad;

namespace Presentacion.Reportes
{
    class PantallaCrearFactura : Pantalla
    {

        public static Factura Factura;

        #region UI

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFacturaId;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblCodigoPostalCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblRfcCliente;
        private System.Windows.Forms.Label lblCiudadEmpresa;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblRfcEmpresa;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblCodigoPostalEmpresa;
        private System.Windows.Forms.Label lblDireccionEmpresa;
        private System.Windows.Forms.Label lblEstadoEmpresa;
        private System.Windows.Forms.Label lblCiudadCliente;
        private System.Windows.Forms.Label lblEstadoCliente;
        private System.Windows.Forms.Label lblTelefonoEmpresa;
        private System.Windows.Forms.Label lblCorreoEmpresa;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private Button btnModificar;
        private Label label1;
        private DataGridViewTextBoxColumn cnumero;
        private DataGridViewTextBoxColumn cdescripcion;
        private DataGridViewTextBoxColumn cpreciounitario;
        private DataGridViewTextBoxColumn cpreciomat1;
        private DataGridViewTextBoxColumn cpreciomat2;
        private DataGridViewTextBoxColumn cimporte;
        private System.Windows.Forms.Label label5;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCrearFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFacturaId = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblCodigoPostalCliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblRfcCliente = new System.Windows.Forms.Label();
            this.lblCiudadEmpresa = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.cnumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpreciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpreciomat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpreciomat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblRfcEmpresa = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblCodigoPostalEmpresa = new System.Windows.Forms.Label();
            this.lblDireccionEmpresa = new System.Windows.Forms.Label();
            this.lblEstadoEmpresa = new System.Windows.Forms.Label();
            this.lblCiudadCliente = new System.Windows.Forms.Label();
            this.lblEstadoCliente = new System.Windows.Forms.Label();
            this.lblTelefonoEmpresa = new System.Windows.Forms.Label();
            this.lblCorreoEmpresa = new System.Windows.Forms.Label();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.pictureBox1);
            this.Encabezado.Controls.Add(this.label5);
            this.Encabezado.Size = new System.Drawing.Size(906, 101);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 90);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(23, 7);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 74);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(110, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Agregar Factura";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(514, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Favor de ingresar la informacion mediante el boton de buscar pedido.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(695, 576);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Aceptar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(801, 576);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cancelar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(770, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Limpiar tabla";
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.BackgroundImage = global::Presentacion.Properties.Resources.IconoBuscarPedido;
            this.btnBuscarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPedido.FlatAppearance.BorderSize = 0;
            this.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedido.Location = new System.Drawing.Point(677, 172);
            this.btnBuscarPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(60, 60);
            this.btnBuscarPedido.TabIndex = 9;
            this.btnBuscarPedido.TabStop = false;
            this.btnBuscarPedido.UseVisualStyleBackColor = true;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::Presentacion.Properties.Resources.eraser_46865;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(786, 172);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(60, 60);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Presentacion.Properties.Resources.IconoAceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(695, 512);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(60, 60);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(804, 512);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 60);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.invoice_account_bank_check;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 74);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(100, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Generar factura";
            // 
            // lblFacturaId
            // 
            this.lblFacturaId.AutoSize = true;
            this.lblFacturaId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaId.Location = new System.Drawing.Point(42, 168);
            this.lblFacturaId.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblFacturaId.Name = "lblFacturaId";
            this.lblFacturaId.Size = new System.Drawing.Size(77, 17);
            this.lblFacturaId.TabIndex = 0;
            this.lblFacturaId.Text = "N° Factura: ";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(332, 168);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(59, 17);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lista de productos:";
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(332, 208);
            this.lblDireccionCliente.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(69, 17);
            this.lblDireccionCliente.TabIndex = 0;
            this.lblDireccionCliente.Text = "Direccion:";
            // 
            // lblCodigoPostalCliente
            // 
            this.lblCodigoPostalCliente.AutoSize = true;
            this.lblCodigoPostalCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostalCliente.Location = new System.Drawing.Point(332, 228);
            this.lblCodigoPostalCliente.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCodigoPostalCliente.Name = "lblCodigoPostalCliente";
            this.lblCodigoPostalCliente.Size = new System.Drawing.Size(94, 17);
            this.lblCodigoPostalCliente.TabIndex = 0;
            this.lblCodigoPostalCliente.Text = "Codigo Postal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "Informacion del cliente";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.Location = new System.Drawing.Point(42, 188);
            this.lblFechaEmision.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(115, 17);
            this.lblFechaEmision.TabIndex = 0;
            this.lblFechaEmision.Text = "Fecha de emision:";
            // 
            // lblRfcCliente
            // 
            this.lblRfcCliente.AutoSize = true;
            this.lblRfcCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRfcCliente.Location = new System.Drawing.Point(332, 188);
            this.lblRfcCliente.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblRfcCliente.Name = "lblRfcCliente";
            this.lblRfcCliente.Size = new System.Drawing.Size(33, 17);
            this.lblRfcCliente.TabIndex = 0;
            this.lblRfcCliente.Text = "RFC:";
            // 
            // lblCiudadEmpresa
            // 
            this.lblCiudadEmpresa.AutoSize = true;
            this.lblCiudadEmpresa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadEmpresa.Location = new System.Drawing.Point(42, 319);
            this.lblCiudadEmpresa.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCiudadEmpresa.Name = "lblCiudadEmpresa";
            this.lblCiudadEmpresa.Size = new System.Drawing.Size(54, 17);
            this.lblCiudadEmpresa.TabIndex = 0;
            this.lblCiudadEmpresa.Text = "Ciudad:";
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnumero,
            this.cdescripcion,
            this.cpreciounitario,
            this.cpreciomat1,
            this.cpreciomat2,
            this.cimporte});
            this.dgvTabla.Location = new System.Drawing.Point(45, 420);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.Size = new System.Drawing.Size(605, 260);
            this.dgvTabla.TabIndex = 10;
            // 
            // cnumero
            // 
            this.cnumero.FillWeight = 25F;
            this.cnumero.HeaderText = "#";
            this.cnumero.Name = "cnumero";
            this.cnumero.ReadOnly = true;
            // 
            // cdescripcion
            // 
            this.cdescripcion.HeaderText = "Descripcion";
            this.cdescripcion.Name = "cdescripcion";
            this.cdescripcion.ReadOnly = true;
            // 
            // cpreciounitario
            // 
            this.cpreciounitario.FillWeight = 50F;
            this.cpreciounitario.HeaderText = "Precio Base";
            this.cpreciounitario.Name = "cpreciounitario";
            this.cpreciounitario.ReadOnly = true;
            // 
            // cpreciomat1
            // 
            this.cpreciomat1.FillWeight = 50F;
            this.cpreciomat1.HeaderText = "P. Material 1";
            this.cpreciomat1.Name = "cpreciomat1";
            this.cpreciomat1.ReadOnly = true;
            // 
            // cpreciomat2
            // 
            this.cpreciomat2.FillWeight = 50F;
            this.cpreciomat2.HeaderText = "P. Material 2";
            this.cpreciomat2.Name = "cpreciomat2";
            this.cpreciomat2.ReadOnly = true;
            // 
            // cimporte
            // 
            this.cimporte.FillWeight = 75F;
            this.cimporte.HeaderText = "Importe Total";
            this.cimporte.Name = "cimporte";
            this.cimporte.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Presentacion.Properties.Resources.ImagenSeparador;
            this.pictureBox2.Location = new System.Drawing.Point(332, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 2);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(42, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 14);
            this.label17.TabIndex = 0;
            this.label17.Text = "Informacion de la factura";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Presentacion.Properties.Resources.ImagenSeparador;
            this.pictureBox3.Location = new System.Drawing.Point(42, 163);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 2);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Presentacion.Properties.Resources.ImagenSeparador;
            this.pictureBox4.Location = new System.Drawing.Point(42, 234);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(240, 2);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // lblRfcEmpresa
            // 
            this.lblRfcEmpresa.AutoSize = true;
            this.lblRfcEmpresa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRfcEmpresa.Location = new System.Drawing.Point(42, 259);
            this.lblRfcEmpresa.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblRfcEmpresa.Name = "lblRfcEmpresa";
            this.lblRfcEmpresa.Size = new System.Drawing.Size(33, 17);
            this.lblRfcEmpresa.TabIndex = 12;
            this.lblRfcEmpresa.Text = "RFC:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(42, 217);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(162, 14);
            this.label19.TabIndex = 13;
            this.label19.Text = "Informacion de la empresa";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(42, 239);
            this.lblNombreEmpresa.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(164, 17);
            this.lblNombreEmpresa.TabIndex = 14;
            this.lblNombreEmpresa.Text = "Nombre: Diamon Dentures";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Presentacion.Properties.Resources.ImagenSeparador;
            this.pictureBox6.Location = new System.Drawing.Point(663, 163);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 2);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(663, 146);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 14);
            this.label21.TabIndex = 16;
            this.label21.Text = "Opciones";
            // 
            // lblCodigoPostalEmpresa
            // 
            this.lblCodigoPostalEmpresa.AutoSize = true;
            this.lblCodigoPostalEmpresa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostalEmpresa.Location = new System.Drawing.Point(42, 299);
            this.lblCodigoPostalEmpresa.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCodigoPostalEmpresa.Name = "lblCodigoPostalEmpresa";
            this.lblCodigoPostalEmpresa.Size = new System.Drawing.Size(94, 17);
            this.lblCodigoPostalEmpresa.TabIndex = 18;
            this.lblCodigoPostalEmpresa.Text = "Codigo Postal:";
            // 
            // lblDireccionEmpresa
            // 
            this.lblDireccionEmpresa.AutoSize = true;
            this.lblDireccionEmpresa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionEmpresa.Location = new System.Drawing.Point(42, 279);
            this.lblDireccionEmpresa.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblDireccionEmpresa.Name = "lblDireccionEmpresa";
            this.lblDireccionEmpresa.Size = new System.Drawing.Size(69, 17);
            this.lblDireccionEmpresa.TabIndex = 19;
            this.lblDireccionEmpresa.Text = "Direccion:";
            // 
            // lblEstadoEmpresa
            // 
            this.lblEstadoEmpresa.AutoSize = true;
            this.lblEstadoEmpresa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoEmpresa.Location = new System.Drawing.Point(42, 339);
            this.lblEstadoEmpresa.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblEstadoEmpresa.Name = "lblEstadoEmpresa";
            this.lblEstadoEmpresa.Size = new System.Drawing.Size(51, 17);
            this.lblEstadoEmpresa.TabIndex = 0;
            this.lblEstadoEmpresa.Text = "Estado:";
            // 
            // lblCiudadCliente
            // 
            this.lblCiudadCliente.AutoSize = true;
            this.lblCiudadCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadCliente.Location = new System.Drawing.Point(332, 248);
            this.lblCiudadCliente.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCiudadCliente.Name = "lblCiudadCliente";
            this.lblCiudadCliente.Size = new System.Drawing.Size(54, 17);
            this.lblCiudadCliente.TabIndex = 0;
            this.lblCiudadCliente.Text = "Ciudad:";
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.AutoSize = true;
            this.lblEstadoCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCliente.Location = new System.Drawing.Point(332, 268);
            this.lblEstadoCliente.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(51, 17);
            this.lblEstadoCliente.TabIndex = 0;
            this.lblEstadoCliente.Text = "Estado:";
            // 
            // lblTelefonoEmpresa
            // 
            this.lblTelefonoEmpresa.AutoSize = true;
            this.lblTelefonoEmpresa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoEmpresa.Location = new System.Drawing.Point(42, 359);
            this.lblTelefonoEmpresa.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblTelefonoEmpresa.Name = "lblTelefonoEmpresa";
            this.lblTelefonoEmpresa.Size = new System.Drawing.Size(62, 17);
            this.lblTelefonoEmpresa.TabIndex = 0;
            this.lblTelefonoEmpresa.Text = "Telefono:";
            // 
            // lblCorreoEmpresa
            // 
            this.lblCorreoEmpresa.AutoSize = true;
            this.lblCorreoEmpresa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoEmpresa.Location = new System.Drawing.Point(42, 379);
            this.lblCorreoEmpresa.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCorreoEmpresa.Name = "lblCorreoEmpresa";
            this.lblCorreoEmpresa.Size = new System.Drawing.Size(52, 17);
            this.lblCorreoEmpresa.TabIndex = 0;
            this.lblCorreoEmpresa.Text = "Correo:";
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(332, 288);
            this.lblTelefonoCliente.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(62, 17);
            this.lblTelefonoCliente.TabIndex = 0;
            this.lblTelefonoCliente.Text = "Telefono:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::Presentacion.Properties.Resources.IconoModificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(739, 292);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(60, 60);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.TabStop = false;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Modificar datos";
            // 
            // PantallaCrearFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 701);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigoPostalEmpresa);
            this.Controls.Add(this.lblDireccionEmpresa);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblRfcEmpresa);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblEstadoCliente);
            this.Controls.Add(this.lblCiudadCliente);
            this.Controls.Add(this.lblTelefonoCliente);
            this.Controls.Add(this.lblCorreoEmpresa);
            this.Controls.Add(this.lblTelefonoEmpresa);
            this.Controls.Add(this.lblEstadoEmpresa);
            this.Controls.Add(this.lblCiudadEmpresa);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblRfcCliente);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblFechaEmision);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCodigoPostalCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblDireccionCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblFacturaId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "PantallaCrearFactura";
            this.Text = "Generar factura";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.lblFacturaId, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.lblNombreCliente, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblDireccionCliente, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.lblCodigoPostalCliente, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.btnBuscarPedido, 0);
            this.Controls.SetChildIndex(this.lblFechaEmision, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.lblRfcCliente, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.lblCiudadEmpresa, 0);
            this.Controls.SetChildIndex(this.lblEstadoEmpresa, 0);
            this.Controls.SetChildIndex(this.lblTelefonoEmpresa, 0);
            this.Controls.SetChildIndex(this.lblCorreoEmpresa, 0);
            this.Controls.SetChildIndex(this.lblTelefonoCliente, 0);
            this.Controls.SetChildIndex(this.lblCiudadCliente, 0);
            this.Controls.SetChildIndex(this.lblEstadoCliente, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.dgvTabla, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.lblNombreEmpresa, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.lblRfcEmpresa, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.pictureBox6, 0);
            this.Controls.SetChildIndex(this.lblDireccionEmpresa, 0);
            this.Controls.SetChildIndex(this.lblCodigoPostalEmpresa, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public PantallaCrearFactura()
        {
            InitializeComponent();
        }

        public PantallaCrearFactura(string clave)
        {
            InitializeComponent();
            Factura = ConsultarFactura(clave);
            if(Factura == null) return;
            MostrarDatos();
        }

        #region Metodos

        void Reiniciar()
        {

            lblFacturaId.Text = TextosDefault.NFactura;
            lblFechaEmision.Text = TextosDefault.FechaEmision;
            lblNombreCliente.Text = TextosDefault.Nombre;
            lblNombreEmpresa.Text = TextosDefault.Nombre;
            lblRfcCliente.Text = TextosDefault.Rfc;
            lblRfcEmpresa.Text = TextosDefault.Rfc;
            lblDireccionCliente.Text = TextosDefault.Direccion;
            lblDireccionEmpresa.Text = TextosDefault.Direccion;
            lblCodigoPostalCliente.Text = TextosDefault.CodigoPostal;
            lblCodigoPostalEmpresa.Text = TextosDefault.CodigoPostal;
            lblCiudadCliente.Text = TextosDefault.Ciudad;
            lblCiudadEmpresa.Text = TextosDefault.Ciudad;
            lblEstadoCliente.Text = TextosDefault.Estado;
            lblEstadoEmpresa.Text = TextosDefault.Estado;
            lblTelefonoCliente.Text = TextosDefault.Telefono;
            lblTelefonoEmpresa.Text = TextosDefault.Telefono;
            lblCiudadEmpresa.Text = TextosDefault.Correo;

            dgvTabla.Rows.Clear();
        }

        void MostrarDatos()
        {
            lblFacturaId.Text = $"{TextosDefault.NFactura} {Factura.Id}";
            lblFechaEmision.Text = $"{TextosDefault.FechaEmision} {Factura.Fecha}";
            lblNombreCliente.Text = $"{TextosDefault.Nombre} {Factura.NombreC}";
            lblNombreEmpresa.Text = $"{TextosDefault.Nombre} {Factura.NombreE}";
            lblRfcCliente.Text = $"{TextosDefault.Rfc} {Factura.RfcC}";
            lblRfcEmpresa.Text = $"{TextosDefault.Rfc} {Factura.RfcE}";
            lblDireccionCliente.Text = $"{TextosDefault.Direccion} {Factura.CalleC}";
            lblDireccionEmpresa.Text = $"{TextosDefault.Direccion} {Factura.CalleE}";
            lblCodigoPostalCliente.Text = $"{TextosDefault.CodigoPostal} {Factura.CpC}";
            lblCodigoPostalEmpresa.Text = $"{TextosDefault.CodigoPostal} {Factura.CpE}";
            lblCiudadCliente.Text = $"{TextosDefault.Ciudad} {Factura.CiudadC}";
            lblCiudadEmpresa.Text = $"{TextosDefault.Ciudad} {Factura.CiudadE}";
            lblEstadoCliente.Text = $"{TextosDefault.Estado} {Factura.EstadoC}";
            lblEstadoEmpresa.Text = $"{TextosDefault.Estado} {Factura.EstadoE}";
            lblTelefonoCliente.Text = $"{TextosDefault.Telefono} {Factura.TelefonoC}";
            lblTelefonoEmpresa.Text = $"{TextosDefault.Telefono} {Factura.TelefonoE}";
            lblCorreoEmpresa.Text = $"{TextosDefault.Correo} {Factura.CorreoE}";
            
            dgvTabla.Rows.Clear();
            if (Factura.ListaProductos != null)
            {
                foreach (Productos producto in Factura.ListaProductos)
                {
                    dgvTabla.RowCount++;
                    dgvTabla["cnumero", dgvTabla.RowCount - 1].Value = producto.Clave;
                    dgvTabla["cdescripcion", dgvTabla.RowCount - 1].Value = producto.Producto;
                    dgvTabla["cpreciounitario", dgvTabla.RowCount - 1].Value = producto.PrecioProducto;
                    dgvTabla["cpreciomat1", dgvTabla.RowCount - 1].Value = producto.PrecioMat1;
                    dgvTabla["cpreciomat2", dgvTabla.RowCount - 1].Value = producto.PrecioMat2;
                    dgvTabla["cimporte", dgvTabla.RowCount - 1].Value = producto.PrecioProducto + producto.PrecioMat1 + producto.PrecioMat2;
                }
            }
            Refresh();
        }

        #endregion

        #region Eventos

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            PantallaBuscarPedido buscarPedido = new PantallaBuscarPedido();

            buscarPedido.ShowDialog();

            if (PantallaBuscarPedido.Factura == null)
            {
                buscarPedido.Close();
                return;
            }

            Factura = PantallaBuscarPedido.Factura;
            MostrarDatos();

            buscarPedido.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Facturar(Factura);
            Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogoModicarFactura dmf = new DialogoModicarFactura();
            if (Factura == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna factura", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogoModicarFactura.Factura = Factura;
                dmf.ShowDialog();
                Factura = DialogoModicarFactura.Factura;
                MostrarDatos();
            }
            dmf.Close();
            BringToFront();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        #endregion

    }

    struct TextosDefault
    {

        public const string NFactura = "N° Factura";
        public const string FechaEmision = "Fecha de emision";
        public const string Nombre = "Nombre:";
        public const string Rfc = "RFC:";
        public const string Direccion = "Direccion:";
        public const string CodigoPostal = "Codigo Postal:";
        public const string Ciudad = "Ciudad:";
        public const string Estado = "Estado:";
        public const string Telefono = "Telefono:";
        public const string Correo = "Correo";

    }
}
