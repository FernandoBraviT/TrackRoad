using PIM_TRACKROAD.GUI;
using System;
using System.Windows.Forms;

namespace PIM_TRACKROAD
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            ValidarPermissoes();
        }

        // Eventos
        private void consultarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarUsuario().ShowDialog();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            new frmConsultarCliente().ShowDialog();
        }

        private void consultarContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarContratos().ShowDialog();
        }

        private void consultarCombustívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarCombustivel().ShowDialog();
        }

        private void consultarMotoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarMotorista().ShowDialog();
        }

        private void consultarViagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultarViagem().ShowDialog();
        }

        private void linkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var form = new Login();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        // Métodos
        private void ValidarPermissoes()
        {
            //1 - Administrador
            //2 - Cadastro
            //3 - Finanças
            //4 - Operador
            //5 - Motorista
            if (User.Tipo == 1 || User.Tipo == 2 || User.Tipo == 5)
            {
                usuarioToolStripMenuItem.Enabled = true;
                clientesToolStripMenuItem.Enabled = true;
            }

            if (User.Tipo == 1 || User.Tipo == 3)
            {
                contratosToolStripMenuItem.Enabled = true;
            }

            if (User.Tipo == 1 || User.Tipo == 2 || User.Tipo == 3)
            {
                combustivelToolStripMenuItem.Enabled = true;
            }

            if (User.Tipo == 1 || User.Tipo == 2)
            {
                motoristaToolStripMenuItem.Enabled = true;
            }

            if (User.Tipo == 1 || User.Tipo == 3 || User.Tipo == 4)
            {
                viagensToolStripMenuItem.Enabled = true;
            }
        }

    }
}
