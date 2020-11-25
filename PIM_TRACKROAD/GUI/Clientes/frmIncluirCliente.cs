using Entidades.ViewModels;
using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD.GUI.Clientes
{
    public partial class frmIncluirCliente : Form
    {
        private readonly IClienteAppService _clienteApp;

        public frmIncluirCliente()
        {
            InitializeComponent();

            _clienteApp = new ClienteAppService();
        }

        // Eventos
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Voltar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarCliente();
                Voltar();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message, "Erro ao cadastrar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TeclaPresionada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // Métodos
        private void Voltar()
        {
            Hide();
            var form = new frmConsultarCliente();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        async private void AdicionarCliente()
        {
            var cliente = new ClienteViewModel
            {
                Id = 0,
                NomeFantasia = tbxNome.Text,
                RazaoSocial = tbxRazSoc.Text,
                Cnpj = tbxCpfCnpj.Text,
                RamoAtividade = tbxRamAtiv.Text,
                Endereco = tbxEndereco.Text,
                Numero = int.Parse(tbxNumero.Text),
                Bairro = tbxBairro.Text,
                Cidade = tbxCidade.Text,
                Estado = cbxEnderecoEstado.Text,
                Cep = tbxCep.Text
            };

            _clienteApp.Add(cliente);
        }

    }
}
