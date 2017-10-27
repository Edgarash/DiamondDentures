using System;
using System.Windows.Forms;
using Control;

namespace Presentacion.Reportes
{
  
    class PantallaMenuReportes : Pantalla
    {
        public PantallaMenuReportes()
        {
            InitializeComponent();
        }

        #region GUI

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnRegresar;
        private System.Windows.Forms.TreeView treeView1;

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Proveedores");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Insumos Comprados");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Materiales Comprados");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Insumos Comprados (E)");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Materiales Comprados (E)");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Producto-Materiales");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Requisicion de materiales");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Almacen", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nomina");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Comprobante de nomina");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Gastos");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Materiales");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Ventas Detalladas");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Ventas General");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Finanzas", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.label5);
            this.Encabezado.Size = new System.Drawing.Size(735, 93);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 147);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "rprov";
            treeNode1.Text = "Proveedores";
            treeNode2.Name = "rincomp";
            treeNode2.Text = "Insumos Comprados";
            treeNode3.Name = "rmatcomp";
            treeNode3.Text = "Materiales Comprados";
            treeNode4.Name = "rgastiesp";
            treeNode4.Text = "Insumos Comprados (E)";
            treeNode5.Name = "rgastmesp";
            treeNode5.Text = "Materiales Comprados (E)";
            treeNode6.Name = "rprodmat";
            treeNode6.Text = "Producto-Materiales";
            treeNode7.Name = "rreqmat";
            treeNode7.Text = "Requisicion de materiales";
            treeNode8.Checked = true;
            treeNode8.Name = "nalmacen";
            treeNode8.Text = "Almacen";
            treeNode9.Name = "rnomina";
            treeNode9.Text = "Nomina";
            treeNode10.Name = "rcomnom";
            treeNode10.Text = "Comprobante de nomina";
            treeNode11.Name = "rgastos";
            treeNode11.Text = "Gastos";
            treeNode12.Name = "rmateriales";
            treeNode12.Text = "Materiales";
            treeNode13.Name = "rventas";
            treeNode13.Text = "Ventas Detalladas";
            treeNode14.Name = "rventasgen";
            treeNode14.Text = "Ventas General";
            treeNode15.Checked = true;
            treeNode15.Name = "nfinanzas";
            treeNode15.Text = "Finanzas";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(175, 344);
            this.treeView1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.ImagenSeparador;
            this.pictureBox1.Location = new System.Drawing.Point(12, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 11);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista de reportes";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackgroundImage = global::Presentacion.Properties.Resources.IconoAceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(234, 381);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 80);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Aceptar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.ImagenSeparador;
            this.pictureBox2.Location = new System.Drawing.Point(227, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(461, 10);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Reporte: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripcion: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Menu de reportes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(610, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Regresar";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = global::Presentacion.Properties.Resources.IconoRegresarReportes;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(608, 381);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(80, 80);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // PantallaMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(735, 503);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "PantallaMenuReportes";
            this.Text = "Menu de reportes";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.treeView1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnRegresar, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e) 
            => SeleccionarOpcion(treeView1.SelectedNode.Name);

        private void SeleccionarOpcion(string tipo)
        {
            switch (tipo)
            {
                case "rcomnom":
                    MostrarPantalla(new PantallaVPNominaEmpleado());
                    break;
                case "rnomina":
                    MostrarPantalla(new PantallaVPNominaGeneral());
                    break;
                case "rincomp":
                    MostrarPantalla(new PantallaVPInsCom());
                    break;
                case "rmatcomp":
                    MostrarPantalla(new PantallaVPMatCom());
                    break;
                case "rprov":
                    MostrarPantalla(new PantallaVPProveedores());
                    break;
                case "rgastos":
                    MostrarPantalla(new PantallaVPGastos());
                    break;
                case "rmateriales":
                    MostrarPantalla(new PantallaVPMateriales());
                    break;
                case "rprodmat":
                    MostrarPantalla(new PantallaVPMatProd());
                    break;
                case "rventas":
                    MostrarPantalla(new PantallaVPVentas());
                    break;
                case "rgastiesp":
                    MostrarPantalla(new PantallaGasInEs());
                    break;
                case "rgastmesp":
                    MostrarPantalla(new PantallaGasMatEs());
                    break;
                case "rventasgen":
                    MostrarPantalla(new PantallaVPVentasGeneral());
                    break;
                case "rreqmat":
                    MostrarPantalla(new PantallaVPReqMat());
                    break;
            }
        }

        private void MostrarPantalla<T>(T Pantalla) where T : Form
        {
            Hide();
            Pantalla.ShowDialog();
            Pantalla.Close();
            Show();
            BringToFront();
        }


        private void RegresarPantallaAnterior() => Close();

        private void btnRegresar_Click(object sender, EventArgs e) => RegresarPantallaAnterior();

    }
}
