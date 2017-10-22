using Control.Ventas;
using ControlesM;
using Entidad;
using Presentacion.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Ventas
{
    public partial class RealizarCorte : KuroForm
    {
        int IDCorte { get; set; }
        DateTime FechaMin { get; set; }
        public RealizarCorte()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblEmpleado.Text = PantallaLogin.Sesión.NombreCompleto;
            DataTable temp = ManejadorVentas.UltimoCorteCaja();
            FechaMin = temp.Rows.Count > 0 ? Convert.ToDateTime(temp.Rows[0].ToString()) : DateTime.MinValue;
            DataTable Ventas;
            RegistroVenta[] Ventas2;
            ManejadorVentas.VerVentas(0, FechaMin, DateTime.MaxValue, null, PantallaLogin.Sesión.NombreCompleto, null, true, true, true, out Ventas, out Ventas2);
            lblVentas.Text = kuroDGV1.RowCount.ToString() + " Ventas";
            float Tarjeta = 0, Efectivo = 0, Cheque = 0, Total = 0;
            for (int i = 0; i < Ventas2.Length; i++)
            {

                if (Ventas2[i].FormaPago == "TARJETA")
                    Tarjeta += Ventas2[i].Importe;
                if (Ventas2[i].FormaPago == "EFECTIVO")
                    Efectivo += Ventas2[i].Importe;
                if (Ventas2[i].FormaPago == "CHEQUE")
                    Cheque += Ventas2[i].Importe;
            }
            lblCheque.Text = Cheque.ToString("C2");
            lblEfectivo.Text = Efectivo.ToString("C2");
            lblTarjeta.Text = Tarjeta.ToString("C2");
            tbFondo.KeyPress += Validar.TextBox_KeyPress_ValidarSoloReales;
        }
    }
}
