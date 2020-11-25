namespace PIM_TRACKROAD
{
    partial class frmConsultarViagem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarViagem));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCadastros = new System.Windows.Forms.Label();
            this.dgvViagens = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDistancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BairroDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CepDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViagens)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(377, 308);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(458, 308);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(14, 308);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCadastros
            // 
            this.lblCadastros.AutoSize = true;
            this.lblCadastros.Location = new System.Drawing.Point(11, 58);
            this.lblCadastros.Name = "lblCadastros";
            this.lblCadastros.Size = new System.Drawing.Size(110, 13);
            this.lblCadastros.TabIndex = 3;
            this.lblCadastros.Text = "Viagens Cadastradas:";
            // 
            // dgvViagens
            // 
            this.dgvViagens.AllowUserToAddRows = false;
            this.dgvViagens.AllowUserToDeleteRows = false;
            this.dgvViagens.AllowUserToResizeColumns = false;
            this.dgvViagens.AllowUserToResizeRows = false;
            this.dgvViagens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViagens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TotalDistancia,
            this.EnderecoDestino,
            this.NumeroDestino,
            this.BairroDestino,
            this.CidadeDestino,
            this.EstadoDestino,
            this.CepDestino,
            this.IdMotorista,
            this.Motorista});
            this.dgvViagens.EnableHeadersVisualStyles = false;
            this.dgvViagens.Location = new System.Drawing.Point(14, 74);
            this.dgvViagens.MultiSelect = false;
            this.dgvViagens.Name = "dgvViagens";
            this.dgvViagens.ReadOnly = true;
            this.dgvViagens.RowHeadersVisible = false;
            this.dgvViagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViagens.Size = new System.Drawing.Size(600, 227);
            this.dgvViagens.TabIndex = 4;
            this.dgvViagens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViagens_CellClick);
            this.dgvViagens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPressionada_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(539, 308);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(475, 25);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 22);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(92, 9);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(213, 13);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Pesquisar por destino da viagem ou código:";
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(94, 26);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(373, 20);
            this.txbPesquisar.TabIndex = 1;
            this.txbPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPressionada_KeyDown);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Código";
            this.Id.MaxInputLength = 50;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // TotalDistancia
            // 
            this.TotalDistancia.DataPropertyName = "TotalDistancia";
            this.TotalDistancia.HeaderText = "Total Distância";
            this.TotalDistancia.Name = "TotalDistancia";
            this.TotalDistancia.ReadOnly = true;
            this.TotalDistancia.Width = 110;
            // 
            // EnderecoDestino
            // 
            this.EnderecoDestino.DataPropertyName = "EnderecoDestino";
            this.EnderecoDestino.HeaderText = "Endereço Destino";
            this.EnderecoDestino.Name = "EnderecoDestino";
            this.EnderecoDestino.ReadOnly = true;
            this.EnderecoDestino.Width = 150;
            // 
            // NumeroDestino
            // 
            this.NumeroDestino.DataPropertyName = "NumeroDestino";
            this.NumeroDestino.HeaderText = "Número Destino";
            this.NumeroDestino.Name = "NumeroDestino";
            this.NumeroDestino.ReadOnly = true;
            this.NumeroDestino.Width = 110;
            // 
            // BairroDestino
            // 
            this.BairroDestino.DataPropertyName = "BairroDestino";
            this.BairroDestino.HeaderText = "Bairro Destino";
            this.BairroDestino.Name = "BairroDestino";
            this.BairroDestino.ReadOnly = true;
            this.BairroDestino.Width = 150;
            // 
            // CidadeDestino
            // 
            this.CidadeDestino.DataPropertyName = "CidadeDestino";
            this.CidadeDestino.HeaderText = "Cidade Destino";
            this.CidadeDestino.Name = "CidadeDestino";
            this.CidadeDestino.ReadOnly = true;
            this.CidadeDestino.Width = 150;
            // 
            // EstadoDestino
            // 
            this.EstadoDestino.DataPropertyName = "EstadoDestino";
            this.EstadoDestino.HeaderText = "Estado";
            this.EstadoDestino.Name = "EstadoDestino";
            this.EstadoDestino.ReadOnly = true;
            this.EstadoDestino.Width = 150;
            // 
            // CepDestino
            // 
            this.CepDestino.DataPropertyName = "CepDestino";
            this.CepDestino.HeaderText = "CEP Destino";
            this.CepDestino.Name = "CepDestino";
            this.CepDestino.ReadOnly = true;
            this.CepDestino.Width = 120;
            // 
            // IdMotorista
            // 
            this.IdMotorista.DataPropertyName = "IdMotorista";
            this.IdMotorista.HeaderText = "Código do Motorista";
            this.IdMotorista.Name = "IdMotorista";
            this.IdMotorista.ReadOnly = true;
            this.IdMotorista.Width = 130;
            // 
            // Motorista
            // 
            this.Motorista.DataPropertyName = "Motorista";
            this.Motorista.HeaderText = "Motorista";
            this.Motorista.Name = "Motorista";
            this.Motorista.ReadOnly = true;
            this.Motorista.Visible = false;
            // 
            // frmConsultarViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblCadastros);
            this.Controls.Add(this.dgvViagens);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txbPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarViagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar  Viagens";
            this.Click += new System.EventHandler(this.frmConsultarViagem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCadastros;
        private System.Windows.Forms.DataGridView dgvViagens;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDistancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn BairroDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn CepDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motorista;
    }
}