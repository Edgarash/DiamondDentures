using Control;
using Entidad;
using Presentacion.Login;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Usuario
{
    public class PantallaMenuUsuario : Pantalla
    {
        private InterfaceUsuario Interface;
        private Label lblTarjeta;
        private Label lblSesión;
        private Label lblInfo;
        private Label lblEliminarTarjeta;
        private Label lblModificarTarjeta;
        private Label lblAgregarTarjeta;
        private Label lblEliminarUsuario;
        private Button btnModificarUsuario;
        private Button btnEliminarUsuario;
        private Button btnEliminarTarjeta;
        private Label label7;
        private Button btnAgregarTarjeta;
        private Button btnModificarTarjeta;
        private Label lblModificarUsuario;
        private Button btnRegistrarEmpleado;
        private Label lblAgregarEmpleado;
        private Label lblAdmi;
        private Label lblUsuario;
        protected Label lblPantallaUsuario;
        protected PictureBox pbIcono;
        private string Usuario;

        public PantallaMenuUsuario() : base()
        {
            InitializeComponent();
            InitializeComponent2();
            this.Usuario = PantallaMenuPrincipal.Sesion.Login;
            if (!string.IsNullOrWhiteSpace(Usuario))
            {
                ActualizarPantalla();
                this.GotFocus += new EventHandler(delegate (object sender, EventArgs e)
               { ActualizarPantalla(); });
            }
        }

        private void InitializeComponent()
        {
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.lblSesión = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblEliminarTarjeta = new System.Windows.Forms.Label();
            this.lblModificarTarjeta = new System.Windows.Forms.Label();
            this.lblAgregarTarjeta = new System.Windows.Forms.Label();
            this.lblEliminarUsuario = new System.Windows.Forms.Label();
            this.lblModificarUsuario = new System.Windows.Forms.Label();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarTarjeta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarTarjeta = new System.Windows.Forms.Button();
            this.btnModificarTarjeta = new System.Windows.Forms.Button();
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.lblAgregarEmpleado = new System.Windows.Forms.Label();
            this.lblAdmi = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPantallaUsuario = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.lblPantallaUsuario);
            this.Encabezado.Controls.Add(this.pbIcono);
            this.Encabezado.Size = new System.Drawing.Size(857, 93);
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeta.Location = new System.Drawing.Point(649, 147);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(65, 18);
            this.lblTarjeta.TabIndex = 28;
            this.lblTarjeta.Text = "Tarjeta";
            // 
            // lblSesión
            // 
            this.lblSesión.AutoSize = true;
            this.lblSesión.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesión.Location = new System.Drawing.Point(11, 404);
            this.lblSesión.Name = "lblSesión";
            this.lblSesión.Size = new System.Drawing.Size(70, 18);
            this.lblSesión.TabIndex = 29;
            this.lblSesión.Text = "Usuario";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(50, 104);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(256, 24);
            this.lblInfo.TabIndex = 30;
            this.lblInfo.Text = "Seleccionar una opcion:";
            // 
            // lblEliminarTarjeta
            // 
            this.lblEliminarTarjeta.AutoSize = true;
            this.lblEliminarTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEliminarTarjeta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarTarjeta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEliminarTarjeta.Location = new System.Drawing.Point(575, 310);
            this.lblEliminarTarjeta.Name = "lblEliminarTarjeta";
            this.lblEliminarTarjeta.Size = new System.Drawing.Size(68, 34);
            this.lblEliminarTarjeta.TabIndex = 18;
            this.lblEliminarTarjeta.Text = "Eliminar\nTarjeta";
            this.lblEliminarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModificarTarjeta
            // 
            this.lblModificarTarjeta.AutoSize = true;
            this.lblModificarTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModificarTarjeta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarTarjeta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblModificarTarjeta.Location = new System.Drawing.Point(731, 310);
            this.lblModificarTarjeta.Name = "lblModificarTarjeta";
            this.lblModificarTarjeta.Size = new System.Drawing.Size(76, 34);
            this.lblModificarTarjeta.TabIndex = 19;
            this.lblModificarTarjeta.Text = "Modificar\nTarjeta";
            this.lblModificarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgregarTarjeta
            // 
            this.lblAgregarTarjeta.AutoSize = true;
            this.lblAgregarTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarTarjeta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarTarjeta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAgregarTarjeta.Location = new System.Drawing.Point(652, 310);
            this.lblAgregarTarjeta.Name = "lblAgregarTarjeta";
            this.lblAgregarTarjeta.Size = new System.Drawing.Size(69, 34);
            this.lblAgregarTarjeta.TabIndex = 20;
            this.lblAgregarTarjeta.Text = "Agregar\nTarjeta";
            this.lblAgregarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEliminarUsuario
            // 
            this.lblEliminarUsuario.AutoSize = true;
            this.lblEliminarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEliminarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEliminarUsuario.Location = new System.Drawing.Point(336, 310);
            this.lblEliminarUsuario.Name = "lblEliminarUsuario";
            this.lblEliminarUsuario.Size = new System.Drawing.Size(94, 34);
            this.lblEliminarUsuario.TabIndex = 21;
            this.lblEliminarUsuario.Text = "Administrar\nUsuarios";
            this.lblEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModificarUsuario
            // 
            this.lblModificarUsuario.AutoSize = true;
            this.lblModificarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModificarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblModificarUsuario.Location = new System.Drawing.Point(205, 310);
            this.lblModificarUsuario.Name = "lblModificarUsuario";
            this.lblModificarUsuario.Size = new System.Drawing.Size(76, 34);
            this.lblModificarUsuario.TabIndex = 22;
            this.lblModificarUsuario.Text = "Modificar\nUsuario";
            this.lblModificarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackgroundImage = global::Presentacion.Properties.Resources.IconoEditarUsuario;
            this.btnModificarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Location = new System.Drawing.Point(192, 195);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(96, 100);
            this.btnModificarUsuario.TabIndex = 31;
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackgroundImage = global::Presentacion.Properties.Resources.IconoAdministrarUsuarios;
            this.btnEliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(331, 195);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(96, 100);
            this.btnEliminarUsuario.TabIndex = 32;
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnEliminarTarjeta
            // 
            this.btnEliminarTarjeta.BackgroundImage = global::Presentacion.Properties.Resources.IconoEliminaTarjeta;
            this.btnEliminarTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnEliminarTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTarjeta.Location = new System.Drawing.Point(560, 195);
            this.btnEliminarTarjeta.Name = "btnEliminarTarjeta";
            this.btnEliminarTarjeta.Size = new System.Drawing.Size(107, 100);
            this.btnEliminarTarjeta.TabIndex = 34;
            this.btnEliminarTarjeta.UseVisualStyleBackColor = true;
            this.btnEliminarTarjeta.Click += new System.EventHandler(this.btnEliminarTarjeta_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // btnAgregarTarjeta
            // 
            this.btnAgregarTarjeta.BackgroundImage = global::Presentacion.Properties.Resources.IconoAñadirTarjeta;
            this.btnAgregarTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnAgregarTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTarjeta.Location = new System.Drawing.Point(634, 195);
            this.btnAgregarTarjeta.Name = "btnAgregarTarjeta";
            this.btnAgregarTarjeta.Size = new System.Drawing.Size(105, 100);
            this.btnAgregarTarjeta.TabIndex = 37;
            this.btnAgregarTarjeta.UseVisualStyleBackColor = true;
            this.btnAgregarTarjeta.Click += new System.EventHandler(this.btnAgregarTarjeta_Click);
            // 
            // btnModificarTarjeta
            // 
            this.btnModificarTarjeta.BackgroundImage = global::Presentacion.Properties.Resources.IconoEditarTarjeta;
            this.btnModificarTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnModificarTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTarjeta.Location = new System.Drawing.Point(716, 195);
            this.btnModificarTarjeta.Name = "btnModificarTarjeta";
            this.btnModificarTarjeta.Size = new System.Drawing.Size(105, 100);
            this.btnModificarTarjeta.TabIndex = 38;
            this.btnModificarTarjeta.UseVisualStyleBackColor = true;
            this.btnModificarTarjeta.Click += new System.EventHandler(this.btnModificarTarjeta_Click);
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.BackgroundImage = global::Presentacion.Properties.Resources.IconoAgregarUsuario;
            this.btnRegistrarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(54, 195);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(96, 100);
            this.btnRegistrarEmpleado.TabIndex = 39;
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = true;
            this.btnRegistrarEmpleado.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEmpleado.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(59, 302);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(88, 51);
            this.lblAgregarEmpleado.TabIndex = 22;
            this.lblAgregarEmpleado.Text = "Registrar\nNúmero de\nEmpleado";
            this.lblAgregarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdmi
            // 
            this.lblAdmi.AutoSize = true;
            this.lblAdmi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmi.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAdmi.Location = new System.Drawing.Point(683, 404);
            this.lblAdmi.Name = "lblAdmi";
            this.lblAdmi.Size = new System.Drawing.Size(168, 18);
            this.lblAdmi.TabIndex = 29;
            this.lblAdmi.Text = "Modo Administrador";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(207, 147);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(70, 18);
            this.lblUsuario.TabIndex = 29;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.AutoSize = true;
            this.lblPantallaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblPantallaUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantallaUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPantallaUsuario.Location = new System.Drawing.Point(98, 34);
            this.lblPantallaUsuario.Name = "lblPantallaUsuario";
            this.lblPantallaUsuario.Size = new System.Drawing.Size(90, 24);
            this.lblPantallaUsuario.TabIndex = 13;
            this.lblPantallaUsuario.Text = "Usuario";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoUsuario;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcono.Location = new System.Drawing.Point(22, 16);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(60, 60);
            this.pbIcono.TabIndex = 12;
            this.pbIcono.TabStop = false;
            // 
            // PantallaMenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(857, 431);
            this.Controls.Add(this.btnModificarTarjeta);
            this.Controls.Add(this.btnEliminarTarjeta);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.lblTarjeta);
            this.Controls.Add(this.lblAdmi);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSesión);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblEliminarTarjeta);
            this.Controls.Add(this.lblModificarTarjeta);
            this.Controls.Add(this.lblEliminarUsuario);
            this.Controls.Add(this.lblModificarUsuario);
            this.Controls.Add(this.lblAgregarTarjeta);
            this.Controls.Add(this.btnAgregarTarjeta);
            this.Controls.Add(this.btnRegistrarEmpleado);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.Name = "PantallaMenuUsuario";
            this.Text = "Pantalla Principal";
            this.Controls.SetChildIndex(this.lblAgregarEmpleado, 0);
            this.Controls.SetChildIndex(this.btnRegistrarEmpleado, 0);
            this.Controls.SetChildIndex(this.btnAgregarTarjeta, 0);
            this.Controls.SetChildIndex(this.lblAgregarTarjeta, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.lblModificarUsuario, 0);
            this.Controls.SetChildIndex(this.lblEliminarUsuario, 0);
            this.Controls.SetChildIndex(this.lblModificarTarjeta, 0);
            this.Controls.SetChildIndex(this.lblEliminarTarjeta, 0);
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.lblSesión, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.lblAdmi, 0);
            this.Controls.SetChildIndex(this.lblTarjeta, 0);
            this.Controls.SetChildIndex(this.btnModificarUsuario, 0);
            this.Controls.SetChildIndex(this.btnEliminarUsuario, 0);
            this.Controls.SetChildIndex(this.btnEliminarTarjeta, 0);
            this.Controls.SetChildIndex(this.btnModificarTarjeta, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            PantallaAdministrarUsuarios temp = new PantallaAdministrarUsuarios(Usuario);
            temp.ShowDialog();
            ActualizarPantalla();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            Interface.DesplegarPantallaModificarUsuario(Usuario);
            ActualizarPantalla();
        }

        private void btnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            if (!Interface.ValidarDatosTarjeta(Usuario))
            {
                Interface.DesplegarPantallaRegistrarTarjeta(Usuario);
                ActualizarPantalla();
            }
            else
            {
                DialogResult temp = MessageBox.Show("Usted ya tiene una tarjeta registrada\n\n¿Desea modificarla?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (temp == DialogResult.Yes)
                {
                    Interface.DesplegarPantallaModificarTarjeta(Usuario);
                }
            }
        }

        private void btnModificarTarjeta_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            Interface.DesplegarPantallaModificarTarjeta(Usuario);
        }

        private void btnEliminarTarjeta_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            if (Interface.ValidarDatosTarjeta(Usuario))
            {
                DialogResult temp = MessageBox.Show("¿Está seguro que desea eliminar la tarjeta asociada al usuario: \"" + Usuario + "\"?", "ELIMINAR TARJETA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                if (temp == DialogResult.Yes)
                {
                    if (Interface.EliminarTarjeta(Usuario))
                    {
                        MessageBox.Show("Tarjeta eliminada con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un problema al conectar con la base de datos, por favor inténtelo más tarde", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    ActualizarPantalla();
                }
            }
            else
            {
                MessageBox.Show("Usted no tiene ninguna tarjeta registrada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void ActualizarPantalla()
        {
            Interface = new InterfaceUsuario(this);
            lblSesión.Text = "Usuario: " + Usuario;
            RegistroUsuario temp;
            Interface.RecuperarUsuario(Usuario, out temp);
            PantallaLogin.Sesión = temp;
            bool Tarjeta = Interface.ValidarDatosTarjeta(Usuario);
            if (Tarjeta)
            {
                btnAgregarTarjeta.Visible = lblAgregarTarjeta.Visible = false;
                btnEliminarTarjeta.Visible = btnModificarTarjeta.Visible = lblEliminarTarjeta.Visible = lblModificarTarjeta.Visible = true;
            }
            else
            {
                btnAgregarTarjeta.Visible = lblAgregarTarjeta.Visible = true;
                btnEliminarTarjeta.Visible = btnModificarTarjeta.Visible = lblEliminarTarjeta.Visible = lblModificarTarjeta.Visible = false;
            }
            if(Interface.EsAdministrador(Usuario))
            {
                lblAdmi.Visible = btnRegistrarEmpleado.Visible = lblAgregarEmpleado.Visible = btnEliminarUsuario.Visible = lblEliminarUsuario.Visible = true;
                lblUsuario.Location = new Point(207, 147);
                btnModificarUsuario.Location = new Point(192, 195);
                lblModificarUsuario.Location = new Point(205, 310);
                lblTarjeta.Location = new Point(649, 147);
                btnAgregarTarjeta.Location = new Point(634, 195);
                lblAgregarTarjeta.Location = new Point(652, 310);
                btnModificarTarjeta.Location = new Point(560, 195);
                lblModificarTarjeta.Location = new Point(575, 310);
                btnEliminarTarjeta.Location = new Point(716, 195);
                lblEliminarTarjeta.Location = new Point(731, 310);

                Size = new Size(873, 470);
            }
            else
            {
                lblAdmi.Visible = btnRegistrarEmpleado.Visible = lblAgregarEmpleado.Visible = btnEliminarUsuario.Visible = lblEliminarUsuario.Visible = false;

                lblUsuario.Location = new Point(65, 147);
                btnModificarUsuario.Location = new Point(54, 195);
                lblModificarUsuario.Location = new Point(62, 310);
                lblTarjeta.Location = !Tarjeta ? new Point(414, 147) : new Point(350, 147);
                btnAgregarTarjeta.Location = !Tarjeta ? new Point(395, 195) : new Point(331, 195);
                lblAgregarTarjeta.Location = !Tarjeta ? new Point(410, 310) : new Point(346, 310);
                btnModificarTarjeta.Location = new Point(270, 195);
                lblModificarTarjeta.Location = new Point(285, 310);
                btnEliminarTarjeta.Location = new Point(395, 195);
                lblEliminarTarjeta.Location = new Point(410, 310);

                Size = new Size(573, 470);
            }
            this.CenterToScreen();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Interface.RegistrarNumeroEmpleado();
        }
    }
}