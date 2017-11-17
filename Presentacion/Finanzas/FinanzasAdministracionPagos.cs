using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Finanzas
{
    public partial class FinanzasAdministracionPagos : Control.Pantalla
    {
        InterfaceUsuario Interface;
        int r = 0;
        public FinanzasAdministracionPagos()
        {
            InitializeComponent();
        }
        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosDPagos(dtPagos);
            Interface.DatosDTotalIngresos(txTotal);
        }

        private void FinanzasAdministracionPagos_Load(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void infoPagos(TextBox tx, DataGridView dt, int r)
        {
            tx.Text = "ID_Pago: " + dt[0,r].Value + " | NOMBRE: " + dt[1,r].Value+
                " | SUBTOTAL: " + dt[5,r].Value+ " | TOTAL: $ " + dt[6, r].Value;
        }
        private string infoPagos2(DataGridView dt, int r)
        {
            string datos = "";
            datos = "ID_Pago: " + dt[0, r].Value + "\nNOMBRE: " + dt[1, r].Value +
                "\nDESCRIPCIÓN: " + dt[2, r].Value + "\nPrecio Unitario: " + dt[3, r].Value +
                "\nCANTIDAD: " + dt[4, r].Value +"\nSUBTOTAL: " + dt[5, r].Value 
                + "\nTOTAL: $ " + dt[6, r].Value;
            return datos;
        }

        private void dtPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = Convert.ToInt32(dtPagos.CurrentCell.RowIndex.ToString());
            infoPagos(txInfo, dtPagos, r);            

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (Convert.ToSingle(fondoTotal(txTotal.Text)) <= Convert.ToSingle(dtPagos[6, r].Value))
            {
                MessageBox.Show("No hay fondos suficientes para realizar el pago", "Fondo insuficiente",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                FinanzasRealizarPago frp = new FinanzasRealizarPago(infoPagos2(dtPagos, r), dtPagos[9, r].Value.ToString());
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
            Interface.DatosDBuscarAdminPagos(dtPagos, tbBuscar.Text, tbBuscar.Text);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarData7();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

            ActualizarData7();
        }

        private void dtPagos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FinanzasVerRequisicion fvr = new FinanzasVerRequisicion(dtPagos[9, r].Value.ToString());
            fvr.Show();
        }
    }
}
