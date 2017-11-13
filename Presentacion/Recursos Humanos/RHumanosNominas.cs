using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Recursos_Humanos
{
    public partial class RHumanosNominas : Control.Pantalla
    {
        InterfaceUsuario Interface;
        string nemp = "", fec = "", nomb = "", ape = "", rfc = "", mail = "", dep = "", pues = "",
                dlab = "", suel = "", isr = "", descisr = "", sfinal = "", pag = "", fech = "";
        int r = 0;
        private void ActualizarData4()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosDRegistroPagos(dtNomina, "Empleado " + dtNomina[2,r].Value.ToString() + " " + dtNomina[3,r].Value.ToString(),
                "Pago de nómina", dtNomina[9,r].Value.ToString(), dtNomina[8,r].Value.ToString(), sbtotl, total, "1", "1", fech);
            datos = "NOMBRE: " + dtNomina[2, r].Value.ToString() + " " + dtNomina[3,r].Value.ToString()
                + "\nDESCRIPCIÓN: " + "Nomina empleado" + "\nPRECIO UNITARIO: " + dtNomina[9, r].Value.ToString() + "\nCANTIDAD: " + dtNomina[8,r].Value.ToString() +
                "\nSUBTOTAL: " + sbtotl + "\nTOTAL: " + total + "\nESTADO: EN PROCESO" + "\nREGISTRADO: SÍ";
        }
        private void dtNomina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = Convert.ToInt32(dtNomina.CurrentCell.RowIndex.ToString());
            sbtotl = (Convert.ToInt32(dtNomina[9,r].Value) * Convert.ToInt32(dtNomina[8,r].Value)).ToString();
            total = ((Convert.ToInt32(sbtotl) * 0.16) + Convert.ToInt32(sbtotl)).ToString();
        }

        string datos = "", sbtotl = "", precioUni = "", cantidad = "", total = "";

        private void btnPagar_Click(object sender, EventArgs e)
        {
            ActualizarData4();
        }

        int subtotal = 0;
        public RHumanosNominas()
        {
            InitializeComponent();
        }

        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            fech = cbAño.Text + "-" + cbMes.Text;
            Interface.DatosDEmpleados(dtEmpleados);
            Interface.DatosDNomina(dtNomina);
            Interface.DatosDTotalNomina(txTotal);
        }
        private void ActualizarData2()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosDAgregarNomina(dtNomina, nemp, fec, nomb, ape, rfc, mail, dep, pues, dlab, suel, isr, descisr, sfinal, pag);
            ActualizarData();
        }

        private void RHumanosNominas_Load(object sender, EventArgs e)
        {
            ActualizarData();
            dtEmpleados.Columns[3].Visible = false;
            dtEmpleados.Columns[4].Visible = false;
            dtEmpleados.Columns[5].Visible = false;
            cbDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAño.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void dtEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nemp = ""; fec = ""; nomb = ""; ape = ""; rfc = ""; mail = ""; dep = ""; pues = "";
                dlab = ""; suel = ""; isr = ""; descisr = ""; sfinal = ""; pag = "";
            r = Convert.ToInt32(dtEmpleados.CurrentCell.RowIndex.ToString());
            txIDEmp.Text = "";
            txNomb.Text = "";
            txIDEmp.Text = dtEmpleados[0, r].Value.ToString();
            txNomb.Text += dtEmpleados[1, r].Value.ToString() + " " + dtEmpleados[2, r].Value.ToString();
            nomb = dtEmpleados[1, r].Value.ToString();
            ape = dtEmpleados[2, r].Value.ToString();
            rfc = dtEmpleados[3, r].Value.ToString();
            mail = dtEmpleados[4, r].Value.ToString();
            dep = dtEmpleados[5, r].Value.ToString();
            pues = dtEmpleados[6, r].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool sinregistro = false;
            nemp = txIDEmp.Text;
            fec = cbAño.Text + "-" + cbMes.Text + "-" + cbDia.Text;           
            dlab = nudDias.Value.ToString();
            suel = ObtenerPagoPorDia(pues);
            subtotal = Convert.ToInt32(suel) * Convert.ToInt32(dlab);
            isr = ObtenerISR(subtotal);
            descisr = (subtotal * (Convert.ToSingle(isr) / 100)).ToString();
            sfinal = (subtotal-Convert.ToSingle(descisr)).ToString();
            pag = "0";
            for (int i = 0; i < dtNomina.RowCount; i++)
            {
                string fecha2 = ObtenerFecha(Convert.ToDateTime(dtNomina[0, i].Value.ToString()));
                if (nemp == dtNomina[1, i].Value.ToString() && fec == fecha2)
                {
                    MessageBox.Show("Ya se ha ingresado la nomina del trabajador", "Aviso");
                    sinregistro = false;
                    break;
                }
                else
                {
                    sinregistro = true;
                }
            }
            if (sinregistro)
            {
                ActualizarData2();
            }    
        }

        private string ObtenerPagoPorDia(string puesto)
        {
            string pago = "";
            if (puesto == "ADMINISTRADOR")
                pago = "500";
            else if (puesto == "LABORATORISTA")
                pago = "350";
            else if (puesto == "SECRETARIO" || puesto == "SECRETARIA")
                pago = "200";
            else if (puesto == "JEFE DE DEPARTAMENTO")
                pago = "450";
            else
                pago = "150";
            return pago;
        }
        private string ObtenerISR(int subtotal)
        {
            float isr = 0.00f;
            string pago = "";
            if (subtotal <= 496)
                isr = 1.92f;
            else if (subtotal <= 4210)
                isr = 6.40f;
            else if (subtotal <= 7399)
                isr = 10.88f;
            else if (subtotal <= 8601)
                isr = 16.00f;
            else if (subtotal <= 10298)
                isr = 17.92f;
            else if (subtotal <= 20770)
                isr = 21.36f;
            else if (subtotal <= 32736)
                isr = 23.52f;
            else if (subtotal <= 62500)
                isr = 30.00f;
            else if (subtotal <= 83333)
                isr = 32.00f;
            else if (subtotal <= 250000)
                isr = 34.00f;
            else if (subtotal > 250000)
                isr = 35.00f;
            pago = isr.ToString("0.00");
            return pago;
        }

        private static string ObtenerFecha(DateTime Fecha)
        {
            return Fecha.Year + "-" + Fecha.Month + "-" + Fecha.Day;
        }
    }
}
