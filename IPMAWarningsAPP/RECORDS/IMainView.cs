using IPMAWarningsApp.Controllers;
using IPMAWarningsApp.Models;
using System.Collections.Generic;

namespace IPMAWarningsApp.Views
{
    public interface IMainView
    {
        void SetController(IPMAController controller);
        void DisplayWarnings(List<Aviso> avisos);
        void PopulateIdAreaAvisoComboBox(List<string> idAreaAvisos);
        void ShowError(string message);
    }
}
