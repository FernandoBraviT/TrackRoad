namespace PIM_TRACKROAD
{
    partial class frmIncluirViagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncluirViagem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEnderecoEstado = new System.Windows.Forms.ComboBox();
            this.tbxEnderecoNumero = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.tbxEnderecoCep = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbxEnderecoCidade = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tbxEnderecoBairro = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbxDistanciaTotal = new System.Windows.Forms.TextBox();
            this.lblMotorista = new System.Windows.Forms.Label();
            this.lblKmv = new System.Windows.Forms.Label();
            this.cbxMotorista = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEnderecoEstado);
            this.groupBox1.Controls.Add(this.tbxEnderecoNumero);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.tbxEnderecoCep);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.tbxEnderecoCidade);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.tbxEnderecoBairro);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.tbxEndereco);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 182);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço de Destino";
            // 
            // cbxEnderecoEstado
            // 
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
            this.cbxEnderecoEstado.Location = new System.Drawing.Point(325, 101);
            this.cbxEnderecoEstado.Name = "cbxEnderecoEstado";
            this.cbxEnderecoEstado.Size = new System.Drawing.Size(60, 21);
            this.cbxEnderecoEstado.TabIndex = 9;
            // 
            // tbxEnderecoNumero
            // 
            this.tbxEnderecoNumero.Location = new System.Drawing.Point(285, 49);
            this.tbxEnderecoNumero.MaxLength = 10;
            this.tbxEnderecoNumero.Name = "tbxEnderecoNumero";
            this.tbxEnderecoNumero.Size = new System.Drawing.Size(100, 20);
            this.tbxEnderecoNumero.TabIndex = 3;
            this.tbxEnderecoNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclaPressionada_KeyPress);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(11, 32);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(11, 85);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro:";
            // 
            // tbxEnderecoCep
            // 
            this.tbxEnderecoCep.Location = new System.Drawing.Point(14, 148);
            this.tbxEnderecoCep.MaxLength = 10;
            this.tbxEnderecoCep.Name = "tbxEnderecoCep";
            this.tbxEnderecoCep.Size = new System.Drawing.Size(97, 20);
            this.tbxEnderecoCep.TabIndex = 11;
            this.tbxEnderecoCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclaPressionada_KeyPress);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(118, 85);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 6;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(324, 84);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";
            // 
            // tbxEnderecoCidade
            // 
            this.tbxEnderecoCidade.Location = new System.Drawing.Point(118, 102);
            this.tbxEnderecoCidade.Name = "tbxEnderecoCidade";
            this.tbxEnderecoCidade.Size = new System.Drawing.Size(201, 20);
            this.tbxEnderecoCidade.TabIndex = 7;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(282, 33);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número:";
            // 
            // tbxEnderecoBairro
            // 
            this.tbxEnderecoBairro.Location = new System.Drawing.Point(14, 102);
            this.tbxEnderecoBairro.Name = "tbxEnderecoBairro";
            this.tbxEnderecoBairro.Size = new System.Drawing.Size(97, 20);
            this.tbxEnderecoBairro.TabIndex = 5;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(14, 134);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(14, 49);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(265, 20);
            this.tbxEndereco.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(337, 257);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Incluir";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tbxDistanciaTotal
            // 
            this.tbxDistanciaTotal.Location = new System.Drawing.Point(12, 28);
            this.tbxDistanciaTotal.Name = "tbxDistanciaTotal";
            this.tbxDistanciaTotal.Size = new System.Drawing.Size(234, 20);
            this.tbxDistanciaTotal.TabIndex = 1;
            this.tbxDistanciaTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclaPressionada_KeyPress);
            // 
            // lblMotorista
            // 
            this.lblMotorista.AutoSize = true;
            this.lblMotorista.Location = new System.Drawing.Point(250, 12);
            this.lblMotorista.Name = "lblMotorista";
            this.lblMotorista.Size = new System.Drawing.Size(118, 13);
            this.lblMotorista.TabIndex = 2;
            this.lblMotorista.Text = "Motorista Responsável:";
            // 
            // lblKmv
            // 
            this.lblKmv.AutoSize = true;
            this.lblKmv.Location = new System.Drawing.Point(9, 12);
            this.lblKmv.Name = "lblKmv";
            this.lblKmv.Size = new System.Drawing.Size(130, 13);
            this.lblKmv.TabIndex = 0;
            this.lblKmv.Text = "Distância total da Viagem:";
            // 
            // cbxMotorista
            // 
            this.cbxMotorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMotorista.FormattingEnabled = true;
            this.cbxMotorista.Location = new System.Drawing.Point(253, 27);
            this.cbxMotorista.Name = "cbxMotorista";
            this.cbxMotorista.Size = new System.Drawing.Size(159, 21);
            this.cbxMotorista.TabIndex = 3;
            // 
            // frmIncluirViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 290);
            this.Controls.Add(this.cbxMotorista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.tbxDistanciaTotal);
            this.Controls.Add(this.lblMotorista);
            this.Controls.Add(this.lblKmv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIncluirViagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir nova Viagem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxEnderecoNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox tbxEnderecoCep;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox tbxEnderecoCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tbxEnderecoBairro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox tbxDistanciaTotal;
        private System.Windows.Forms.Label lblMotorista;
        private System.Windows.Forms.Label lblKmv;
        private System.Windows.Forms.ComboBox cbxEnderecoEstado;
        private System.Windows.Forms.ComboBox cbxMotorista;
    }
}