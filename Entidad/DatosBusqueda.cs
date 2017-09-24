using System;

namespace Entidad
{
    public class DatosBusqueda : Datos
    {
        public DateTime FechaA;
        public DateTime FechaB;
        public int Id;
        public bool IntervaloActivado;
        public string NombreCliente;

        public DatosBusqueda(DateTime fechaA, DateTime fechaB, int id, bool intervaloActivado, string nombreCliente)
        {
            FechaA = fechaA;
            FechaB = fechaB;
            Id = id;
            IntervaloActivado = intervaloActivado;
            NombreCliente = nombreCliente;
        }
    }
}