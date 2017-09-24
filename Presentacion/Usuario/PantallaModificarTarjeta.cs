using Entidad;
using System;
using System.Windows.Forms;

namespace Presentacion.Usuario
{
    class PantallaModificarTarjeta : PantallaTarjeta
    {
        public PantallaModificarTarjeta() : base()
        {
            InitializeComponent();
        }
        public PantallaModificarTarjeta(RegistroTarjeta Tarjeta) : this()
        {
            User = Tarjeta.Login;
            tbNombre.Text = Tarjeta.NombreTitular;
            tbApellido.Text = Tarjeta.ApellidosTitular;
            tbBanco.Text = Tarjeta.Banco;
            tbBanco_SelectedIndexChanged(Tarjeta, new EventArgs());
            tbFechaTarjeta.MinDate = Convert.ToDateTime(DateTime.Today.Day + "/" + Tarjeta.FechaVencimiento);
            tbFechaTarjeta.Text = Convert.ToDateTime(DateTime.Today.Day + "/" + Tarjeta.FechaVencimiento).ToShortDateString();
            tbTarjeta.Text = Tarjeta.NumeroTarjeta;
        }
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo)).BeginInit();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Presentacion.Properties.Resources.IconoEditarTarjeta;
            // 
            // tbBanco
            // 
            this.tbBanco.Size = new System.Drawing.Size(191, 24);
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
            this.label15.Size = new System.Drawing.Size(175, 24);
            this.label15.Text = "Modificar tarjeta";
            // 
            // PantallaModificarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(517, 451);
            this.Name = "PantallaModificarTarjeta";
            this.Text = "Modificar Tarjeta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo)).EndInit();
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void btnMouseOver(object sender, EventArgs e)
        {
            base.btnMouseOver(sender, e);
        }
        protected override void btnMouseLeft(object sender, EventArgs e)
        {
            base.btnMouseLeft(sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool CamposVacios = false || Validaciones.ValidarComboBox(tbBanco);
            CamposVacios = Validaciones.ValidarMaskedTextBox(tbTarjeta) || CamposVacios;
            CamposVacios = Validaciones.ValidarTextBox(tbNombre, tbApellido);
            if (CamposVacios)
            {
                MessageBox.Show("Favor de llenar la información correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Interface = new InterfaceUsuario(this);
                tbTarjeta.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                RegistroTarjeta Tarjeta = ObtenerRegistro;
                if (Interface.ActualizarTarjeta(Tarjeta))
                {
                    MessageBox.Show("La tarjeta fue actualizada con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Close();
                }
                else
                {
                    MessageBox.Show("Se presentó algún error, por favor vuelva a interntarlo más tarde", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
