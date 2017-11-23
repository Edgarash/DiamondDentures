using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Control;
using Entidad;

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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Proveedores");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Insumos Comprados");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Materiales Comprados");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Insumos Comprados (E)");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Materiales Comprados (E)");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Producto-Materiales");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Requisicion de materiales");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Materiales");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Inventarios");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Almacen",
                new System.Windows.Forms.TreeNode[]
                {
                    treeNode1,
                    treeNode2,
                    treeNode3,
                    treeNode4,
                    treeNode5,
                    treeNode6,
                    treeNode7,
                    treeNode8,
                    treeNode9
                });
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nomina");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Comprobante de nomina");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Gastos");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Ventas Detalladas");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Ventas General");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Finanzas",
                new System.Windows.Forms.TreeNode[] {treeNode11, treeNode12, treeNode13, treeNode14, treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Trabajadores");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Otros", new System.Windows.Forms.TreeNode[] {treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Catalogo de Productos");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Catalogo de Productos (Comb.)");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Cortes de Caja");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Detalles del Pedido");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Rendimiento de Empleado");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Metrica del Pedido");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Balance");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Materiales Faltantes");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Materiales Faltantes (n)");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Metrica del Ultimo Pedido");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Laboratoristas Ocupados");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Laboratoristas Desocupados");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Sueldos Promedio");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Productos de mayor valor");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Productos en laboratorio");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Clientes mas valiosos");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Producto más elaborado");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Producto menos elaborado");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Clientes frencuentes");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Facturas");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Forma Pedido");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Nota Terminacion");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Oficio Confirmacion");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Temporal",
                new System.Windows.Forms.TreeNode[] {treeNode38, treeNode39, treeNode40, treeNode41});
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
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
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
            treeNode8.Name = "rmateriales";
            treeNode8.Text = "Materiales";
            treeNode9.Name = "rinventarios";
            treeNode9.Text = "Inventarios";
            treeNode10.Checked = true;
            treeNode10.Name = "nalmacen";
            treeNode10.Text = "Almacen";
            treeNode11.Name = "rnomina";
            treeNode11.Text = "Nomina";
            treeNode12.Name = "rcomnom";
            treeNode12.Text = "Comprobante de nomina";
            treeNode13.Name = "rgastos";
            treeNode13.Text = "Gastos";
            treeNode14.Name = "rventas";
            treeNode14.Text = "Ventas Detalladas";
            treeNode15.Name = "rventasgen";
            treeNode15.Text = "Ventas General";
            treeNode16.Checked = true;
            treeNode16.Name = "nfinanzas";
            treeNode16.Text = "Finanzas";
            treeNode17.Name = "can1";
            treeNode17.Text = "Trabajadores";
            treeNode18.Name = "notros";
            treeNode18.Text = "Otros";
            treeNode19.Name = "can2_1";
            treeNode19.Text = "Catalogo de Productos";
            treeNode20.Name = "can2_1";
            treeNode20.Text = "Catalogo de Productos (Comb.)";
            treeNode21.Name = "can3";
            treeNode21.Text = "Cortes de Caja";
            treeNode22.Name = "can4";
            treeNode22.Text = "Detalles del Pedido";
            treeNode23.Name = "can5";
            treeNode23.Text = "Rendimiento de Empleado";
            treeNode24.Name = "can6";
            treeNode24.Text = "Metrica del Pedido";
            treeNode25.Name = "can7";
            treeNode25.Text = "Balance";
            treeNode26.Name = "can8";
            treeNode26.Text = "Materiales Faltantes";
            treeNode27.Name = "can9";
            treeNode27.Text = "Materiales Faltantes (n)";
            treeNode28.Name = "can10";
            treeNode28.Text = "Metrica del Ultimo Pedido";
            treeNode29.Name = "can11";
            treeNode29.Text = "Laboratoristas Ocupados";
            treeNode30.Name = "can12";
            treeNode30.Text = "Laboratoristas Desocupados";
            treeNode31.Name = "can13";
            treeNode31.Text = "Sueldos Promedio";
            treeNode32.Name = "can14";
            treeNode32.Text = "Productos de mayor valor";
            treeNode33.Name = "can15";
            treeNode33.Text = "Productos en laboratorio";
            treeNode34.Name = "can16";
            treeNode34.Text = "Clientes mas valiosos";
            treeNode35.Name = "can17";
            treeNode35.Text = "Producto más elaborado";
            treeNode36.Name = "can18";
            treeNode36.Text = "Producto menos elaborado";
            treeNode37.Name = "can19";
            treeNode37.Text = "Clientes frencuentes";
            treeNode38.Name = "rfact";
            treeNode38.Text = "Facturas";
            treeNode39.Name = "rformped";
            treeNode39.Text = "Forma Pedido";
            treeNode40.Name = "rnotter";
            treeNode40.Text = "Nota Terminacion";
            treeNode41.Name = "rofcon";
            treeNode41.Text = "Oficio Confirmacion";
            treeNode42.Name = "Node0";
            treeNode42.Text = "Temporal";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[]
            {
                treeNode10,
                treeNode16,
                treeNode18,
                treeNode19,
                treeNode20,
                treeNode21,
                treeNode22,
                treeNode23,
                treeNode24,
                treeNode25,
                treeNode26,
                treeNode27,
                treeNode28,
                treeNode29,
                treeNode30,
                treeNode31,
                treeNode32,
                treeNode33,
                treeNode34,
                treeNode35,
                treeNode36,
                treeNode37,
                treeNode42
            });
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
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((byte) (0)));
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
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
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
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((byte) (0)));
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
            this.rtbDescripcion.Location = new System.Drawing.Point(226, 192);
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
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e) => SeleccionarOpcion(treeView1.SelectedNode);

        private void SeleccionarOpcion(TreeNode tipo)
        {
            string sql;
            Dictionary<string, ParametroReporte> _estadoColumnas;
            Hide();
            switch (tipo.Name)
            {
                case "rcomnom":
                    ManejadorReportes.MostrarPantalla(new PantallaVPNominaEmpleado());
                    break;
                case "rnomina":
                    ManejadorReportes.MostrarPantalla(new PantallaVPNominaGeneral());
                    break;
                case "rincomp":
                    ManejadorReportes.MostrarPantalla(new PantallaVPInsCom());
                    break;
                case "rmatcomp":
                    ManejadorReportes.MostrarPantalla(this, new PantallaVPListadoGen<ReporteMaterialesComprados>("Materiales Comprados"));
                    break;
                case "rprov":
                    _estadoColumnas = new Dictionary<string, ParametroReporte>
                    {
                        {"ID Prov.", new ParametroReporte("", "ID Prov.", "proveedores.IDProveedor")},
                        {"Nombre", new ParametroReporte("", "Nombre", "proveedores.Nombre")},
                        {"Descripcion", new ParametroReporte("", "Descripcion", "proveedores.Descripcion")},
                        {"Direcion", new ParametroReporte("", "Direcion", "proveedores.Direccion")},
                        {"Telefono", new ParametroReporte("", "Telefono", "proveedores.Telefono")},
                        {"Correo", new ParametroReporte("", "Correo", "proveedores.Correo")}
                    };
                    sql = "FROM proveedores;";
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoPer<ReporteProveedores>(tipo.Text, _estadoColumnas, sql, 6));
                    break;
                case "rgastos":
                    ManejadorReportes.MostrarPantalla(new PantallaVPGastos());
                    break;
                case "rmateriales":
                    _estadoColumnas = new Dictionary<string, ParametroReporte>
                    {
                        {"ID Mat", new ParametroReporte("", "ID Mat", "material.IDMaterial")},
                        {"Nombre", new ParametroReporte("", "Nombre", "material.Nombre")},
                        {"Descripcion", new ParametroReporte("", "Descripcion", "material.Descripcion")},
                        {"Precio Compra", new ParametroReporte("", "Precio Compra", "material.PrecioCompra")},
                        {"Unidad Medida", new ParametroReporte("", "Unidad Medida", "material.UnidadMedida")},
                        {"Cantidad", new ParametroReporte("", "Cantidad", "material.Cantidad")},
                        {"Proveedor", new ParametroReporte("", "Proveedor", "proveedores.Nombre")}
                    };
                    sql = "FROM material,proveedores WHERE proveedores.IDProveedor=material.Proveedor;";
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoPer<ReporteMateriales>(tipo.Text, _estadoColumnas, sql, 7));
                    break;
                case "rprodmat":
                    ManejadorReportes.MostrarPantalla(new PantallaVPMatProd());
                    break;
                case "rinventarios":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<ReporteInventarios>(tipo.Text));
                    break;
                case "rventas":
                    ManejadorReportes.MostrarPantalla(new PantallaVPVentas());
                    break;
                case "rgastiesp":
                    ManejadorReportes.MostrarPantalla(new PantallaGasInEs());
                    break;
                case "rgastmesp":
                    ManejadorReportes.MostrarPantalla(new PantallaGasMatEs());
                    break;
                case "rventasgen":
                    ManejadorReportes.MostrarPantalla(new PantallaVPVentasGeneral());
                    break;
                case "rreqmat":
                    ManejadorReportes.MostrarPantalla(new PantallaVPReqMat());
                    break;
                case "can1":
                    _estadoColumnas = new Dictionary<string, ParametroReporte>
                    {
                        {"Numero Empleado", new ParametroReporte("", "Numero Empleado", "usuario.N_Empleado")},
                        {"Login", new ParametroReporte("", "Login", "usuario.Login")},
                        {"Nombre", new ParametroReporte("", "Nombre", "usuario.Nombre")},
                        {"Apellido", new ParametroReporte("", "Apellido", "usuario.Apellidos")},
                        {"Departamento", new ParametroReporte("", "Departamento", "usuario.Departamento")},
                        {"Puesto", new ParametroReporte("", "Puesto", "usuario.Puesto")},
                        {"Email", new ParametroReporte("", "Email", "usuario.Email")}
                    };
                    sql = "FROM usuario WHERE usuario.Activo=1 ORDER BY usuario.Departamento ASC";
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoPer<CAN1_Trabajadores>(tipo.Text, _estadoColumnas, sql, 7));
                    break;
                case "can2_1":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN2_Catalogo>(tipo.Text));
                    break;
                case "can2_2":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN2_Combinaciones>(tipo.Text));
                    break;
                case "can3":
                    _estadoColumnas = new Dictionary<string, ParametroReporte>
                    {
                        {"Folio", new ParametroReporte("", "Folio", "cortecaja.FolioCorte")},
                        {"Fecha", new ParametroReporte("", "Fecha", "cortecaja.Fecha")},
                        {"Empleado", new ParametroReporte("", "Empleado", "cortecaja.Empleado")},
                        {"Fondo Caja", new ParametroReporte("", "Fondo Caja", "cortecaja.FondoCaja")},
                        {"Entrada Efectivo", new ParametroReporte("", "Entrada Efectivo", "cortecaja.EntradaEfectivo")},
                        {"Salida Efectivo", new ParametroReporte("", "Salida Efectivo", "cortecaja.SalidasEfectivo")},
                        {"Ganancia", new ParametroReporte("", "Ganancia", "cortecaja.Ganancia")},
                        {"Num. Ventas", new ParametroReporte("", "Num. Ventas", "cortecaja.NumVentas")}
                    };
                    sql = "FROM cortecaja;";
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoPer<CAN3_CorteCaja>(tipo.Text, _estadoColumnas, sql, 8));
                    break;
                case "can4":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN4_NotPed>(tipo.Text));
                    break;
                case "can5":
                    _estadoColumnas = new Dictionary<string, ParametroReporte>
                    {
                        {"Login", new ParametroReporte("", "Login", "v_can5_emplab.Login")},
                        {"Nombre", new ParametroReporte("", "Nombre", "v_can5_emplab.Nombre")},
                        {"Apellidos", new ParametroReporte("", "Apellidos", "v_can5_emplab.Apellidos")},
                        {"Edad", new ParametroReporte("", "Edad", "v_can5_emplab.Edad")},
                        {"Antiguedad", new ParametroReporte("", "Antiguedad", "v_can5_emplab.`Antigüedad`")},
                        {"Ped. Ultimo Mes", new ParametroReporte("", "Ped. Ultimo Mes", "v_can5_emplab.`Ped. Último Mes`")},
                        {"Pedidos Asignados", new ParametroReporte("", "Pedidos Asignados", "v_can5_emplab.`Pedidos Asignados`")},
                        {"Costo Pedidos", new ParametroReporte("", "Costo Pedidos", "v_can5_emplab.`Costo Pedidos`")},
                        {"Salario Diario", new ParametroReporte("", "Salario Diario", "v_can5_emplab.`Salario Diario`")},
                        {"Salario Mensual", new ParametroReporte("", "Salario Mensual", "v_can5_emplab.`Salario Mensual`")}
                    };
                    sql = "FROM v_can5_emplab";
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoPer<CAN5_EmpLabPer>(tipo.Text, _estadoColumnas, sql, 10));
                    break;
                case "can6":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN6_Metrica>(tipo.Text));
                    break;
                case "can7":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN7_Balance>(tipo.Text));
                    break;
                case "can8":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN8_ReporteFaltantes>(tipo.Text));
                    break;
                case "can9":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN9_ReporteFaltantesDiferenteCero>(tipo.Text));
                    break;
                case "can10":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN10_MetUltPed>(tipo.Text));
                    break;
                case "can11":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN11_EmplDes>(tipo.Text));
                    break;
                case "can12":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN12_EmplPedTerm>(tipo.Text));
                    break;
                case "can13":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN13_ConsLibre>(tipo.Text));
                    break;
                case "can14":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN14_ProductoCaro>(tipo.Text));
                    break;
                case "can15":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN15_ProdLab>(tipo.Text));
                    break;
                case "can16":
                    _estadoColumnas = new Dictionary<string, ParametroReporte>
                    {
                        {"Nombre", new ParametroReporte("", "Nombre", "dentista.Nombre")},
                        {"Apellidos", new ParametroReporte("", "Apellidos", "dentista.Apellidos")},
                        {"Cedula", new ParametroReporte("", "Cedula", "dentista.Cedula")},
                        {"Tel. Of.", new ParametroReporte("", "Tel. Of.", "dentista.TelOficina")},
                        {"Email", new ParametroReporte("", "Email", "dentista.Email")},
                        {"F. Alta", new ParametroReporte("", "F. Alta", "dentista.FechaAlta")},
                        {"Total", new ParametroReporte("", "Total", "Sum(ventas.Importe)")}
                    };
                    sql =
                        "FROM ventas LEFT JOIN dentista ON dentista.Cedula=ventas.Cedula GROUP BY dentista.Nombre,dentista.Apellidos,dentista.Cedula LIMIT 20;";
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoPer<CAN16_DentMasGastan>(tipo.Text, _estadoColumnas, sql, 7));
                    break;
                case "can17":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN17_ProdMasElab>(tipo.Text));
                    break;
                case "can18":
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoGen<CAN18_ProdMenosElab>(tipo.Text));
                    break;
                case "can19":
                    _estadoColumnas = new Dictionary<string, ParametroReporte>
                    {
                        {"Nombre", new ParametroReporte("", "Nombre", "dentista.Nombre")},
                        {"Apellidos", new ParametroReporte("", "Apellidos", "dentista.Apellidos")},
                        {"Cedula", new ParametroReporte("", "Cedula", "dentista.Cedula")},
                        {"Tel. Of.", new ParametroReporte("", "Tel. Of.", "dentista.TelOficina")},
                        {"Email", new ParametroReporte("", "Email", "dentista.Email")},
                        {"F. Alta", new ParametroReporte("", "F. Alta", "dentista.FechaAlta")},
                        {"Total", new ParametroReporte("", "Total", "Count(ventas.IDVenta)")}
                    };
                    sql =
                        "FROM ventas LEFT JOIN dentista ON dentista.Cedula=ventas.Cedula GROUP BY dentista.Nombre,dentista.Apellidos,dentista.Cedula LIMIT 20;";
                    ManejadorReportes.MostrarPantalla(new PantallaVPListadoPer<CAN19_DentMasCompran>(tipo.Text, _estadoColumnas, sql, 7));
                    break;
                case "rfact":
                    ManejadorReportes.MostrarPantalla(new PantallaContabilidad());
                    break;
                case "rformped":
                    ManejadorReportes.MostrarPantalla(new PantallaFormaPedido());
                    break;
                case "rnotter":
                    ManejadorReportes.MostrarPantalla(new PantallaNotaTerminacion());
                    break;
                case "rofcon":
                    ManejadorReportes.MostrarPantalla(new PantallaOficioConfirmacion());
                    break;
            }
            Show();
            BringToFront();
        }

        private void SeleccionarTexto(TreeNode nodo)
        {
            lblTitulo.Text = nodo.Text;
            rtbDescripcion.Text = string.Empty;
            switch (nodo.Name)
            {
                case "rcomnom":
                    rtbDescripcion.Text = "Se muestrar el comprobante de nomina del trabajador correspondiente";
                    break;
                case "rnomina":
                    rtbDescripcion.Text = "Se muestrar la nomina general donde se detallan informacion con respecto al pago de los trabajadores";
                    break;
                case "rincomp":
                    rtbDescripcion.Text = "Se muestra una lista de los insumos comprados";
                    break;
                case "rmatcomp":
                    rtbDescripcion.Text = "Se muestra una lista de los materiales comprados";
                    break;
                case "rprov":
                    rtbDescripcion.Text = "Se muestrar la lista de proveedores a los cuales se les ha comprado material";
                    break;
                case "rgastos":
                    rtbDescripcion.Text = "Se muestra la lista de gastos realizados por la emprese";
                    break;
                case "rmateriales":
                    rtbDescripcion.Text = "Se muestra la lista de materiales manejados por la empresa";
                    break;
                case "rprodmat":
                    rtbDescripcion.Text = "Se muestra la relacion entre materiales y productos";
                    break;
                case "rventas":
                    rtbDescripcion.Text =
                        "Se muestran las ventas que se realizaron en el periodo detallado anteriormente. Las ventas que se muestran estan divida por su id de venta, donde en cada una de estas, se muestra un encabzado con los detalles propios de la venta y en la parte inferior se detallan la informacion de los productos vendidos en dicha venta. Informacion del producto tal como su id, su nombre, su precio base, los materialies utilizados en su fabricación y el precio de cada uno de estos.";
                    break;
                case "rgastiesp":
                    rtbDescripcion.Text = "Se muestra la lista de gastos con respecto a un insumos comprado en particular";
                    break;
                case "rgastmesp":
                    rtbDescripcion.Text = "Se muestra la lista de gastos con respecto a un material comprado en particular";
                    break;
                case "rventasgen":
                    rtbDescripcion.Text =
                        "Se muestran las ventas que se realizaron en el periodo detallado anteriormente. Para mayor claridad las ventas estan divida por categorias por tipo de producto vendido, donde en cada una de estas se detallan el precio base, los materialies utilizados en la fabricación y el precion de cada uno de estos. En la ultima columna se detallan los importes totales obtenidos por tipo de prodcuto y en general dentro del periodo solicitado";
                    break;
                case "rreqmat":
                    rtbDescripcion.Text =
                        "Se muestra un comprobante para el ingreso de materiales al almacen donde se detalla que materiales y sus cantidades fueron recibidas.";
                    break;
                case "rtrabajadores":
                    rtbDescripcion.Text = "Se muestra una lista con los trabajadores registrados en el sistema.";
                    break;
                case "rinventarios":
                    rtbDescripcion.Text = "Se muestra una lista con los materiales registrados en el sistema.";
                    break;
                case "can1":
                    rtbDescripcion.Text = "Se muestra una lista con la informacion de los trabajadores";
                    break;
                case "can2_1":
                    rtbDescripcion.Text = "Se muestran las combinaciones con las que se puede fabricar un producto.";
                    break;
                case "can2_2":
                    rtbDescripcion.Text = "Se muestran las combinaciones con las que se puede fabricar un producto actualmente.";
                    break;
                case "can3":
                    rtbDescripcion.Text = "Se muestran todos los cortes de caja realizados";
                    break;
                case "can4":
                    rtbDescripcion.Text = "Se muestran todos los detalles del ultimo pedido.";
                    break;
                case "can5":
                    rtbDescripcion.Text = "Se muestra informacion relacionada con el rendimiiento de los trabajadores.";
                    break;
                case "can6":
                    rtbDescripcion.Text = "Se muestra informacion acerca del tiempo que transcurre entre cada fase";
                    break;
                case "can7":
                    rtbDescripcion.Text = "Se muestra el balance";
                    break;
                case "can8":
                    rtbDescripcion.Text = "Se muestra el invetario materiales de pedidos no terminados";
                    break;
                case "can9":
                    rtbDescripcion.Text = "Se muestra el invetario materiales de pedidos no terminados sin mostrar stock en 0";
                    break;
                case "can10":
                    rtbDescripcion.Text = "Se muestra informacion acerca del tiempo que transcurre entre cada fase e informacion del ultimo pedido.";
                    break;
                case "can11":
                    rtbDescripcion.Text = "Se muestra la lista de empleados de laboratorio con pedidos pendientes.";
                    break;
                case "can12":
                    rtbDescripcion.Text = "Se muestra la lista de empleados de laboratorio sin pedidos pendientes.";
                    break;
                case "can13":
                    rtbDescripcion.Text = "Se muestra la lista del salario promedio de cada departamento.";
                    break;
                case "can14":
                    rtbDescripcion.Text = "Se muestra la lista de los productos mas caros y quien los compro.";
                    break;
                case "can15":
                    rtbDescripcion.Text = "Se muestra la lista de productos que estan siendo elaborados por laboratorio.";
                    break;
                case "can16":
                    rtbDescripcion.Text = "Se muestra la lista de dentistas que más han gastado en productos.";
                    break;
                case "can17":
                    rtbDescripcion.Text = "Se muestra la lista de productos más elaborados por laboratorio.";
                    break;
                case "can18":
                    rtbDescripcion.Text = "Se muestra la lista de productos menos elaborados por laboratorio.";
                    break;
                case "can19":
                    rtbDescripcion.Text = "Se muestra la lista de dentistas que mas productos han comprado.";
                    break;
            }
        }

        

        private void RegresarPantallaAnterior() => Close();

        private void btnRegresar_Click(object sender, EventArgs e) => RegresarPantallaAnterior();

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SeleccionarTexto(e.Node);
        }
    }
}