using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroProMat : Datos
    {
        public RegistroProducto Producto { get; set; }
        public RegistroMaterial Material { get; set; }
        public float PrecioFinal { get; set; }
        public int TiempoFinal { get; set; }
        public bool Activo { get; set; }

        public RegistroProMat(RegistroProducto Producto, RegistroMaterial Material,
            float PrecioFinal, int TiempoFinal, bool Activo)
        {
            this.Producto = Producto;
            this.Material = Material;
            this.PrecioFinal = PrecioFinal;
            this.TiempoFinal = TiempoFinal;
            this.Activo = Activo;
        }

        public RegistroProMat(int Producto, int Material, float PrecioFinal,
            int TiempoFinal, bool Activo) :
            this(new RegistroProducto(Producto), new RegistroMaterial(Material), PrecioFinal, TiempoFinal, Activo)
        { }
    }
}
