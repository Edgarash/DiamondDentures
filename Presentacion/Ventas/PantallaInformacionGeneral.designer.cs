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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label2;
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
            this.kuroButton1 = new ControlesM.KuroButton();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "#Pedido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(329, 13);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(107, 20);
            label3.TabIndex = 0;
            label3.Text = "Registrado el:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(327, 33);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(109, 20);
            label5.TabIndex = 0;
            label5.Text = "Por el usuario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(13, 69);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(73, 20);
            label7.TabIndex = 0;
            label7.Text = "Dentista:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(13, 89);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(137, 20);
            label9.TabIndex = 0;
            label9.Text = "Fecha de Entrega";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(86, 13);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(64, 20);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "XXXXX";
            // 
            // lblFechaRegistrado
            // 
            this.lblFechaRegistrado.AutoSize = true;
            this.lblFechaRegistrado.Location = new System.Drawing.Point(442, 13);
            this.lblFechaRegistrado.Name = "lblFechaRegistrado";
            this.lblFechaRegistrado.Size = new System.Drawing.Size(64, 20);
            this.lblFechaRegistrado.TabIndex = 0;
            this.lblFechaRegistrado.Text = "XXXXX";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(442, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "XXXXX";
            // 
            // lblDentista
            // 
            this.lblDentista.AutoSize = true;
            this.lblDentista.Location = new System.Drawing.Point(156, 69);
            this.lblDentista.Name = "lblDentista";
            this.lblDentista.Size = new System.Drawing.Size(64, 20);
            this.lblDentista.TabIndex = 0;
            this.lblDentista.Text = "XXXXX";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(156, 89);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kuroDGV1.DefaultCellStyle = dataGridViewCellStyle3;
            this.kuroDGV1.GridColor = System.Drawing.Color.Black;
            this.kuroDGV1.Location = new System.Drawing.Point(12, 125);
            this.kuroDGV1.MultiSelect = false;
            this.kuroDGV1.Name = "kuroDGV1";
            this.kuroDGV1.ReadOnly = true;
            this.kuroDGV1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.kuroDGV1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kuroDGV1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.kuroDGV1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kuroDGV1.Size = new System.Drawing.Size(667, 150);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 278);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 20);
            label2.TabIndex = 0;
            label2.Text = "Restante A Pagar:";
            // 
            // lblRestanteAPagar
            // 
            this.lblRestanteAPagar.AutoSize = true;
            this.lblRestanteAPagar.Location = new System.Drawing.Point(154, 278);
            this.lblRestanteAPagar.Name = "lblRestanteAPagar";
            this.lblRestanteAPagar.Size = new System.Drawing.Size(64, 20);
            this.lblRestanteAPagar.TabIndex = 0;
            this.lblRestanteAPagar.Text = "XXXXX";
            // 
            // kuroButton1
            // 
            this.kuroButton1.BackColor = System.Drawing.Color.White;
            this.kuroButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.kuroButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kuroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kuroButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kuroButton1.ForeColor = System.Drawing.Color.Black;
            this.kuroButton1.Location = new System.Drawing.Point(559, 303);
            this.kuroButton1.Name = "kuroButton1";
            this.kuroButton1.Size = new System.Drawing.Size(120, 50);
            this.kuroButton1.TabIndex = 2;
            this.kuroButton1.Text = "Abonar $$$";
            this.kuroButton1.UseVisualStyleBackColor = false;
            this.kuroButton1.Click += new System.EventHandler(this.kuroButton1_Click);
            // 
            // PantallaInformacionGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(691, 365);
            this.Controls.Add(this.kuroButton1);
            this.Controls.Add(this.kuroDGV1);
            this.Controls.Add(this.lblRestanteAPagar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFechaRegistrado);
            this.Controls.Add(label2);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.lblDentista);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(label9);
            this.Controls.Add(label7);
            this.Controls.Add(label1);
            this.Name = "PantallaInformacionGeneral";
            this.Text = "InfoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ControlesM.KuroButton kuroButton1;
    }
}
