using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConexionBaseDeDatos
{
    /// <summary>
    /// Describe los métodos para accesar a una base de datos de MySQL
    /// </summary>
    public static partial class InterfaceMySQL
    {
        //En esta clase sólo Michell deberá meter sólo los métodos y atributos que ocupe
        
        public static bool RecuperarPedido(string IDPedido, out RegistroPedido Pedido)
        {
            EjecutarProcedimientoAlmacenado("RecuperarPedido", TipoConsulta.DevuelveReader,
                Parametro("IDPedid", IDPedido));
            bool Exito = OperacionRealizada2;
            Pedido = ObtenerPedido();
            return Exito;
        }

        private static RegistroPedido ObtenerPedido()
        {
            RegistroPedido[] x = RellenarPedidos();
            RegistroPedido temp = x.Length > 0 ? x[0] : null;
            RegistrosAfectados = temp != null ? 1 : 0;
            return temp;
        }

        public static bool ObtenerPedidos(out RegistroPedido[] Pedidos)
        {
            Pedidos = null;
            EjecutarProcedimientoAlmacenado("ObtenerPedidos", TipoConsulta.DevuelveReader,
                Parametro("", null));
            bool Exito = OperacionRealizada2;
            Pedidos = RellenarPedidos();
            return Exito;
        }

        private static RegistroPedido[] RellenarPedidos()
        {
            RegistroPedido[] Pedidos = new RegistroPedido[TablaDeResultados.Rows.Count];
            DataTable PedidosTemp = TablaDeResultados;
            Pedidos = new RegistroPedido[PedidosTemp.Rows.Count];
            for (int i = 0; i < Pedidos.Length; i++)
            {
                DataRow x = PedidosTemp.Rows[i];
                RegistroUsuario RegistroPedido;
                RegistroDentista Dentista;
                RegistroUsuario Laboratorista;
                RegistroTrabajo[] Trabajos;
                RecuperarUsuario(x["IDEmpleado"].ToString(), out RegistroPedido);
                RecuperarDentista(x["Cedula"].ToString(), out Dentista);
                RecuperarUsuario(x["Laboratorista"].ToString(), out Laboratorista);
                RecuperarProducto_Pedido(x["IDPedido"].ToString(), out Trabajos);
                DateTime FI = ObtenerFecha(x["FechaIngreso"].ToString());
                DateTime FC = ObtenerFecha(x["FechaCalculada"].ToString());
                DateTime FE = ObtenerFecha(x["FechaEntrega"].ToString());
                Pedidos[i] = new RegistroPedido
                    (
                    x["IDPedido"].ToString(),
                    RegistroPedido,
                    Dentista,
                    Convert.ToInt32(x["EstadoPedido"].ToString()),
                    FI,
                    FC,
                    FE,
                    x["Entregado"].ToString(),
                    x["Urgencia"].ToString(),
                    Convert.ToSingle(x["CostoTotal"].ToString()),
                    Laboratorista,
                    x["Pagado"].ToString(),
                    Convert.ToSingle(x["RestantePagar"].ToString()),
                    Trabajos
                    );
            }
            return Pedidos;
        }

        #region Configuracion

        public static bool RecuperarProducto(int IDProducto, out RegistroProducto Producto)
        {
            EjecutarProcedimientoAlmacenado("RecuperarProducto", TipoConsulta.DevuelveReader,
                Parametro("IDProduct", IDProducto));
            Producto = ObtenerProducto();
            return OperacionRealizada2;
        }

        public static bool ObtenerProductos(out RegistroProducto[] Productos)
        {
            EjecutarProcedimientoAlmacenado("ObtenerProductos", TipoConsulta.DevuelveReader,
                Parametro("", null));
            Productos = RellenarProductos();
            return OperacionRealizada2;
        }
         
        private static RegistroProducto ObtenerProducto()
        {
            RegistroProducto[] x =  RellenarProductos();
            RegistroProducto temp = x.Length > 0 ? x[0] : null;
            RegistrosAfectados = temp != null ? 1 : 0;
            return temp;
        }

        private static RegistroProducto[] RellenarProductos()
        {
            RegistroProducto[] Productos = new RegistroProducto[TablaDeResultados.Rows.Count];
            for (int i = 0; i < Productos.Length; i++)
            {
                DataRow Registro = TablaDeResultados.Rows[i];
                Productos[i] = new RegistroProducto
                    (
                    Convert.ToInt32(Registro["IDProducto"].ToString()),
                    Registro["Nombre"].ToString(),
                    Registro["Descripcion"].ToString(),
                    Convert.ToInt32(Registro["TiempoBase"].ToString()),
                    Convert.ToSingle(Registro["PrecioBase"].ToString()),
                    Convert.ToSingle(Registro["PrecioCompra"].ToString()),
                    Registro["Activo"].ToString() == "1",
                    Registro["UnidadMedida"].ToString(),
                    Convert.ToInt32(Registro["Cantidad"].ToString())
                    );
            }
            return Productos;
        }             

        public static bool ObtenerMateriales(out RegistroMaterial[] Materiales)
        {
            EjecutarProcedimientoAlmacenado("ObtenerMateriales", TipoConsulta.DevuelveReader,
                Parametro("", null));
            bool Exito = OperacionRealizada2;
            Materiales = RellenarMateriales();
            return Exito;
        }

        public static bool RecuperarMaterial(int IDMaterial, out RegistroMaterial Material)
        {
            EjecutarProcedimientoAlmacenado("RecuperarMaterial", TipoConsulta.DevuelveReader,
                Parametro("IDMateria", IDMaterial));
            bool Exito = OperacionRealizada2;
            Material = ObtenerMaterial();
            return Exito;
        }

        private static RegistroMaterial ObtenerMaterial()
        {
            RegistroMaterial[] x = RellenarMateriales();
            RegistroMaterial temp = x.Length > 0 ? x[0] : null;
            RegistrosAfectados = temp != null ? 1 : 0;
            return temp;
        }

        private static RegistroMaterial[] RellenarMateriales()
        {
            RegistroMaterial[] Materiales = new RegistroMaterial[TablaDeResultados.Rows.Count];
            DataTable Mats = TablaDeResultados;
            for (int i = 0; i < Materiales.Length; i++)
            {
                DataRow x = Mats.Rows[i];
                RegistroProveedor Proveedor;
                RecuperarProveedor(Convert.ToInt32(x["Proveedor"].ToString()), out Proveedor);
                Materiales[i] = new RegistroMaterial
                    (
                    Convert.ToInt32(x["IDMaterial"].ToString()),
                    x["Nombre"].ToString(),
                    x["Descripcion"].ToString(),
                    Convert.ToSingle(x["PrecioBase"].ToString()),
                    Convert.ToSingle(x["PrecioCompra"].ToString()),
                    Convert.ToInt32(x["TiempoBase"].ToString()),
                    Proveedor,
                    x["UnidadMedida"].ToString(),
                    Convert.ToInt32(x["Cantidad"].ToString())
                    );
            }
            return Materiales;
        }

        public static bool RecuperarProveedor(int IDProveedor, out RegistroProveedor Proveedor)
        {
            EjecutarProcedimientoAlmacenado("RecuperarProveedor", TipoConsulta.DevuelveReader,
                Parametro("Proveedo", IDProveedor));
            Proveedor = ObtenerProveedor();
            return OperacionRealizada2;
        }

        private static RegistroProveedor ObtenerProveedor()
        {
            RegistroProveedor[] x = RellenarProveedores();
            RegistroProveedor temp = x.Length > 0 ? x[0] : null;
            RegistrosAfectados = temp != null ? 1 : 0;
            return temp;
        }

        private static RegistroProveedor[] RellenarProveedores()
        {
            RegistroProveedor[] Proveedores = new RegistroProveedor[TablaDeResultados.Rows.Count];
            for (int i = 0; i < Proveedores.Length; i++)
            {
                DataRow x = TablaDeResultados.Rows[i];
                Proveedores[i] = new RegistroProveedor
                    (
                    Convert.ToInt32(x["IDProveedor"].ToString()),
                    x["Nombre"].ToString(),
                    x["Telefono"].ToString(),
                    x["Correo"].ToString(),
                    x["Direccion"].ToString(),
                    x["Descripcion"].ToString(),
                    x["Banco"].ToString(),
                    x["NumeroCuenta"].ToString()
                    );
            }
            return Proveedores;
        }

        #endregion

        #region Recepcion

        public static bool RecuperarDentista(string Cedula, out RegistroDentista Dentista)
        {
            EjecutarProcedimientoAlmacenado("RecuperarDentista", TipoConsulta.DevuelveReader,
                Parametro("Cedul", Cedula));
            Dentista = ObtenerDentista();
            return OperacionRealizada2;
        }

        private static RegistroDentista ObtenerDentista()
        {
            RegistroDentista[] x = RellenarDentistas();
            RegistroDentista temp = x.Length > 0 ? x[0] : null;
            RegistrosAfectados = temp != null ? 1 : 0;
            return temp;
        }

        private static RegistroDentista[] RellenarDentistas()
        {
            RegistroDentista[] Dentistas = new RegistroDentista[TablaDeResultados.Rows.Count];
            for (int i = 0; i < Dentistas.Length; i++)
            {
                DataRow x = TablaDeResultados.Rows[i];
                Dentistas[i] = new RegistroDentista
                    (
                    x["Cedula"].ToString(),
                    x["RFC"].ToString(),
                    x["Nombre"].ToString(),
                    x["Apellidos"].ToString(),
                    x["TelOficina"].ToString(),
                    x["Pais"].ToString(),
                    x["Estado"].ToString(),
                    x["Municipio"].ToString(),
                    x["Ciudad"].ToString(),
                    x["Colonia"].ToString(),
                    x["Direccion"].ToString(),
                    x["CodPos"].ToString(),
                    x["Email"].ToString(),
                    x["Activo"].ToString(),
                    x["Consultorio"].ToString(),
                    Convert.ToDateTime(x["FechaAlta"].ToString())
                    );
            }
            return Dentistas;
        }

        public static bool RecuperarProducto_Pedido(string IDPedido, out RegistroTrabajo[] Trabajos)
        {
            EjecutarProcedimientoAlmacenado("RecuperarTrabajos", TipoConsulta.DevuelveReader,
                Parametro("IDPedid", IDPedido));
            bool Exito = OperacionRealizada2;
            Trabajos = RellenarTrabajos();
            return Exito;
        }

        private static RegistroTrabajo[] RellenarTrabajos()
        {
            RegistroTrabajo[] Trabajos = new RegistroTrabajo[TablaDeResultados.Rows.Count];
            DataTable Trabs = TablaDeResultados;
            for (int i = 0; i < Trabajos.Length; i++)
            {
                DataRow x = Trabs.Rows[i];
                RegistroProducto Producto;
                RegistroMaterial Material1;
                RegistroMaterial Material2;
                RecuperarProducto(Convert.ToInt32(x["IDProducto"].ToString()), out Producto);
                RecuperarMaterial(Convert.ToInt32(x["IDMaterial1"].ToString()), out Material1);
                string temp = string.IsNullOrWhiteSpace(x["IDMaterial2"].ToString()) ? "0" : x["IDMaterial2"].ToString();
                RecuperarMaterial(Convert.ToInt32(temp), out Material2);

                Trabajos[i] = new RegistroTrabajo
                    (
                    x["IDPedido"].ToString(),
                    Producto,
                    Material1,
                    Material2
                    );
            }
            return Trabajos;
        }

        #endregion

        #region Configuración
        #region Materiales

        public static bool ObtenerUltimaClaveMaterial(out RegistroMaterial Material)
        {
            EjecutarProcedimientoAlmacenado("ObtenerUltimaClaveMaterial", TipoConsulta.DevuelveReader,
                null);
            bool Ejecutado = OperacionRealizada2;
            Material = ObtenerMaterial();
            return Ejecutado;
        }

        public static bool ObtenerProveedores(out RegistroProveedor[] Proveedores)
        {
            EjecutarProcedimientoAlmacenado("ObtenerProveedores", TipoConsulta.DevuelveReader,
                null);
            bool Ejecutado = OperacionRealizada2;
            Proveedores = RellenarProveedores();
            return Ejecutado;

        }

        public static bool RegistrarMaterial(RegistroMaterial Material)
        {
            EjecutarProcedimientoAlmacenado("RegistrarMaterial", TipoConsulta.DevuelveInt,
                Parametro("IDMateria", Material.IDMaterial),
                Parametro("Nombr", Material.Nombre),
                Parametro("Descripcio", Material.Descripcion),
                Parametro("PrecioBas", Material.PrecioBase),
                Parametro("PrecioCompr", Material.PrecioCompra),
                Parametro("TiempoBas", Material.TiempoBase),
                Parametro("Proveedo", Material.Proveedor.IDProveedor),
                Parametro("UnidadMedid", Material.UnidadMedida),
                Parametro("Cantida", Material.Cantidad)
                );
            return OperacionRealizada;
        }

        public static bool ObtenerProductosMateriales(int Producto, int Material,
            out RegistroProMat[] Registros)
        {
            string
                Prod = Producto < 0 ? null : Producto.ToString(),
                Mat = Material < 0 ? null : Material.ToString();
            EjecutarProcedimientoAlmacenado("ObtenerProMat", TipoConsulta.DevuelveReader,
                Parametro("Producto", Prod),
                Parametro("Material", Mat)
                );
            bool Ejecutado = OperacionRealizada;
            Registros = RellenarProMat();
            return Ejecutado;
        }

        public static bool ActualizarProMat(RegistroProMat Registro)
        {
            EjecutarProcedimientoAlmacenado("ActualizarProMat", TipoConsulta.DevuelveInt,
                Parametro("Producto", Registro.Producto.IDProducto),
                Parametro("Material", Registro.Material.IDMaterial),
                Parametro("Precio", Registro.PrecioFinal),
                Parametro("Tiempo", Registro.TiempoFinal),
                Parametro("Activ", Registro.Activo)
                );
            return OperacionRealizada;
        }

        public static bool ActualizarMaterial(RegistroMaterial Material)
        {
            EjecutarProcedimientoAlmacenado("ActualizarMaterial", TipoConsulta.DevuelveInt,
                Parametro("Clv", Material.IDMaterial),
                Parametro("Nom", Material.Nombre),
                Parametro("Des", Material.Descripcion),
                Parametro("PreB", Material.PrecioBase),
                Parametro("PreC", Material.PrecioCompra),
                Parametro("Tie", Material.TiempoBase),
                Parametro("Prov", Material.IDProveedor),
                Parametro("UM", Material.UnidadMedida),
                Parametro("Can", Material.Cantidad));
            return OperacionRealizada;
        }

        public static RegistroProMat[] RellenarProMat()
        {
            RegistroProMat[] ProMat = new RegistroProMat[TablaDeResultados.Rows.Count];
            DataTable Pros = TablaDeResultados;
            for (int i = 0; i < ProMat.Length; i++)
            {
                DataRow x = Pros.Rows[i];
                RegistroProducto Producto =
                    new RegistroProducto(
                        Convert.ToInt32(x["IDProducto"].ToString()),
                        x["NombreProducto"].ToString());
                RegistroMaterial Material =
                    new RegistroMaterial(
                        Convert.ToInt32(x["IDMaterial"].ToString()),
                        x["NombreMaterial"].ToString());
                ProMat[i] = new RegistroProMat
                    (
                    Producto,
                    Material,
                    Convert.ToSingle(x["PrecioFinal"]),
                    Convert.ToInt32(x["TiempoFinal"]),
                    Convert.ToChar(x["Activo"]) == '1'
                    );
            }
            return ProMat;
        }

        public static bool EliminarMaterial(int Clave)
        {
            EjecutarProcedimientoAlmacenado("EliminarMaterial", TipoConsulta.DevuelveInt,
                Parametro("Material", Clave));
            return OperacionRealizada;
        }

        public static bool UltimaClaveProducto(out RegistroProducto Producto)
        {
            EjecutarProcedimientoAlmacenado("ObtenerUltimaClaveProducto", TipoConsulta.DevuelveReader, null);
            Producto = ObtenerProducto();
            return OperacionRealizada2;
        }

        public static bool AgregarProducto(RegistroProducto Producto)
        {
            EjecutarProcedimientoAlmacenado("AgregarProducto", TipoConsulta.DevuelveReader,
                Parametro("IDProduct", Producto.IDProducto),
                Parametro("Nombr", Producto.Nombre),
                Parametro("Descripcio", Producto.Descripcion),
                Parametro("TiempoBas", Producto.TiempoBase),
                Parametro("PrecioBas", Producto.PrecioBase),
                Parametro("Activ", Producto.Activo),
                Parametro("UnidadMedid", Producto.UnidadMedida),
                Parametro("Cantida", Producto.Cantidad));
            return OperacionRealizada;
        }

        public static bool ObtenerDentistas(out RegistroDentista[] Dentistas)
        {
            EjecutarProcedimientoAlmacenado("ObtenerDentistas", TipoConsulta.DevuelveReader);
            Dentistas = RellenarDentistas();
            return OperacionRealizada;
        }

        #endregion
        #endregion

        #region Ventas

        public static bool InsertarVenta(RegistroVenta Venta)
        {
            EjecutarProcedimientoAlmacenado("InsertarVenta", TipoConsulta.DevuelveInt,
                Parametro("IDPedid", Venta.Pedido.IDPedido),
                Parametro("Importee", Venta.Importe),
                Parametro("Recibid", Venta.Recibido),
                Parametro("FechaPag", ObtenerFechaHora(Venta.FechaPago)),
                Parametro("Logi", Venta.Registra.Login),
                Parametro("PersonaPag", Venta.PersonaPaga),
                Parametro("FormaPag", Venta.FormaPago));
            return OperacionRealizada;
        }

        public static bool VerVentas(int IDVenta, DateTime FechaMin, DateTime FechaMax,
            string IDPedido, string Nombre, string Referencia, bool Efectivo, bool Tarjeta,
            bool Cheque, out DataTable Datos, out RegistroVenta[] Ventas)
        {
            EjecutarProcedimientoAlmacenado("VerVentas", TipoConsulta.DevuelveReader,
                Parametro("IDVent", IDVenta),
                Parametro("FechaPagoMin", ObtenerFechaHora(FechaMin)),
                Parametro("FechaPagoMax", ObtenerFechaHora(FechaMax)),
                Parametro("IDPedid", IDPedido),
                Parametro("Nombre", Nombre),
                Parametro("Referenci", Referencia),
                Parametro("Efectivo", Efectivo),
                Parametro("Tarjeta", Tarjeta),
                Parametro("Cheque", Cheque));
            Datos = TablaDeResultados;
            bool x = OperacionRealizada2;
            Ventas = RellenarVentas();
            return x;
        }

        public static bool BuscarPedidosNoPagados(string IDPedido, DateTime FechaMin, DateTime FechaMax,
            string Empleado, string Dentista, bool Urgente, bool NoPagado, out RegistroPedido[] Pedidos, int Entregado)
        {
            EjecutarProcedimientoAlmacenado("BuscarPedidosParametros", TipoConsulta.DevuelveReader,
                Parametro("IDPedid", IDPedido),
                Parametro("Empleado", Empleado),
                Parametro("Dentista", Dentista),
                Parametro("FechaMin", ObtenerFechaHora(FechaMin)),
                Parametro("FechaMax", ObtenerFechaHora(FechaMax)),
                Parametro("Urgente", Urgente),
                Parametro("NoPagado", NoPagado),
                Parametro("Entregado", Entregado));
            Pedidos = RellenarPedidos();
            return OperacionRealizada2;
        }

        public static bool RealizarDevolucionTicket(int IDVenta)
        {
            EjecutarProcedimientoAlmacenado("DevolucionPago", TipoConsulta.DevuelveInt,
                Parametro("IDVent", IDVenta));
            return OperacionRealizada;
        }

        public static bool ObtenerPermisoAdministrador(string Password)
        {
            EjecutarProcedimientoAlmacenado("ObtenerPermisoAdministrador", TipoConsulta.DevuelveReader,
                Parametro("pass", Password));
            return OperacionRealizada2;
        }

        public static DataTable UltimoCorteCaja(string Usuario)
        {
            EjecutarProcedimientoAlmacenado("UltimoCorteCaja", TipoConsulta.DevuelveReader);
            return TablaDeResultados;
        }

        private static RegistroVenta[] RellenarVentas()
        {
            DataTable Ventas = TablaDeResultados;
            RegistroVenta[] Ventitas = new RegistroVenta[Ventas.Rows.Count];
            for (int i = 0; i < Ventitas.Length; i++)
            {
                DataRow x = Ventas.Rows[i];
                RegistroUsuario Empleado;
                RegistroPedido Pedido;
                RecuperarUsuario(x["Login"].ToString(), out Empleado);
                RecuperarPedido(x["IDPedido"].ToString(), out Pedido);
                Ventitas[i] = new RegistroVenta(Pedido,
                    Convert.ToSingle(x["Importe"].ToString()),
                    Convert.ToSingle(x["Recibido"].ToString()),
                    Convert.ToDateTime(x["FechaPago"].ToString()),
                    Empleado,
                    x["Referencia"].ToString(),
                    x["FormaPago"].ToString()
                    );
            }
            return Ventitas;
        }

        public static bool RegistrarCorteCaja(RegistroCorteCaja Corte)
        {
            EjecutarProcedimientoAlmacenado("AgregarCorteCaja", TipoConsulta.DevuelveInt,
                Parametro("Fechita", ObtenerFechaHora(Corte.Fecha)),
                Parametro("Emp", Corte.Registra.Login),
                Parametro("Sup", Corte.Autoriza.Login),
                Parametro("Fondo", Corte.FondoCaja),
                Parametro("Efec", Corte.EntradaEfectivo),
                Parametro("Cheq", Corte.EntradaCheque),
                Parametro("Tar", Corte.EntradaTarjeta),
                Parametro("Ven", Corte.NumVentas),
                Parametro("Din", Corte.DineroCaja),
                Parametro("Com", Corte.Comentario));
            return OperacionRealizada;
        }

        public static RegistroUsuario VerificoSupervisor(string Contraseña)
        {
            EjecutarProcedimientoAlmacenado("VerificoSupervisor", TipoConsulta.DevuelveReader,
                Parametro("Contra", Contraseña));
            RegistroUsuario temp = ObtenerUsuario();
            return temp;
        }

        public static bool EntregarPedido(string IDPedido, DateTime FechaEntregado)
        {
            EjecutarProcedimientoAlmacenado("EntregarPedido", TipoConsulta.DevuelveInt,
                Parametro("Fecha", FechaEntregado),
                Parametro("IDPedid", IDPedido));
            return OperacionRealizada;
        }

        public static bool ObtenerUnProducto(int IDProducto, out RegistroProducto Producto)
        {
            EjecutarProcedimientoAlmacenado("ObtenerUnProducto", TipoConsulta.DevuelveReader,
                Parametro("IDProduct", IDProducto));
            Producto = ObtenerProducto();
            return OperacionRealizada2;
        }

        public static bool ActualizarProducto(RegistroProducto Producto)
        {
            EjecutarProcedimientoAlmacenado("ActualizarProducto", TipoConsulta.DevuelveReader,
                Parametro("IDProduct", Producto.IDProducto),
                Parametro("Nombr", Producto.Nombre),
                Parametro("Descripcio", Producto.Descripcion),
                Parametro("Tiempo", Producto.TiempoBase),
                Parametro("Base", Producto.PrecioBase),
                Parametro("Compra", Producto.PrecioCompra),
                Parametro("Acti", Producto.Activo ? '1' : '0'),
                Parametro("UM", Producto.UnidadMedida),
                Parametro("Canti", Producto.Cantidad)
                );
            return OperacionRealizada;
        }

        public static bool EliminarProducto(int Producto)
        {
            EjecutarProcedimientoAlmacenado("EliminarProducto", TipoConsulta.DevuelveInt,
                Parametro("Producto", Producto));
            return OperacionRealizada;
        }

        public static bool RegistrarDentista(RegistroDentista Dentista)
        {
            EjecutarProcedimientoAlmacenado("RegistrarDentista", TipoConsulta.DevuelveInt,
                Parametro("Cedul", Dentista.Cedula),
                Parametro("RF", Dentista.RFC),
                Parametro("Nombr", Dentista.Nombre),
                Parametro("Apellido", Dentista.Apellidos),
                Parametro("Direccio", Dentista.Direccion),
                Parametro("Coloni", Dentista.Colonia),
                Parametro("Ciuda", Dentista.Ciudad),
                Parametro("Municipi", Dentista.Municipio),
                Parametro("Estad", Dentista.Estado),
                Parametro("Pai", Dentista.Pais),
                Parametro("CodPo", Dentista.CodPos),
                Parametro("TelOficin", Dentista.TelOficina),
                Parametro("Emai", Dentista.Email),
                Parametro("Activ", Dentista.Activo),
                Parametro("Consultori", Dentista.Consultorio),
                Parametro("FechaAlt", ObtenerFechaHora(Dentista.FechaAlta))
                );
            return OperacionRealizada;
        }

        public static bool ActualizarDentista(RegistroDentista Dentista)
        {
            EjecutarProcedimientoAlmacenado("ActualizarDentista", TipoConsulta.DevuelveInt,
                Parametro("Cedul", Dentista.Cedula),
                Parametro("RF", Dentista.RFC),
                Parametro("Nombr", Dentista.Nombre),
                Parametro("Apellido", Dentista.Apellidos),
                Parametro("Direccio", Dentista.Direccion),
                Parametro("Coloni", Dentista.Colonia),
                Parametro("Ciuda", Dentista.Ciudad),
                Parametro("Municipi", Dentista.Municipio),
                Parametro("Estad", Dentista.Estado),
                Parametro("Pai", Dentista.Pais),
                Parametro("CodPo", Dentista.CodPos),
                Parametro("TelOficin", Dentista.TelOficina),
                Parametro("Emai", Dentista.Email),
                Parametro("Activ", Dentista.Activo),
                Parametro("Consultori", Dentista.Consultorio),
                Parametro("FechaAlt", ObtenerFechaHora(Dentista.FechaAlta))
                );
            return OperacionRealizada;
        }

        public static bool EliminarDentista(string Cedula)
        {
            EjecutarProcedimientoAlmacenado("EliminarDentista", TipoConsulta.DevuelveInt,
                Parametro("Cedul", Cedula));
            return OperacionRealizada;
        }

        public static bool RegistrarPedido(RegistroPedido Pedido)
        {
            EjecutarProcedimientoAlmacenado("RegistrarPedido", TipoConsulta.DevuelveInt,
                Parametro("IDPedid", Pedido.IDPedido),
                Parametro("IDEmplead", Pedido.IDEmpleado),
                Parametro("Cedul", Pedido.Cedula),
                Parametro("EstadoPedid", Pedido.EstadoPedido),
                Parametro("FechaIngres", Pedido.FechaIngreso),
                Parametro("FechaCalculad", Pedido.FechaCalculada),
                Parametro("FechaEntreg", Pedido.FechaEntrega),
                Parametro("Entregad", Pedido.Entregado),
                Parametro("Urgenci", Pedido.Urgencia),
                Parametro("CostoTota", Pedido.CostoTotal),
                Parametro("Laboratorist", Pedido.Laboratorista),
                Parametro("Pagad", Pedido.Pagado),
                Parametro("RestantePaga", Pedido.RestanteAPagar)
                );
            bool Ejecutado = OperacionRealizada;
            RegistrarTrabajos(Pedido.Productos);
            return Ejecutado;
        }

        public static bool RegistrarTrabajos(RegistroTrabajo[] Trabajos)
        {
            for (int i = 0; i < Trabajos.Length; i++)
            {
                EjecutarProcedimientoAlmacenado("RegistrarTrabajos", TipoConsulta.DevuelveInt,
                    Parametro("IDPedid", Trabajos[i].IDPedido),
                Parametro("IDProduct", Trabajos[i].IDProducto),
                Parametro("PrecioProduct", Trabajos[i].Producto.PrecioBase),
                Parametro("IDMaterial11", Trabajos[i].IDMaterial1),
                Parametro("PrecioMaterial11", Trabajos[i].Material1.PrecioBase),
                Parametro("IDMaterial22", Trabajos[i].IDMaterial2),
                Parametro("PrecioMaterial22", Trabajos[i].Material2.IDMaterial),
                Parametro("Subtota", Trabajos[i].Total));
                return OperacionRealizada;
            }
            return OperacionRealizada;
        }

        #endregion

        #region Auxiliares

        private static DateTime ObtenerFecha(string Fecha)
        {
            DateTime FechaAgRegresar = new DateTime();
            if (!string.IsNullOrWhiteSpace(Fecha))
            {
                FechaAgRegresar = Convert.ToDateTime(Fecha);
            }
            return FechaAgRegresar;
        }

        private static DateTime ObtenerFechaHora(string Fecha)
        {
            DateTime FechaARegresar = new DateTime();
            if (!string.IsNullOrWhiteSpace(Fecha))
            {
                FechaARegresar = Convert.ToDateTime(Fecha);
            }
            return FechaARegresar;
        }

        private static string ObtenerFecha(DateTime Fecha)
        {
            return Fecha.Year + "-" + Fecha.Month + "-" + Fecha.Day;
        }

        private static string ObtenerHora(DateTime Fecha)
        {
            return Fecha.Hour.ToString("D2") + ":" + Fecha.Minute.ToString("D2") + ":" + Fecha.Second.ToString("D2");
        }

        private static string ObtenerFechaHora(DateTime Fecha)
        {
            return ObtenerFecha(Fecha) + " " + ObtenerHora(Fecha);
        }

        #endregion
    }
}