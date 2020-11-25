namespace PIM_TRACKROAD
{
    partial class frmIncluirCombustivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncluirCombustivel));
            this.lblCombustível = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCombustível
            // 
            this.lblCombustível.AutoSize = true;
            this.lblCombustível.Location = new System.Drawing.Point(9, 30);
            this.lblCombustível.Name = "lblCombustível";
            this.lblCombustível.Size = new System.Drawing.Size(115, 13);
            this.lblCombustível.TabIndex = 0;
            this.lblCombustível.Text = "Nome do Combustível:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(12, 46);
            this.tbxNome.MaxLength = 50;
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(260, 20);
            this.tbxNome.TabIndex = 4;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(197, 171);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 171);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "R$";
            // 
            // tbxPreco
            // 
            this.tbxPreco.Location = new System.Drawing.Point(43, 103);
            this.tbxPreco.MaxLength = 6;
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(229, 20);
            this.tbxPreco.TabIndex = 16;
            this.tbxPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPreco_KeyPress);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(13, 88);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(67, 13);
            this.lblPreco.TabIndex = 15;
            this.lblPreco.Text = "Preço (Litro):";
            // 
            // frmIncluirCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblCombustível);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIncluirCombustivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir novo Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCombustível;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.Label lblPreco;
    }
}