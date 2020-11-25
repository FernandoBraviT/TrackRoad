using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD
{
    public partial class frmConsultarMotorista : Form
    {
        private readonly IMotoristaAppService _motoristaApp;

        public frmConsultarMotorista()
        {
            InitializeComponent();

            _motoristaApp = new MotoristaAppService();
            GetAllMotoristas();
        }

        // Eventos
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPesquisar.Text))
            {
                GetAllMotoristas();
                return;
            }

            PesquisarMotoristas(txbPesquisar.Text);
        }

        private void dgvMotoristas_CellClick(object sender, DataGridViewCellEventArgs e)
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
                var idMotorista = int.Parse(dgvMotoristas.CurrentRow.Cells[0].Value.ToString());
                _motoristaApp.Delete(idMotorista);

                ReloadForm();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var idMotorista = int.Parse(dgvMotoristas.CurrentRow.Cells[0].Value.ToString());

            Hide();
            var form = new frmAlterarMotorista(idMotorista);
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new frmIncluirMotorista();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void frmConsultarMotorista_Click(object sender, EventArgs e)
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
        private async void GetAllMotoristas()
        {
            dgvMotoristas.DataSource = await _motoristaApp.GetAll();
        }

        private async void PesquisarMotoristas(string pesquisa)
        {
            dgvMotoristas.DataSource = await _motoristaApp.Search(pesquisa);
            LimparSelecao();
        }

        private void LimparSelecao()
        {
            dgvMotoristas.ClearSelection();
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
            GetAllMotoristas();
            LimparSelecao();
        }

    }
}
