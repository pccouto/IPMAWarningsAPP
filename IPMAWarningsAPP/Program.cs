using System;
using System.Windows.Forms;
using IPMAWarningsApp.Views;
using IPMAWarningsApp.Controllers;
using IPMAWarningsApp.API;

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

            // Inicializar a API Caller
            var apiCaller = new RestSharpCaller("https://api.ipma.pt/open-data/");

            // Inicializar a View e o Controller
            MainView mainView = new MainView();
            IPMAController controller = new IPMAController(apiCaller, mainView);

            // Iniciar a aplicação com a MainView
            Application.Run(mainView);
        }
    }
}
