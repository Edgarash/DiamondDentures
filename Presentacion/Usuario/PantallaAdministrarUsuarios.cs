using Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Usuario
{
    class PantallaAdministrarUsuarios : Pantalla
    {
        private System.Windows.Forms.DataGridView dgvDatos;
        protected System.Windows.Forms.Label lblPantallaUsuario;
        protected System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.Button btnModificarUsuario;
        InterfaceUsuario Interface;
        public bool cerrar = false;
        private Label lblInfo;
        private Button btnAgregarUsuario;
        private Button btnEliminarUsuario;
        private Button btnAgregarTarjeta;
        private Button btnModificarTarjeta;
        private Button btnEliminarTarjeta;
        private Label lblEliminarUsuario;
        private Label lblModificarUsuario;
        private Label lblAgregarTarjeta;
        private Label lblModificarTarjeta;
        private Label lblEliminarTarjeta;
        private Label lblAgregarUsuario;
        private Button btnRegresar;
        private Button btnActivarUsuario;
        private Label lblActivarUsuario;
        string Usuario;

        public PantallaAdministrarUsuarios(string user) : base()
        {
            InitializeComponent();
            ActualizarData();
            Usuario = user;
            Interface = new InterfaceUsuario(this);
        }

        private void InitializeComponent()
        {
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblPantallaUsuario = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarTarjeta = new System.Windows.Forms.Button();
            this.btnModificarTarjeta = new System.Windows.Forms.Button();
            this.btnEliminarTarjeta = new System.Windows.Forms.Button();
            this.lblEliminarUsuario = new System.Windows.Forms.Label();
            this.lblModificarUsuario = new System.Windows.Forms.Label();
            this.lblAgregarTarjeta = new System.Windows.Forms.Label();
            this.lblModificarTarjeta = new System.Windows.Forms.Label();
            this.lblEliminarTarjeta = new System.Windows.Forms.Label();
            this.lblAgregarUsuario = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActivarUsuario = new System.Windows.Forms.Button();
            this.lblActivarUsuario = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.btnRegresar);
            this.Encabezado.Controls.Add(this.pbIcono);
            this.Encabezado.Controls.Add(this.lblPantallaUsuario);
            this.Encabezado.Size = new System.Drawing.Size(611, 79);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 165);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(587, 262);
            this.dgvDatos.TabIndex = 9;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDatos_CellFormatting);
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.AutoSize = true;
            this.lblPantallaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblPantallaUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantallaUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPantallaUsuario.Location = new System.Drawing.Point(82, 27);
            this.lblPantallaUsuario.Name = "lblPantallaUsuario";
            this.lblPantallaUsuario.Size = new System.Drawing.Size(226, 24);
            this.lblPantallaUsuario.TabIndex = 34;
            this.lblPantallaUsuario.Text = "Administrar Usuarios";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImage = Properties.Resources.IconoUsuario;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcono.Location = new System.Drawing.Point(19, 8);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(60, 60);
            this.pbIcono.TabIndex = 35;
            this.pbIcono.TabStop = false;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackgroundImage = global::Presentacion.Properties.Resources.IconoEditarUsuario;
            this.btnModificarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Location = new System.Drawing.Point(12, 451);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(49, 50);
            this.btnModificarUsuario.TabIndex = 33;
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            this.btnModificarUsuario.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnModificarUsuario.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(8, 132);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(251, 24);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.Text = "Seleccionar un usuario:";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackgroundImage = global::Presentacion.Properties.Resources.IconoAgregarUsuario;
            this.btnAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(493, 82);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(49, 50);
            this.btnAgregarUsuario.TabIndex = 34;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            this.btnAgregarUsuario.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnAgregarUsuario.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackgroundImage = global::Presentacion.Properties.Resources.IconoEliminarUsuario;
            this.btnEliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(226, 451);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(49, 50);
            this.btnEliminarUsuario.TabIndex = 35;
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            this.btnEliminarUsuario.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnEliminarUsuario.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // btnAgregarTarjeta
            // 
            this.btnAgregarTarjeta.BackgroundImage = global::Presentacion.Properties.Resources.IconoAñadirTarjeta;
            this.btnAgregarTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnAgregarTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTarjeta.Location = new System.Drawing.Point(333, 451);
            this.btnAgregarTarjeta.Name = "btnAgregarTarjeta";
            this.btnAgregarTarjeta.Size = new System.Drawing.Size(49, 50);
            this.btnAgregarTarjeta.TabIndex = 36;
            this.btnAgregarTarjeta.UseVisualStyleBackColor = true;
            this.btnAgregarTarjeta.Click += new System.EventHandler(this.btnAgregarTarjeta_Click);
            this.btnAgregarTarjeta.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnAgregarTarjeta.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // btnModificarTarjeta
            // 
            this.btnModificarTarjeta.BackgroundImage = global::Presentacion.Properties.Resources.IconoEditarTarjeta;
            this.btnModificarTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnModificarTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTarjeta.Location = new System.Drawing.Point(440, 451);
            this.btnModificarTarjeta.Name = "btnModificarTarjeta";
            this.btnModificarTarjeta.Size = new System.Drawing.Size(49, 50);
            this.btnModificarTarjeta.TabIndex = 37;
            this.btnModificarTarjeta.UseVisualStyleBackColor = true;
            this.btnModificarTarjeta.Click += new System.EventHandler(this.btnModificarTarjeta_Click);
            this.btnModificarTarjeta.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnModificarTarjeta.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // btnEliminarTarjeta
            // 
            this.btnEliminarTarjeta.BackgroundImage = global::Presentacion.Properties.Resources.IconoEliminaTarjeta;
            this.btnEliminarTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarTarjeta.FlatAppearance.BorderSize = 0;
            this.btnEliminarTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTarjeta.Location = new System.Drawing.Point(547, 451);
            this.btnEliminarTarjeta.Name = "btnEliminarTarjeta";
            this.btnEliminarTarjeta.Size = new System.Drawing.Size(49, 50);
            this.btnEliminarTarjeta.TabIndex = 38;
            this.btnEliminarTarjeta.UseVisualStyleBackColor = true;
            this.btnEliminarTarjeta.Click += new System.EventHandler(this.btnEliminarTarjeta_Click);
            this.btnEliminarTarjeta.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnEliminarTarjeta.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblEliminarUsuario
            // 
            this.lblEliminarUsuario.AutoSize = true;
            this.lblEliminarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEliminarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEliminarUsuario.Location = new System.Drawing.Point(221, 505);
            this.lblEliminarUsuario.Name = "lblEliminarUsuario";
            this.lblEliminarUsuario.Size = new System.Drawing.Size(62, 30);
            this.lblEliminarUsuario.TabIndex = 39;
            this.lblEliminarUsuario.Text = "Eliminar\r\nUsuario";
            this.lblEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModificarUsuario
            // 
            this.lblModificarUsuario.AutoSize = true;
            this.lblModificarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModificarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblModificarUsuario.Location = new System.Drawing.Point(9, 504);
            this.lblModificarUsuario.Name = "lblModificarUsuario";
            this.lblModificarUsuario.Size = new System.Drawing.Size(58, 30);
            this.lblModificarUsuario.TabIndex = 40;
            this.lblModificarUsuario.Text = "Editar\r\nUsuario";
            this.lblModificarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgregarTarjeta
            // 
            this.lblAgregarTarjeta.AutoSize = true;
            this.lblAgregarTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarTarjeta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarTarjeta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAgregarTarjeta.Location = new System.Drawing.Point(328, 504);
            this.lblAgregarTarjeta.Name = "lblAgregarTarjeta";
            this.lblAgregarTarjeta.Size = new System.Drawing.Size(60, 30);
            this.lblAgregarTarjeta.TabIndex = 41;
            this.lblAgregarTarjeta.Text = "Agregar\r\nTarjeta";
            this.lblAgregarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModificarTarjeta
            // 
            this.lblModificarTarjeta.AutoSize = true;
            this.lblModificarTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModificarTarjeta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarTarjeta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblModificarTarjeta.Location = new System.Drawing.Point(436, 504);
            this.lblModificarTarjeta.Name = "lblModificarTarjeta";
            this.lblModificarTarjeta.Size = new System.Drawing.Size(54, 30);
            this.lblModificarTarjeta.TabIndex = 42;
            this.lblModificarTarjeta.Text = "Editar\r\nTarjeta";
            this.lblModificarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEliminarTarjeta
            // 
            this.lblEliminarTarjeta.AutoSize = true;
            this.lblEliminarTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEliminarTarjeta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarTarjeta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEliminarTarjeta.Location = new System.Drawing.Point(539, 504);
            this.lblEliminarTarjeta.Name = "lblEliminarTarjeta";
            this.lblEliminarTarjeta.Size = new System.Drawing.Size(62, 30);
            this.lblEliminarTarjeta.TabIndex = 43;
            this.lblEliminarTarjeta.Text = "Eliminar\r\nTarjeta";
            this.lblEliminarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgregarUsuario
            // 
            this.lblAgregarUsuario.AutoSize = true;
            this.lblAgregarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAgregarUsuario.Location = new System.Drawing.Point(488, 132);
            this.lblAgregarUsuario.Name = "lblAgregarUsuario";
            this.lblAgregarUsuario.Size = new System.Drawing.Size(58, 30);
            this.lblAgregarUsuario.TabIndex = 44;
            this.lblAgregarUsuario.Text = "Crear\r\nUsuario";
            this.lblAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = global::Presentacion.Properties.Resources.IconoRegresar;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(19, 8);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(60, 60);
            this.btnRegresar.TabIndex = 45;
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // btnActivarUsuario
            // 
            this.btnActivarUsuario.BackgroundImage = global::Presentacion.Properties.Resources.IconoSalir;
            this.btnActivarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActivarUsuario.FlatAppearance.BorderSize = 0;
            this.btnActivarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnActivarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnActivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarUsuario.Location = new System.Drawing.Point(119, 451);
            this.btnActivarUsuario.Name = "btnActivarUsuario";
            this.btnActivarUsuario.Size = new System.Drawing.Size(49, 50);
            this.btnActivarUsuario.TabIndex = 35;
            this.btnActivarUsuario.UseVisualStyleBackColor = true;
            this.btnActivarUsuario.Click += new System.EventHandler(this.btnActivarUsuario_Click);
            this.btnActivarUsuario.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnActivarUsuario.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // lblActivarUsuario
            // 
            this.lblActivarUsuario.AutoSize = true;
            this.lblActivarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblActivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblActivarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivarUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblActivarUsuario.Location = new System.Drawing.Point(113, 505);
            this.lblActivarUsuario.Name = "lblActivarUsuario";
            this.lblActivarUsuario.Size = new System.Drawing.Size(58, 30);
            this.lblActivarUsuario.TabIndex = 39;
            this.lblActivarUsuario.Text = "Activar\r\nUsuario";
            this.lblActivarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PantallaAdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(611, 540);
            this.Controls.Add(this.lblAgregarUsuario);
            this.Controls.Add(this.lblAgregarTarjeta);
            this.Controls.Add(this.btnAgregarTarjeta);
            this.Controls.Add(this.lblEliminarTarjeta);
            this.Controls.Add(this.lblModificarTarjeta);
            this.Controls.Add(this.lblModificarUsuario);
            this.Controls.Add(this.lblActivarUsuario);
            this.Controls.Add(this.lblEliminarUsuario);
            this.Controls.Add(this.btnEliminarTarjeta);
            this.Controls.Add(this.btnModificarTarjeta);
            this.Controls.Add(this.btnActivarUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvDatos);
            this.Name = "PantallaAdministrarUsuarios";
            this.Text = "Administrar Usuarios";
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Controls.SetChildIndex(this.dgvDatos, 0);
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.btnModificarUsuario, 0);
            this.Controls.SetChildIndex(this.btnAgregarUsuario, 0);
            this.Controls.SetChildIndex(this.btnEliminarUsuario, 0);
            this.Controls.SetChildIndex(this.btnActivarUsuario, 0);
            this.Controls.SetChildIndex(this.btnModificarTarjeta, 0);
            this.Controls.SetChildIndex(this.btnEliminarTarjeta, 0);
            this.Controls.SetChildIndex(this.lblEliminarUsuario, 0);
            this.Controls.SetChildIndex(this.lblActivarUsuario, 0);
            this.Controls.SetChildIndex(this.lblModificarUsuario, 0);
            this.Controls.SetChildIndex(this.lblModificarTarjeta, 0);
            this.Controls.SetChildIndex(this.lblEliminarTarjeta, 0);
            this.Controls.SetChildIndex(this.btnAgregarTarjeta, 0);
            this.Controls.SetChildIndex(this.lblAgregarTarjeta, 0);
            this.Controls.SetChildIndex(this.lblAgregarUsuario, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value != null)
            {
                if (dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString() != "")
                {
                    int Empleado = Convert.ToInt32(dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value);
                    Interface = new InterfaceUsuario(this);
                    string Usuario = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
                    if (Usuario != this.Usuario)
                    {
                        DialogResult temp = MessageBox.Show("¿Desea eliminar al usuario: " + Usuario, "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        if (temp == DialogResult.Yes)
                        {
                            if (Interface.BorrarUsuario(Usuario))
                            {
                                MessageBox.Show("Usuario eliminado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                RefrescarData();
                            }
                            else
                            {
                                MessageBox.Show("Hubo un problema con la base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede eliminar su propio Usuario", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void btnEliminarTarjeta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ObtenerUsuario))
            {
                if (Interface.ValidarDatosTarjeta(ObtenerUsuario))
                {
                    if (DialogResult.Yes == MessageBox.Show("Desea eliminar la tarjeta asociada al usuario " + ObtenerUsuario + "?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
                    {
                        if (Interface.EliminarTarjeta(ObtenerUsuario))
                        {
                            MessageBox.Show("Tarjeta eliminada con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            RefrescarData();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un problema con la base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El usuario " + ObtenerUsuario + " no tiene una tarjeta registrada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        protected override void btnMouseLeft(object sender, EventArgs e)
        {
            base.btnMouseLeft(sender, e);
        }

        protected override void btnMouseOver(object sender, EventArgs e)
        {
            base.btnMouseOver(sender, e);
        }

        private string ObtenerUsuario
        {
            get
            {
                string User = "";
                if (dgvDatos.SelectedCells.Count > 0)
                {
                    if (dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value != null)
                    {
                        User = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
                    }
                }
                return User;
            }
        }

        private int ObtenerEmpleado
        {
            get
            {
                int Num = -1;
                if (dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value != null)
                {
                    Num = Convert.ToInt32(dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value);
                }
                return Num;
            }
        }

        private void btnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ObtenerUsuario))
            {
                Interface = new InterfaceUsuario(this);
                if (Interface.ValidarDatosTarjeta(ObtenerUsuario))
                {
                    if (DialogResult.Yes == MessageBox.Show("El usuario " + ObtenerUsuario + " ya tiene una tarjeta registrada\n\n¿Desea modificarla?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        Interface.DesplegarPantallaModificarTarjeta(ObtenerUsuario);
                        RefrescarData();
                    }
                }
                else
                {
                    Interface.DesplegarPantallaRegistrarTarjeta(ObtenerUsuario);
                    RefrescarData();
                }
            }
        }

        private void btnModificarTarjeta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ObtenerUsuario))
            {
                Interface = new InterfaceUsuario(this);
                if (Interface.ValidarDatosTarjeta(ObtenerUsuario))
                {
                    Interface.DesplegarPantallaModificarTarjeta(ObtenerUsuario);
                    RefrescarData();
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("El usuario " + ObtenerUsuario + " no tiene una tarjeta registrada\n\n¿Desea agregar una?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        Interface.DesplegarPantallaRegistrarTarjeta(ObtenerUsuario);
                    }
                }
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ObtenerUsuario))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaModificarUsuario(ObtenerUsuario, true);
                RefrescarData();
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            Interface.DesplegarPantallaRegistrarUsuario("", ObtenerEmpleado);
            RefrescarData();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ObtenerUsuario))
            {
                Interface = new InterfaceUsuario(this);
                if (Interface.ValidarDatosTarjeta(ObtenerUsuario))
                {
                    lblAgregarTarjeta.Visible = btnAgregarTarjeta.Visible = false;
                    lblModificarTarjeta.Visible = btnModificarTarjeta.Visible = lblEliminarTarjeta.Visible = btnEliminarTarjeta.Visible = true;
                }
                else
                {
                    if (dgvDatos[dgvDatos.Columns["Activo"].Index, e.RowIndex].Value.ToString() == 1.ToString())
                    {
                        lblAgregarTarjeta.Visible = btnAgregarTarjeta.Visible = true;
                        lblModificarTarjeta.Visible = btnModificarTarjeta.Visible = lblEliminarTarjeta.Visible = btnEliminarTarjeta.Visible = false;
                    }
                    else
                    {
                        lblAgregarTarjeta.Visible = btnAgregarTarjeta.Visible = false;
                        lblModificarTarjeta.Visible = btnModificarTarjeta.Visible = lblEliminarTarjeta.Visible = btnEliminarTarjeta.Visible = false;
                    }
                }
                if (dgvDatos[dgvDatos.Columns["Activo"].Index, e.RowIndex].Value.ToString() == 1.ToString())
                {
                    btnActivarUsuario.Visible = lblActivarUsuario.Visible = false;
                    btnEliminarUsuario.Visible = lblEliminarUsuario.Visible = true;
                }
                else
                {
                    btnActivarUsuario.Visible = lblActivarUsuario.Visible = true;
                    btnEliminarUsuario.Visible = lblEliminarUsuario.Visible = false;
                }
                btnAgregarUsuario.Visible = lblAgregarUsuario.Visible = false;
                btnModificarUsuario.Visible = lblModificarUsuario.Visible = true;
            }
            else
            {
                btnAgregarUsuario.Visible = lblAgregarUsuario.Visible = true;
                btnEliminarTarjeta.Visible = lblEliminarTarjeta.Visible = btnAgregarTarjeta.Visible = 
                    lblAgregarTarjeta.Visible = btnEliminarUsuario.Visible = lblEliminarUsuario.Visible = 
                    btnModificarTarjeta.Visible = lblModificarTarjeta.Visible = btnEliminarUsuario.Visible =
                    lblEliminarUsuario.Visible = btnModificarUsuario.Visible = lblModificarUsuario.Visible =
                    btnActivarUsuario.Visible = lblActivarUsuario.Visible = false;
            }
        }

        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            Interface.ObtenerUsuarios(dgvDatos);
            for (int i = 0; i < dgvDatos.RowCount; i++)
            {
                if (dgvDatos[dgvDatos.Columns["Activo"].Index, i].Value != null)
                {
                    dgvDatos.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                }
            }
        }

        private void dgvDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell temp = dgvDatos[dgvDatos.Columns["Activo"].Index, e.RowIndex];
            if (temp.Value != null)
            {
                if (temp.Value.ToString() == 1.ToString())
                e.CellStyle.BackColor = System.Drawing.Color.LightGreen;
                if (temp.Value.ToString() == 0.ToString())
                    e.CellStyle.BackColor = System.Drawing.Color.LightSalmon;
                if (temp.Value.ToString() == "")
                    e.CellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            }
        }

        private void btnActivarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value != null)
            {
                if (dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value.ToString() != "")
                {
                    int Empleado = Convert.ToInt32(dgvDatos[0, dgvDatos.SelectedCells[0].RowIndex].Value);
                    Interface = new InterfaceUsuario(this);
                    string Usuario = dgvDatos[1, dgvDatos.SelectedCells[0].RowIndex].Value.ToString();
                    if (Usuario != this.Usuario)
                    {
                        DialogResult temp = MessageBox.Show("¿Desea permitirle acceso al sistema al usuario: " + Usuario, "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        if (temp == DialogResult.Yes)
                        {
                            if (Interface.ActivarUsuario(Usuario))
                            {
                                MessageBox.Show("Usuario activado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                RefrescarData();
                            }
                            else
                            {
                                MessageBox.Show("Hubo un problema con la base de datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede activar su propio Usuario", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void RefrescarData()
        {
            int Col = 0, Ren = 0;
            if (dgvDatos.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dgvDatos.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
                ActualizarData();
                dgvDatos.CurrentCell = dgvDatos[Col, Ren];
                dgvDatos.Focus();
            }
        }
    }
}
