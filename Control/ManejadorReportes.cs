using Entidad;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Control
{
    

    public static class ManejadorReportes
    {
//        public static ReporteCorteDeCaja GenerarReporteCDC(string fecha, string login, string responsable)
//        {
//            var reporte = new ReporteCorteDeCaja();
//            reporte.SetParameterValue();
//            reporte.SetParameterValue("logi", login);
//            reporte.SetParameterValue("fech", fecha);
//            reporte.SetParameterValue("nres", responsable);
//            return reporte;
//        }

        public static void DeterminarTipoReporte(string tipo)
        {
        }

        public static void ExportarReporte<T>(string ruta, T reporte) where T : ReportClass
        {
            reporte.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            reporte.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            reporte.ExportOptions.DestinationOptions = new DiskFileDestinationOptions {DiskFileName = ruta};
            reporte.ExportOptions.FormatOptions = new PdfRtfWordFormatOptions();
            reporte.Export();
        }

        public static ReporteNomina CargarReporte(ReporteNomina reporteNomina) => reporteNomina;

        public static ReporteComprobanteNomina CargarReporte(ReporteComprobanteNomina reporteComprobanteNomina, int id)
        {
            reporteComprobanteNomina.SetParameterValue("idPag", id);
            return reporteComprobanteNomina;
        }

        public static ReporteProveedores CargarReporte(ReporteProveedores reporteProveedores) => reporteProveedores;

        public static ReporteMateriales CargarReporte(ReporteMateriales reporteMateriales) => reporteMateriales;

        public static ReporteProductoMateriales CargarReporte(ReporteProductoMateriales reporteProductoMateriales) => reporteProductoMateriales;

        public static ReporteMaterialesComprados CargarReporte(ReporteMaterialesComprados reporteMaterialesComprados) => reporteMaterialesComprados;

        public static ReporteInsumosComprados CargarReporte(ReporteInsumosComprados reporteInsumosComprados) => reporteInsumosComprados;

        public static ReporteVentasN CargarReporte(ReporteVentasN reporteVentasN) => reporteVentasN;

        public static ReporteGastos CargarReporte(ReporteGastos reporteGastos) => reporteGastos;

        public static ReporteGastoIEsp CargarReporte(ReporteGastoIEsp reporteGastoIEsp, string nomins, int idins)
        {
            reporteGastoIEsp.SetParameterValue("NomIs", nomins);
            reporteGastoIEsp.SetParameterValue("idComp", idins);
            return reporteGastoIEsp;
        }

        public static ReporteGastoMEsp CargarReporte(ReporteGastoMEsp reporteGastoMEsp, string nommat, int idmat)
        {
            reporteGastoMEsp.SetParameterValue("NomMat",nommat);
            reporteGastoMEsp.SetParameterValue("idComp",idmat);
            return reporteGastoMEsp;
        }
    }
}