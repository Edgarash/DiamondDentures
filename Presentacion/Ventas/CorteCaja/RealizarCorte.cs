using Control.Ventas;
using ControlesM;
using Entidad;
using Presentacion.Login;
using System;
using System.Data;
using static Validaciones.Validar;
using static Presentacion.Ventas.CorteCaja.PantallaContarCorte;
using System.Windows.Forms;
using Presentacion.Usuario;

namespace Presentacion.Ventas.CorteCaja
{
    public partial class RealizarCorte : KuroForm
    {
        int IDCorte { get; set; }
        DateTime FechaMin { get; set; }
        Efectivo[] Arqueo;
        decimal DineroEnVentas { get; set; }
        decimal TotalArqueo { get; set; }
        float Tarjeta { get; set; }
        float Efectivo { get; set; }
        float Cheque { get; set; }
        float FondoCaja { get; set; }
        RegistroVenta[] Ventas2;

        public RealizarCorte()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblEmpleado.Text = PantallaLogin.Sesión.NombreCompleto;
            DataTable temp = ManejadorVentas.UltimoCorteCaja(PantallaLogin.Sesión.Login);
            FechaMin = temp.Rows.Count > 0 ? Convert.ToDateTime(temp.Rows[0][1]) : DateTime.MinValue;
            DataTable Ventas;
            ManejadorVentas.VerVentas(0, FechaMin, DateTime.MaxValue, null, PantallaLogin.Sesión.NombreCompleto, null, true, true, true, out Ventas, out Ventas2);
            Ventas.Columns.Remove("RegistraVenta");
            Ventas.Columns.Remove("Login");
            btnRegistrar.Visible = false;
            Tarjeta =  Efectivo =  Cheque = 0;
            FondoCaja = 0;
            DineroEnVentas = 0;
            kuroDGV1.DataSource = Ventas;
            lblVentas.Text = kuroDGV1.RowCount.ToString() + " Ventas";
            for (int i = 0; i < Ventas2.Length; i++)
            {
                if (Ventas2[i].FormaPago == "TARJETA")
                    Tarjeta += Ventas2[i].Importe;
                if (Ventas2[i].FormaPago == "EFECTIVO")
                {
                    Efectivo += Ventas2[i].Importe;
                    DineroEnVentas += Convert.ToDecimal(Ventas2[i].Importe);
                }
                if (Ventas2[i].FormaPago == "CHEQUE")
                    Cheque += Ventas2[i].Importe;
            }
            lblCheque.Text = Cheque.ToString("C2");
            lblEfectivo.Text = Efectivo.ToString("C2");
            lblTarjeta.Text = Tarjeta.ToString("C2");
            tbFondo.KeyPress += TextBox_KeyPress_ValidarSoloReales2Decimales;
            tbComentarios.KeyPress += NoApostrofes;
        }

        private void btnArqueo_Click(object sender, EventArgs e)
        {
            PantallaContarCorte temp = new PantallaContarCorte(Arqueo);
            temp.RecuperarRegistros += AsignarEfectivo;
            temp.ShowDialog();
        }

        private void AsignarEfectivo(Efectivo[] Money, decimal Total)
        {
            Arqueo = Money;
            lblEfectivoEnCaja.Text = Total.ToString("C2");
            btnRegistrar.Visible = true;
            TotalArqueo = Total;
            CalcularDiferencia();
        }

        private void CalcularDiferencia()
        {
            string Fondo = string.IsNullOrWhiteSpace(tbFondo.Text) ? "0" : tbFondo.Text;
            FondoCaja = Convert.ToSingle(Fondo);
            lblDiferencia.Text = (TotalArqueo - Convert.ToDecimal(FondoCaja) - DineroEnVentas).ToString("C2");
        }

        private void tbFondo_TextChanged(object sender, EventArgs e)
        {
            CalcularDiferencia();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool Cancelado;
            RegistroUsuario Autoriza = PantallaPermisoAdministrador.Supervisor(out Cancelado);
            if (Autoriza != null)
            {
                RegistroCorteCaja Corte = new RegistroCorteCaja(0, DateTime.Now, PantallaLogin.Sesión, FondoCaja, Efectivo,
                    Cheque, Tarjeta, Convert.ToSingle(TotalArqueo), Ventas2.Length, Autoriza, tbComentarios.Text);
                ManejadorVentas.RegistrarCorteCaja(Corte);
                Close();
            }
        }
    }
}
