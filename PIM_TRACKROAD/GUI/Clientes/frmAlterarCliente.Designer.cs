
namespace PIM_TRACKROAD.GUI.Clientes
{
    partial class frmAlterarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarCliente));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbxRamAtiv = new System.Windows.Forms.TextBox();
            this.tbxCpfCnpj = new System.Windows.Forms.TextBox();
            this.lblRamAtiv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEnderecoEstado = new System.Windows.Forms.ComboBox();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.tbxCep = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbxCidade = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tbxBairro = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxRazSoc = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblMotorista = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(337, 277);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 64;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tbxRamAtiv
            // 
            this.tbxRamAtiv.Location = new System.Drawing.Point(226, 80);
            this.tbxRamAtiv.Name = "tbxRamAtiv";
            this.tbxRamAtiv.Size = new System.Drawing.Size(186, 20);
            this.tbxRamAtiv.TabIndex = 74;
            // 
            // tbxCpfCnpj
            // 
            this.tbxCpfCnpj.Location = new System.Drawing.Point(12, 80);
            this.tbxCpfCnpj.MaxLength = 14;
            this.tbxCpfCnpj.Name = "tbxCpfCnpj";
            this.tbxCpfCnpj.Size = new System.Drawing.Size(208, 20);
            this.tbxCpfCnpj.TabIndex = 73;
            // 
            // lblRamAtiv
            // 
            this.lblRamAtiv.AutoSize = true;
            this.lblRamAtiv.Location = new System.Drawing.Point(223, 64);
            this.lblRamAtiv.Name = "lblRamAtiv";
            this.lblRamAtiv.Size = new System.Drawing.Size(85, 13);
            this.lblRamAtiv.TabIndex = 72;
            this.lblRamAtiv.Text = "Ramo Atividade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "CNPJ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEnderecoEstado);
            this.groupBox1.Controls.Add(this.tbxNumero);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.tbxCep);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.tbxCidade);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.tbxBairro);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.tbxEndereco);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 142);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço do Cliente";
            // 
            // cbxEnderecoEstado
            // 
            this.cbxEnderecoEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cbxEnderecoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnderecoEstado.FormattingEnabled = true;
            this.cbxEnderecoEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxEnderecoEstado.Location = new System.Drawing.Point(222, 101);
            this.cbxEnderecoEstado.Name = "cbxEnderecoEstado";
            this.cbxEnderecoEstado.Size = new System.Drawing.Size(60, 21);
            this.cbxEnderecoEstado.TabIndex = 55;
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(285, 49);
            this.tbxNumero.MaxLength = 5;
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(100, 20);
            this.tbxNumero.TabIndex = 36;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(11, 32);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 29;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(11, 85);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 30;
            this.lblBairro.Text = "Bairro:";
            // 
            // tbxCep
            // 
            this.tbxCep.Location = new System.Drawing.Point(285, 102);
            this.tbxCep.Name = "tbxCep";
            this.tbxCep.Size = new System.Drawing.Size(100, 20);
            this.tbxCep.TabIndex = 40;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(118, 85);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 31;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(222, 85);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 32;
            this.lblEstado.Text = "Estado:";
            // 
            // tbxCidade
            // 
            this.tbxCidade.Location = new System.Drawing.Point(118, 102);
            this.tbxCidade.Name = "tbxCidade";
            this.tbxCidade.Size = new System.Drawing.Size(100, 20);
            this.tbxCidade.TabIndex = 38;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(282, 33);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 33;
            this.lblNumero.Text = "Número:";
            // 
            // tbxBairro
            // 
            this.tbxBairro.Location = new System.Drawing.Point(14, 102);
            this.tbxBairro.Name = "tbxBairro";
            this.tbxBairro.Size = new System.Drawing.Size(97, 20);
            this.tbxBairro.TabIndex = 37;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(284, 86);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 34;
            this.lblCep.Text = "CEP:";
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(14, 49);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(265, 20);
            this.tbxEndereco.TabIndex = 35;
            // 
            // tbxRazSoc
            // 
            this.tbxRazSoc.Location = new System.Drawing.Point(253, 32);
            this.tbxRazSoc.Name = "tbxRazSoc";
            this.tbxRazSoc.Size = new System.Drawing.Size(159, 20);
            this.tbxRazSoc.TabIndex = 69;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(12, 32);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(234, 20);
            this.tbxNome.TabIndex = 68;
            // 
            // lblMotorista
            // 
            this.lblMotorista.AutoSize = true;
            this.lblMotorista.Location = new System.Drawing.Point(250, 16);
            this.lblMotorista.Name = "lblMotorista";
            this.lblMotorista.Size = new System.Drawing.Size(73, 13);
            this.lblMotorista.TabIndex = 67;
            this.lblMotorista.Text = "Razão Social:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 66;
            this.lblNome.Text = "Nome:";
            // 
            // frmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 307);
            this.Controls.Add(this.tbxRamAtiv);
            this.Controls.Add(this.tbxCpfCnpj);
            this.Controls.Add(this.lblRamAtiv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxRazSoc);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblMotorista);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar dados do Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox tbxRamAtiv;
        private System.Windows.Forms.TextBox tbxCpfCnpj;
        private System.Windows.Forms.Label lblRamAtiv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxEnderecoEstado;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox tbxCep;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox tbxCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tbxBairro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxRazSoc;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblMotorista;
        private System.Windows.Forms.Label lblNome;
    }
}