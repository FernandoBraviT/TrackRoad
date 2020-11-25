namespace PIM_TRACKROAD
{
    partial class frmAlterarContratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarContratos));
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelecionarArquivos = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContrato = new System.Windows.Forms.Label();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.tbxEmpresa = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelecionarArquivos);
            this.groupBox1.Controls.Add(this.txtArquivo);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.lblContrato);
            this.groupBox1.Location = new System.Drawing.Point(19, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 219);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrato";
            // 
            // btnSelecionarArquivos
            // 
            this.btnSelecionarArquivos.BackgroundImage = global::PIM_TRACKROAD.Properties.Resources.seta_cima;
            this.btnSelecionarArquivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelecionarArquivos.Location = new System.Drawing.Point(222, 29);
            this.btnSelecionarArquivos.Name = "btnSelecionarArquivos";
            this.btnSelecionarArquivos.Size = new System.Drawing.Size(30, 21);
            this.btnSelecionarArquivos.TabIndex = 80;
            this.btnSelecionarArquivos.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivos.Click += new System.EventHandler(this.btnSelecionarArquivos_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(6, 30);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(210, 20);
            this.txtArquivo.TabIndex = 75;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 154);
            this.flowLayoutPanel1.TabIndex = 78;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(4, 14);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(103, 13);
            this.lblContrato.TabIndex = 7;
            this.lblContrato.Text = "Selecionar Contrato:";
            // 
            // cbxClientes
            // 
            this.cbxClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(18, 30);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(259, 21);
            this.cbxClientes.TabIndex = 87;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(15, 14);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 86;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(18, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Enabled = false;
            this.btnIncluir.Location = new System.Drawing.Point(202, 362);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 84;
            this.btnIncluir.Text = "Alterar";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(19, 109);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(173, 20);
            this.tbxValor.TabIndex = 83;
            // 
            // tbxEmpresa
            // 
            this.tbxEmpresa.Location = new System.Drawing.Point(19, 70);
            this.tbxEmpresa.Name = "tbxEmpresa";
            this.tbxEmpresa.Size = new System.Drawing.Size(258, 20);
            this.tbxEmpresa.TabIndex = 82;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(18, 93);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(119, 13);
            this.lblValor.TabIndex = 81;
            this.lblValor.Text = "Valor Total do Contrato:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(17, 54);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 80;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // frmAlterarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxClientes);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.tbxEmpresa);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarContratos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar dados do Contrato";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelecionarArquivos;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.TextBox tbxEmpresa;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblEmpresa;
    }
}