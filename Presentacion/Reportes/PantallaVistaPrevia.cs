using Control;
using System.Windows.Forms;

namespace Presentacion.Reportes
{
    class PantallaVistaPrevia : Pantalla
    {
        public PantallaVistaPrevia()
        {
            InitializeComponent();
        }

        #region UI

        private GroupBox groupBox2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Size = new System.Drawing.Size(1210, 93);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(295, 96);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(915, 501);
            this.crystalReportViewer1.TabIndex = 9;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox2
            // 
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(3, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 501);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros del reporte";
            // 
            // PantallaVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1210, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "PantallaVistaPrevia";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.ResumeLayout(false);
        }

        #endregion
    }
}