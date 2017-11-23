using System;
using System.Data;
using MySql.Data.MySqlClient;
using Entidad;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
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

        #endregion

        #region Módulo Configuración

        public bool RegistrarProducto(RegistroProducto Registro)
        {
            var command = new MySqlCommand("RegistrarProducto", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Registro.IDProducto);
            command.Parameters.AddWithValue("@nmb", Registro.Nombre);
            command.Parameters.AddWithValue("@days", Registro.TiempoBase);
            command.Parameters.AddWithValue("@price", Registro.PrecioBase);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool RegistrarMaterial(RegistroMaterial Material)
        {
            var command = new MySqlCommand("RegistrarMaterial", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Material.IDMaterial);
            command.Parameters.AddWithValue("@nmb", Material.Nombre);
            command.Parameters.AddWithValue("@price", Material.PrecioBase);
            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool RegistrarPedido(RegistroPedido Pedido)
        {
            var command = new MySqlCommand("RegistrarPedido", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", Pedido.IDPedido);
            command.Parameters.AddWithValue("@user", Pedido.IDEmpleado);
            command.Parameters.AddWithValue("@dat", Convert.ToDateTime(Pedido.FechaIngreso));
            command.Parameters.AddWithValue("@ced", Pedido.Cedula);
            command.Parameters.AddWithValue("@rf", Pedido.Dentista.RFC);
            command.Parameters.AddWithValue("@nmb", Pedido.Dentista.Nombre);
            command.Parameters.AddWithValue("@ape", Pedido.Dentista.Apellidos);
            command.Parameters.AddWithValue("@tel", Pedido.Dentista.TelOficina);
            command.Parameters.AddWithValue("@pa", Pedido.Dentista.Pais);
            //command.Parameters.AddWithValue("@es", Pedido.Estado);
            //command.Parameters.AddWithValue("@mu", Pedido.Municipio);
            //command.Parameters.AddWithValue("@ciu", Pedido.Ciudad);
            //command.Parameters.AddWithValue("@col", Pedido.Colonia);
            //command.Parameters.AddWithValue("@cal", Pedido.Calle);
            //command.Parameters.AddWithValue("@num", Pedido.NumeroFrente);
            //command.Parameters.AddWithValue("@codp", Pedido.CP);
            //command.Parameters.AddWithValue("@ema", Pedido.Email);
            command.Parameters.AddWithValue("@fechaent", Convert.ToDateTime(Pedido.FechaCalculada));
            command.Parameters.AddWithValue("@esta", Pedido.EstadoPedido);
            command.Parameters.AddWithValue("@asig", Pedido.Laboratorista);
            //command.Parameters.AddWithValue("@urg", Pedido.Urgente);
            Open();
            var nc = command.ExecuteNonQuery();
            if (EnviarConfirmacion(nc))
            {
                //for (int i = 0; i < Pedido.Trabajos.Length; i++)
                //    RegistrarTrabajos(Pedido.IDPedido, Pedido.Trabajos[i]);
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

            command.Parameters.AddWithValue("@clv", Pedido.IDPedido);
            command.Parameters.AddWithValue("@user", Pedido.IDEmpleado);
            command.Parameters.AddWithValue("@dat", Convert.ToDateTime(Pedido.FechaIngreso));
            command.Parameters.AddWithValue("@ced", Pedido.Cedula);
            command.Parameters.AddWithValue("@rf", Pedido.Dentista.RFC);
            command.Parameters.AddWithValue("@nmb",Pedido.Dentista.Nombre);
            command.Parameters.AddWithValue("@ape",Pedido.Dentista.Apellidos);
            command.Parameters.AddWithValue("@tel", Pedido.Dentista.TelOficina);
            command.Parameters.AddWithValue("@pa", Pedido.Dentista.Pais);
            command.Parameters.AddWithValue("@es", Pedido.Dentista.Estado);
            command.Parameters.AddWithValue("@mu", Pedido.Dentista.Municipio);
            command.Parameters.AddWithValue("@ciu", Pedido.Dentista.Ciudad);
            command.Parameters.AddWithValue("@col", Pedido.Dentista.Colonia);
            command.Parameters.AddWithValue("@cal", Pedido.Dentista.Direccion);
            command.Parameters.AddWithValue("@codp", Pedido.Dentista.CodPos);
            command.Parameters.AddWithValue("@ema", Pedido.Dentista.Email);
            command.Parameters.AddWithValue("@fechaent", Convert.ToDateTime(Pedido.FechaCalculada));
            command.Parameters.AddWithValue("@esta", Pedido.EstadoPedido);
            command.Parameters.AddWithValue("@asig", Pedido.Laboratorista);
            command.Parameters.AddWithValue("@urg", Pedido.Urgencia);
            Open();
            var nc = command.ExecuteNonQuery();
            if (EnviarConfirmacion(nc))
            {
                for (int i = 0; i < Pedido.Productos.Length; i++)
                    RegistrarTrabajos(Pedido.IDPedido, Pedido.Productos[i]);
            }
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool RegistrarTrabajos(string Clave, RegistroTrabajo Trabajo)
        {
            var command = new MySqlCommand("RegistrarTrabajo", conexion);
            //command.CommandType = CommandType.StoredProcedure;

            //command.Parameters.AddWithValue("@clv", Clave);
            //command.Parameters.AddWithValue("@pro", Trabajo.IDProducto);
            //command.Parameters.AddWithValue("@pre", Trabajo.PrecioProducto);
            //command.Parameters.AddWithValue("@mat1", Trabajo.IDMaterial1);
            //command.Parameters.AddWithValue("@pre1", Trabajo.PrecioMaterial1);
            //command.Parameters.AddWithValue("@mat2", Trabajo.IDMaterial2);
            //command.Parameters.AddWithValue("@pre2", Trabajo.PrecioMaterial2);
            //command.Parameters.AddWithValue("@fec", Convert.ToDateTime(Trabajo.Fecha));
            //Open();
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

            command.Parameters.AddWithValue("@clv", producto.IDProducto);
            command.Parameters.AddWithValue("@nmb", producto.Nombre);
            command.Parameters.AddWithValue("@days", producto.TiempoBase);
            command.Parameters.AddWithValue("@price", producto.PrecioBase);

            Open();
            var nc = command.ExecuteNonQuery();
            Close();
            return EnviarConfirmacion(nc);
        }

        public bool ActualizarMaterial(RegistroMaterial material)
        {
            var command = new MySqlCommand("ActualizarMaterial", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@clv", material.IDMaterial);
            command.Parameters.AddWithValue("@nmb", material.Nombre);
            command.Parameters.AddWithValue("@price", material.PrecioBase);

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
                    //Lista.Add(new RegistroMaterial(str.GetInt32(0), str.GetString(1), str.GetFloat(2), str.GetInt32(3)));
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

            command.Parameters.AddWithValue("@clv", Registro.IDProducto);
            command.Parameters.AddWithValue("@nmb", Registro.Nombre);
            command.Parameters.AddWithValue("@days", Registro.TiempoBase);
            command.Parameters.AddWithValue("@price", Registro.PrecioBase.ToString());

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            if (str.HasRows)
            {
                List<RegistroProducto> Lista = new List<RegistroProducto>();
                while (str.Read())
                {
                    //Lista.Add(new RegistroProducto(str.GetInt32(0), str.GetString(1), str.GetInt32(2), str.GetFloat(3), str.GetInt32(4)));
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

            command.Parameters.AddWithValue("@clv", Material.IDMaterial);
            command.Parameters.AddWithValue("@nmb", Material.Nombre);
            command.Parameters.AddWithValue("@price", Material.PrecioBase.ToString());

            string p = string.Empty;
            Open();
            var str = command.ExecuteReader();

            if (str.HasRows)
            {
                List<RegistroMaterial> Lista = new List<RegistroMaterial>();
                while (str.Read())
                {
                    //Lista.Add(new RegistroMaterial(str.GetInt32(0), str.GetString(1), str.GetInt32(2), str.GetInt32(3)));
                }
                temp = Lista.ToArray();
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
                    //temp.Add(new RegistroTrabajo(str.GetString(1), str.GetFloat(2), str.GetString(3), str.GetFloat(4), str.GetString(5), str.GetFloat(6), Convert.ToDateTime(str.GetString(7)).ToShortDateString()));
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
                //temp = new RegistroProducto(str.GetInt32(0), str.GetString(1), str.GetInt32(2), str.GetFloat(3), str.GetInt32(4));
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
                //temp = new RegistroMaterial(str.GetInt32(0), str.GetString(1), str.GetFloat(2), str.GetInt32(3));
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