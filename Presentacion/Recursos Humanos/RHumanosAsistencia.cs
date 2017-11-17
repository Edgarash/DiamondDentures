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
        string fech = "";
        public RHumanosAsistencia()
        {
            InitializeComponent();
        }
        private void ActualizarData()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosDAsistencia(dtAsistencia);
        }
        private void ActualizarData2()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosComboIDUsuarios(comboBox1);
        }
        private void ActualizarData3()
        {
            Interface = new InterfaceUsuario(this);
            Interface.DatosNombreUsuarios(txEmpleado, comboBox1.Text);
        }
        private void ActualizarData4()
        {
            Interface = new InterfaceUsuario(this);
            fech = cbAño.Text + "-" + cbMes.Text+ "-" + cbDia.Text;
            Interface.DatosAgregarAsistencia(dtAsistencia,comboBox1.Text,txEmpleado.Text, fech,txEnt.Text,txSal.Text);
            ActualizarData();
        }
        private void RHumanosAsistencia_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            ActualizarData();
            ActualizarData2();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarData4();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarData3();
        }
    }
}
