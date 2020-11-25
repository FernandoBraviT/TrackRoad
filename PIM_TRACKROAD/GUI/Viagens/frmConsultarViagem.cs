using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD
{
    public partial class frmConsultarViagem : Form
    {
        private readonly IViagemAppService _viagemApp;

        public frmConsultarViagem()
        {
            InitializeComponent();

            _viagemApp = new ViagemAppService();

            GetAllViagens();
            LimparSelecao();
        }

        // Eventos
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPesquisar.Text))
            {
                GetAllViagens();
                return;
            }

            PesquisarViagens(txbPesquisar.Text);
        }

        private void dgvViagens_CellClick(object sender, DataGridViewCellEventArgs e)
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
                var idViagem = int.Parse(dgvViagens.CurrentRow.Cells[0].Value.ToString());
                _viagemApp.Delete(idViagem);

                ReloadForm();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var idViagem = int.Parse(dgvViagens.CurrentRow.Cells[0].Value.ToString());

            Hide();
            var form = new frmAlterarViagem(idViagem);
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new frmIncluirViagem();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void frmConsultarViagem_Click(object sender, EventArgs e)
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
        private async void GetAllViagens()
        {
            dgvViagens.DataSource = await _viagemApp.GetAll();
        }

        private async void PesquisarViagens(string pesquisa)
        {
            dgvViagens.DataSource = await _viagemApp.Search(pesquisa);
            LimparSelecao();
        }

        private void LimparSelecao()
        {
            dgvViagens.ClearSelection();
            AlterarBotoes("DESATIVAR");
        }

        private void AlterarBotoes(string acao)
        {
            if (acao == "ATIVAR" && User.Tipo != 4)
            {
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
            }

            if (acao == "DESATIVAR")
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
        }

        private void ReloadForm()
        {
            txbPesquisar.Text = "";
            GetAllViagens();
            LimparSelecao();
        }

    }
}
