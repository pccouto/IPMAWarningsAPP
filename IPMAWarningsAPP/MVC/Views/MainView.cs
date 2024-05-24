using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPMAWarningsApp.Controllers;
using IPMAWarningsApp.Models;
using IPMAWarningsApp.API;

namespace IPMAWarningsApp.Views
{
    public partial class MainView : Form, IMainView
    {
        private IPMAController _controller;
        private List<Aviso> _allAvisos;

        public MainView()
        {
            InitializeComponent();
        }

        public void SetController(IPMAController controller)
        {
            _controller = controller;
        }

        public void DisplayWarnings(List<Aviso> avisos)
        {
            _allAvisos = avisos;
            dataGridView1.DataSource = _allAvisos;
        }

        public void PopulateIdAreaAvisoComboBox(List<string> idAreaAvisos)
        {
            comboBoxIdAreaAviso.Items.Clear();
            comboBoxIdAreaAviso.Items.AddRange(idAreaAvisos.ToArray());
        }

        public void ShowError(string message)
        {
            MessageBox.Show($"Erro: {message}");
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // Inicialização de dados, se necessário
        }

        private async void btnFetchData_Click(object sender, EventArgs e)
        {
            try
            {
                var avisos = await _controller.GetWarningsAsync();
                DisplayWarnings(avisos);

                // Preencher o ComboBox com valores únicos de IdAreaAviso
                var idAreaAvisos = avisos.Select(a => a.IdAreaAviso).Distinct().ToList();
                PopulateIdAreaAvisoComboBox(idAreaAvisos);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void comboBoxIdAreaAviso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdAreaAviso.SelectedItem != null)
            {
                var selectedIdAreaAviso = comboBoxIdAreaAviso.SelectedItem.ToString();
                var filteredAvisos = _allAvisos.Where(a => a.IdAreaAviso == selectedIdAreaAviso).ToList();
                dataGridView1.DataSource = filteredAvisos;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para manipular o evento CellContentClick, se necessário
        }
    }
}
