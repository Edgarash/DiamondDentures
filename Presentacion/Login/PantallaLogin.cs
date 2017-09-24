using System;
using System.ComponentModel;
using System.Windows.Forms;
using ControlesPersonalizados;
using Control;
using Validaciones;
using Entidad;

namespace Presentacion.Login
{
    public class PantallaLogin : Pantalla
    {
        Validar Validacion;
        private PictureBox pbDiente;
        private LinkLabel lblOlvidar;
        private Label lblContraseña;
        private TextBox tbUsuario;
        private Label lblUsuario;
        private Password tbPassword;
        private Button btnEntrar;
        private ToolTip Mensaje;
        private IContainer components;
        private Button btnRegistrar;
        private Button btnSalir;
        private Label lblTitulo;
        private InterfaceUsuario Interface;
        private ErrorProvider[] Error = new ErrorProvider[2];
        static int IntentosFallidos;
        bool RegistrarNombre = false;
        public static RegistroUsuario Sesión { get; set; }

        public PantallaLogin() : base()
        {
            InitializeComponent();
            Validacion = new Validar(this);
            IntentosFallidos = 0;
        }
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbDiente = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOlvidar = new System.Windows.Forms.LinkLabel();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbPassword = new ControlesPersonalizados.Password();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.Mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiente)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.pbDiente);
            this.Encabezado.Controls.Add(this.lblTitulo);
            this.Encabezado.Size = new System.Drawing.Size(481, 93);
            // 
            // pbDiente
            // 
            this.pbDiente.BackColor = System.Drawing.Color.Transparent;
            this.pbDiente.BackgroundImage = global::Presentacion.Properties.Resources.IconoMenúPrinicpal;
            this.pbDiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDiente.Location = new System.Drawing.Point(430, 8);
            this.pbDiente.Name = "pbDiente";
            this.pbDiente.Size = new System.Drawing.Size(41, 37);
            this.pbDiente.TabIndex = 7;
            this.pbDiente.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Edwardian Script ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(420, 76);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Diamond Dentures";
            // 
            // lblOlvidar
            // 
            this.lblOlvidar.AutoSize = true;
            this.lblOlvidar.BackColor = System.Drawing.Color.Transparent;
            this.lblOlvidar.DisabledLinkColor = System.Drawing.Color.Black;
            this.lblOlvidar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblOlvidar.LinkColor = System.Drawing.Color.Black;
            this.lblOlvidar.Location = new System.Drawing.Point(174, 241);
            this.lblOlvidar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblOlvidar.Name = "lblOlvidar";
            this.lblOlvidar.Size = new System.Drawing.Size(133, 16);
            this.lblOlvidar.TabIndex = 4;
            this.lblOlvidar.TabStop = true;
            this.lblOlvidar.Text = "Olvidé mi contraseña";
            this.lblOlvidar.VisitedLinkColor = System.Drawing.Color.Black;
            this.lblOlvidar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOlvidar_LinkClicked);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(189, 183);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(98, 19);
            this.lblContraseña.TabIndex = 9;
            this.lblContraseña.Text = "Contraseña";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(161, 133);
            this.tbUsuario.MaxLength = 30;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.ShortcutsEnabled = false;
            this.tbUsuario.Size = new System.Drawing.Size(154, 21);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuarioPassword_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(206, 111);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 19);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(161, 207);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(156, 23);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Enfocar += new ControlesPersonalizados.Password.InFocus(this.tbPassword_KeyPress);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackgroundImage = global::Presentacion.Properties.Resources.IconoEntrar;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Location = new System.Drawing.Point(201, 272);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(78, 71);
            this.btnEntrar.TabIndex = 3;
            this.Mensaje.SetToolTip(this.btnEntrar, "Entrar");
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnEntrar.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnEntrar.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // Mensaje
            // 
            this.Mensaje.AutoPopDelay = 5000;
            this.Mensaje.InitialDelay = 100;
            this.Mensaje.ReshowDelay = 100;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = global::Presentacion.Properties.Resources.IconoAgregarUsuario;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(12, 384);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(62, 58);
            this.btnRegistrar.TabIndex = 5;
            this.Mensaje.SetToolTip(this.btnRegistrar, "Registrar Usuario");
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnRegistrar.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Presentacion.Properties.Resources.IconoSalir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(407, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 58);
            this.btnSalir.TabIndex = 6;
            this.Mensaje.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // PantallaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 454);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblOlvidar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "PantallaLogin";
            this.Text = "Pantalla Login";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.tbUsuario, 0);
            this.Controls.SetChildIndex(this.lblContraseña, 0);
            this.Controls.SetChildIndex(this.lblOlvidar, 0);
            this.Controls.SetChildIndex(this.tbPassword, 0);
            this.Controls.SetChildIndex(this.btnEntrar, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiente)).EndInit();
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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Validacion.ChecarUsuario(tbUsuario, tbPassword);
            if (tbUsuario.Text != "")
            {
                Interface = new InterfaceUsuario(this);
                if (DialogResult.Yes == Interface.DesplegarPantallaMenuPrincipal(tbUsuario.Text, tbPassword.Text, ref IntentosFallidos))
                {
                    RegistrarNombre = true;
                    RegistrarUsuario(tbUsuario.Text);
                    tbUsuario.Text = tbPassword.Text = "";
                }
            }
        }

        //private void btnEntrar_Click(object sender, EventArgs e)
        //{
        //    Validacion.ChecarUsuario(tbUsuario, tbPassword);
        //    if (tbUsuario.Text != "")
        //    {
        //        Interface = new InterfaceUsuario(this);
        //        if (DialogResult.Yes == Interface.DesplegarPantallaPrincipal(tbUsuario.Text, tbPassword.Text, ref IntentosFallidos))
        //        {
        //            RegistrarNombre = true;
        //            RegistrarUsuario(tbUsuario.Text);
        //            tbUsuario.Text = tbPassword.Text = "";
        //        }
        //    }
        //}

        private void tbUsuarioPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tbPassword.tbFocus();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnEntrar_Click(btnEntrar, new EventArgs());
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario("");
        }

        private void RegistrarUsuario(string Usuario)
        {
            Interface = new InterfaceUsuario(this);
            int temp = -1;
            int Conteo = 0;
            bool PrimerAdmin = !Interface.HayAdministradores(out Conteo);
            DialogResult Resultado;
            if (!PrimerAdmin)
            {
                if (Interface.ValidarEmpleado(out temp, out Resultado))
                {
                    if (!Interface.ValidarEmpleadoRegistrado(temp))
                    {
                        Interface = new InterfaceUsuario(this);
                        Interface.DesplegarPantallaRegistrarUsuario(RegistrarNombre ? tbUsuario.Text : "", temp);
                        IntentosFallidos = 0;
                    }
                    else
                    {
                        MessageBox.Show("El número de empleado " + temp.ToString() + " ya tiene un usuario registrado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    if (Resultado == DialogResult.Yes)
                    {
                        MessageBox.Show("Número de empleado no registrado, contáctese con el administrador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        IntentosFallidos++;
                    }
                }
            }
            else
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaRegistrarUsuario(RegistrarNombre ? tbUsuario.Text : "", 1);
                IntentosFallidos = 0;
            }
            tbUsuario.Text = tbPassword.Text = "";
            if ( IntentosFallidos == 5)
            {
                MessageBox.Show("Abuso de intentos, se cerrará el sistema", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblOlvidar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            Interface.DesplegarPantallaRecuperarContraseña();
        }
    }
}
