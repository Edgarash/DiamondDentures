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
    public partial class MostrarFaltantes : Control.Pantalla
    {
        InterfaceUsuario Interface;
        enum Búsqueda { Total, Clave, Personalizada };
        public MostrarFaltantes()
        {
            InitializeComponent();
        }

        private void MostrarFaltantes_Load(object sender, EventArgs e)
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
                temp = Interface.MostrarFaltantes();
            dataGridView1.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView1[0, i].Value = temp[i].IDMaterial;
                    dataGridView1[1, i].Value = temp[i].Nombre;
                    dataGridView1[2, i].Value = temp[i].Faltantes;
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
    }
}
