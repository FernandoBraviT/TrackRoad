namespace PIM_TRACKROAD
{
    partial class frmConsultarCombustivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCombustivel));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gdvConsulta = new System.Windows.Forms.Label();
            this.dgvCombustiveis = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.EmailUsuario = new System.Windows.Forms.Label();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombustiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(377, 308);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 92;
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
            this.btnAlterar.TabIndex = 91;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(14, 308);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 90;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gdvConsulta
            // 
            this.gdvConsulta.AutoSize = true;
            this.gdvConsulta.Location = new System.Drawing.Point(13, 58);
            this.gdvConsulta.Name = "gdvConsulta";
            this.gdvConsulta.Size = new System.Drawing.Size(135, 13);
            this.gdvConsulta.TabIndex = 88;
            this.gdvConsulta.Text = "Combustíveis cadastrados:";
            // 
            // dgvCombustiveis
            // 
            this.dgvCombustiveis.AllowUserToAddRows = false;
            this.dgvCombustiveis.AllowUserToDeleteRows = false;
            this.dgvCombustiveis.AllowUserToResizeColumns = false;
            this.dgvCombustiveis.AllowUserToResizeRows = false;
            this.dgvCombustiveis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCombustiveis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCombustiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombustiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.login,
            this.Preco});
            this.dgvCombustiveis.EnableHeadersVisualStyles = false;
            this.dgvCombustiveis.Location = new System.Drawing.Point(14, 74);
            this.dgvCombustiveis.MultiSelect = false;
            this.dgvCombustiveis.Name = "dgvCombustiveis";
            this.dgvCombustiveis.ReadOnly = true;
            this.dgvCombustiveis.RowHeadersVisible = false;
            this.dgvCombustiveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCombustiveis.Size = new System.Drawing.Size(600, 227);
            this.dgvCombustiveis.TabIndex = 87;
            this.dgvCombustiveis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvCombustiveis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPressionada_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(539, 308);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 86;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(475, 25);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 22);
            this.btnConsultar.TabIndex = 85;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // EmailUsuario
            // 
            this.EmailUsuario.AutoSize = true;
            this.EmailUsuario.Location = new System.Drawing.Point(92, 11);
            this.EmailUsuario.Name = "EmailUsuario";
            this.EmailUsuario.Size = new System.Drawing.Size(118, 13);
            this.EmailUsuario.TabIndex = 84;
            this.EmailUsuario.Text = "Pesquisar Combustível:";
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(94, 26);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(373, 20);
            this.txbPesquisar.TabIndex = 83;
            this.txbPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPressionada_KeyDown);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Código";
            this.Id.MaxInputLength = 50;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 102;
            // 
            // login
            // 
            this.login.DataPropertyName = "Nome";
            this.login.HeaderText = "Nome";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Width = 345;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 150;
            // 
            // frmConsultarCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gdvConsulta);
            this.Controls.Add(this.dgvCombustiveis);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.EmailUsuario);
            this.Controls.Add(this.txbPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarCombustivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Combustíveis";
            this.Click += new System.EventHandler(this.frmConsultarCombustivel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombustiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label gdvConsulta;
        private System.Windows.Forms.DataGridView dgvCombustiveis;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label EmailUsuario;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}