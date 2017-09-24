using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Control;
using Entidad.Reportes;
using Presentacion.Properties;

namespace Presentacion.Reportes
{
    internal class PantallaEnviarCorreo : Pantalla
    {
        private readonly List<string> _dominios = new List<string>
        {
            "gmail.com",
            "yahoo.ca",
            "yahoo.co.in",
            "yahoo.co.jp",
            "yahoo.co.kr",
            "yahoo.co.nz",
            "yahoo.co.uk",
            "yahoo.com",
            "yahoo.com.ar",
            "yahoo.com.au",
            "yahoo.com.br",
            "yahoo.com.cn",
            "yahoo.com.hk",
            "yahoo.com.is",
            "yahoo.com.mx",
            "yahoo.com.ru",
            "yahoo.com.sg",
            "yahoo.de",
            "yahoo.dk",
            "yahoo.es",
            "yahoo.fr",
            "yahoo.ie",
            "yahoo.it",
            "yahoo.jp",
            "yahoo.ru",
            "yahoo.se",
            "hotmail.co.il",
            "hotmail.co.uk",
            "hotmail.com",
            "hotmail.fr",
            "hotmail.kg",
            "hotmail.kz",
            "hotmail.ru",
            "live.com",
            "prodigy.net",
            "outlook.com"
        };

        public PantallaEnviarCorreo()
        {
            InitializeComponent();
        }


        public void CrearCorreo()
        {
            string destinatario = txtDestinatario.Text.Trim();
            if (!string.IsNullOrWhiteSpace(destinatario))
            {
                if (destinatario.Split('@').Length > 1)
                {
                    if (!_dominios.Contains(destinatario.Split('@')[1]))
                    {
                        MessageBox.Show("No se reconoce el dominio del correo del destinatario: " + destinatario,
                            "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(
                        "El correo ingresado no posee el formato adecuado. Una direccion de correo debe estar compuesta de una parte local, el simbolo \"@\" y un dominio.\n\nEjemplo: marco.lopez@gmail.com",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado el correo del destinatario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string cc = txtCC.Text.Trim();
            string[] listaCorreo = {};
            if (!string.IsNullOrWhiteSpace(cc))
            {
                listaCorreo = cc.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                foreach (string elemento in listaCorreo.Where(elemento => !string.IsNullOrWhiteSpace(elemento)))
                {
                    if (elemento.Split('@').Length > 1)
                    {
                        if (_dominios.Contains(elemento.Split('@')[1]))
                            continue;

                        MessageBox.Show("No se reconoce el dominio del correo del destinatario: " + elemento,
                            "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }
                    else
                    {
                        MessageBox.Show(
                            "El correo ingresado no posee el formato adecuado. Una direccion de correo debe estar compuesta de una parte local, el simbolo \"@\" y un dominio.\n\nEjemplo: marco.lopez@gmail.com",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            string mensaje = txtMensaje.Text.Trim();
            if (string.IsNullOrWhiteSpace(mensaje))
                mensaje = string.Empty;

            string asunto = txtAsunto.Text.Trim();
            if (string.IsNullOrWhiteSpace(asunto))
                asunto = string.Empty;

            string archivo = txtRuta.Text;
            if (string.IsNullOrWhiteSpace(archivo))
            {
                DialogResult respuesta =  MessageBox.Show("Se esta apunto de enviar un correo sin una factura adjunta, ¿Desea continuar?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (respuesta != DialogResult.Yes)
                {
                    return;
                }
            }

            List<string> l = listaCorreo.ToList();
            Correo correo = new Correo(destinatario, mensaje, asunto,l ,archivo);
            Cursor.Current = Cursors.WaitCursor;
            ManejadorContabilidad.EnviarCorreo(correo);
            Cursor.Current = Cursors.Default;
        }

        #region Eventos

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CrearCorreo();
        }

        #endregion

        private void label6_Click(object sender, EventArgs e)
        {
        }

        #region UI Componentes

        private Panel panel1;
        private PictureBox pictureBox5;
        private Label label15;
        private Label label1;
        private Label label12;
        private TextBox txtDestinatario;
        private Label label2;
        private TextBox txtAsunto;
        private Label label3;
        private TextBox txtCC;
        private TextBox txtMensaje;
        private Label label4;
        private TextBox txtRuta;
        private Button btnAdjuntar;
        private Label label5;
        private Label label7;
        private Button btnCancelar;
        private Button btnEnviar;
        private PictureBox pictureBox1;
        private Label label8;
        private OpenFileDialog ofdFactura;
        private Label label6;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaEnviarCorreo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ofdFactura = new System.Windows.Forms.OpenFileDialog();
            this.Encabezado.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.pictureBox1);
            this.Encabezado.Controls.Add(this.label8);
            this.Encabezado.Size = new System.Drawing.Size(530, 114);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 90);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(23, 7);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 74);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(110, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Enviar E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Destinatario:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(305, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "Por favor ingrese los datos correspondientes";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(42, 175);
            this.txtDestinatario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(444, 21);
            this.txtDestinatario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asunto";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(42, 230);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(444, 21);
            this.txtAsunto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mensaje:";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(42, 283);
            this.txtCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(444, 21);
            this.txtCC.TabIndex = 3;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(42, 341);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(444, 194);
            this.txtMensaje.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Factura adjunta:";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(42, 564);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(360, 21);
            this.txtRuta.TabIndex = 11;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdjuntar.Location = new System.Drawing.Point(408, 564);
            this.btnAdjuntar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(78, 21);
            this.btnAdjuntar.TabIndex = 12;
            this.btnAdjuntar.Text = "Adjuntar";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enviar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(423, 663);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cancelar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "C.C:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(426, 599);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 60);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackgroundImage = global::Presentacion.Properties.Resources.IconoAceptar;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Location = new System.Drawing.Point(205, 599);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(60, 60);
            this.btnEnviar.TabIndex = 14;
            this.btnEnviar.TabStop = false;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(111, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Enviar E-mail";
            // 
            // ofdFactura
            // 
            this.ofdFactura.DefaultExt = "pdf";
            this.ofdFactura.Filter = "Portable Document Format (.pdf)|*.pdf";
            this.ofdFactura.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdFactura_FileOk);
            // 
            // PantallaEnviarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 686);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "PantallaEnviarCorreo";
            this.Text = "Enviar Email";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDestinatario, 0);
            this.Controls.SetChildIndex(this.txtAsunto, 0);
            this.Controls.SetChildIndex(this.txtCC, 0);
            this.Controls.SetChildIndex(this.txtMensaje, 0);
            this.Controls.SetChildIndex(this.txtRuta, 0);
            this.Controls.SetChildIndex(this.btnAdjuntar, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnEnviar, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Eventos

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            ofdFactura.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DialogResult dialog = ofdFactura.ShowDialog();

        }

        private void ofdFactura_FileOk(object sender, CancelEventArgs e)
        {
            txtRuta.Text = ofdFactura.FileName;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        #endregion
    }
}