﻿using Entidad;
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
        public static DataSet ConsultaSelect(string select)
        {
            var adapter = new MySqlDataAdapter(select, Conexion);
            DatosPer dataSet = new DatosPer();
            adapter.Fill(dataSet, "DTDP");
            return dataSet;
        }

        static void EjecutarProcedimientoAlmacenadoReportes
            (string NombreProcedimiento, TipoConsulta Tipo, MySqlParameter[] Datos)
        {
            Comando = new MySqlCommand(NombreProcedimiento, Conexion);
            foreach (MySqlParameter dato in Datos)
            {
                Comando.Parameters.Add(dato);
            }
            Comando.CommandType = CommandType.StoredProcedure;
            AbrirConexion();
            if (Tipo == TipoConsulta.DevuelveInt)
                RegistrosAfectados = Comando.ExecuteNonQuery();
            else
            {
                Lector = Comando.ExecuteReader();
                TablaDeResultados = new DataTable();
                TablaDeResultados.Load(Lector);
            }
            CerrarConexion();
        }

        public static DataTable rRecuperarDatos(string nombreProcedimiento, Dictionary<string, object> parametros)
        {
            MySqlParameter[] listaParametros = parametros.Select(a => Parametro(a.Key, a.Value)).ToArray();
            EjecutarProcedimientoAlmacenadoReportes(nombreProcedimiento, TipoConsulta.DevuelveReader, listaParametros);
            return TablaDeResultados;
        }

        public static void rGuardarDatos(string nombreProcedimiento, Dictionary<string, object> parametros)
        {
            var listaParametros = parametros.Select(a => Parametro(a.Key, a.Value)).ToArray();
            EjecutarProcedimientoAlmacenado(nombreProcedimiento, TipoConsulta.DevuelveInt, listaParametros);
        }
    }
}