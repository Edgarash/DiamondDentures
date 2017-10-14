using System;
using System.Data;
using MySql.Data.MySqlClient;
using Entidad;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Entidad.Reportes;

namespace ConexionBaseDeDatos
{
    public sealed class InterfaceBaseDeDatos
    {
        private MySqlConnection conexion;

        MySqlConnectionStringBuilder builder;

        /// <summary>
        /// Inicializa una instancia de InterfaceBaseDeDatos con los valores especificados
        /// </summary>
        /// <param name="port">Puerto</param>
        /// <param name="server">Nombre del servidor MySQL.</param>
        /// <param name="userid">ID de Usuario.</param>
        /// <param name="password">Contraseña.</param>
        /// <param name="database">Base de datos.</param>
        public InterfaceBaseDeDatos(uint port, string server, string userid, string password, string database)
        {
            //builder = new MySqlConnectionStringBuilder();
            //builder.Port = port;
            //builder.Server = server;
            //builder.UserID = userid;
            //builder.Password = password;
            //builder.Database = database;
            //conexion = new MySqlConnection(builder.ConnectionString);
            //FileStream temp = new FileStream(@"creado.txt", FileMode.OpenOrCreate);
            //StreamWriter w = new StreamWriter(temp);
            //StreamReader r = new StreamReader(temp);
            //int e = r.ReadToEnd().Length;
            //if (r.ReadToEnd().Length == 0)
            //{
            //    var comando = new MySqlCommand(ConexionBaseDeDatos.Properties.Resources.Script_Diamond_dentures, conexion);
            //    Open();
            //    comando.ExecuteNonQuery();
            //    w.Write("Database Created");
            //    w.Flush();
            //    Close();
            //}
            //var comando2 = new MySqlCommand(Properties.Resources.Script_Procedimientos, conexion);
            //Open();
            //comando2.ExecuteNonQuery();
            //Close();
            //temp.Close();
        }

        /// <summary>
        /// Inicializa una instancia de InterfaceBaseDeDatos con los valores por defecto
        /// </summary>
        //public InterfaceBaseDeDatos() : this(3306, "localhost", "root", "EDGARASH31896", "diamond_dentures") { }
        //public InterfaceBaseDeDatos() : this(3306, "localhost", "root", "carlos", "diamond_dentures") { }
        //public InterfaceBaseDeDatos() : this(3306, "localhost", "root", "thekillml7", "diamond_dentures") { }
        public InterfaceBaseDeDatos() : this(3306, "sql9.freesqldatabase.com", "sql9174827", "tHc9X1c9xh", "sql9174827") { }

        #region Resposabilidades Publicas

        #region Módulo Usuario

        /// <summary>
        /// Método encargado de verificar la existencia de Administradores
        /// </summary>
        /// <returns>Verdadero en caso de encontrar Administradores</returns>
        //public bool HayAdministradores(out int Conteo)
        //{
        //    bool regresar = true;
        //    var command = new MySqlCommand("ConteoAdministradores", conexion);
        //    command.CommandType = CommandType.StoredProcedure;
        //    Open();
        //    var reader = command.ExecuteReader();
        //    Conteo = 0;
        //    if (reader.HasRows)
        //    {
        //        reader.Read();
        //        if (Convert.ToInt32(reader["resultado"].ToString()) == 0)
        //        {
        //            Conteo = Convert.ToInt32(reader["resultado"].ToString());
        //            regresar = false;
        //        }
        //    }
        //    Close();
        //    return regresar;
        //}

        //public bool RegistrarEmpleado(int NumeroEmpleado)
        //{
        //    var command = new MySqlCommand("RegistrarEmpleado", conexion);
        //    command.CommandType = CommandType.StoredProcedure;

        //    command.Parameters.AddWithValue("@emp", NumeroEmpleado);
        //    Open();
        //    var nc = command.ExecuteNonQuery();
        //    Close();
        //    return EnviarConfirmacion(nc);
        //}

        public void Datos(DataGridView temp)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"select N_Empleado,
		login as 'Login',
        t_usuario as 'Tipo Usuario',
        nombre as 'Nombre',
        apellidos as 'Apellidos',
        pais as 'País',
        estado as 'Estado',
        municipio as 'Municipio',
        ciudad as 'Ciudad',
        colonia as 'Colonia',
        calle as 'Calle',
        numcasa as '# Casa',
        cp as 'C. Postal',
        email as 'Email',
        tel_casa as 'Tel. Casa',
        tel_movil as 'Tel. Cel',
        tel_oficina as 'Tel. Oficina',
        estatus as 'Activo',
        Pregunta,
        Respuesta
        from empleados, usuarios where N_Empleado = nmtrabajador union all select N_Empleado, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '' from empleados where N_Empleado not in (select nmtrabajador from usuarios) order by N_Empleado"));
            DataTable x = new DataTable();
            p.SelectCommand.Connection = conexion;
            p.SelectCommand.Connection.Open();
            p.Fill(x);
            temp.DataSource = x;
            p.SelectCommand.Connection.Close();
        }

