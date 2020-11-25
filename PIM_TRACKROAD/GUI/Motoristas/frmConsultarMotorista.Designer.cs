namespace PIM_TRACKROAD
{
    partial class frmConsultarMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarMotorista));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvMotoristas = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.EmailUsuario = new System.Windows.Forms.Label();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.gdvConsulta = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipVeic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModVeic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcVeic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnoFab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmLitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCombustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(375, 308);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 91;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(456, 308);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 90;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 308);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 89;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvMotoristas
            // 
            this.dgvMotoristas.AllowUserToAddRows = false;
            this.dgvMotoristas.AllowUserToDeleteRows = false;
            this.dgvMotoristas.AllowUserToResizeColumns = false;
            this.dgvMotoristas.AllowUserToResizeRows = false;
            this.dgvMotoristas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMotoristas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMotoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotoristas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.login,
            this.Cnh,
            this.TipVeic,
            this.ModVeic,
            this.MarcVeic,
            this.AnoFab,
            this.KmLitro,
            this.CodigoCombustivel,
            this.Combustivel});
            this.dgvMotoristas.EnableHeadersVisualStyles = false;
            this.dgvMotoristas.Location = new System.Drawing.Point(12, 74);
            this.dgvMotoristas.MultiSelect = false;
            this.dgvMotoristas.Name = "dgvMotoristas";
            this.dgvMotoristas.ReadOnly = true;
            this.dgvMotoristas.RowHeadersVisible = false;
            this.dgvMotoristas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMotoristas.Size = new System.Drawing.Size(600, 227);
            this.dgvMotoristas.TabIndex = 87;
            this.dgvMotoristas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMotoristas_CellClick);
            this.dgvMotoristas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPressionada_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(537, 308);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 86;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(473, 25);
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
            this.EmailUsuario.Location = new System.Drawing.Point(89, 9);
            this.EmailUsuario.Name = "EmailUsuario";
            this.EmailUsuario.Size = new System.Drawing.Size(163, 13);
            this.EmailUsuario.TabIndex = 84;
            this.EmailUsuario.Text = "Pesquisar por nome do motorista:";
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(92, 26);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(373, 20);
            this.txbPesquisar.TabIndex = 83;
            this.txbPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPressionada_KeyDown);
            // 
            // gdvConsulta
            // 
            this.gdvConsulta.AutoSize = true;
            this.gdvConsulta.Location = new System.Drawing.Point(9, 58);
            this.gdvConsulta.Name = "gdvConsulta";
            this.gdvConsulta.Size = new System.Drawing.Size(119, 13);
            this.gdvConsulta.TabIndex = 92;
            this.gdvConsulta.Text = "Motoristas cadastrados:";
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
            // login
            // 
            this.login.DataPropertyName = "Nome";
            this.login.HeaderText = "Nome";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // Cnh
            // 
            this.Cnh.DataPropertyName = "Cnh";
            this.Cnh.HeaderText = "CNH";
            this.Cnh.Name = "Cnh";
            this.Cnh.ReadOnly = true;
            // 
            // TipVeic
            // 
            this.TipVeic.DataPropertyName = "TipoVeiculo";
            this.TipVeic.HeaderText = "Tipo Veículo";
            this.TipVeic.Name = "TipVeic";
            this.TipVeic.ReadOnly = true;
            this.TipVeic.Width = 120;
            // 
            // ModVeic
            // 
            this.ModVeic.DataPropertyName = "ModeloVeiculo";
            this.ModVeic.HeaderText = "Modelo Veículo";
            this.ModVeic.Name = "ModVeic";
            this.ModVeic.ReadOnly = true;
            this.ModVeic.Width = 130;
            // 
            // MarcVeic
            // 
            this.MarcVeic.DataPropertyName = "MarcaVeiculo";
            this.MarcVeic.HeaderText = "Marca Veículo";
            this.MarcVeic.Name = "MarcVeic";
            this.MarcVeic.ReadOnly = true;
            this.MarcVeic.Width = 120;
            // 
            // AnoFab
            // 
            this.AnoFab.DataPropertyName = "AnoFabricacao";
            this.AnoFab.HeaderText = "Ano Fabricação";
            this.AnoFab.Name = "AnoFab";
            this.AnoFab.ReadOnly = true;
            this.AnoFab.Width = 120;
            // 
            // KmLitro
            // 
            this.KmLitro.DataPropertyName = "KmLitro";
            this.KmLitro.HeaderText = "Km / Litro";
            this.KmLitro.Name = "KmLitro";
            this.KmLitro.ReadOnly = true;
            // 
            // CodigoCombustivel
            // 
            this.CodigoCombustivel.DataPropertyName = "IdCombustivel";
            this.CodigoCombustivel.HeaderText = "Código do Tipo Combustível";
            this.CodigoCombustivel.Name = "CodigoCombustivel";
            this.CodigoCombustivel.ReadOnly = true;
            this.CodigoCombustivel.Width = 150;
            // 
            // Combustivel
            // 
            this.Combustivel.DataPropertyName = "Combustivel";
            this.Combustivel.HeaderText = "Combustivel";
            this.Combustivel.Name = "Combustivel";
            this.Combustivel.ReadOnly = true;
            this.Combustivel.Visible = false;
            // 
            // frmConsultarMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.gdvConsulta);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvMotoristas);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.EmailUsuario);
            this.Controls.Add(this.txbPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar  Motorista";
            this.Click += new System.EventHandler(this.frmConsultarMotorista_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvMotoristas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label EmailUsuario;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.Label gdvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipVeic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModVeic;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcVeic;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnoFab;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmLitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCombustivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustivel;
    }
}