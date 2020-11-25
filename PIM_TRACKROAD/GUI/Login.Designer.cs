
namespace PIM_TRACKROAD.GUI
{
    partial class Login
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
            this.SenhaUsuario = new System.Windows.Forms.Label();
            this.LoginUsuario = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEspiarSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SenhaUsuario
            // 
            this.SenhaUsuario.AutoSize = true;
            this.SenhaUsuario.Location = new System.Drawing.Point(9, 124);
            this.SenhaUsuario.Name = "SenhaUsuario";
            this.SenhaUsuario.Size = new System.Drawing.Size(41, 13);
            this.SenhaUsuario.TabIndex = 14;
            this.SenhaUsuario.Text = "Senha:";
            // 
            // LoginUsuario
            // 
            this.LoginUsuario.AutoSize = true;
            this.LoginUsuario.Location = new System.Drawing.Point(11, 85);
            this.LoginUsuario.Name = "LoginUsuario";
            this.LoginUsuario.Size = new System.Drawing.Size(36, 13);
            this.LoginUsuario.TabIndex = 12;
            this.LoginUsuario.Text = "Login:";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(14, 138);
            this.txbPassword.MaxLength = 10;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(223, 20);
            this.txbPassword.TabIndex = 15;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(12, 100);
            this.txbLogin.MaxLength = 30;
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(252, 20);
            this.txbLogin.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(175, 184);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(89, 23);
            this.btnConectar.TabIndex = 17;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PIM_TRACKROAD.Properties.Resources.icone_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 84);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnEspiarSenha
            // 
            this.btnEspiarSenha.BackColor = System.Drawing.SystemColors.Control;
            this.btnEspiarSenha.BackgroundImage = global::PIM_TRACKROAD.Properties.Resources.icone_olho1;
            this.btnEspiarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEspiarSenha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEspiarSenha.Location = new System.Drawing.Point(243, 137);
            this.btnEspiarSenha.Name = "btnEspiarSenha";
            this.btnEspiarSenha.Size = new System.Drawing.Size(21, 20);
            this.btnEspiarSenha.TabIndex = 16;
            this.btnEspiarSenha.UseVisualStyleBackColor = false;
            this.btnEspiarSenha.Click += new System.EventHandler(this.btnEspiarSenha_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(276, 219);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnEspiarSenha);
            this.Controls.Add(this.SenhaUsuario);
            this.Controls.Add(this.LoginUsuario);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackRoad - Entrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEspiarSenha;
        private System.Windows.Forms.Label SenhaUsuario;
        private System.Windows.Forms.Label LoginUsuario;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}