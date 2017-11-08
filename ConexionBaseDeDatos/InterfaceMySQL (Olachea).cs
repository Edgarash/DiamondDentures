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
        //En esta clase sólo Olachea deberá meter sólo los métodos y atributos que ocupe

        public static DataSet ConsultaSelect(string select)
        {
            var  adapter = new MySqlDataAdapter(select, Conexion);
            DatosPer dataSet = new DatosPer();
            adapter.Fill(dataSet,"DTDP");
            return dataSet;
        }











    }
}