using ProyectoFinal_G8.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_G8.Vistas
{
    public partial class ClienteView : Form
    {
        public ClienteView()
        {
            InitializeComponent();

            ClienteController controlador = new ClienteController(this);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
