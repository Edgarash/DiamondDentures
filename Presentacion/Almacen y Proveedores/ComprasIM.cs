using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Almacen_y_Proveedores
{
    public partial class ComprasIM : Control.Pantalla
    {
        InterfaceUsuario Interface;
        List<string> Lista = new List<string>();
        int r = 0, u = 0, a = 0;
        string datos = "", subtotl = "", totl = "", fec = "", subtotal = "";

        public ComprasIM()
        {
            InitializeComponent();
        }

        private void ComprasIM_Load(object sender, EventArgs e)
        {
            Lista = new List<string>();
            ActualizarData();
            ActualizarData2();
            txID.Text = (Convert.ToInt32(dtIdCompras[0, 0].Value) + 1).ToString();
        }

        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosDUltipoIDCompra(dtIdCompras);
        }

        private void ActualizarData2()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosComboListaNombProveedor(txProveedor);
        }

        private void txProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ActualizarData3();
            ActualizarData4();
            dtInsumos.Select();
        }

        private void dtInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = Convert.ToInt32(dtInsumos.CurrentCell.RowIndex.ToString());
            txIdInsumos.Text = dtInsumos[0, r].Value.ToString();
            txNom.Text = dtInsumos[1, r].Value.ToString();
            txPreUni.Text = dtInsumos[3, r].Value.ToString();
            txCant.Select();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Interface = new InterfaceUsuario(this);
                Interface.DatosDVerProductosDeProveedor(dtInsumos, txIdPr.Text);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Interface = new InterfaceUsuario(this);
                Interface.DatosDVerMaterialesDeProveedor(dtInsumos, txIdPr.Text);
            }
        }

        private void ActualizarData3()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosComboObtenerIDProveedores(txIdPr, txProveedor.Text);
        }
        private void ActualizarData4()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosComboObtenerIDProveedores(txIdPr, txProveedor.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool repetido = false;
            txTotal.Text = "";
            if (dataGridView1.RowCount > 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dtInsumos[0, r].Value.ToString() == dataGridView1[0, i].Value.ToString())
                    {
                        repetido = true;
                        break;
                    }
                    else
                    {
                        repetido = false;
                    }
                }
            }
            if (!repetido)
            {
                string aux = dtInsumos[3, r].Value.ToString(), prec = "";
                for (int i = 0; i < aux.Length; i++)
                {
                    if (aux[i].ToString() != ".")
                    {
                        prec += aux[i].ToString();
                    }
                    else
                        break;
                }
                if (txCant.Text != "")
                {
                    subtotal = (Convert.ToInt32(prec) * Convert.ToInt32(txCant.Text)).ToString();
                    Lista.Add(subtotal);

                }
                dataGridView1.Rows.Add(txIdInsumos.Text, txIdPr.Text, txNom.Text, prec, txCant.Text, subtotal.ToString());
                for (int i = 0; i < Lista.Count; i++)
                {
                    a += Convert.ToInt32(Lista[i]);
                }
                txTotal.Text = "TOTAL= " + a.ToString() + ".00";
            }
            else
            {
                MessageBox.Show("Ya has agregado este Insumo a tu lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            totl = (Convert.ToInt32(a) + (Convert.ToInt32(a) * 0.16)).ToString();
            DataGridView dtt = new DataGridView();
            //Interface.DatosDRegistroPagos(dtt, txNom.Text, "INSUMOS a de proveedor: " + txDesc.Text, txPreUni.Text, txCant.Text, a.ToString(), totl, "1", "1", hoy.ToShortDateString(), txID.Text);
            Interface.DatosDRegistroPagos(dtt, "INSUMOS a de proveedor: " + txIdPr.Text, txDesc.Text, a.ToString(), "1", a.ToString(), totl, "1", "1", txID.Text);
            Interface.AgregarCompra("", totl);
            MessageBox.Show("Compra Registrada Correctamete", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            u = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(u);
        }
    }
}
