using System;
using System.Windows.Forms;
using Simulacion_TP7;

namespace Simulacion_TP7
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
            Application.Run(new tp7_window());
        }
    }
}
