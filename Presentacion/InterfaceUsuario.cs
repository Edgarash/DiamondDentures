using Control;
using Entidad;
using System.Windows.Forms;
using System;
using Presentacion.Usuario;
using Presentacion.Login;
using Presentacion.Recepcion;
using Presentacion.Configuracion;
using static Control.Pantalla;
using Presentacion.Laboratorio;
using Presentacion.Control_Pedidos;

namespace Presentacion
{
    public sealed class InterfaceUsuario
    {
        Manejador Manejador;
        Pantalla Pantalla;

        public InterfaceUsuario(Pantalla Invocadora)
        {
            Pantalla = Invocadora;
        }

        #region Módulo Usuario

        public void DesplegarPantallaMenuUsuario()
        {
            Manejador = new ManejadorLogin(Pantalla);
            PantallaMenuUsuario Nueva = new PantallaMenuUsuario();
            Nueva.Cerrar += delegate { Nueva.Close(); };
            Nueva.Show();
        }

        public RegistroDentista ObtenerUnDentista(string Cedula)
        {
            Manejador = new ManejadorRegistroDentista();
            return (Manejador as ManejadorRegistroDentista).ObtenerUnDentista(Cedula);
        }

        public bool RegistrarDentista(RegistroDentista Dentista)
        {
            Manejador = new ManejadorRegistroDentista();
            return (Manejador as ManejadorRegistroDentista).RegistrarDentista(Dentista);
        }

        public void DesplegarPantallaRegistrarPedido()
        {
            Manejador = new ManejadorRecepcion();
            Manejador.DesplegarPantalla(new PantallaRegistrarPedido());
        }

        public RegistroPedido ObtenerUnPedido(string ClavePedido)
        {
            Manejador = new ManejadorPedido();
            return (Manejador as ManejadorPedido).ObtenerUnPedido(ClavePedido);
        }

        public bool ActualizarDentista(RegistroDentista Dentista)
        {
            Manejador = new ManejadorRegistroDentista();
            return (Manejador as ManejadorRegistroDentista).ActualizarDentista(Dentista);
        }

        public bool RegistrarPedido(RegistroPedido Pedido)
        {
            Manejador = new ManejadorPedido();
            return (Manejador as ManejadorPedido).RegistrarPedido(Pedido);
        }

        public void DesplegarPantallaLaboratorio(string Usuario)
        {
            Manejador = new ManejadorPrincipal();
            Manejador.DesplegarPantalla(new PantallaMenuLaboratorio());
        }

        public void DesplegarPantallaModificarPedido(RegistroPedido Pedido)
        {
            Manejador = new ManejadorRecepcion();
            Manejador.DesplegarPantalla(new PantallaModificarPedido(Pedido));
        }

        public void DesplegarPantallaControlPedidos(string Usuario)
        {
            Manejador = new ManejadorRecepcion();
            Manejador.DesplegarPantalla(new PantallaMenuControlPedidos(Usuario));
        }

        public void DesplegarPantallaEstadoPedido(string Usuario)
        {
            Manejador = new ManejadorRecepcion();
            Manejador.DesplegarPantalla(new PantallaEstadoPedido(Usuario));
        }

