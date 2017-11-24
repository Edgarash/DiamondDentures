using System;
using System.Drawing;
using System.Windows.Forms;

namespace Control
{
    public partial class Pantalla : Form
    {
        public delegate void Regresar();
        public event Regresar Cerrar;
        public Pantalla()
        {
            InitializeComponent();
        }
        protected virtual void btnMouseOver(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            temp.Cursor = Cursors.Hand;
            temp.Location = new System.Drawing.Point(temp.Location.X - 5, temp.Location.Y - 5);
            temp.Size = new System.Drawing.Size(temp.Width + 10, temp.Height + 10);
        }
        protected virtual void btnMouseLeft(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            temp.Location = new System.Drawing.Point(temp.Location.X + 5, temp.Location.Y + 5);
            temp.Size = new System.Drawing.Size(temp.Width - 10, temp.Height - 10);
        }
        protected void LlamarEventoCerrar()
        {
            Cerrar();
        }
        protected virtual void SeleccionarSiguiente(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.SelectNextControl(sender as System.Windows.Forms.Control, true, true, true, true);
            }
        }

        protected virtual void InitializeComponent2()
        {
            Type temp = new Button().GetType();
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].GetType() == temp)
                {
                    Controls[i].MouseEnter += btnMouseOver;
                    Controls[i].MouseLeave += btnMouseLeft;
                }
            }
        }

        protected virtual void AlinearCentroHorizontal(params System.Windows.Forms.Control [] x)
        {
            for (int i = 0; i < x.Length; i++)
                x[i].Location = new Point(this.Width / 2 - x[i].Width / 2 - 13, x[i].Location.Y);
        }
    }
}
