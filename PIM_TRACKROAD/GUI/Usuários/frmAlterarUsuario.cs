using Entidades;
using System;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;
using TrackRoad.Application.ViewModels;

namespace PIM_TRACKROAD
{
    public partial class frmAlterarUsuario : Form
    {
        private readonly IUsuarioAppService _usuarioApp;
        private UsuarioViewModel usuario;

        public frmAlterarUsuario(int idUsuario)
        {
            InitializeComponent();

            _usuarioApp = new UsuarioAppService();
            BuscarUsuario(idUsuario);
        }

        // Eventos
        private void btnEspiarSenha_Click(object sender, EventArgs e)
        {
            var useChar = txbPassword1.UseSystemPasswordChar;

            txbPassword1.UseSystemPasswordChar = !useChar;
            txbPassword2.UseSystemPasswordChar = !useChar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                AlterarUsuario();
                Voltar();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Erro ao alterar usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos
        private async void BuscarUsuario(int idUsuario)
        {
            this.usuario = await _usuarioApp.Get(idUsuario);
            MostrarUsuario();
        }

        private void MostrarUsuario()
        {
            txbLogin.Text = usuario.Login;
            txbPassword1.Text = usuario.Password;
            txbPassword2.Text = usuario.Password;
            txbEmail.Text = usuario.Email;
            cbxTiposDeUsuario.Text = GetTipo(usuario.Tipo);
        }

        private string GetTipo(int tipo)
        {
            var codigo = Convert.ToString(tipo);
            string retorno = null;

            foreach (var item in cbxTiposDeUsuario.Items)
            {
                if (item.ToString().StartsWith(codigo))
                {
                    retorno = item.ToString();
                }
            }

            return retorno;
        }

        private void Voltar()
        {
            Hide();
            var form = new frmConsultarUsuario();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        async private void AlterarUsuario()
        {
            ValidarCriacaoUsuario();

            var usuario = new Usuario
            {
                Id = this.usuario.Id,
                Login = txbLogin.Text,
                Password = txbPassword1.Text,
                Email = txbEmail.Text,
                Tipo = int.Parse(cbxTiposDeUsuario.Text[0].ToString())
            };

            await _usuarioApp.Update(usuario);
        }

        private void ValidarCriacaoUsuario()
        {
            if (string.IsNullOrEmpty(txbPassword1.Text))
            {
                throw new Exception("Informe uma senha para o usuário");
            }

            if (string.IsNullOrEmpty(txbPassword2.Text))
            {
                throw new Exception("Confirme a senha digitada");
            }

            if (txbPassword1.Text != txbPassword2.Text)
                throw new Exception("Senhas digitadas não correspondem");
        }

    }
}
