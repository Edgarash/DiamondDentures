namespace Presentacion.Finanzas
{
    partial class FinanzasVerCompraInsumos
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
            this.btnGenRep = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInsumos = new System.Windows.Forms.DataGridView();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txRegistro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txEsta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txTot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txSubTot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txCant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txPrecUn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConf = new System.Windows.Forms.Button();
            this.txNombr = new System.Windows.Forms.TextBox();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInsumos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label1);
            this.Encabezado.Size = new System.Drawing.Size(1276, 93);
            // 
            // btnGenRep
            // 
            this.btnGenRep.Location = new System.Drawing.Point(99, 12);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(88, 42);
            this.btnGenRep.TabIndex = 31;
            this.btnGenRep.Text = "Generar \r\nReporte";
            this.btnGenRep.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(6, 13);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 40);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "Insumos Comprados";
            // 
            // dtInsumos
            // 
            this.dtInsumos.AllowUserToAddRows = false;
            this.dtInsumos.AllowUserToDeleteRows = false;
            this.dtInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtInsumos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtInsumos.BackgroundColor = System.Drawing.Color.White;
            this.dtInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInsumos.Location = new System.Drawing.Point(12, 193);
            this.dtInsumos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtInsumos.Name = "dtInsumos";
            this.dtInsumos.ReadOnly = true;
            this.dtInsumos.RowHeadersVisible = false;
            this.dtInsumos.Size = new System.Drawing.Size(854, 176);
            this.dtInsumos.TabIndex = 28;
            // 
            // txTotal
            // 
            this.txTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotal.Location = new System.Drawing.Point(555, 376);
            this.txTotal.Multiline = true;
            this.txTotal.Name = "txTotal";
            this.txTotal.ReadOnly = true;
            this.txTotal.Size = new System.Drawing.Size(217, 40);
            this.txTotal.TabIndex = 30;
            this.txTotal.Text = "TOTAL = ";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(779, 374);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(87, 42);
            this.btnPagar.TabIndex = 34;
            this.btnPagar.Text = "Registrar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbBuscar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnGenRep);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 60);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Buscar: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbBuscar
            // 
            this.tbBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(556, 21);
            this.tbBuscar.MaxLength = 20;
            this.tbBuscar.Multiline = true;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(245, 24);
            this.tbBuscar.TabIndex = 49;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Presentacion.Properties.Resources.IconoBuscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(807, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 41);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txRegistro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txEsta);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txTot);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txSubTot);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txCant);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txPrecUn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txDes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnConf);
            this.groupBox2.Controls.Add(this.txNombr);
            this.groupBox2.Location = new System.Drawing.Point(886, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 273);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(201, 209);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(79, 42);
            this.btnCalcular.TabIndex = 64;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 62;
            this.label11.Text = "Registrado";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txRegistro
            // 
            this.txRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRegistro.Location = new System.Drawing.Point(115, 232);
            this.txRegistro.MaxLength = 20;
            this.txRegistro.Multiline = true;
            this.txRegistro.Name = "txRegistro";
            this.txRegistro.Size = new System.Drawing.Size(53, 24);
            this.txRegistro.TabIndex = 61;
            this.txRegistro.Text = "NO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "Estado: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txEsta
            // 
            this.txEsta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txEsta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEsta.Location = new System.Drawing.Point(78, 202);
            this.txEsta.MaxLength = 20;
            this.txEsta.Multiline = true;
            this.txEsta.Name = "txEsta";
            this.txEsta.Size = new System.Drawing.Size(90, 24);
            this.txEsta.TabIndex = 59;
            this.txEsta.Text = "PENDIENTE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Total: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txTot
            // 
            this.txTot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txTot.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTot.Location = new System.Drawing.Point(78, 172);
            this.txTot.MaxLength = 20;
            this.txTot.Multiline = true;
            this.txTot.Name = "txTot";
            this.txTot.ReadOnly = true;
            this.txTot.Size = new System.Drawing.Size(90, 24);
            this.txTot.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "Subtotal: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txSubTot
            // 
            this.txSubTot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txSubTot.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSubTot.Location = new System.Drawing.Point(78, 142);
            this.txSubTot.MaxLength = 20;
            this.txSubTot.Multiline = true;
            this.txSubTot.Name = "txSubTot";
            this.txSubTot.ReadOnly = true;
            this.txSubTot.Size = new System.Drawing.Size(90, 24);
            this.txSubTot.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Cantidad: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txCant
            // 
            this.txCant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCant.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCant.Location = new System.Drawing.Point(115, 112);
            this.txCant.MaxLength = 20;
            this.txCant.Multiline = true;
            this.txCant.Name = "txCant";
            this.txCant.Size = new System.Drawing.Size(53, 24);
            this.txCant.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Precio Unitario: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txPrecUn
            // 
            this.txPrecUn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txPrecUn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrecUn.Location = new System.Drawing.Point(115, 82);
            this.txPrecUn.MaxLength = 20;
            this.txPrecUn.Multiline = true;
            this.txPrecUn.Name = "txPrecUn";
            this.txPrecUn.Size = new System.Drawing.Size(53, 24);
            this.txPrecUn.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Descripción: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txDes
            // 
            this.txDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txDes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDes.Location = new System.Drawing.Point(179, 81);
            this.txDes.MaxLength = 20;
            this.txDes.Multiline = true;
            this.txDes.Name = "txDes";
            this.txDes.Size = new System.Drawing.Size(194, 115);
            this.txDes.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Datos de Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nombre: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(286, 209);
            this.btnConf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(87, 42);
            this.btnConf.TabIndex = 36;
            this.btnConf.Text = "Confirmar";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // txNombr
            // 
            this.txNombr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txNombr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombr.Location = new System.Drawing.Point(78, 52);
            this.txNombr.MaxLength = 20;
            this.txNombr.Multiline = true;
            this.txNombr.Name = "txNombr";
            this.txNombr.Size = new System.Drawing.Size(90, 24);
            this.txNombr.TabIndex = 46;
            // 
            // cbAño
            // 
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbAño.Location = new System.Drawing.Point(156, 162);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(66, 24);
            this.cbAño.TabIndex = 78;
            this.cbAño.Text = "2017";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(112, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = "Año: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMes.Location = new System.Drawing.Point(58, 162);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(47, 24);
            this.cbMes.TabIndex = 76;
            this.cbMes.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 75;
            this.label13.Text = "Mes: ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FinanzasVerCompraInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 425);
            this.Controls.Add(this.cbAño);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.dtInsumos);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FinanzasVerCompraInsumos";
            this.Text = "Insumos Comprados";
            this.Load += new System.EventHandler(this.FinanzasVerCompraInsumos_Load);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.dtInsumos, 0);
            this.Controls.SetChildIndex(this.txTotal, 0);
            this.Controls.SetChildIndex(this.btnPagar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.cbMes, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.cbAño, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInsumos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenRep;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtInsumos;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        protected System.Windows.Forms.TextBox txRegistro;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.TextBox txEsta;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.TextBox txTot;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txSubTot;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox txCant;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox txPrecUn;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox txDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConf;
        protected System.Windows.Forms.TextBox txNombr;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox tbBuscar;
        protected System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label13;
    }
}