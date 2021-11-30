using ProyectoFinal_G8.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal_G8
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginView());
        }
    }
}
