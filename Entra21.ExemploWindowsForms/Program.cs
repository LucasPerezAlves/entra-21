using Entra21.ExemploWindowsForms.Exemplo01;
using System;
using System.Windows.Forms;

namespace Entra21.ExemploWindowsForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PacientesForms());
        }
    }
}
