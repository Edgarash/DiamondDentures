﻿using Control;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using CrystalDecisions.CrystalReports.Engine;
using Entidad;
using static System.Environment;

namespace Presentacion.Reportes
{
    class PantallaVPListadoFec<T> : Pantalla where T : ReportClass, new()
    {
       

        private ParametroReporte FchIni;
        private ParametroReporte FchFin;



        public PantallaVPListadoFec(string titulo, ParametroReporte fechaInicial, ParametroReporte fechaFinal)
        {
            InitializeComponent();
            Text = titulo;

            dtpFechaInicial.Value =  (DateTime) fechaInicial.Valor;
            dtpFechaFinal.Value =  (DateTime) fechaFinal.Valor;

            FchIni = fechaInicial;
            FchFin = fechaFinal;
        }

        public PantallaVPListadoFec(string titulo, DateTime fechaInicial, DateTime fechaFinal, params ParametroReporte[] parametros)
        {
            InitializeComponent();
            Text = titulo;

            dtpFechaInicial.Value = fechaInicial;
            dtpFechaFinal.Value = fechaFinal;

            CargarReporte(true, parametros);

        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }
        
        #region UI

        private GroupBox groupBox2;
        private Button btnRegresar;
        private Label label1;
        private Button btnExportar;
        private Label label10;
        private SaveFileDialog sfdExportar;
        private Button btnGenerar;
        private Label lblGenerar;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFechaInicial;
        private DateTimePicker dtpFechaFinal;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisor;

        private void InitializeComponent()
        {
            this.crvVisor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblGenerar = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.sfdExportar = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.Encabezado.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label2);
            this.Encabezado.Size = new System.Drawing.Size(1210, 93);
            // 
            // crvVisor
            // 
            this.crvVisor.ActiveViewIndex = -1;
            this.crvVisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisor.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisor.DisplayStatusBar = false;
            this.crvVisor.DisplayToolbar = false;
            this.crvVisor.Location = new System.Drawing.Point(295, 96);
            this.crvVisor.Name = "crvVisor";
            this.crvVisor.Size = new System.Drawing.Size(915, 501);
            this.crvVisor.TabIndex = 9;
            this.crvVisor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpFechaInicial);
            this.groupBox2.Controls.Add(this.dtpFechaFinal);
            this.groupBox2.Controls.Add(this.btnGenerar);
            this.groupBox2.Controls.Add(this.lblGenerar);
            this.groupBox2.Controls.Add(this.btnRegresar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnExportar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(3, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 501);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros del reporte";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackgroundImage = global::Presentacion.Properties.Resources.IconoGenerar;
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Location = new System.Drawing.Point(108, 232);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(60, 60);
            this.btnGenerar.TabIndex = 24;
            this.btnGenerar.TabStop = false;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblGenerar
            // 
            this.lblGenerar.AutoSize = true;
            this.lblGenerar.BackColor = System.Drawing.Color.Transparent;
            this.lblGenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGenerar.Location = new System.Drawing.Point(103, 295);
            this.lblGenerar.Name = "lblGenerar";
            this.lblGenerar.Size = new System.Drawing.Size(71, 20);
            this.lblGenerar.TabIndex = 23;
            this.lblGenerar.Text = "Generar";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::Presentacion.Properties.Resources.IconoRegresarReportes;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(183, 368);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(60, 60);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(179, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Regresar";
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = global::Presentacion.Properties.Resources.IconoExportar;
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(30, 368);
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
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(26, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Exportar";
            // 
            // sfdExportar
            // 
            this.sfdExportar.Filter = "Adobe PDF|*.pdf";
            this.sfdExportar.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdExportar_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Crear un reporte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Rango de fechas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "-";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(30, 61);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(78, 21);
            this.dtpFechaInicial.TabIndex = 34;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(132, 61);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(78, 21);
            this.dtpFechaFinal.TabIndex = 35;
            // 
            // PantallaVPListadoFec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1210, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.crvVisor);
            this.MaximizeBox = true;
            this.Name = "PantallaVPListadoFec";
            this.Text = "Materiales";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.crvVisor, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (crvVisor.ReportSource == null)
            {
                MessageBox.Show("No se ha generado ningun reporte", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            sfdExportar.InitialDirectory = GetFolderPath(SpecialFolder.MyDocuments);
            sfdExportar.FileName = $"reporte-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pdf";
            sfdExportar.ShowDialog();
        }

        private void btnGenerar_Click(object sender, EventArgs e) => CargarReporte();

        private void CargarReporte()
        {
            DateTime fchIni = dtpFechaInicial.Value.Date;
            DateTime fchFin = dtpFechaFinal.Value.Date;

            if (fchFin < fchIni)
            {
                MessageBox.Show("La fecha inicial es mayor a la fecha final");
                return;
            }

            FchIni.Valor = fchIni;
            FchFin.Valor = fchFin;

            crvVisor.ReportSource = ManejadorReportes.CargarReporte(new T(), FchIni, FchFin);
        }

        private void CargarReporte(bool subreporte, ParametroReporte[] parametros)
        {
            crvVisor.ReportSource = ManejadorReportes.CargarReporte(new T(), parametros[0], parametros[1], parametros[2], parametros[3]);
        }

        private void btnRegresar_Click(object sender, EventArgs e) => Close();

        private void sfdExportar_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string ruta = sfdExportar.FileName;
            ManejadorReportes.ExportarReporte(ruta, (T) crvVisor.ReportSource);
        }
    }
}