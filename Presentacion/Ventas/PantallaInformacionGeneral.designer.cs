namespace Presentacion.Ventas
{
    partial class PantallaInformacionGeneral
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblFechaRegistrado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDentista = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.kuroDGV1 = new ControlesM.KuroDGV();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRestanteAPagar = new System.Windows.Forms.Label();
            this.btnAbonar = new ControlesM.KuroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kuroButton1 = new ControlesM.KuroButton();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "#Pedido:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(272, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(107, 20);
            label3.TabIndex = 0;
            label3.Text = "Registrado el:";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(272, 35);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(109, 20);
            label5.TabIndex = 0;
            label5.Text = "Por el usuario:";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(3, 35);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(73, 20);
            label7.TabIndex = 0;
            label7.Text = "Dentista:";
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label9.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label9, 2);
            label9.Location = new System.Drawing.Point(3, 65);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(141, 20);
            label9.TabIndex = 0;
            label9.Text = "Fecha de Entrega:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Location = new System.Drawing.Point(3, 234);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 20);
            label2.TabIndex = 0;
            label2.Text = "Restante A Pagar:";
            // 
            // lblPedido
            // 
            this.lblPedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPedido.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblPedido, 2);
            this.lblPedido.Location = new System.Drawing.Point(83, 5);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(64, 20);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "XXXXX";
            // 
            // lblFechaRegistrado
            // 
            this.lblFechaRegistrado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechaRegistrado.AutoSize = true;
            this.lblFechaRegistrado.Location = new System.Drawing.Point(392, 5);
            this.lblFechaRegistrado.Name = "lblFechaRegistrado";
            this.lblFechaRegistrado.Size = new System.Drawing.Size(64, 20);
            this.lblFechaRegistrado.TabIndex = 0;
            this.lblFechaRegistrado.Text = "XXXXX";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(392, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "XXXXX";
            // 
            // lblDentista
            // 
            this.lblDentista.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDentista.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblDentista, 2);
            this.lblDentista.Location = new System.Drawing.Point(83, 35);
            this.lblDentista.Name = "lblDentista";
            this.lblDentista.Size = new System.Drawing.Size(64, 20);
            this.lblDentista.TabIndex = 0;
            this.lblDentista.Text = "XXXXX";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechaEntrega.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblFechaEntrega, 2);
            this.lblFechaEntrega.Location = new System.Drawing.Point(153, 65);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(64, 20);
            this.lblFechaEntrega.TabIndex = 0;
            this.lblFechaEntrega.Text = "XXXXX";
            // 
            // kuroDGV1
            // 
            this.kuroDGV1.AllowUserToAddRows = false;
            this.kuroDGV1.AllowUserToDeleteRows = false;
            this.kuroDGV1.AllowUserToResizeRows = false;
            this.kuroDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kuroDGV1.BackgroundColor = System.Drawing.Color.White;
            this.kuroDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kuroDGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Material1,
            this.Material2,
            this.Precio});
            this.tableLayoutPanel1.SetColumnSpan(this.kuroDGV1, 6);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kuroDGV1.DefaultCellStyle = dataGridViewCellStyle1;
            this.kuroDGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kuroDGV1.GridColor = System.Drawing.Color.Black;
            this.kuroDGV1.Location = new System.Drawing.Point(3, 93);
            this.kuroDGV1.MultiSelect = false;
            this.kuroDGV1.Name = "kuroDGV1";
            this.kuroDGV1.ReadOnly = true;
            this.kuroDGV1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.kuroDGV1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kuroDGV1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kuroDGV1.Size = new System.Drawing.Size(899, 138);
            this.kuroDGV1.TabIndex = 1;
            this.kuroDGV1.TabStop = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Material1
            // 
            this.Material1.HeaderText = "Material 1";
            this.Material1.Name = "Material1";
            this.Material1.ReadOnly = true;
            // 
            // Material2
            // 
            this.Material2.HeaderText = "Material 2";
            this.Material2.Name = "Material2";
            this.Material2.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Final";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // lblRestanteAPagar
            // 
            this.lblRestanteAPagar.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblRestanteAPagar, 2);
            this.lblRestanteAPagar.Location = new System.Drawing.Point(153, 234);
            this.lblRestanteAPagar.Name = "lblRestanteAPagar";
            this.lblRestanteAPagar.Size = new System.Drawing.Size(64, 20);
            this.lblRestanteAPagar.TabIndex = 0;
            this.lblRestanteAPagar.Text = "XXXXX";
            // 
            // btnAbonar
            // 
            this.btnAbonar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbonar.BackColor = System.Drawing.Color.White;
            this.btnAbonar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAbonar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbonar.ForeColor = System.Drawing.Color.Black;
            this.btnAbonar.Location = new System.Drawing.Point(770, 266);
            this.btnAbonar.Name = "btnAbonar";
            this.tableLayoutPanel1.SetRowSpan(this.btnAbonar, 3);
            this.btnAbonar.Size = new System.Drawing.Size(132, 55);
            this.btnAbonar.TabIndex = 2;
            this.btnAbonar.Text = "Abonar $$$";
            this.btnAbonar.UseVisualStyleBackColor = false;
            this.btnAbonar.Click += new System.EventHandler(this.kuroButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Controls.Add(this.kuroButton1, 3, 4);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRestanteAPagar, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.kuroDGV1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaRegistrado, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUsuario, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaEntrega, 2, 2);
            this.tableLayoutPanel1.Controls.Add(label5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPedido, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDentista, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAbonar, 5, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 324);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // kuroButton1
            // 
            this.kuroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kuroButton1.BackColor = System.Drawing.Color.White;
            this.kuroButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.kuroButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kuroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kuroButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kuroButton1.ForeColor = System.Drawing.Color.Black;
            this.kuroButton1.Location = new System.Drawing.Point(628, 266);
            this.kuroButton1.Name = "kuroButton1";
            this.tableLayoutPanel1.SetRowSpan(this.kuroButton1, 3);
            this.kuroButton1.Size = new System.Drawing.Size(132, 55);
            this.kuroButton1.TabIndex = 3;
            this.kuroButton1.Text = "Entregar";
            this.kuroButton1.UseVisualStyleBackColor = false;
            // 
            // PantallaInformacionGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(905, 324);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PantallaInformacionGeneral";
            this.Text = "InfoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblFechaRegistrado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDentista;
        private System.Windows.Forms.Label lblFechaEntrega;
        private ControlesM.KuroDGV kuroDGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lblRestanteAPagar;
        private ControlesM.KuroButton btnAbonar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ControlesM.KuroButton kuroButton1;
    }
}
