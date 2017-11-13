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
    public partial class FinanzasComprarInsumos : Control.Pantalla
    {
        InterfaceUsuario Interface;
        string datos = "", subtotl = "", totl = "", fec = "";

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FinanzasComprarInsumos()
        {
            InitializeComponent();
        }
        private void AgregarDatos()
        {
            Interface = new InterfaceUsuario(this);
            Interface.AgregarCompra(txID);
            Interface.ComprarInsumos(txID, txNom, txDesc, txCant, txPreUni,"7");
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txID.Text == "" || txNom.Text == "" || txDesc.Text == "" || txCant.Text == "" || txPreUni.Text == "")
            {
                MessageBox.Show("No puedes dejar un campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AgregarDatos();
                MessageBox.Show("Compra de Insumos Registrada Correctamete", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                subtotl = (Convert.ToInt32(txPreUni.Text) * Convert.ToInt32(txCant.Text)).ToString();
                totl = ((Convert.ToInt32(subtotl) * 0.16) + Convert.ToInt32(subtotl)).ToString();
                DataGridView a = new DataGridView();
                Interface.DatosDRegistroPagos(a, txNom.Text, txDesc.Text, txPreUni.Text, txCant.Text, subtotl.ToString(), totl.ToString(), "1", "1", fec);
                datos = "ID: "+ txID.Text+ "\nNOMBRE: " + txNom.Text + "\nDESCRIPCIÓN: " + txDesc.Text + "\nPRECIO UNITARIO: " + txPreUni.Text + "\nCANTIDAD: " + txCant.Text +
                    "\nSUBTOTAL: " + subtotl.ToString() + "\nTOTAL: " + totl.ToString() + "\nESTADO: EN PROCESO" + "\nREGISTRADO: SÍ";
                DialogResult result = MessageBox.Show("¿Desea realizar otra compra?",
                "Aviso", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        txNom.Clear();
                        txCant.Clear();
                        txPreUni.Clear();
                        txDesc.Clear();
                        break;
                    case DialogResult.No:
                        txID.Clear();
                        txNom.Clear();
                        txCant.Clear();
                        txPreUni.Clear();
                        txDesc.Clear();
                        break;
                }
               
                
            }            
        }
    }
}
