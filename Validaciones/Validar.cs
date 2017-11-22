using Control;
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

        private void InicializarControles(Pantalla Pantalla)
        {
            for (int i = 0; i < Pantalla.Controls.Count; i++)
            {
                System.Windows.Forms.Control x = Pantalla.Controls[i];
                if (x != null)
                {
                    if (x.GetType() == new TextBox().GetType())
                    {
                        Text.Add((TextBox)x);
                    }
                    else
                    {
                        if (x.GetType() == new MaskedTextBox().GetType())
                        {
                            Masked.Add((MaskedTextBox)x);
                        }
                        else
                        {
                            if (x.GetType() == new ComboBox().GetType())
                            {
                                Combo.Add((ComboBox)x);
                            }
                            else
                            {
                                if (x.GetType() == new Password().GetType())
                                {
                                    Pass.Add((Password)x);
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool ValidarCampos(bool ChecarContraseñaVacía)
        {
            bool temp = ValidarCampos();
            temp = ValidarPassword(ChecarContraseñaVacía) || temp;
            return temp;
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
                Masked[i].TextMaskFormat = MaskFormat.IncludeLiterals;
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
            if (e.KeyChar!= '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != 13)
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

        public static void TextBox_KeyPress_ValidarSoloReales(object sender, KeyPressEventArgs e)
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
            }
        }
    }
}

