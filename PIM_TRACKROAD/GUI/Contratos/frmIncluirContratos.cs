using Entidades;
using System;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;

namespace PIM_TRACKROAD
{
    public partial class frmIncluirContratos : Form
    {
        private readonly IContratoAppService _contratoApp;
        private readonly IClienteAppService _clienteApp;

        public frmIncluirContratos()
        {
            InitializeComponent();

            _contratoApp = new ContratoAppService();
            _clienteApp = new ClienteAppService();

            GetAllClientes();
        }

        // Eventos
        private void btnSelecionarArquivos_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Fotos";
            ofd1.InitialDirectory = @"C:\Users\macoratti\Pictures";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                foreach (var arquivo in ofd1.FileNames)
                {
                    txtArquivo.Text += arquivo;
                    try
                    {
                        PictureBox pb = new PictureBox();
                        Image Imagem = Image.FromFile(arquivo);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Height = 120;
                        pb.Width = 120;
                        pb.Image = Imagem;

                        //inclui a imagem no containter flowLayoutPanel
                        flowLayoutPanel1.Controls.Clear();
                        flowLayoutPanel1.Controls.Add(pb);

                        btnIncluir.Enabled = true;
                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                    "Mensagem : " + ex.Message + "\n\n" +
                                                    "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message, "Não é possível exibir a imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarContrato();
                Voltar();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Erro ao cadastrar contrato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Métodos
        private void GetAllClientes()
        {
            var clientes = _clienteApp.GetAll();

            foreach (var item in clientes)
            {
                cbxClientes.Items.Add($"{item.Id} - {item.NomeFantasia}");
            }
        }

        private void Voltar()
        {
            Hide();
            var form = new frmConsultarContratos();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private async void AdicionarContrato()
        {
            var contrato = new Contrato
            {
                IdCliente = GetContrato(cbxClientes.Text),
                Empresa = tbxEmpresa.Text,
                Valor = double.Parse(tbxValor.Text),
                Doc = ConverterImagem(txtArquivo.Text)
            };

            await _contratoApp.Add(contrato);
        }

        private string ConverterImagem(string caminho)
        {
            byte[] imagem = System.IO.File.ReadAllBytes(caminho);
            return Convert.ToBase64String(imagem);
        }

        private int GetContrato(string contratoTexto)
        {
            string[] colunas = contratoTexto.Split('-');
            return int.Parse(colunas[0]);
        }

    }
}
