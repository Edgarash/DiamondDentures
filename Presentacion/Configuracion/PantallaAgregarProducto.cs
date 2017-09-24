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
    public partial class PantallaAgregarProducto : PantallaProducto
    {
        public PantallaAgregarProducto()
        {
            InitializeComponent();
            InitializeComponent2();
            InitializeComponent3();
        }

        protected override void InitializeComponent3()
        {
            base.InitializeComponent3();
            Interface = new InterfaceUsuario(this);
            RegistroProducto[] Productos = Interface.ObtenerProductos();
            tbClave.Enabled = true;
            tbClave.Text = Productos?.Length > 0 ? (Productos?[Productos.Length - 1]?.Clave + 1)?.ToString() : "0";
            RegistroMaterial[] Materiales = Interface.BuscarUnMaterial(new RegistroMaterial(-1, "", -1, -1));
            for (int i = 0; i < Materiales?.Length; i++)
            {
                if (Materiales[i].Activo == 1)
                {
                    int j = dgvMateriales.RowCount;
                    dgvMateriales.RowCount += 1;
                    dgvMateriales[0, j].Value = Materiales[i].Clave;
                    dgvMateriales[2, j].Value = Materiales[i].Nombre;
                    dgvMateriales[3, j].Value = Materiales[i].Precio;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos)
            {
                Interface = new InterfaceUsuario(this);
                RegistroProducto temp = ObtenerRegistro;
                temp.Clave = Convert.ToInt32(tbClave.Text);
                if (Interface.RegistrarProducto(temp))
                {
                    string Mensaje = "";
                    if (!ActualizarProMat(out Mensaje))
                        MessageBox.Show("Producto registrado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        Validar.MensajeErrorOK("El producto se registró sin embargo hubo un problema al asociar los materiales, favor de cambiar los parámetros modificando el producto en su opción correspondiente\n\n" + Mensaje);
                    Close();
                }
                else
                {
                    RegistroProducto[] Productos = Interface.BuscarUnProducto(new RegistroProducto(ObtenerRegistro.Clave, "", -1, -1,-1));
                    if (Productos?[0]?.Clave == ObtenerRegistro.Clave)
                        Validar.MensajeErrorOK("El número clave ya ha sido usado anteriormente y no puede repetirse");
                    else
                    {
                        Productos = Interface.BuscarUnProducto(new RegistroProducto(-1, tbNombre.Text, -1, -1, -1));
                        bool Existe = false;
                        for (int i = 0; i < Productos?.Length && !Existe; i++)
                            if (Productos?[i]?.Nombre == tbNombre.Text)
                                Existe = true;
                        if (Existe)
                            Validar.MensajeErrorOK("El nombre ya ha sido usado anteriormente y no puede repetirse");
                        else
                            Validar.MensajeErrorBaseDeDatos();
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
