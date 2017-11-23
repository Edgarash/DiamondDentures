using System;

namespace Entidad
{
    /// <summary>
    /// Clase que representa la información del usuario
    /// </summary>
    public sealed class RegistroUsuario : Persona
    {
        #region Atributos

        /// <summary>
        /// Número de económico en la empresa
        /// </summary>
        public int NumeroTrabajador { get; set; }

        /// <summary>
        /// Login del trabajador
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Contraseña de su usuario
        /// </summary>
        public string Password { get; set; }
        
        /// <summary>
        /// Número de casa donde vive
        /// </summary>
        public string NumCasa { get; set; }
        
        /// <summary>
        /// Teléfono de casa
        /// </summary>
        public string TelCasa { get; set; }

        /// <summary>
        /// Teléfono celular personal
        /// </summary>
        public string TelCel { get; set; }
        
        /// <summary>
        /// Pregunta de seguridad
        /// </summary>
        public string Pregunta { get; set; }

        /// <summary>
        /// Respuesta a la pregunta de seguridad
        /// </summary>
        public string Respuesta { get; set; }

        /// <summary>
        /// Departamento donde trabaja
        /// </summary>
        public string Departamento { get; set; }

        /// <summary>
        /// Puesto que desempeña en la empresa
        /// </summary>
        public string Puesto { get; set; }

        /// <summary>
        /// Fecha en la que empezó a trabajar en la empresa
        /// </summary>
        public DateTime FechaIngreso { get; set; }

        /// <summary>
        /// Edad del empleado
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Sueldo diario del empleado
        /// </summary>
        public float SueldoDiario { get; set; }

        /// <summary>
        /// Sueldo cada 15 dias
        /// </summary>
        public float Sueldo15Dias { get { return SueldoDiario * 15; } }

        /// <summary>
        /// Sueldo al mes
        /// </summary>
        public float SueldoMensual { get { return SueldoMensual * 30; } }

        /// <summary>
        /// Fecha de nacimiento con Formato para MySQL
        /// </summary>
        public string FechaNacimiento_ { get { return ObtenerFecha(FechaNacimiento); } }

        /// <summary>
        /// Fecha de ingreso con Formato para MySQL
        /// </summary>
        public string FechaIngreso_ { get { return ObtenerFecha(FechaIngreso); } }

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
            Direccion = "";
            NumCasa = "";
            Colonia = "";
            Ciudad = "";
            Pais = "";
            CodPos = "";
            Email = "";
            Login = "";
            Password = "";
            Estado = "";
            Activo = "0";
            Departamento = "";
            Puesto = "";
            TelCasa = "";
            TelOficina = "";
            TelCel = "";
            Municipio = "";
            FechaIngreso = FechaNacimiento = new DateTime();
            SueldoDiario = 0;
        }

        /// <summary>
        /// Inicializa una nueva instancia de RegistroUsuario con los datos especificados.
        /// </summary>
        /// <param name="numTrabajador">Numero de trabajador dentro de la empresa</param>
        /// <param name="loginTrabajador">Login o usuario del trabajador de la empresa</param>
        /// <param name="passwordTrabajador">Password o contraseña del trabajador de la empresa</param>
        /// <param name="nombreTrabajador">Nombre del trabajador de la empresa</param>
        /// <param name="apellidosTrabajador">Apellidos del trabajador de la empresa</param>
        /// <param name="fechaNacTrabajador">Fecha de nacimiento del trabajador</param>
        /// <param name="numCasaTrabajador">Numero de casa donde reside el trabajador</param>
        /// <param name="direccionTrabajador">Calle/Dirección donde reside el trabajador</param>
        /// <param name="coloniaTrabajador">Colonia donde reside el trabajador</param>
        /// <param name="ciudadTrabajador">Ciudad donde reside el trabajador</param>
        /// <param name="municipioTrabajador">Municipio donde reside el trabajador</param>
        /// <param name="estadoTrabajador">Estado donde reside el trabajador</param>
        /// <param name="paisTrabajador">País del trabajador</param>
        /// <param name="codPosTrabajador">Código Postal donde reside el trabajador</param>
        /// <param name="telCasaTrabajador">Teléfono de casa del trabajador</param>
        /// <param name="telOficinaTrabajador">Teléfono de oficina del trabajador</param>
        /// <param name="telCelularTrabajador">Teléfono celular del trabajador</param>
        /// <param name="emailTrabajador">Email del trabajador</param>
        /// <param name="preguntaTrabajador">Pregunta de seguridad</param>
        /// <param name="respuestaTrabajador">Respuesta a la pregunta de seguridad</param>
        /// <param name="activoTrabajador">Estado de cuenta, activo o inactivo del trabajador</param>
        /// <param name="departamentoTrabajador">Departamento dentro de la empresa</param>
        /// <param name="puestoTrabajador">Puesto del trabajador</param>
        /// <param name="fechaIngresoTrabajador">Fecha de ingreso a la empresa</param>
        /// <param name="sueldodiarioTrabajador">Sueldo diario del trabajador</param>
        public RegistroUsuario(int numTrabajador, string loginTrabajador, string passwordTrabajador,
            string nombreTrabajador, string apellidosTrabajador, DateTime fechaNacTrabajador, string numCasaTrabajador,
            string direccionTrabajador, string coloniaTrabajador, string ciudadTrabajador, string municipioTrabajador,
            string estadoTrabajador, string paisTrabajador, string codPosTrabajador, string telCasaTrabajador,
            string telOficinaTrabajador, string telCelularTrabajador, string emailTrabajador, string preguntaTrabajador,
            string respuestaTrabajador, string activoTrabajador, string departamentoTrabajador, string puestoTrabajador, 
            DateTime fechaIngresoTrabajador, float sueldodiarioTrabajador)
        {
            NumeroTrabajador = numTrabajador;
            Login = loginTrabajador.ToUpper();
            Password = passwordTrabajador;
            Nombre = nombreTrabajador.ToUpper();
            Apellidos = apellidosTrabajador.ToUpper();
            FechaNacimiento = fechaNacTrabajador;
            NumCasa = numCasaTrabajador;
            Direccion = direccionTrabajador.ToUpper();
            Colonia = coloniaTrabajador.ToUpper();
            Ciudad = ciudadTrabajador.ToUpper();
            Municipio = municipioTrabajador.ToUpper();
            Estado = estadoTrabajador.ToUpper();
            Pais = paisTrabajador.ToUpper();
            CodPos = codPosTrabajador.ToUpper();
            TelCasa = telCasaTrabajador;
            TelOficina = telOficinaTrabajador;
            TelCel = telCelularTrabajador;
            Email = emailTrabajador.ToUpper();
            Pregunta = preguntaTrabajador.ToUpper();
            Respuesta = respuestaTrabajador.ToUpper();
            Activo = activoTrabajador;
            Departamento = departamentoTrabajador.ToUpper();
            FechaIngreso = fechaIngresoTrabajador;
            Puesto = puestoTrabajador.ToUpper();
            SueldoDiario = sueldodiarioTrabajador;
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