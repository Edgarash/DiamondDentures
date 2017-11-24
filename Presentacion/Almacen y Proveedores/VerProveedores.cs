using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Control;
using Presentacion.Reportes;

namespace Presentacion.Almacen_y_Proveedores
{
    public partial class VerProveedores : Pantalla
    {
        InterfaceUsuario Interface;

        enum Búsqueda
        {
            Total,
            Clave,
            Personalizada
        };

        public VerProveedores()
        {
            InitializeComponent();
        }

        private void VerProveedores_Load(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData(Búsqueda.Total);
            LlenarData2(Búsqueda.Total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void LlenarData(Búsqueda Tipo)
        {
            int Col = 0, Ren = 0;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dataGridView1.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
            }
            dataGridView1.Rows.Clear();
            RegistroProveedor[] temp = null;
            if (Tipo == Búsqueda.Total)
            {
                temp = Interface.MostrarProveedores();
            }
            dataGridView1.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView1[0, i].Value = temp[i].IDProveedor;
                    dataGridView1[1, i].Value = temp[i].Nombre;
                    dataGridView1[2, i].Value = temp[i].Telefono;
                    dataGridView1[3, i].Value = temp[i].Correo;
                    dataGridView1[4, i].Value = temp[i].Direccion;
                    dataGridView1[5, i].Value = temp[i].Descripcion;
                }
            }
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[Col > dataGridView1.ColumnCount ? 0 : Col, Ren > dataGridView1.RowCount ? 0 : Ren];
                dataGridView1.Focus();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 6)
            {
                DetallesCompras2 p7 = new DetallesCompras2();
                p7.label4.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                p7.Show();
            }

            if (dataGridView1.CurrentCell.ColumnIndex == 7)
            {
                ActualizarProveedor p8 = new ActualizarProveedor();
                p8.txtID.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                p8.txtNombre.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                p8.txtTel.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                p8.txtCorreo.Text = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                p8.txtDir.Text = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                p8.txtDes.Text = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                p8.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData3(Búsqueda.Total);
        }

        private void LlenarData2(Búsqueda Tipo)
        {
            int Col = 0, Ren = 0;
            if (dataGridView2.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dataGridView2.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
            }
            dataGridView2.Rows.Clear();
            FolioProveedor[] temp = null;
            if (Tipo == Búsqueda.Total)
            {
                temp = Interface.SeleccFolios();
            }
            dataGridView2.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView2[0, i].Value = temp[i].IDFolio;
                    dataGridView2[1, i].Value = temp[i].IDCompra;
                    dataGridView2[2, i].Value = temp[i].IDProveedor;
                    dataGridView2[3, i].Value = temp[i].Fecha;
                    dataGridView2[4, i].Value = temp[i].Cantidad;
                    dataGridView2[5, i].Value = temp[i].SubTotal;
                }
            }
            if (dataGridView2.SelectedCells.Count > 0)
            {
                dataGridView2.CurrentCell = dataGridView2[Col > dataGridView2.ColumnCount ? 0 : Col, Ren > dataGridView2.RowCount ? 0 : Ren];
                dataGridView2.Focus();
            }
        }

        private void LlenarData4(Búsqueda Tipo)
        {
            int Col = 0, Ren = 0;
            if (dataGridView2.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dataGridView2.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
            }
            dataGridView2.Rows.Clear();
            FolioProveedor[] temp = null;
            if (Tipo == Búsqueda.Total)
            {
                temp = Interface.SeleccUnFolio(Convert.ToInt32(textBox2.Text));
            }
            dataGridView2.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView2[0, i].Value = temp[i].IDFolio;
                    dataGridView2[1, i].Value = temp[i].IDCompra;
                    dataGridView2[2, i].Value = temp[i].IDProveedor;
                    dataGridView2[3, i].Value = temp[i].Fecha;
                    dataGridView2[4, i].Value = temp[i].Cantidad;
                    dataGridView2[5, i].Value = temp[i].SubTotal;
                }
            }
            if (dataGridView2.SelectedCells.Count > 0)
            {
                dataGridView2.CurrentCell = dataGridView2[Col > dataGridView2.ColumnCount ? 0 : Col, Ren > dataGridView2.RowCount ? 0 : Ren];
                dataGridView2.Focus();
            }
        }

        private void LlenarData3(Búsqueda Tipo)
        {
            int Col = 0, Ren = 0;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dataGridView1.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
            }
            dataGridView1.Rows.Clear();
            RegistroProveedor[] temp = null;
            if (Tipo == Búsqueda.Total)
            {
                temp = Interface.MostrarUnProveedor(textBox1.Text);
            }
            dataGridView1.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView1[0, i].Value = temp[i].IDProveedor;
                    dataGridView1[1, i].Value = temp[i].Nombre;
                    dataGridView1[2, i].Value = temp[i].Telefono;
                    dataGridView1[3, i].Value = temp[i].Correo;
                    dataGridView1[4, i].Value = temp[i].Direccion;
                    dataGridView1[5, i].Value = temp[i].Descripcion;
                }
            }
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[Col > dataGridView1.ColumnCount ? 0 : Col, Ren > dataGridView1.RowCount ? 0 : Ren];
                dataGridView1.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData3(Búsqueda.Total);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData4(Búsqueda.Total);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData4(Búsqueda.Total);
        }

        private void btnLstProv_Click(object sender, EventArgs e)
        {
            Dictionary<string, ParametroReporte> estadoColumnas = new Dictionary<string, ParametroReporte>
            {
                {"ID Prov.", new ParametroReporte("", "ID Prov.", "proveedores.IDProveedor")},
                {"Nombre", new ParametroReporte("", "Nombre", "proveedores.Nombre")},
                {"Descripcion", new ParametroReporte("", "Descripcion", "proveedores.Descripcion")},
                {"Direcion", new ParametroReporte("", "Direcion", "proveedores.Direccion")},
                {"Telefono", new ParametroReporte("", "Telefono", "proveedores.Telefono")},
                {"Correo", new ParametroReporte("", "Correo", "proveedores.Correo")}
            };
            string sql = "FROM proveedores;";
            ManejadorReportes.MostrarPantalla(this, new PantallaVPListadoPer<ReporteProveedores>("Proveedores", estadoColumnas, sql, 6));
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ManejadorReportes.MostrarPantalla(this, new PantallaVPNotaProv());
        }
    }
}