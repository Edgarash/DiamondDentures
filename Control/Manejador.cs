using System;
using ConexionBaseDeDatos;
using Entidad;

namespace Control
{
    public abstract class Manejador
    {
        protected InterfaceBaseDeDatos Interface;
        protected Pantalla Pantalla;

        public Manejador() { }

        public Manejador(Pantalla EnviaEvento)
        {
            Pantalla = EnviaEvento;
        }

        public void DesplegarPantalla(Pantalla PantallaADesplegar)
        {
            if (PantallaADesplegar != null)
            {
                OcultarPantallaAgregarEvento(PantallaADesplegar);
                PantallaADesplegar.Show();
            }
        }

        public void DesplegarPantallaDialog(Pantalla PantallaADesplegar)
        {
            if (PantallaADesplegar != null)
            {
                OcultarPantallaAgregarEvento(PantallaADesplegar);
                PantallaADesplegar.ShowDialog();
            }
        }

        private void AbrirPantalla()
        {
            if (Pantalla != null)
            {
                Pantalla.Show();
            }
        }

        protected void OcultarPantallaAgregarEvento(Pantalla PantallaADesplegar)
        {
            if (Pantalla != null)
            {
                Pantalla.Hide();
            }
            PantallaADesplegar.Cerrar += new Pantalla.Regresar(AbrirPantalla);
        }
    }
}
