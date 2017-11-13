using System.Collections.Generic;

namespace Entidad.Reportes
{
    public class Correo
    {
        public string Destinatario;
        public string Mensaje;
        public string Asunto;
        public List<string> Cc;
        public string ArchivoAdjunto;

        public Correo(string destinatario, string mensaje, string asunto, List<string> cc, string archivoAdjunto)
        {
            Destinatario = destinatario;
            Mensaje = mensaje;
            Asunto = asunto;
            Cc = cc;
            ArchivoAdjunto = archivoAdjunto;
        }
    }
}