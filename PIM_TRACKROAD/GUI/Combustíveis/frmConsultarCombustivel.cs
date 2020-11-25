using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD
{
    public partial class frmConsultarCombustivel : Form
    {
        private readonly ICombustivelAppService _combustivelApp;

        public frmConsultarCombustivel()
        {
            InitializeComponent();

            _combustivelApp = new CombustivelAppService();

            GetAllCombustiveis();
            LimparSelecao();
        }

        // Eventos
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPesquisar.Text))
            {
                GetAllCombustiveis();
                return;
            }

            PesquisarCombustiveis(txbPesquisar.Text);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarBotoes("ATIVAR");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var idCombustivel = int.Parse(dgvCombustiveis.CurrentRow.Cells[0].Value.ToString());
                _combustivelApp.Delete(idCombustivel);

                ReloadForm();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var idCombustivel = int.Parse(dgvCombustiveis.CurrentRow.Cells[0].Value.ToString());

            Hide();
            var form = new frmAlterarCombustivel(idCombustivel);
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new frmIncluirCombustivel();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void frmConsultarCombustivel_Click(object sender, EventArgs e)
        {
            LimparSelecao();
        }

        private void TeclaPressionada_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se tecla ESC foi pressionada
            if ("27".Equals(Convert.ToString(e.KeyValue)))
            {
                LimparSelecao();
            }
        }

        // Métodos
        private async void GetAllCombustiveis()
        {
            dgvCombustiveis.DataSource = await _combustivelApp.GetAll();
        }
        private async void PesquisarCombustiveis(string pesquisa)
        {
            dgvCombustiveis.DataSource = await _combustivelApp.Search(pesquisa);
            LimparSelecao();
        }

        private void LimparSelecao()
        {
            dgvCombustiveis.ClearSelection();
            AlterarBotoes("DESATIVAR");
        }

        private void AlterarBotoes(string acao)
        {
            if (acao == "ATIVAR")
            {
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
            }

            if (acao == "DESATIVAR")
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }

            if (User.Tipo == 3)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnAdicionar.Enabled = false;
            }
        }

        private void ReloadForm()
        {
            txbPesquisar.Text = "";
            GetAllCombustiveis();
            LimparSelecao();
        }

    }
}
