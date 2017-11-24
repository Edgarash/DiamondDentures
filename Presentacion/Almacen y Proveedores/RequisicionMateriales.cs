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
    public partial class RequisicionMateriales : Control.Pantalla
    {
        InterfaceUsuario Interface;
        enum Búsqueda { Total, Clave, Personalizada };
        public RequisicionMateriales()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData3(Búsqueda.Total);
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
            RegistroMaterial[] temp = null;
            if (Tipo == Búsqueda.Total)
                temp = Interface.ObtenerMateriales3();
            dataGridView1.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView1[0, i].Value = temp[i].IDMaterial;
                    dataGridView1[1, i].Value = temp[i].Nombre;
                    dataGridView1[2, i].Value = "$" + temp[i].PrecioBase.ToString("N2");
                    dataGridView1[3, i].Value = "$" + temp[i].PrecioCompra.ToString("N2");
                    dataGridView1[4, i].Value = temp[i].IDProveedor.ToString();
                    dataGridView1[5, i].Value = temp[i].UnidadMedida.ToString();
                    dataGridView1[6, i].Value = temp[i].Cantidad.ToString();
                }
            }
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[Col > dataGridView1.ColumnCount ? 0 : Col, Ren > dataGridView1.RowCount ? 0 : Ren];
                dataGridView1.Focus();
            }
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
            Compras[] temp = null;
            if (Tipo == Búsqueda.Total)
                temp = Interface.RecuperarCompras();
            dataGridView2.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView2[0, i].Value = temp[i].IDCompra;
                    dataGridView2[1, i].Value = temp[i].Empleado;
                    dataGridView2[2, i].Value = temp[i].Total;
                    dataGridView2[3, i].Value = temp[i].Fecha;
                    dataGridView2[4, i].Value = temp[i].Tipo;
                    dataGridView2[5, i].Value = temp[i].FechaSurtido;
                    dataGridView2[6, i].Value = temp[i].Estado;
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
            RegistroMaterial[] temp = null;
            if (Tipo == Búsqueda.Total)
                temp = Interface.ObtenerUnMaterial(textBox1.Text);
            dataGridView1.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView1[0, i].Value = temp[i].IDMaterial;
                    dataGridView1[1, i].Value = temp[i].Nombre;
                    dataGridView1[2, i].Value = "$" + temp[i].PrecioBase.ToString("N2");
                    dataGridView1[3, i].Value = "$" + temp[i].PrecioCompra.ToString("N2");
                    dataGridView1[4, i].Value = temp[i].IDProveedor.ToString();
                    dataGridView1[5, i].Value = temp[i].UnidadMedida.ToString();
                    dataGridView1[6, i].Value = temp[i].Cantidad.ToString();
                }
            }
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[Col > dataGridView1.ColumnCount ? 0 : Col, Ren > dataGridView1.RowCount ? 0 : Ren];
                dataGridView1.Focus();
            }
        }




        private void LlenarData11(Búsqueda Tipo)
        {
            int Col = 0, Ren = 0;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dataGridView1.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
            }
            dataGridView1.Rows.Clear();
            RegistroInsumos[] temp = null;
            if (Tipo == Búsqueda.Total)
                temp = Interface.ObtenerInsumos3();
            dataGridView1.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView1[0, i].Value = temp[i].IDInsumos;
                    dataGridView1[1, i].Value = temp[i].Nombre;
                    dataGridView1[2, i].Value = "$" + temp[i].PrecioBase.ToString("N2");
                    dataGridView1[3, i].Value = "$" + temp[i].PrecioCompra.ToString("N2");
                    dataGridView1[4, i].Value = temp[i].IDProveedor.ToString();
                    dataGridView1[5, i].Value = temp[i].UnidadMedida.ToString();
                    dataGridView1[6, i].Value = temp[i].Cantidad.ToString();
                }
            }
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[Col > dataGridView1.ColumnCount ? 0 : Col, Ren > dataGridView1.RowCount ? 0 : Ren];
                dataGridView1.Focus();
            }
        }

        private void LlenarData12(Búsqueda Tipo)
        {
            int Col = 0, Ren = 0;
            if (dataGridView2.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dataGridView2.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
            }
            dataGridView2.Rows.Clear();
            Compras[] temp = null;
            if (Tipo == Búsqueda.Total)
                temp = Interface.RecuperarCompras();
            dataGridView2.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView2[0, i].Value = temp[i].IDCompra;
                    dataGridView2[1, i].Value = temp[i].Empleado;
                    dataGridView2[2, i].Value = temp[i].Total;
                    dataGridView2[3, i].Value = temp[i].Fecha;
                    dataGridView2[4, i].Value = temp[i].Tipo;
                    dataGridView2[5, i].Value = temp[i].FechaSurtido;
                    dataGridView2[6, i].Value = temp[i].Estado;
                }
            }
            if (dataGridView2.SelectedCells.Count > 0)
            {
                dataGridView2.CurrentCell = dataGridView2[Col > dataGridView2.ColumnCount ? 0 : Col, Ren > dataGridView2.RowCount ? 0 : Ren];
                dataGridView2.Focus();
            }
        }













        private void RequisicionMateriales_Load(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
                LlenarData(Búsqueda.Total);
                LlenarData2(Búsqueda.Total);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Compras temp = null;
                temp = Interface.ObtenerID();
                var id = temp.IDCompra + 1;
                var compra = new Compras(id);
                ManejadorAlmacen.AgregarCompra(compra);

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1[7, i].Value != null)
                    {
                        CompraMaterial cmaterial = new CompraMaterial(id, Convert.ToInt32(dataGridView1[0, i].Value), Convert.ToString(dataGridView1[1, i].Value), Convert.ToInt32(dataGridView1[4, i].Value), Convert.ToInt32(dataGridView1[7, i].Value));
                        ManejadorAlmacen.AgregarAlaCompra(cmaterial);
                    }
                }
                MessageBox.Show("Registro agregado con exito");
            }
            else
            {
                Compras temp = null;
                temp = Interface.ObtenerID();
                var id = temp.IDCompra + 1;
                var compra = new Compras(id);
                ManejadorAlmacen.AgregarCompraInsumos7(compra);
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1[7, i].Value != null)
                    {
                        CompraMaterial cmaterial = new CompraMaterial(id, Convert.ToInt32(dataGridView1[0, i].Value), Convert.ToString(dataGridView1[1, i].Value), Convert.ToInt32(dataGridView1[4, i].Value), Convert.ToInt32(dataGridView1[7, i].Value));
                        ManejadorAlmacen.AgregarInsumosAlaCompra(cmaterial);
                    }
                }
                MessageBox.Show("Registro agregado con exito");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == 7)
            {
                DetalleCompras p6 = new DetalleCompras();
                p6.label2.Text = dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString();
                p6.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData3(Búsqueda.Total);
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float Total = Convert.ToSingle(label4.Text);
            DateTime Fecha = Convert.ToDateTime(label5.Text);
            int IDCompra = Convert.ToInt32(label6.Text);

            Compras compra = new Compras(IDCompra, Total, Fecha);
            ManejadorAlmacen.ActualizarCompra(compra);
            LlenarData2(Búsqueda.Total);
            MessageBox.Show("Compra Actualizada");
        }

        private void btnReqM_Click(object sender, EventArgs e)
        {
            ManejadorReportes.MostrarPantalla(this, new PantallaVPReqMat());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                LlenarData(Búsqueda.Total);
                LlenarData2(Búsqueda.Total);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                LlenarData11(Búsqueda.Total);
                LlenarData12(Búsqueda.Total);
            }
        }
    }
}
