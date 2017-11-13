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
    public partial class RHumanosAsistencia : Control.Pantalla
    {
        InterfaceUsuario Interface;
        public RHumanosAsistencia()
        {
            InitializeComponent();
        }
        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosDAsistencia(dtAsistencia);
        }
        private void RHumanosAsistencia_Load(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarData();
        }
    }
}
