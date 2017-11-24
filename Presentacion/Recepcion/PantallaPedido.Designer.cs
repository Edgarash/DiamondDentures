namespace Presentacion.Recepcion
{
    partial class PantallaPedido
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
            this.pbSeparador1 = new System.Windows.Forms.PictureBox();
            this.lblAceptar = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblRegistra = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tbFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.pbSeparador2 = new System.Windows.Forms.PictureBox();
            this.btnDentista = new System.Windows.Forms.Button();
            this.lblFechaProbable = new System.Windows.Forms.Label();
            this.tbFechaEntrega = new System.Windows.Forms.MaskedTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbUrgente = new System.Windows.Forms.CheckBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblDentista = new System.Windows.Forms.Label();
            this.lblMostrarNombreDentista = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblMostrarDireccion = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblMostrarRFC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTrabajos = new System.Windows.Forms.NumericUpDown();
            this.Panel = new System.Windows.Forms.Panel();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrabajos)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.lblPantallaUsuario);
            this.Encabezado.Controls.Add(this.pbIcono);
            this.Encabezado.Size = new System.Drawing.Size(810, 93);
            this.Encabezado.TabIndex = 0;
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.AutoSize = true;
            this.lblPantallaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblPantallaUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantallaUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPantallaUsuario.Location = new System.Drawing.Point(93, 36);
            this.lblPantallaUsuario.Name = "lblPantallaUsuario";
            this.lblPantallaUsuario.Size = new System.Drawing.Size(168, 24);
            this.lblPantallaUsuario.TabIndex = 0;
            this.lblPantallaUsuario.Text = "Pantalla Pedido";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoPedido;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcono.Location = new System.Drawing.Point(19, 16);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(60, 60);
            this.pbIcono.TabIndex = 11;
            this.pbIcono.TabStop = false;
            // 
            // pbSeparador1
            // 
            this.pbSeparador1.BackgroundImage = global::Presentacion.Properties.Resources.ImagenSeparador;
            this.pbSeparador1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSeparador1.Location = new System.Drawing.Point(19, 155);
            this.pbSeparador1.Name = "pbSeparador1";
            this.pbSeparador1.Size = new System.Drawing.Size(771, 14);
            this.pbSeparador1.TabIndex = 144;
            this.pbSeparador1.TabStop = false;
            // 
            // lblAceptar
            // 
            this.lblAceptar.AutoSize = true;
            this.lblAceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAceptar.Location = new System.Drawing.Point(623, 666);
            this.lblAceptar.Name = "lblAceptar";
            this.lblAceptar.Size = new System.Drawing.Size(73, 18);
            this.lblAceptar.TabIndex = 154;
            this.lblAceptar.Text = "Aceptar";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = global::Presentacion.Properties.Resources.IconoAceptar;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(628, 605);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(62, 58);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.Location = new System.Drawing.Point(717, 666);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(81, 18);
            this.lblCancelar.TabIndex = 156;
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
            this.btnCerrar.Location = new System.Drawing.Point(726, 605);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(62, 58);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblRegistra
            // 
            this.lblRegistra.AutoSize = true;
            this.lblRegistra.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistra.Location = new System.Drawing.Point(27, 103);
            this.lblRegistra.Name = "lblRegistra";
            this.lblRegistra.Size = new System.Drawing.Size(133, 16);
            this.lblRegistra.TabIndex = 300;
            this.lblRegistra.Text = "Registra El Usuario: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(600, 103);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 16);
            this.lblFecha.TabIndex = 300;
            this.lblFecha.Text = "Fecha:";
            // 
            // tbFecha
            // 
            this.tbFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFecha.Location = new System.Drawing.Point(657, 100);
            this.tbFecha.Mask = "00/00/0000 00:00";
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(133, 23);
            this.tbFecha.TabIndex = 159;
            this.tbFecha.TabStop = false;
            this.tbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUsuario.Location = new System.Drawing.Point(159, 103);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 16);
            this.lblUsuario.TabIndex = 300;
            this.lblUsuario.Text = "Michel";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(20, 130);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(71, 17);
            this.lblClave.TabIndex = 300;
            this.lblClave.Text = "#Pedido: ";
            // 
            // tbClave
            // 
            this.tbClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbClave.Location = new System.Drawing.Point(97, 128);
            this.tbClave.MaxLength = 10;
            this.tbClave.Name = "tbClave";
            this.tbClave.ShortcutsEnabled = false;
            this.tbClave.Size = new System.Drawing.Size(94, 21);
            this.tbClave.TabIndex = 1;
            // 
            // pbSeparador2
            // 
            this.pbSeparador2.BackgroundImage = global::Presentacion.Properties.Resources.ImagenSeparador;
            this.pbSeparador2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSeparador2.Location = new System.Drawing.Point(19, 299);
            this.pbSeparador2.Name = "pbSeparador2";
            this.pbSeparador2.Size = new System.Drawing.Size(771, 14);
            this.pbSeparador2.TabIndex = 144;
            this.pbSeparador2.TabStop = false;
            // 
            // btnDentista
            // 
            this.btnDentista.BackgroundImage = global::Presentacion.Properties.Resources.IconoDentistaAgregar;
            this.btnDentista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDentista.FlatAppearance.BorderSize = 0;
            this.btnDentista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDentista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDentista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDentista.Location = new System.Drawing.Point(690, 213);
            this.btnDentista.Name = "btnDentista";
            this.btnDentista.Size = new System.Drawing.Size(80, 80);
            this.btnDentista.TabIndex = 160;
            this.btnDentista.UseVisualStyleBackColor = true;
            this.btnDentista.Click += new System.EventHandler(this.btnDentista_Click);
            // 
            // lblFechaProbable
            // 
            this.lblFechaProbable.AutoSize = true;
            this.lblFechaProbable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaProbable.Location = new System.Drawing.Point(16, 535);
            this.lblFechaProbable.Name = "lblFechaProbable";
            this.lblFechaProbable.Size = new System.Drawing.Size(190, 17);
            this.lblFechaProbable.TabIndex = 161;
            this.lblFechaProbable.Text = "Fecha Probable De Entrega:";
            // 
            // tbFechaEntrega
            // 
            this.tbFechaEntrega.Enabled = false;
            this.tbFechaEntrega.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaEntrega.Location = new System.Drawing.Point(19, 562);
            this.tbFechaEntrega.Mask = "00/00/0000";
            this.tbFechaEntrega.Name = "tbFechaEntrega";
            this.tbFechaEntrega.Size = new System.Drawing.Size(95, 23);
            this.tbFechaEntrega.TabIndex = 162;
            this.tbFechaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFechaEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotal.Location = new System.Drawing.Point(686, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 24);
            this.lblTotal.TabIndex = 300;
            this.lblTotal.Text = "Total $$$";
            // 
            // tbUrgente
            // 
            this.tbUrgente.AutoSize = true;
            this.tbUrgente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUrgente.ForeColor = System.Drawing.Color.Red;
            this.tbUrgente.Location = new System.Drawing.Point(149, 564);
            this.tbUrgente.Name = "tbUrgente";
            this.tbUrgente.Size = new System.Drawing.Size(77, 21);
            this.tbUrgente.TabIndex = 19;
            this.tbUrgente.Text = "Urgente";
            this.tbUrgente.UseVisualStyleBackColor = true;
            // 
            // tbCedula
            // 
            this.tbCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCedula.Location = new System.Drawing.Point(20, 189);
            this.tbCedula.MaxLength = 7;
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.ShortcutsEnabled = false;
            this.tbCedula.Size = new System.Drawing.Size(122, 21);
            this.tbCedula.TabIndex = 2;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(20, 172);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(122, 17);
            this.lblCedula.TabIndex = 185;
            this.lblCedula.Text = "*Número Cédula:";
            // 
            // lblDentista
            // 
            this.lblDentista.AutoSize = true;
            this.lblDentista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDentista.Location = new System.Drawing.Point(168, 172);
            this.lblDentista.Name = "lblDentista";
            this.lblDentista.Size = new System.Drawing.Size(122, 17);
            this.lblDentista.TabIndex = 185;
            this.lblDentista.Text = "Nombre Dentista:";
            // 
            // lblMostrarNombreDentista
            // 
            this.lblMostrarNombreDentista.AutoSize = true;
            this.lblMostrarNombreDentista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarNombreDentista.Location = new System.Drawing.Point(168, 191);
            this.lblMostrarNombreDentista.Name = "lblMostrarNombreDentista";
            this.lblMostrarNombreDentista.Size = new System.Drawing.Size(88, 17);
            this.lblMostrarNombreDentista.TabIndex = 185;
            this.lblMostrarNombreDentista.Text = "                    ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(20, 213);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(73, 17);
            this.lblDireccion.TabIndex = 185;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblMostrarDireccion
            // 
            this.lblMostrarDireccion.AutoSize = true;
            this.lblMostrarDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDireccion.Location = new System.Drawing.Point(20, 232);
            this.lblMostrarDireccion.Name = "lblMostrarDireccion";
            this.lblMostrarDireccion.Size = new System.Drawing.Size(88, 17);
            this.lblMostrarDireccion.TabIndex = 185;
            this.lblMostrarDireccion.Text = "                    ";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFC.Location = new System.Drawing.Point(576, 172);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(37, 17);
            this.lblRFC.TabIndex = 185;
            this.lblRFC.Text = "RFC:";
            // 
            // lblMostrarRFC
            // 
            this.lblMostrarRFC.AutoSize = true;
            this.lblMostrarRFC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarRFC.Location = new System.Drawing.Point(576, 191);
            this.lblMostrarRFC.Name = "lblMostrarRFC";
            this.lblMostrarRFC.Size = new System.Drawing.Size(88, 17);
            this.lblMostrarRFC.TabIndex = 185;
            this.lblMostrarRFC.Text = "                    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 185;
            this.label1.Text = "# Productos:";
            // 
            // nudTrabajos
            // 
            this.nudTrabajos.Location = new System.Drawing.Point(116, 323);
            this.nudTrabajos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTrabajos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTrabajos.Name = "nudTrabajos";
            this.nudTrabajos.Size = new System.Drawing.Size(110, 21);
            this.nudTrabajos.TabIndex = 302;
            this.nudTrabajos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTrabajos.ValueChanged += new System.EventHandler(this.nudTrabajos_ValueChanged);
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.Location = new System.Drawing.Point(23, 350);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(765, 182);
            this.Panel.TabIndex = 303;
            // 
            // PantallaPedido
            // 
            this.AcceptButton = this.btnRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(810, 693);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.nudTrabajos);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.lblMostrarDireccion);
            this.Controls.Add(this.lblMostrarRFC);
            this.Controls.Add(this.lblMostrarNombreDentista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.lblDentista);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbFechaEntrega);
            this.Controls.Add(this.lblFechaProbable);
            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.tbUrgente);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblAceptar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pbSeparador2);
            this.Controls.Add(this.pbSeparador1);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblRegistra);
            this.Controls.Add(this.lblClave);
            this.Name = "PantallaPedido";
            this.Text = "Pantalla Pedido";
            this.Controls.SetChildIndex(this.lblClave, 0);
            this.Controls.SetChildIndex(this.lblRegistra, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.tbClave, 0);
            this.Controls.SetChildIndex(this.pbSeparador1, 0);
            this.Controls.SetChildIndex(this.pbSeparador2, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.lblAceptar, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.lblCancelar, 0);
            this.Controls.SetChildIndex(this.tbUrgente, 0);
            this.Controls.SetChildIndex(this.tbFecha, 0);
            this.Controls.SetChildIndex(this.btnDentista, 0);
            this.Controls.SetChildIndex(this.lblFechaProbable, 0);
            this.Controls.SetChildIndex(this.tbFechaEntrega, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.lblCedula, 0);
            this.Controls.SetChildIndex(this.lblDentista, 0);
            this.Controls.SetChildIndex(this.lblRFC, 0);
            this.Controls.SetChildIndex(this.lblDireccion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblMostrarNombreDentista, 0);
            this.Controls.SetChildIndex(this.lblMostrarRFC, 0);
            this.Controls.SetChildIndex(this.lblMostrarDireccion, 0);
            this.Controls.SetChildIndex(this.tbCedula, 0);
            this.Controls.SetChildIndex(this.nudTrabajos, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.Panel, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrabajos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblPantallaUsuario;
        protected System.Windows.Forms.PictureBox pbIcono;
        protected System.Windows.Forms.Button btnRegistrar;
        protected System.Windows.Forms.Button btnCerrar;
        protected System.Windows.Forms.TextBox tbClave;
        protected System.Windows.Forms.PictureBox pbSeparador1;
        protected System.Windows.Forms.Label lblRegistra;
        protected System.Windows.Forms.Label lblFecha;
        protected System.Windows.Forms.MaskedTextBox tbFecha;
        protected System.Windows.Forms.Label lblUsuario;
        protected System.Windows.Forms.Label lblClave;
        protected System.Windows.Forms.PictureBox pbSeparador2;
        protected System.Windows.Forms.Label lblAceptar;
        protected System.Windows.Forms.Label lblCancelar;
        protected System.Windows.Forms.Label lblFechaProbable;
        protected System.Windows.Forms.MaskedTextBox tbFechaEntrega;
        protected System.Windows.Forms.Label lblTotal;
        protected System.Windows.Forms.CheckBox tbUrgente;
        protected System.Windows.Forms.TextBox tbCedula;
        protected System.Windows.Forms.Label lblCedula;
        protected System.Windows.Forms.Button btnDentista;
        protected System.Windows.Forms.Label lblDentista;
        protected System.Windows.Forms.Label lblMostrarNombreDentista;
        protected System.Windows.Forms.Label lblDireccion;
        protected System.Windows.Forms.Label lblMostrarDireccion;
        protected System.Windows.Forms.Label lblRFC;
        protected System.Windows.Forms.Label lblMostrarRFC;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.NumericUpDown nudTrabajos;
        protected System.Windows.Forms.Panel Panel;
    }
}
