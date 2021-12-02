using ProyectoFinal_G8.Modelos.DAO;
using ProyectoFinal_G8.Modelos.Entidades;
using ProyectoFinal_G8.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_G8.Controladores
{
    public class ClientesController
    {
        ClienteView vista;
        String operacion = string.Empty;
        ClienteDAO userDAO = new ClienteDAO();
        Cliente user = new Cliente();
        public ClientesController(ClienteView view)
        {
            vista = view;
            vista.btn_nuevo.Click += new EventHandler(Nuevo);
            vista.btn_guardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);

        }
        private void Load(object sender, EventArgs e)
        {
            ListarCliente();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_nombre.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_nombre, "Ingrese el nombre");
                vista.txt_nombre.Focus();
                return;
            }
            if (vista.txt_telefono.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_telefono, "Ingrese un nùmero de telefono");
                vista.txt_telefono.Focus();
                return;
            }
            if (vista.txt_email.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_email, "Ingrese un email");
                vista.txt_email.Focus();
                return;
            }
            if (vista.txt_direccion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_email, "Ingrese la direccion");
                vista.txt_direccion.Focus();
                return;
            }

            user.Nombre = vista.txt_nombre.Text;
            user.Email = vista.txt_email.Text;
            user.Telefono = vista.txt_telefono.Text;
            user.Direccion = vista.txt_direccion.Text;
            bool insertar = userDAO.GuardarCliente(user);

            if (insertar)
            {
                DesabilitarControles();
                MessageBox.Show("Cliente Guardado Correctamente", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
                ListarCliente();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //LISTA DE CLIENTES
        private void ListarCliente()
        {
            vista.DATACLIENTE.DataSource = userDAO.GetUsuario();
        }
        //HABILITAR CONTROLES
        private void HabilitarControles()
        {
            vista.txt_id.Enabled = true;
            vista.txt_nombre.Enabled = true;
            vista.txt_telefono.Enabled = true;
            vista.txt_email.Enabled = true;
            vista.txt_direccion.Enabled = true;

            vista.btn_cancelar.Enabled = true;
            vista.btn_guardar.Enabled = true;
            vista.btn_borrar.Enabled = true;
            vista.btn_nuevo.Enabled = false;
        }

        //DESABILITAR CONTROLES
        private void DesabilitarControles()
        {
            vista.txt_id.Enabled = false;
            vista.txt_nombre.Enabled = false;
            vista.txt_telefono.Enabled = false;
            vista.txt_email.Enabled = false;
            vista.txt_direccion.Enabled = false;

            vista.btn_cancelar.Enabled = false;
            vista.btn_guardar.Enabled = false;
            vista.btn_borrar.Enabled = true;
            vista.btn_nuevo.Enabled = true;
        }

        //HABILITAR CONTROLES
        private void LimpiarControles()
        {
            vista.txt_id.Clear();
            vista.txt_nombre.Clear();
            vista.txt_telefono.Clear();
            vista.txt_email.Clear();
            vista.txt_direccion.Clear();

        }

    }
}
