using Control;
using Entidad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Recepcion
{
    public class Trabajo : Panel
    {
        public ComboBox Producto { get; set; }
        public ComboBox Material1 { get; set; }
        public ComboBox Material2 { get; set; }
        public Label FechadeEntrega { get; set; }
        public Label PrecioProducto { get; set; }
        public DateTime Fecha { get; set; }
        public float Precio { get; set; }
        public bool Terminado { get; set; }
        public Trabajo()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Producto = new ComboBox();
            Material1 = new ComboBox();
            Material2 = new ComboBox();
            FechadeEntrega = new Label();
            PrecioProducto = new Label();
            Precio = 0;
            Terminado = false;
            ///Productos
            Producto.Size = new Size(150, 23);
            Producto.DropDownStyle = ComboBoxStyle.DropDownList;
            ///Material1
            Material1.Size = new Size(150, 23);
            Material1.Location = new Point(Producto.Width + 30);
            Material1.Visible = false;
            Material1.DropDownStyle = ComboBoxStyle.DropDownList;
            ///Material2
            Material2.Size = new Size(150, 23);
            Material2.Location = new Point(Material1.Location.X + Material1.Width + 30);
            Material2.Visible = false;
            Material2.DropDownStyle = ComboBoxStyle.DropDownList;
            ///FechaEntrega
            FechadeEntrega.Size = new Size(50, 23);
            FechadeEntrega.Location = new Point(Material2.Location.X + Material2.Width + 30);
            ///PrecioProducto
            PrecioProducto.Size = new Size(100, 23);
            PrecioProducto.Location = new Point(FechadeEntrega.Location.X + FechadeEntrega.Width + 30);
            ///Panel
            Controls.Add(Producto);
            Controls.Add(Material1);
            Controls.Add(Material2);
            Controls.Add(FechadeEntrega);
            Controls.Add(PrecioProducto);
            Size = new Size(700, 30);
        }
    }
}