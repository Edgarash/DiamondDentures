namespace Entidad
{
    /// <summary>
    /// Clase que representa la información del usuario
    /// </summary>
    public sealed class RegistroUsuario : Datos
    {
        #region Atributos
        /// <summary>
        /// Numero del trabajador
        /// </summary>
        private int _numeroTrabajador;

        /// <summary>
        /// Nombre del trabajador
        /// </summary>
        private string _Nombre;

        /// <summary>
        /// Apellidos del trabajador
        /// </summary>
        private string _Apellidos;

        /// <summary>
        /// Calle del domicilio trabajador
        /// </summary>
        private string _Calle;

        /// <summary>
        /// Número de casa del domicilio del trabajador
        /// </summary>
        private string _NumCasa;

        /// <summary>
        /// Colonia del domicilio del trabajador
        /// </summary>
        private string _Colonia;

        /// <summary>
        /// Ciudad donde reside el trabajador
        /// </summary>
        private string _Ciudad;

        /// <summary>
        /// País donde reside el trabajador
        /// </summary>
        private string _Pais;

        /// <summary>
        /// Código postal donde reside el trabajador
        /// </summary>
        private string _CodigoPostal;

        /// <summary>
        /// Email del trabajador
        /// </summary>
        private string _Email;

        /// <summary>
        /// Login o usuario del trabajador
        /// </summary>
        private string _Login;

        /// <summary>
        /// Contraseña del trabajador
        /// </summary>
        private string _Password;

        /// <summary>
        /// Estado donde reside el trabajador
        /// </summary>
        private string _Estado;

        /// <summary>
        /// Estado de la cuenta del trabajador
        /// (0) Inactivo, 
        /// (1) Activo
        /// </summary>
        private byte _Estatus;

        /// <summary>
        /// Tipo de usuario del trabajador, Empleado o Administrador
        /// </summary>
        private string _TipoUsuario;

        /// <summary>
        /// Número del teléfono de casa del trabajador
        /// </summary>
        private string _TelefonoCasa;

        /// <summary>
        /// Número del teléfono de la oficina del trabajador
        /// </summary>
        private string _TelefonoOficina;

        /// <summary>
        /// Número del teléfono celular del trabajador
        /// </summary>
        private string _TelefonoMovil;

        /// <summary>
        /// Municipio donde reside el trabajador
        /// </summary>
        private string _Municipio;

        private string _Pregunta;

        private string _Respuesta;

        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa una nueva instancia RegistroUsuario con valores por defecto
        /// </summary>
        public RegistroUsuario()
        {
            NumeroTrabajador = 0;
            Nombre = "";
            Apellidos = "";
            Calle = "";
            NumCasa = "";
            Colonia = "";
            Ciudad = "";
            Pais = "";
            CodigoPostal = "";
            Email = "";
            Login = "";
            Password = "";
            Estado = "";
            Estatus = 0;
            TipoUsuario = "";
            TelefonoCasa = "";
            TelefonoOficina = "";
            TelefonoMovil = "";
            Municipio = "";
        }

        /// <summary>
        /// Inicializa una nueva instancia RegistroUsuario con los datos especificados
        /// </summary>
        /// <param name="numeroTrabajador">Numero de trabajador dentro de la empresa</param>
        /// <param name="nombreTrabajador">Nombre del trabajador de la empresa</param>
        /// <param name="apellidosTrabajador">Apellidos del trabajador de la empresa</param>
        /// <param name="loginTrabajador">Login o usuario del trabajador de la empresa</param>
        /// <param name="passwordTrabajador">Password o contraseña del trabajador de la empresa</param>
        /// <param name="tipoTrabajador">Tipo de usuario o rango dentro de la empresa</param>
        /// <param name="paisTrabajador">País del trabajador</param>
        /// <param name="estadoTrabajador">Estado donde reside el trabajador</param>
        /// <param name="municipioTrabajador">Municipio donde reside el trabajador</param>
        /// <param name="ciudadTrabajador">Ciudad donde reside el trabajador</param>
        /// <param name="coloniaTrabajador">Colonia donde reside el trabajador</param>
        /// <param name="calleTrabajador">Calle donde reside el trabajador</param>
        /// <param name="numeroDeCasaTrabajador">Numero de casa donde reside el trabajador</param>
        /// <param name="codigoPostalTrabajador">Código Postal donde reside el trabajador</param>
        /// <param name="telefonoCasaTrabajador">Teléfono de casa del trabajador</param>
        /// <param name="telefonoCelularTrabajador">Teléfono celular del trabajador</param>
        /// <param name="telefonoOficinaTrabajador">Teléfono de oficina del trabajador</param>
        /// <param name="emailTrabajador">Email del trabajador</param>
        /// <param name="estatusCuenta">Estado de cuenta, activo o inactivo del trabajador</param>
        public RegistroUsuario(int numeroTrabajador, string nombreTrabajador, string apellidosTrabajador, string loginTrabajador,
            string passwordTrabajador, string tipoTrabajador, string paisTrabajador, string estadoTrabajador, string municipioTrabajador,
            string ciudadTrabajador, string coloniaTrabajador, string calleTrabajador, string numeroDeCasaTrabajador,  string codigoPostalTrabajador,
            string telefonoCasaTrabajador, string telefonoCelularTrabajador, string telefonoOficinaTrabajador, string emailTrabajador, string pregunta,
            string respuesta, byte estatusCuenta)
        {
            NumeroTrabajador = numeroTrabajador;
            Nombre = nombreTrabajador;
            Apellidos = apellidosTrabajador;
            Login = loginTrabajador;
            Password = passwordTrabajador;
            TipoUsuario = tipoTrabajador;
            Pais = paisTrabajador;
            Estado = estadoTrabajador;
            Municipio = municipioTrabajador;
            Ciudad = ciudadTrabajador;
            Colonia = coloniaTrabajador;
            Calle = calleTrabajador;
            NumCasa = numeroDeCasaTrabajador;
            CodigoPostal = codigoPostalTrabajador;
            TelefonoCasa = telefonoCasaTrabajador;
            TelefonoMovil = telefonoCelularTrabajador;
            TelefonoOficina = telefonoOficinaTrabajador;
            Email = emailTrabajador;
            Pregunta = pregunta;
            Respuesta = respuesta;
            Estatus = estatusCuenta;
        }
        #endregion

        #region Modificadores
        /// <summary>
        /// Numero del trabajador
        /// </summary>
        public int NumeroTrabajador
        {
            get
            {
                return _numeroTrabajador;
            }

            set
            {
                _numeroTrabajador = value;
            }
        }
        /// <summary>
        /// Nombre del trabajador
        /// </summary>
        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }
        /// <summary>
        /// Apellidos del trabajador
        /// </summary>
        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
            }
        }
        /// <summary>
        /// Calle del domicilio trabajador
        /// </summary>
        public string Calle
        {
            get
            {
                return _Calle;
            }

            set
            {
                _Calle = value;
            }
        }
        /// <summary>
        /// Número de casa del domicilio del trabajador
        /// </summary>
        public string NumCasa
        {
            get
            {
                return _NumCasa;
            }

            set
            {
                _NumCasa = value;
            }
        }
        /// <summary>
        /// Colonia del domicilio del trabajador
        /// </summary>
        public string Colonia
        {
            get
            {
                return _Colonia;
            }

            set
            {
                _Colonia = value;
            }
        }
        /// <summary>
        /// Ciudad donde reside el trabajador
        /// </summary>
        public string Ciudad
        {
            get
            {
                return _Ciudad;
            }

            set
            {
                _Ciudad = value;
            }
        }
        /// <summary>
        /// País donde reside el trabajador
        /// </summary>
        public string Pais
        {
            get
            {
                return _Pais;
            }

            set
            {
                _Pais = value;
            }
        }
        /// <summary>
        /// Código postal donde reside el trabajador
        /// </summary>
        public string CodigoPostal
        {
            get
            {
                return _CodigoPostal;
            }

            set
            {
                _CodigoPostal = value;
            }
        }
        /// <summary>
        /// Email del trabajador
        /// </summary>
        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }
        /// <summary>
        /// Login o usuario del trabajador
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
        /// Contraseña del trabajador
        /// </summary>
        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }
        /// <summary>
        /// Estado donde reside el trabajador
        /// </summary>
        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }
        /// <summary>
        /// Estado de la cuenta del trabajador
        /// (0) Inactivo, 
        /// (1) Activo
        /// </summary>
        public byte Estatus
        {
            get
            {
                return _Estatus;
            }

            set
            {
                _Estatus = value;
            }
        }
        /// <summary>
        /// Tipo de usuario del trabajador, Empleado o Administrador
        /// </summary>
        public string TipoUsuario
        {
            get
            {
                return _TipoUsuario;
            }

            set
            {
                _TipoUsuario = value;
            }
        }
        /// <summary>
        /// Número del teléfono de casa del trabajador
        /// </summary>
        public string TelefonoCasa
        {
            get
            {
                return _TelefonoCasa;
            }

            set
            {
                _TelefonoCasa = value;
            }
        }
        /// <summary>
        /// Número del teléfono de la oficina del trabajador
        /// </summary>
        public string TelefonoOficina
        {
            get
            {
                return _TelefonoOficina;
            }

            set
            {
                _TelefonoOficina = value;
            }
        }
        /// <summary>
        /// Número del teléfono celular del trabajador
        /// </summary>
        public string TelefonoMovil
        {
            get
            {
                return _TelefonoMovil;
            }

            set
            {
                _TelefonoMovil = value;
            }
        }
        /// <summary>
        /// Municipio donde reside el trabajador
        /// </summary>
        public string Municipio
        {
            get
            {
                return _Municipio;
            }

            set
            {
                _Municipio = value;
            }
        }
        
        /// <summary>
        /// Indica si el usuario actual está activo
        /// </summary>
        public bool UsuarioActivo
        {
            get
            {
                return Estatus == 1;
            }
        }

        public string Pregunta
        {
            get
            {
                return _Pregunta;
            }

            set
            {
                _Pregunta = value;
            }
        }

        public string Respuesta
        {
            get
            {
                return _Respuesta;
            }

            set
            {
                _Respuesta = value;
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método que verifica si la contraseña introducida es la misma que la del Usuario
        /// </summary>
        /// <param name="Contraseña">Contraseña a verificar</param>
        /// <returns>Verdadero si la contraseña es la misma, Falso en caso contrario</returns>
        public bool ValidarContraseña(string Contraseña)
        {
            return Password == Contraseña;
        }
        #endregion
    }
}