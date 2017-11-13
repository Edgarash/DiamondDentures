using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroProducto : Datos
    {
        public int Clave { get; set; }

        public string Nombre { get; set; }

        public int Dias { get; set; }

        public float Precio { get; set; }

        public int Activo { get; set; }

        public RegistroProducto(int Clave, string Nombre, int Dias, float Precio, int Activo)
        {
            this.Clave = Clave;
            this.Nombre = Nombre;
            this.Dias = Dias;
            this.Precio = Precio;
            this.Activo = Activo;
        }
    }
}
