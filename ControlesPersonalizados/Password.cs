using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesPersonalizados
{
    public partial class Password : UserControl
    {
        bool click = true;
        public Password()
        {
            InitializeComponent();
            tbPass2.KeyPress += new KeyPressEventHandler(delegate (object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 13)
                {
                    Enfocar(sender, e);
                }
            });
        }

        private void pbOjito_Click(object sender, EventArgs e)
        {
            pbOjito.BackgroundImage = click ? Properties.Resources.noun_851962_cc : Properties.Resources.noun_851961_cc;
            click = !click;
            tbPass2.UseSystemPasswordChar = click;
        }
        public void tbFocus()
        {
            tbPass2.Focus();
        }
        public delegate void InFocus(object sender, KeyPressEventArgs e);
        public event InFocus Enfocar;

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPass2.Focus();
        }
        public override string Text
        {
            get
            {
                return tbPass2.Text;
            }

            set
            {
                tbPass2.Text = value;
            }
        }

        public bool ContraseñaValida
        {
            get
            {
                bool numero = false, mayus = false, minus = false, esp = false, min = false;
                string[] t = " ! \" # $ % & ' ( ) * + , - . / : ; < = > ? @ [ \\ ] ^ _ ` { | } ~".Split(' ');
                if (Text.Length > 7)
                {
                    min = true;
                    for (int i = 0; i < Text.Length; i++)
                    {
                        char temp = Text[i];
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
        }
    }
}
