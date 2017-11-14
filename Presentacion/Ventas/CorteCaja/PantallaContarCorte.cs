using ControlesM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.String;
using static Validaciones.Validar;

namespace Presentacion.Ventas.CorteCaja
{
    public partial class PantallaContarCorte : KuroForm
    {
        public enum Denominacion { B1000, B500, B200, B100, B50, B20, M10, M05, M02, M01, M50C, M20C, M10C, M05C }
        public struct Efectivo
        {
            public Denominacion Tipo { get; set; }
            public int Valor { get; set; }

            public Efectivo(Denominacion Tipo, int Valor)
            {
                this.Tipo = Tipo;
                this.Valor = Valor;
            }
        }

        public delegate void GuardarCorte(Efectivo[] RegistroBilletes, decimal Total);
        public event GuardarCorte RecuperarRegistros;

        private RichTextBox[] tbb { get; set; }
        private RichTextBox[] tbm { get; set; }
        private Efectivo[] MoneyMoneyMoney { get; set; }
        private decimal Total { get; set; }
        private bool Voluntario { get; set; }

        public PantallaContarCorte()
        {
            InitializeComponent();
            tbb = new RichTextBox[] { tbB1000, tbB500, tbB200, tbB100, tbB50, tbB20 };
            tbm = new RichTextBox[] { tbM10, tbM05, tbM01, tbM02, tbM50C, tbM20C, tbM10C, tbM05C };
            CambiarFuenteRichTextBox();
            CalcularTotal();
            foreach (RichTextBox x in tbb)
            {
                x.KeyPress += TextBox_KeyPress_ValidarSoloEnteros;
                x.TextChanged += RichTextBox_TextLenghtChanged;
            }
            foreach (RichTextBox x in tbm)
            {
                x.KeyPress += TextBox_KeyPress_ValidarSoloEnteros;
                x.TextChanged += RichTextBox_TextLenghtChanged;
            }
        }

        public PantallaContarCorte(Efectivo[] Cash) : this() { LlenarFormConMoneyMoneyMoney(Cash); }

        private void PantallaContarCorte_SizeChanged(object sender, EventArgs e)
        {
            CambiarFuenteRichTextBox();
        }

        private Font CambiarFuenteRichTextBox(RichTextBox Medida)
        {
            float Alto = 12;
            Graphics g = Medida.CreateGraphics();
            for (; g.MeasureString("1", new Font("Microsoft Sans Serif", Alto)).Height < Medida.Height; Alto += 0.5f) { }
            Font Nueva = new Font("Microsoft Sans Sefir", Alto - 0.5f);
            return Nueva;
        }

        private void CambiarFuenteRichTextBox()
        {
            Font
                Fuente1 = CambiarFuenteRichTextBox(tbB1000),
                Fuente2 = CambiarFuenteRichTextBox(tbM10),
                Fuente3;
            foreach (RichTextBox x in tbb)
                x.Font = Fuente1;
            foreach (RichTextBox x in tbm)
                x.Font = Fuente2;
            Fuente3 = new Font(Fuente2.FontFamily, Fuente2.Height / 3);
            btnAceptar.Font = btnSalir.Font = lblTotal.Font = Fuente3;
        }

        private void CalcularTotal()
        {
            decimal Total = 0;
            Total += Valor(tbB1000) * 1000;
            Total += Valor(tbB500) * 500;
            Total += Valor(tbB200) * 200;
            Total += Valor(tbB100) * 100;
            Total += Valor(tbB50) * 50;
            Total += Valor(tbB20) * 20;

            Total += Valor(tbM10) * 10;
            Total += Valor(tbM05) * 5;
            Total += Valor(tbM02) * 2;
            Total += Valor(tbM01);
            Total += Valor(tbM50C) / Convert.ToDecimal(2);
            Total += Valor(tbM20C) / Convert.ToDecimal(5);
            Total += Valor(tbM10C) / Convert.ToDecimal(10);
            Total += Valor(tbM05C) / Convert.ToDecimal(20);

            this.Total = Total;
            lblTotal.Text = "Total: " + Total.ToString("C2");
        }