        /// <summary>
        /// Método encargado de solicitar a la base de datos la creación de un registro de tarjeta.
        /// </summary>
        /// <param name="Tarjeta">Objeto que contiene la información de la tarjeta.</param>
        /// <returns>Confirmacion de la creacion del regitro de la tarjeta con exito</returns>
        public bool RegistroTarjeta(RegistroTarjeta Tarjeta)
        {
            var command = new MySqlCommand("RegistrarTarjeta", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@log", Tarjeta.Login);
            command.Parameters.AddWithValue("@nmr", Tarjeta.NumeroTarjeta);
            command.Parameters.AddWithValue("@ttlr", Tarjeta.NombreTitular);
            command.Parameters.AddWithValue("@appe", Tarjeta.ApellidosTitular);
            command.Parameters.AddWithValue("@bnc", Tarjeta.Banco);
            command.Parameters.AddWithValue("@fven", Tarjeta.FechaVencimiento);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        /// <summary>
        /// Método encargado de solicitar a la base de datos la creación de un registro de usuario
        /// </summary>
        /// <param name="Usuario">Objeto que contiene la información del usuario.</param>
        /// <returns>Confirmacion de la creacion del regitro de usuario con exito</returns>
        //public bool RegistroUsuario(RegistroUsuario Usuario)
        //{
        //    var command = new MySqlCommand("RegistrarUsuario", conexion);
        //    command.CommandType = CommandType.StoredProcedure;

        //    command.Parameters.AddWithValue("@nmtrb", Usuario.NumeroTrabajador);
        //    command.Parameters.AddWithValue("@nmb", Usuario.Nombre);
        //    command.Parameters.AddWithValue("@appe", Usuario.Apellidos);
        //    command.Parameters.AddWithValue("@dr", Usuario.Direccion);
        //    command.Parameters.AddWithValue("@ncasa", Usuario.NumCasa);
        //    command.Parameters.AddWithValue("@cl", Usuario.Colonia);
        //    command.Parameters.AddWithValue("@cdd", Usuario.Ciudad);
        //    command.Parameters.AddWithValue("@ps", Usuario.Pais);
        //    command.Parameters.AddWithValue("@cp", Usuario.CodPos);
        //    command.Parameters.AddWithValue("@eml", Usuario.Email);
        //    command.Parameters.AddWithValue("@logi", Usuario.Login);
        //    command.Parameters.AddWithValue("@pwd", Usuario.Password);
        //    command.Parameters.AddWithValue("@edo", Usuario.Estado);
        //    command.Parameters.AddWithValue("@muni", Usuario.Municipio);
        //    command.Parameters.AddWithValue("@est", Usuario.Activo);
        //    command.Parameters.AddWithValue("@t_us", Usuario.Departamento);
        //    command.Parameters.AddWithValue("@tl_c", Usuario.TelCasa);
        //    command.Parameters.AddWithValue("@tl_o", Usuario.TelOficina);
        //    command.Parameters.AddWithValue("@tl_m", Usuario.TelCel);
        //    command.Parameters.AddWithValue("@preg", Usuario.Pregunta);
        //    command.Parameters.AddWithValue("@respues", Usuario.Respuesta);

        //    Open();

        //    var nc = command.ExecuteNonQuery();
        //    Close();
        //    return EnviarConfirmacion(nc);
        //}

        /// <summary>
        /// Método encargado de solicitar a la base de datos la actualización de un registro de Usuario
        /// </summary>
        /// <param name="Usuario">Objeto que contiene la información a actualizar del usuario</param>
        /// <returns>Confirmación de la actualización del registro de usuario con éxito</returns>
        public bool ActualizarUsuario(string User, RegistroUsuario Usuario)
        {
            var command = new MySqlCommand("ActualizarUsuario", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@nmtrb", Usuario.NumeroTrabajador);
            command.Parameters.AddWithValue("@nomb", Usuario.Nombre);
            command.Parameters.AddWithValue("@appe", Usuario.Apellidos);
            command.Parameters.AddWithValue("@str", Usuario.Direccion);
            command.Parameters.AddWithValue("@ncasa", Usuario.NumCasa);
            command.Parameters.AddWithValue("@cl", Usuario.Colonia);
            command.Parameters.AddWithValue("@cdd", Usuario.Ciudad);
            command.Parameters.AddWithValue("@ps", Usuario.Pais);
            command.Parameters.AddWithValue("@cp", Usuario.CodPos);
            command.Parameters.AddWithValue("@eml", Usuario.Email);
            command.Parameters.AddWithValue("@logi", User);
            command.Parameters.AddWithValue("@pwd", Usuario.Password);
            command.Parameters.AddWithValue("@edo", Usuario.Estado);
            command.Parameters.AddWithValue("@muni", Usuario.Municipio);
            command.Parameters.AddWithValue("@est", Usuario.Activo);
            command.Parameters.AddWithValue("@t_us", Usuario.Departamento);
            command.Parameters.AddWithValue("@tl_c", Usuario.TelCasa);
            command.Parameters.AddWithValue("@tl_o", Usuario.TelOficina);
            command.Parameters.AddWithValue("@tl_m", Usuario.TelCel);
            command.Parameters.AddWithValue("@preg", Usuario.Pregunta);
            command.Parameters.AddWithValue("@resp", Usuario.Respuesta);
            command.Parameters.AddWithValue("@newlogin", Usuario.Login);

            Open();

            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        /// <summary>
        /// Método encargado de solicitar a la base de datos la actualización de un registro de tarjeta
        /// </summary>
        /// <param name="Tarjeta">Objeto que contiene la información a actualizar de la tarjeta</param>
        /// <returns>Confirmación de la actualización del registro de tarjeta con éxito</returns>
        public bool ActualizarTarjeta(RegistroTarjeta Tarjeta)
        {
            var command = new MySqlCommand("ActualizarTarjeta", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@nmr", Tarjeta.NumeroTarjeta);
            command.Parameters.AddWithValue("@ttlr", Tarjeta.NombreTitular);
            command.Parameters.AddWithValue("@appe", Tarjeta.ApellidosTitular);
            command.Parameters.AddWithValue("@bnc", Tarjeta.Banco);
            command.Parameters.AddWithValue("@fveni", Tarjeta.FechaVencimiento);
            command.Parameters.AddWithValue("@log", Tarjeta.Login);

            Open();

            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        /// <summary>
        /// Método encargado de solicitar a la base de datos un borrado lógico de una tarjeta
        /// </summary>
        /// <param name="Usuario">Cadena que contiene el usuario al cual pertenece la tarjeta</param>
        /// <returns>Confirmación del borrado lógico de la tarjeta en la base de datos con éxito</returns>
        public bool BorrarTarjeta(string Usuario)
        {
            var command = new MySqlCommand("EliminarTarjeta", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@logi", Usuario);

            Open();

            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        /// <summary>
        /// Método encargado de solicitar a la base de datos un borrado lógico de un usuario
        /// </summary>
        /// <param name="Usuario">Cadena que contiene el usuario al cuál se le hará el borrado lógico</param>
        /// <returns>Confirmación del borrado lógico del usuario en la base de datos con éxito</returns>
        public bool BorrarUsuario(string Usuario)
        {
            var command = new MySqlCommand("BorrarUsuario", conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@logi", Usuario);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool ActivarUsuario(string Usuario)
        {
            var command = new MySqlCommand("ActivarUsuario", conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@logi", Usuario);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        /// <summary>
        /// Método encargado de solicitar a la base de datos la confirmación de la existencia de esa contraseña como contraseña de administrador
        /// </summary>
        /// <param name="Pass">Contrasñea a ser verificada</param>
        /// <returns>Confirmación de la contraseña como de un usuario de administrador</returns>
        public bool ObtenerPermiso(string Pass)
        {
            var command = new MySqlCommand("ObtenerPermiso", conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@pass", Pass);
            Open();
            var reader = command.ExecuteReader();
            bool Permiso = false;
            if (reader.HasRows)
            {
                reader.Read();
                if (Pass == (reader["result"].ToString()))
                {
                    Permiso = true;
                }
            }
            Close();
            return Permiso;
        }

        //public bool ValidarEmpleado(int NumeroTrabajador)
        //{
        //    var command = new MySqlCommand("ValidarEmpleado", conexion);
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.AddWithValue("@emp", NumeroTrabajador);
        //    Open();
        //    var reader = command.ExecuteReader();
        //    bool Validado = false;
        //    if (reader.HasRows)
        //    {
        //        reader.Read();
        //        if (NumeroTrabajador.ToString() == reader["N_Empleado"].ToString())
        //            Validado = true;
        //    }
        //    Close();
        //    return Validado;
        //}

        public bool ValidarEmpleadoRegistrado(int NumeroTrabajador)
        {
            var command = new MySqlCommand("ValidarEmpleadoRegistrado", conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@emp", NumeroTrabajador);
            Open();
            var reader = command.ExecuteReader();
            bool Validado = false;
            if (reader.HasRows)
            {
                Validado = true;
            }
            Close();
            return Validado;
        }

        #endregion

        #region Módulo Configuración

        public bool RegistrarProducto(RegistroProducto Registro)
        {
            var command = new MySqlCommand("RegistrarProducto", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Registro.Clave);
            command.Parameters.AddWithValue("@nmb", Registro.Nombre);
            command.Parameters.AddWithValue("@days", Registro.Dias);
            command.Parameters.AddWithValue("@price", Registro.Precio);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool RegistrarMaterial(RegistroMaterial Material)
        {
            var command = new MySqlCommand("RegistrarMaterial", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Material.Clave);
            command.Parameters.AddWithValue("@nmb", Material.Nombre);
            command.Parameters.AddWithValue("@price", Material.Precio);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool RegistrarPedido(RegistroPedido Pedido)
        {
            var command = new MySqlCommand("RegistrarPedido", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Pedido.Clave);
            command.Parameters.AddWithValue("@user", Pedido.Usuario);
            command.Parameters.AddWithValue("@dat", Convert.ToDateTime(Pedido.Fecha));
            command.Parameters.AddWithValue("@ced", Pedido.Cedula);
            command.Parameters.AddWithValue("@rf", Pedido.RFC);
            command.Parameters.AddWithValue("@nmb", Pedido.NombreDentista);
            command.Parameters.AddWithValue("@ape", Pedido.ApellidosDentista);
            command.Parameters.AddWithValue("@tel", Pedido.Telefono);
            command.Parameters.AddWithValue("@pa", Pedido.Pais);
            command.Parameters.AddWithValue("@es", Pedido.Estado);
            command.Parameters.AddWithValue("@mu", Pedido.Municipio);
            command.Parameters.AddWithValue("@ciu", Pedido.Ciudad);
            command.Parameters.AddWithValue("@col", Pedido.Colonia);
            command.Parameters.AddWithValue("@cal", Pedido.Calle);
            command.Parameters.AddWithValue("@num", Pedido.NumeroFrente);
            command.Parameters.AddWithValue("@codp", Pedido.CP);
            command.Parameters.AddWithValue("@ema", Pedido.Email);
            command.Parameters.AddWithValue("@fechaent", Convert.ToDateTime(Pedido.FechaEntrega));
            command.Parameters.AddWithValue("@esta", Pedido.Estatus);
            command.Parameters.AddWithValue("@asig", Pedido.Asignado);
            command.Parameters.AddWithValue("@urg", Pedido.Urgente);
            Open();
            var nc = command.ExecuteNonQuery();
            if (EnviarConfirmacion(nc))
            {
                for (int i = 0; i < Pedido.Trabajos.Length; i++)
                    RegistrarTrabajos(Pedido.Clave, Pedido.Trabajos[i]);
            }
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool RegistrarDentista(RegistroDentista Dentista)
        {
            var command = new MySqlCommand("RegistrarDentista", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ced", Dentista.Cedula);
            command.Parameters.AddWithValue("@rf", Dentista.RFC);
            command.Parameters.AddWithValue("@nmb", Dentista.Nombre);
            command.Parameters.AddWithValue("@ape", Dentista.Apellidos);
            command.Parameters.AddWithValue("@tel", Dentista.TelOficina);
            command.Parameters.AddWithValue("@pa", Dentista.Pais);
            command.Parameters.AddWithValue("@es", Dentista.Estado);
            command.Parameters.AddWithValue("@mu", Dentista.Municipio);
            command.Parameters.AddWithValue("@ciu", Dentista.Ciudad);
            command.Parameters.AddWithValue("@col", Dentista.Colonia);
            command.Parameters.AddWithValue("@cal", Dentista.Direccion);
            command.Parameters.AddWithValue("@codp", Dentista.CodPos);
            command.Parameters.AddWithValue("@ema", Dentista.Email);

            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool ActualizarDentista(RegistroDentista Dentista)
        {
            var command = new MySqlCommand("ActualizarDentista", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ced", Dentista.Cedula);
            command.Parameters.AddWithValue("@rf", Dentista.RFC);
            command.Parameters.AddWithValue("@nmb", Dentista.Nombre);
            command.Parameters.AddWithValue("@ape", Dentista.Apellidos);
            command.Parameters.AddWithValue("@tel", Dentista.TelOficina);
            command.Parameters.AddWithValue("@pa", Dentista.Pais);
            command.Parameters.AddWithValue("@es", Dentista.Estado);
            command.Parameters.AddWithValue("@mu", Dentista.Municipio);
            command.Parameters.AddWithValue("@ciu", Dentista.Ciudad);
            command.Parameters.AddWithValue("@col", Dentista.Colonia);
            command.Parameters.AddWithValue("@cal", Dentista.Direccion);
            command.Parameters.AddWithValue("@codp", Dentista.CodPos);
            command.Parameters.AddWithValue("@ema", Dentista.Email);

            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool ActualizarPedido(RegistroPedido Pedido)
        {
            var command = new MySqlCommand("ActualizarPedido", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Pedido.Clave);
            command.Parameters.AddWithValue("@user", Pedido.Usuario);
            command.Parameters.AddWithValue("@dat", Convert.ToDateTime(Pedido.Fecha));
            command.Parameters.AddWithValue("@ced", Pedido.Cedula);
            command.Parameters.AddWithValue("@rf", Pedido.RFC);
            command.Parameters.AddWithValue("@nmb", Pedido.NombreDentista);
            command.Parameters.AddWithValue("@ape", Pedido.ApellidosDentista);
            command.Parameters.AddWithValue("@tel", Pedido.Telefono);
            command.Parameters.AddWithValue("@pa", Pedido.Pais);
            command.Parameters.AddWithValue("@es", Pedido.Estado);
            command.Parameters.AddWithValue("@mu", Pedido.Municipio);
            command.Parameters.AddWithValue("@ciu", Pedido.Ciudad);
            command.Parameters.AddWithValue("@col", Pedido.Colonia);
            command.Parameters.AddWithValue("@cal", Pedido.Calle);
            command.Parameters.AddWithValue("@num", Pedido.NumeroFrente);
            command.Parameters.AddWithValue("@codp", Pedido.CP);
            command.Parameters.AddWithValue("@ema", Pedido.Email);
            command.Parameters.AddWithValue("@fechaent", Convert.ToDateTime(Pedido.FechaEntrega));
            command.Parameters.AddWithValue("@esta", Pedido.Estatus);
            command.Parameters.AddWithValue("@asig", Pedido.Asignado);
            command.Parameters.AddWithValue("@urg", Pedido.Urgente);
            Open();
            var nc = command.ExecuteNonQuery();
            if (EnviarConfirmacion(nc))
            {
                for (int i = 0; i < Pedido.Trabajos.Length; i++)
                    RegistrarTrabajos(Pedido.Clave, Pedido.Trabajos[i]);
            }
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool RegistrarTrabajos(string Clave, RegistroTrabajo Trabajo)
        {
            var command = new MySqlCommand("RegistrarTrabajo", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Clave);
            command.Parameters.AddWithValue("@pro", Trabajo.Producto);
            command.Parameters.AddWithValue("@pre", Trabajo.PrecioProducto);
            command.Parameters.AddWithValue("@mat1", Trabajo.Material1);
            command.Parameters.AddWithValue("@pre1", Trabajo.PrecioMaterial1);
            command.Parameters.AddWithValue("@mat2", Trabajo.Material2);
            command.Parameters.AddWithValue("@pre2", Trabajo.PrecioMaterial2);
            command.Parameters.AddWithValue("@fec", Convert.ToDateTime(Trabajo.Fecha));
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool ActualizarProMat(RegistroProMat Registro)
        {
            var command = new MySqlCommand("ActualizarProMat", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clvpro", Registro.ClavePro);
            command.Parameters.AddWithValue("@clvmat", Registro.ClaveMat);
            command.Parameters.AddWithValue("@price", Registro.Precio);
            command.Parameters.AddWithValue("@act", Registro.Activo);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool ActivarProducto(int Clave)
        {
            var command = new MySqlCommand("ActivarProducto", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Clave);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool ActivarMaterial(int Clave)
        {
            var command = new MySqlCommand("ActivarMaterial", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Clave);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool ActualizarProducto(RegistroProducto producto)
        {
            var command = new MySqlCommand("ActualizarProducto", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", producto.Clave);
            command.Parameters.AddWithValue("@nmb", producto.Nombre);
            command.Parameters.AddWithValue("@days", producto.Dias);
            command.Parameters.AddWithValue("@price", producto.Precio);

            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool ActualizarMaterial(RegistroMaterial material)
        {
            var command = new MySqlCommand("ActualizarMaterial", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", material.Clave);
            command.Parameters.AddWithValue("@nmb", material.Nombre);
            command.Parameters.AddWithValue("@price", material.Precio);

            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool EliminarProducto(int Clave)
        {
            var command = new MySqlCommand("EliminarProducto", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Clave);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool EliminarMaterial(int clave)
        {
            var command = new MySqlCommand("EliminarMaterial", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", clave);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public RegistroProducto[] ObtenerProductos()
        {
            RegistroProducto[] temp = null;

            var command = new MySqlCommand("ObtenerProductos", conexion);
            command.CommandType = CommandType.StoredProcedure;

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            if (str.HasRows)
            {
                List<RegistroProducto> Lista = new List<RegistroProducto>();
                while (str.Read())
                {
                    Lista.Add(new RegistroProducto(str.GetInt32(0), str.GetString(1), str.GetInt32(2), str.GetFloat(3), str.GetInt32(4)));
                }
                temp = Lista.ToArray();
            }
            Close();
            return temp;
        }

        public RegistroMaterial[] ObtenerMateriales()
        {
            RegistroMaterial[] temp = null;

            var command = new MySqlCommand("ObtenerMateriales", conexion);
            command.CommandType = CommandType.StoredProcedure;

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            if (str.HasRows)
            {
                List<RegistroMaterial> Lista = new List<RegistroMaterial>();
                while (str.Read())
                {
                    Lista.Add(new RegistroMaterial(str.GetInt32(0), str.GetString(1), str.GetFloat(2), str.GetInt32(3)));
                }
                temp = Lista.ToArray();
            }
            Close();
            return temp;
        }

        public RegistroProMat[] ObtenerProMat(int mat, int pro)
        {
            RegistroProMat[] temp = null;

            var command = new MySqlCommand("ObtenerProMat", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clvmat", mat);
            command.Parameters.AddWithValue("@clvpro", pro);

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            if (str.HasRows)
            {
                List<RegistroProMat> Lista = new List<RegistroProMat>();
                while (str.Read())
                {
                    Lista.Add(new RegistroProMat(str.GetInt32(0), str.GetString(1), str.GetInt32(2), str.GetString(3), str.GetFloat(4), str.GetInt32(5)));
                }
                temp = Lista.ToArray();
            }
            Close();
            return temp;
        }

        public RegistroProducto[] BuscarProducto(RegistroProducto Registro)
        {
            RegistroProducto[] temp = null;

            var command = new MySqlCommand("BuscarUnProducto", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Registro.Clave);
            command.Parameters.AddWithValue("@nmb", Registro.Nombre);
            command.Parameters.AddWithValue("@days", Registro.Dias);
            command.Parameters.AddWithValue("@price", Registro.Precio.ToString());

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            if (str.HasRows)
            {
                List<RegistroProducto> Lista = new List<RegistroProducto>();
                while (str.Read())
                {
                    Lista.Add(new RegistroProducto(str.GetInt32(0), str.GetString(1), str.GetInt32(2), str.GetFloat(3), str.GetInt32(4)));
                }
                temp = Lista.ToArray();
            }
            Close();
            return temp;
        }

        public RegistroMaterial[] BuscarUnMaterial(RegistroMaterial Material)
        {
            RegistroMaterial[] temp = null;

            var command = new MySqlCommand("BuscarUnMaterial", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Material.Clave);
            command.Parameters.AddWithValue("@nmb", Material.Nombre);
            command.Parameters.AddWithValue("@price", Material.Precio.ToString());

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            if (str.HasRows)
            {
                List<RegistroMaterial> Lista = new List<RegistroMaterial>();
                while (str.Read())
                {
                    Lista.Add(new RegistroMaterial(str.GetInt32(0), str.GetString(1), str.GetInt32(2), str.GetInt32(3)));
                }
                temp = Lista.ToArray();
            }
            Close();
            return temp;
        }

        public RegistroPedido ObtenerUnPedido(string clavePedido)
        {
            var command = new MySqlCommand("ObtenerUnPedido", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", clavePedido);

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            RegistroPedido temp = null;
            if (str.HasRows)
            {
                while (str.Read())
                {
                    temp = new RegistroPedido(str.GetString(0), str.GetString(1), str.GetString(2), str.GetString(3), str.GetString(4), str.GetString(5),
                        str.GetString(6), str.GetString(7), str.GetString(8), str.GetString(9), str.GetString(10), str.GetString(11), str.GetString(12),
                        str.GetString(13), str.GetString(14), str.GetString(15), str.GetString(16), str.GetString(17), str.GetInt32(20), str.GetString(19));
                    temp.Estatus = str.GetInt32(18);
                }
            }
            Close();
            temp?.setTrabajos(ObtenerTrabajos(temp.Clave));
            return temp;
        }

        public RegistroDentista ObtenerUnDentista(string Cedula)
        {
            var command = new MySqlCommand("ObtenerUnDentista", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Cedula);

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            RegistroDentista temp = null;
            if (str.HasRows)
            {
                while (str.Read())
                {
                    temp = new RegistroDentista(str.GetString(0), str.GetString(1), str.GetString(2), str.GetString(3), str.GetString(4), str.GetString(5),
                        str.GetString(6), str.GetString(7), str.GetString(8), str.GetString(9), str.GetString(10), str.GetString(11), str.GetString(12),
                        str.GetString(13));
                }
            }
            Close();
            return temp;
        }

        public RegistroTrabajo[] ObtenerTrabajos(string Clave)
        {
            var command = new MySqlCommand("ObtenerTrabajos", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Clave);

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            List<RegistroTrabajo> temp = new List<RegistroTrabajo>();
            if (str.HasRows)
            {
                while (str.Read())
                {
                    temp.Add(new RegistroTrabajo(str.GetString(1), str.GetFloat(2), str.GetString(3), str.GetFloat(4), str.GetString(5), str.GetFloat(6), Convert.ToDateTime(str.GetString(7)).ToShortDateString()));
                }
            }
            Close();
            return temp.ToArray();
        }

        public RegistroProducto ObtenerUnProducto(string Proceso)
        {
            RegistroProducto temp = null;

            var command = new MySqlCommand("ObtenerUnProducto", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@nmb", Proceso);

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            if (str.HasRows)
            {
                str.Read();
                temp = new RegistroProducto(str.GetInt32(0), str.GetString(1), str.GetInt32(2), str.GetFloat(3), str.GetInt32(4));
            }
            Close();
            return temp;
        }

        public RegistroMaterial ObtenerUnMaterial(int clave)
        {
            RegistroMaterial temp = null;

            var command = new MySqlCommand("ObtenerUnMaterial", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", clave);

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            if (str.HasRows)
            {
                str.Read();
                temp = new RegistroMaterial(str.GetInt32(0), str.GetString(1), str.GetFloat(2), str.GetInt32(3));
            }
            Close();
            return temp;
        }

        #endregion

        #region Módulo Control Pedidos & Laboratorio

        private void setData(DataGridView Data, DataTable Tabla)
        {
            Data.DataSource = null;
            Data.ColumnCount = Tabla.Columns.Count;
            for (int i = 0; i < Data.ColumnCount; i++)
                Data.Columns[i].Name = Data.Columns[i].HeaderText = Tabla.Columns[i].ColumnName;
            Data.RowCount = Tabla.Rows.Count;
            for (int i = 0; i < Data.RowCount; i++)
            {
                for (int j = 0; j < Data.ColumnCount; j++)
                {
                    Data[j, i].Value = Tabla.Rows[i].ItemArray.GetValue(j);
                }
            }
        }
        public void Datos2(DataGridView temp2)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"call ObtenerPedidos"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;
            p.SelectCommand.Connection.Open();
            p.Fill(y);
            setData(temp2, y);
            p.SelectCommand.Connection.Close();
        }
        public void DatosPedidos(DataGridView temp)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"SELECT
  `Clave`, `NombreDen` AS 'Cliente', `FechaEntrega` AS 'Entrega', IF(`Urgente` = 1, 'Urgente', 'Normal') AS 'Tipo de Pedido', Estatus, IF(`Asignado` = '', 'No asignado', `Asignado`) AS 'Laboratorista'
FROM
  `pedidos` ORDER BY `Urgente` DESC, `FechaEntrega`, `Estatus` = '0', `Estatus` = '5', `Estatus` = '7', `Estatus` = '6', `Estatus` = '1', `Estatus` = '2', `Estatus` = '4' DESC;"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;
            p.SelectCommand.Connection.Open();
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void DatosProductos(DataGridView temp)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"SELECT
  `Clave`, `Nombre`, `Dias`, `Precio`
FROM
  `productos`
WHERE
  `activo` = '1'
ORDER BY `Clave`;"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;
            p.SelectCommand.Connection.Open();
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void ObtenerIdPiezas(DataGridView temp)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"SELECT `Clave` FROM `productos` WHERE `Activo` = '1' ORDER BY `Clave`;"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;
            p.SelectCommand.Connection.Open();
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void BuscarIdPedido(DataGridView temp, string valor)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"call ObtenerPedidoID ('" + valor + "');"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;
            try { p.SelectCommand.Connection.Open(); }
            catch (Exception)
            { throw; }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void BuscarIdDentista(DataGridView temp, string cedula)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"SELECT
  `Clave`,
  `Cedula`,
  `NombreDen` as 'Nombre Dentista',
  `Telefono`,
  `Fecha` AS 'Llegada',
  `FechaEntrega` AS 'Entrega',
  IF(`Urgente` = 1, 'Urgente', 'Normal') AS 'Tipo de Pedido',
`Estatus`
FROM
  `pedidos`
WHERE
  `Cedula` = '" + cedula + "';"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;

            try
            {
                p.SelectCommand.Connection.Open();
            }
            catch (Exception)
            {

                throw;
            }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void BuscarTipo(DataGridView temp, string valor)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"SELECT
  `Clave`,
  `Cedula`,
  `NombreDen`,
  `Telefono`,
  `Fecha` AS 'Llegada',
  `FechaEntrega` AS 'Entrega',
  IF(`Urgente` = 1, 'Urgente', 'Normal') AS 'Tipo de Pedido'
FROM
  `pedidos`
WHERE
  `Urgente` = '" + valor + "'"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;

            try
            {
                p.SelectCommand.Connection.Open();
            }
            catch (Exception)
            {

                throw;
            }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void CambiarLaboratorista(DataGridView temp, string valor, string Laboratorista, string id)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"UPDATE `pedidos` 
            SET `Asignado` = '" + valor + "' WHERE `Asignado` = '" + Laboratorista + "' AND `Clave` = '" + id + "';"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;
            try { p.SelectCommand.Connection.Open(); }
            catch (Exception) { }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void CambiarEstado(DataGridView temp, string valor, string estado, string id)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"UPDATE `pedidos` 
            SET `Estatus` = '" + valor + "' WHERE `Estatus` = '" + estado + "' AND `Clave` = '" + id + "';"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;
            try { p.SelectCommand.Connection.Open(); }
            catch (Exception) { }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void EstadoProcesar(DataGridView temp, string valor, string id, string user)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"UPDATE `pedidos` 
            SET `Estatus` = '" + valor + "' where `Clave` = '" + id + "';\n UPDATE `pedidos` SET `Asignado` = '" + user + "' where `Clave` = '" + id + "'; "));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;
            try { p.SelectCommand.Connection.Open(); }
            catch (Exception) { }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void CancelarPedido(DataGridView temp, string id)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"UPDATE `pedidos` 
            SET `Estatus` = '0' WHERE `Clave` = '" + id + "';"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;
            try { p.SelectCommand.Connection.Open(); }
            catch (Exception) { }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void CancelarPieza(DataGridView temp, string id)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"UPDATE `productos` 
            SET `Activo` = '0' WHERE `Clave` = '" + id + "';"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;
            try { p.SelectCommand.Connection.Open(); }
            catch (Exception) { }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void ObtenerNombrePieza(DataGridView temp, string id)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"SELECT `Nombre` FROM `productos` WHERE `Clave` = '" + id + "';"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;
            try { p.SelectCommand.Connection.Open(); }
            catch (Exception) { }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void BusquedaIdPedido(DataGridView temp, string valor)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"SELECT
  `Clave`,
  `NombreDen` AS 'Cliente',
  `FechaEntrega` AS 'Entrega',
  IF(`Urgente` = 1, 'Urgente', 'Normal') AS 'Tipo de Pedido',
  `Estatus`
FROM
  `pedidos`
WHERE
  `Clave` = '" + valor + "'"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;

            try
            {
                p.SelectCommand.Connection.Open();
            }
            catch (Exception)
            {

                throw;
            }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void BusquedaTipo(DataGridView temp, string valor)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"SELECT
  `Clave`,
  `NombreDen` AS 'Cliente',
  `FechaEntrega` AS 'Entrega',
  IF(`Urgente` = 1, 'Urgente', 'Normal') AS 'Tipo de Pedido',
  `Estatus`
FROM
  `pedidos`
WHERE
  `Urgente` = '" + valor + "'"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;

            try
            {
                p.SelectCommand.Connection.Open();
            }
            catch (Exception)
            {

                throw;
            }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public void BusquedaIdPieza(DataGridView temp, string valor)
        {
            MySqlDataAdapter p = new MySqlDataAdapter(new MySqlCommand(@"SELECT
            `Clave`, `Nombre`, `Dias`, `Precio`
            FROM  `productos` WHERE Activo = '1' AND Clave = '" + valor + "'" + " ORDER BY `Clave`"));
            DataTable y = new DataTable();
            p.SelectCommand.Connection = conexion;

            try
            {
                p.SelectCommand.Connection.Open();
            }
            catch (Exception)
            {

                throw;
            }
            p.Fill(y);
            setData(temp, y);
            p.SelectCommand.Connection.Close();
        }
        public string ObtenerTipoUser(string usuario)
        {
            string tipoUsuario = "";
            MySqlCommand command = new MySqlCommand($"SELECT `t_usuario` FROM `usuarios` WHERE `login` = '" + usuario + "';", conexion);
            Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tipoUsuario = reader[0].ToString();
                }
            }
            return tipoUsuario;
        }
        public void ObtenerUsuariosActivos(ComboBox cbtrabaja)
        {
            MySqlCommand command = new MySqlCommand($"SELECT `login` FROM `usuarios`where t_usuario = 'Laboratorista';", conexion);
            Open();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cbtrabaja.Items.Add(reader[0].ToString());
                }
            }
        }
        public bool PedidosEnProcesoPorUsuario(string usuario, string estado)
        {
            bool stop = false;
            string cont = "";
            if (estado == "En Proceso")
            {
                stop = true;
                MessageBox.Show("Este pedido ya está en proceso y no se puede asignar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MySqlCommand command = new MySqlCommand($"SELECT COUNT(`Estatus`) FROM `pedidos` WHERE `Estatus` = '4' AND `Asignado` = '" + usuario + "';", conexion);
                Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cont = reader[0].ToString();
                    }
                }
                if (cont == "0" || estado != "En Proceso")
                    stop = false;
                else
                {
                    stop = true;
                    MessageBox.Show("No se puede asignar el pedido al usuario: " + usuario + " ya que ya tiene asignado un pedido En Proceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return stop;
        }
        public bool PedidosPorUserLaboratorio(string usuario, string estado)
        {
            bool stop = false;
            string cont = "";
                MySqlCommand command = new MySqlCommand($"SELECT COUNT(`Estatus`) FROM `pedidos` WHERE `Estatus` = '4' AND `Asignado` = '" + usuario + "';", conexion);
                Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cont = reader[0].ToString();
                    }
                }
            if (cont == "0")
            {
                stop = false;
                if (estado == "Cancelado")
                {
                    MessageBox.Show("No se puede poner en proceso un pedido cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stop = true;
                }
                if (estado == "Registrado")
                {
                    stop = false;
                }
                if (estado == "Confirmado")
                {
                    stop = false;
                }
                if (estado == "Terminado")
                {
                    MessageBox.Show("No se puede poner en proceso un pedido terminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stop = true;
                }
                if (estado == "Facturado")
                {
                    MessageBox.Show("No se puede poner en proceso un pedido facturado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stop = true;
                }
                if (estado == "Pagado")
                {
                    MessageBox.Show("No se puede poner en proceso un pedido pagado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stop = true;
                }
                if (estado == "En Proceso")
                {
                    MessageBox.Show("El pedido ya está en proceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stop = true;
                }
            }
            else
            {
                stop = true;
                MessageBox.Show("El usuario "+usuario+" ya tiene un pedido en proceso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return stop;
        }
        #endregion

        #region Conta & Reportes

        private static MySqlConnection _conexion;
        private static MySqlConnectionStringBuilder _builder;

        private MySqlConnection Conectar(uint port, string server, string userid, string password, string database)
        {
            _builder = new MySqlConnectionStringBuilder
            {
                Port = port,
                Server = server,
                UserID = userid,
                Password = password,
                Database = database,
                ConvertZeroDateTime = true,
                AllowZeroDateTime = true
            };

            _conexion?.Close();
            _conexion = new MySqlConnection(_builder.ConnectionString);
            return _conexion;
        }

        private static MySqlConnection Conectar()
        {
            _builder = new MySqlConnectionStringBuilder
            {
                Port = CnDefault.Port,
                Server = CnDefault.Server,
                UserID = CnDefault.UserId,
                Password = CnDefault.Password,
                Database = CnDefault.Database,
                AllowZeroDateTime = true,
                ConvertZeroDateTime = true
            };

            _conexion?.Close();
            _conexion = new MySqlConnection(_builder.ConnectionString);
            return _conexion;
        }

        public static List<Pedidos> BuscarPedido(CriterioBusqueda pedidoFormateado)
        {
            MySqlCommand command = new MySqlCommand("BuscarPedido", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@nmp", pedidoFormateado.Id);
            command.Parameters.AddWithValue("@nmcl", pedidoFormateado.NombreCliente);
            command.Parameters.AddWithValue("@f1", pedidoFormateado.FechaA);
            command.Parameters.AddWithValue("@f2", pedidoFormateado.FechaB);
            command.Parameters.AddWithValue("@opt", pedidoFormateado.Opcion);

            SOpen();

            List<Pedidos> pedidos = new List<Pedidos>();
            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                pedidos.Add(
                    new Pedidos(
                        reader["Clave"].ToString(),
                        $"{reader["NombreDen"]} {reader["ApellidosDen"]}",
                        reader["Cedula"].ToString(),
                        Convert.ToDateTime(reader["Fecha"])));
            }

            reader.Close();

            SClose();

            return pedidos;
        }

        private static List<Productos> BuscarListaProductos(string id)
        {
            MySqlCommand command = new MySqlCommand("ObtenerListaPedidos", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@clv", id);

            SOpen();

            List<Productos> pedidos = new List<Productos>();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows && reader.Read())
            {
                pedidos.Add(
                    new Productos(
                        reader["Clave"].ToString(),
                        reader["Producto"].ToString(),
                        Convert.ToDecimal(reader["PrecioProducto"]),
                        reader["Material1"].ToString(),
                        Convert.ToDecimal(reader["PrecioMat1"]),
                        reader["Material2"].ToString(),
                        Convert.ToDecimal(reader["PrecioMat2"]),
                        Convert.ToDateTime(reader["Fecha"]))
                    );
            }

            reader.Close();
            SClose();

            return pedidos;
        }

        public static Factura GenerarFactura(string id)
        {
            MySqlCommand command = new MySqlCommand("ObtenerPedidoUnico", Conectar()) { CommandType = CommandType.StoredProcedure };

            command.Parameters.AddWithValue("@np", id);

            SOpen();

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {  reader.Read();}
            else
            {  return null;}

            decimal importe = 0;

            Factura factura = new Factura(
                reader["Calle"].ToString(),
                reader["Ciudad"].ToString(),
                reader["Colonia"].ToString(),
                reader["Email"].ToString(),
                reader["CP"].ToString(),
                reader["Estado"].ToString(),
                Convert.ToInt32(reader["Estatus"].ToString()),
                Convert.ToDateTime(reader["Fecha"]),
                importe,
                $"{reader["NombreDen"]} {reader["ApellidosDen"]}",
                reader["NumFrente"].ToString(),
                reader["Pais"].ToString(),
                reader["Clave"].ToString(),
                reader["Rfc"].ToString(),
                reader["Telefono"].ToString()
                );

            reader.Close();
            SClose();

            command = new MySqlCommand("ObtenerListaPedidos", Conectar()) { CommandType = CommandType.StoredProcedure };
            command.Parameters.AddWithValue("@clv", factura.Pedidos);

            SOpen();

            reader = command.ExecuteReader();
            List<Productos> pedidos = new List<Productos>();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    pedidos.Add(new Productos(
                        reader["Clave"].ToString(),
                        reader["Producto"].ToString(),
                        Convert.ToDecimal(reader["PrecioProducto"]),
                        reader["Material1"].ToString(),
                        Convert.ToDecimal(reader["PrecioMat1"]),
                        reader["Material2"].ToString(),
                        Convert.ToDecimal(reader["PrecioMat2"]),
                        Convert.ToDateTime(reader["Fecha"])));
                }
            }

            factura.ListaProductos = pedidos;
            importe = pedidos.Sum(pedido => pedido.PrecioProducto + pedido.PrecioMat1 + pedido.PrecioMat2);
            factura.Importe = importe;

            SClose();
            return factura;
        }

        public static List<Factura> BuscarFactura(CriterioBusqueda pedidoFormateado)
        {
            MySqlCommand command = new MySqlCommand("BuscarFactura", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@idf", pedidoFormateado.Id);
            command.Parameters.AddWithValue("@nmcl", pedidoFormateado.NombreCliente);
            command.Parameters.AddWithValue("@f1", pedidoFormateado.FechaA);
            command.Parameters.AddWithValue("@f2", pedidoFormateado.FechaB);
            command.Parameters.AddWithValue("@opt", pedidoFormateado.Opcion);

            SOpen();

            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows) return null;

            reader.Read();
            List<Productos> listaProductos = BuscarListaProductos(reader["pedidos"].ToString());

            reader.Close();
            SClose();

            command = new MySqlCommand("BuscarFactura", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@idf", pedidoFormateado.Id);
            command.Parameters.AddWithValue("@nmcl", pedidoFormateado.NombreCliente);
            command.Parameters.AddWithValue("@f1", pedidoFormateado.FechaA);
            command.Parameters.AddWithValue("@f2", pedidoFormateado.FechaB);
            command.Parameters.AddWithValue("@opt", pedidoFormateado.Opcion);

            SOpen();

            reader = command.ExecuteReader();
            List<Factura> facturas = new List<Factura>();

            while (reader.HasRows && reader.Read())
            {
                facturas.Add(
                    new Factura(
                        reader["CalleC"].ToString(),
                        reader["CalleE"].ToString(),
                        reader["CiudadC"].ToString(),
                        reader["CiudadE"].ToString(),
                        reader["ColoniaC"].ToString(),
                        reader["ColoniaE"].ToString(),
                        reader["CorreoC"].ToString(),
                        reader["CorreoE"].ToString(),
                        reader["CpC"].ToString(),
                        reader["CpE"].ToString(),
                        reader["EstadoC"].ToString(),
                        reader["EstadoE"].ToString(),
                        Convert.ToInt32(reader["Estatus"]),
                        Convert.ToInt32(reader["Id"]),
                        Convert.ToDateTime(reader["Fecha"]),
                        Convert.ToDecimal(reader["Importe"]),
                        listaProductos,
                        reader["NombreC"].ToString(),
                        reader["NombreE"].ToString(),
                        reader["NumCasaC"].ToString(),
                        reader["NumCasaE"].ToString(),
                        reader["PaisC"].ToString(),
                        reader["PaisE"].ToString(),
                        reader["Pedidos"].ToString(),
                        reader["RfcC"].ToString(),
                        reader["RfcE"].ToString(),
                        reader["TelefonoC"].ToString(),
                        reader["TelefonoE"].ToString()
                        ));
            }

            reader.Close();
            SClose();

            return facturas;
        }

        public static Factura BuscarFactura(int facturaId)
        {
            MySqlCommand command = new MySqlCommand("BuscarFactura", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };

            CriterioBusqueda criterioBusqueda = new CriterioBusqueda();

            command.Parameters.AddWithValue("@idf", facturaId);
            command.Parameters.AddWithValue("@nmcl", criterioBusqueda.NombreCliente);
            command.Parameters.AddWithValue("@f1", criterioBusqueda.FechaA);
            command.Parameters.AddWithValue("@f2", criterioBusqueda.FechaB);
            command.Parameters.AddWithValue("@opt", 1);

            SOpen();
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
                reader.Read();
            else return null;

            List<Productos> listaPedidos = BuscarListaProductos(reader["Pedidos"].ToString());

            reader.Close();
            SClose();

            command = new MySqlCommand("BuscarFactura", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };

            criterioBusqueda = new CriterioBusqueda();

            command.Parameters.AddWithValue("@idf", facturaId);
            command.Parameters.AddWithValue("@nmcl", criterioBusqueda.NombreCliente);
            command.Parameters.AddWithValue("@f1", criterioBusqueda.FechaA);
            command.Parameters.AddWithValue("@f2", criterioBusqueda.FechaB);
            command.Parameters.AddWithValue("@opt", 1);

            SOpen();
            reader = command.ExecuteReader();

            Factura factura = null;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    factura = new Factura(
                             reader["CalleC"].ToString(),
                        reader["CalleE"].ToString(),
                        reader["CiudadC"].ToString(),
                        reader["CiudadE"].ToString(),
                        reader["ColoniaC"].ToString(),
                        reader["ColoniaE"].ToString(),
                        reader["CorreoC"].ToString(),
                        reader["CorreoE"].ToString(),
                        reader["CpC"].ToString(),
                        reader["CpE"].ToString(),
                        reader["EstadoC"].ToString(),
                        reader["EstadoE"].ToString(),
                        Convert.ToInt32(reader["Estatus"]),
                        Convert.ToInt32(reader["Id"]),
                        Convert.ToDateTime(reader["Fecha"]),
                        Convert.ToDecimal(reader["Importe"]),
                        listaPedidos, 
                        reader["NombreC"].ToString(),
                        reader["NombreE"].ToString(),
                        reader["NumCasaC"].ToString(),
                        reader["NumCasaE"].ToString(),
                        reader["PaisC"].ToString(),
                        reader["PaisE"].ToString(),
                        reader["Pedidos"].ToString(),
                        reader["RfcC"].ToString(),
                        reader["RfcE"].ToString(),
                        reader["TelefonoC"].ToString(),
                        reader["TelefonoE"].ToString()
                        );
                }
            }

            reader.Close();
            SClose();

            return factura;
        }

        public static void GuardarFactura(Factura factura)
        {
            MySqlCommand command = new MySqlCommand("GuardarFactura", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@idf", factura.Id);
            command.Parameters.AddWithValue("@imp", factura.Importe);
            command.Parameters.AddWithValue("@fch", factura.Fecha);
            command.Parameters.AddWithValue("@nmc", factura.NombreC);
            command.Parameters.AddWithValue("@nme", factura.NombreE);
            command.Parameters.AddWithValue("@cee", factura.CorreoE);
            command.Parameters.AddWithValue("@cec", factura.CorreoC);
            command.Parameters.AddWithValue("@cpc", factura.CpC);
            command.Parameters.AddWithValue("@cpe", factura.CpE);
            command.Parameters.AddWithValue("@drc", factura.CalleC);
            command.Parameters.AddWithValue("@dre", factura.CalleE);
            command.Parameters.AddWithValue("@esc", factura.EstadoC);
            command.Parameters.AddWithValue("@ese", factura.EstadoE);
            command.Parameters.AddWithValue("@pds", factura.Pedidos);
            command.Parameters.AddWithValue("@rfc", factura.RfcC);
            command.Parameters.AddWithValue("@rfe", factura.RfcE);
            command.Parameters.AddWithValue("@tlc", factura.TelefonoC);
            command.Parameters.AddWithValue("@tle", factura.TelefonoE);
            command.Parameters.AddWithValue("@cdc", factura.CiudadC);
            command.Parameters.AddWithValue("@cde", factura.CiudadE);
            command.Parameters.AddWithValue("@ncc", factura.NumCasaC);
            command.Parameters.AddWithValue("@nce", factura.NumCasaE);
            command.Parameters.AddWithValue("@clc", factura.ColoniaC);
            command.Parameters.AddWithValue("@cle", factura.ColoniaE);
            command.Parameters.AddWithValue("@psc", factura.PaisC);
            command.Parameters.AddWithValue("@pse", factura.PaisE);

            SOpen();

            command.ExecuteNonQuery();

            SClose();
        }

        public static List<int> ObtenerIdFacturas()
        {
            MySqlCommand command = new MySqlCommand("ObtenerIdFacturas", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };

            SOpen();

            List<int> ids = new List<int>();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows && reader.Read())
            {
                ids.Add(Convert.ToInt32(reader["id"]));
            }

            reader.Close();
            SClose();

            return ids;
        }

        public static void CancelarFactura(int facturaId)
        {
            MySqlCommand command = new MySqlCommand("CancelarFactura", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@idf", facturaId);

            SOpen();

            command.ExecuteNonQuery();

            SClose();
        }

        public static List<Historial> BuscarHistorial(int opcion)
        {
            MySqlCommand command = new MySqlCommand("ObtenerHistorial", Conectar())
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@opt", opcion);

            SOpen();

            MySqlDataReader reader = command.ExecuteReader();

            List<Historial> listaHistorial = new List<Historial>();
            while (reader.HasRows && reader.Read())
            {
                listaHistorial.Add(new Historial(
                    reader["id"].ToString(),
                    reader["descripcion"].ToString(),
                    reader["tipo"].ToString(),
                    Convert.ToDateTime(reader["fecha"]),
                    Convert.ToInt32(reader["pedido"])
                    ));
            }

            reader.Close();
            SClose();

            return listaHistorial;


        }

        public static void SOpen()
        {

            if (_conexion.State != ConnectionState.Open)
                _conexion.Open();
            else
            {
                _conexion.Close();
                _conexion.Open();
            }


        }

        public static void SClose()
        {
            if (_conexion.State == ConnectionState.Open)
                _conexion.Close();
        }
    

    #endregion

    public bool ValidarRespuesta(int NumeroTrabajador, string Respuesta)
        {
            var command = new MySqlCommand("ValidarRespuesta", conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@num", NumeroTrabajador);
            command.Parameters.AddWithValue("@resp", Respuesta);
            Open();
            var reader = command.ExecuteReader();
            bool Validado = false;
            if (reader.HasRows)
            {
                reader.Read();
                if (reader.GetInt32(0) > 0)
                    Validado = true;
            }
            Close();
            return Validado;
        }

        #endregion

        #region Resposabilidades Privadas

        /// <summary>
        /// método encargado de solicitar a la InterfaceBaseDeDatos la contraseña del usuario que solicita la recuperación
        /// </summary>
        /// <param name="Usuario">Objeto que contiene la información de la tarjeta del usuario.</param>
        /// <param name="p">Contiene la contraseña obtenida de la base de datos.</param>
        /// <returns>Confirmacion de la obtencion de la contraseña del usuario con exito</returns>
        public bool RecuperarContraseña(int NumeroEmpleado, out string p)
        {
            var command = new MySqlCommand("RecuperarContraseña", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@nmtrb", NumeroEmpleado);

            p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            if (str.HasRows)
            {
                str.Read();
                p = str[0].ToString();
            }
            Close();
            return EnviarConfirmacion(p);
        }

        public string RecuperarPregunta(int NumeroEmpleado)
        {
            var command = new MySqlCommand("RecuperarPregunta", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@emp", NumeroEmpleado);

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            if (str.HasRows)
            {
                str.Read();
                p = str[0].ToString();
            }
            Close();
            return p;
        }

        /// <summary>
        /// Método encargado de solicitar a la base de datos un RegistroUsuario
        /// </summary>
        /// <param name="login">Cadena que contiene el Login del usuario a recuperar</param>
        /// <param name="Usuario">Objeto que regresa el registro de usuario</param>
        /// <returns>Confirmación de la existencia de un registro de Usuario con el Login especificado</returns>
        //public bool RecuperarUsuario(string login, out RegistroUsuario Usuario)
        //{
        //    var command = new MySqlCommand("RecuperarUsuario", conexion);
        //    command.CommandType = CommandType.StoredProcedure;

        //    command.Parameters.AddWithValue("@log", login);

        //    Open();

        //    var reader = command.ExecuteReader();

        //    Usuario = null;

        //    if (reader.HasRows)
        //    {
        //        reader.Read();
        //        Usuario = new RegistroUsuario
        //        (
        //            /*Convert.ToInt32(reader["nmtrabajador"]),
        //            reader["nombre"].ToString(),
        //            reader["apellidos"].ToString(),
        //            reader["login"].ToString(),
        //            reader["contrasena"].ToString(),
        //            reader["t_usuario"].ToString(),
        //            reader["pais"].ToString(),
        //            reader["estado"].ToString(),
        //            reader["municipio"].ToString(),
        //            reader["ciudad"].ToString(),
        //            reader["colonia"].ToString(),
        //            reader["calle"].ToString(),
        //            reader["numcasa"].ToString(),
        //            reader["cp"].ToString(),
        //            reader["tel_casa"].ToString(),
        //            reader["tel_movil"].ToString(),
        //            reader["tel_oficina"].ToString(),
        //            reader["email"].ToString(),
        //            reader["Pregunta"].ToString(),
        //            reader["Respuesta"].ToString(),
        //            Convert.ToByte(reader["estatus"])*/);
        //    }
        //    Close();
        //    return EnviarConfirmacion(Usuario);
        //}

        /// <summary>
        /// Método encargado de solicitar a la base de datos un RegistroTarjeta
        /// </summary>
        /// <param name="login">Cadena que contiene el usuario al cuál le pertenece la tarjeta a recuperar</param>
        /// <param name="Tarjeta">Objeto que regresa el registro de tarjeta</param>
        /// <returns>Confirmación de la existencia de un registro de Tarjeta con el login especificado</returns>
        public bool RecuperarTarjeta(string login, out RegistroTarjeta Tarjeta)
        {
            var command = new MySqlCommand("RecuperarTarjeta", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@log", login);
            Open();
            var reader = command.ExecuteReader();
            Tarjeta = null;
            if (reader.HasRows)
            {
                reader.Read();
                Tarjeta = new RegistroTarjeta
                (
                    reader["login"].ToString(),
                    reader["numero"].ToString(),
                    reader["titular"].ToString(),
                    reader["apellidos"].ToString(),
                    reader["banco"].ToString(),
                    reader["fven"].ToString(),
                    reader["activo"].ToString()
                );
            }
            Close();
            return EnviarConfirmacion(Tarjeta);
        }

        /// <summary>
        /// Método encargado de solicitar a la InterfaceBaseDeDatos la confirmación del registro de administrador.
        /// </summary>
        /// <param name="nc">Cantidad de renglones afectados de la base de datos.</param>
        /// <returns>Confirmacion de que se realizaron cambios en la base de datos</returns>
        private bool EnviarConfirmacion(int nc)
        {
            return nc > 0;
        }

        /// <summary>
        /// Método encargado de solicitar a la InterfaceBaseDeDatos la confirmación del registro de administrador.
        /// </summary>
        /// <param name="pd">Contraseña del usuario.</param>
        /// <returns>Confirmacion de que la información recibida contenga la contraseña del usuario</returns>
        private bool EnviarConfirmacion(string pd)
        {
            return pd != string.Empty;
        }

        #endregion

        #region Metodos Auxiliares

        /// <summary>
        /// Abre la conexion a la base de datos.
        /// </summary>
        public void Open()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                else
                {
                    conexion.Close();
                    Open();
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show("No se pudo establecer la conexión, por favor revisa tu conexión a internet","Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Cierra la conexion a la base de datos.
        /// </summary>
        public void Close()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        /// <summary>
        /// Verifica la existencia de un objeto inicializado
        /// </summary>
        /// <param name="pd">Objeto a verificar</param>
        /// <returns>Verdadero en caso de ser un objeto inicializado, Falso en caso de ser null</returns>
        private bool EnviarConfirmacion(object pd)
        {
            return pd != null;
        }

        #endregion
    }

    public class Pedidos
    {
        public string Clave;
        public string NombrDen;
        public string Cedula;
        public DateTime Fecha;

        public Pedidos(string clave, string nombrDen, string cedula, DateTime fecha)
        {
            Clave = clave;
            NombrDen = nombrDen;
            Cedula = cedula;
            Fecha = fecha;
        }
    }

    internal static class CnDefault
    {
        public const uint Port = 3306;
        public const string Server = "sql9.freesqldatabase.com";
        public const string UserId = "sql9174827";
        public const string Password = "tHc9X1c9xh";
        public const string Database = "sql9174827";
    }

    public class CriterioBusqueda
    {
        public string FechaA;
        public string FechaB;
        public int Id;
        public string NombreCliente;
        public int Opcion;

        public CriterioBusqueda(string fechaA, string fechaB, int id, string nombreCliente, int opcion)
        {
            FechaA = fechaA;
            FechaB = fechaB;
            Id = id;
            NombreCliente = nombreCliente;
            Opcion = opcion;
        }

        public CriterioBusqueda()
            : this(DateTime.MinValue.ToShortDateString(), DateTime.MinValue.ToShortDateString(), -1, string.Empty, 0)
        {
        }
    }

}