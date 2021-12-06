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
   public class PaqueteController
    {
        PaqueteView vista;
        PaqueteDAO userDAO = new PaqueteDAO();
        Paquete user = new Paquete();
        String operacion = string.Empty;

        public PaqueteController(PaqueteView view)
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
            vista.txt_Descripcion.Focus();
        }
        //LISTA DE REPARTIDORES
        private void ListarPaquete()
        {
            vista.dataPaquete.DataSource = userDAO.GetPaquete();
        }

        //GUARDAR REPARTIDORES
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_Descripcion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Descripcion, "Ingrese la Direccion");
                vista.txt_Descripcion.Focus();
                return;
            }
            if (vista.txt_IdDestinatario.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_IdDestinatario, "Ingrese el id del destinatario");
                vista.txt_IdDestinatario.Focus();
                return;
            }
            if (vista.txt_Direccion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Direccion, "Ingrese la direccion");
                vista.txt_Direccion.Focus();
                return;
            }
            if (vista.txt_Telefono.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Telefono, "Ingrese el telefono");
                vista.txt_Telefono.Focus();
                return;
            }
            if (vista.txtPeso.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtPeso, "Ingrese el precio del paquete");
                vista.txtPeso.Focus();
                return;
            }

            user.Descripcion = vista.txt_Descripcion.Text;
            user.Direccion = vista.txt_Direccion.Text;
            user.Telefonocliente = Convert.ToInt32(vista.txt_Telefono.Text);
            user.Idcliente = Convert.ToInt32(vista.txt_IdDestinatario.Text);
            user.Pesolibras = Convert.ToDecimal(vista.txtPeso.Text);

            bool GuardarR = userDAO.GuardarPaquete(user);
            if (GuardarR)
            {
                DesabilitarControles();
                MessageBox.Show("Paquete Guardado Correctamente", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
                ListarPaquete();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Paquete", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //ELIMINAR REPARTIDOR
        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.dataPaquete.SelectedRows.Count > 0)
            {
                bool eliminado = userDAO.EliminarPaquete(Convert.ToInt32(vista.dataPaquete.CurrentRow.Cells[0].Value.ToString()));
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
            vista.txt_id.Enabled = false;
            vista.txtPeso.Enabled = true;
            vista.txt_Descripcion.Enabled = true;
            vista.txt_Direccion.Enabled = true;
            vista.txt_IdDestinatario.Enabled = true;
            vista.txt_Telefono.Enabled = true;

            vista.btn_cancelar.Enabled = true;
            vista.btn_guardar.Enabled = true;
            vista.btn_borrar.Enabled = true;
            vista.btn_nuevo.Enabled = false;
        }

        //DESABILITAR CONTROLES
        private void DesabilitarControles()
        {
            vista.txt_id.Enabled = false;
            vista.txtPeso.Enabled = false;
            vista.txt_Descripcion.Enabled = false;
            vista.txt_Direccion.Enabled = false;
            vista.txt_IdDestinatario.Enabled = false;
            vista.txt_Telefono.Enabled = false;

            vista.btn_nuevo.Enabled = true;
            vista.btn_cancelar.Enabled = false;
            vista.btn_guardar.Enabled = false;
            vista.btn_borrar.Enabled = true;
        }

        //HABILITAR CONTROLES
        private void LimpiarControles()
        {
            vista.txt_id.Clear();
            vista.txt_Descripcion.Clear();
            vista.txt_Direccion.Clear();
            vista.txtPeso.Clear();
            vista.txt_IdDestinatario.Clear();
            vista.txt_Telefono.Clear();
        }
    }
}

