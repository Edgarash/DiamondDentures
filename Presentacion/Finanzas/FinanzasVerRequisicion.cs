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
    public partial class FinanzasVerRequisicion : Control.Pantalla
    {
        string idcom { get; set; }
        InterfaceUsuario Interface;
        public FinanzasVerRequisicion(string IDCompra)
        {
            idcom = IDCompra;
            InitializeComponent();
        }

        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosDVerRequisicion(dtRequisicion, idcom);
        }

        private void FinanzasVerRequisicion_Load(object sender, EventArgs e)
        {
            ActualizarData();
        }
    }
}
