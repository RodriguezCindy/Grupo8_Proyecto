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
        ClienteView vistaC;
        PaqueteView vistaP;
        RepartidorView vistaR;
        FacturaView vistaF;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (vistaC == null)
            {
                vistaC = new ClienteView();
                vistaC.MdiParent = this;
                vistaC.FormClosed += Vista_FormClosed;
                vistaC.Show();
            }
            else
            {
                vistaC.Activate();
            }
        }

        private void Vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaC = null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (vistaP == null)
            {
                vistaP = new PaqueteView();
                vistaP.MdiParent = this;
                vistaP.FormClosed += VistaP_FormClosed;
                vistaP.Show();
            }
            else
            {
                vistaP.Activate();
            }
        }

        private void VistaP_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaP = null;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (vistaR == null)
            {
                vistaR = new RepartidorView();
                vistaR.MdiParent = this;
                vistaR.FormClosed += VistaR_FormClosed;
                vistaR.Show();
            }
            else
            {
                vistaR.Activate();
            }
        }

        private void VistaR_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaR = null;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (vistaF == null)
            {
                vistaF = new FacturaView();
                vistaF.MdiParent = this;
              //  vistaF.FormClosed += VistaF_FormClosed;
                vistaF.Show();
            }
            else
            {
                vistaF.Activate();
            }
        }

       
    }
}
