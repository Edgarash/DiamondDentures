namespace Presentacion.Finanzas
{
    partial class FinanzasComprarInsumos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.txNom = new System.Windows.Forms.TextBox();
            this.txCant = new System.Windows.Forms.TextBox();
            this.txPreUni = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenRep = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txIdInsumos = new System.Windows.Forms.TextBox();
            this.dtInsumos = new System.Windows.Forms.DataGridView();
            this.IdProveedor = new System.Windows.Forms.Label();
            this.txIdPr = new System.Windows.Forms.TextBox();
            this.txProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtIdCompras = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Encabezado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIdCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Size = new System.Drawing.Size(1076, 93);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Comprar Insumos";
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(97, 20);
            this.txID.Name = "txID";
            this.txID.ReadOnly = true;
            this.txID.Size = new System.Drawing.Size(100, 21);
            this.txID.TabIndex = 14;
            // 
            // txNom
            // 
            this.txNom.Location = new System.Drawing.Point(97, 237);
            this.txNom.Name = "txNom";
            this.txNom.ReadOnly = true;
            this.txNom.Size = new System.Drawing.Size(100, 21);
            this.txNom.TabIndex = 15;
            // 
            // txCant
            // 
            this.txCant.Location = new System.Drawing.Point(443, 237);
            this.txCant.Name = "txCant";
            this.txCant.Size = new System.Drawing.Size(83, 21);
            this.txCant.TabIndex = 17;
            this.txCant.Text = "1";
            // 
            // txPreUni
            // 
            this.txPreUni.Location = new System.Drawing.Point(273, 237);
            this.txPreUni.Name = "txPreUni";
            this.txPreUni.ReadOnly = true;
            this.txPreUni.Size = new System.Drawing.Size(82, 21);
            this.txPreUni.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txIdInsumos);
            this.groupBox1.Controls.Add(this.dtInsumos);
            this.groupBox1.Controls.Add(this.IdProveedor);
            this.groupBox1.Controls.Add(this.txIdPr);
            this.groupBox1.Controls.Add(this.txProveedor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txID);
            this.groupBox1.Controls.Add(this.txPreUni);
            this.groupBox1.Controls.Add(this.txNom);
            this.groupBox1.Controls.Add(this.txCant);
            this.groupBox1.Controls.Add(this.dtIdCompras);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 366);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txTotal);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnGenRep);
            this.groupBox2.Controls.Add(this.btnComprar);
            this.groupBox2.Controls.Add(this.txDesc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(542, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 333);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de compra de insumos:";
            // 
            // txTotal
            // 
            this.txTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotal.Location = new System.Drawing.Point(290, 181);
            this.txTotal.Multiline = true;
            this.txTotal.Name = "txTotal";
            this.txTotal.ReadOnly = true;
            this.txTotal.Size = new System.Drawing.Size(217, 40);
            this.txTotal.TabIndex = 43;
            this.txTotal.Text = "TOTAL = ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Pedido,
            this.ID_Proveedor,
            this.Nombre_Insumo,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(15, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(487, 140);
            this.dataGridView1.TabIndex = 42;
            this.toolTip1.SetToolTip(this.dataGridView1, "Presiona doble click para eliminar elemento.");
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID_Pedido
            // 
            this.ID_Pedido.HeaderText = "ID_Insumo";
            this.ID_Pedido.Name = "ID_Pedido";
            this.ID_Pedido.ReadOnly = true;
            // 
            // ID_Proveedor
            // 
            this.ID_Proveedor.HeaderText = "ID_Proveedor";
            this.ID_Proveedor.Name = "ID_Proveedor";
            this.ID_Proveedor.ReadOnly = true;
            // 
            // Nombre_Insumo
            // 
            this.Nombre_Insumo.HeaderText = "Nombre_Insumo";
            this.Nombre_Insumo.Name = "Nombre_Insumo";
            this.Nombre_Insumo.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Subtotal";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // btnGenRep
            // 
            this.btnGenRep.Location = new System.Drawing.Point(414, 285);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(88, 42);
            this.btnGenRep.TabIndex = 41;
            this.btnGenRep.Text = "Generar \r\nReporte";
            this.btnGenRep.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(320, 285);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(88, 42);
            this.btnComprar.TabIndex = 39;
            this.btnComprar.Text = "Registrar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click_1);
            // 
            // txDesc
            // 
            this.txDesc.Location = new System.Drawing.Point(15, 189);
            this.txDesc.Multiline = true;
            this.txDesc.Name = "txDesc";
            this.txDesc.Size = new System.Drawing.Size(226, 117);
            this.txDesc.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Descripción de compra: ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(438, 31);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 42);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "IdInsumo: ";
            // 
            // txIdInsumos
            // 
            this.txIdInsumos.Location = new System.Drawing.Point(299, 54);
            this.txIdInsumos.Name = "txIdInsumos";
            this.txIdInsumos.ReadOnly = true;
            this.txIdInsumos.Size = new System.Drawing.Size(100, 21);
            this.txIdInsumos.TabIndex = 34;
            // 
            // dtInsumos
            // 
            this.dtInsumos.AllowUserToAddRows = false;
            this.dtInsumos.AllowUserToDeleteRows = false;
            this.dtInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtInsumos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtInsumos.BackgroundColor = System.Drawing.Color.White;
            this.dtInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInsumos.Location = new System.Drawing.Point(24, 114);
            this.dtInsumos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtInsumos.Name = "dtInsumos";
            this.dtInsumos.ReadOnly = true;
            this.dtInsumos.RowHeadersVisible = false;
            this.dtInsumos.Size = new System.Drawing.Size(502, 106);
            this.dtInsumos.TabIndex = 33;
            this.dtInsumos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtInsumos_CellClick);
            // 
            // IdProveedor
            // 
            this.IdProveedor.AutoSize = true;
            this.IdProveedor.Location = new System.Drawing.Point(12, 61);
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.Size = new System.Drawing.Size(79, 16);
            this.IdProveedor.TabIndex = 32;
            this.IdProveedor.Text = "IdProveedor:";
            // 
            // txIdPr
            // 
            this.txIdPr.Location = new System.Drawing.Point(97, 58);
            this.txIdPr.Name = "txIdPr";
            this.txIdPr.ReadOnly = true;
            this.txIdPr.Size = new System.Drawing.Size(100, 21);
            this.txIdPr.TabIndex = 31;
            // 
            // txProveedor
            // 
            this.txProveedor.FormattingEnabled = true;
            this.txProveedor.Location = new System.Drawing.Point(299, 20);
            this.txProveedor.Name = "txProveedor";
            this.txProveedor.Size = new System.Drawing.Size(100, 24);
            this.txProveedor.TabIndex = 29;
            this.txProveedor.SelectedIndexChanged += new System.EventHandler(this.txProveedor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Proveedor: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Precio \r\nUnitario: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantidad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "IdCompra: ";
            // 
            // dtIdCompras
            // 
            this.dtIdCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtIdCompras.Location = new System.Drawing.Point(0, 0);
            this.dtIdCompras.Name = "dtIdCompras";
            this.dtIdCompras.Size = new System.Drawing.Size(10, 10);
            this.dtIdCompras.TabIndex = 30;
            this.dtIdCompras.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 10;
            // 
            // FinanzasComprarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 464);
            this.Controls.Add(this.groupBox1);
            this.Name = "FinanzasComprarInsumos";
            this.Text = "Comprar Insumos";
            this.Load += new System.EventHandler(this.FinanzasComprarInsumos_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIdCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.TextBox txNom;
        private System.Windows.Forms.TextBox txCant;
        private System.Windows.Forms.TextBox txPreUni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtIdCompras;
        private System.Windows.Forms.Label IdProveedor;
        private System.Windows.Forms.TextBox txIdPr;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txIdInsumos;
        private System.Windows.Forms.DataGridView dtInsumos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenRep;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txDesc;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}