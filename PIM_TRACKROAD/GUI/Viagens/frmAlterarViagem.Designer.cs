namespace PIM_TRACKROAD
{
    partial class frmAlterarViagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarViagem));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbxCepDestino = new System.Windows.Forms.TextBox();
            this.tbxCidadeDestino = new System.Windows.Forms.TextBox();
            this.tbxBairroDestino = new System.Windows.Forms.TextBox();
            this.tbxNumeroDestino = new System.Windows.Forms.TextBox();
            this.tbxEnderecoDestino = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.tbxTotalDistancia = new System.Windows.Forms.TextBox();
            this.lblMotorista = new System.Windows.Forms.Label();
            this.lblKmv = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEstadoDestino = new System.Windows.Forms.ComboBox();
            this.cbxMotorista = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 252);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(336, 252);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tbxCepDestino
            // 
            this.tbxCepDestino.Location = new System.Drawing.Point(14, 146);
            this.tbxCepDestino.Name = "tbxCepDestino";
            this.tbxCepDestino.Size = new System.Drawing.Size(97, 20);
            this.tbxCepDestino.TabIndex = 11;
            this.tbxCepDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclaPresionada_KeyPress);
            // 
            // tbxCidadeDestino
            // 
            this.tbxCidadeDestino.Location = new System.Drawing.Point(118, 102);
            this.tbxCidadeDestino.Name = "tbxCidadeDestino";
            this.tbxCidadeDestino.Size = new System.Drawing.Size(201, 20);
            this.tbxCidadeDestino.TabIndex = 7;
            // 
            // tbxBairroDestino
            // 
            this.tbxBairroDestino.Location = new System.Drawing.Point(14, 102);
            this.tbxBairroDestino.Name = "tbxBairroDestino";
            this.tbxBairroDestino.Size = new System.Drawing.Size(97, 20);
            this.tbxBairroDestino.TabIndex = 5;
            // 
            // tbxNumeroDestino
            // 
            this.tbxNumeroDestino.Location = new System.Drawing.Point(285, 49);
            this.tbxNumeroDestino.Name = "tbxNumeroDestino";
            this.tbxNumeroDestino.Size = new System.Drawing.Size(100, 20);
            this.tbxNumeroDestino.TabIndex = 3;
            this.tbxNumeroDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclaPresionada_KeyPress);
            // 
            // tbxEnderecoDestino
            // 
            this.tbxEnderecoDestino.Location = new System.Drawing.Point(14, 49);
            this.tbxEnderecoDestino.Name = "tbxEnderecoDestino";
            this.tbxEnderecoDestino.Size = new System.Drawing.Size(265, 20);
            this.tbxEnderecoDestino.TabIndex = 1;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(13, 130);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP:";
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
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(325, 85);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";
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
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(11, 85);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro:";
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
            // tbxTotalDistancia
            // 
            this.tbxTotalDistancia.Location = new System.Drawing.Point(12, 29);
            this.tbxTotalDistancia.Name = "tbxTotalDistancia";
            this.tbxTotalDistancia.Size = new System.Drawing.Size(234, 20);
            this.tbxTotalDistancia.TabIndex = 1;
            this.tbxTotalDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclaPresionada_KeyPress);
            // 
            // lblMotorista
            // 
            this.lblMotorista.AutoSize = true;
            this.lblMotorista.Location = new System.Drawing.Point(250, 13);
            this.lblMotorista.Name = "lblMotorista";
            this.lblMotorista.Size = new System.Drawing.Size(118, 13);
            this.lblMotorista.TabIndex = 2;
            this.lblMotorista.Text = "Motorista Responsável:";
            // 
            // lblKmv
            // 
            this.lblKmv.AutoSize = true;
            this.lblKmv.Location = new System.Drawing.Point(9, 13);
            this.lblKmv.Name = "lblKmv";
            this.lblKmv.Size = new System.Drawing.Size(130, 13);
            this.lblKmv.TabIndex = 0;
            this.lblKmv.Text = "Distância total da Viagem:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEstadoDestino);
            this.groupBox1.Controls.Add(this.tbxNumeroDestino);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.tbxCepDestino);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.tbxCidadeDestino);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.tbxBairroDestino);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.tbxEnderecoDestino);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço de Destino";
            // 
            // cbxEstadoDestino
            // 
            this.cbxEstadoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoDestino.FormattingEnabled = true;
            this.cbxEstadoDestino.Items.AddRange(new object[] {
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
            this.cbxEstadoDestino.Location = new System.Drawing.Point(325, 101);
            this.cbxEstadoDestino.Name = "cbxEstadoDestino";
            this.cbxEstadoDestino.Size = new System.Drawing.Size(60, 21);
            this.cbxEstadoDestino.TabIndex = 9;
            // 
            // cbxMotorista
            // 
            this.cbxMotorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMotorista.FormattingEnabled = true;
            this.cbxMotorista.Location = new System.Drawing.Point(252, 28);
            this.cbxMotorista.Name = "cbxMotorista";
            this.cbxMotorista.Size = new System.Drawing.Size(159, 21);
            this.cbxMotorista.TabIndex = 3;
            // 
            // frmAlterarViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 284);
            this.Controls.Add(this.cbxMotorista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.tbxTotalDistancia);
            this.Controls.Add(this.lblMotorista);
            this.Controls.Add(this.lblKmv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarViagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar dados da Viagem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox tbxCepDestino;
        private System.Windows.Forms.TextBox tbxCidadeDestino;
        private System.Windows.Forms.TextBox tbxBairroDestino;
        private System.Windows.Forms.TextBox tbxNumeroDestino;
        private System.Windows.Forms.TextBox tbxEnderecoDestino;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox tbxTotalDistancia;
        private System.Windows.Forms.Label lblMotorista;
        private System.Windows.Forms.Label lblKmv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxEstadoDestino;
        private System.Windows.Forms.ComboBox cbxMotorista;
    }
}