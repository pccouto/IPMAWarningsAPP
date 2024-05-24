using System;
using System.Windows.Forms;
using IPMAWarningsApp.Views; // Certifique-se de que o namespace está correto

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
            Application.Run(new Form1()); // Certifique-se de que a classe Form1 está no namespace correto
        }
    }
}
