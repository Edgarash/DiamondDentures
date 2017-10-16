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
            string Municipio, string Ciudad, string Colonia, string Calle, string CP, string Email, string Activo, string Consultorio, DateTime FechaAlta)
        {
            this.Cedula = Cedula;
            this.RFC = RFC;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            Direccion = Calle;
            this.Colonia = Colonia;
            this.Ciudad = Ciudad;
            this.Municipio = Municipio;
            this.Estado = Estado;
            this.Pais = Pais;
            CodPos = CP;
            this.TelOficina = Telefono;
            this.Email = Email;
            this.Activo = Activo;
            this.Consultorio = Consultorio;
            this.FechaAlta = FechaAlta;
        }
    }
}
