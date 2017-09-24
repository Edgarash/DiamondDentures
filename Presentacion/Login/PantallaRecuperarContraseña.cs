using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Login
{
    class PantallaRecuperarContraseña : Pantalla
    {
        InterfaceUsuario Interface;
        bool Fuera = false;
        bool MostrarPregunta = false;
        static int Intentos = 0;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.TextBox tbNumEmpleado;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label lblRecuperar;
        private System.Windows.Forms.Button btnRecuperar;
        private Label lblPregunta;
        private TextBox tbRespuesta;
        private System.Windows.Forms.Label lblTitulo;
        DialogResult Opcion = DialogResult.Cancel;
        public PantallaRecuperarContraseña()
            : base()
        {
            InitializeComponent();
            tbNumEmpleado.KeyPress += new KeyPressEventHandler(delegate (object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 13)
                {
                    if (!Fuera)
                    {
                        btnRecuperar_Click(sender, e);
                    }
                    else
                    {
                        this.Close();
                    }
                    Opcion = DialogResult.Yes;
                }
                else
                {
                    if(!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                    {
                        e.Handled = true;
                    }
                }
            });
        }

        private void InitializeComponent()
        {
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbNumEmpleado = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblRecuperar = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.tbRespuesta = new System.Windows.Forms.TextBox();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.pbImg);
            this.Encabezado.Controls.Add(this.lblTitulo);
            this.Encabezado.Size = new System.Drawing.Size(497, 93);
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.Transparent;
            this.pbImg.BackgroundImage = global::Presentacion.Properties.Resources.IconoRecuperarContraseña;
            this.pbImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImg.Location = new System.Drawing.Point(9, 16);
            this.pbImg.Margin = new System.Windows.Forms.Padding(0);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(60, 60);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 8;
            this.pbImg.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(77, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(251, 24);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Recuperar Constraseña";
            // 
            // tbNumEmpleado
            // 
            this.tbNumEmpleado.Location = new System.Drawing.Point(72, 183);
            this.tbNumEmpleado.Name = "tbNumEmpleado";
            this.tbNumEmpleado.ShortcutsEnabled = false;
            this.tbNumEmpleado.Size = new System.Drawing.Size(352, 21);
            this.tbNumEmpleado.TabIndex = 11;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 114);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(473, 17);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "Para recuperar su contraseña ingrese su numero de trabajador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero de trabajador:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(391, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 58);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblCancelar.Location = new System.Drawing.Point(381, 293);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(81, 18);
            this.lblCancelar.TabIndex = 13;
            this.lblCancelar.Text = "Cancelar";
            // 
            // lblRecuperar
            // 
            this.lblRecuperar.AutoSize = true;
            this.lblRecuperar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblRecuperar.Location = new System.Drawing.Point(272, 293);
            this.lblRecuperar.Name = "lblRecuperar";
            this.lblRecuperar.Size = new System.Drawing.Size(94, 18);
            this.lblRecuperar.TabIndex = 15;
            this.lblRecuperar.Text = "Recuperar";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.BackgroundImage = global::Presentacion.Properties.Resources.IconoDesbloquearContraseña;
            this.btnRecuperar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecuperar.FlatAppearance.BorderSize = 0;
            this.btnRecuperar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRecuperar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperar.Location = new System.Drawing.Point(288, 229);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(62, 58);
            this.btnRecuperar.TabIndex = 14;
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            this.btnRecuperar.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnRecuperar.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(12, 218);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(75, 17);
            this.lblPregunta.TabIndex = 10;
            this.lblPregunta.Text = "Pregunta";
            this.lblPregunta.Visible = false;
            // 
            // tbRespuesta
            // 
            this.tbRespuesta.Location = new System.Drawing.Point(15, 247);
            this.tbRespuesta.Name = "tbRespuesta";
            this.tbRespuesta.ShortcutsEnabled = false;
            this.tbRespuesta.Size = new System.Drawing.Size(453, 21);
            this.tbRespuesta.TabIndex = 11;
            this.tbRespuesta.Visible = false;
            this.tbRespuesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRespuesta_KeyPress);
            // 
            // PantallaRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(497, 319);
            this.Controls.Add(this.lblRecuperar);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbRespuesta);
            this.Controls.Add(this.tbNumEmpleado);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.Name = "PantallaRecuperarContraseña";
            this.Text = "Recuperar Contraseña";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.lblPregunta, 0);
            this.Controls.SetChildIndex(this.tbNumEmpleado, 0);
            this.Controls.SetChildIndex(this.tbRespuesta, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblCancelar, 0);
            this.Controls.SetChildIndex(this.btnRecuperar, 0);
            this.Controls.SetChildIndex(this.lblRecuperar, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
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

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (!Fuera)
            {
                Interface = new InterfaceUsuario(this);
                if (!MostrarPregunta)
                {
                    if (tbNumEmpleado.Text != "")
                    {
                        int Empleado = Convert.ToInt32(tbNumEmpleado.Text);
                        if (Interface.ValidarEmpleadoRegistrado(Empleado))
                        {
                            tbNumEmpleado.Enabled = false;
                            lblPregunta.Visible = true;
                            tbRespuesta.Visible = true;
                            btnCancelar.Location = new System.Drawing.Point(btnCancelar.Location.X, btnCancelar.Location.Y + 60);
                            btnRecuperar.Location = new System.Drawing.Point(btnRecuperar.Location.X, btnRecuperar.Location.Y + 60);
                            lblRecuperar.Location = new System.Drawing.Point(lblRecuperar.Location.X, lblRecuperar.Location.Y + 60);
                            lblCancelar.Location = new System.Drawing.Point(lblCancelar.Location.X, lblCancelar.Location.Y + 60);
                            Size = new System.Drawing.Size(Size.Width, Size.Height + 60);
                            bool temp = Interface.ValidarEmpleadoRegistrado(Empleado);
                            string pregunta = Interface.RecuperarPregunta(Empleado);
                            if (pregunta != string.Empty)
                            {
                                lblPregunta.Text = pregunta;
                            }
                            MostrarPregunta = true;
                            ActiveControl = tbRespuesta;
                        }
                        else
                        {
                            MessageBox.Show("Número de empleado inexistente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            Intentos++;
                        }
                    }
                }
                else
                {
                    string contra = "";
                    int Empleado = Convert.ToInt32(tbNumEmpleado.Text);
                    bool correcto = Interface.ValidarRespuesta(Empleado, tbRespuesta.Text);
                    if (correcto)
                    {
                        contra = Interface.RecuperarContraseña(Empleado);
                        MessageBox.Show("Su contraseña es: " + contra, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        Intentos = 0;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Respuesta incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Intentos++;
                    }
                }
                if (Intentos == 5)
                {
                    MessageBox.Show("Abuso de intentos, se cerrará el sistema", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Application.Exit();
                }
            }
            Opcion = DialogResult.Yes;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Opcion = DialogResult.Cancel;
        }

        public int ObtenerNumero()
        {
            Text = lblTitulo.Text = "Agregar Número De Empelado";
            pbImg.BackgroundImage = Presentacion.Properties.Resources.IconoAgregarUsuario;
            lblInfo.Text = "Ingrese el número de trabajador a registrar";
            lblRecuperar.Text = "Aceptar";
            btnRecuperar.BackgroundImage = Presentacion.Properties.Resources.IconoAceptar;
            Fuera = true;
            btnRecuperar.Click -= btnRecuperar_Click;
            btnRecuperar.Click += btnCancelar_Click;
            ShowDialog();
            int temp = -1;
            if (tbNumEmpleado.Text != string.Empty)
            {
                temp = Convert.ToInt32(tbNumEmpleado.Text);
            }
            return temp;
        }

        public int VerficarNumero(out DialogResult Resul)
        {
            Text = lblTitulo.Text = "Verificar Número De Empelado";
            pbImg.BackgroundImage = Presentacion.Properties.Resources.IconoAgregarUsuario;
            lblInfo.Text = "Ingrese el número de trabajador a verificar";
            lblRecuperar.Text = "Aceptar";
            btnRecuperar.BackgroundImage = Presentacion.Properties.Resources.IconoAceptar;
            Fuera = true;
            ShowDialog();
            int temp = -1;
            if (tbNumEmpleado.Text != string.Empty)
            {
                temp = Convert.ToInt32(tbNumEmpleado.Text);
            }
            Resul = Opcion;
            return temp;
        }

        private void tbRespuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tbRespuesta.Text != "")
                {
                    btnRecuperar_Click(sender, e);
                }
            }
        }
    }
}
