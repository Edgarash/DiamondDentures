using Entidad;
using Presentacion.Recepcion;
using System;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Configuracion
{
    public partial class PantallaConfiguracion : Control.Pantalla
    {
        string Usuario;
        InterfaceUsuario Interface;

        public PantallaConfiguracion(string User)
        {
            InitializeComponent();
            InitializeComponent2();
            Usuario = User;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaAgregarProducto().GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaAgregarProducto(null);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaAdministrarProducto().GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaAdministrarProductos();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            PantallaPedirInformación temp = new PantallaPedirInformación();
            bool Cancelado = true;
            RegistroProducto ProductoAEliminar = temp.PedirProducto(out Cancelado);
            if (!Cancelado)
            {
                if (ProductoAEliminar == null)
                {
                    if (DialogResult.Yes == MessageBox.Show("No se encontró el producto a eliminar\n\n¿desea ver una lista de todos los productos?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        btnModificarProducto_Click(sender, e);
                    }
                }
                else
                {
                    if (!Validar.ValidarUnaPantalla(new PantallaEliminarProducto(null).GetType()))
                    {
                        Interface = new InterfaceUsuario(this);
                        Interface.DesplegarPantallaEliminarProducto(ProductoAEliminar, null);
                    }
                }
            }
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaAgregarMaterial().GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaAgregarMaterial(null);
            }
        }

        private void btnModificarMaterial_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaAdministrarMateriales().GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaAdministrarMateriales();
            }
        }

        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            PantallaPedirInformación temp = new PantallaPedirInformación();
            bool Cancelado = true;
            RegistroMaterial MaterialAEliminar = temp.PedirMaterial(out Cancelado);
            if (!Cancelado)
            {
                if (MaterialAEliminar == null)
                {
                    if (DialogResult.Yes == MessageBox.Show("No se encontró el Material a eliminar\n\n¿desea ver una lista de todos los materiales?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                    {
                        btnModificarMaterial_Click(sender, e);
                    }
                }
                else
                {
                    if (!Validar.ValidarUnaPantalla(new PantallaEliminarProducto(null).GetType()))
                    {
                        Interface = new InterfaceUsuario(this);
                        Interface.DesplegarPantallaEliminarMaterial(MaterialAEliminar);
                    }
                }
            }
        }

        private void btnCambiarPrecios_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaCambiarPrecios().GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaCambiarPrecios();
            }
        }

        private void btnCambiarTiempos_Click(object sender, EventArgs e)
        {
            if (!Validar.ValidarUnaPantalla(new PantallaCambiarTiempos().GetType()))
            {
                Interface = new InterfaceUsuario(this);
                Interface.DesplegarPantallaCambiarTiempos();
            }
        }
    }
}