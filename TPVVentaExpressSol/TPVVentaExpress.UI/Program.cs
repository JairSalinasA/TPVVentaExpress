﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPVVentaExpress.UI.Forms;
using TPVVentaExpress.UI.Forms.Login;

namespace TPVVentaExpress.UI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new LoginForm());
            Application.Run(new RecoveryPassword()); 
        }
    }
}
