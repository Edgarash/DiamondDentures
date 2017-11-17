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
    public partial class FinanzasRealizarPago : Control.Pantalla
    {
        InterfaceUsuario Interface;
        string dts { get; set; }
        string idcom { get; set; }
        public FinanzasRealizarPago(string datos, string IDCompra)
        {
            dts = datos;
            idcom = IDCompra;
            InitializeComponent();
            txDatos.Text = dts;
        }

        private void tbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se ha realizado el pago, ¿desea generar un reporte?",
                "Pago concluído", MessageBoxButtons.YesNo);
            ActualizarData();
            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Aquí se genera el reporte");
                    break;
                case DialogResult.No:
                    break;
            }
        }
        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            string id = obtenerID(txDatos);
            Interface.DatosDActualizarPago(Convert.ToInt32(id));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(511, 324);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(303, 285);
        }

        private string obtenerID(RichTextBox texto)
        {
            bool entra = false, sal = false; 
            string ID = "", aux = "", aux2 = "", salida = "";
            aux = texto.Text;
            int cont = 0;
            while (cont<aux.Length)
            {
                aux2 += aux[cont];
                if (aux2 == "ID_Pago: ")
                {
                    entra = true;
                }
                if (aux[cont] == '\n')
                {
                    sal = true;
                }
                if (entra && !sal)
                {
                    if (aux2[cont]!=32)
                    {
                        salida += aux2[cont];
                    }
                }
                cont++;

            }
            return salida;
        }
        private void ActualizarData2()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosComboNombProveedor(txBeneficiario, idcom);
        }

        private void ActualizarData3()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosComboObtenerBanco(txBanco, txBeneficiario.Text);
            Interface.DatosComboObtenerNumeroCuenta(txNumCuenta, txBeneficiario.Text);
        }

        private void FinanzasRealizarPago_Load(object sender, EventArgs e)
        {
            ActualizarData2();
            ActualizarData3();
        }

        private void txBeneficiario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarData3();
        }
    }
}
