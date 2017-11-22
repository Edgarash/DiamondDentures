using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using ConexionBaseDeDatos;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Entidad;
using Entidad.Reportes;
using static ConexionBaseDeDatos.InterfaceBaseDeDatos;

namespace Control
{
    public class ManejadorContabilidad : Manejador
    {
        private static string DarFormatoFecha(DateTime fecha)
        {
            return $"{fecha.Year}/{fecha.Month}/{fecha.Day}";
        }

        public static List<Pedidos> ConsultarPedido(DatosBusqueda datos)
        {
            CriterioBusqueda criterio = new CriterioBusqueda();

            if (datos.IntervaloActivado)
            {
                criterio.FechaA = DarFormatoFecha(datos.FechaA);
                criterio.FechaB = DarFormatoFecha(datos.FechaB);

                if ((datos.Id != -1) || (datos.NombreCliente != string.Empty))
                {
                    if ((datos.Id != -1) && (datos.NombreCliente != string.Empty))
                    {
                        criterio.Id = datos.Id;
                        criterio.NombreCliente = datos.NombreCliente;
                        criterio.Opcion = 7;
                    }
                    else if (datos.Id != -1)
                    {
                        criterio.Id = datos.Id;
                        criterio.Opcion = 5;
                    }
                    else if (datos.NombreCliente != string.Empty)
                    {
                        criterio.NombreCliente = datos.NombreCliente;
                        criterio.Opcion = 6;
                    }
                }
                else
                {
                    criterio.Opcion = 4;
                }
            }
            else
            {
                if ((datos.Id != -1) || (datos.NombreCliente != string.Empty))
                {
                    if ((datos.Id != -1) && (datos.NombreCliente != string.Empty))
                    {
                        criterio.Id = datos.Id;
                        criterio.NombreCliente = datos.NombreCliente;
                        criterio.Opcion = 3;
                    }
                    else if (datos.Id != -1)
                    {
                        criterio.Id = datos.Id;
                        criterio.Opcion = 1;
                    }
                    else if (datos.NombreCliente != string.Empty)
                    {
                        criterio.NombreCliente = datos.NombreCliente;
                        criterio.Opcion = 2;
                    }
                }
                else
                {
                    criterio.Opcion = 8;
                }
            }

            return BuscarPedido(criterio);
        }

        private static Factura ConsultarFacturaUnica(int facturaId)
        {
            return null;
        }

        public static List<Factura> ConsultarFactura()
        {
            CriterioBusqueda criterio = new CriterioBusqueda {Opcion = 8};
            return null;
        }

        public static void Facturar(Factura factura)
        {
            if (factura.ListaProductos != null)
            {
                decimal importe = factura.ListaProductos.Aggregate<Productos, decimal>(0,
                    (current, producto) => current + producto.PrecioProducto + producto.PrecioMat1 + producto.PrecioMat2);
                factura.Importe = importe;
            }
            GuardarFactura(factura);
        }

        public static int GenerarId()
        {
            Random r = new Random();
            List<int> ids = ObtenerIdFacturas();
            int numeroRandom;
            do
            {
                numeroRandom = r.Next(1, int.MaxValue);
            } while (ids.Contains(numeroRandom));
            return numeroRandom;
        }

        public static ReportDocument DefinirIntervaloFecha(string periodo, int año, DateTime fechaA,
            DateTime fechaB)
        {
            if (string.IsNullOrWhiteSpace(periodo)) { return null; }

            Fecha fecha1 = new Fecha();
            Fecha fecha2 = new Fecha();

            switch (periodo)
            {
                case "Anual":
                    fecha1.Dia = 1;
                    fecha1.Mes = 1;
                    fecha1.Año = año;
                    fecha2.Dia = 1;
                    fecha2.Mes = 1;
                    fecha2.Año = año + 1;
                    return ObtenerReporteFecha(fecha1.ObtenerFecha(), fecha2.ObtenerFecha());
                case "1er Semestral ":
                    fecha1.Dia = 1;
                    fecha1.Mes = 1;
                    fecha1.Año = año;
                    fecha2.Dia = 1;
                    fecha2.Mes = 6;
                    fecha2.Año = año;
                    return ObtenerReporteFecha(fecha1.ObtenerFecha(), fecha2.ObtenerFecha());
                case "2do Semestral ":
                    fecha1.Dia = 2;
                    fecha1.Mes = 6;
                    fecha1.Año = año;
                    fecha2.Dia = 1;
                    fecha2.Mes = 1;
                    fecha2.Año = año + 1;
                    return ObtenerReporteFecha(fecha1.ObtenerFecha(), fecha2.ObtenerFecha());
                case "1er Trimestral":
                    fecha1.Dia = 1;
                    fecha1.Mes = 1;
                    fecha1.Año = año;
                    fecha2.Dia = 1;
                    fecha2.Mes = 4;
                    fecha2.Año = año;
                    return ObtenerReporteFecha(fecha1.ObtenerFecha(), fecha2.ObtenerFecha());
                case "2er Trimestral":
                    fecha1.Dia = 2;
                    fecha1.Mes = 4;
                    fecha1.Año = año;
                    fecha2.Dia = 1;
                    fecha2.Mes = 7;
                    fecha2.Año = año;
                    return ObtenerReporteFecha(fecha1.ObtenerFecha(), fecha2.ObtenerFecha());
                case "3er Trimestral":
                    fecha1.Dia = 2;
                    fecha1.Mes = 7;
                    fecha1.Año = año;
                    fecha2.Dia = 1;
                    fecha2.Mes = 10;
                    fecha2.Año = año;
                    return ObtenerReporteFecha(fecha1.ObtenerFecha(), fecha2.ObtenerFecha());
                case "4er Trimestral":
                    fecha1.Dia = 1;
                    fecha1.Mes = 10;
                    fecha1.Año = año;
                    fecha2.Dia = 1;
                    fecha2.Mes = 1;
                    fecha2.Año = año + 1;
                    return ObtenerReporteFecha(fecha1.ObtenerFecha(), fecha2.ObtenerFecha());
                case "Personalizado":
                    fecha1.Dia = fechaA.Day;
                    fecha1.Mes = fechaA.Month;
                    fecha1.Año = fechaA.Year;
                    fecha2.Dia = fechaB.Day;
                    fecha2.Mes = fechaB.Month;
                    fecha2.Año = fechaB.Year;
                    return ObtenerReporteFecha(fecha1.ObtenerFecha(), fecha2.ObtenerFecha());
            }

            return null;
        }

