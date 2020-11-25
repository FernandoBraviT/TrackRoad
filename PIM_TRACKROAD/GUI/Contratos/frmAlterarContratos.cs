using Entidades;
using System;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;
using TrackRoad.Application.Interfaces;
using TrackRoad.Application.Services;
using TrackRoad.Application.ViewModels;

namespace PIM_TRACKROAD
{
    public partial class frmAlterarContratos : Form
    {
        private readonly IContratoAppService _contratoApp;
        private readonly IClienteAppService _clienteApp;
        private ContratoViewModel contrato;

        public frmAlterarContratos(int id)
        {
            InitializeComponent();

            _contratoApp = new ContratoAppService();
            _clienteApp = new ClienteAppService();

            GetAllClientes();
            BuscarContrato(id);
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
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd1.FileNames)
                {
                    txtArquivo.Text += arquivo;
                    // cria um PictureBox
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                AlterarContrato();
                Voltar();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Erro ao alterar contrato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos
        private async void BuscarContrato(int idContrato)
        {
            this.contrato = await _contratoApp.Get(idContrato);
            MostrarContrato();
        }

        private void GetAllClientes()
        {
            var clientes = _clienteApp.GetAll();

            foreach (var item in clientes)
            {
                cbxClientes.Items.Add($"{item.Id} - {item.NomeFantasia}");
            }
        }

        private void MostrarContrato()
        {
            cbxClientes.Text = $"{contrato.Cliente.Id} - {contrato.Cliente.NomeFantasia}";
            tbxEmpresa.Text = contrato.Empresa;
            tbxValor.Text = Convert.ToString(contrato.Valor);
            ExibirDoc(contrato.Doc);
        }

        private void ExibirDoc(string doc)
        {
            byte[] imageBytes = Convert.FromBase64String(doc);

            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 120;
                pb.Width = 120;
                pb.Image = Image.FromStream(ms, true);
                flowLayoutPanel1.Controls.Add(pb);
            }
        }

        private void Voltar()
        {
            Hide();
            var form = new frmConsultarContratos();
            form.Closed += (s, args) => Close();
            form.ShowDialog();
        }

        private async void AlterarContrato()
        {
            var contrato = new Contrato
            {
                Id = this.contrato.Id,
                IdCliente = GetContrato(cbxClientes.Text),
                Empresa = tbxEmpresa.Text,
                Valor = double.Parse(tbxValor.Text),
                Doc = ConverterImagem(txtArquivo.Text)
            };

            await _contratoApp.Update(contrato);
        }

        private int GetContrato(string contratoTexto)
        {
            string[] colunas = contratoTexto.Split('-');
            return int.Parse(colunas[0]);
        }

        private string ConverterImagem(string caminho)
        {
            byte[] imagem = File.ReadAllBytes(caminho);
            return Convert.ToBase64String(imagem);
        }

    }
}
