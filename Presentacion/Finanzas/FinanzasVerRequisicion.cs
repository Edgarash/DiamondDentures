using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control;
using Entidad;
using System.Windows.Forms;

namespace Presentacion.Finanzas
{
    public partial class FinanzasVerRequisicion : Control.Pantalla
    {
        public string elquesea;
        enum Búsqueda { Total, Clave, Personalizada };
        string idcom { get; set; }
        InterfaceUsuario Interface;
        public FinanzasVerRequisicion()
        {
            InitializeComponent();
        }
        public int[] cantidad = new int[100];

        private void FinanzasVerRequisicion_Load(object sender, EventArgs e)
        {
            Interface = new InterfaceUsuario(this);
            //LlenarData11(Búsqueda.Total);
            LlenarData(Búsqueda.Total);
        }
        private void LlenarData(Búsqueda Tipo)
        {
            int IDCompra = Convert.ToInt32(elquesea);
            int Col = 0, Ren = 0;
            if (dtRequisicion.SelectedCells.Count > 0)
            {
                DataGridViewCell Cell = dtRequisicion.SelectedCells[0];
                Col = Cell.ColumnIndex;
                Ren = Cell.RowIndex;
            }
            dtRequisicion.Rows.Clear();
            CompraMaterial[] temp = null;
            if (Tipo == Búsqueda.Total)
                temp = Interface.DetallesMaterial(IDCompra);
            dtRequisicion.RowCount = temp?.Length ?? 0;
            if (temp != null)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    dtRequisicion[0, i].Value = temp[i].IDCompra;
                    dtRequisicion[1, i].Value = temp[i].IDMaterial;
                    dtRequisicion[2, i].Value = temp[i].Nombre;
                    dtRequisicion[3, i].Value = temp[i].IDProveedor;
                    dtRequisicion[4, i].Value = temp[i].SubTotal;
                    dtRequisicion[5, i].Value = temp[i].Cantidad;
                    dtRequisicion[6, i].Value = temp[i].Fecha;
                    dtRequisicion[7, i].Value = temp[i].Estado;
                }
            }
            if (dtRequisicion.SelectedCells.Count > 0)
            {
                dtRequisicion.CurrentCell = dtRequisicion[Col > dtRequisicion.ColumnCount ? 0 : Col, Ren > dtRequisicion.RowCount ? 0 : Ren];
                dtRequisicion.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool supererror = false;
            bool valorcito = false;
            int contado = 0;
            for (int j = 0; j < dtRequisicion.RowCount; j++)
            {
                if (cantidad[j] == Convert.ToInt32(dtRequisicion[5, j].Value))
                {

                }
                else
                {
                    if (cantidad[j] > Convert.ToInt32(dtRequisicion[5, j].Value))
                    {
                        supererror = true;
                        break;
                    }
                    else
                    {
                        valorcito = true;
                    }
                }
                if (dtRequisicion[7, j].Value.ToString().ToUpper() == "AUTORIZADA")
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
                        if (contado == dtRequisicion.RowCount)
                        {
                            FinanzasAdministracionPagos rm = new FinanzasAdministracionPagos();
                            float total = 0;
                            for (int i = 0; i < dtRequisicion.RowCount; i++)
                            {
                                total += Convert.ToInt32(dtRequisicion[4, i].Value);
                            }
                            rm.r4 = total.ToString();
                            rm.r5 = dtRequisicion[6, dtRequisicion.CurrentCell.RowIndex].Value.ToString();
                            rm.r6 = dtRequisicion[0, dtRequisicion.CurrentCell.RowIndex].Value.ToString();
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
                    if (contado == dtRequisicion.RowCount)
                    {
                        FinanzasAdministracionPagos rm = new FinanzasAdministracionPagos();
                        float total = 0;
                        for (int i = 0; i < dtRequisicion.RowCount; i++)
                        {
                            total += Convert.ToInt32(dtRequisicion[4, i].Value);
                        }
                        rm.r4 = total.ToString();
                        rm.r5 = dtRequisicion[6, dtRequisicion.CurrentCell.RowIndex].Value.ToString();
                        rm.r6 = dtRequisicion[0, dtRequisicion.CurrentCell.RowIndex].Value.ToString();
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
    }
}
