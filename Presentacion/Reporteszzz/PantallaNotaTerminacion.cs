﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using Control;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using static Control.ManejadorContabilidad;

namespace Presentacion.Reportes
{
    internal class PantallaNotaTerminacion : Pantalla
    {
        public PantallaNotaTerminacion()
        {
            InitializeComponent();
        }

        #region UI Componente 

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private Button btnBuscarPedido;
        private Label label5;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label14;
        private CrystalReportViewer crystalReportViewer1;
        private SaveFileDialog sfdGuardar;
        private Label label13;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaNotaTerminacion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Controls.Add(this.pictureBox1);
            this.Encabezado.Size = new System.Drawing.Size(1141, 93);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(93, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Generar nota de terminación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(830, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Para generar una nota de terminacion, se debe seleccionar un pedido mediante el b" +
    "oton Buscar Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vista previa de la nota";
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.BackgroundImage = global::Presentacion.Properties.Resources.IconoBuscar;
            this.btnBuscarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPedido.FlatAppearance.BorderSize = 0;
            this.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedido.Location = new System.Drawing.Point(995, 276);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(60, 60);
            this.btnBuscarPedido.TabIndex = 30;
            this.btnBuscarPedido.TabStop = false;
            this.btnBuscarPedido.UseVisualStyleBackColor = true;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(971, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Buscar pedido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(1044, 460);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 60);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::Presentacion.Properties.Resources.IconoAceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(935, 460);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(60, 60);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1041, 524);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Cancelar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(935, 524);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Aceptar";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 159);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(900, 386);
            this.crystalReportViewer1.TabIndex = 35;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // sfdGuardar
            // 
            this.sfdGuardar.DefaultExt = "pdf";
            this.sfdGuardar.Filter = "Portable Format Document (.pdf)|*.pdf";
            this.sfdGuardar.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdGuardar_FileOk);
            // 
            // PantallaNotaTerminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1141, 561);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "PantallaNotaTerminacion";
            this.Text = "Generar nota de terminacion";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnBuscarPedido, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Metodos

        private void MostrarNotaTerminacion(int numeroPedido)
        {
            crystalReportViewer1.ReportSource = GenerarNotaTerminacion(numeroPedido);
            crystalReportViewer1.Refresh();
        }

        #endregion

        #region Eventos

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            PantallaBuscarPedido pbp = new PantallaBuscarPedido();
            Hide();
            pbp.ShowDialog();
            int numeroPedido = pbp.Renglon;
            if (numeroPedido > 0)
                MostrarNotaTerminacion(numeroPedido);
            pbp.Close();
            Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            sfdGuardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfdGuardar.FileName = $@"NotaT-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pdf";
            sfdGuardar.ShowDialog();
        }


        private void sfdGuardar_FileOk(object sender, CancelEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (crystalReportViewer1.ReportSource != null)
               ExportarReporte(sfdGuardar.FileName,
                    (ReportDocument) crystalReportViewer1.ReportSource);
            Cursor = Cursors.Default;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        #endregion
    }
}