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
    public partial class Form1 : Form
    {
        private readonly IPMAController _controller;
        private List<Aviso> _allAvisos;

        public Form1()
        {
            InitializeComponent();
            var apiCaller = new RestSharpCaller("https://api.ipma.pt/open-data/");
            _controller = new IPMAController(apiCaller);
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se você precisa carregar dados ou executar alguma lógica ao carregar o formulário, adicione aqui
            // Exemplo: Carregar informações iniciais ou configurar o estado do formulário
        }

        private async void btnFetchData_Click(object sender, EventArgs e)
        {
            try
            {
                _allAvisos = await _controller.GetWarningsAsync();
                dataGridView1.DataSource = _allAvisos;

                // Preencher o ComboBox com valores únicos de IdAreaAviso
                var idAreaAvisos = _allAvisos.Select(a => a.IdAreaAviso).Distinct().ToList();
                comboBoxIdAreaAviso.Items.Clear();
                comboBoxIdAreaAviso.Items.AddRange(idAreaAvisos.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar dados: {ex.Message}");
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
    }
}
