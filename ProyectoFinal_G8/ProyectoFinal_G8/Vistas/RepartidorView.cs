﻿using ProyectoFinal_G8.Controladores;
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
    public partial class RepartidorView : Form
    {
        public RepartidorView()
        {
            InitializeComponent();
            RepartidorController controlador = new RepartidorController(this);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
