using ConexionBaseDeDatos;
using Entidad;
using System.Windows.Forms;

namespace Control
{
    public sealed class ManejadorLogin : Manejador
    {
        private string user;
        private string pass;

        public ManejadorLogin()
        {
            Interface = new InterfaceBaseDeDatos();
        }

        public ManejadorLogin(Pantalla EnviaEvento) : this("", "", EnviaEvento) { }

        public ManejadorLogin(string Usuario, string Password) : this()
        {
            user = Usuario;
            pass = Password;
        }

        public ManejadorLogin(string Usuario, string Password, Pantalla EnviaEvento) : this(Usuario, Password)
        {
            Pantalla = EnviaEvento;
        }

        public string DesplegarPantallaMenuUsuario(string Login, string Password, Pantalla PantallaADesplegar)
        {
            string AccesoPermitido = "Usuario No Existe";
            if (PantallaADesplegar != null)
            {
                RegistroUsuario temp;
                Interface.RecuperarUsuario(Login, out temp);
                if (temp != null)
                {
                    if (temp.UsuarioActivo)
                    {
                        if (temp.ValidarContraseña(Password))
                        {
                            OcultarPantallaAgregarEvento(PantallaADesplegar);
                            PantallaADesplegar.Show();
                            AccesoPermitido = "Entrada Al Sistema";
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            AccesoPermitido = "Contraseña Incorrecta";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este usuario fue borrado con la autorización de un administrador", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        AccesoPermitido = "Usuario Borrado";
                    }
                }
            }
            return AccesoPermitido;
        }

        private void RegresarLogin()
        {
            Pantalla.Show();
        }

        private void Mostrar()
        {
            Pantalla.Show();
        }

        public void DesplegarPantallaRegistrarUsuario(string Usuario, Pantalla PantallaRegistroUsuario)
        {
            DesplegarPantallaDialog(PantallaRegistroUsuario);
        }

        public void DesplegarPantallaRecuerarContraseña(Pantalla PantallaRecuperarContraseña)
        {
            PantallaRecuperarContraseña.ShowDialog();
        }
    }
}
