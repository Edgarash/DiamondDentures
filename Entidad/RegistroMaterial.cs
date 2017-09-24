using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroMaterial : Datos
    {
        public string Nombre { get; set; }
        public int Activo { get; set; }
        public float Precio { get; set; }
        public int Clave { get; set; }

        public RegistroMaterial(int Clave, string Nombre, float Precio, int Activo)
        {
            this.Clave = Clave;
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Activo = Activo;
        }
    }
}
