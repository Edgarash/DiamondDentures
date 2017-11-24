using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Entidad;
using Entidad.Reportes;

namespace Presentacion.Reportes
{
    class DialogoModicarFactura : Pantalla
    {
        public static Factura Factura;
        private int[] _ids;

        public DialogoModicarFactura()
        {
            InitializeComponent();
        }

        #region UI

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.ComboBox cmbEstado;
        private Label label9;
        private TextBox txtIIdFactura;
        private Button btnVerificarId;
        private Button btnGenerarId;
        private System.Windows.Forms.PictureBox pictureBox1;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIIdFactura = new System.Windows.Forms.TextBox();
            this.btnVerificarId = new System.Windows.Forms.Button();
            this.btnGenerarId = new System.Windows.Forms.Button();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Controls.Add(this.pictureBox1);
            this.Encabezado.Size = new System.Drawing.Size(531, 93);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(93, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modificar información del cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.IconoModificar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(283, 377);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 60);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Presentacion.Properties.Resources.IconoAceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(173, 377);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(60, 60);
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(279, 441);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Cancelar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(173, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Aceptar";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(21, 204);
            this.txtNombreCliente.MaxLength = 100;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(214, 21);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(300, 267);
            this.txtCodigoPostal.MaxLength = 10;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(98, 21);
            this.txtCodigoPostal.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(21, 267);
            this.txtDireccion.MaxLength = 80;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(270, 21);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(250, 204);
            this.txtRFC.MaxLength = 15;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(268, 21);
            this.txtRFC.TabIndex = 2;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(409, 267);
            this.txtCiudad.MaxLength = 30;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(109, 21);
            this.txtCiudad.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Nombre del cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "RFC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Código Postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ciudad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(247, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Teléfono";
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(247, 333);
            this.mtbTelefono.Mask = "(999) 000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(111, 21);
            this.mtbTelefono.TabIndex = 7;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Ciudad de México",
            "Coahuila",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.cmbEstado.Location = new System.Drawing.Point(21, 330);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(214, 24);
            this.cmbEstado.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Id. factura";
            // 
            // txtIIdFactura
            // 
            this.txtIIdFactura.Location = new System.Drawing.Point(21, 143);
            this.txtIIdFactura.MaxLength = 11;
            this.txtIIdFactura.Name = "txtIIdFactura";
            this.txtIIdFactura.Size = new System.Drawing.Size(214, 21);
            this.txtIIdFactura.TabIndex = 39;
            this.txtIIdFactura.TextChanged += new System.EventHandler(this.txtIIdFactura_TextChanged);
            // 
            // btnVerificarId
            // 
            this.btnVerificarId.BackColor = System.Drawing.SystemColors.Window;
            this.btnVerificarId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarId.Location = new System.Drawing.Point(322, 142);
            this.btnVerificarId.Name = "btnVerificarId";
            this.btnVerificarId.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarId.TabIndex = 41;
            this.btnVerificarId.Text = "Verficar";
            this.btnVerificarId.UseVisualStyleBackColor = false;
            this.btnVerificarId.Click += new System.EventHandler(this.btnVerificarId_Click);
            // 
            // btnGenerarId
            // 
            this.btnGenerarId.BackColor = System.Drawing.SystemColors.Window;
            this.btnGenerarId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarId.Location = new System.Drawing.Point(241, 142);
            this.btnGenerarId.Name = "btnGenerarId";
            this.btnGenerarId.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarId.TabIndex = 41;
            this.btnGenerarId.Text = "Generar";
            this.btnGenerarId.UseVisualStyleBackColor = false;
            this.btnGenerarId.Click += new System.EventHandler(this.btnGenerarId_Click);
            // 
            // DialogoModicarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(531, 476);
            this.Controls.Add(this.btnGenerarId);
            this.Controls.Add(this.btnVerificarId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIIdFactura);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.mtbTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Name = "DialogoModicarFactura";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.DialogoModicarFactura_Load);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtNombreCliente, 0);
            this.Controls.SetChildIndex(this.txtCodigoPostal, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.txtRFC, 0);
            this.Controls.SetChildIndex(this.txtCiudad, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.mtbTelefono, 0);
            this.Controls.SetChildIndex(this.cmbEstado, 0);
            this.Controls.SetChildIndex(this.txtIIdFactura, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.btnVerificarId, 0);
            this.Controls.SetChildIndex(this.btnGenerarId, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void CargarInformacion()
        {
            txtNombreCliente.Text = Factura.NombreC;
            txtRFC.Text = Factura.RfcC;
            txtDireccion.Text = Factura.CalleC;
            txtCodigoPostal.Text = Factura.CpC.ToString();
            txtCiudad.Text = Factura.CiudadC;
            if (cmbEstado.Items.Contains(Factura.ToString()))
            {
                cmbEstado.SelectedItem = Factura.EstadoC;
                cmbEstado.Refresh();
            }
            else
            {
                cmbEstado.SelectedIndex = -1;
            }
            mtbTelefono.Text = Factura.TelefonoC;
        }

        private void DialogoModicarFactura_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                Factura.NombreC = txtNombreCliente.Text;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un nombre");
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtRFC.Text))
            {
                Factura.RfcC = txtRFC.Text;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un RFC");
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                Factura.CalleC = txtDireccion.Text;
            }
            else
            {
                MessageBox.Show("No se ha ingresado una direccion");
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtCodigoPostal.Text))
            {
                Factura.CpC = txtCodigoPostal.Text;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un codigo postal");
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtCiudad.Text))
            {
                Factura.CiudadC = txtCiudad.Text;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un estado");
                return;
            }
            if (cmbEstado.SelectedItem != null)
            {
                Factura.EstadoC = cmbEstado.SelectedItem.ToString();
                cmbEstado.Refresh();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un estado");
                return;
            }
            if (!string.IsNullOrWhiteSpace(mtbTelefono.Text))
            {
                Factura.TelefonoC = mtbTelefono.Text;
            }
            else
            {
                MessageBox.Show("No se ha ingresado un telefono");
                return;
            }
            int valor = 0;
            if (int.TryParse(txtIIdFactura.Text, out valor))
            {
                Factura.Id = valor;
            }
            else
            {
                MessageBox.Show("El ID no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnGenerarId_Click(object sender, EventArgs e)
        {
            RecuperarIds();
            txtIIdFactura.Text = GenerarId().ToString();
        }

        private void RecuperarIds()
        {
            if (_ids == null)
            {
                _ids = ManejadorReportes.RecuperarIdFacturas();
            }
        }

        private int GenerarId()
        {
            Random random = new Random();
            int valor;
            do
            {
                valor = random.Next(0, Datos.SAFE_MYSQL_INT);
            } while (_ids.Contains(valor));
            return valor;
        }

        private void btnVerificarId_Click(object sender, EventArgs e)
        {
            if (_ids == null)
            {
              _ids =  ManejadorReportes.RecuperarIdFacturas();
            }
            txtIIdFactura.BackColor = SystemColors.Window;
            int valor;
            if (!int.TryParse(txtIIdFactura.Text, out valor))
            {
                MessageBox.Show("El ID no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (VerificarId(valor))
            {
                MessageBox.Show("Ya existe una factura con ese ID", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIIdFactura.BackColor = Color.Red;
                return;
            }
            txtIIdFactura.BackColor = Color.Aquamarine;
        }

        private bool VerificarId(int valor)
        {
            return _ids.Contains(valor);
        }

        private void txtIIdFactura_TextChanged(object sender, EventArgs e)
        {
            txtIIdFactura.BackColor = SystemColors.Window;
        }
    }
}