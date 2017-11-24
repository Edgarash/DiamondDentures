using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Control;
using System.Windows.Forms;

namespace Presentacion.Finanzas
{
    public partial class FinanzasAdministracionPagos : Control.Pantalla
    {
        InterfaceUsuario Interface;
        public string r4 = "", r5 = "", r6 = "";
        enum Búsqueda { Total, Clave, Personalizada };
        int r = 0;
        public FinanzasAdministracionPagos()
        {
            InitializeComponent();
        }
        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            
            Interface.DatosDTotalIngresos(txTotal);
        }

        private void FinanzasAdministracionPagos_Load(object sender, EventArgs e)
        {
            ActualizarData();
            LlenarData2(Búsqueda.Total);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private string infoPagos2(DataGridView dt, int r)
        {
            string datos = "";
            datos = "ID: " + dt[0, r].Value + "\nNOMBRE: " + dt[1, r].Value +
                "\nDESCRIPCIÓN: Compra de " + dt[4, r].Value+ " del día " + dt[3, r].Value + "\nEstado: " + dt[6, r].Value +
                "\nTOTAL: $ " + dt[2, r].Value;
            return datos;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (Convert.ToSingle(fondoTotal(txTotal.Text)) <= Convert.ToSingle(dataGridView2[2, r].Value))
            {
                MessageBox.Show("No hay fondos suficientes para realizar el pago", "Fondo insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FinanzasRealizarPago frp = new FinanzasRealizarPago(infoPagos2(dataGridView2,r),dataGridView2[0,r].Value.ToString());
                frp.Show();
            }
        }

        private string fondoTotal(string fondo)
        {
            string total = "", salida = "";
            total = fondo;
            for (int i = 0; i < total.Length; i++)
            {
                if (Char.IsNumber(total[i])||total[i].ToString()==".")
                {
                    salida += total[i].ToString();
                }
            }
            return salida;
        }
        private void ActualizarData7()
        {
            Interface = new InterfaceUsuario(this);
           // Interface.DatosDBuscarAdminPagos(dtPagos, tbBuscar.Text, tbBuscar.Text);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarData7();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float Total = Convert.ToSingle(r4);
            DateTime Fecha = Convert.ToDateTime(r5);
            int IDCompra = Convert.ToInt32(r6);

            Compras compra = new Compras(IDCompra, Total, Fecha);
            ManejadorAlmacen.ActualizarCompra(compra);
            LlenarData2(Búsqueda.Total);
            MessageBox.Show("Compra Actualizada");
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

            ActualizarData7();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = Convert.ToInt32(dataGridView2.CurrentCell.RowIndex.ToString());
            txInfo.Text = "ID: " + dataGridView2[0, r].Value + " | NOMBRE: " + dataGridView2[1, r].Value +
                " | DESCRIPCIÓN: Compra de " + dataGridView2[4, r].Value  +" | Estado: " + dataGridView2[6, r].Value +
                " | TOTAL: $ " + dataGridView2[2, r].Value;

            if (dataGridView2.CurrentCell.ColumnIndex == 7)
            {
                FinanzasVerRequisicion p6 = new FinanzasVerRequisicion();
                p6.elquesea = dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString();
                p6.Show();
            }
        }
    }
}
