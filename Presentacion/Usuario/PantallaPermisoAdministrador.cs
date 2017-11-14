using Control;
using ControlesPersonalizados;
using System;
using System.Windows.Forms;
using Entidad;
using Control.Ventas;

namespace Presentacion.Usuario
{
    class PantallaPermisoAdministrador : Pantalla
    {
        private Label lblInfo;
        private Label lblPermiso;
        bool Cancelado { get; set; }
        protected Password tbPassword;
        Manejador Manejador;
        bool Mensaje = false;
        public PantallaPermisoAdministrador()
        {
            InitializeComponent();
            tbPassword.Enfocar += new Password.InFocus(EnterContraseña);
            Cancelado = false;
        }

        private void EnterContraseña(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.Close();
                Mensaje = true;
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    Close();
                    Cancelado = true;
                }
            }
        }

        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPermiso = new System.Windows.Forms.Label();
            this.tbPassword = new ControlesPersonalizados.Password();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.lblPermiso);
            this.Encabezado.Size = new System.Drawing.Size(468, 93);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(17, 114);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(435, 17);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "Necesita permisos de administrador para poder continuar.";
            // 
            // lblPermiso
            // 
            this.lblPermiso.AutoSize = true;
            this.lblPermiso.BackColor = System.Drawing.Color.Transparent;
            this.lblPermiso.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermiso.Location = new System.Drawing.Point(125, 18);
            this.lblPermiso.Name = "lblPermiso";
            this.lblPermiso.Size = new System.Drawing.Size(218, 59);
            this.lblPermiso.TabIndex = 12;
            this.lblPermiso.Text = "Permiso";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(155, 152);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(154, 23);
            this.tbPassword.TabIndex = 11;
            // 
            // PantallaPermisoAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(468, 203);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblInfo);
            this.Name = "PantallaPermisoAdministrador";
            this.Text = "Confirmación De Administrador";
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.tbPassword, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public static RegistroUsuario Supervisor(out bool cancelado)
        {
            PantallaPermisoAdministrador temp = new PantallaPermisoAdministrador();
            RegistroUsuario Autorizo = null;
            bool Obtenido = false;
            temp.ShowDialog();
            temp.Manejador = new ManejadorPermisoAdministrador();
            if (temp.Mensaje)
            {
                Autorizo = ManejadorVentas.VerificoSupervisor(temp.tbPassword.Text);
                if (Autorizo != null)
                {
                    Obtenido = true;
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            cancelado = temp.Cancelado;
            return Autorizo;
        }

        public bool PermisoAdmin(out bool Cancelado)
        {
            bool Obtenido = false;
            ShowDialog();
            Manejador = new ManejadorPermisoAdministrador();
            if (Mensaje)
            {
                if (((ManejadorPermisoAdministrador)Manejador).PermisoObtenido(tbPassword.Text))
                {
                    Obtenido = true;
                }
                else
                {
                    MessageBox.Show("No tiene los suficientes permisos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            Cancelado = this.Cancelado;
            return Obtenido;
        }

        public static bool PedirPermisoAdministrador(out bool Cancelado)
        {
            PantallaPermisoAdministrador x = new PantallaPermisoAdministrador();
            return x.PermisoAdmin(out Cancelado);
        }
    }
}
