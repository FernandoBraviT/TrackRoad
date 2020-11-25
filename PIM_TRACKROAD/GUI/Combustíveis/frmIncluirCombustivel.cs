using Entidades;
using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD
{
    public partial class frmIncluirCombustivel : Form
    {
        private readonly ICombustivelAppService _combustivelApp;

        public frmIncluirCombustivel()
        {
            InitializeComponent();
            _combustivelApp = new CombustivelAppService();
        }

        // Eventos
        private void tbxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarCombustivel();
                Voltar();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Erro ao cadastrar combustível", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos
        private void Voltar()
        {
            Hide();
            var form = new frmConsultarCombustivel();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private async void AdicionarCombustivel()
        {
            var combustivel = new Combustivel
            {
                Id = 0,
                Nome = tbxNome.Text,
                Preco = double.Parse(tbxPreco.Text)
            };

            await _combustivelApp.Add(combustivel);
        }

    }
}
