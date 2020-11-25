using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;
using TrackRoad.Application.ViewModels;

namespace PIM_TRACKROAD.GUI
{
    public partial class Login : Form
    {
        private readonly IUsuarioAppService _usuarioApp;

        public Login()
        {
            InitializeComponent();
            _usuarioApp = new UsuarioAppService();
        }

        // Eventos
        private void btnEspiarSenha_Click(object sender, EventArgs e)
        {
            var useChar = txbPassword.UseSystemPasswordChar;
            txbPassword.UseSystemPasswordChar = !useChar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                Conectar();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Erro ao conectar com o sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos
        private async void Conectar()
        {
            if (ValidarCampos())
            {

                var login = txbLogin.Text;
                var usuario = await _usuarioApp.Search(login);

                if (ValidarUsuario(usuario.ToList()))
                {
                    AbrirSistema();
                }
                else
                {
                    MessageBox.Show("Login e/ou Senha incorreto", "Erro ao conectar com o sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txbLogin.Text))
            {
                MessageBox.Show("Informe seu Login", "Erro ao conectar com o sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txbPassword.Text))
            {
                MessageBox.Show("Informe sua senha", "Erro ao conectar com o sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AbrirSistema()
        {
            Hide();
            var form = new frmPrincipal();
            form.Closed += (s, args) => Close();
            form.Show();
        }

        private bool ValidarUsuario(List<UsuarioViewModel> usuario)
        {
            if (usuario.Count != 0)
            {
                var loginDigitado = txbLogin.Text;
                var senhaDigitada = txbPassword.Text;

                var login = usuario[0].Login;
                var senha = usuario[0].Password;

                if (loginDigitado == login && senhaDigitada == senha)
                {
                    User.Nome = login;
                    User.Tipo = usuario[0].Tipo;

                    return true;
                }
            }

            return false;
        }

    }
}
