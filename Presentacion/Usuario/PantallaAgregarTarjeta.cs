using Entidad;
using System;
using System.Windows.Forms;

namespace Presentacion.Usuario
{
    class PantallaAgregarTarjeta : PantallaTarjeta
    {
        bool SacandoRegistro = false;
        public PantallaAgregarTarjeta(string Usuario) : base(Usuario)
        {
            InitializeComponent();
            RegistroUsuario temp;
            Interface = new InterfaceUsuario(this);
            Interface.RecuperarUsuario(Usuario, out temp);
            tbNombre.Text = temp.Nombre;
            tbApellido.Text = temp.Apellidos;
            this.ActiveControl = tbTarjeta;
            tbFechaTarjeta.KeyPress += new KeyPressEventHandler(delegate (object sender, KeyPressEventArgs e)
             {
                 if (e.KeyChar == 13)
                 {
                     btnAceptar_Click(sender, e);
                 }
             });
        }
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBanco
            // 
            this.tbBanco.Size = new System.Drawing.Size(191, 24);
            // 
            // tbTarjeta
            // 
            this.tbTarjeta.Mask = "0000 - 0000 - 0000 - 0000";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label15
            // 
            this.label15.Size = new System.Drawing.Size(163, 24);
            this.label15.Text = "Agregar tarjeta";
            // 
            // PantallaAgregarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(517, 451);
            this.Name = "PantallaAgregarTarjeta";
            this.Text = "Agregar Tarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            //Cambiar Validar campos por validacio por separado
            if (!Validaciones.ValidarCampos())
            {
                tbTarjeta.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (!Interface.ValidarDatosTarjeta(User))
                {
                    if (!SacandoRegistro)
                    {
                        RegistroTarjeta Tarjeta = ObtenerRegistro;
                        if (Interface.AgregarTarjeta(Tarjeta))
                        {
                            MessageBox.Show("Tarjeta registrada con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            MessageBox.Show("Hubo algun problema, intente más tarde", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
                this.Close();
            }
        }

        public void CrearRegistroTarjeta(RegistroTarjeta RegistroTarjeta, out RegistroTarjeta Tarjeta)
        {
            if (RegistroTarjeta != null)
            {
                tbNombre.Text = RegistroTarjeta.NombreTitular;
                tbApellido.Text = RegistroTarjeta.ApellidosTitular;
                tbBanco.Text = RegistroTarjeta.Banco;
                tbBanco_SelectedIndexChanged(new object(), new EventArgs());
                tbTarjeta.Text = RegistroTarjeta.NumeroTarjeta;
                tbFechaTarjeta.Text = RegistroTarjeta.FechaVencimiento;
            }
            SacandoRegistro = true;
            tbTarjeta.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            this.ShowDialog();
            Tarjeta = ObtenerRegistro;
        }
    }
}