using Entidades;
using Entidades.ViewModels;
using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD.GUI.Clientes
{
    public partial class frmAlterarCliente : Form
    {
        private readonly IClienteAppService _clienteApp;
        private ClienteViewModel cliente;

        public frmAlterarCliente(int idCliente)
        {
            InitializeComponent();

            _clienteApp = new ClienteAppService();
            BuscarCliente(idCliente);
        }

        // Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                AlterarCliente();
                Voltar();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Erro ao alterar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos
        private void BuscarCliente(int idCliente)
        {
            this.cliente = _clienteApp.Get(idCliente);
            MostrarCliente();
        }

        private void MostrarCliente()
        {
            tbxNome.Text = cliente.NomeFantasia;
            tbxRazSoc.Text = cliente.RazaoSocial;
            tbxCpfCnpj.Text = cliente.Cnpj;
            tbxRamAtiv.Text = cliente.RamoAtividade;
            tbxEndereco.Text = cliente.Endereco;
            tbxNumero.Text = Convert.ToString(cliente.Numero);
            tbxBairro.Text = cliente.Bairro;
            tbxCidade.Text = cliente.Cidade;
            tbxEndereco.Text = cliente.Estado;
            tbxCep.Text = cliente.Cep;
            cbxEnderecoEstado.Text = cliente.Estado;
        }

        private void Voltar()
        {
            Hide();
            var form = new frmConsultarCliente();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        async private void AlterarCliente()
        {
            var cliente = new ClienteViewModel
            {
                Id = this.cliente.Id,
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

            _clienteApp.Update(cliente);
        }


    }
}
