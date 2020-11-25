namespace PIM_TRACKROAD
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarContratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combustivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCombustívelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarViagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkSair = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.contratosToolStripMenuItem,
            this.combustivelToolStripMenuItem,
            this.motoristaToolStripMenuItem,
            this.viagensToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultarUsuario});
            this.usuarioToolStripMenuItem.Enabled = false;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuarioToolStripMenuItem.Text = "Usuários";
            // 
            // btnConsultarUsuario
            // 
            this.btnConsultarUsuario.Name = "btnConsultarUsuario";
            this.btnConsultarUsuario.Size = new System.Drawing.Size(181, 22);
            this.btnConsultarUsuario.Text = "Consultar Usuário(s)";
            this.btnConsultarUsuario.Click += new System.EventHandler(this.consultarUsuárioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultarCliente});
            this.clientesToolStripMenuItem.Enabled = false;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(180, 22);
            this.btnConsultarCliente.Text = "Consultar Cliente(s)";
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarContratosToolStripMenuItem});
            this.contratosToolStripMenuItem.Enabled = false;
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.contratosToolStripMenuItem.Text = "Contratos";
            // 
            // consultarContratosToolStripMenuItem
            // 
            this.consultarContratosToolStripMenuItem.Name = "consultarContratosToolStripMenuItem";
            this.consultarContratosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.consultarContratosToolStripMenuItem.Text = "Consultar Contrato(s)";
            this.consultarContratosToolStripMenuItem.Click += new System.EventHandler(this.consultarContratosToolStripMenuItem_Click);
            // 
            // combustivelToolStripMenuItem
            // 
            this.combustivelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCombustívelToolStripMenuItem});
            this.combustivelToolStripMenuItem.Enabled = false;
            this.combustivelToolStripMenuItem.Name = "combustivelToolStripMenuItem";
            this.combustivelToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.combustivelToolStripMenuItem.Text = "Combustível";
            // 
            // consultarCombustívelToolStripMenuItem
            // 
            this.consultarCombustívelToolStripMenuItem.Name = "consultarCombustívelToolStripMenuItem";
            this.consultarCombustívelToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.consultarCombustívelToolStripMenuItem.Text = "Consultar Combustível(s)";
            this.consultarCombustívelToolStripMenuItem.Click += new System.EventHandler(this.consultarCombustívelToolStripMenuItem_Click);
            // 
            // motoristaToolStripMenuItem
            // 
            this.motoristaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarMotoristaToolStripMenuItem});
            this.motoristaToolStripMenuItem.Enabled = false;
            this.motoristaToolStripMenuItem.Name = "motoristaToolStripMenuItem";
            this.motoristaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.motoristaToolStripMenuItem.Text = "Motorista";
            // 
            // consultarMotoristaToolStripMenuItem
            // 
            this.consultarMotoristaToolStripMenuItem.Name = "consultarMotoristaToolStripMenuItem";
            this.consultarMotoristaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.consultarMotoristaToolStripMenuItem.Text = "Consultar Motorista(s)";
            this.consultarMotoristaToolStripMenuItem.Click += new System.EventHandler(this.consultarMotoristaToolStripMenuItem_Click);
            // 
            // viagensToolStripMenuItem
            // 
            this.viagensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarViagemToolStripMenuItem});
            this.viagensToolStripMenuItem.Enabled = false;
            this.viagensToolStripMenuItem.Name = "viagensToolStripMenuItem";
            this.viagensToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.viagensToolStripMenuItem.Text = "Viagem";
            // 
            // consultarViagemToolStripMenuItem
            // 
            this.consultarViagemToolStripMenuItem.Name = "consultarViagemToolStripMenuItem";
            this.consultarViagemToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultarViagemToolStripMenuItem.Text = "Consultar Viagem(s)";
            this.consultarViagemToolStripMenuItem.Click += new System.EventHandler(this.consultarViagemToolStripMenuItem_Click);
            // 
            // linkSair
            // 
            this.linkSair.AutoSize = true;
            this.linkSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSair.Location = new System.Drawing.Point(769, 4);
            this.linkSair.Name = "linkSair";
            this.linkSair.Size = new System.Drawing.Size(33, 17);
            this.linkSair.TabIndex = 2;
            this.linkSair.TabStop = true;
            this.linkSair.Text = "Sair";
            this.linkSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSair_LinkClicked);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.Controls.Add(this.linkSair);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackRoad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnConsultarUsuario;
        private System.Windows.Forms.ToolStripMenuItem consultarContratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combustivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCombustívelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMotoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarViagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnConsultarCliente;
        private System.Windows.Forms.LinkLabel linkSair;
    }
}

