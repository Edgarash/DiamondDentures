using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Configuracion
{
    public partial class PantallaAgregarMaterial : Presentacion.Configuracion.PantallaMaterial
    {
        public PantallaAgregarMaterial()
        {
            InitializeComponent();
            InitializeComponent2();
            InitializeComponent3();
        }

        protected override void InitializeComponent3()
        {
            base.InitializeComponent3();
            tbClave.Enabled = true;
            Interface = new InterfaceUsuario(this);
            RegistroProducto[] Productos = Interface.ObtenerProductos();
            //RegistroMaterial[] Materiales = Interface.BuscarUnMaterial(new RegistroMaterial(-1, "", -1, -1));
            //tbClave.Text = (Materiales?[Materiales.Length - 1].IDMaterial + 1).ToString();
            tbClave.Select(tbClave.Text.Length, tbClave.Text.Length);
            for (int i = 0; i < Productos?.Length; i++)
            {
                if (Productos[i].Activo[0] == 1)
                {
                    int j = dgvProductos.RowCount;
                    dgvProductos.RowCount += 1;
                    dgvProductos[0, j].Value = Productos[i].IDProducto;
                    dgvProductos[2, j].Value = Productos[i].Nombre;
                    dgvProductos[3, j].Value = Productos[i].PrecioBase;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!CamposFaltantes)
            {
                Interface = new InterfaceUsuario(this);
                if (Interface.RegistrarMaterial(ObtenerRegistro))
                {
                    string Mensaje = "";
                    if (!ActualizarProMat(out Mensaje))
                        MessageBox.Show("Material registrado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        Validar.MensajeErrorOK("El material se registró sin embargo hubo un problema al asociar los productos, favor de cambiar los parámetros modificando el material en su opción correspondiente\n\n" + Mensaje);
                    Close();
                }
                else
                {
                    ////RegistroMaterial[] temp = Interface.BuscarUnMaterial(new RegistroMaterial(ObtenerRegistro.IDMaterial ,"", -1, -1));
                    //if (temp?[0]?.IDMaterial == ObtenerRegistro.IDMaterial)
                    //    Validar.MensajeErrorOK("El número clave ya ha sido usado anteriormente y no puede repetirse");
                    //else
                    //{
                    //    temp = Interface.BuscarUnMaterial(new RegistroMaterial(-1, tbNombre.Text, -1, -1));
                    //    bool Existe = false;
                    //    for (int i = 0; i < temp?.Length && !Existe; i++)
                    //        if (temp?[i]?.Nombre == tbNombre.Text)
                    //            Existe = true;
                    //    if (temp?[0]?.Nombre == ObtenerRegistro.Nombre)
                    //        Validar.MensajeErrorOK("El nombre ya ha sido usado anteriormente y no puede repetirse");
                    //    else
                    //        Validar.MensajeErrorBaseDeDatos();
                    //}
                }
            }
        }
    }
}
