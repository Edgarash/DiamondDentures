namespace Entidad
{
    /// <summary>
    /// Clase que representa la información de la tarjeta de un trabajador
    /// </summary>
    public sealed class RegistroTarjeta : Datos
    {
        #region Atributos
        /// <summary>
        /// Login del usuario en el que se registra la tarjeta
        /// </summary>
        private string _Login;
        /// <summary>
        /// Nombre del titular de la tarjeta
        /// </summary>
        private string _NombreTitular;
        /// <summary>
        /// Apellidos del titular de la tarjeta
        /// </summary>
        private string _ApellidosTitular;
        /// <summary>
        /// Número de la tarjeta
        /// </summary>
        private string _NumeroTarjeta;
        /// <summary>
        /// Banco de la tarjeta
        /// </summary>
        private string _Banco;
        /// <summary>
        /// Fecha de vencimiento de la tarjeta
        /// </summary>
        private string _FechaVencimiento;
        /// <summary>
        /// Estado Activo o Inactivo de la tarjeta
        /// </summary>
        private string _Activo;
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa una nueva instancia de RegistroTarjeta con valores por defecto
        /// </summary>
        public RegistroTarjeta()
        {
            Login = "";
            NombreTitular = "";
            ApellidosTitular = "";
            NumeroTarjeta = "";
            Banco = "";
            FechaVencimiento = "";
            Activo = "";
        }
        /// <summary>
        /// Inicializa una nueva instancia de RegistroTarjeta con los valores especificados
        /// </summary>
        /// <param name="login">Login o usuario al que se le registrará la tarjeta</param>
        /// <param name="numTarjeta">Número que viene en el frente de la tarjeta</param>
        /// <param name="nombre">Nombre del titular de la tarjeta</param>
        /// <param name="apellidos">Apellidos del titular de la tarjeta</param>
        /// <param name="banco">Banco de donde proviene la tarjeta</param>
        /// <param name="fechaVencimiento">Fecha en la que vence la tarjeta</param>
        /// <param name="activo">Estado activo de la tarjeta</param>
        public RegistroTarjeta(string login, string numTarjeta, string nombre, string apellidos, string banco, string fechaVencimiento, string activo)
        {
            Login = login;
            NumeroTarjeta = numTarjeta;
            NombreTitular = nombre;
            ApellidosTitular = apellidos;
            Banco = banco;
            FechaVencimiento = fechaVencimiento;
            Activo = activo;
        }
        #endregion

        #region Modificadores De Acceso
        /// <summary>
        /// Login del usuario en el que se registra la tarjeta
        /// </summary>
        public string Login
        {
            get
            {
                return _Login;
            }

            set
            {
                _Login = value;
            }
        }

        /// <summary>
        /// Nombre del titular de la tarjeta
        /// </summary>
        public string NombreTitular
        {
            get
            {
                return _NombreTitular;
            }

            set
            {
                _NombreTitular = value;
            }
        }

        /// <summary>
        /// Apellidos del titular de la tarjeta
        /// </summary>
        public string ApellidosTitular
        {
            get
            {
                return _ApellidosTitular;
            }

            set
            {
                _ApellidosTitular = value;
            }
        }

        /// <summary>
        /// Número de la tarjeta
        /// </summary>
        public string NumeroTarjeta
        {
            get
            {
                return _NumeroTarjeta;
            }

            set
            {
                _NumeroTarjeta = value;
            }
        }

        /// <summary>
        /// Banco de la tarjeta
        /// </summary>
        public string Banco
        {
            get
            {
                return _Banco;
            }

            set
            {
                _Banco = value;
            }
        }
        
        /// <summary>
        /// Fecha de vencimiento de la tarjeta
        /// </summary>
        public string FechaVencimiento
        {
            get
            {
                return _FechaVencimiento;
            }

            set
            {
                _FechaVencimiento = value;
            }
        }

        /// <summary>
        /// Estado Activo o Inactivo de la tarjeta
        /// </summary>
        public string Activo
        {
            get
            {
                return _Activo;
            }

            set
            {
                _Activo = value;
            }
        }
        #endregion
    }
}
