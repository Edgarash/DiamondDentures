namespace Entidad
{
    public class RegistroProveedor
    {
        public int IDProveedor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public string Banco { get; set; }
        public string NumeroCuenta { get; set; }

        public RegistroProveedor(int IDProveedor, string Nombre, string Telefono, string Correo,
            string Direccion, string Descripcion):this(IDProveedor)
        {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Correo = Correo;
            this.Direccion = Direccion;
            this.Descripcion = Descripcion;
        }

        public RegistroProveedor(int IDProveedor, string Nombre, string Telefono, string Correo,
            string Direccion, string Descripcion, string Banco, string NumeroCuenta):this
                (IDProveedor, Nombre, Telefono, Correo, Direccion, Descripcion)
        {
            this.Banco = Banco;
            this.NumeroCuenta = NumeroCuenta;
        }

        public RegistroProveedor(int IDProveedor)
        {
            this.IDProveedor = IDProveedor;
        }
    }
}