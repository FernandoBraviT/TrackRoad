using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD
{
    public partial class frmConsultarContratos : Form
    {
        private readonly IContratoAppService _contratoApp;

        public frmConsultarContratos()
        {
            InitializeComponent();

            _contratoApp = new ContratoAppService();
            GetAllContratos();
        }

        // Eventos
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPesquisar.Text))
            {
                GetAllContratos();
                return;
            }

            PesquisarContratos(txbPesquisar.Text);
        }

        private void dgvContratos_CellClick(object sender, DataGridViewCellEventArgs e)
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
                var idContrato = int.Parse(dgvContratos.CurrentRow.Cells[0].Value.ToString());
                _contratoApp.Delete(idContrato);

                ReloadForm();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var idContrato = int.Parse(dgvContratos.CurrentRow.Cells[0].Value.ToString());

            Hide();
            var form = new frmAlterarContratos(idContrato);
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new frmIncluirContratos();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void frmConsultarContrato_Click(object sender, EventArgs e)
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
        private async void GetAllContratos()
        {
            dgvContratos.DataSource = await _contratoApp.GetAll();
        }
        private async void PesquisarContratos(string pesquisa)
        {
            dgvContratos.DataSource = await _contratoApp.Search(pesquisa);
            LimparSelecao();
        }

        private void LimparSelecao()
        {
            dgvContratos.ClearSelection();
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
        }

        private void ReloadForm()
        {
            txbPesquisar.Text = "";
            GetAllContratos();
            LimparSelecao();
        }

    }
}
