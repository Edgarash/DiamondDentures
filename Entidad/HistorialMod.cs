using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class HistorialMod : Datos
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int CantidadReal { get; set; }
        public int Faltantes { get; set; }
        public DateTime Fecha { get; set; }

        public HistorialMod(int Id, int Cantidad, int CantidadReal, int Faltantes, DateTime Fecha)
        {
            this.Id = Id;
            this.Cantidad = Cantidad;
            this.CantidadReal = CantidadReal;
            this.Faltantes = Faltantes;
            this.Fecha = Fecha;
        }

        public HistorialMod(int Id, int Cantidad, int CantidadReal)
        {
            this.Id = Id;
            this.Cantidad = Cantidad;
            this.CantidadReal = CantidadReal;
        }
    }
}
