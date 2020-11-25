using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD
{
    public partial class frmConsultarUsuario : Form
    {
        private readonly IUsuarioAppService _usuarioApp;

        public frmConsultarUsuario()
        {
            InitializeComponent();

            _usuarioApp = new UsuarioAppService();

            GetAllUsuarios();
            LimparSelecao();
        }

        // Eventos
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPesquisar.Text))
            {
                GetAllUsuarios();
                return;
            }

            PesquisarUsuarios(txbPesquisar.Text);
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
                var idUsuario = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                _usuarioApp.Delete(idUsuario);

                ReloadForm();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var idUsuario = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());

            Hide();
            var form = new frmAlterarUsuario(idUsuario);
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new frmIncluirUsuario();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void frmConsultarUsuario_Click(object sender, EventArgs e)
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
        private async void GetAllUsuarios()
        {
            dgvUsuarios.DataSource = await _usuarioApp.GetAll();
        }

        private async void PesquisarUsuarios(string pesquisa)
        {
            dgvUsuarios.DataSource = await _usuarioApp.Search(pesquisa);
            LimparSelecao();
        }

        private void LimparSelecao()
        {
            dgvUsuarios.ClearSelection();
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

            if (User.Tipo == 5)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnAdicionar.Enabled = false;
            }
        }

        private void ReloadForm()
        {
            txbPesquisar.Text = "";
            GetAllUsuarios();
            LimparSelecao();
        }

    }
}
