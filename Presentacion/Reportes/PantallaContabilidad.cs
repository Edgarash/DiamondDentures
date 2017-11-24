using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Control;
using CrystalDecisions.CrystalReports.Engine;
using Entidad;
using Entidad.Reportes;
using static Control.ManejadorBorrarFactura;

namespace Presentacion.Reportes
{
    internal class PantallaContabilidad : Pantalla
    {
        private DataTable _facturas;

        public PantallaContabilidad()
        {
            InitializeComponent();
            //Actualizar();
        }

        #region Metodos  

        

        private void MostrarFacturas()
        {
            _facturas = ManejadorReportes.RecuperarFacturas(new Dictionary<string, object>
            {
                {"opc", -1},
                {"nomc", string.Empty},
                {"nfac", default(int)},
                {"fchi", DateTime.MinValue},
                {"fchf", DateTime.MaxValue}
            });

            LlenarTabla(_facturas);
        }

        private void LlenarTabla(DataTable facturas)
        {
            dgvFacturas.Rows.Clear();
            foreach (DataRow factura in facturas.Select())
            {
                dgvFacturas.RowCount++;
                dgvFacturas["cid", dgvFacturas.RowCount - 1].Value = factura["NoFactura"];
                dgvFacturas["cnombre", dgvFacturas.RowCount - 1].Value = factura["NombreC"];
                dgvFacturas["ctelefono", dgvFacturas.RowCount - 1].Value = factura["TelefonoC"];
                dgvFacturas["cfecha", dgvFacturas.RowCount - 1].Value = factura["FechaEmision"];
                dgvFacturas["cemail", dgvFacturas.RowCount - 1].Value = factura["CorreoC"];
                dgvFacturas["cestado", dgvFacturas.RowCount - 1].Value = Convert.ToInt32(factura["Estatus"]) == 1 ? "Vigente" : "Cancelada";
            }
        }

        #endregion

        #region UI

