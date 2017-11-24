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
    public partial class Inventario : Control.Pantalla
    {
        InterfaceUsuario Interface;
        enum Búsqueda { Total, Clave, Personalizada };
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData(Búsqueda.Total);
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
                temp = Interface.ObtenerMateriales2();
            dataGridView1.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView1[0, i].Value = temp[i].IDMaterial;
                    dataGridView1[1, i].Value = temp[i].Nombre;
                    dataGridView1[2, i].Value = temp[i].Descripcion;
                    dataGridView1[3, i].Value = "$" + temp[i].PrecioBase.ToString("N2");
                    dataGridView1[4, i].Value = "$" + temp[i].PrecioCompra.ToString("N2");
                    dataGridView1[5, i].Value = temp[i].TiempoBase.ToString();
                    dataGridView1[6, i].Value = temp[i].IDProveedor.ToString();
                    dataGridView1[7, i].Value = temp[i].UnidadMedida.ToString();
                    dataGridView1[8, i].Value = temp[i].Cantidad.ToString();
                }
            }
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[Col > dataGridView1.ColumnCount ? 0 : Col, Ren > dataGridView1.RowCount ? 0 : Ren];
                dataGridView1.Focus();
            }
        }

        private void LlenarData()
        {
            LlenarData(Búsqueda.Total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[9, i].Value != null)
                {
                    HistorialMod historial = new HistorialMod(Convert.ToInt32(dataGridView1[0, i].Value), Convert.ToInt32(dataGridView1[8, i].Value), Convert.ToInt32(dataGridView1[9, i].Value));
                    ManejadorAlmacen.AgregarHistorial(historial);
                    dataGridView1[8, i].Value = dataGridView1[9, i].Value;
                    RegistroMaterial material = new RegistroMaterial(Convert.ToInt32(dataGridView1[0, i].Value), Convert.ToInt32(dataGridView1[8, i].Value));
                    ManejadorAlmacen.Actualizar_Cantidad(material);
                }
            }
            LlenarData(Búsqueda.Total);
            MessageBox.Show("Registro actualizado con exito");
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
            HistorialMod[] temp = null;
            if (Tipo == Búsqueda.Total)
                temp = Interface.SeleccHistorial();
            dataGridView2.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView2[0, i].Value = temp[i].Id;
                    dataGridView2[1, i].Value = temp[i].Cantidad;
                    dataGridView2[2, i].Value = temp[i].CantidadReal;
                    dataGridView2[3, i].Value = temp[i].Faltantes;
                    dataGridView2[4, i].Value = temp[i].Fecha;
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
                temp = Interface.ObtenerUnMaterial2(textBox1.Text);
            dataGridView1.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView1[0, i].Value = temp[i].IDMaterial;
                    dataGridView1[1, i].Value = temp[i].Nombre;
                    dataGridView1[2, i].Value = temp[i].Descripcion;
                    dataGridView1[3, i].Value = "$" + temp[i].PrecioBase.ToString("N2");
                    dataGridView1[4, i].Value = "$" + temp[i].PrecioCompra.ToString("N2");
                    dataGridView1[5, i].Value = temp[i].TiempoBase.ToString();
                    dataGridView1[6, i].Value = temp[i].IDProveedor.ToString();
                    dataGridView1[7, i].Value = temp[i].UnidadMedida.ToString();
                    dataGridView1[8, i].Value = temp[i].Cantidad.ToString();
                }
            }
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[Col > dataGridView1.ColumnCount ? 0 : Col, Ren > dataGridView1.RowCount ? 0 : Ren];
                dataGridView1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData2(Búsqueda.Total);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData3(Búsqueda.Total);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            LlenarData3(Búsqueda.Total);
            textBox1.Focus();
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            ManejadorReportes.MostrarPantalla(this, new PantallaVPListadoGen<ReporteInventarios>("Inventarios"));
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ManejadorReportes.MostrarPantalla(this, new PantallaVPListadoGen<CAN8_ReporteFaltantes>("Faltantes"));
        }
    }
}
