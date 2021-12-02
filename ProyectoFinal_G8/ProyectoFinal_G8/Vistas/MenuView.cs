using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_G8.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2007Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ClienteView vista = new ClienteView();
            vista.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PaqueteView vista = new PaqueteView();
            vista.Show();
        }
    }
}
