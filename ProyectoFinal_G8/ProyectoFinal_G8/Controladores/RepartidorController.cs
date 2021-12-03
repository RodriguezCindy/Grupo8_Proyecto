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
    public class RepartidorController
    {
        RepartidorView vista;
        RepartidorDAO userDAO = new RepartidorDAO();
        Repartidor user = new Repartidor();
        String operacion = string.Empty;

        public RepartidorController(RepartidorView view)
        {
            vista = view;
            vista.btn_nuevo.Click += new EventHandler(Nuevo);
            vista.btn_guardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.btn_borrar.Click += new EventHandler(Eliminar);
        }

        private void Load(object sender, EventArgs e)
        {
            ListarRepartidor();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        //LISTA DE REPARTIDORES
        private void ListarRepartidor()
        {
            vista.dataRepartidor.DataSource = userDAO.GetRepartidor();
        }

        //GUARDAR REPARTIDORES
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_dni.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_dni, "Ingrese su nùmero de identificaciòn");
                vista.txt_dni.Focus();
                return;
            }
            if (vista.txt_nombre.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_nombre, "Ingrese un nombre");
                vista.txt_nombre.Focus();
                return;
            }
            if (vista.txt_telefono.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_telefono, "Ingrese un nùmero de telefono");
                vista.txt_telefono.Focus();
                return;
            }

            user.Dni = Convert.ToInt32(vista.txt_dni.Text);
            user.Nombre = vista.txt_nombre.Text;
            user.Telefono = Convert.ToInt32(vista.txt_telefono.Text);

            bool GuardarR = userDAO.GuardarRepartidor(user);
            if (GuardarR)
            {
                DesabilitarControles();
                MessageBox.Show("Repartidor Guardado Correctamente", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
                ListarRepartidor();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Repartidor", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //ELIMINAR REPARTIDOR
        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.dataRepartidor.SelectedRows.Count > 0)
            {
                bool eliminado = userDAO.EliminarRepartidor(Convert.ToInt32(vista.dataRepartidor.CurrentRow.Cells[0].Value.ToString()));
                if (eliminado)
                {

                    MessageBox.Show("Repartidor Eliminado Exitosamente", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarRepartidor();
                    DesabilitarControles();
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("El Repartidor No Fue Eliminado", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        //HABILITAR CONTROLES
        private void HabilitarControles()
        {
            vista.txt_id.Enabled = true;
            vista.txt_nombre.Enabled = true;
            vista.txt_telefono.Enabled = true;

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

          vista.btn_nuevo.Enabled = true;
            vista.btn_cancelar.Enabled = false;
            vista.btn_guardar.Enabled = false;
            vista.btn_borrar.Enabled = true;
        }

        //HABILITAR CONTROLES
        private void LimpiarControles()
        {
            vista.txt_id.Clear();
            vista.txt_nombre.Clear();
            vista.txt_telefono.Clear();
        }
    }
}
