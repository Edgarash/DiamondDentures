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
        private Label lblTitulo;
        private Label label6;
        private Button btnRegresar;
        private RichTextBox rtbDescripcion;
        private System.Windows.Forms.TreeView treeView1;

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Proveedores");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Insumos Comprados");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Materiales Comprados");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Insumos Comprados (E)");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Materiales Comprados (E)");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Producto-Materiales");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Requisicion de materiales");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Almacen", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Nomina");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Comprobante de nomina");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Gastos");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Materiales");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Ventas Detalladas");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Ventas General");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Finanzas", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
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
            treeNode16.Name = "rprov";
            treeNode16.Text = "Proveedores";
            treeNode17.Name = "rincomp";
            treeNode17.Text = "Insumos Comprados";
            treeNode18.Name = "rmatcomp";
            treeNode18.Text = "Materiales Comprados";
            treeNode19.Name = "rgastiesp";
            treeNode19.Text = "Insumos Comprados (E)";
            treeNode20.Name = "rgastmesp";
            treeNode20.Text = "Materiales Comprados (E)";
            treeNode21.Name = "rprodmat";
            treeNode21.Text = "Producto-Materiales";
            treeNode22.Name = "rreqmat";
            treeNode22.Text = "Requisicion de materiales";
            treeNode23.Checked = true;
            treeNode23.Name = "nalmacen";
            treeNode23.Text = "Almacen";
            treeNode24.Name = "rnomina";
            treeNode24.Text = "Nomina";
            treeNode25.Name = "rcomnom";
            treeNode25.Text = "Comprobante de nomina";
            treeNode26.Name = "rgastos";
            treeNode26.Text = "Gastos";
            treeNode27.Name = "rmateriales";
            treeNode27.Text = "Materiales";
            treeNode28.Name = "rventas";
            treeNode28.Text = "Ventas Detalladas";
            treeNode29.Name = "rventasgen";
            treeNode29.Text = "Ventas General";
            treeNode30.Checked = true;
            treeNode30.Name = "nfinanzas";
            treeNode30.Text = "Finanzas";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(175, 344);
            this.treeView1.TabIndex = 9;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(223, 154);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(82, 18);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Reporte: ";
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
            // rtbDescripcion
            // 
            this.rtbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescripcion.Location = new System.Drawing.Point(227, 192);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(461, 183);
            this.rtbDescripcion.TabIndex = 14;
            this.rtbDescripcion.Text = "";
            // 
            // PantallaMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(735, 503);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
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
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnRegresar, 0);
            this.Controls.SetChildIndex(this.rtbDescripcion, 0);
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

        private void SeleccionarTexto(string nodo)
        {
            switch (nodo)
            {
                case "rcomnom":
                    
                    break;
                case "rnomina":
                    
                    break;
                case "rincomp":
                    
                    break;
                case "rmatcomp":
                    
                    break;
                case "rprov":
                    
                    break;
                case "rgastos":
                    
                    break;
                case "rmateriales":
                    
                    break;
                case "rprodmat":
                    
                    break;
                case "rventas":
                    
                    break;
                case "rgastiesp":
                    
                    break;
                case "rgastmesp":
                    
                    break;
                case "rventasgen":
                    lblTitulo.Text = $"Reporte: Ventas";
                    rtbDescripcion.Text = "Se muestran las ventas que se realizaron en el periodo detallado anteriormente. Para mayor claridad las ventas estan divida por categorias por tipo de producto vendido, donde en cada una de estas se detallan el precio base, los materialies utilizados en la fabricación y el precion de cada uno de estos. En la ultima columna se detallan los importes totales obtenidos por tipo de prodcuto y en general dentro del periodo solicitado";

            
                    break;
                case "rreqmat":
                    
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

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SeleccionarTexto(e.Node.Name);
        }
    }
}
