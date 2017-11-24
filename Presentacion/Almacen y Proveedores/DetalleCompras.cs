using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Entidad;

namespace Presentacion.Almacen_y_Proveedores
{
    public partial class DetalleCompras : Pantalla
    {
        public int[] cantidad = new int[100];

        InterfaceUsuario Interface;
        enum Búsqueda { Total, Clave, Personalizada };
        public DetalleCompras()
        {
            InitializeComponent();
        }


        private void LlenarData(Búsqueda Tipo)
        {
            int IDCompra = Convert.ToInt32(label2.Text);
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
                temp = Interface.DetallesMaterial(IDCompra);
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
                    dataGridView2[8, i].Value = temp[i].CantidadEnviada;
                }
            }
            if (dataGridView2.SelectedCells.Count > 0)
            {
                dataGridView2.CurrentCell = dataGridView2[Col > dataGridView2.ColumnCount ? 0 : Col, Ren > dataGridView2.RowCount ? 0 : Ren];
                dataGridView2.Focus();
            }
        }

        private void LlenarData11(Búsqueda Tipo)
        {
            int IDCompra = Convert.ToInt32(label2.Text);
            int Col = 0, Ren = 0;
            if (dataGridView2.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dataGridView2.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
            }
            dataGridView2.Rows.Clear();
            CompraInsumos[] temp = null;
            if (Tipo == Búsqueda.Total) 
                temp = Interface.DetallesInsumos(IDCompra);
            dataGridView2.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dataGridView2[0, i].Value = temp[i].IDCompra;
                    dataGridView2[1, i].Value = temp[i].IDInsumos;
                    dataGridView2[2, i].Value = temp[i].Nombre;
                    dataGridView2[3, i].Value = temp[i].IDProveedor;
                    dataGridView2[4, i].Value = temp[i].SubTotal;
                    dataGridView2[5, i].Value = temp[i].Cantidad;
                    dataGridView2[6, i].Value = temp[i].Fecha;
                    dataGridView2[7, i].Value = temp[i].Estado;
                    //dataGridView2[8, i].Value = temp[i].
                }
            }
            if (dataGridView2.SelectedCells.Count > 0)
            {
                dataGridView2.CurrentCell = dataGridView2[Col > dataGridView2.ColumnCount ? 0 : Col, Ren > dataGridView2.RowCount ? 0 : Ren];
                dataGridView2.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void DetalleCompras_Load(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            //LlenarData11(Búsqueda.Total);
            LlenarData(Búsqueda.Total);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool supererror = false;
            bool valorcito = false;
            int contado = 0;
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                if (Convert.ToInt32(dataGridView2[8, j].Value) == Convert.ToInt32(dataGridView2[5, j].Value))
                {

                }
                else
                {
                    if (Convert.ToInt32(dataGridView2[8, j].Value) > Convert.ToInt32(dataGridView2[5, j].Value))
                    {
                        supererror = true;
                        break;
                    }
                    else
                    {
                        valorcito = true;
                    }
                }
                if (dataGridView2[7, j].Value.ToString().ToUpper() == "ENVIADO")
                {
                    contado++;
                }
            }
            if (supererror)
            {
                Validaciones.Validar.MensajeErrorOK("El proveedor ha enviado más cantidades de las solicitadas, asi que no se puede aceptar");
            }
            else
            {
                if (valorcito && !supererror)
                {
                    DialogResult opcion = MessageBox.Show("La compra no cumple con los requisitos especificados, ¿Aún asi quiere admitirla?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (opcion == DialogResult.Yes)
                    {
                        if (contado == dataGridView2.RowCount)
                        {
                            RequisicionMateriales rm = new RequisicionMateriales();
                            float total = 0;
                            for (int i = 0; i < dataGridView2.RowCount; i++)
                            {
                                total += Convert.ToInt32(dataGridView2[4, i].Value);
                            }
                            rm.label4.Text = total.ToString();
                            rm.label5.Text = dataGridView2[6, dataGridView2.CurrentCell.RowIndex].Value.ToString();
                            rm.label6.Text = dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString();
                            rm.Show();

                            MessageBox.Show("Compra añadida con exito");
                        }
                        else
                        {
                            Validaciones.Validar.MensajeErrorOK("La compra aun no ha sido autorizada por completo, asi que es imposible añadirla");
                        }
                    }
                    if (opcion == DialogResult.No)
                    {
                        Validaciones.Validar.MensajeErrorOK("La compra ha sido rechazada");
                    }
                }
                else
                {
                    if (contado == dataGridView2.RowCount)
                    {
                        RequisicionMateriales rm = new RequisicionMateriales();
                        float total = 0;
                        for (int i = 0; i < dataGridView2.RowCount; i++)
                        {
                            total += Convert.ToInt32(dataGridView2[4, i].Value);
                        }
                        rm.label4.Text = total.ToString();
                        rm.label5.Text = dataGridView2[6, dataGridView2.CurrentCell.RowIndex].Value.ToString();
                        rm.label6.Text = dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString();
                        rm.Show();

                        MessageBox.Show("Compra añadida con exito");
                    }
                    else
                    {
                        Validaciones.Validar.MensajeErrorOK("La compra aun no ha sido autorizada por completo, asi que es imposible añadirla");
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
