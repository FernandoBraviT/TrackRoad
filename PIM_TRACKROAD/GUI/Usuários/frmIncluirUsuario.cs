using Entidades;
using System;
using System.Data.Entity.Validation;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD
{
    public partial class frmIncluirUsuario : Form
    {
        private readonly IUsuarioAppService _usuarioApp;

        public frmIncluirUsuario()
        {
            InitializeComponent();
            _usuarioApp = new UsuarioAppService();
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
                AdicionarUsuario();
                Voltar();
            }
            catch (DbEntityValidationException ent)
            {
                MessageBox.Show(ent.Message, "Erro ao cadastrar usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message, "Erro ao cadastrar usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos
        private void Voltar()
        {
            Hide();
            var form = new frmConsultarUsuario();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        async private void AdicionarUsuario()
        {
            ValidarCriacaoUsuario();

            var usuario = new Usuario
            {
                Id = 0,
                Login = txbLogin.Text,
                Password = txbPassword1.Text,
                Email = txbEmail.Text,
                Tipo = int.Parse(cbxTiposDeUsuario.Text[0].ToString())
            };

            await _usuarioApp.Add(usuario);
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
