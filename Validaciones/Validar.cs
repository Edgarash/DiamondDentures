﻿using Control;
using ControlesPersonalizados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Validaciones
{
    public class Validar
    {
        Pantalla Pantalla;
        List<TextBox> Text = new List<TextBox>();
        List<MaskedTextBox> Masked = new List<MaskedTextBox>();
        List<ComboBox> Combo = new List<ComboBox>();
        List<Password> Pass = new List<Password>();
        ErrorProvider[] ErrorText;
        ErrorProvider[] ErrorMasked;
        ErrorProvider[] ErrorCombo;
        ErrorProvider[] ErrorPass;
        System.Windows.Forms.Control UltimoError;

        public Validar(Pantalla Contenedor)
        {
            Pantalla = Contenedor;
        }

        public bool ValidarCampos()
        {
            bool temp = ValidarTextBox();
            temp = ValidarComboBox() || temp;
            temp = ValidarMaskedTextBox() || temp;
            return temp;
        }

        private bool ValidarTextBox()
        {
            bool Error = false;
            for (int i = 0; i < Text.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(Text[i].Text))
                {
                    ErrorText[i].SetError(Text[i], "Campo obligatorio");
                    Error = true;
                    UltimoError = Text[i];
                }
                else
                {
                    if (ErrorText[i] != null)
                    {
                        ErrorText[i].SetError(Text[i], "");
                        ErrorText[i].Clear();
                    }
                }
                Text[i].ShortcutsEnabled = false;
            }
            return Error;
        }

        public bool ValidarTextBox(params TextBox[] Text)
        {
            if (ErrorText == null)
            {
                this.Text.Clear();
                ErrorText = new ErrorProvider[Text.Length];
            }
            for (int i = 0; i < Text.Length; i++)
            {
                if (!this.Text.Contains(Text[i]))
                {
                    this.Text.Add(Text[i]);
                }
                if (ErrorText[i] == null)
                {
                    ErrorText[i] = new ErrorProvider(Pantalla);
                }
            }
            return ValidarTextBox();
        }

        private bool ValidarComboBox()
        {
            bool Error = false;
            for (int i = 0; i < Combo.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(Combo[i].Text))
                {
                    ErrorCombo[i].SetError(Combo[i], "Campo obligatorio");
                    Error = true;
                    UltimoError = Combo[i];
                }
                else
                {
                    if (ErrorCombo[i] != null)
                    {
                        ErrorCombo[i].SetError(Combo[i], "");
                        ErrorCombo[i].Clear();
                    }
                }
            }
            return Error;
        }

        public bool ValidarComboBox(params ComboBox[] Combo)
        {
            if (ErrorCombo == null)
            {
                this.Combo.Clear();
                ErrorCombo = new ErrorProvider[Combo.Length];
            }
            for (int i = 0; i < Combo.Length; i++)
            {
                if (!this.Combo.Contains(Combo[i]))
                {
                    this.Combo.Add(Combo[i]);
                }
                if (ErrorCombo[i] == null)
                {
                    ErrorCombo[i] = new ErrorProvider(Pantalla);
                }
            }
            return ValidarComboBox();
        }

        private bool ValidarMaskedTextBox()
        {
            bool Error = false;
            for (int i = 0; i < Masked.Count; i++)
            {
                Masked[i].TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (string.IsNullOrWhiteSpace(Masked[i].Text))
                {
                    ErrorMasked[i].SetError(Masked[i], "Campo obligatorio");
                    Error = true;
                    UltimoError = Masked[i];
                }
                else
                {
                    if (!Masked[i].MaskCompleted)
                    {
                        ErrorMasked[i].SetError(Masked[i], "Campo incompleto");
                        Error = true;
                        UltimoError = Masked[i];
                    }
                    else
                    {
                        if (Masked[i].Mask.Contains('/') && Masked[i].Name == "tbFechaTarjeta")
                        {
                            string[] temp = { Masked[i].Text[0].ToString() + Masked[i].Text[1], Masked[i].Text[2].ToString() + Masked[i].Text[3] };
                            if (Convert.ToInt32(temp[0]) > 12 || Convert.ToInt32(temp[1]) < 17)
                            {
                                if (Convert.ToInt32(temp[1]) < 17)
                                {
                                    ErrorMasked[i].SetError(Masked[i], "Tarjeta vencida");
                                    Error = true;
                                    UltimoError = Masked[i];
                                }
                                else
                                {
                                    ErrorMasked[i].SetError(Masked[i], "Fecha inválida");
                                    Error = true;
                                    UltimoError = Masked[i];
                                }
                            }
                        }
                        else
                        {
                            if (ErrorMasked[i] != null)
                            {
                                string e = ErrorMasked[i].GetError(Masked[i]);
                                ErrorMasked[i].SetError(Masked[i] as System.Windows.Forms.Control, null);
                                ErrorMasked[i].Clear();
                            }
                        }
                    }
                }
            }
            return Error;
        }

        public bool ValidarMaskedTextBox(params MaskedTextBox[] Masked)
        {
            if (ErrorMasked == null)
            {
                this.Masked.Clear();
                ErrorMasked = new ErrorProvider[Masked.Length];
            }
            for (int i = 0; i < Masked.Length; i++)
            {
                if (!this.Masked.Contains(Masked[i]))
                {
                    this.Masked.Add(Masked[i]);
                }
                if (ErrorMasked[i] == null)
                {
                    ErrorMasked[i] = new ErrorProvider(Pantalla);
                }
            }
            return ValidarMaskedTextBox();
        }

        private bool ValidarPassword(bool ChecarContraseñaVacía)
        {
            bool Error = false;
            for (int i = 0; i < Pass.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(Pass[i].Text))
                {
                    if (ChecarContraseñaVacía)
                    {
                        ErrorPass[i].SetError(Pass[i], "Campo obligatorio");
                        Error = true;
                        UltimoError = Pass[i];
                    }
                    else
                    {
                        if (ErrorPass != null)
                        {
                            ErrorPass[i].SetError(Pass[i], "");
                            ErrorPass[i].Clear();
                        }
                    }
                }
                else
                {
                    if (!ContraseñaValida(Pass[i].Text))
                    {
                        ErrorPass[i].SetError(Pass[i], "La contraseña necesita tener al menos\n\n* 1 mayúscula\n* 1 minúscula\n* 1 número\n* 1 caracter especial\n* 8 caracteres");
                        Error = true;
                        UltimoError = Pass[i];
                    }
                    else
                    {
                        if (ErrorPass != null)
                        {
                            ErrorPass[i].SetError(Pass[i], "");
                            ErrorPass[i].Clear();
                        }
                    }
                }
            }
            return Error;
        }

        public bool ValidarPassword(bool ChecarContraseñaVacía, params Password[] Pass)
        {
            if (ErrorPass == null)
            {
                this.Pass.Clear();
                ErrorPass = new ErrorProvider[Pass.Length];
            }
            for (int i = 0; i < Pass.Length; i++)
            {
                if (!this.Pass.Contains(Pass[i]))
                {
                    this.Pass.Add(Pass[i]);
                }
                if (ErrorPass[i] == null)
                {
                    ErrorPass[i] = new ErrorProvider(Pantalla);
                }
            }
            return ValidarPassword(ChecarContraseñaVacía);
        }

        private bool ContraseñaValida(string Contraseña)
        {
            bool numero = false, mayus = false, minus = false, esp = false, min = false;
            string[] t = " ! \" # $ % & ' ( ) * + , - . / : ; < = > ? @ [ \\ ] ^ _ ` { | } ~".Split(' ');
            if (Contraseña.Length > 7)
            {
                min = true;
                for (int i = 0; i < Contraseña.Length; i++)
                {
                    char temp = Contraseña[i];
                    if (char.IsDigit(temp))
                    { numero = true; }
                    else
                    {
                        if (char.IsUpper(temp))
                        { mayus = true; }
                        else
                        {
                            if (char.IsLower(temp))
                            { minus = true; }
                            else
                            {
                                if (t.Contains<string>(temp.ToString()))
                                { esp = true; }
                                else
                                {
                                    if (temp == ' ')
                                    { esp = true; }
                                }
                            }
                        }
                    }
                }
            }
            return numero && mayus && minus && esp && min;
        }

        public void ChecarUsuario(TextBox User, Password Pass)
        {
            ValidarTextBox(User);
            ValidarPassword(true, Pass);
        }

        public System.Windows.Forms.Control ObtenerControlError
        {
            get
            {
                return UltimoError;
            }
        }

        public static bool ValidarUnaPantalla(Type temp)
        {
            bool Abierta = false;
            foreach (Pantalla x in Application.OpenForms)
            {
                if (temp == x.GetType())
                {
                    x.Show();
                    x.WindowState = FormWindowState.Normal;
                    x.Activate();
                    x.BringToFront();
                    Abierta = true;
                }
            }
            return Abierta;
        }

        public static void ValidarPrecio(TextBox sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            { }
            else
            {
                if (char.IsDigit(e.KeyChar))
                {
                    if (sender.Text.Contains("."))
                    {
                        if (sender.Text.Substring(sender.Text.IndexOf('.')).Length > 2)
                            e.Handled = true;
                    }
                    else
                    {
                        if (sender.Text.Length == 8)
                            e.Handled = true;
                    }
                }
                else
                {
                    if (e.KeyChar == '.' && sender.Text.Contains("."))
                        e.Handled = true;
                    else
                    {
                        if (!sender.Text.Contains(".") && (sender.Text.Length == 7 || sender.Text.Length == 0))
                            e.Handled = true;
                        else
                        {
                            if (e.KeyChar != '.')
                                e.Handled = true;
                        }
                    }
                }
            }
        }

        public static void ValidarSoloNumeros(TextBox sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != 13)
                e.Handled = true;
        }

        public static DialogResult MensajeErrorBaseDeDatos()
        {
            return MensajeErrorOK("Hubo un problema con la base de datos, inténtelo más tarde");
        }

        public static DialogResult MensajeErrorOK(string temp)
        {
            return MessageBox.Show(temp, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        public void validarData(DataGridView data)
        {
            for (int i = 0; i < data.RowCount; i++)
            {
                DataGridViewCell temp = data[data.Columns["Estado de Pedido"].Index, i];
                string x = temp.Value.ToString();
                if (x == "Cancelado")
                {
                    temp.Style.BackColor = Color.IndianRed;
                }
                else
                {
                    if (x == "Registrado")
                    {
                        temp.Style.BackColor = Color.Thistle;
                    }
                    else
                    {
                        if (x == "Confirmado")
                        {
                            temp.Style.BackColor = Color.LimeGreen;
                        }
                        else
                        {
                            if (x == "En Proceso")
                            {
                                temp.Style.BackColor = Color.LightGray;
                            }
                            else
                            {
                                if (x == "Terminado")
                                {
                                    temp.Style.BackColor = Color.DeepSkyBlue;
                                }
                                else
                                {
                                    if (x == "Facturado")
                                    {
                                        temp.Style.BackColor = Color.Gold;
                                    }
                                    else
                                        if (x == "Pagado")
                                    {
                                        temp.Style.BackColor = Color.LightSalmon;
                                    }
                                }
                            }
                        }


                    }
                }
            }
        }

        public void ValidaCampoTxb(bool tipo, KeyPressEventArgs e)
        {
            if (tipo)
            {
                if (char.IsNumber(e.KeyChar)) { }
                else
                {
                    if (e.KeyChar == '\b')
                    {

                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                if (char.IsLetter(e.KeyChar)) { }
                else
                {
                    if (e.KeyChar == '\b' || (Keys)e.KeyChar == Keys.Space)
                    {

                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        public static void TextBox_KeyPress_ValidarSoloRealesConNegativos(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox;
            string temp = t.Text;
            if (e.KeyChar == '-')
            {
                if (t.SelectionStart != 0 || temp.Contains(e.KeyChar))
                    if (t.SelectedText.Length != temp.Length)
                        e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    if (t.SelectionStart > 0)
                    {
                        if (!char.IsDigit(temp[t.SelectionStart - 1]))
                            e.Handled = true;
                        else
                            if (temp.Contains(e.KeyChar))
                            if (!t.SelectedText.Contains(e.KeyChar))
                                e.Handled = true;
                    }
                    else
                        e.Handled = true;
                }
                else
                {
                    if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
                        e.Handled = true;
                }
            }
        }

        public static void TextBox_KeyPress_ValidarSoloReales2Decimales(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox;
            string temp = t.Text;
            if (e.KeyChar == '.')
            {
                if (t.SelectionStart > 0)
                {
                    if (!char.IsDigit(temp[t.SelectionStart - 1]))
                        e.Handled = true;
                    else
                        if (temp.Contains(e.KeyChar))
                        if (!t.SelectedText.Contains(e.KeyChar))
                            e.Handled = true;
                }
                else
                    e.Handled = true;
            }
            else
            {
                if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
                else
                    if (char.IsDigit(e.KeyChar))
                    if (temp.Contains("."))
                        if (temp.Substring(temp.IndexOf('.')).Length > 2)
                            e.Handled = true;
            }
        }

        public static void TextBox_KeyPress_ValidarSoloEnteros(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public static void NoApostrofes(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
                e.Handled = true;
        }

        public static void Mayusculas(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (e.KeyChar == '\'')
                e.Handled = true;
        }

        public static DialogResult MensajeInfo(string Mensaje)
        {
            return MessageBox.Show(Mensaje, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static int Valor(System.Windows.Forms.Control temp)
        {
            return string.IsNullOrEmpty(temp.Text) ? 0 : Convert.ToInt32(temp.Text);
        }

        public static string[] Paises =
            new string[]
           {
            "AFGANISTÁN",
            "ALBANIA",
            "ALEMANIA",
            "ANDORRA",
            "ANGOLA",
            "ANTIGUA Y BARBUDA",
            "ARABIA SAUDITA",
            "ARGELIA",
            "ARGENTINA",
            "ARMENIA",
            "AUSTRALIA",
            "AUSTRIA",
            "AZERBAIYÁN",
            "BAHAMAS",
            "BANGLADÉS",
            "BARBADOS",
            "BARÉIN",
            "BÉLGICA",
            "BELICE",
            "BENÍN",
            "BIELORRUSIA",
            "BIRMANIA",
            "BOLIVIA",
            "BOSNIA-HERZEGOVINA",
            "BOTSUANA",
            "BRASIL",
            "BRUNÉI",
            "BULGARIA",
            "BURKINA FASO",
            "BURUNDI",
            "BUTÁN",
            "CABO VERDE",
            "CAMBOYA",
            "CAMERÚN",
            "CANADÁ",
            "CATAR",
            "CHAD",
            "CHILE",
            "CHINA",
            "CHIPRE",
            "COLOMBIA",
            "COMORAS",
            "CONGO",
            "COREA DEL NORTE",
            "COREA DEL SUR",
            "COSTA DE MARFIL",
            "COSTA RICA",
            "CROACIA",
            "CUBA",
            "DINAMARCA",
            "DOMINICA",
            "ECUADOR",
            "EGIPTO",
            "EL SALVADOR",
            "EMIRATOS ÁRABES UNIDOS",
            "ERITREA",
            "ESLOVAQUIA",
            "ESLOVENIA",
            "ESPAÑA",
            "ESTADOS UNIDOS",
            "ESTONIA",
            "ETIOPÍA",
            "FILIPINAS",
            "FINLANDIA",
            "FIYI",
            "FRANCIA",
            "GABÓN",
            "GAMBIA",
            "GEORGIA",
            "GHANA",
            "GRANADA",
            "GRECIA",
            "GUATEMALA",
            "GUINEA",
            "GUINEA ECUATORIAL",
            "GUINEA-BISÁU",
            "GUYANA",
            "HAITÍ",
            "HONDURAS",
            "HUNGRÍA",
            "INDIA",
            "INDONESIA",
            "IRAK",
            "IRÁN",
            "IRLANDA",
            "ISLANDIA",
            "ISLAS MARSHALL",
            "ISLAS SALOMÓN",
            "ISRAEL",
            "ITALIA",
            "JAMAICA",
            "JAPÓN",
            "JORDANIA",
            "KAZAJISTÁN",
            "KENIA",
            "KIRGUISTÁN",
            "KIRIBATI",
            "KOSOVO",
            "KUWAIT",
            "LAOS",
            "LESOTO",
            "LETONIA",
            "LÍBANO",
            "LIBERIA",
            "LIBIA",
            "LIECHTENSTEIN",
            "LITUANIA",
            "LUXEMBURGO",
            "MACEDONIA",
            "MADAGASCAR",
            "MALASIA",
            "MALAUI",
            "MALDIVAS",
            "MALÍ",
            "MALTA",
            "MARRUECOS",
            "MAURICIO",
            "MAURITANIA",
            "MÉXICO",
            "MICRONESIA",
            "MOLDAVIA",
            "MÓNACO",
            "MONGOLIA",
            "MONTENEGRO",
            "MOZAMBIQUE",
            "NAMIBIA",
            "NAURU",
            "NEPAL",
            "NICARAGUA",
            "NÍGER",
            "NIGERIA",
            "NORUEGA",
            "NUEVA ZELANDA",
            "OMÁN",
            "PAÍSES BAJOS",
            "PAKISTÁN",
            "PALAOS",
            "PALESTINA",
            "PANAMÁ",
            "PAPÚA NUEVA GUINEA",
            "PARAGUAY",
            "PERÚ",
            "POLONIA",
            "PORTUGAL",
            "REINO UNIDO",
            "REPÚBLICA CENTROAFRICANA",
            "REPÚBLICA CHECA",
            "REPÚBLICA DEMOCRÁTICA DEL CONGO",
            "REPÚBLICA DOMINICANA",
            "RUANDA",
            "RUMANIA",
            "RUSIA",
            "SAMOA",
            "SAN CRISTÓBAL Y NIEVES",
            "SAN MARINO",
            "SAN VICENTE Y LAS GRANADINAS",
            "SANTA LUCÍA",
            "SANTO TOMÉ Y PRÍNCIPE",
            "SENEGAL",
            "SERBIA",
            "SEYCHELLES",
            "SIERRA LEONA",
            "SINGAPUR",
            "SIRIA",
            "SOMALIA",
            "SRI LANKA",
            "SUAZILANDIA",
            "SUDÁFRICA",
            "SUDÁN",
            "SUDÁN DEL SUR",
            "SUECIA",
            "SUIZA",
            "SURINAM",
            "TAILANDIA",
            "TAIWÁN",
            "TANZANIA",
            "TAYIKISTÁN",
            "TIMOR ORIENTAL",
            "TOGO",
            "TONGA",
            "TRINIDAD Y TOBAGO",
            "TÚNEZ",
            "TURKMENISTÁN",
            "TURQUÍA",
            "TUVALU",
            "UCRANIA",
            "UGANDA",
            "URUGUAY",
            "UZBEKISTÁN",
            "VANUATU",
            "VATICANO",
            "VENEZUELA",
            "VIETNAM",
            "YEMEN",
            "YIBUTI",
            "ZAMBIA",
            "ZIMBABUE"
           };

        public static string[] Capitales = ("Kabul,Tirana,Berlín,Andorra la Vieja,Luanda,Saint John,Riad,Argel,Buenos Aires,Ereván,Canberra,Viena,Bakú,Nasáu,Daca,Bridgetown," +
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
                                "Port Vila,Vaticano,Caracas,Hanói,Saná,Yibuti,Lusaka,Harare,").ToUpper().Split(',', '\n', '\r', '\t');
    }
}