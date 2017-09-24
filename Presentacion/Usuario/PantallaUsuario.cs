using Control;
using ControlesPersonalizados;
using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Validaciones;

namespace Presentacion.Usuario
{
    class PantallaUsuario : Pantalla
    {
        protected InterfaceUsuario Interface;

        protected Validar Validaciones;
        protected ErrorProvider Error;
        protected ErrorProvider[] ErrorText;
        protected ErrorProvider[] ErrorMasked;
        protected ErrorProvider[] ErrorCombo;
        protected ErrorProvider ErrorPass;
        protected Label lblPantallaUsuario;
        private Label lblInfo;
        protected Password tbPassword;
        private Label lblNombre;
        private Label lblApellido;
        protected TextBox tbNombre;
        protected TextBox tbApellidos;
        private Label lblUsuario;
        protected TextBox tbUsuario;
        private Label lblContraseña;
        private Label lblEmpleado;
        protected TextBox tbNEmpleado;
        private PictureBox pbSeparador1;
        private Label lblPais;
        protected ComboBox cbPaíses;
        private Label lblCodigoPostal;
        protected TextBox tbCalle;
        protected TextBox tbNFrente;
        private Label lblNumeroCasa;
        private Label lblCalle;
        private Label lblColonia;
        protected ComboBox cbEstado;
        protected ComboBox cbMunicipio;
        private Label lblEstado;
        private Label lblMunicipio;
        private Label lblCiudad;
        protected ComboBox cbTipoUsuario;
        private Label lblTipoUsuario;
        protected MaskedTextBox tbTrabajo;
        private Label lblTelefonoTrabajo;
        protected MaskedTextBox tbCel;
        private Label lblTelefonoCelular;
        protected ComboBox cbEmail;
        protected MaskedTextBox tbTel;
        protected TextBox tbEmail;
        private Label lblTelefonoCasa;
        private Label lblEmail;
        private PictureBox pbSeparador2;
        protected Button btnCerrar;
        protected TextBox tbColonia;
        protected Button btnRegistrar;
        private Label label14;
        private Label label13;
        protected ComboBox cbCiudad;
        protected PictureBox pbIcono;
        private string[] México;
        protected MaskedTextBox tbCP;
        private PictureBox pbSeparador3;
        protected ComboBox cbPregunta;
        private Label lblPregunta;
        private Label label1;
        protected TextBox tbRespuesta;
        private Label label2;
        private string[] Capitales = ("Kabul,Tirana,Berlín,Andorra la Vieja,Luanda,Saint John,Riad,Argel,Buenos Aires,Ereván,Canberra,Viena,Bakú,Nasáu,Daca,Bridgetown," +
                                "Manama,Bruselas,Belmopán,Porto - Novo,Minsk,Naipyidó,Sucre,Sarajevo,Gaborone,Brasilia,Bandar Seri Begawan," +
                                "Sofía,Uagadugú,Buyumbura,Thimphu,Praia,Nom Pen,Yaundé,Ottawa,Doha,Yamena,Santiago,Pekín,Nicosia,Bogotá,Moroni,Brazzaville," +
                                "Pionyang,Seúl,Yamusukro,San José,Zagreb,La Habana,Copenhague,Roseau,Quito,El Cairo,San Salvador,Abu Dabi,Asmara,Bratislava," +
                                "Liubliana,Madrid,Washington D.C.,Tallin,Adís Abeba,Manila,Helsinki,Suva,París,Libreville,Banjul,Tiflis,Accra,Saint George," +
                                "Atenas,Guatemala,Conakri,Malabo,Bisáu,Georgetown,Puerto Príncipe,Tegucigalpa,Budapest,Nueva Delhi,Yakarta,Bagdad,Teherán,Dublín," +
                                "Reikiavik,Majuro,Honiara,Jerusalén,Roma,Kingston,Tokio,Amán,Astaná,Nairobi,Biskek,Tarawa,Pristina,Kuwait City,Vientián,Maseru," +
                                "Riga,Beirut,Monrovia,Trípoli,Vaduz,Vilna,Luxemburgo,Skopie,Antananarivo,Kuala Lumpur,Lilongüe,Malé,Bamako,La Valeta,Rabat," +
                                "Port Louis,Nuakchot,México,Palikir,Chisináu,Mónaco,Ulán Bator,Podgorica,Maputo,Windhoek,Yaren,Katmandú,Managua,Niamey,Abuya," +
                                "Oslo,Wellington,Mascate,Ámsterdam,Islamabad,Melekeok,Jerusalén Este,Panamá,Puerto Moresby,Asunción,Lima,Varsovia,Lisboa,Londres," +
                                "Bangui,Praga,Kinsasa,Santo Domingo,Kigali,Bucarest,Moscú,Apia,Basseterre,San Marino,Kingstown,Castries,Santo Tomé,Dakar,Belgrado," +
                                "Victoria,Freetown,Singapur,Damasco,Mogadiscio,Sri Jayawardenapura Kotte,Mbabane,Pretoria,Jartum,Yuba,Estocolmo,Berna,Paramaribo," +
                                "Bangkok,Taipéi,Dodoma,Dusambé,Dili,Lomé,Nukualofa,Puerto España,Túnez,Asjabad,Ankara,Funafuti,Kiev,Kampala,Montevideo,Taskent," +
                                "Port Vila,Vaticano,Caracas,Hanói,Saná,Yibuti,Lusaka,Harare,").Split(',', '\n', '\r', '\t');

