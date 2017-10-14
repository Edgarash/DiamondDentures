using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Control;

namespace Presentacion.Usuario
{
    class PantallaRegistroUsuario : PantallaUsuario
    {
        protected Button btnRegistrarShido;
        public PantallaRegistroUsuario()
            : base()
        {
            InitializeComponent();
            cbDepartamento.SelectedIndex = 0;
            cbPaíses.SelectedIndex = cbPaíses.Items.IndexOf("México");
            cbEmail.SelectedIndex = 0;
        }
        public PantallaRegistroUsuario(string Usuario, int NumeroEmpleado) : this()
        {
            tbUsuario.Text = Usuario;
            tbNEmpleado.Text = NumeroEmpleado.ToString();
            if (NumeroEmpleado != 1)
            {
                tbNEmpleado.Enabled = false;
            }
            else
            {
                cbDepartamento.Enabled = false;
            }
        }

        private void InitializeComponent()
        {
            this.btnRegistrarShido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.Size = new System.Drawing.Size(189, 24);
            this.lblPantallaUsuario.Text = "Registrar Usuario";
            // 
            // cbPaíses
            // 
            this.cbPaíses.Size = new System.Drawing.Size(149, 24);
            // 
            // cbEstado
            // 
            this.cbEstado.Size = new System.Drawing.Size(154, 24);
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.Size = new System.Drawing.Size(153, 24);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.Size = new System.Drawing.Size(153, 24);
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
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoAgregarUsuario;
            // 
            // cbPregunta
            // 
            this.cbPregunta.Size = new System.Drawing.Size(338, 24);
            // 
            // tbRespuesta
            // 
            this.tbRespuesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRespuesta_KeyPress);
            // 
            // cbPuesto
            // 
            this.cbPuesto.Size = new System.Drawing.Size(153, 24);
            // 
            // btnRegistrarShido
            // 
            this.btnRegistrarShido.BackgroundImage = global::Presentacion.Properties.Resources.IconoAceptar;
            this.btnRegistrarShido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarShido.FlatAppearance.BorderSize = 0;
            this.btnRegistrarShido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarShido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarShido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarShido.Location = new System.Drawing.Point(587, 439);
            this.btnRegistrarShido.Name = "btnRegistrarShido";
            this.btnRegistrarShido.Size = new System.Drawing.Size(62, 58);
            this.btnRegistrarShido.TabIndex = 153;
            this.btnRegistrarShido.UseVisualStyleBackColor = true;
            this.btnRegistrarShido.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrarShido.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnRegistrarShido.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // PantallaRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(785, 534);
            this.Controls.Add(this.btnRegistrarShido);
            this.Name = "PantallaRegistroUsuario";
            this.Text = "Registro de usuario";
            this.Controls.SetChildIndex(this.cbPuesto, 0);
            this.Controls.SetChildIndex(this.tbFechaNac, 0);
            this.Controls.SetChildIndex(this.btnRegistrarShido, 0);
            this.Controls.SetChildIndex(this.tbRespuesta, 0);
            this.Controls.SetChildIndex(this.cbPregunta, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.tbCP, 0);
            this.Controls.SetChildIndex(this.cbCiudad, 0);
            this.Controls.SetChildIndex(this.tbPassword, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.tbUsuario, 0);
            this.Controls.SetChildIndex(this.tbApellidos, 0);
            this.Controls.SetChildIndex(this.tbNEmpleado, 0);
            this.Controls.SetChildIndex(this.cbPaíses, 0);
            this.Controls.SetChildIndex(this.cbMunicipio, 0);
            this.Controls.SetChildIndex(this.cbEstado, 0);
            this.Controls.SetChildIndex(this.tbNFrente, 0);
            this.Controls.SetChildIndex(this.tbColonia, 0);
            this.Controls.SetChildIndex(this.tbCalle, 0);
            this.Controls.SetChildIndex(this.cbDepartamento, 0);
            this.Controls.SetChildIndex(this.tbEmail, 0);
            this.Controls.SetChildIndex(this.tbTel, 0);
            this.Controls.SetChildIndex(this.cbEmail, 0);
            this.Controls.SetChildIndex(this.tbCel, 0);
            this.Controls.SetChildIndex(this.tbTrabajo, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
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
            if (!ValidarCampos)
            {
                Interface = new InterfaceUsuario(this);
                RegistroUsuario Usuario = ObtenerRegistro;
                bool PrimerAdmin = !Interface.HayAdministradores();
                if (cbDepartamento.Text == "Administrador" && !PrimerAdmin)
                {
                    if (Interface.PermisoDeAdministrador())
                    {
                        if (Interface.RegistrarUsuario(Usuario))
                        {
                            Close();
                        }
                    }
                }
                else
                {
                    if (PrimerAdmin)
                    {
                        //new ManejadorPrincipal().RegistrarEmpleado(Convert.ToInt32(tbNEmpleado.Text));
                        Interface.RegistrarEmpleado(Usuario.NumeroTrabajador);
                        if (Interface.RegistrarUsuario(Usuario))
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        if (Interface.RegistrarUsuario(Usuario))
                        {
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar la información correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                ActiveControl = ObtenerErrorControl;
                Refresh();
            }
        }

        protected override void btnMouseLeft(object sender, EventArgs e)
        {
            base.btnMouseLeft(sender, e);
        }

        protected override void btnMouseOver(object sender, EventArgs e)
        {
            base.btnMouseOver(sender, e);
        }

        protected override void btnCerrar_Click(object sender, EventArgs e)
        {
            base.btnCerrar_Click(sender, e);
        }

        protected void Form_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbRespuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnRegistrar_Click(sender, e);
            }
        }
    }
}
