using PIM_TRACKROAD.GUI.Clientes;
using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD
{
    public partial class frmConsultarCliente : Form
    {
        private readonly IClienteAppService _clienteApp;

        public frmConsultarCliente()
        {
            InitializeComponent();

            _clienteApp = new ClienteAppService();

            GetAllClientes();
            LimparSelecao();
        }

        // Eventos
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPesquisar.Text))
            {
                GetAllClientes();
                return;
            }

            PesquisarClientes(txbPesquisar.Text);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarBotoes("ATIVAR");
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var idCliente = int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString());
                _clienteApp.Delete(idCliente);

                ReloadForm();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var idCliente = int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString());

            Hide();
            var form = new frmAlterarCliente(idCliente);
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new frmIncluirCliente();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private void frmConsultarCliente_Click(object sender, EventArgs e)
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
        private void GetAllClientes()
        {
            dgvClientes.DataSource = _clienteApp.GetAll();
        }

        private void PesquisarClientes(string pesquisa)
        {
            dgvClientes.DataSource = _clienteApp.Search(pesquisa);
            LimparSelecao();
        }

        private void LimparSelecao()
        {
            dgvClientes.ClearSelection();
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

            if(User.Tipo == 5)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnAdicionar.Enabled = false;
            }
        }

        private void ReloadForm()
        {
            txbPesquisar.Text = "";
            GetAllClientes();
            LimparSelecao();
        }

    }
}
