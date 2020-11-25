using Entidades;
using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;
using TrackRoad.Application.ViewModels;

namespace PIM_TRACKROAD
{
    public partial class frmAlterarCombustivel : Form
    {
        private readonly ICombustivelAppService _combustivelApp;
        private CombustivelViewModel combustivel;

        public frmAlterarCombustivel(int idCombustivel)
        {
            InitializeComponent();

            _combustivelApp = new CombustivelAppService();
            BuscarCombustivel(idCombustivel);
        }

        // Eventos
        private void tbxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarCombustivel();
                Voltar();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Erro ao atualizar combustível", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos
        private async void BuscarCombustivel(int idCombustivel)
        {
            this.combustivel = await _combustivelApp.Get(idCombustivel);
            MostrarCombustivel();
        }

        private void MostrarCombustivel()
        {
            tbxNome.Text = combustivel.Nome;
            tbxPreco.Text = Convert.ToString(combustivel.Preco);
        }

        private async void AtualizarCombustivel()
        {
            var combustivel = new Combustivel
            {
                Id = this.combustivel.Id,
                Nome = tbxNome.Text,
                Preco = double.Parse(tbxPreco.Text)
            };

            await _combustivelApp.Update(combustivel);
        }

        private void Voltar()
        {
            Hide();
            var form = new frmConsultarCombustivel();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }
    }
}