        private static ReportDocument ObtenerReporteFecha(string fecha1, string fecha2)
        {
            ReportDocument reporte = new ReportDocument();
            reporte.Load($@"{Application.StartupPath}\ReporteVentas.rpt");

            reporte.DataDefinition.ParameterFields["f1"].CurrentValues.Clear();
            reporte.DataDefinition.ParameterFields["f1"].CurrentValues.Add(new ParameterDiscreteValue {Value = fecha1});
            reporte.DataDefinition.ParameterFields["f1"].ApplyCurrentValues(
                reporte.DataDefinition.ParameterFields["f1"].CurrentValues);

            reporte.DataDefinition.ParameterFields["f2"].CurrentValues.Clear();
            reporte.DataDefinition.ParameterFields["f2"].CurrentValues.Add(new ParameterDiscreteValue {Value = fecha2});
            reporte.DataDefinition.ParameterFields["f2"].ApplyCurrentValues(
                reporte.DataDefinition.ParameterFields["f2"].CurrentValues);

            return reporte;
        }

        public static ReportDocument ObtenerFacturaReporte(int facturaId)
        {
            Factura factura = ConsultarFacturaUnica(facturaId);

            ReportDocument reporte = new ReportDocument();
            reporte.Load($@"{Application.StartupPath}\FacturaReporte.rpt");

            reporte.DataDefinition.ParameterFields["fac"].CurrentValues.Clear();
            reporte.DataDefinition.ParameterFields["fac"].CurrentValues.Add(new ParameterDiscreteValue
            {Value = factura.Id});
            reporte.DataDefinition.ParameterFields["fac"].ApplyCurrentValues(
                reporte.DataDefinition.ParameterFields["fac"].CurrentValues);

            return reporte;
        }

        public static void ExportarReporte(string ruta, ReportDocument reporte)
        {
            reporte.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            reporte.ExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            reporte.ExportOptions.DestinationOptions = new DiskFileDestinationOptions {DiskFileName = ruta};
            reporte.ExportOptions.FormatOptions = new PdfRtfWordFormatOptions();
            reporte.Export();
        }

      

        public static ReportDocument GeneararNotaConfirmacion(string numeroPedido)
        {
            ReportDocument nota = new ReportDocument();
            nota.Load($@"{Application.StartupPath}\NotaConfirmacion.rpt");
            nota.DataDefinition.ParameterFields["clv"].CurrentValues.Clear();
            nota.DataDefinition.ParameterFields["clv"].CurrentValues.Add(new ParameterDiscreteValue{Value = numeroPedido});
            nota.DataDefinition.ParameterFields["clv"].ApplyCurrentValues(nota.DataDefinition.ParameterFields["clv"].CurrentValues);
            return nota;
        }

        public static List<Historial> ObtenerHistorial(int opcion)
        {
            return BuscarHistorial(opcion);
        }

        public static ReportDocument GenerarNotaTerminacion(string numeroPedido)
        {
            ReportDocument nota = new ReportDocument();
            nota.Load($@"{Application.StartupPath}\NotaTerminacion.rpt");
            nota.DataDefinition.ParameterFields["clv"].CurrentValues.Clear();
            nota.DataDefinition.ParameterFields["clv"].CurrentValues.Add(new ParameterDiscreteValue{Value = numeroPedido});
            nota.DataDefinition.ParameterFields["clv"].ApplyCurrentValues(nota.DataDefinition.ParameterFields["clv"].CurrentValues);
            return nota;
        }

        public static ReportDocument GenerarFormaPedido(string numeroPedido)
        {
            ReportDocument nota = new ReportDocument();
            nota.Load($@"{Application.StartupPath}\FormaPedido.rpt");
            nota.DataDefinition.ParameterFields["clv"].CurrentValues.Clear();
            nota.DataDefinition.ParameterFields["clv"].CurrentValues.Add(new ParameterDiscreteValue { Value = numeroPedido });
            nota.DataDefinition.ParameterFields["clv"].ApplyCurrentValues(nota.DataDefinition.ParameterFields["clv"].CurrentValues);
            return nota;
        }
    }
}