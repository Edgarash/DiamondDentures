using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Usuario
{
    class PantallaModificarUsuario : PantallaUsuario
    {
        RegistroUsuario User;
        string UsuarioAnterior;
        public PantallaModificarUsuario() : base()
        {
            InitializeComponent();
        }
        public PantallaModificarUsuario(RegistroUsuario Usuario) : this()
        {
            User = Usuario;
            tbNombre.Text = Usuario.Nombre;
            tbNombre.Enabled = false;
            tbApellidos.Text = Usuario.Apellidos;
            tbApellidos.Enabled = false;
            tbNEmpleado.Text = Usuario.NumeroTrabajador.ToString();
            tbNEmpleado.Enabled = false;
            tbUsuario.Text = Usuario.Login;
            tbUsuario.Enabled = false;
            cbTipoUsuario.Text = Usuario.TipoUsuario;
            cbPaíses.Text = Usuario.Pais;
            cbEstado.Text = Usuario.Estado;
            cbMunicipio.Text = Usuario.Municipio;
            cbCiudad.Text = Usuario.Ciudad;
            tbColonia.Text = Usuario.Colonia;
            tbCalle.Text = Usuario.Calle;
            tbNFrente.Text = Usuario.NumCasa;
            tbCP.Text = Usuario.CodigoPostal.ToString();
            tbEmail.Text = Usuario.Email.Split('@')[0];
            cbEmail.Text = Usuario.Email.Contains("@") ? Usuario.Email.Split('@')[1].ToUpper() : "";
            tbTel.Text = Usuario.TelefonoCasa;
            tbCel.Text = Usuario.TelefonoMovil;
            tbTrabajo.Text = Usuario.TelefonoOficina;
            cbPregunta.Text = Usuario.Pregunta;
            tbRespuesta.Text = Usuario.Respuesta;
            UsuarioAnterior = Usuario.Login;
        }

        public PantallaModificarUsuario(RegistroUsuario Usuario, bool Administrador):this (Usuario)
        {
            tbUsuario.Enabled = tbNombre.Enabled = tbApellidos.Enabled = true;
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.Size = new System.Drawing.Size(187, 24);
            this.lblPantallaUsuario.Text = "Modificar usuario";
            // 
            // cbPaíses
            // 
            this.cbPaíses.Size = new System.Drawing.Size(117, 24);
            // 
            // cbEstado
            // 
            this.cbEstado.Size = new System.Drawing.Size(151, 24);
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.Size = new System.Drawing.Size(151, 24);
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.Size = new System.Drawing.Size(153, 24);
            // 
            // cbEmail
            // 
            this.cbEmail.Size = new System.Drawing.Size(131, 24);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbCiudad
            // 
            this.cbCiudad.Size = new System.Drawing.Size(149, 24);
            // 
            // pbIcono
            // 
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoEditarUsuario;
            // 
            // PantallaModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(599, 661);
            this.Name = "PantallaModificarUsuario";
            this.Text = "Modificar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool Vacio = ValidarCampos;
            if (Vacio)
            {
                MessageBox.Show("Favor de llenar la información correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Interface = new InterfaceUsuario(this);
                bool Permiso = true;
                DialogResult temporal = MessageBox.Show("Esta operación sobreescribirá algunos de sus datos\n\n¿Desea continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (User.TipoUsuario != "Administrador" && cbTipoUsuario.Text == "Administrador")
                {
                    int Conteo = 0;
                    bool PrimerAdmin = !Interface.HayAdministradores(out Conteo);
                    if (temporal == DialogResult.Yes && !PrimerAdmin)
                    {
                        Permiso = Interface.PermisoDeAdministrador();
                    }
                    if (PrimerAdmin)
                    {
                        Permiso = true;
                    }
                }
                if (Permiso)
                {
                    if (temporal == DialogResult.Yes)
                    {
                        if (Interface.ActualizarUsuario(UsuarioAnterior, ObtenerRegistro))
                        {
                            MessageBox.Show("El registro fue actualizado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            LlamarEventoCerrar();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Se presentó algún error, por favor vuelva a interntarlo más tarde", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
            }
        }

        protected override bool ValidarCampos
        {
            get
            {
                bool temp = Validaciones.ValidarTextBox(tbNombre, tbApellidos, tbUsuario, tbCalle, tbColonia, tbEmail, tbNEmpleado, tbRespuesta);
                temp = Validaciones.ValidarComboBox(cbEmail, cbTipoUsuario, cbPregunta) || temp;
                temp = Validaciones.ValidarMaskedTextBox(tbTel, tbCel) || temp;
                temp = Validaciones.ValidarPassword(false, tbPassword) || temp;
                return temp;
            }
        }

        protected override RegistroUsuario ObtenerRegistro
        {
            get
            {
                string Kagi = tbPassword.Text == "" ? User.Password : tbPassword.Text;
                return new RegistroUsuario(Convert.ToInt32(tbNEmpleado.Text), tbNombre.Text, tbApellidos.Text, tbUsuario.Text, Kagi,
                    cbTipoUsuario.Text, cbPaíses.Text, cbEstado.Text, cbMunicipio.Text, cbCiudad.Text, tbColonia.Text, tbCalle.Text, tbNFrente.Text,
                    tbCP.Text, tbTel.Text, tbCel.Text, tbTrabajo.Text, tbEmail.Text + "@" + cbEmail.Text, cbPregunta.Text, tbRespuesta.Text, 1);
            }
        }

        protected override void btnCerrar_Click(object sender, EventArgs e)
        {
            base.btnCerrar_Click(sender, e);
        }
    }
}
