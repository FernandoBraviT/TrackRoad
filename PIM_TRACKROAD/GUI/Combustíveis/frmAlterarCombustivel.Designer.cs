namespace PIM_TRACKROAD
{
    partial class frmAlterarCombustivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarCombustivel));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCombustível = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(14, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(197, 176);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // tbxPreco
            // 
            this.tbxPreco.Location = new System.Drawing.Point(45, 102);
            this.tbxPreco.MaxLength = 6;
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(229, 20);
            this.tbxPreco.TabIndex = 11;
            this.tbxPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPreco_KeyPress);
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(14, 50);
            this.tbxNome.MaxLength = 50;
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(260, 20);
            this.tbxNome.TabIndex = 10;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(15, 87);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(67, 13);
            this.lblPreco.TabIndex = 9;
            this.lblPreco.Text = "Preço (Litro):";
            // 
            // lblCombustível
            // 
            this.lblCombustível.AutoSize = true;
            this.lblCombustível.Location = new System.Drawing.Point(13, 34);
            this.lblCombustível.Name = "lblCombustível";
            this.lblCombustível.Size = new System.Drawing.Size(115, 13);
            this.lblCombustível.TabIndex = 8;
            this.lblCombustível.Text = "Nome do Combustível:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "R$";
            // 
            // frmAlterarCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.tbxPreco);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblCombustível);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarCombustivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar dados do Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCombustível;
        private System.Windows.Forms.Label label1;
    }
}