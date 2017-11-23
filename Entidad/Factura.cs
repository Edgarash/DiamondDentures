using System;
using System.Collections.Generic;

namespace Entidad
{
    public class Factura : Datos
    {
        public string CalleC;
        public string CalleE;
        public string CiudadC;
        public string CiudadE;
        public string ColoniaC;
        public string ColoniaE;
        public string CorreoC;
        public string CorreoE;
        public string CpC;
        public string CpE;
        public string EstadoC;
        public string EstadoE;
        public int Estatus;
        public int Id;
        public DateTime Fecha;
        public decimal Importe;
        public List<Productos> ListaProductos;
        public string NombreC;
        public string NombreE;
        public string NumCasaE;
        public string PaisC;
        public string PaisE;
        public string Pedidos;
        public string RfcC;
        public string RfcE;
        public string TelefonoC;
        public string TelefonoE;
        public string IdPedido;
    }
}