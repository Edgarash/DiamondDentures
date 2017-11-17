namespace Presentacion.Finanzas
{
    partial class FinanzasVerRequisicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txTotal = new System.Windows.Forms.TextBox();
            this.dtRequisicion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRequisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Size = new System.Drawing.Size(824, 93);
            // 
            // txTotal
            // 
            this.txTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotal.Location = new System.Drawing.Point(575, 351);
            this.txTotal.Multiline = true;
            this.txTotal.Name = "txTotal";
            this.txTotal.ReadOnly = true;
            this.txTotal.Size = new System.Drawing.Size(237, 40);
            this.txTotal.TabIndex = 31;
            this.txTotal.Text = "TOTAL = ";
            // 
            // dtRequisicion
            // 
            this.dtRequisicion.AllowUserToAddRows = false;
            this.dtRequisicion.AllowUserToDeleteRows = false;
            this.dtRequisicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtRequisicion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtRequisicion.BackgroundColor = System.Drawing.Color.White;
            this.dtRequisicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRequisicion.Location = new System.Drawing.Point(12, 114);
            this.dtRequisicion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtRequisicion.Name = "dtRequisicion";
            this.dtRequisicion.ReadOnly = true;
            this.dtRequisicion.RowHeadersVisible = false;
            this.dtRequisicion.Size = new System.Drawing.Size(800, 235);
            this.dtRequisicion.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Requisición";
            // 
            // FinanzasVerRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 403);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.dtRequisicion);
            this.Name = "FinanzasVerRequisicion";
            this.Text = "FinanzasVerRequisicion";
            this.Load += new System.EventHandler(this.FinanzasVerRequisicion_Load);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.dtRequisicion, 0);
            this.Controls.SetChildIndex(this.txTotal, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRequisicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.DataGridView dtRequisicion;
        private System.Windows.Forms.Label label1;
    }
}