        internal RegistroMaterial[] ObtenerMateriales()
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).ObtenerMateriales();
        }

        internal RegistroMaterial[] ObtenerMateriales3()
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).ObtenerMateriales3();
        }

        internal RegistroInsumos[] ObtenerInsumos3()
        {
            Manejador = new ManejadorRegistroInsumos();
            return (Manejador as ManejadorRegistroInsumos).ObtenerInsumos3();
        }

        internal RegistroMaterial[] ObtenerUnMaterial(string Nombre)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).ObtenerUnMaterial(Nombre);
        }

        internal RegistroMaterial[] ObtenerUnMaterial2(String Nombre)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).ObtenerUnMaterial2(Nombre);
        }

        internal RegistroMaterial[] ObtenerMateriales2()
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).ObtenerMateriales2();
        }


        internal HistorialMod[] SeleccHistorial()
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).SeleccHistorial();
        }

        internal RegistroProveedor[] MostrarProveedores()
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).MostrarProveedores();
        }

        internal FolioProveedor[] SeleccFolios()
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).SeleccFolios();
        }

        internal FolioProveedor[] SeleccUnFolio(int IDFolio)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).SeleccUnFolio(IDFolio);
        }

        internal RegistroProveedor[] MostrarUnProveedor(string Nombre)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).MostrarUnProveedor(Nombre);
        }

        internal Compras[] RecuperarCompras()
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).RecuperarCompras();
        }

        internal CompraMaterial[] DetallesMaterial(int IDCompra)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).DetallesMaterial(IDCompra);
        }

        internal CompraInsumos[] DetallesInsumos(int IDCompra)
        {
            Manejador = new ManejadorRegistroInsumos();
            return (Manejador as ManejadorRegistroInsumos).DetallesInsumos(IDCompra);
        }

        internal CompraMaterial[] DetallesProveedorMaterial(int IDProveedor)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).DetallesProveedorMaterial(IDProveedor);
        }

        internal CompraMaterial[] MostrarUnaCompra(CompraMaterial cm)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).MostrarUnaCompra(cm);
        }

        internal Compras ObtenerID()
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).ObtenerID();
        }

        internal RegistroMaterial[] MostrarFaltantes()
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).MostrarFaltantes();
        }

        public void DesplegarPantallaRegistrarUsuario(string User, int NumeroEmpleado)
        {
            Manejador = new ManejadorLogin(Pantalla);
            PantallaRegistroUsuario Nueva = new PantallaRegistroUsuario(User, NumeroEmpleado);
            ((ManejadorLogin)Manejador).DesplegarPantallaDialog(Nueva);
        }

        public bool RegistrarUsuario(RegistroUsuario Usuario)
        {
            Manejador = new ManejadorRegistroUsuario();
            bool Empleado = ((ManejadorRegistroUsuario)Manejador).ValidarEmpleado(Usuario.NumeroTrabajador);
            if (Empleado)
            {
                if (((ManejadorRegistroUsuario)Manejador).RegistrarUsuario(Usuario))
                {
                    MessageBox.Show("Usuario registrado con éxito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (((ManejadorRegistroUsuario)Manejador).ValidarUsuario(Usuario.Login))
                    {
                        MessageBox.Show("Lo sentimos, pero ese usuario ya existe", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Empleado = false;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error, por favor inténtelo más tarde", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Empleado = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("El numero de trabajador " + Usuario.NumeroTrabajador + " no existe, favor de contactar con un administrador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            return Empleado;
        }

        public void DesplegarPantallaModificarDentista(RegistroDentista Dentista)
        {
            Manejador = new ManejadorRecepcion();
            Manejador.DesplegarPantalla(new PantallaModificarDentista(Dentista));
        }

        public void DesplegarPantallaAgregarDentista()
        {
            Manejador = new ManejadorRecepcion();
            Manejador.DesplegarPantalla(new PantallaAgregarDentista());
        }

        public bool ActualizarPedido(RegistroPedido Pedido)
        {
            Manejador = new ManejadorPedido();
            return (Manejador as ManejadorPedido).ActualizarPedido(Pedido);
        }

        public bool ActualizarMaterial(RegistroMaterial Material)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).ActualizarMaterial(Material);
        }

        public bool ActivarMaterial(int Clave)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).ActivarMaterial(Clave);
        }

        public void DesplegarPantallaModificarMaterial(RegistroMaterial Material, Regresar Acción)
        {
            Manejador = new ManejadorConfiguracion();
            Pantalla = new PantallaModificarMaterial(Material);
            Pantalla.Cerrar += Acción;
            Manejador.DesplegarPantalla(Pantalla);
        }

        public RegistroMaterial ObtenerUnMaterial(int Clave)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).ObtenerUnMaterial(Clave);
        }

        public RegistroMaterial[] BuscarUnMaterial(RegistroMaterial Material)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).BuscarUnMaterial(Material);
        }

        public void DesplegarPantallaEliminarMaterial(RegistroMaterial materialAEliminar)
        {
            Manejador = new ManejadorConfiguracion();
            Manejador.DesplegarPantalla(new PantallaEliminarMaterial(materialAEliminar));
        }

        public void DesplegarPantallaCambiarPrecios()
        {
            Manejador = new ManejadorConfiguracion();
            Manejador.DesplegarPantalla(new PantallaCambiarPrecios());
        }

        internal void DesplegarPantallaAdministrarMateriales()
        {
            Manejador = new ManejadorConfiguracion();
            Manejador.DesplegarPantalla(new PantallaAdministrarMateriales());
        }

        public void DesplegarPantallaCambiarTiempos()
        {
            Manejador = new ManejadorConfiguracion();
            Manejador.DesplegarPantalla(new PantallaCambiarTiempos());
        }

        public bool RegistrarEmpleado(int NumeroEmpleado)
        {
            Manejador = new ManejadorUsuario();
            return ((ManejadorUsuario)Manejador).RegistrarEmpleado(NumeroEmpleado);
        }

        public bool PermisoDeAdministrador()
        {
            bool Cancelado;
            return PantallaPermisoAdministrador.PedirPermisoAdministrador(out Cancelado);
        }

        public bool HayAdministradores()
        {
            Manejador = new ManejadorUsuario();
            return ((ManejadorUsuario)Manejador).HayAdministradores();
        }

        public bool EliminarMaterial(int Clave)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).EliminarMaterial(Clave);
        }

        public bool ActualizarProMat(RegistroProMat Registro)
        {
            Manejador = new ManejadorConfiguracion();
            return (Manejador as ManejadorConfiguracion).ActualizarProMat(Registro);
        }

        public bool EliminarTarjeta(string Usuario)
        {
            Manejador = new ManejadorUsuario();
            return ((ManejadorUsuario)Manejador).EliminarTarjeta(Usuario);
        }

        internal RegistroProMat[] ObtenerProMat(int Mat, int Pro)
        {
            Manejador = new ManejadorConfiguracion();
            return (Manejador as ManejadorConfiguracion).ObtenerProMat(Mat, Pro);
        }

        public bool BorrarUsuario(string Usuario)
        {
            Manejador = new ManejadorUsuario();
            return ((ManejadorUsuario)Manejador).BorrarUsuario(Usuario);
        }

        public bool ActivarUsuario(string Usuario)
        {
            Manejador = new ManejadorUsuario();
            return ((ManejadorUsuario)Manejador).ActivarUsuario(Usuario);
        }

        public void DesplegarPantallaModificarUsuario(string Usuario)
        {
            Manejador = new ManejadorUsuario();
            RegistroUsuario Registro;
            ((ManejadorUsuario)Manejador).RecuperarUsuario(Usuario, out Registro);
            PantallaModificarUsuario Nueva = new PantallaModificarUsuario(Registro);
            Manejador.DesplegarPantallaDialog(Nueva);
        }

        public void DesplegarPantallaModificarUsuario(string Usuario, bool Administrador)
        {
            Manejador = new ManejadorUsuario();
            RegistroUsuario Registro;
            ((ManejadorUsuario)Manejador).RecuperarUsuario(Usuario, out Registro);
            PantallaModificarUsuario Nueva = new PantallaModificarUsuario(Registro, true);
            Manejador.DesplegarPantallaDialog(Nueva);
        }

        public void RecuperarUsuario(string Usuario, out RegistroUsuario Registro)
        {
            Manejador = new ManejadorUsuario();
            ((ManejadorUsuario)Manejador).RecuperarUsuario(Usuario, out Registro);
        }

        public bool ActualizarUsuario(string User, RegistroUsuario Usuario)
        {
            Manejador = new ManejadorRegistroUsuario();
            return ((ManejadorRegistroUsuario)Manejador).ActualizarUsuario(User, Usuario);
        }

        public void DesplegarPantallaRegistrarTarjeta(string Usuario)
        {
            Manejador = new ManejadorUsuario();
            PantallaAgregarTarjeta Temporal = new PantallaAgregarTarjeta(Usuario);
            ((ManejadorUsuario)Manejador).DesplegarPantallaDialog(Temporal);
        }

        public bool AgregarTarjeta(RegistroTarjeta Tarjeta)
        {
            Manejador = new ManejadorUsuario();
            return ((ManejadorUsuario)Manejador).AgregarRegistroTarjeta(Tarjeta);
        }

        public bool ActualizarTarjeta(RegistroTarjeta Tarjeta)
        {
            Manejador = new ManejadorRegistroTarjeta();
            return ((ManejadorRegistroTarjeta)Manejador).ActualizarRegistroTarjeta(Tarjeta);
        }

        public bool ValidarDatosTarjeta(string Usuario)
        {
            Manejador = new ManejadorRegistroTarjeta();
            return ((ManejadorRegistroTarjeta)Manejador).ValidarDatosTarjeta(Usuario);
        }

        public void DesplegarPantallaModificarTarjeta(string Usuario)
        {
            Manejador = new ManejadorUsuario();
            RegistroTarjeta Registro;
            if (((ManejadorUsuario)Manejador).RecuperarTarjeta(Usuario, out Registro))
            {
                PantallaModificarTarjeta Temporal = new PantallaModificarTarjeta(Registro);
                ((ManejadorUsuario)Manejador).DesplegarPantallaDialog(Temporal);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Usted no tiene una tarjeta registrada\n\n¿Desea añadir una nueva tarjeta?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))
                {
                    DesplegarPantallaRegistrarTarjeta(Usuario);
                }
            }
        }

        public bool RecuperarUsuarioN(int Empleado, out RegistroUsuario User)
        {
            Manejador = new ManejadorRegistroUsuario();
            return ((ManejadorRegistroUsuario)Manejador).RecuperarUsuarioN(Empleado, out User);
        }

        public bool RegistrarTarjeta(RegistroTarjeta Tarjeta)
        {
            Manejador = new ManejadorRegistroTarjeta();
            return ((ManejadorRegistroTarjeta)Manejador).AgregarRegistroTarjeta(Tarjeta);
        }

        public void CrearRegistroTarjeta(RegistroTarjeta RegistroTarjeta, out RegistroTarjeta Tarjeta)
        {
            PantallaAgregarTarjeta Temporal = new PantallaAgregarTarjeta("");
            Temporal.CrearRegistroTarjeta(RegistroTarjeta, out Tarjeta);
        }

        public bool EsAdministrador(string Usuario)
        {
            RegistroUsuario temp;
            RecuperarUsuario(Usuario, out temp);
            if (temp != null)
            {
                return temp.Departamento == "ADMINISTRACION" && temp.Activo== "1";
            }
            return false;
        }

        public void RegistrarNumeroEmpleado()
        {
            PantallaRecuperarContraseña temp = new PantallaRecuperarContraseña();
            int numero = temp.ObtenerNumero();
            Manejador = new ManejadorUsuario();
            if (numero != -1)
            {
                if (!new ManejadorRegistroUsuario().ValidarEmpleado(numero))
                {
                    if (((ManejadorUsuario)Manejador).RegistrarEmpleado(numero))
                    {
                        MessageBox.Show("Número de empleado registrado correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un problema, por favor inténtelo más tarde", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("El número de empleado " + numero + " ya existe", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        public bool ValidarEmpleado(out int numero, out DialogResult Resultado)
        {
            Manejador = new ManejadorRegistroUsuario();
            PantallaRecuperarContraseña temp = new PantallaRecuperarContraseña();
            numero = temp.VerficarNumero(out Resultado);
            bool Validado = false;
            if (Resultado == DialogResult.Yes)
            {
                if (numero != -1)
                {
                    Validado = ((ManejadorRegistroUsuario)Manejador).ValidarEmpleado(numero);
                }
            }
            return Validado;
        }

        public bool ValidarEmpleadoRegistrado(int Numero)
        {
            Manejador = new ManejadorRegistroUsuario();
            return ((ManejadorRegistroUsuario)Manejador).ValidarEmpleadoRegistrado(Numero);
        }

        public void ObtenerUsuarios(DataGridView data)
        {
            Manejador = new ManejadorUsuario();
            ((ManejadorUsuario)Manejador).ObtenerUsuarios(data);
        }

        #endregion

        #region Módulo Recepcion

        public void DesplegarPantallaRecepcion()
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DesplegarPantalla(new PantallaRecepcion());
        }



        #endregion

        #region Módulo Configuración

        public void DesplegarPantallaConfiguracion()
        {
            Manejador = new ManejadorPrincipal();
            Manejador.DesplegarPantalla(new PantallaConfiguracion());
        }

        public void DesplegarPantallaAgregarProducto(Regresar Accion)
        {
            Manejador = new ManejadorConfiguracion();
            Pantalla = new PantallaAgregarProducto();
            Pantalla.Cerrar += Accion;
            Manejador.DesplegarPantalla(Pantalla);

        }

        public void DesplegarPantallaAdministrarProductos()
        {
            Manejador = new ManejadorConfiguracion();
            Manejador.DesplegarPantalla(new PantallaAdministrarProducto());
        }

        public void DesplegarPantallaModificarProducto(RegistroProducto Producto)
        {
            Manejador = new ManejadorConfiguracion();
            Manejador.DesplegarPantalla(new PantallaModificarProducto(Producto));
        }

        public void DesplegarPantallaModificarProducto(RegistroProducto Producto, Regresar Actualizar)
        {
            Manejador = new ManejadorConfiguracion();
            PantallaModificarProducto Pantalla = new PantallaModificarProducto(Producto);
            Pantalla.Cerrar += Actualizar;
            Manejador.DesplegarPantalla(Pantalla);
        }

        public void DesplegarPantallaEliminarProducto(RegistroProducto Producto, Regresar Actualizar)
        {
            Manejador = new ManejadorConfiguracion();
            Pantalla = new PantallaEliminarProducto(Producto);
            Pantalla.Cerrar += Actualizar;
            Manejador.DesplegarPantalla(Pantalla);
        }

        public void DesplegarPantallaAgregarMaterial(Regresar Actualizar)
        {
            Manejador = new ManejadorConfiguracion();
            Manejador.DesplegarPantalla(new PantallaAgregarMaterial());
        }

        public bool RegistrarProducto(RegistroProducto Registro)
        {
            Manejador = new ManejadorConfiguracion();
            return ((ManejadorConfiguracion)Manejador).RegistrarProducto(Registro);
        }

        public bool ActivarProducto(int Clave)
        {
            Manejador = new ManejadorRegistroProducto();
            return (Manejador as ManejadorRegistroProducto).ActivarProducto(Clave);
        }

        public bool ActualizarProducto(RegistroProducto Producto)
        {
            Manejador = new ManejadorRegistroProducto();
            return (Manejador as ManejadorRegistroProducto).ActualizarProducto(Producto);
        }

        public bool EliminarProducto(int Clave)
        {
            Manejador = new ManejadorRegistroProducto();
            return ((ManejadorRegistroProducto)Manejador).EliminarProducto(Clave);
        }

        public RegistroProducto[] ObtenerProductos()
        {
            Manejador = new ManejadorConfiguracion();
            return ((ManejadorConfiguracion)Manejador).ObtenerProductos();
        }

        public RegistroProducto[] BuscarUnProducto(RegistroProducto Registro)
        {
            Manejador = new ManejadorConfiguracion();
            return ((ManejadorConfiguracion)Manejador).BuscarUnProducto(Registro);
        }

        public RegistroProducto ObtenerUnProducto(string Proceso)
        {
            Manejador = new ManejadorConfiguracion();
            return ((ManejadorConfiguracion)Manejador).ObtenerUnProducto(Proceso);
        }

        public bool RegistrarMaterial(RegistroMaterial Material)
        {
            Manejador = new ManejadorRegistroMaterial();
            return (Manejador as ManejadorRegistroMaterial).RegistrarMaterial(Material);
        }

        #endregion

        #region Módulo Login

        public void DesplegarPantallaRecuperarContraseña()
        {
            Manejador = new ManejadorLogin((PantallaLogin)Pantalla);
            PantallaRecuperarContraseña temp = new PantallaRecuperarContraseña();
            ((ManejadorLogin)Manejador).DesplegarPantallaRecuerarContraseña(temp);
        }

        public string RecuperarPregunta(int NumeroEmpleado)
        {
            Manejador = new ManejadorRegistroUsuario();
            return ((ManejadorRegistroUsuario)Manejador).RecuperarPregunta(NumeroEmpleado);
        }

        public bool ValidarRespuesta(int Trabajador, string Resp)
        {
            Manejador = new ManejadorRegistroUsuario();
            return ((ManejadorRegistroUsuario)Manejador).ValidarRespuesta(Trabajador, Resp);
        }

        #endregion

        #region Módulo Control Pedidos

        public void ObtenerProductos(DataGridView data)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).ObtenerProductos(data);
        }

        public void BuscarIdPedido(DataGridView data, string valor)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).BuscarIdPedido(data, valor);
        }

        public void BuscarIdDentista(DataGridView data, string cedula)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).BuscarIdDentista(data, cedula);
        }
        public void BuscarTipo(DataGridView data, string valor)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).BuscarTipo(data, valor);
        }
        public void BusquedaIdPedido(DataGridView data, string valor)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).BusquedaIdPedido(data, valor);
        }
        public void BusquedaTipo(DataGridView data, string valor)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).BusquedaTipo(data, valor);
        }
        public void CambiarLaboratorista(DataGridView temp, string nuevo, string id)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).CambiarLaboratorista(temp, nuevo, id);
        }
        public void CambiarEstado(DataGridView temp, string valor, string a, string id)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).CambiarEstado(temp, valor, a, id);
        }

        #endregion

        #region Módulo Laboratorio

        public void EstadoProcesar(DataGridView temp, string valor, string id, string user)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).EstadoProcesar(temp, valor, id, user);
        }
        public void CancelarPedido(DataGridView temp, string id)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).CancelarPedido(temp, id);
        }
        public void CancelarPieza(DataGridView temp, string id)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).CancelarPieza(temp, id);
        }
        public void ObtenerNombrePieza(DataGridView temp, string id)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).ObtenerNombrePieza(temp, id);
        }
        public void DatosPedidos(DataGridView temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosPedidos(temp);
        }

        public void DatosProductos(DataGridView temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosProductos(temp);
        }
        public void ObtenerIdPiezas(DataGridView temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).ObtenerIdPiezas(temp);
        }
        public string ObtenerTipoUser(string usuario)
        {
            Manejador = new ManejadorPrincipal();
            return ((ManejadorPrincipal)Manejador).ObtenerTipoUser(usuario);
        }
        public void ObtenerUsuariosActivos(ComboBox cbtrabaja)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).ObtenerUsuariosActivos(cbtrabaja);
        }
        public bool PedidosEnProcesoPorUsuario(string usuario, string estado)
        {
            Manejador = new ManejadorPrincipal();
            return ((ManejadorPrincipal)Manejador).PedidosEnProcesoPorUsuario(usuario, estado);
        }
        public bool PedidosPorUserLaboratorio(string usuario, string estado)
        {
            Manejador = new ManejadorPrincipal();
            return ((ManejadorPrincipal)Manejador).PedidosPorUserLaboratorio(usuario, estado);
        }

        #endregion

        #region Modulo Finanzas
        public void DatosDVentas(DataGridView temp, string fech)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDVentas(temp, fech);
        }
        public void DatosDBuscarVentas(DataGridView temp, string nomb, string idp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDBuscarVentas(temp,nomb,idp);
        }
        public void DatosDTotalVentas(TextBox temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDTotalVentas(temp);
        }
        public void DatosDGastos(DataGridView temp, string f)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDGastos(temp, f);
        }
        public void DatosDAutualizarRegistroGastos(string id)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDAutualizarRegistroGastos(id);
        }
        public void DatosDRegistroPagos(DataGridView temp, string nom, string des, string punit, string cant, string subt,
            string tot, string est, string reg, string id)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDRegistroPagos(temp, nom, des, punit, cant, subt, tot, est, reg, id);
        }
        public void DatosDTotalGastos(TextBox temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDTotalGastos(temp);
        }
        public void DatosDPagosTrab(DataGridView temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDPagosTrab(temp);
        }
        public void DatosDTotalPagosTrab(TextBox temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDTotalPagosTrab(temp);
        }
                
        public void CPObtenerLaboratoristas(ComboBox temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).CPObtenerLaboratoristas(temp);
        }
        public void DatosComboIDUsuarios(ComboBox temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosComboIDUsuarios(temp);
        }
        public void DatosComboNombProveedor(TextBox temp,string id)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosComboNombProveedor(temp, id);
        }
        public void DatosNombreUsuarios(TextBox emp, string temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosNombreUsuarios(emp,temp);
        }
        public void DatosComboObtenerIDProveedores(TextBox emp, string temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosComboObtenerIDProveedores(emp,temp);
        }
        public void DatosComboObtenerBanco(TextBox emp, string temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosComboObtenerBanco(emp,temp);
        }
        public void DatosDVerRequisicion(DataGridView emp, string temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDVerRequisicion(emp,temp);
        }
        public void DatosComboObtenerNumeroCuenta(TextBox emp, string temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosComboObtenerNumeroCuenta(emp,temp);
        }
        public void DatosDVerProductosDeProveedor(DataGridView emp, string temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDVerProductosDeProveedor(emp,temp);
        }
        public void DatosDVerMaterialesDeProveedor(DataGridView emp, string temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDVerMaterialesDeProveedor(emp, temp);
        }
        public void DatosAgregarAsistencia(DataGridView temp, string id, string emp, string fec, string hEnt, string hSal)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosAgregarAsistencia(temp, id, emp, fec, hEnt, hSal);
        }
        public void DatosDInsumos(DataGridView temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDInsumos(temp);
        }
        public void DatosDTotalInsumos(TextBox temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDTotalInsumos(temp);
        }
        
        public void DatosDPagos(DataGridView temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDPagos(temp);
        }
        public void DatosDBuscarAdminPagos(DataGridView temp, string id, string nomb)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDBuscarAdminPagos(temp,id,nomb);
        }
        public void DatosDTotalIngresos(TextBox temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDTotalIngresos(temp);
        }
        public void ComprarInsumos(TextBox txID, TextBox txNomb, TextBox txDesc, TextBox txCant, TextBox txPrUni, string p)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).ComprarInsumos(txID, txNomb, txDesc, txCant, txPrUni,p);
        }
        public void AgregarCompra(string nom, string tot)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).AgregarCompra(nom, tot);
        }
        public void DatosDEmpleados(DataGridView temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDEmpleados(temp);
        }
        public void DatosDUltipoIDCompra(DataGridView temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDUltipoIDCompra(temp);
        }
        public void DatosDAsistencia(DataGridView temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDAsistencia(temp);
        }
        public void DatosDNomina(DataGridView temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDNomina(temp);
        }
        public void DatosDTotalNomina(TextBox temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDTotalNomina(temp);
        }
        public void DatosComboListaNombProveedor(ComboBox temp)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosComboListaNombProveedor(temp);
        }
        public void DatosDAgregarNomina(DataGridView temp, string nemp, string fec, string nomb, string ape, string rfc, 
            string mail, string dep, string pues, string dlab, string suel, string isr, string descisr, string sfinal, string pag)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDAgregarNomina(temp, nemp, fec, nomb, ape, rfc, mail, dep, pues, dlab, suel, isr, descisr, sfinal, pag);
        }
        public void DatosDBalanceCuentasIngresos(DataGridView temp, string fec)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDBalanceCuentasIngresos(temp, fec);
        }
        public void DatosDAgregarBalanceCuentasIngresos(DataGridView temp, string des, string val, string fec)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDAgregarBalanceCuentasIngresos(temp, des, val, fec);
        }
        public void DatosDAgregarBalanceCuentasEgresos(DataGridView temp, string des, string val, string fec)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDAgregarBalanceCuentasEgresos(temp, des, val, fec);
        }
        public void DatosDBalanceCuentasEgresos(DataGridView temp, string fec)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDBalanceCuentasEgresos(temp,fec);
        }

        public void DatosDActualizarPago(int id)
        {
            Manejador = new ManejadorPrincipal();
            ((ManejadorPrincipal)Manejador).DatosDActualizarPago(id);
        }

        #endregion


        public DialogResult DesplegarPantallaMenuPrincipal(string Login, string Password, ref int Intentos)
        {
            Manejador = new ManejadorLogin(Pantalla);
            PantallaMenuPrincipal Nueva = new PantallaMenuPrincipal(Login, ((PantallaLogin)Pantalla));
            DialogResult temp = DialogResult.No;
            if ("Usuario No Existe" == ((ManejadorLogin)Manejador).DesplegarPantallaMenuUsuario(Login, Password, Nueva))
            {
                temp = MessageBox.Show("No existe el usuario\n\n¿Desea crearlo?", "USUARIO NO ENCONTRADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Intentos++;
            }
            if (Intentos == 5)
            {
                MessageBox.Show("Abuso de intentos, el sistema se cerrará", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Application.Exit();
            }
            return temp;
        }
    }
}