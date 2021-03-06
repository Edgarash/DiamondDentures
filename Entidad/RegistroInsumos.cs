﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroInsumos : Datos
    {
        public int IDInsumos { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float PrecioBase { get; set; }
        public float PrecioCompra { get; set; }
        public int IDProveedor { get { return Proveedor.IDProveedor; } }
        public RegistroProveedor Proveedor { get; set; }
        public string UnidadMedida { get; set; }
        public int Cantidad { get; set; }
        public int CantidadEnviada { get; set; }

        public RegistroInsumos(int IDMaterial, RegistroProveedor Proveedor, string Nombre, string Descripcion, float PrecioBase, float PrecioCompra,
           string UnidadMedida, int Cantidad, int CantidadEnviada)
        {
            this.IDInsumos = IDMaterial;
            this.Proveedor = Proveedor;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.PrecioBase = PrecioBase;
            this.PrecioCompra = PrecioCompra;
            this.UnidadMedida = UnidadMedida;
            this.Cantidad = Cantidad;
            this.CantidadEnviada = CantidadEnviada;
        }
    }
}
