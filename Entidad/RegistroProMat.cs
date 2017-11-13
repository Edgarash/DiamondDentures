using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroProMat : Datos
    {
        public int ClavePro { get; set; }
        public int ClaveMat { get; set; }
        public int Activo { get; set; }
        public string Producto { get; set; }
        public string Material { get; set; }
        public float Precio { get; set; }

        public RegistroProMat(int ClavePro, int ClaveMat, float Precio, int Valido)
        {
            this.ClaveMat = ClaveMat;
            this.ClavePro = ClavePro;
            this.Precio = Precio;
            this.Activo = Valido;
        }

        public RegistroProMat(int ClaveMat, string Material, int ClavePro, string Producto, float Precio, int Valido):this(ClavePro, ClaveMat, Precio, Valido)
        {
            this.Producto = Producto;
            this.Material = Material;
        }
    }
}
