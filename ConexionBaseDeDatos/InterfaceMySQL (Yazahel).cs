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
        //En esta clase sólo Yazahel deberá meter sólo los métodos y atributos que ocupe
        public static bool FinanzasVerVentasGeneradas(DataGridView temp, string fech)
        {
            EjecutarProcedimientoAlmacenado("FinanzasVentasGeneradas", TipoConsulta.DevuelveReader,
                Parametro("fec", "%"+fech+"%"));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }
        public static bool FinanzasBusquedaVentasGeneradas(DataGridView temp, string busca, string idp)
        {
            EjecutarProcedimientoAlmacenado("FinanzasBusquedaVentasGeneradas", TipoConsulta.DevuelveReader,
                Parametro("logi", "%"+busca+"%"),
                Parametro("idp", "%"+idp+"%"));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }
        public static bool FinanzasBuscarAdminPagos(DataGridView temp, string idp, string nomb)
        {
            EjecutarProcedimientoAlmacenado("FinanzasBuscarAdminPagos", TipoConsulta.DevuelveReader,
                Parametro("idp", "%"+idp+"%"),
                Parametro("nomb", "%" + nomb + "%"));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }
        public static bool FinanzasVerGastosGenerados(DataGridView temp, string fec)
        {
            EjecutarProcedimientoAlmacenado("FinanzasGastosGenerados", TipoConsulta.DevuelveReader,
                Parametro("fec", "%"+fec+"%"));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }
        public static bool RHumanosVerPagosTrabajadores(DataGridView temp)
        {
            EjecutarProcedimientoAlmacenado("RHumanosEmpleados", TipoConsulta.DevuelveReader,
                Parametro("", null));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }       
        public static void FinanzasObtenerUsuario(ComboBox combobx)
        {
            EjecutarProcedimientoAlmacenado2(combobx, "FinanzasObtenerUsuarios", TipoConsulta.DevuelveReader,
                Parametro("", null));
        }
        public static bool FinanzasVerIsumos(DataGridView temp)
        {
            EjecutarProcedimientoAlmacenado("FinanzasVerComprarInsumos", TipoConsulta.DevuelveReader,
                Parametro("", null));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }
        public static bool FinanzasPagos(DataGridView temp)
        {
            EjecutarProcedimientoAlmacenado("FinanzasPagos", TipoConsulta.DevuelveReader,
                Parametro("", null));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }
        public static bool FinanzasBalanceCuentasIngresos(DataGridView temp, string fec)
        {
            EjecutarProcedimientoAlmacenado("FinanzasBalanceCuentasIngresos", TipoConsulta.DevuelveReader,
                Parametro("fec", "%"+fec+"%"));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }
        public static bool FinanzasBalanceCuentasEgresos(DataGridView temp, string fec)
        {
            EjecutarProcedimientoAlmacenado("FinanzasBalanceCuentasEgresos", TipoConsulta.DevuelveReader,
                Parametro("fec", "%"+fec+"%"));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }
        public static bool FinanzasComprarIsumos(TextBox txID, 
            TextBox txNomb, TextBox txDesc, TextBox txCant, TextBox txPrUni, string p)
        {
            EjecutarProcedimientoAlmacenado("FinanzasComprarInsumos", TipoConsulta.DevuelveInt,
                Parametro("id", txID.Text.ToString()),
                Parametro("Nombre", txNomb.Text.ToString()),
                Parametro("Descripcion", txDesc.Text.ToString()),
                Parametro("Cantidad", txCant.Text.ToString()),
                Parametro("PrecioUnitario", txPrUni.Text.ToString()+".00"),
                Parametro("IDProveedor", p));
            return OperacionRealizada;
        }

        public static bool FinanzasAgregarCompra(TextBox txID)
        {
            EjecutarProcedimientoAlmacenado("FinanzasAgregarCompra", TipoConsulta.DevuelveInt,
                Parametro("idcompra", txID.Text.ToString()));
            return OperacionRealizada;
        }
        public static bool FinanzasTotalVentas(TextBox temp)
        {
            EjecutarProcedimientoAlmacenado3(temp,"FinanzasTotalVentas", TipoConsulta.DevuelveReader,
                Parametro("", null));
            return OperacionRealizada2;
        }
        public static bool FinanzasTotalGastos(TextBox temp)
        {
            EjecutarProcedimientoAlmacenado3(temp, "FinanzasTotalGastos", TipoConsulta.DevuelveReader,
                Parametro("", null));
            return OperacionRealizada2;
        }
        public static bool FinanzasTotalInsumos(TextBox temp)
        {
            EjecutarProcedimientoAlmacenado3(temp, "FinanzasTotalInsumos", TipoConsulta.DevuelveReader,
                Parametro("", null));
            return OperacionRealizada2;
        }
        public static bool RHumanosTotalPagoEmp(TextBox temp)
        {
            EjecutarProcedimientoAlmacenado3(temp, "RHumanosTotalPagoEmp", TipoConsulta.DevuelveReader,
                Parametro("", null));
            return OperacionRealizada2;
        }
        public static bool FinanzasTotalIngresos(TextBox temp)
        {
            EjecutarProcedimientoAlmacenado4(temp, "FinanzasTotalIngresos", TipoConsulta.DevuelveReader,
                Parametro("", null));
            return OperacionRealizada2;
        }
        public static bool FinanzasRegistrarPago(DataGridView temp, string nom, string des, string punit, string cant, string subt,
            string tot, string est, string reg, string fec)
        {
            EjecutarProcedimientoAlmacenado("FinanzasRegistrarPago", TipoConsulta.DevuelveInt,
                Parametro("nom", nom),
                Parametro("des", des),
                Parametro("punit", punit+"0.00"),
                Parametro("cant", cant),
                Parametro("subt", subt + "0.00"),
                Parametro("tot", tot + "0.00"),
                Parametro("est", est),
                Parametro("reg", reg),
                Parametro("fec", fec));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada;
        }
        public static bool FinanzasAgregaBalanceIngresos(DataGridView temp, string des, string val, string fec)
        {
            string descripcion = "Balance manual";
            EjecutarProcedimientoAlmacenado("FinanzasAgregaBalanceIngresos", TipoConsulta.DevuelveInt,
                Parametro("des", descripcion),
                Parametro("val", val + "0.00"),
                Parametro("fec", "%"+fec+"%"));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada;
        }
        public static bool FinanzasAgregaBalanceEgresos(DataGridView temp, string des, string val, string fec)
        {
            string descripcion = "Balance manual";
            EjecutarProcedimientoAlmacenado("FinanzasAgregaBalanceEgresos", TipoConsulta.DevuelveInt,
                Parametro("des", descripcion),
                Parametro("val", val + "0.00"),
                Parametro("fec", "%"+fec+"%"));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada;
        }
        public static bool FinanzasActualizarEstado(int id)
        {
            EjecutarProcedimientoAlmacenado("FinanzasActualizarEstado", TipoConsulta.DevuelveInt,
                Parametro("id", id));
            return OperacionRealizada;
        }

        public static bool RHumanosEmpleados(DataGridView temp)
        {
            EjecutarProcedimientoAlmacenado("RHumanosEmpleados", TipoConsulta.DevuelveReader,
                Parametro("", null));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }
        public static bool RHumanosTotalNomina(TextBox temp)
        {
            EjecutarProcedimientoAlmacenado3(temp, "RHumanosTotalNomina", TipoConsulta.DevuelveReader,
                Parametro("", null));
            return OperacionRealizada2;
        }
        public static bool RHumanosNomina(DataGridView temp)
        {
            EjecutarProcedimientoAlmacenado("RHumanosNomina", TipoConsulta.DevuelveReader,
                Parametro("", null));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }
        public static bool RHumanosAsistencia(DataGridView temp)
        {
            EjecutarProcedimientoAlmacenado("RHumanosAsistencia", TipoConsulta.DevuelveReader,
                Parametro("", null));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada2;
        }
        public static bool RHumanosAgregarNomina(DataGridView temp, string nemp, string fec, string nomb, string ape, string rfc,
            string mail, string dep, string pues, string dlab, string suel, string isr, string descisr, string sfinal, string pag)
        {
            EjecutarProcedimientoAlmacenado("RHumanosAgregarNomina", TipoConsulta.DevuelveInt,
                Parametro("nemp", nemp),
                Parametro("fec", fec),
                Parametro("nomb", nomb),
                Parametro("ape", ape),
                Parametro("rfc", rfc),
                Parametro("mail", mail),
                Parametro("dep", dep),
                Parametro("pues", pues),
                Parametro("dlab", dlab),
                Parametro("suel", suel + ".00"),
                Parametro("isr", isr),
                Parametro("descisr", descisr),
                Parametro("sfinal", sfinal + ".00"),
                Parametro("pag", pag));
            temp.DataSource = TablaDeResultados;
            return OperacionRealizada;
        }


        #region Metodos Auxiliares
        private static string ObtenerFecha(DateTime Fecha)
        {
            return "'" + Fecha.Year + "-" + Fecha.Month + "-" + Fecha.Day + "'";
        }

        static void EjecutarProcedimientoAlmacenado2
            (ComboBox cbox, string NombreProcedimiento, TipoConsulta Tipo, params MySqlParameter[] Datos)
        {
            Comando = new MySqlCommand(NombreProcedimiento, Conexion);
            for (int i = 0; i < Datos.Length; i++)
                Comando.Parameters.Add(Datos[i]);
            Comando.CommandType = CommandType.StoredProcedure;
            AbrirConexion();
            if (Tipo == TipoConsulta.DevuelveInt)
                RegistrosAfectados = Comando.ExecuteNonQuery();
            else
            {
                Lector = Comando.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        cbox.Items.Add(Lector[0].ToString());
                    }
                }
            }
            CerrarConexion();
        }

        static void EjecutarProcedimientoAlmacenado3
            (TextBox txBox, string NombreProcedimiento, TipoConsulta Tipo, params MySqlParameter[] Datos)
        {
            Comando = new MySqlCommand(NombreProcedimiento, Conexion);
            for (int i = 0; i < Datos.Length; i++)
                Comando.Parameters.Add(Datos[i]);
            Comando.CommandType = CommandType.StoredProcedure;
            AbrirConexion();
            if (Tipo == TipoConsulta.DevuelveInt)
                RegistrosAfectados = Comando.ExecuteNonQuery();
            else
            {
                Lector = Comando.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        txBox.Text = "TOTAL = $ "+ Lector[0].ToString();
                    }
                }
            }
            CerrarConexion();
        }

        static void EjecutarProcedimientoAlmacenado4
            (TextBox txBox, string NombreProcedimiento, TipoConsulta Tipo, params MySqlParameter[] Datos)
        {
            Comando = new MySqlCommand(NombreProcedimiento, Conexion);
            for (int i = 0; i < Datos.Length; i++)
                Comando.Parameters.Add(Datos[i]);
            Comando.CommandType = CommandType.StoredProcedure;
            AbrirConexion();
            if (Tipo == TipoConsulta.DevuelveInt)
                RegistrosAfectados = Comando.ExecuteNonQuery();
            else
            {
                Lector = Comando.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        txBox.Text = "FONDO = $ " + Lector[0].ToString();
                    }
                }
            }
            CerrarConexion();
        }
        #endregion
    }
}