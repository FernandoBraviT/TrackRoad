namespace PIM_TRACKROAD
{
    partial class frmAlterarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.txbPassword2 = new System.Windows.Forms.TextBox();
            this.cbxTiposDeUsuario = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.TipoUsuario = new System.Windows.Forms.Label();
            this.EmailUsuario = new System.Windows.Forms.Label();
            this.SenhaUsuario = new System.Windows.Forms.Label();
            this.LoginUsuario = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPassword1 = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.btnEspiarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Confirmar senha:";
            // 
            // txbPassword2
            // 
            this.txbPassword2.Location = new System.Drawing.Point(17, 142);
            this.txbPassword2.MaxLength = 10;
            this.txbPassword2.Name = "txbPassword2";
            this.txbPassword2.Size = new System.Drawing.Size(147, 20);
            this.txbPassword2.TabIndex = 18;
            this.txbPassword2.UseSystemPasswordChar = true;
            // 
            // cbxTiposDeUsuario
            // 
            this.cbxTiposDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTiposDeUsuario.FormattingEnabled = true;
            this.cbxTiposDeUsuario.Items.AddRange(new object[] {
            "1 - Administrador",
            "2 - Cadastro",
            "3 - Finanças",
            "4 - Operador",
            "5 - Motorista"});
            this.cbxTiposDeUsuario.Location = new System.Drawing.Point(17, 242);
            this.cbxTiposDeUsuario.Name = "cbxTiposDeUsuario";
            this.cbxTiposDeUsuario.Size = new System.Drawing.Size(206, 21);
            this.cbxTiposDeUsuario.TabIndex = 22;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(13, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(221, 307);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 23;
            this.btnIncluir.Text = "Alterar";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.AutoSize = true;
            this.TipoUsuario.Location = new System.Drawing.Point(14, 226);
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Size = new System.Drawing.Size(85, 13);
            this.TipoUsuario.TabIndex = 21;
            this.TipoUsuario.Text = "Tipo de Usuário:";
            // 
            // EmailUsuario
            // 
            this.EmailUsuario.AutoSize = true;
            this.EmailUsuario.Location = new System.Drawing.Point(14, 177);
            this.EmailUsuario.Name = "EmailUsuario";
            this.EmailUsuario.Size = new System.Drawing.Size(38, 13);
            this.EmailUsuario.TabIndex = 19;
            this.EmailUsuario.Text = "E-mail:";
            // 
            // SenhaUsuario
            // 
            this.SenhaUsuario.AutoSize = true;
            this.SenhaUsuario.Location = new System.Drawing.Point(14, 87);
            this.SenhaUsuario.Name = "SenhaUsuario";
            this.SenhaUsuario.Size = new System.Drawing.Size(41, 13);
            this.SenhaUsuario.TabIndex = 15;
            this.SenhaUsuario.Text = "Senha:";
            // 
            // LoginUsuario
            // 
            this.LoginUsuario.AutoSize = true;
            this.LoginUsuario.Location = new System.Drawing.Point(14, 37);
            this.LoginUsuario.Name = "LoginUsuario";
            this.LoginUsuario.Size = new System.Drawing.Size(75, 13);
            this.LoginUsuario.TabIndex = 13;
            this.LoginUsuario.Text = "Nome / Login:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(17, 193);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(274, 20);
            this.txbEmail.TabIndex = 20;
            // 
            // txbPassword1
            // 
            this.txbPassword1.Location = new System.Drawing.Point(17, 103);
            this.txbPassword1.MaxLength = 10;
            this.txbPassword1.Name = "txbPassword1";
            this.txbPassword1.Size = new System.Drawing.Size(147, 20);
            this.txbPassword1.TabIndex = 16;
            this.txbPassword1.UseSystemPasswordChar = true;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(17, 53);
            this.txbLogin.MaxLength = 30;
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(274, 20);
            this.txbLogin.TabIndex = 14;
            // 
            // btnEspiarSenha
            // 
            this.btnEspiarSenha.BackColor = System.Drawing.SystemColors.Control;
            this.btnEspiarSenha.BackgroundImage = global::PIM_TRACKROAD.Properties.Resources.icone_olho1;
            this.btnEspiarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEspiarSenha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEspiarSenha.Location = new System.Drawing.Point(170, 103);
            this.btnEspiarSenha.Name = "btnEspiarSenha";
            this.btnEspiarSenha.Size = new System.Drawing.Size(21, 20);
            this.btnEspiarSenha.TabIndex = 24;
            this.btnEspiarSenha.UseVisualStyleBackColor = false;
            this.btnEspiarSenha.Click += new System.EventHandler(this.btnEspiarSenha_Click);
            // 
            // frmAlterarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 341);
            this.Controls.Add(this.btnEspiarSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPassword2);
            this.Controls.Add(this.cbxTiposDeUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.TipoUsuario);
            this.Controls.Add(this.EmailUsuario);
            this.Controls.Add(this.SenhaUsuario);
            this.Controls.Add(this.LoginUsuario);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPassword1);
            this.Controls.Add(this.txbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar dados do Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEspiarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPassword2;
        private System.Windows.Forms.ComboBox cbxTiposDeUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label TipoUsuario;
        private System.Windows.Forms.Label EmailUsuario;
        private System.Windows.Forms.Label SenhaUsuario;
        private System.Windows.Forms.Label LoginUsuario;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPassword1;
        private System.Windows.Forms.TextBox txbLogin;
    }
}