        private void RichTextBox_TextLenghtChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            LlenarMoneyMoneyMoney();
            RecuperarRegistros(MoneyMoneyMoney, Total);
            Voluntario = true;
            Close();
        }

        private void LlenarMoneyMoneyMoney()
        {
            List<Efectivo> Money = new List<Efectivo>();
            if (Valor(tbB1000) > 0)
                Money.Add(new Efectivo(Denominacion.B1000, Valor(tbB1000)));
            if (Valor(tbB500) > 0)
                Money.Add(new Efectivo(Denominacion.B500, Valor(tbB500)));
            if (Valor(tbB200) > 0)
                Money.Add(new Efectivo(Denominacion.B200, Valor(tbB200)));
            if (Valor(tbB100) > 0)
                Money.Add(new Efectivo(Denominacion.B100, Valor(tbB100)));
            if (Valor(tbB50) > 0)
                Money.Add(new Efectivo(Denominacion.B50, Valor(tbB50)));
            if (Valor(tbB20) > 0)
                Money.Add(new Efectivo(Denominacion.B20, Valor(tbB20)));

            if (Valor(tbM10) > 0)
                Money.Add(new Efectivo(Denominacion.M10, Valor(tbM10)));
            if (Valor(tbM05) > 0)
                Money.Add(new Efectivo(Denominacion.M05, Valor(tbM05)));
            if (Valor(tbM02) > 0)
                Money.Add(new Efectivo(Denominacion.M02, Valor(tbM02)));
            if (Valor(tbM01) > 0)
                Money.Add(new Efectivo(Denominacion.M01, Valor(tbM01)));
            if (Valor(tbM50C) > 0)
                Money.Add(new Efectivo(Denominacion.M50C, Valor(tbM50C)));
            if (Valor(tbM20C) > 0)
                Money.Add(new Efectivo(Denominacion.M20C, Valor(tbM20C)));
            if (Valor(tbM10C) > 0)
                Money.Add(new Efectivo(Denominacion.M10C, Valor(tbM10C)));
            if (Valor(tbM05C) > 0)
                Money.Add(new Efectivo(Denominacion.M05C, Valor(tbM05C)));

            MoneyMoneyMoney = Money.ToArray();
        }

        private void LlenarFormConMoneyMoneyMoney(Efectivo[] Money)
        {
            if (Money != null)
            {
                for (int i = 0; i < Money.Length; i++)
                {
                    switch (Money[i].Tipo)
                    {
                        case Denominacion.B1000:
                            tbB1000.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.B500:
                            tbB500.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.B200:
                            tbB200.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.B100:
                            tbB100.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.B50:
                            tbB50.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.B20:
                            tbB20.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.M10:
                            tbM10.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.M05:
                            tbM05.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.M02:
                            tbM02.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.M01:
                            tbM01.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.M50C:
                            tbM50C.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.M20C:
                            tbM20C.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.M10C:
                            tbM10C.Text = Money[i].Valor.ToString();
                            break;
                        case Denominacion.M05C:
                            tbM05C.Text = Money[i].Valor.ToString();
                            break;
                    }
                }
            }
            CalcularTotal();
        }

        private void PantallaContarCorte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Voluntario)
            {
                switch (MessageBox.Show("¿Desea Guardar Los Cambios?", "AVISO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
                {
                    case DialogResult.None:
                    case DialogResult.Cancel:
                    case DialogResult.Abort:
                        e.Cancel = true;
                        break;
                    case DialogResult.No:
                    case DialogResult.Retry:
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                    case DialogResult.OK:
                        LlenarMoneyMoneyMoney();
                        RecuperarRegistros(MoneyMoneyMoney, Total);
                        break;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}