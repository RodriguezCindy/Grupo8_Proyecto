using ProyectoFinal_G8.Vistas;
using ProyectoFinal_G8.Modelos.DAO;
using ProyectoFinal_G8.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ProyectoFinal_G8.Controladores
{
    public class LoginController
    {
        LoginView vista;
        public LoginController(LoginView view)
        {
           vista = view;
           vista.btn_aceptar.Click += new EventHandler(ValidarUsuario);
        }

        private void ValidarUsuario(Object sender, EventArgs e)
        {
            bool esValido = false;
            UsuarioDAO userDAO = new UsuarioDAO();
            Usuario user = new Usuario();

            user.Email = vista.txt_email.Text;
            user.Clave = EncriptarClave(vista.txt_contrasena.Text);

            esValido = userDAO.ValidarUsuario(user);

            if (esValido)
            {
                //MenuView menu = new MenuView();
                //vista.Hide();
                //menu.Show();
                MessageBox.Show("Usuario correcto");
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }

        public static string EncriptarClave(string str)
            {
                string cadena = str + "MiClavePersonal";
                SHA256 sha256 = SHA256Managed.Create();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] stream = null;
                StringBuilder sb = new StringBuilder();
                stream = sha256.ComputeHash(encoding.GetBytes(str));
                for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                return sb.ToString();
            }
    }
}
