using System;
using System.ComponentModel;
using System.Windows.Forms;
using Control;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using static System.Environment;
using static Control.ManejadorContabilidad;

namespace Presentacion.Reportes
{
    public class PantallaGenerarRVentas : Pantalla
    {
        private ReportDocument reporteActual;

        public PantallaGenerarRVentas()
        {
            InitializeComponent();
            cmbPeriodo.SelectedItem = 0;
            for (int años = 2100; años > 1990; años--)
            {
                cmbAño.Items.Add(años);
            }

            Reiniciar();
        }

        #region Metodos

        private void ActivarFechas(bool activar)
        {
            dtpFechaA.Enabled = activar;
            dtpFechaB.Enabled = activar;
        }

        private void MostrarReporte()
        {
            reporteActual = DefinirIntervaloFecha(cmbPeriodo.SelectedItem.ToString(),
                (int) cmbAño.SelectedItem, dtpFechaA.Value, dtpFechaB.Value);
            
            if (reporteActual != null)
            {
                crystalReportViewer1.ReportSource = reporteActual;
                crystalReportViewer1.Refresh();
            }
            else
            {
                MessageBox.Show("No se definio ninguna opcion", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void Reiniciar()
        {
            cmbPeriodo.SelectedIndex = 0;
            cmbAño.SelectedIndex = cmbAño.Items.IndexOf(DateTime.Now.Year);

            cmbPeriodo.Refresh();
            cmbAño.Refresh();

            dtpFechaA.Value = DateTime.Today.AddMonths(-6);
            dtpFechaB.Value = DateTime.Today;

            ActivarFechas(false);
        }

        #endregion

        #region Eventos

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MostrarReporte();
        }

        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivarFechas(cmbPeriodo.SelectedItem.ToString() == "Personalizado");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (reporteActual == null)
            {
                MessageBox.Show("No se ha generado ningun reporte", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            sfdExportar.InitialDirectory = GetFolderPath(SpecialFolder.MyDocuments);
            sfdExportar.FileName = $"reporte-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pdf";
            sfdExportar.ShowDialog();
        }

        private void svfExportar_FileOk(object sender, CancelEventArgs e)
        {
            string ruta = sfdExportar.FileName;
            ExportarReporte(ruta, reporteActual);
        }

        private void dtpFechaA_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaA.MaxDate = dtpFechaB.Value.AddDays(-1);
        }

        private void dtpFechaB_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaB.MinDate = dtpFechaA.Value.AddDays(1);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Hide();
        }
        #endregion

        #region UI Componentes

        private Label label1;
        private Label label2;
        private PictureBox pictureBox6;
        private Label label21;
        private Label label3;
        private ComboBox cmbPeriodo;
        private CrystalReportViewer crystalReportViewer1;
        private Button btnGenerar;
        private Label label6;
        private Label label7;
        private Button btnLimpiar;
        private DateTimePicker dtpFechaB;
        private DateTimePicker dtpFechaA;
        private Label label4;
        private Label label9;
        private Label label5;
        private Label label8;
        private ComboBox cmbAño;
        private Label label10;
        private Button btnExportar;
        private SaveFileDialog sfdExportar;
        private Button btnRegresar;
        private Label label11;
        private PictureBox pictureBox1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaGenerarRVentas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpFechaB = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaA = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.sfdExportar = new System.Windows.Forms.SaveFileDialog();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.btnRegresar);
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Controls.Add(this.pictureBox1);
            this.Encabezado.Controls.Add(this.label11);
            this.Encabezado.Size = new System.Drawing.Size(816, 93);
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
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Generar reporte de ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Favor de ingresar el criterio para generar el reporte";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Presentacion.Properties.Resources.ImagenSeparador;
            this.pictureBox6.Location = new System.Drawing.Point(30, 160);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(700, 2);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label21.Location = new System.Drawing.Point(28, 139);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 21);
            this.label21.TabIndex = 18;
            this.label21.Text = "Opciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Periodo:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "Anual",
            "1er Semestral ",
            "2do Semestral ",
            "1er Trimestral",
            "2er Trimestral",
            "3er Trimestral",
            "4er Trimestral",
            "Personalizado",
            ""});
            this.cmbPeriodo.Location = new System.Drawing.Point(97, 168);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(163, 24);
            this.cmbPeriodo.TabIndex = 1;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodo_SelectedIndexChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 277);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(792, 308);
            this.crystalReportViewer1.TabIndex = 21;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerar.BackgroundImage")));
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Location = new System.Drawing.Point(500, 179);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(60, 60);
            this.btnGenerar.TabIndex = 22;
            this.btnGenerar.TabStop = false;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(495, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Generar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(591, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Limpiar";
            // 
            // btnLimpiar
            // 
            ////this.btnLimpiar.BackgroundImage = global::Presentacion.Properties.Resources.IconoLimpiar;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(591, 179);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(60, 60);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtpFechaB
            // 
            this.dtpFechaB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaB.Location = new System.Drawing.Point(167, 228);
            this.dtpFechaB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaB.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpFechaB.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpFechaB.Name = "dtpFechaB";
            this.dtpFechaB.Size = new System.Drawing.Size(93, 21);
            this.dtpFechaB.TabIndex = 4;
            this.dtpFechaB.Value = new System.DateTime(2017, 4, 30, 20, 51, 0, 0);
            this.dtpFechaB.ValueChanged += new System.EventHandler(this.dtpFechaB_ValueChanged);
            // 
            // dtpFechaA
            // 
            this.dtpFechaA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaA.Location = new System.Drawing.Point(32, 226);
            this.dtpFechaA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaA.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpFechaA.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpFechaA.Name = "dtpFechaA";
            this.dtpFechaA.Size = new System.Drawing.Size(93, 21);
            this.dtpFechaA.TabIndex = 3;
            this.dtpFechaA.Value = new System.DateTime(2017, 3, 30, 20, 51, 0, 0);
            this.dtpFechaA.ValueChanged += new System.EventHandler(this.dtpFechaA_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 42);
            this.label9.TabIndex = 38;
            this.label9.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(28, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Invervalo de tiempo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(266, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Año:";
            // 
            // cmbAño
            // 
            this.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(312, 168);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(163, 24);
            this.cmbAño.TabIndex = 2;
            this.cmbAño.SelectedIndexChanged += new System.EventHandler(this.cmbAño_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(677, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Exportar";
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportar.BackgroundImage")));
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Location = new System.Drawing.Point(681, 179);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(60, 60);
            this.btnExportar.TabIndex = 22;
            this.btnExportar.TabStop = false;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // sfdExportar
            // 
            this.sfdExportar.DefaultExt = "pdf";
            this.sfdExportar.Filter = "Portable Document Format (PDF)|*.pdf";
            this.sfdExportar.RestoreDirectory = true;
            this.sfdExportar.FileOk += new System.ComponentModel.CancelEventHandler(this.svfExportar_FileOk);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(701, 22);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(60, 60);
            this.btnRegresar.TabIndex = 22;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(612, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Regresar";
            // 
            // PantallaGenerarRVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(816, 597);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaB);
            this.Controls.Add(this.dtpFechaA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Name = "PantallaGenerarRVentas";
            this.Text = "Generar reporte de ventas";
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtpFechaA, 0);
            this.Controls.SetChildIndex(this.dtpFechaB, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.pictureBox6, 0);
            this.Controls.SetChildIndex(this.cmbPeriodo, 0);
            this.Controls.SetChildIndex(this.cmbAño, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.btnGenerar, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.btnExportar, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        
    }
}