        public PantallaUsuario() : base()
        {
            InitializeComponent();
            Enters();
            México = Properties.Resources.Ciudades.Split('\n');
            Error = new ErrorProvider(this);
            ErrorText = new ErrorProvider[8];
            for (int i = 0; i < ErrorText.Length; i++)
                ErrorText[i] = new ErrorProvider();
            ErrorMasked = new ErrorProvider[4];
            for (int i = 0; i < ErrorMasked.Length; i++)
                ErrorMasked[i] = new ErrorProvider();
            ErrorCombo = new ErrorProvider[6];
            for (int i = 0; i < ErrorCombo.Length; i++)
                ErrorCombo[i] = new ErrorProvider();
            ErrorPass = new ErrorProvider();
            Validaciones = new Validar(this);
        }

        private void InitializeComponent()
        {
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.lblPantallaUsuario = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbPassword = new ControlesPersonalizados.Password();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.tbNEmpleado = new System.Windows.Forms.TextBox();
            this.pbSeparador1 = new System.Windows.Forms.PictureBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.cbPaíses = new System.Windows.Forms.ComboBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.tbNFrente = new System.Windows.Forms.TextBox();
            this.lblNumeroCasa = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbMunicipio = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.tbTrabajo = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefonoTrabajo = new System.Windows.Forms.Label();
            this.tbCel = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefonoCelular = new System.Windows.Forms.Label();
            this.cbEmail = new System.Windows.Forms.ComboBox();
            this.tbTel = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblTelefonoCasa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pbSeparador2 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbColonia = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.tbCP = new System.Windows.Forms.MaskedTextBox();
            this.pbSeparador3 = new System.Windows.Forms.PictureBox();
            this.cbPregunta = new System.Windows.Forms.ComboBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRespuesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador3)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Controls.Add(this.lblPantallaUsuario);
            this.Encabezado.Controls.Add(this.pbIcono);
            this.Encabezado.Size = new System.Drawing.Size(599, 73);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(506, 624);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 18);
            this.label14.TabIndex = 151;
            this.label14.Text = "Cancelar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(409, 624);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 18);
            this.label13.TabIndex = 152;
            this.label13.Text = "Aceptar";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImage = global::Presentacion.Properties.Resources.IconoUsuario;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcono.Location = new System.Drawing.Point(20, 6);
            this.pbIcono.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(60, 60);
            this.pbIcono.TabIndex = 9;
            this.pbIcono.TabStop = false;
            // 
            // lblPantallaUsuario
            // 
            this.lblPantallaUsuario.AutoSize = true;
            this.lblPantallaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblPantallaUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantallaUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPantallaUsuario.Location = new System.Drawing.Point(94, 26);
            this.lblPantallaUsuario.Name = "lblPantallaUsuario";
            this.lblPantallaUsuario.Size = new System.Drawing.Size(177, 24);
            this.lblPantallaUsuario.TabIndex = 9;
            this.lblPantallaUsuario.Text = "Pantalla Usuario";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(36, 85);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(492, 17);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Favor de ingresar la informacion en los campos correspondientes.";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(224, 176);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(154, 23);
            this.tbPassword.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(36, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 17);
            this.lblNombre.TabIndex = 54;
            this.lblNombre.Text = "* Nombre(s)";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(221, 112);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(85, 17);
            this.lblApellido.TabIndex = 56;
            this.lblApellido.Text = "* Apellido(s)";
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Location = new System.Drawing.Point(39, 132);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ShortcutsEnabled = false;
            this.tbNombre.Size = new System.Drawing.Size(153, 21);
            this.tbNombre.TabIndex = 1;
            // 
            // tbApellidos
            // 
            this.tbApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbApellidos.Location = new System.Drawing.Point(224, 132);
            this.tbApellidos.MaxLength = 50;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.ShortcutsEnabled = false;
            this.tbApellidos.Size = new System.Drawing.Size(153, 21);
            this.tbApellidos.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(36, 159);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(146, 17);
            this.lblUsuario.TabIndex = 60;
            this.lblUsuario.Text = "* Nombre de Usuario:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUsuario.Location = new System.Drawing.Point(39, 177);
            this.tbUsuario.MaxLength = 30;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.ShortcutsEnabled = false;
            this.tbUsuario.Size = new System.Drawing.Size(153, 21);
            this.tbUsuario.TabIndex = 4;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(228, 159);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(98, 17);
            this.lblContraseña.TabIndex = 60;
            this.lblContraseña.Text = "* Contraseña:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(405, 112);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(108, 17);
            this.lblEmpleado.TabIndex = 60;
            this.lblEmpleado.Text = "* N° Empleado:";
            // 
            // tbNEmpleado
            // 
            this.tbNEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNEmpleado.Location = new System.Drawing.Point(408, 132);
            this.tbNEmpleado.MaxLength = 20;
            this.tbNEmpleado.Name = "tbNEmpleado";
            this.tbNEmpleado.ShortcutsEnabled = false;
            this.tbNEmpleado.Size = new System.Drawing.Size(153, 21);
            this.tbNEmpleado.TabIndex = 3;
            this.tbNEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros_KeyPress);
            // 
            // pbSeparador1
            // 
            this.pbSeparador1.BackgroundImage = global::Presentacion.Properties.Resources.ImagenSeparador;
            this.pbSeparador1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSeparador1.Location = new System.Drawing.Point(40, 205);
            this.pbSeparador1.Name = "pbSeparador1";
            this.pbSeparador1.Size = new System.Drawing.Size(521, 13);
            this.pbSeparador1.TabIndex = 61;
            this.pbSeparador1.TabStop = false;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(43, 222);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(37, 17);
            this.lblPais.TabIndex = 62;
            this.lblPais.Text = "País:";
            // 
            // cbPaíses
            // 
            this.cbPaíses.FormattingEnabled = true;
            this.cbPaíses.Items.AddRange(new object[] {
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "Birmania",
            "Bolivia",
            "Bosnia-Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Colombia",
            "Comoras",
            "Congo",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guinea",
            "Guinea Ecuatorial",
            "Guinea-Bisáu",
            "Guyana",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kosovo",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macedonia",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Palestina",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Taiwán",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Vaticano",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.cbPaíses.Location = new System.Drawing.Point(43, 239);
            this.cbPaíses.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbPaíses.MaxLength = 30;
            this.cbPaíses.Name = "cbPaíses";
            this.cbPaíses.Size = new System.Drawing.Size(149, 24);
            this.cbPaíses.TabIndex = 7;
            this.cbPaíses.SelectedIndexChanged += new System.EventHandler(this.cbPaises_SelectedChanged);
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.Location = new System.Drawing.Point(201, 315);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(53, 17);
            this.lblCodigoPostal.TabIndex = 84;
            this.lblCodigoPostal.Text = "* C. P.:";
            // 
            // tbCalle
            // 
            this.tbCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCalle.Location = new System.Drawing.Point(408, 288);
            this.tbCalle.Margin = new System.Windows.Forms.Padding(3, 3, 10, 6);
            this.tbCalle.MaxLength = 80;
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.ShortcutsEnabled = false;
            this.tbCalle.Size = new System.Drawing.Size(153, 21);
            this.tbCalle.TabIndex = 12;
            // 
            // tbNFrente
            // 
            this.tbNFrente.Location = new System.Drawing.Point(45, 336);
            this.tbNFrente.MaxLength = 6;
            this.tbNFrente.Name = "tbNFrente";
            this.tbNFrente.ShortcutsEnabled = false;
            this.tbNFrente.Size = new System.Drawing.Size(117, 21);
            this.tbNFrente.TabIndex = 13;
            this.tbNFrente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros_KeyPress);
            // 
            // lblNumeroCasa
            // 
            this.lblNumeroCasa.AutoSize = true;
            this.lblNumeroCasa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCasa.Location = new System.Drawing.Point(45, 315);
            this.lblNumeroCasa.Name = "lblNumeroCasa";
            this.lblNumeroCasa.Size = new System.Drawing.Size(115, 17);
            this.lblNumeroCasa.TabIndex = 78;
            this.lblNumeroCasa.Text = "Número exterior:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(405, 269);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(56, 17);
            this.lblCalle.TabIndex = 79;
            this.lblCalle.Text = "* Calle:";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColonia.Location = new System.Drawing.Point(221, 268);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(74, 17);
            this.lblColonia.TabIndex = 80;
            this.lblColonia.Text = "* Colonia:";
            // 
            // cbEstado
            // 
            this.cbEstado.ContextMenu = this.cbPaíses.ContextMenu;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(224, 239);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbEstado.MaxLength = 30;
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(154, 24);
            this.cbEstado.TabIndex = 8;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.ContextMenu = this.cbPaíses.ContextMenu;
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.Location = new System.Drawing.Point(408, 239);
            this.cbMunicipio.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbMunicipio.MaxLength = 50;
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(153, 24);
            this.cbMunicipio.TabIndex = 9;
            this.cbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cbMunicipio_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(221, 222);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 72;
            this.lblEstado.Text = "Estado:";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(405, 222);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(74, 17);
            this.lblMunicipio.TabIndex = 73;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(45, 268);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(61, 17);
            this.lblCiudad.TabIndex = 74;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.ContextMenu = this.cbPaíses.ContextMenu;
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Empleado",
            "Laboratorista",
            "Jefe Laboratorio",
            "Contador"});
            this.cbTipoUsuario.Location = new System.Drawing.Point(408, 174);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbTipoUsuario.MaxLength = 30;
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(153, 24);
            this.cbTipoUsuario.TabIndex = 6;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(405, 156);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(119, 17);
            this.lblTipoUsuario.TabIndex = 86;
            this.lblTipoUsuario.Text = "* Tipo de Usuario:";
            // 
            // tbTrabajo
            // 
            this.tbTrabajo.Location = new System.Drawing.Point(274, 400);
            this.tbTrabajo.Mask = "(999)000-0000";
            this.tbTrabajo.Name = "tbTrabajo";
            this.tbTrabajo.ShortcutsEnabled = false;
            this.tbTrabajo.Size = new System.Drawing.Size(78, 21);
            this.tbTrabajo.TabIndex = 17;
            this.tbTrabajo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTelefonoTrabajo
            // 
            this.lblTelefonoTrabajo.AutoSize = true;
            this.lblTelefonoTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoTrabajo.Location = new System.Drawing.Point(274, 380);
            this.lblTelefonoTrabajo.Name = "lblTelefonoTrabajo";
            this.lblTelefonoTrabajo.Size = new System.Drawing.Size(60, 17);
            this.lblTelefonoTrabajo.TabIndex = 141;
            this.lblTelefonoTrabajo.Text = "Trabajo:";
            // 
            // tbCel
            // 
            this.tbCel.Location = new System.Drawing.Point(154, 400);
            this.tbCel.Mask = "000-000-0000";
            this.tbCel.Name = "tbCel";
            this.tbCel.ShortcutsEnabled = false;
            this.tbCel.Size = new System.Drawing.Size(78, 21);
            this.tbCel.TabIndex = 16;
            this.tbCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTelefonoCelular
            // 
            this.lblTelefonoCelular.AutoSize = true;
            this.lblTelefonoCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCelular.Location = new System.Drawing.Point(154, 380);
            this.lblTelefonoCelular.Name = "lblTelefonoCelular";
            this.lblTelefonoCelular.Size = new System.Drawing.Size(68, 17);
            this.lblTelefonoCelular.TabIndex = 139;
            this.lblTelefonoCelular.Text = "* Celular:";
            // 
            // cbEmail
            // 
            this.cbEmail.ContextMenu = this.cbPaíses.ContextMenu;
            this.cbEmail.FormattingEnabled = true;
            this.cbEmail.Items.AddRange(new object[] {
            "gmail.com",
            "hotmail.com",
            "yahoo.com",
            "outlook.com",
            "live.com",
            "prodigy.com"});
            this.cbEmail.Location = new System.Drawing.Point(235, 445);
            this.cbEmail.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbEmail.MaxLength = 20;
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(131, 24);
            this.cbEmail.TabIndex = 19;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(45, 400);
            this.tbTel.Mask = "(999)000-0000";
            this.tbTel.Name = "tbTel";
            this.tbTel.ResetOnSpace = false;
            this.tbTel.ShortcutsEnabled = false;
            this.tbTel.Size = new System.Drawing.Size(78, 21);
            this.tbTel.SkipLiterals = false;
            this.tbTel.TabIndex = 15;
            this.tbTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbEmail
            // 
            this.tbEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEmail.Location = new System.Drawing.Point(45, 445);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 3, 10, 6);
            this.tbEmail.MaxLength = 49;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ShortcutsEnabled = false;
            this.tbEmail.Size = new System.Drawing.Size(147, 21);
            this.tbEmail.TabIndex = 18;
            // 
            // lblTelefonoCasa
            // 
            this.lblTelefonoCasa.AutoSize = true;
            this.lblTelefonoCasa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCasa.Location = new System.Drawing.Point(45, 380);
            this.lblTelefonoCasa.Name = "lblTelefonoCasa";
            this.lblTelefonoCasa.Size = new System.Drawing.Size(76, 17);
            this.lblTelefonoCasa.TabIndex = 134;
            this.lblTelefonoCasa.Text = "* Telefono:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(45, 427);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 17);
            this.lblEmail.TabIndex = 135;
            this.lblEmail.Text = "* Email:";
            // 
            // pbSeparador2
            // 
            this.pbSeparador2.BackgroundImage = this.pbSeparador1.BackgroundImage;
            this.pbSeparador2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSeparador2.Location = new System.Drawing.Point(39, 364);
            this.pbSeparador2.Name = "pbSeparador2";
            this.pbSeparador2.Size = new System.Drawing.Size(521, 13);
            this.pbSeparador2.TabIndex = 146;
            this.pbSeparador2.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Presentacion.Properties.Resources.IconoCancelar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(515, 560);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(62, 58);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // tbColonia
            // 
            this.tbColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbColonia.Location = new System.Drawing.Point(224, 287);
            this.tbColonia.MaxLength = 30;
            this.tbColonia.Name = "tbColonia";
            this.tbColonia.ShortcutsEnabled = false;
            this.tbColonia.Size = new System.Drawing.Size(154, 21);
            this.tbColonia.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = global::Presentacion.Properties.Resources.IconoAceptar;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(415, 560);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(62, 58);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.MouseEnter += new System.EventHandler(this.btnMouseOver);
            this.btnRegistrar.MouseLeave += new System.EventHandler(this.btnMouseLeft);
            // 
            // cbCiudad
            // 
            this.cbCiudad.ContextMenu = this.cbPaíses.ContextMenu;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Items.AddRange(new object[] {
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "Birmania",
            "Bolivia",
            "Bosnia-Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Colombia",
            "Comoras",
            "Congo",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guinea",
            "Guinea Ecuatorial",
            "Guinea-Bisáu",
            "Guyana",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kosovo",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macedonia",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Palestina",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Taiwán",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Vaticano",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.cbCiudad.Location = new System.Drawing.Point(43, 285);
            this.cbCiudad.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbCiudad.MaxLength = 30;
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(149, 24);
            this.cbCiudad.TabIndex = 10;
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(201, 336);
            this.tbCP.Mask = "00000";
            this.tbCP.Name = "tbCP";
            this.tbCP.ShortcutsEnabled = false;
            this.tbCP.Size = new System.Drawing.Size(88, 21);
            this.tbCP.TabIndex = 14;
            this.tbCP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // pbSeparador3
            // 
            this.pbSeparador3.BackgroundImage = this.pbSeparador1.BackgroundImage;
            this.pbSeparador3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSeparador3.Location = new System.Drawing.Point(39, 475);
            this.pbSeparador3.Name = "pbSeparador3";
            this.pbSeparador3.Size = new System.Drawing.Size(521, 13);
            this.pbSeparador3.TabIndex = 146;
            this.pbSeparador3.TabStop = false;
            // 
            // cbPregunta
            // 
            this.cbPregunta.ContextMenu = this.cbPaíses.ContextMenu;
            this.cbPregunta.FormattingEnabled = true;
            this.cbPregunta.Items.AddRange(new object[] {
            "Lugar de nacimiento de la madre",
            "Nombre de la primera mascota.",
            "Canción favorita.",
            "Equipo deportivo preferido.",
            "Nombre del abuelo paterno."});
            this.cbPregunta.Location = new System.Drawing.Point(40, 520);
            this.cbPregunta.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cbPregunta.MaxLength = 100;
            this.cbPregunta.Name = "cbPregunta";
            this.cbPregunta.Size = new System.Drawing.Size(338, 24);
            this.cbPregunta.TabIndex = 21;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(40, 497);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(170, 17);
            this.lblPregunta.TabIndex = 134;
            this.lblPregunta.Text = "* Pregunta de seguridad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 34);
            this.label1.TabIndex = 134;
            this.label1.Text = "Favor de recordar su respuesta ya que le ayudará\nen caso de que pierda su contras" +
    "eña";
            // 
            // tbRespuesta
            // 
            this.tbRespuesta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRespuesta.Location = new System.Drawing.Point(40, 559);
            this.tbRespuesta.Margin = new System.Windows.Forms.Padding(3, 3, 10, 6);
            this.tbRespuesta.MaxLength = 100;
            this.tbRespuesta.Name = "tbRespuesta";
            this.tbRespuesta.ShortcutsEnabled = false;
            this.tbRespuesta.Size = new System.Drawing.Size(337, 21);
            this.tbRespuesta.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 139;
            this.label2.Text = "@";
            // 
            // PantallaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(599, 609);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pbSeparador3);
            this.Controls.Add(this.pbSeparador2);
            this.Controls.Add(this.tbTrabajo);
            this.Controls.Add(this.lblTelefonoTrabajo);
            this.Controls.Add(this.tbCel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTelefonoCelular);
            this.Controls.Add(this.cbPregunta);
            this.Controls.Add(this.cbEmail);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbRespuesta);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblTelefonoCasa);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblCodigoPostal);
            this.Controls.Add(this.tbCalle);
            this.Controls.Add(this.tbColonia);
            this.Controls.Add(this.tbNFrente);
            this.Controls.Add(this.lblNumeroCasa);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblColonia);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbMunicipio);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.cbPaíses);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.pbSeparador1);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tbNEmpleado);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.tbCP);
            this.Name = "PantallaUsuario";
            this.Text = "Pantalla Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaUsuario_FormClosing);
            this.Controls.SetChildIndex(this.tbCP, 0);
            this.Controls.SetChildIndex(this.cbCiudad, 0);
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.tbPassword, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.tbNombre, 0);
            this.Controls.SetChildIndex(this.tbUsuario, 0);
            this.Controls.SetChildIndex(this.tbApellidos, 0);
            this.Controls.SetChildIndex(this.tbNEmpleado, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.lblContraseña, 0);
            this.Controls.SetChildIndex(this.lblEmpleado, 0);
            this.Controls.SetChildIndex(this.pbSeparador1, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.cbPaíses, 0);
            this.Controls.SetChildIndex(this.lblCiudad, 0);
            this.Controls.SetChildIndex(this.lblMunicipio, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.cbMunicipio, 0);
            this.Controls.SetChildIndex(this.cbEstado, 0);
            this.Controls.SetChildIndex(this.lblColonia, 0);
            this.Controls.SetChildIndex(this.lblCalle, 0);
            this.Controls.SetChildIndex(this.lblNumeroCasa, 0);
            this.Controls.SetChildIndex(this.tbNFrente, 0);
            this.Controls.SetChildIndex(this.tbColonia, 0);
            this.Controls.SetChildIndex(this.tbCalle, 0);
            this.Controls.SetChildIndex(this.lblCodigoPostal, 0);
            this.Controls.SetChildIndex(this.lblTipoUsuario, 0);
            this.Controls.SetChildIndex(this.cbTipoUsuario, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblTelefonoCasa, 0);
            this.Controls.SetChildIndex(this.lblPregunta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbEmail, 0);
            this.Controls.SetChildIndex(this.tbRespuesta, 0);
            this.Controls.SetChildIndex(this.tbTel, 0);
            this.Controls.SetChildIndex(this.cbEmail, 0);
            this.Controls.SetChildIndex(this.cbPregunta, 0);
            this.Controls.SetChildIndex(this.lblTelefonoCelular, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbCel, 0);
            this.Controls.SetChildIndex(this.lblTelefonoTrabajo, 0);
            this.Controls.SetChildIndex(this.tbTrabajo, 0);
            this.Controls.SetChildIndex(this.pbSeparador2, 0);
            this.Controls.SetChildIndex(this.pbSeparador3, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.Encabezado, 0);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparador3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Método que agrega los eventos correspondientes a los controles de la PantallaUsuario
        /// </summary>
        private void Enters()
        {
            tbNombre.KeyPress += SeleccionarSiguiente;
            tbApellidos.KeyPress += SeleccionarSiguiente;
            tbNEmpleado.KeyPress += SeleccionarSiguiente;
            tbUsuario.KeyPress += SeleccionarSiguiente;
            tbPassword.Enfocar += new Password.InFocus(delegate (object sender, KeyPressEventArgs e) { if (e.KeyChar == 13) cbTipoUsuario.Focus(); });
            cbTipoUsuario.KeyPress += SeleccionarSiguiente;
            cbTipoUsuario.LostFocus += FocoPerdido;
            cbPaíses.KeyPress += SeleccionarSiguiente;
            cbPaíses.LostFocus += FocoPerdido;
            cbEstado.KeyPress += SeleccionarSiguiente;
            cbEstado.LostFocus += FocoPerdido;
            cbMunicipio.KeyPress += SeleccionarSiguiente;
            cbMunicipio.LostFocus += FocoPerdido;
            cbCiudad.KeyPress += SeleccionarSiguiente;
            cbCiudad.LostFocus += FocoPerdido;
            tbColonia.KeyPress += SeleccionarSiguiente;
            tbCalle.KeyPress += SeleccionarSiguiente;
            tbNFrente.KeyPress += SeleccionarSiguiente;
            tbCP.KeyPress += SeleccionarSiguiente;
            tbTel.KeyPress += SeleccionarSiguiente;
            tbCel.KeyPress += SeleccionarSiguiente;
            tbTrabajo.KeyPress += SeleccionarSiguiente;
            tbEmail.KeyPress += SeleccionarSiguiente;
            cbEmail.KeyPress += SeleccionarSiguiente;
            cbEmail.LostFocus += FocoPerdido;
            cbPregunta.LostFocus += FocoPerdido;
            cbPregunta.KeyPress += SeleccionarSiguiente;
            tbRespuesta.KeyPress += SeleccionarSiguiente;
        }

        /// <summary>
        /// Método encargado de actualizar los combobox al perder el foco de control
        /// </summary>
        /// <param name="sender">Objeto que envía el evento</param>
        /// <param name="e">Contenedor de los parámetros de invocación</param>
        private void FocoPerdido(object sender, EventArgs e)
        {
            ComboBox temp = sender as ComboBox;
            int t = temp.Items.IndexOf(temp.Text);
            if (t != -1)
            {
                temp.SelectedIndex = t == -1 ? (temp.Items.Count > 0 ? 0 : t) : t;
            }
            else
            {
                if (cbPaíses == (ComboBox)sender)
                {
                    cbEstado.Items.Clear();
                    cbMunicipio.Items.Clear();
                    cbCiudad.Items.Clear();
                    cbEstado.Text = cbMunicipio.Text = cbCiudad.Text = "";
                }
                else
                {
                    if (cbEstado == (ComboBox)sender)
                    {
                        cbMunicipio.Items.Clear();
                        cbCiudad.Items.Clear();
                        cbMunicipio.Text = cbCiudad.Text = "";
                    }
                    else
                    {
                        if (cbMunicipio == (ComboBox)sender)
                        {
                            cbCiudad.Items.Clear();
                            cbCiudad.Text = "";
                        }
                        else
                        {
                            if ((ComboBox)sender == cbTipoUsuario)
                            {
                                if (t == -1)
                                {
                                    cbTipoUsuario.SelectedIndex = 1;
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Método encargado de seleccionar el siguiente control al presionar un enter
        /// </summary>
        /// <param name="sender">Objeto que invoca el método</param>
        /// <param name="e">Contenedor de los parámetros de invocación</param>
        protected override void SeleccionarSiguiente(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || (e.KeyChar == '@' || (sender.GetType() == tbEmail.GetType() && (TextBox)sender == tbEmail)))
            {
                if (e.KeyChar == '@' && (sender.GetType() == tbEmail.GetType() && (TextBox)sender == tbEmail))
                {
                    e.Handled = true;
                    e.KeyChar = (char)13;
                }
                else
                {
                    if (e.KeyChar == '@' && (sender.GetType() == cbEmail.GetType() && (ComboBox)sender == cbEmail))
                    {
                        e.Handled = true;
                    }
                }
                base.SeleccionarSiguiente(sender, e);
            }
        }
        
        protected override void btnMouseLeft(object sender, EventArgs e)
        {
            base.btnMouseLeft(sender, e);
        }

        protected override void btnMouseOver(object sender, EventArgs e)
        {
            base.btnMouseOver(sender, e);
        }

        private void cbPaises_SelectedChanged(object sender, EventArgs e)
        {
            cbEstado.Items.Clear();
            cbMunicipio.Items.Clear();
            cbCiudad.Items.Clear();
            cbEstado.Text = cbMunicipio.Text = cbCiudad.Text = "";
            if (cbPaíses.Text == "México")
            {
                for (int i = 0; i < México.Length; i++)
                {
                    string[] temp = México[i].Split('\t');
                    if (!cbEstado.Items.Contains(temp[0]))
                    {
                        cbEstado.Items.Add(temp[0]);
                    }
                }
                tbCP.Mask = "00000";
            }
            else
            {
                cbEstado.Items.Add(Capitales[cbPaíses.SelectedIndex]);
                if (cbPaíses.Text == "Estados Unidos")
                {
                    tbCP.Mask = "00000";
                }
                else
                {
                    if (cbPaíses.Text == "Canadá")
                    {
                        tbCP.Mask = ">L0>L0>L0";
                    }
                    else
                    {
                        tbCP.Mask = ">a>a>a>a>a>a>a>a>a>a";
                    }
                }
            }
            cbEstado.SelectedIndex = 0;

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMunicipio.Items.Clear();
            cbCiudad.Items.Clear();
            cbMunicipio.Text = cbCiudad.Text = "";
            if (cbPaíses.Text == "México")
            {
                for (int i = 0; i < México.Length; i++)
                {
                    string[] temp = México[i].Split('\t');
                    if (cbEstado.Text == temp[0])
                        if (!cbMunicipio.Items.Contains(temp[1]))
                        {
                            cbMunicipio.Items.Add(temp[1]);
                        }
                }
                cbMunicipio.SelectedIndex = 0;
            }
        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCiudad.Items.Clear();
            cbCiudad.Text = "";
            if (cbPaíses.Text == "México")
            {
                for (int i = 0; i < México.Length; i++)
                {
                    string[] temp = México[i].Split('\t');
                    if (cbEstado.Text == temp[0])
                        if (cbMunicipio.Text == temp[1])
                            if (!cbCiudad.Items.Contains(temp[2]))
                            {
                                cbCiudad.Items.Add(temp[2]);
                            }
                }
                cbCiudad.SelectedIndex = 0;
            }
        }

        private void PantallaUsuario_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            LlamarEventoCerrar();
        }

        protected virtual RegistroUsuario ObtenerRegistro
        {
            get
            {
                return new RegistroUsuario(Convert.ToInt32(tbNEmpleado.Text), tbNombre.Text, tbApellidos.Text, tbUsuario.Text,
              tbPassword.Text, cbTipoUsuario.Text, cbPaíses.Text, cbEstado.Text, cbMunicipio.Text, cbCiudad.Text,
              tbColonia.Text, tbCalle.Text, Convert.ToInt32(tbNFrente.Text == "" ? 0.ToString() : tbNFrente.Text).ToString(), tbCP.Text, tbTel.Text, tbCel.Text, tbTrabajo.Text,
              tbEmail.Text + "@" + cbEmail.Text, cbPregunta.Text, tbRespuesta.Text, 1);
            }
        }

        private void ValidarNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        protected virtual bool ValidarCampos
        {
            get
            {
                bool temp = Validaciones.ValidarTextBox(tbNombre, tbApellidos, tbUsuario, tbCalle, tbColonia, tbEmail, tbNEmpleado, tbRespuesta);
                temp = Validaciones.ValidarComboBox(cbEmail, cbTipoUsuario, cbPregunta) || temp;
                temp = Validaciones.ValidarMaskedTextBox(tbTel, tbCel, tbCP) || temp;
                temp = Validaciones.ValidarPassword(true, tbPassword) || temp;
                return temp;
            }
        }

        protected virtual void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected System.Windows.Forms.Control ObtenerErrorControl
        {
            get
            {
                return Validaciones.ObtenerControlError;
            }
        }
    }
}
