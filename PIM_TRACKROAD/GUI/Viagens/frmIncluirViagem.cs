using Entidades;
using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD
{
    public partial class frmIncluirViagem : Form
    {
        private readonly IViagemAppService _viagemApp;
        private readonly IMotoristaAppService _motoristaApp;

        public frmIncluirViagem()
        {
            InitializeComponent();

            _viagemApp = new ViagemAppService();
            _motoristaApp = new MotoristaAppService();

            GetAllMotoristas();
        }

        // Eventos
        private void TeclaPressionada_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarViagem();
                Voltar();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message, "Erro ao cadastrar viagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos
        private async void GetAllMotoristas()
        {
            var motoristas = await _motoristaApp.GetAll();

            foreach (var item in motoristas)
            {
                cbxMotorista.Items.Add($"{item.Id} - {item.Nome}");
            }
        }

        private void Voltar()
        {
            Hide();
            var form = new frmConsultarViagem();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private async void AdicionarViagem()
        {
            var viagem = new Viagem
            {
                TotalDistancia = double.Parse(tbxDistanciaTotal.Text),
                EnderecoDestino = tbxEndereco.Text,
                NumeroDestino = int.Parse(tbxEnderecoNumero.Text),
                BairroDestino = tbxEnderecoBairro.Text,
                CidadeDestino = tbxEnderecoCidade.Text,
                EstadoDestino = cbxEnderecoEstado.Text,
                CepDestino = tbxEnderecoCep.Text,
                IdMotorista = GetMotorista(cbxMotorista.Text)
            };

            await _viagemApp.Add(viagem);
        }

        private int GetMotorista(string motoristaTexto)
        {
            string[] colunas = motoristaTexto.Split('-');
            return int.Parse(colunas[0]);
        }

    }
}
