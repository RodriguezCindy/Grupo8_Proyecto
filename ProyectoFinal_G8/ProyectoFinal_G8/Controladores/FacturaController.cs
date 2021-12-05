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
    class FacturaController
    {
        FacturaView vista;
        FacturaDAO userDAO = new FacturaDAO();
        Factura user = new Factura();
        String operacion = string.Empty;
        public FacturaController(FacturaView view)
        {
            vista = view;
            vista.btn_nuevo.Click += new EventHandler(Nuevo);
            vista.btn_guardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.btn_borrar.Click += new EventHandler(Eliminar);

        }
        private void Load(object sender, EventArgs e)
        {
            ListarPaquete();
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
            if (vista.txt_email.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_email, "Ingrese un email");
                vista.txt_email.Focus();
                return;
            }
            if (vista.txt_telefono.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_telefono, "Ingrese un nùmero de telefono");
                vista.txt_telefono.Focus();
                return;
            }
            if (vista.txtDepartamento.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtDepartamento, "Ingrese el departamento");
                vista.txtDepartamento.Focus();
                return;
            }
            if (vista.txtDireccion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtDireccion, "Ingrese la direccion");
                vista.txtDireccion.Focus();
                return;
            }
            if (vista.txtCiudad.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtCiudad, "Ingrese la ciudad");
                vista.txtCiudad.Focus();
                return;
            }
            if (vista.txtPeso.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtPeso, "Ingrese el peso en lb");
                vista.txtPeso.Focus();
                return;
            }
            user.Nombre_Desti = vista.txt_nombre.Text;
            user.Email = vista.txt_email.Text;
            user.Telefono = Convert.ToInt32(vista.txt_telefono.Text);
            user.Departamento = vista.txtDepartamento.Text;
            user.Ciudad = vista.txtCiudad.Text;
            user.Direccion = vista.txtDireccion.Text;
            user.Peso = Convert.ToDouble(vista.txtPeso.Text);

            bool GuardarP = userDAO.GuardarPaquete(user);
            if (GuardarP)
            {
                DesabilitarControles();
                MessageBox.Show("Paquete Guardado Correctamente", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
                ListarPaquete();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el paquete", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //LISTA DE CLIENTES
        private void ListarPaquete()
        {
            vista.DATACLIENTE.DataSource = userDAO.GetPaquete();
        }

        //ELIMINAR CLIENTE
        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.DATACLIENTE.SelectedRows.Count > 0)
            {
                bool eliminado = userDAO.EliminarPaquete(Convert.ToInt32(vista.DATACLIENTE.CurrentRow.Cells[0].Value.ToString()));
                if (eliminado)
                {

                    MessageBox.Show("Paquete Eliminado Exitosamente", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarPaquete();
                    DesabilitarControles();
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("El Paquete No Fue Eliminado", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        //HABILITAR CONTROLES
        private void HabilitarControles()
        {
            vista.txt_id.Enabled = true;
            vista.txt_nombre.Enabled = true;
            vista.txt_telefono.Enabled = true;
            vista.txt_email.Enabled = true;
            vista.txtDepartamento.Enabled = true;
            vista.txtCiudad.Enabled = true;
            vista.txtDireccion.Enabled = true;
            vista.txtPeso.Enabled = true;

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
            vista.txtDepartamento.Enabled = false;
            vista.txtCiudad.Enabled = false;
            vista.txtDireccion.Enabled = false;
            vista.txtPeso.Enabled = false;

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
            vista.txtDepartamento.Clear();
            vista.txtCiudad.Clear();
            vista.txtDireccion.Clear();
            vista.txtPeso.Clear();

        }
    }
}
