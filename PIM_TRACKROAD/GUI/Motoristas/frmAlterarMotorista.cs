using Entidades;
using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;
using TrackRoad.Application.ViewModels;

namespace PIM_TRACKROAD
{
    public partial class frmAlterarMotorista : Form
    {
        private readonly IMotoristaAppService _motoristaApp;
        private readonly ICombustivelAppService _combustivelApp;

        private MotoristaViewModel motorista;

        public frmAlterarMotorista(int idMotorista)
        {
            InitializeComponent();

            _motoristaApp = new MotoristaAppService();
            _combustivelApp = new CombustivelAppService();

            GetAllCombustiveis();
            BuscarMotorista(idMotorista);
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
                AlterarMotorista();
                Voltar();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Erro ao alterar motorista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos
        private async void BuscarMotorista(int idMotorista)
        {
            this.motorista = await _motoristaApp.Get(idMotorista);
            MostrarMotorista();
        }

        private void MostrarMotorista()
        {
            tbxNome.Text = motorista.Nome;
            tbxCnh.Text = motorista.Cnh;
            tbxVeiculoTipo.Text = motorista.TipoVeiculo;
            tbxVeiculoModelo.Text = motorista.ModeloVeiculo;
            tbxVeiculoMarca.Text = motorista.MarcaVeiculo;
            tbxVeiculoAno.Text = motorista.AnoFabricacao.ToString();
            tbxVeiculoKm.Text = motorista.KmLitro;
            cbxCombustiveis.Text = $"{motorista.Combustivel.Id} - {motorista.Combustivel.Nome}";
        }

        private async void GetAllCombustiveis()
        {
            var combustiveis = await _combustivelApp.GetAll();

            foreach (var item in combustiveis)
            {
                cbxCombustiveis.Items.Add($"{item.Id} - {item.Nome}");
            }
        }

        private void Voltar()
        {
            Hide();
            var form = new frmConsultarMotorista();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private async void AlterarMotorista()
        {
            var motorista = new Motorista
            {
                Id = this.motorista.Id,
                Nome = tbxNome.Text,
                Cnh = tbxCnh.Text,
                TipoVeiculo = tbxVeiculoTipo.Text,
                ModeloVeiculo = tbxVeiculoModelo.Text,
                MarcaVeiculo = tbxVeiculoMarca.Text,
                AnoFabricacao = int.Parse(tbxVeiculoAno.Text),
                KmLitro = tbxVeiculoKm.Text,
                IdCombustivel = GetCombustivel(cbxCombustiveis.Text)
            };

            await _motoristaApp.Update(motorista);
        }

        private int GetCombustivel(string combustivelTexto)
        {
            string[] colunas = combustivelTexto.Split('-');
            return int.Parse(colunas[0]);
        }

    }
}