        private PictureBox pictureBox6;
        private Label label21;
        private DataGridViewTextBoxColumn cid;
        private DataGridViewTextBoxColumn cnombre;
        private DataGridViewTextBoxColumn cfecha;
        private DataGridViewTextBoxColumn ctelefono;
        private DataGridViewTextBoxColumn cemail;
        private DataGridViewTextBoxColumn cestado;
        private ContextMenuStrip cmsTabla;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox5;
        private Label label12;
        private Label label13;
        private Label label15;
        private DataGridView dgvFacturas;
        private Label label7;
        private Label label8;
        private Label label14;
        private PictureBox pictureBox1;
        private Button btnGenerarFactura;
        private Button btnEnviarFactura;
        private Label label11;
        private IContainer components;
        private Label label1;
        private Label label3;
        private Button btnBuscarFacturas;
        private SaveFileDialog sfdFactura;
        private Button btnCancelar;
        private Label label4;
        private Button btnExportar;
        private Label label10;
        private Button btnRegresar;
        private Label label5;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof (PantallaContabilidad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsTabla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnEnviarFactura = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarFacturas = new System.Windows.Forms.Button();
            this.sfdFactura = new System.Windows.Forms.SaveFileDialog();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvFacturas)).BeginInit();
            this.cmsTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label14);
            this.Encabezado.Controls.Add(this.pictureBox1);
            this.Encabezado.Controls.Add(this.btnRegresar);
            this.Encabezado.Controls.Add(this.label5);
            this.Encabezado.Size = new System.Drawing.Size(1069, 80);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 81);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(23, 7);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 74);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(110, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Contabilidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(26, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Lista de facturas:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.Location = new System.Drawing.Point(944, 758);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Regresar";
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.cid,
                this.cnombre,
                this.cfecha,
                this.ctelefono,
                this.cemail,
                this.cestado
            });
            this.dgvFacturas.ContextMenuStrip = this.cmsTabla;
            this.dgvFacturas.Location = new System.Drawing.Point(29, 133);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(737, 291);
            this.dgvFacturas.TabIndex = 9;
            // 
            // cid
            // 
            this.cid.FillWeight = 75F;
            this.cid.HeaderText = "ID";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // cnombre
            // 
            this.cnombre.HeaderText = "Nombre";
            this.cnombre.Name = "cnombre";
            this.cnombre.ReadOnly = true;
            // 
            // cfecha
            // 
            this.cfecha.HeaderText = "Fecha";
            this.cfecha.Name = "cfecha";
            this.cfecha.ReadOnly = true;
            // 
            // ctelefono
            // 
            this.ctelefono.HeaderText = "Telefono";
            this.ctelefono.Name = "ctelefono";
            this.ctelefono.ReadOnly = true;
            // 
            // cemail
            // 
            this.cemail.HeaderText = "E-mail";
            this.cemail.Name = "cemail";
            this.cemail.ReadOnly = true;
            // 
            // cestado
            // 
            this.cestado.FillWeight = 60F;
            this.cestado.HeaderText = "Estado";
            this.cestado.Name = "cestado";
            this.cestado.ReadOnly = true;
            // 
            // cmsTabla
            // 
            this.cmsTabla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.actualizarToolStripMenuItem});
            this.cmsTabla.Name = "cmsTabla";
            this.cmsTabla.Size = new System.Drawing.Size(127, 26);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(23, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lista de facturas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(926, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Generar factura";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackgroundImage = global::Presentacion.Properties.Resources.invoice_account_bank_check;
            this.btnGenerarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerarFactura.FlatAppearance.BorderSize = 0;
            this.btnGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarFactura.Location = new System.Drawing.Point(958, 151);
            this.btnGenerarFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(60, 60);
            this.btnGenerarFactura.TabIndex = 14;
            this.btnGenerarFactura.TabStop = false;
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // btnEnviarFactura
            // 
            this.btnEnviarFactura.BackgroundImage = global::Presentacion.Properties.Resources.IconoEnviarEmail;
            this.btnEnviarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviarFactura.FlatAppearance.BorderSize = 0;
            this.btnEnviarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarFactura.Location = new System.Drawing.Point(897, 352);
            this.btnEnviarFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarFactura.Name = "btnEnviarFactura";
            this.btnEnviarFactura.Size = new System.Drawing.Size(60, 60);
            this.btnEnviarFactura.TabIndex = 14;
            this.btnEnviarFactura.TabStop = false;
            this.btnEnviarFactura.UseVisualStyleBackColor = true;
            this.btnEnviarFactura.Click += new System.EventHandler(this.btnEnviarFactura_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((byte) (0)));
            this.label11.Location = new System.Drawing.Point(871, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Enviar factura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.IconoFacturacion1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 60);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(96, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 24);
            this.label14.TabIndex = 15;
            this.label14.Text = "Contabilidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "A continuacion se muestra la lista de facturas registradas.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(798, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Buscar factura";
            // 
            // btnBuscarFacturas
            // 
            this.btnBuscarFacturas.BackgroundImage = global::Presentacion.Properties.Resources.IconoBuscarFactura;
            this.btnBuscarFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarFacturas.FlatAppearance.BorderSize = 0;
            this.btnBuscarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFacturas.Location = new System.Drawing.Point(824, 151);
            this.btnBuscarFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarFacturas.Name = "btnBuscarFacturas";
            this.btnBuscarFacturas.Size = new System.Drawing.Size(60, 60);
            this.btnBuscarFacturas.TabIndex = 14;
            this.btnBuscarFacturas.TabStop = false;
            this.btnBuscarFacturas.UseVisualStyleBackColor = true;
            this.btnBuscarFacturas.Click += new System.EventHandler(this.btnBuscarFacturas_Click);
            // 
            // sfdFactura
            // 
            this.sfdFactura.DefaultExt = "docx";
            this.sfdFactura.Filter = "Word Document 2010|*.docx";
            this.sfdFactura.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdFactura_FileOk);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(958, 249);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 60);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(916, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cancelar factura";
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = global::Presentacion.Properties.Resources.IconoExportar;
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(824, 249);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(60, 60);
            this.btnExportar.TabIndex = 24;
            this.btnExportar.TabStop = false;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((byte) (0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(820, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Exportar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(875, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Regresar";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = global::Presentacion.Properties.Resources.IconoRegresarReportes;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(958, 11);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(60, 60);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Presentacion.Properties.Resources.ImagenSeparador;
            this.pictureBox6.Location = new System.Drawing.Point(779, 127);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(270, 2);
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label21.Location = new System.Drawing.Point(777, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 21);
            this.label21.TabIndex = 25;
            this.label21.Text = "Opciones";
            // 
            // PantallaContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 464);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEnviarFactura);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarFacturas);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "PantallaContabilidad";
            this.Text = "Contabilidiad";
            this.Load += new System.EventHandler(this.PantallaContabilidad_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.dgvFacturas, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnGenerarFactura, 0);
            this.Controls.SetChildIndex(this.btnBuscarFacturas, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnEnviarFactura, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.btnExportar, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.pictureBox6, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvFacturas)).EndInit();
            this.cmsTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        #region Eventos

        private void sfdFactura_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            object id = dgvFacturas.SelectedRows[0].Cells["cid"].Value;
            PantallaVPListadoGen<FacturaReporte> pantalla = new PantallaVPListadoGen<FacturaReporte>("Factura", id, "nfac");
            Cursor = Cursors.Default;
            pantalla.ShowDialog();
            pantalla.Close();
        
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            PantallaCrearFactura pcf = new PantallaCrearFactura();
            Hide();
            pcf.ShowDialog();
            pcf.Close();
            Show();
            MostrarFacturas();
        }

        private void PantallaContabilidad_Load(object sender, EventArgs e)
        {
            MostrarFacturas();
        }

        private void btnBuscarFacturas_Click(object sender, EventArgs e)
        {
            PantallaBuscarFactura buscarFactura = new PantallaBuscarFactura(false);
            Hide();
            buscarFactura.ShowDialog();
            _facturas = buscarFactura.Facturas;
            if (_facturas != null)
            {
                LlenarTabla(_facturas);
            }
            buscarFactura.Close();
            Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (DateTime.Today != Convert.ToDateTime(dgvFacturas.SelectedRows[0].Cells["cfecha"].Value))
            {
                MessageBox.Show("Unicamente se puede cancelar una factura el mismo dia en la que fue emitida.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (dgvFacturas.SelectedRows.Count <= 0)
            {
                return;
            }
            int idFactura = (int) dgvFacturas.SelectedRows[0].Cells["cid"].Value;
            ManejadorReportes.CancelarFactura(idFactura);
            dgvFacturas.SelectedRows[0].Cells["cestado"].Value = "Cancelada";
            Cursor = Cursors.Default;
        }

        private void btnEnviarFactura_Click(object sender, EventArgs e)
        {
            PantallaEnviarCorreo pec = new PantallaEnviarCorreo();
            Hide();
            pec.ShowDialog();
            pec.Close();
            Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFacturas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogoModicarFactura pantalla = new DialogoModicarFactura();
        }

        #endregion
    }
}