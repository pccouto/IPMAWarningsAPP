using System;
using System.Windows.Forms;
using IPMAWarningsApp.Views;

namespace IPMAWarningsApp
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView()); // Certifique-se de que MainView está sendo usado aqui
        }
    }
}
