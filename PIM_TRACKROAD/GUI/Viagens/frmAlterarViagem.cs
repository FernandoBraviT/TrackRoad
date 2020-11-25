using Entidades;
using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;
using TrackRoad.Application.ViewModels;

namespace PIM_TRACKROAD
{
    public partial class frmAlterarViagem : Form
    {
        private readonly IViagemAppService _viagemApp;
        private readonly IMotoristaAppService _motoristaApp;
        private ViagemViewModel viagem;

        public frmAlterarViagem(int idViagem)
        {
            InitializeComponent();

            _viagemApp = new ViagemAppService();
            _motoristaApp = new MotoristaAppService();

            GetAllMotoristas();
            BuscarViagem(idViagem);
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
                AlterarViagem();
                Voltar();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message, "Erro ao alterar viagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private async void GetAllMotoristas()
        {
            var motoristas = await _motoristaApp.GetAll();

            foreach (var item in motoristas)
            {
                cbxMotorista.Items.Add($"{item.Id} - {item.Nome}");
            }
        }

        private async void BuscarViagem(int idViagem)
        {
            this.viagem = await _viagemApp.Get(idViagem);
            MostrarViagem();
        }

        private void MostrarViagem()
        {
            tbxTotalDistancia.Text = Convert.ToString(viagem.TotalDistancia);
            tbxEnderecoDestino.Text = viagem.EnderecoDestino;
            tbxNumeroDestino.Text = Convert.ToString(viagem.NumeroDestino);
            tbxBairroDestino.Text = viagem.BairroDestino;
            tbxCidadeDestino.Text = viagem.CidadeDestino;
            cbxEstadoDestino.Text = viagem.EstadoDestino;
            tbxCepDestino.Text = viagem.CepDestino;
            cbxMotorista.Text = $"{viagem.Motorista.Id} - {viagem.Motorista.Nome}";
        }

        private void Voltar()
        {
            Hide();
            var form = new frmConsultarViagem();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private async void AlterarViagem()
        {
            var viagem = new Viagem
            {
                Id = this.viagem.Id,
                TotalDistancia = double.Parse(tbxTotalDistancia.Text),
                EnderecoDestino = tbxEnderecoDestino.Text,
                NumeroDestino = int.Parse(tbxNumeroDestino.Text),
                BairroDestino = tbxBairroDestino.Text,
                CidadeDestino = tbxCidadeDestino.Text,
                EstadoDestino = cbxEstadoDestino.Text,
                CepDestino = tbxCepDestino.Text,
                IdMotorista = GetMotorista(cbxMotorista.Text)
            };

            await _viagemApp.Update(viagem);
        }

        private int GetMotorista(string motoristaTexto)
        {
            string[] colunas = motoristaTexto.Split('-');
            return int.Parse(colunas[0]);
        }

    }
}
