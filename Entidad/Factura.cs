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
        public string NumCasaC;
        public string NumCasaE;
        public string PaisC;
        public string PaisE;
        public string Pedidos;
        public string RfcC;
        public string RfcE;
        public string TelefonoC;
        public string TelefonoE;
  


        public Factura(string calleC, string calleE, string ciudadC, string ciudadE, string coloniaC, string coloniaE, string correoC, string correoE, string cpC, string cpE, string estadoC, string estadoE, int estatus, int id, DateTime fecha, decimal importe, List<Productos> listaProductos, string nombreC, string nombreE, string numCasaC, string numCasaE, string paisC, string paisE, string pedidos, string rfcC, string rfcE, string telefonoC, string telefonoE)
        {
            CalleC = calleC;
            CalleE = calleE;
            CiudadC = ciudadC;
            CiudadE = ciudadE;
            ColoniaC = coloniaC;
            ColoniaE = coloniaE;
            CorreoC = correoC;
            CorreoE = correoE;
            CpC = cpC;
            CpE = cpE;
            EstadoC = estadoC;
            EstadoE = estadoE;
            Estatus = estatus;
            Id = id;
            Fecha = fecha;
            Importe = importe;
            ListaProductos = listaProductos;
            NombreC = nombreC;
            NombreE = nombreE;
            NumCasaC = numCasaC;
            NumCasaE = numCasaE;
            PaisC = paisC;
            PaisE = paisE;
            Pedidos = pedidos;
            RfcC = rfcC;
            RfcE = rfcE;
            TelefonoC = telefonoC;
            TelefonoE = telefonoE;
        }

        public Factura(string calleC, string ciudadC, string coloniaC, string correoC, string cpC, string estadoC, int estatus, DateTime fecha, decimal importe, string nombreC, string numCasaC, string paisC, string pedidos, string rfcC, string telefonoC)
        {
            CalleC = calleC;
            CiudadC = ciudadC;
            ColoniaC = coloniaC;
            CorreoC = correoC;
            CpC = cpC;
            EstadoC = estadoC;
            Estatus = estatus;
            Fecha = fecha;
            Importe = importe;
            NombreC = nombreC;
            NumCasaC = numCasaC;
            PaisC = paisC;
            Pedidos = pedidos;
            RfcC = rfcC;
            TelefonoC = telefonoC;
        }
    }
}