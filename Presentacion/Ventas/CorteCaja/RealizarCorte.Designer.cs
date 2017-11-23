using Validaciones;

namespace Presentacion.Ventas.CorteCaja
{
    partial class RealizarCorte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.tbFondo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kuroDGV1 = new ControlesM.KuroDGV();
            this.btnRegistrar = new ControlesM.KuroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCheque = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEfectivoEnCaja = new System.Windows.Forms.Label();
            this.kuroButton1 = new ControlesM.KuroButton();
            this.tbComentarios = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.tableLayoutPanel8.SetColumnSpan(this.lblFecha, 5);
            this.lblFecha.Location = new System.Drawing.Point(105, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(288, 20);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "VIERNES 27 DE OCTUBRE DEL 2017";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empleado:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.tableLayoutPanel8.SetColumnSpan(this.lblEmpleado, 5);
            this.lblEmpleado.Location = new System.Drawing.Point(105, 30);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(288, 20);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "EDGAR MICHEL CISNEROS GARCIA";
            // 
            // tbFondo
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.tbFondo, 2);
            this.tbFondo.Location = new System.Drawing.Point(105, 63);
            this.tbFondo.Name = "tbFondo";
            this.tbFondo.Size = new System.Drawing.Size(132, 26);
            this.tbFondo.TabIndex = 1;
            this.tbFondo.TextChanged += new System.EventHandler(this.tbFondo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fondo Caja:";
            // 
            // kuroDGV1
            // 
            this.kuroDGV1.AllowUserToAddRows = false;
            this.kuroDGV1.AllowUserToDeleteRows = false;
            this.kuroDGV1.AllowUserToResizeRows = false;
            this.kuroDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kuroDGV1.BackgroundColor = System.Drawing.Color.White;
            this.kuroDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel8.SetColumnSpan(this.kuroDGV1, 9);
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
            this.kuroDGV1.Size = new System.Drawing.Size(867, 162);
            this.kuroDGV1.TabIndex = 2;
            this.kuroDGV1.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(750, 265);
            this.btnRegistrar.Name = "btnRegistrar";
            this.tableLayoutPanel8.SetRowSpan(this.btnRegistrar, 2);
            this.btnRegistrar.Size = new System.Drawing.Size(120, 50);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Efectivo:";
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Location = new System.Drawing.Point(105, 258);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(64, 20);
            this.lblEfectivo.TabIndex = 0;
            this.lblEfectivo.Text = "XXXXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tarjeta:";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(243, 258);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(64, 20);
            this.lblTarjeta.TabIndex = 0;
            this.lblTarjeta.Text = "XXXXX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cheque:";
            // 
            // lblCheque
            // 
            this.lblCheque.AutoSize = true;
            this.lblCheque.Location = new System.Drawing.Point(391, 258);
            this.lblCheque.Name = "lblCheque";
            this.lblCheque.Size = new System.Drawing.Size(64, 20);
            this.lblCheque.TabIndex = 0;
            this.lblCheque.Text = "XXXXX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(462, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Ventas:";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(553, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(64, 20);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "XXXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Efectivo Caja:";
            // 
            // lblEfectivoEnCaja
            // 
            this.lblEfectivoEnCaja.AutoSize = true;
            this.lblEfectivoEnCaja.Location = new System.Drawing.Point(553, 30);
            this.lblEfectivoEnCaja.Name = "lblEfectivoEnCaja";
            this.lblEfectivoEnCaja.Size = new System.Drawing.Size(64, 20);
            this.lblEfectivoEnCaja.TabIndex = 0;
            this.lblEfectivoEnCaja.Text = "XXXXX";
            // 
            // kuroButton1
            // 
            this.kuroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kuroButton1.BackColor = System.Drawing.Color.White;
            this.kuroButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.kuroButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kuroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kuroButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kuroButton1.ForeColor = System.Drawing.Color.Black;
            this.kuroButton1.Location = new System.Drawing.Point(750, 3);
            this.kuroButton1.Name = "kuroButton1";
            this.tableLayoutPanel8.SetRowSpan(this.kuroButton1, 3);
            this.kuroButton1.Size = new System.Drawing.Size(120, 50);
            this.kuroButton1.TabIndex = 4;
            this.kuroButton1.Text = "Arqueo";
            this.kuroButton1.UseVisualStyleBackColor = false;
            this.kuroButton1.Click += new System.EventHandler(this.btnArqueo_Click);
            // 
            // tbComentarios
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.tbComentarios, 7);
            this.tbComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbComentarios.Location = new System.Drawing.Point(3, 291);
            this.tbComentarios.Name = "tbComentarios";
            this.tbComentarios.Size = new System.Drawing.Size(544, 26);
            this.tbComentarios.TabIndex = 5;
            this.tbComentarios.Text = "SIN COMENTARIOS";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 9;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.tbComentarios, 0, 5);
            this.tableLayoutPanel8.Controls.Add(this.btnRegistrar, 8, 4);
            this.tableLayoutPanel8.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.lblEfectivo, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.kuroButton1, 8, 0);
            this.tableLayoutPanel8.Controls.Add(this.kuroDGV1, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.tbFondo, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.lblEmpleado, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblFecha, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label7, 2, 4);
            this.tableLayoutPanel8.Controls.Add(this.lblTarjeta, 3, 4);
            this.tableLayoutPanel8.Controls.Add(this.label9, 4, 4);
            this.tableLayoutPanel8.Controls.Add(this.lblCheque, 5, 4);
            this.tableLayoutPanel8.Controls.Add(this.lblVentas, 7, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblEfectivoEnCaja, 7, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblDiferencia, 7, 2);
            this.tableLayoutPanel8.Controls.Add(this.label11, 6, 0);
            this.tableLayoutPanel8.Controls.Add(this.label3, 6, 1);
            this.tableLayoutPanel8.Controls.Add(this.label6, 6, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 6;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(873, 318);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Location = new System.Drawing.Point(553, 60);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(64, 20);
            this.lblDiferencia.TabIndex = 0;
            this.lblDiferencia.Text = "XXXXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Diferencia:";
            // 
            // RealizarCorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 318);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Name = "RealizarCorte";
            this.Text = "RealizarCorte";
            ((System.ComponentModel.ISupportInitialize)(this.kuroDGV1)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox tbFondo;
        private System.Windows.Forms.Label label4;
        private ControlesM.KuroDGV kuroDGV1;
        private ControlesM.KuroButton btnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCheque;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEfectivoEnCaja;
        private ControlesM.KuroButton kuroButton1;
        private System.Windows.Forms.TextBox tbComentarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDiferencia;
    }
}