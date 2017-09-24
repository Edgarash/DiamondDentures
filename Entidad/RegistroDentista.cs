using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroDentista : Datos
    {
        public string Cedula { get; set; }
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string NumFrente { get; set; }
        public string CP { get; set; }
        public string Email { get; set; }

        public RegistroDentista(string Cedula, string RFC, string Nombre, string Apellidos, string Telefono, string Pais, string Estado,
            string Municipio, string Ciudad, string Colonia, string Calle, string NumFrente, string CP, string Email)
        {
            this.Cedula = Cedula;
            this.RFC = RFC;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Telefono = Telefono;
            this.Pais = Pais;
            this.Estado = Estado;
            this.Municipio = Municipio;
            this.Ciudad = Ciudad;
            this.Colonia = Colonia;
            this.Calle = Calle;
            this.NumFrente = NumFrente;
            this.CP = CP;
            this.Email = Email;
        }
    }
}
