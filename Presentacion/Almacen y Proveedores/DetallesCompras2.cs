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

namespace Presentacion.Almacen_y_Proveedores
{
    public partial class DetallesCompras2 : Pantalla
    {
        InterfaceUsuario Interface;
        enum Búsqueda { Total, Clave, Personalizada };
        public DetallesCompras2()
        {
            InitializeComponent();
        }

        private void DetallesCompras2_Load(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData(Búsqueda.Total);
        }

        private void LlenarData(Búsqueda Tipo)
        {
            int IDProveedor = Convert.ToInt32(label4.Text);
            int Col = 0, Ren = 0;
            if (dataGridView2.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dataGridView2.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
            }
            dataGridView2.Rows.Clear();
            CompraMaterial[] temp = null;
            if (Tipo == Búsqueda.Total)
                temp = Interface.DetallesProveedorMaterial(IDProveedor);
            dataGridView2.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView2[0, i].Value = temp[i].IDCompra;
                    dataGridView2[1, i].Value = temp[i].IDMaterial;
                    dataGridView2[2, i].Value = temp[i].Nombre;
                    dataGridView2[3, i].Value = temp[i].IDProveedor;
                    dataGridView2[4, i].Value = temp[i].SubTotal;
                    dataGridView2[5, i].Value = temp[i].Cantidad;
                    dataGridView2[6, i].Value = temp[i].Fecha;
                    dataGridView2[7, i].Value = temp[i].Estado;
                }
            }
            if (dataGridView2.SelectedCells.Count > 0)
            {
                dataGridView2.CurrentCell = dataGridView2[Col > dataGridView2.ColumnCount ? 0 : Col, Ren > dataGridView2.RowCount ? 0 : Ren];
                dataGridView2.Focus();
            }
        }

        private void LlenarData2(Búsqueda Tipo)
        {
            CompraMaterial material = new CompraMaterial(Convert.ToInt32(textBox2.Text), Convert.ToInt32(label4.Text));
            int Col = 0, Ren = 0;
            if (dataGridView2.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dataGridView2.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
            }
            dataGridView2.Rows.Clear();
            CompraMaterial[] temp = null;
            if (Tipo == Búsqueda.Total)
                temp = Interface.MostrarUnaCompra(material);
            dataGridView2.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView2[0, i].Value = temp[i].IDCompra;
                    dataGridView2[1, i].Value = temp[i].IDMaterial;
                    dataGridView2[2, i].Value = temp[i].Nombre;
                    dataGridView2[3, i].Value = temp[i].IDProveedor;
                    dataGridView2[4, i].Value = temp[i].SubTotal;
                    dataGridView2[5, i].Value = temp[i].Cantidad;
                    dataGridView2[6, i].Value = temp[i].Fecha;
                    dataGridView2[7, i].Value = temp[i].Estado;
                }
            }
            if (dataGridView2.SelectedCells.Count > 0)
            {
                dataGridView2.CurrentCell = dataGridView2[Col > dataGridView2.ColumnCount ? 0 : Col, Ren > dataGridView2.RowCount ? 0 : Ren];
                dataGridView2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = 0;
            CompraMaterial material = new CompraMaterial(Convert.ToInt32(dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value), Convert.ToInt32(label4.Text));
            ManejadorAlmacen.ActualizarEDO(material);
            MessageBox.Show("Registro actualizado con exito");

            DetalleCompras decomp = new DetalleCompras();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView2[0, i].Value) == Convert.ToInt32(dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value)) 
                {
                    decomp.cantidad[valor] = Convert.ToInt32(dataGridView2[5, i].Value);
                    valor++;
                }
            }
            decomp.label2.Text = dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString();
            decomp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData2(Búsqueda.Total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolioProveedor proveedor = new FolioProveedor(Convert.ToInt32(dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value), Convert.ToInt32(dataGridView2[3, dataGridView2.CurrentCell.RowIndex].Value),
                Convert.ToInt32(dataGridView2[5, dataGridView2.CurrentCell.RowIndex].Value), Convert.ToSingle(dataGridView2[4, dataGridView2.CurrentCell.RowIndex].Value));
            ManejadorAlmacen.AgregarFolios(proveedor);
            MessageBox.Show("Folio realizado con exito ");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData2(Búsqueda.Total);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CompraMaterial compra = new CompraMaterial(Convert.ToInt32(dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value), Convert.ToInt32(dataGridView2[1, dataGridView2.CurrentCell.RowIndex].Value), Convert.ToInt32(dataGridView2[5, dataGridView2.CurrentCell.RowIndex].Value));
            ManejadorAlmacen.ActualizarPrecio(compra);
            MessageBox.Show("Precio actualizado con exito ");
        }
    }
}
