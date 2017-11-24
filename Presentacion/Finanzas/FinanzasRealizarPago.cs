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

namespace Presentacion.Finanzas
{
    public partial class FinanzasRealizarPago : Control.Pantalla
    {
        InterfaceUsuario Interface;
        public string r1id = "",r4 = "", r5 = "", r6 = "";
        int rngln = 0, r = 0;
        enum Búsqueda { Total, Clave, Personalizada };
        string dts { get; set; }
        string idd { get; set; }
        public FinanzasRealizarPago()
        {
            InitializeComponent();
        }

        public FinanzasRealizarPago(string id)
        {
            idd = id;
            InitializeComponent();
        }

        private void tbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = Convert.ToInt32(dataGridView2.CurrentCell.RowIndex.ToString());
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ManejadorReportes.MostrarPantalla(this, new Reportes.PantallaVPNotaPagos());
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dataGridView2[9, r].Value.ToString()== "ENVIADO")
            {
                CompraMaterial material = new CompraMaterial(Convert.ToInt32(dataGridView2[0, r].Value), Convert.ToInt32(dataGridView2[3, r].Value));
                ManejadorAlmacen.ActualizarEDOPagado(material);
                DialogResult result = MessageBox.Show("Se ha realizado el pago, ¿desea generar un reporte?",
                "Pago concluído", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        //Reporte
                        break;
                    case DialogResult.No:
                        break;
                }
                ActualizarData();
            }
            else
            {
                MessageBox.Show("No se puede pagar un material que no ha sido enviado");
            }
            
        }
        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            int IDCompra = Convert.ToInt32(idd);
            Interface.VerDetallesPagos(dataGridView2, IDCompra);
        }
        
        private void FinanzasRealizarPago_Load(object sender, EventArgs e)
        {
            ActualizarData();

        }

       
    }
}
