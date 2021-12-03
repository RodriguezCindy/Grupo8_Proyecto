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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            LoginController controlador = new LoginController(this);
        }
        private void mostrarcontraseña()
        {
            if (CheckMostrar.Checked == false)
            {
                txt_contrasena.PasswordChar = '*';
            }
            else if (txt_contrasena.Text != "")
            {
                txt_contrasena.PasswordChar = '\0';
            }
        }

        private void CheckMostrar_CheckedChanged(object sender, EventArgs e)
        {
            mostrarcontraseña();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
