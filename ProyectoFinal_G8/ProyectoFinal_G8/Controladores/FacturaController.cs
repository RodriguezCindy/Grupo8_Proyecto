using ProyectoFinal_G8.Modelos.DAO;
using ProyectoFinal_G8.Modelos.Entidades;
using ProyectoFinal_G8.Vistas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_G8.Controladores
{
    public class FacturaController: Conexion
    {
        FacturaView vista;
        FacturaDAO userDAO = new FacturaDAO();
        Factura user = new Factura();
        String operacion = string.Empty;
        ComboBoxDAO CargarCombo = new ComboBoxDAO();


        public FacturaController(FacturaView view)
        {
            vista = view;
            vista.btnnuevo.Click += new EventHandler(Nuevo);
            vista.btnguardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.cb_nombre.SelectedIndexChanged += new EventHandler(TreaerCliente);

        }
        private void ReiniciarCombo()
        {
            vista.cb_nombre.Text = "Seleccione El Cliente";
            vista.txt_id.Text = " ";
            vista.txtDireccion.Text = " ";

        }
        private void TreaerCliente(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTE WHERE NOMBRE='" + vista.cb_nombre.Text + "'", MiConexion);
            MiConexion.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read() == true)
            {
                vista.txtDireccion.Text = dr["DIRECCION"].ToString();
                vista.txt_id.Text = dr["ID"].ToString();
            }
            MiConexion.Close();
        }
        private void Load(object sender, EventArgs e)
        {
            ListarCliente();
            ReiniciarCombo();
        }
        private void Nuevo(object sender, EventArgs e)
         {
            HabilitarControles();
            operacion = "Nuevo";
        }
        //LISTA DE FACTURAS
        private void ListarFactura()
        {
            vista.dataFactura.DataSource = userDAO.GetFactura();
        }

        //GUARDAR FACTURA
        private void Guardar(object sender, EventArgs e)
        {

            if (vista.cb_nombre.Text == "")
            {
                vista.errorProvider1.SetError(vista.cb_nombre, "Ingrese el id del destinatario");
                vista.cb_nombre.Focus();
                return;
            }
            if (vista.txtNumPaquete.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtNumPaquete, "Ingrese la Direccion");
                vista.txtNumPaquete.Focus();
                return;
            }
            if (vista.dateTimePicker1.Text == "")
            {
                vista.errorProvider1.SetError(vista.dateTimePicker1, "Ingrese la direccion");
                vista.dateTimePicker1.Focus();
                return;
            }
            if (vista.txtDireccion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtDireccion, "Ingrese el telefono");
                vista.txtDireccion.Focus();
                return;
            }
            if (vista.txtSubtotal.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtSubtotal, "Ingrese el precio del paquete");
                vista.txtSubtotal.Focus();
                return;
            }
           

            user.IdCliente = Convert.ToInt32(vista.txt_id.Text);
            user.NumeroPaquete = Convert.ToInt32( vista.txtNumPaquete.Text);
            user.Fecha =Convert.ToDateTime( vista.dateTimePicker1.Text);
            user.Direccion = vista.txtDireccion.Text;
            user.Subtotal = Convert.ToInt32(vista.txtSubtotal.Text);
            user.Total = Convert.ToInt32(vista.txtTotal.Text);

            bool GuardarR = userDAO.GuardarFactura(user);
            if (GuardarR)
            {
                DesabilitarControles();
                MessageBox.Show("Factura Guardada Correctamente", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
                ListarFactura();
            }
            else
            {
                MessageBox.Show("No se pudo guardar la Factura", "Atenciòn", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //HABILITAR CONTROLES
        private void HabilitarControles()
        {

            vista.txtNumPaquete.Enabled = true;
            vista.txtSubtotal.Enabled = true;
            vista.dateTimePicker1.Enabled = true;
            vista.cb_nombre.Enabled = true;
            vista.txtTotal.Enabled = true;

            vista.btncancelar.Enabled = true;
            vista.btnguardar.Enabled = true;
            vista.btnnuevo.Enabled = false;
        }
        //DESABILITAR CONTROLES
        private void DesabilitarControles()
        {
            vista.txtNumPaquete.Enabled = false;
            vista.txtSubtotal.Enabled = false;
            vista.cb_nombre.Enabled = false;
            vista.txtTotal.Enabled = false;
            vista.dateTimePicker1.Enabled = false;

            vista.btnnuevo.Enabled = true;
            vista.btncancelar.Enabled = false;
            vista.btnguardar.Enabled = false;
        }
        //LIMPIAR CONTROLES
        private void LimpiarControles()
        {
            vista.txtNumPaquete.Clear();
            vista.txt_id.Clear();
            vista.txtSubtotal.Clear();
            vista.cb_nombre.Text = "";
            vista.txtTotal.Clear();
        }
        private void ListarCliente()
        {
            vista.cb_nombre.DataSource = CargarCombo.ListarCliente();
            vista.cb_nombre.DisplayMember = "NOMBRE";
            vista.cb_nombre.ValueMember = "ID";

        }
    }
}
