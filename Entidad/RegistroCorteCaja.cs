using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroCorteCaja
    {
        public int FolioCorte { get; set; }
        public DateTime Fecha { get; set; }
        public string Empleado { get { return Registra.Login; } }
        public RegistroUsuario Registra { get; set; }
        public float FondoCaja { get; set; }
        public float EntradaEfectivo { get; set; }
        public float EntradaCheque { get; set; }
        public float EntradaTarjeta { get; set; }
        public float Total { get { return EntradaCheque + EntradaEfectivo + EntradaTarjeta; } }
        public int NumVentas { get; set; }
        public float DineroCaja { get; set; }
        public RegistroUsuario Autoriza { get; set; }
        public string Autorizo { get { return Autoriza.Login; } }
        public string Comentario { get; set; }

        public RegistroCorteCaja(int FolioCorte, DateTime Fecha, RegistroUsuario Registra, float FondoCaja,
            float Efectivo, float Cheque, float Tarjeta, float DineroCaja, int NumVentas, RegistroUsuario Autoriza,
            string Comentario)
        {
            this.FolioCorte = FolioCorte;
            this.Fecha = Fecha;
            this.Registra = Registra;
            this.FondoCaja = FondoCaja;
            this.EntradaEfectivo = Efectivo;
            this.EntradaCheque = Cheque;
            this.EntradaTarjeta = Tarjeta;
            this.DineroCaja = DineroCaja;
            this.NumVentas = NumVentas;
            this.Autoriza = Autoriza;
            this.Comentario = Comentario;
        }
    }
}

