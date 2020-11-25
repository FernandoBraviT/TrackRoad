using Entidades;
using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD
{
    public partial class frmIncluirMotorista : Form
    {
        private readonly IMotoristaAppService _motoristaApp;
        private readonly ICombustivelAppService _combustivelApp;

        public frmIncluirMotorista()
        {
            InitializeComponent();

            _motoristaApp = new MotoristaAppService();
            _combustivelApp = new CombustivelAppService();

            GetAllCombustiveis();
        }

        // Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarMotorista();
                Voltar();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Erro ao cadastrar motorista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos
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

        private async void AdicionarMotorista()
        {
            var motorista = new Motorista
            {
                Nome = tbxNome.Text,
                Cnh = tbxCnh.Text,
                TipoVeiculo = tbxVeiculoTipo.Text,
                ModeloVeiculo = tbxVeiculoModelo.Text,
                MarcaVeiculo = tbxVeiculoMarca.Text,
                AnoFabricacao = int.Parse(tbxVeiculoAno.Text),
                KmLitro = tbxVeiculoKm.Text,
                IdCombustivel = GetCombustivel(cbxCombustiveis.Text)
            };

            await _motoristaApp.Add(motorista);
        }

        private int GetCombustivel(string combustivelTexto)
        {
            string[] colunas = combustivelTexto.Split('-');
            return int.Parse(colunas[0]);
        }

    }
}
