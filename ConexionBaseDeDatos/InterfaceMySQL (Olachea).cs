using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ConexionBaseDeDatos
{
    /// <summary>
    /// Describe los métodos para accesar a una base de datos de MySQL
    /// </summary>
    public static partial class InterfaceMySQL
    {
        //En esta clase sólo Olachea deberá meter sólo los métodos y atributos que ocupe

        /// <summary>
        /// Realiza la consulata personalizada para los reportes personalizados
        /// </summary>
        /// <param name="select">Consulta perosnalizada.</param>
        /// <returns></returns>
        public static DataSet rConsultaSelect(string select)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(select, Conexion);
            DatosPer dataSet = new DatosPer();
            adapter.Fill(dataSet, "DTDP");
            return dataSet;
        }

        private static void rEjecutarProcedimientoAlmacenado(string NombreProcedimiento, TipoConsulta Tipo)
        {
            Comando = new MySqlCommand(NombreProcedimiento, Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            AbrirConexion();
            if (Tipo == TipoConsulta.DevuelveInt)
            {
                RegistrosAfectados = Comando.ExecuteNonQuery();
            }
            else
            {
                Lector = Comando.ExecuteReader();
                TablaDeResultados = new DataTable();
                TablaDeResultados.Load(Lector);
            }
            CerrarConexion();
        }

        static void rEjecutarProcedimientoAlmacenado(string NombreProcedimiento, TipoConsulta Tipo, MySqlParameter[] Datos)
        {
            Comando = new MySqlCommand(NombreProcedimiento, Conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            foreach (MySqlParameter dato in Datos)
            {
                Comando.Parameters.Add(dato);
            }
            AbrirConexion();
            if (Tipo == TipoConsulta.DevuelveInt)
            {
                RegistrosAfectados = Comando.ExecuteNonQuery();
            }
            else
            {
                Lector = Comando.ExecuteReader();
                var a = Lector.HasRows;
                TablaDeResultados = new DataTable();
                TablaDeResultados.Load(Lector);
            }
            CerrarConexion();
        }

        public static DataTable rRecuperarDatos(string nombreProcedimiento, Dictionary<string, object> parametros)
        {
            MySqlParameter[] listaParametros = parametros.Select(a => Parametro(a.Key, a.Value)).ToArray();
            rEjecutarProcedimientoAlmacenado(nombreProcedimiento, TipoConsulta.DevuelveReader, listaParametros);
            return TablaDeResultados;
        }

        public static void rGuardarDatos(string nombreProcedimiento, Dictionary<string, object> parametros)
        {
            MySqlParameter[] listaParametros = parametros.Select(a => Parametro(a.Key, a.Value)).ToArray();
            rEjecutarProcedimientoAlmacenado(nombreProcedimiento, TipoConsulta.DevuelveInt, listaParametros);
        }

        public static DataTable rRecuperarDatos(string nombreProcedimiento)
        {
            rEjecutarProcedimientoAlmacenado(nombreProcedimiento, TipoConsulta.DevuelveReader);
            return TablaDeResultados;
        }
    }
}