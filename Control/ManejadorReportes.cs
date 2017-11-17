using System.Collections.Generic;
using System.Data;
using Entidad;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ConexionBaseDeDatos;

namespace Control
{
    public static class ManejadorReportes
    {
        public static void ExportarReporte<T>(string ruta, T reporte) where T : ReportClass
        {
            reporte.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            reporte.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            reporte.ExportOptions.DestinationOptions = new DiskFileDestinationOptions
            {
                DiskFileName = ruta
            };
            reporte.ExportOptions.FormatOptions = new PdfRtfWordFormatOptions();
            reporte.Export();
        }

        public static T CargarReporte<T>(T reporte) where T : ReportClass => reporte;

        public static T CargarReporte<T>(T reporte, params ParametroReporte[] parametros) where T : ReportClass
        {
            foreach (ParametroReporte parametro in parametros)
            {
                reporte.SetParameterValue(parametro.Nombre, parametro.Valor);
            }
            return reporte;
        }

        public static T CargarReporte<T>(T reporte, Dictionary<string, ParametroReporte> estadoColumnas) where T : ReportClass
        {
            foreach (KeyValuePair<string, ParametroReporte> parametroReporte in estadoColumnas)
            {
                reporte.SetParameterValue(parametroReporte.Value.Nombre,parametroReporte.Value.Valor);
            }
            return reporte;
        }

        public static void GuardarFactura(Dictionary<string, object> informacion) => InterfaceMySQL.rGuardarDatos("R_GuardarFactura", informacion);

        public static DataTable CargarDatos(Dictionary<string, object> parametros) => InterfaceMySQL.rRecuperarDatos("R_RecuperarVentas", parametros);
    }
}
