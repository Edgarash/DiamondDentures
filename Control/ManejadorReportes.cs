using Entidad;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Control
{
    public static class ManejadorReportes
    {

        public static void ExportarReporte<T>(string ruta, T reporte) where T : ReportClass
        {
            reporte.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            reporte.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            reporte.ExportOptions.DestinationOptions = new DiskFileDestinationOptions {DiskFileName = ruta};
            reporte.ExportOptions.FormatOptions = new PdfRtfWordFormatOptions();
            reporte.Export();
        }

        public static T CargarReporte<T>(T reporte) where T : ReportClass => reporte;

        public static T CargarReporte<T>(T reporte, params ParametroReporte[] parametros) where T : ReportClass
        {
            foreach (ParametroReporte parametro in parametros)
            {
                reporte.SetParameterValue(parametro.Nombre,parametro.Valor );
            }
            return reporte;
        }
    }
}