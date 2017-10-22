using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona : Datos
    {
        /// <summary>
        /// Nombre de la persona
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Apellidos de la persona
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Calle/Dirección de la persona
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Colonia donde vive
        /// </summary>
        public string Colonia { get; set; }

        /// <summary>
        /// Ciudad donde vive
        /// </summary>
        public string Ciudad { get; set; }

        /// <summary>
        /// Municipio donde vive
        /// </summary>
        public string Municipio { get; set; }

        /// <summary>
        /// Estado donde vive
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// País donde vive
        /// </summary>
        public string Pais { get; set; }

        /// <summary>
        /// Código postal donde vive
        /// </summary>
        public string CodPos { get; set; }

        /// <summary>
        /// Teléfono de oficina
        /// </summary>
        public string TelOficina { get; set; }

        /// <summary>
        /// Email de contacto
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Indica si el registro está activo o no
        /// </summary>
        public string Activo { get; set; }

        /// <summary>
        /// Regresa el nombre completo de la persona
        /// </summary>
        public string NombreCompleto { get { return Nombre + " " + Apellidos; } }
    }
}
