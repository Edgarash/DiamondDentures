using Control.Ventas;
using ControlesM;
using Entidad;
using Presentacion.Recepcion;
using Presentacion.Usuario;
using System;
using System.Data;
using Validaciones;

namespace Presentacion.Ventas
{
    public partial class PantallaVerVentas : KuroForm
    {
        public PantallaVerVentas()
        {
            InitializeComponent();
            btnEjecutar_Click(btnBuscar, new EventArgs());
            tbEmpleado.KeyPress += Validar.NoApostrofes;
            tbIDPedido.KeyPress += Validar.NoApostrofes;
            tbIDVenta.KeyPress += Validar.NoApostrofes;
            tbReferencia.KeyPress += Validar.NoApostrofes;
        }

        private void btnEjecutar_Click(object sender, System.EventArgs e)
        {
            DataTable Datos;
            RegistroVenta[] Ventas;

            int IDVenta = string.IsNullOrWhiteSpace(tbIDVenta.Text) ? 0 : int.Parse(tbIDVenta.Text);
            string
                IDPedido = string.IsNullOrWhiteSpace(tbIDPedido.Text) ? null : tbIDPedido.Text,
                Nombre = string.IsNullOrWhiteSpace(tbEmpleado.Text) ? null : tbEmpleado.Text,
                Referencia = string.IsNullOrWhiteSpace(tbReferencia.Text) ? null : tbReferencia.Text;
            DateTime
                Min = dtpMin.Checked ? new DateTime(dtpMin.Value.Year, dtpMin.Value.Month, dtpMin.Value.Day) : DateTime.MinValue,
                Max = dtpMax.Checked ? new DateTime(dtpMax.Value.Year, dtpMax.Value.Month, dtpMax.Value.Day, 23, 59, 59, 999) : DateTime.MaxValue;
            ManejadorVentas.VerVentas(IDVenta, Min, Max, IDPedido, Nombre, Referencia,
                cbEfectivo.Checked, cbTarjeta.Checked, cbCheque.Checked, out Datos, out Ventas);
            kuroDGV1.RowCount = Datos.Rows.Count;
            for (int i = 0; i < kuroDGV1.RowCount; i++)
            {
                DataRow x = Datos.Rows[i];
                kuroDGV1["IDVenta", i].Value = x["IDVenta"];
                kuroDGV1["FechaPago", i].Value = Convert.ToDateTime(x["FechaPago"]).ToLongDateString();
                kuroDGV1["IDPedido", i].Value = x["IDPedido"];
                kuroDGV1["Empleado", i].Value = x["RegistraVenta"];
                kuroDGV1["Importe", i].Value = Convert.ToInt32(x["Importe"]).ToString("C2");
                kuroDGV1["Referencia", i].Value = x["Referencia"];
                kuroDGV1["FormaPago", i].Value = x["FormaPago"];
            }
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            int IDVenta = Convert.ToInt32(kuroDGV1["IDVenta", kuroDGV1.CurrentRow.Index].Value);
            bool Cancelado;
            if (PantallaPermisoAdministrador.PedirPermisoAdministrador(out Cancelado))
            {
                if (ManejadorVentas.RealizarDevolucionTicket(IDVenta))
                {
                    Validar.MensajeInfo("Devolución hecha correctamente\n\nDevolver al cliente la cantidad de " + kuroDGV1["Importe", kuroDGV1.CurrentRow.Index].Value);
                    kuroDGV1.Rows.Remove(kuroDGV1.CurrentRow);
                }
                else
                    Validar.MensajeErrorOK("Se produjo un error, inténtelo más tarde\n\nContacte con el administrador");
            }
        }
    }
}