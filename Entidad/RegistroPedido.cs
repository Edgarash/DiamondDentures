using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroPedido : Datos
    {
        public string Clave { get; set; }
        public string Usuario { get; set; }
        public string Fecha { get; set; }
        public string Cedula { get; set; }
        public string RFC { get; set; }
        public string NombreDentista { get; set; }
        public string ApellidosDentista { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string NumeroFrente { get; set; }
        public string CP { get; set; }
        public string Email { get; set; }
        public string FechaEntrega { get; set; }
        public int Estatus { get; set; }
        public string Asignado { get; set; }
        public int Urgente { get; set; }
        public RegistroTrabajo[] Trabajos { get; set; }
        public bool Inicializado { get; set; }

        /// <summary>
        /// Constructor por defecto de un pedido
        /// </summary>
        /// <param name="Clave">Clave del pedido</param>
        /// <param name="Usuario">Usuario que registra el pedido</param>
        /// <param name="Fecha">Fecha en que se realiza el pedido</param>
        /// <param name="Cedula">Cédula del dentista que hace el pedido</param>
        /// <param name="RFC">RFC del dentista</param>
        /// <param name="Nombre">Nombre del dentista</param>
        /// <param name="Apellidos">Apellidos del dentista</param>
        /// <param name="Telefono">Teléfono del dentista</param>
        /// <param name="Pais">País del dentista</param>
        /// <param name="Estado">Estado del dentista</param>
        /// <param name="Municipio">Municipio del dentista</param>
        /// <param name="Ciudad">Ciudad del dentista</param>
        /// <param name="Colonia">Colonia del dentista</param>
        /// <param name="Calle">Calle del dentista</param>
        /// <param name="NumeroFrente">Número del local del dentista</param>
        /// <param name="CP">Código postal del dentista</param>
        /// <param name="Email">Email del dentista</param>
        /// <param name="FechaEntrega">Fecha probable de entrega del pedido</param>
        /// <param name="Urgente">Urgencia del pedido a realizar</param>
        /// <param name="Asignado">Trabajador al cuál le fue asignado el pedido</param>
        public RegistroPedido(string Clave, string Usuario, string Fecha, string Cedula, string RFC, string Nombre, string Apellidos,
            string Telefono, string Pais, string Estado, string Municipio, string Ciudad, string Colonia, string Calle,
            string NumeroFrente, string CP , string Email, string FechaEntrega, int Urgente, string Asignado)
        {
            this.Clave = Clave;
            this.Usuario = Usuario;
            this.Fecha = Fecha;
            this.Cedula = Cedula;
            this.RFC = RFC;
            this.NombreDentista = Nombre;
            this.ApellidosDentista = Apellidos;
            this.Telefono = Telefono;
            this.Pais = Pais;
            this.Estado = Estado;
            this.Municipio = Municipio;
            this.Ciudad = Ciudad;
            this.Colonia = Colonia;
            this.Calle = Calle;
            this.NumeroFrente = NumeroFrente;
            this.CP = CP;
            this.Email = Email;
            this.FechaEntrega = FechaEntrega;
            this.Estatus = 1;
            this.Asignado = Asignado;
            this.Urgente = Urgente;
            this.Inicializado = false;
        }

        public void setTrabajos(RegistroTrabajo[] Registro)
        {
            this.Trabajos = Registro;
            this.Inicializado = true;
        }
    }
}
