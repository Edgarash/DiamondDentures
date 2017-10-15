using Entidad;
using Control;
using System;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Usuario
{
    class PantallaTarjeta : Pantalla
    {
        protected string User;
        protected InterfaceUsuario Interface;
        protected Validar Validaciones;
        protected System.Windows.Forms.PictureBox pictureBox5;
        protected System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        protected System.Windows.Forms.ComboBox tbBanco;
        private System.Windows.Forms.Label label13;
        protected System.Windows.Forms.MaskedTextBox tbTarjeta;
        protected System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnAceptar;
        protected System.Windows.Forms.Button btnCerrar;
        protected System.Windows.Forms.Label label15;
        protected ErrorProvider[] Masked;
        protected ErrorProvider Combo;
        protected DateTimePicker tbFechaTarjeta;
        protected ErrorProvider[] Textb;

        public PantallaTarjeta()
            : base()
        {
            InitializeComponent();
            string [] Bancos = Presentacion.Properties.Resources.Bancos.Split((new string[]{"\n", "\r"}), StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(Bancos);
            foreach (string x in Bancos)
            {
                tbBanco.Items.Add(x);
            }
            Masked = new ErrorProvider[2];
            for (int i = 0; i < Masked.Length; i++)
                Masked[i] = new ErrorProvider(this);
            Combo = new ErrorProvider(this);
            Textb = new ErrorProvider[2];
            for (int i = 0; i < Textb.Length; i++)
                Textb[i] = new ErrorProvider(this);
            tbNombre.KeyPress += SeleccionarSiguiente;
            tbTarjeta.KeyPress += SeleccionarSiguiente;
            tbApellido.KeyPress += SeleccionarSiguiente;
            tbBanco.KeyPress += SeleccionarSiguiente;
            tbFechaTarjeta.KeyPress += SeleccionarSiguiente;
            Validaciones = new Validar(this);
        }

        public PantallaTarjeta(string Usuario) :this()
        {
            User = Usuario;
        }

        private void InitializeComponent()
        {
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbBanco = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbFechaTarjeta = new System.Windows.Forms.DateTimePicker();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.pictureBox5);
            this.Encabezado.Controls.Add(this.label15);
            this.Encabezado.Size = new System.Drawing.Size(517, 93);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Presentacion.Properties.Resources.IconoAñadirTarjeta;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(9, 16);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(83, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 24);
            this.label15.TabIndex = 7;
            this.label15.Text = "Pantalla Tarjeta";
            // 
            // tbApellido
            // 
            this.tbApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbApellido.Location = new System.Drawing.Point(274, 156);
            this.tbApellido.MaxLength = 50;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.ShortcutsEnabled = false;
            this.tbApellido.Size = new System.Drawing.Size(193, 21);
            this.tbApellido.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "* Apellido(s)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(492, 17);
            this.label12.TabIndex = 79;
            this.label12.Text = "Favor de ingresar la informacion en los campos correspondientes.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(422, 416);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 18);
            this.label14.TabIndex = 75;
            this.label14.Text = "Cancelar";
            // 
            // tbBanco
            // 
            this.tbBanco.FormattingEnabled = true;
            this.tbBanco.Location = new System.Drawing.Point(274, 223);
            this.tbBanco.MaxLength = 50;
            this.tbBanco.Name = "tbBanco";
            this.tbBanco.Size = new System.Drawing.Size(191, 24);
            this.tbBanco.TabIndex = 4;
            this.tbBanco.SelectedIndexChanged += new System.EventHandler(this.tbBanco_SelectedIndexChanged);
            this.tbBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBanco_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(325, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 18);
            this.label13.TabIndex = 76;
            this.label13.Text = "Aceptar";
            // 
            // tbTarjeta
            // 
            this.tbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTarjeta.Location = new System.Drawing.Point(50, 226);
            this.tbTarjeta.Mask = "0000 - 0000 - 0000 - 0000 - 0000";
            this.tbTarjeta.Name = "tbTarjeta";
            this.tbTarjeta.ShortcutsEnabled = false;
            this.tbTarjeta.Size = new System.Drawing.Size(193, 21);
            this.tbTarjeta.TabIndex = 3;
            this.tbTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTarjeta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Location = new System.Drawing.Point(52, 156);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ShortcutsEnabled = false;
            this.tbNombre.Size = new System.Drawing.Size(193, 21);
            this.tbNombre.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "* Fecha de vencimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "* Banco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "* Numero de la tarjeta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "* Nombre(s)";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Presentacion.Properties.Resources.IconoAceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(330, 353);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(62, 58);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(431, 353);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(62, 58);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // tbFechaTarjeta
            // 
            this.tbFechaTarjeta.CustomFormat = "MM/yy";
            this.tbFechaTarjeta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbFechaTarjeta.Location = new System.Drawing.Point(50, 304);
            this.tbFechaTarjeta.MinDate = new System.DateTime(2017, 3, 30, 0, 0, 0, 0);
            this.tbFechaTarjeta.Name = "tbFechaTarjeta";
            this.tbFechaTarjeta.Size = new System.Drawing.Size(87, 21);
            this.tbFechaTarjeta.TabIndex = 5;
            // 
            // PantallaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(517, 451);
            this.Controls.Add(this.tbFechaTarjeta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbBanco);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbTarjeta);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaTarjeta";
            this.Text = "Pantalla Tarjeta";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.tbTarjeta, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.tbBanco, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbApellido, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.tbFechaTarjeta, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void btnMouseLeft(object sender, EventArgs e)
        {
            base.btnMouseLeft(sender, e);
        }
        protected override void btnMouseOver(object sender, EventArgs e)
        {
            base.btnMouseOver(sender, e);
        }
        protected RegistroTarjeta ObtenerRegistro
        {
            get { return new RegistroTarjeta(User, tbTarjeta.Text, tbNombre.Text, tbApellido.Text, tbBanco.Text, tbFechaTarjeta.Text, 1.ToString()); }
        }

        private bool ValidarText
        {
            get
            {
                TextBox[] tb = { tbNombre, tbApellido };
                bool Error = false;
                for (int i = 0; i < tb.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(tb[i].Text))
                    {
                        Textb[i].SetError(tb[i], "Campo vacío obligatorio");
                        Error = true;
                    }
                    else
                    {
                        if (Textb[i] != null)
                        {
                            Textb[i].SetError(tb[i], "");
                            Textb[i].Clear();
                        }
                    }
                }
                return Error;
            }
        }

        private bool ValidarMasked
        {
            get
            {
                MaskedTextBox[] Mask = { tbTarjeta };
                bool Error = false;
                for (int i = 0; i < Mask.Length; i++)
                {
                    Mask[i].TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (string.IsNullOrWhiteSpace(Mask[i].Text))
                    {
                        Masked[i].SetError(Mask[i], "Campo vacío obligatorio");
                        Error = true;
                    }
                    else
                    {
                        if (!Mask[i].MaskCompleted)
                        {
                            Masked[i].SetError(Mask[i], "Campo incompleto");
                            Error = true;
                        }
                        else
                        {
                            Masked[i].SetError(Mask[i], "");
                            Masked[i].Clear();
                        }
                    }
                    Mask[i].TextMaskFormat = MaskFormat.IncludeLiterals;
                }
                return Error;
            }
        }

        private bool ValidarCombo
        { get
            {
                bool Error = false;
                if (string.IsNullOrWhiteSpace(tbBanco.Text))
                {
                    Combo.SetError(tbBanco, "Campo vacío obligatorio");
                    Error = true;
                }
                else
                {
                    Combo.SetError(tbBanco, "");
                    Combo.Clear();
                }
                return Error;
            } }

        protected void tbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbBanco.Text == "American Express".ToUpper())
            {
                tbTarjeta.Mask = "0000 - 000000 - 00000";
            }
            else
            {
                tbTarjeta.Mask = "0000 - 0000 - 0000 - 0000";
            }
        }

        private void tbBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
