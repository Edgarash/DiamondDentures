using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Entidad;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ConexionBaseDeDatos;
using Entidad.Reportes;
using System.Windows.Forms;

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
                if (parametro.EsSubreporte)
                {
                    reporte.SetParameterValue(parametro.Nombre, parametro.Valor, parametro.Subreporte);
                }
                else
                {
                    reporte.SetParameterValue(parametro.Nombre, parametro.Valor);
                }
            }
            return reporte;
        }

        public static T CargarReportePersonalizado<T>(T reporte, Dictionary<string, ParametroReporte> estadoColumnas) where T : ReportClass
        {
            foreach (KeyValuePair<string, ParametroReporte> parametroReporte in estadoColumnas)
            {
                reporte.SetParameterValue(parametroReporte.Value.Nombre, parametroReporte.Value.Valor);
            }
            return reporte;
        }

        public static void GuardarDatos(string procedimiento, Dictionary<string, object> informacion) => InterfaceMySQL.rGuardarDatos(procedimiento, informacion);

        public static DataTable CargarDatos(string procedimiento, Dictionary<string, object> parametros)
            => InterfaceMySQL.rRecuperarDatos(procedimiento, parametros);

        public static int[] RecuperarIdFacturas()
        {
            int[] recuperarIdFacturas =
                InterfaceMySQL.rRecuperarDatos("R_ObtenerIdFactura")
                              .Select()
                              .Select(row => row.ItemArray.Cast<int>())
                              .Aggregate(new List<int>(), (current, ints) => current.Concat(ints).ToList())
                              .ToArray();

            return recuperarIdFacturas;
        }

        public static DataTable RecuperarFacturas(Dictionary<string, object> parametros)
        {
            return InterfaceMySQL.rRecuperarDatos("R_BuscarFactura", parametros);
        }

        public static void CancelarFactura(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                {"nfac", id}
            };
            InterfaceMySQL.rGuardarDatos("R_CancelarFactura", parametros);
        }

        public static void EnviarCorreo(Correo correo)
        {
            SmtpClient smtpServer = new SmtpClient(InformacionEmpresarial.Smtp)
            {
                Port = 587,
                Credentials = new NetworkCredential(InformacionEmpresarial.Correo, InformacionEmpresarial.Contraseña),
                EnableSsl = InformacionEmpresarial.SSL
            };

            MailMessage mail = new MailMessage
            {
                From = new MailAddress(InformacionEmpresarial.Correo),
                Subject = correo.Asunto,
                Body = correo.Mensaje
            };

            mail.To.Add(correo.Destinatario);

            foreach (string cc in correo.Cc)
            {
                mail.CC.Add(cc);
            }

            if (!string.IsNullOrWhiteSpace(correo.ArchivoAdjunto))
            {
                mail.Attachments.Add(new Attachment(correo.ArchivoAdjunto));
            }

            try
            {
                smtpServer.Send(mail);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void MostrarPantalla<T>(T Pantalla) where T : Form
        {
            Pantalla.ShowDialog();
            Pantalla.Close();
        }

        public static void MostrarPantalla<V, T>(V Parent, T Pantalla) where T : Form where V : Form
        {
            Parent.Hide();
            Pantalla.ShowDialog();
            Pantalla.Close();
            Parent.Show();
            Parent.BringToFront();
        }
    }
}
