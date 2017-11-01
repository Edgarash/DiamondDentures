using Control;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Entidad;
using static System.Environment;

namespace Presentacion.Reportes
{
    class PantallaVPMateriales : Pantalla
    {
        private readonly Dictionary<string, bool> _estadoColumnas = new Dictionary<string, bool>
        {
            {"Descripcion", true},
            {"Nombre Prov.", true},
            {"Precio Base", true},
            {"Precio Compra", true},
            {"Unidad Medida", true},
            {"Cantidad", true}
        };

        public PantallaVPMateriales()
        {
            InitializeComponent();
            for (int i = 0; i < clbOpciones.Items.Count; i++)
            {
                clbOpciones.SetItemCheckState(i, CheckState.Checked);
            }
        }

        #region UI

        private GroupBox groupBox2;
        private Button btnRegresar;
        private Label label1;
        private Button btnExportar;
        private Label label10;
        private SaveFileDialog sfdExportar;
        private Button btnGenerar;
        private Label label6;
        private Label label2;
        private CheckedListBox clbOpciones;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisor;

        private void InitializeComponent()
        {
            this.crvVisor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clbOpciones = new System.Windows.Forms.CheckedListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.sfdExportar = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Size = new System.Drawing.Size(1210, 93);
            // 
            // crvVisor
            // 
            this.crvVisor.ActiveViewIndex = -1;
            this.crvVisor.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) |
                       System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.clbOpciones);
            this.groupBox2.Controls.Add(this.btnGenerar);
            this.groupBox2.Controls.Add(this.label6);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Campos para mostrar:";
            // 
            // clbOpciones
            // 
            this.clbOpciones.FormattingEnabled = true;
            this.clbOpciones.Items.AddRange(new object[]
            {
                "Descripcion",
                "Nombre Prov.",
                "Precio Base",
                "Precio Compra",
                "Unidad Medida",
                "Cantidad"
            });
            this.clbOpciones.Location = new System.Drawing.Point(9, 42);
            this.clbOpciones.Name = "clbOpciones";
            this.clbOpciones.Size = new System.Drawing.Size(120, 100);
            this.clbOpciones.TabIndex = 27;
            this.clbOpciones.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbOpciones_ItemCheck);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(103, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Generar";
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            // PantallaVPMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1210, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.crvVisor);
            this.MaximizeBox = true;
            this.Name = "PantallaVPMateriales";
            this.Text = "Materiales";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.crvVisor, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private void btnExportar_Click(object sender, System.EventArgs e)
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

        private void CambiarEstado(string item, CheckState estadoItem)
        {
            bool temp = CheckState.Checked == estadoItem;
            _estadoColumnas[item] = temp;
        }

        private void CargarReporte()
        {
            ParametroReporte Descrip = new ParametroReporte("des", _estadoColumnas["Descripcion"]);
            ParametroReporte NombreProv = new ParametroReporte("nomprov", _estadoColumnas["Nombre Prov."]);
            ParametroReporte Prbase = new ParametroReporte("prbase", _estadoColumnas["Precio Base"]);
            ParametroReporte Prcompra = new ParametroReporte("prcomp", _estadoColumnas["Precio Compra"]);
            ParametroReporte Unmedi = new ParametroReporte("umedi", _estadoColumnas["Unidad Medida"]);
            ParametroReporte Cant = new ParametroReporte("cant", _estadoColumnas["Cantidad"]);

            crvVisor.ReportSource = ManejadorReportes.CargarReporte(new ReporteMateriales(), Descrip, NombreProv, Prbase, Prcompra, Unmedi, Cant);
        }

        private void btnRegresar_Click(object sender, EventArgs e) => Close();

        private void sfdExportar_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string ruta = sfdExportar.FileName;
            ManejadorReportes.ExportarReporte(ruta, (ReporteMateriales) crvVisor.ReportSource);
        }

        private void clbOpciones_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox a = (CheckedListBox) sender;
            if (a.SelectedItem != null)
            {
                CambiarEstado(a.SelectedItem.ToString(), e.NewValue);
            }
        }
    }
}