using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroDentista : Persona
    {

        public string Cedula { get; set; }
        public string RFC { get; set; }

        public string Consultorio { get; set; }
        public DateTime FechaAlta { get; set; }

        public RegistroDentista(string Cedula, string RFC, string Nombre, string Apellidos, string Telefono, string Pais, string Estado,
            string Municipio, string Ciudad, string Colonia, string Calle, string NumFrente, string CP, string Email)
        {
            this.Cedula = Cedula;
            this.RFC = RFC;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.TelOficina = Telefono;
            this.Pais = Pais;
            this.Estado = Estado;
            this.Municipio = Municipio;
            this.Ciudad = Ciudad;
            this.Colonia = Colonia;
            this.Direccion = Calle;
            this.CodPos = CP;
            this.Email = Email;
        }
    }
}
