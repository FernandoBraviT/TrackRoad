﻿namespace PIM_TRACKROAD
{
    partial class frmAlterarMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarMotorista));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCombustiveis = new System.Windows.Forms.ComboBox();
            this.tbxVeiculoMarca = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.tbxVeiculoKm = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.tbxVeiculoAno = new System.Windows.Forms.TextBox();
            this.lblTipoComb = new System.Windows.Forms.Label();
            this.lblKml = new System.Windows.Forms.Label();
            this.tbxVeiculoModelo = new System.Windows.Forms.TextBox();
            this.tbxVeiculoTipo = new System.Windows.Forms.TextBox();
            this.tbxCnh = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblCnh = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(394, 230);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCombustiveis);
            this.groupBox1.Controls.Add(this.tbxVeiculoMarca);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.tbxVeiculoKm);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.lblAno);
            this.groupBox1.Controls.Add(this.tbxVeiculoAno);
            this.groupBox1.Controls.Add(this.lblTipoComb);
            this.groupBox1.Controls.Add(this.lblKml);
            this.groupBox1.Controls.Add(this.tbxVeiculoModelo);
            this.groupBox1.Controls.Add(this.tbxVeiculoTipo);
            this.groupBox1.Location = new System.Drawing.Point(6, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 139);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Veículo";
            // 
            // cbxCombustiveis
            // 
            this.cbxCombustiveis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCombustiveis.FormattingEnabled = true;
            this.cbxCombustiveis.Location = new System.Drawing.Point(111, 107);
            this.cbxCombustiveis.Name = "cbxCombustiveis";
            this.cbxCombustiveis.Size = new System.Drawing.Size(117, 21);
            this.cbxCombustiveis.TabIndex = 33;
            // 
            // tbxVeiculoMarca
            // 
            this.tbxVeiculoMarca.Location = new System.Drawing.Point(350, 49);
            this.tbxVeiculoMarca.Name = "tbxVeiculoMarca";
            this.tbxVeiculoMarca.Size = new System.Drawing.Size(100, 20);
            this.tbxVeiculoMarca.TabIndex = 15;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(2, 32);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(86, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo de Veículo:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(108, 33);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(100, 13);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo do Veículo:";
            // 
            // tbxVeiculoKm
            // 
            this.tbxVeiculoKm.Location = new System.Drawing.Point(234, 108);
            this.tbxVeiculoKm.Name = "tbxVeiculoKm";
            this.tbxVeiculoKm.Size = new System.Drawing.Size(110, 20);
            this.tbxVeiculoKm.TabIndex = 18;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(349, 33);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(95, 13);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca do Veículo:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(2, 91);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(100, 13);
            this.lblAno.TabIndex = 10;
            this.lblAno.Text = "Ano de Fabricação:";
            // 
            // tbxVeiculoAno
            // 
            this.tbxVeiculoAno.Location = new System.Drawing.Point(5, 108);
            this.tbxVeiculoAno.Name = "tbxVeiculoAno";
            this.tbxVeiculoAno.Size = new System.Drawing.Size(100, 20);
            this.tbxVeiculoAno.TabIndex = 16;
            // 
            // lblTipoComb
            // 
            this.lblTipoComb.AutoSize = true;
            this.lblTipoComb.Location = new System.Drawing.Point(109, 91);
            this.lblTipoComb.Name = "lblTipoComb";
            this.lblTipoComb.Size = new System.Drawing.Size(108, 13);
            this.lblTipoComb.TabIndex = 11;
            this.lblTipoComb.Text = "Tipo de Combustível:";
            // 
            // lblKml
            // 
            this.lblKml.AutoSize = true;
            this.lblKml.Location = new System.Drawing.Point(231, 92);
            this.lblKml.Name = "lblKml";
            this.lblKml.Size = new System.Drawing.Size(50, 13);
            this.lblKml.TabIndex = 12;
            this.lblKml.Text = "Km/Litro:";
            // 
            // tbxVeiculoModelo
            // 
            this.tbxVeiculoModelo.Location = new System.Drawing.Point(111, 49);
            this.tbxVeiculoModelo.Name = "tbxVeiculoModelo";
            this.tbxVeiculoModelo.Size = new System.Drawing.Size(233, 20);
            this.tbxVeiculoModelo.TabIndex = 14;
            // 
            // tbxVeiculoTipo
            // 
            this.tbxVeiculoTipo.Location = new System.Drawing.Point(5, 49);
            this.tbxVeiculoTipo.Name = "tbxVeiculoTipo";
            this.tbxVeiculoTipo.Size = new System.Drawing.Size(100, 20);
            this.tbxVeiculoTipo.TabIndex = 13;
            // 
            // tbxCnh
            // 
            this.tbxCnh.Location = new System.Drawing.Point(339, 38);
            this.tbxCnh.Name = "tbxCnh";
            this.tbxCnh.Size = new System.Drawing.Size(122, 20);
            this.tbxCnh.TabIndex = 31;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(16, 38);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(317, 20);
            this.tbxNome.TabIndex = 30;
            // 
            // lblCnh
            // 
            this.lblCnh.AutoSize = true;
            this.lblCnh.Location = new System.Drawing.Point(336, 22);
            this.lblCnh.Name = "lblCnh";
            this.lblCnh.Size = new System.Drawing.Size(33, 13);
            this.lblCnh.TabIndex = 29;
            this.lblCnh.Text = "CNH:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(99, 13);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome do Motorista:";
            // 
            // frmAlterarMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxCnh);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblCnh);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar dados de motorista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxVeiculoMarca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox tbxVeiculoKm;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox tbxVeiculoAno;
        private System.Windows.Forms.Label lblTipoComb;
        private System.Windows.Forms.Label lblKml;
        private System.Windows.Forms.TextBox tbxVeiculoModelo;
        private System.Windows.Forms.TextBox tbxVeiculoTipo;
        private System.Windows.Forms.TextBox tbxCnh;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblCnh;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbxCombustiveis;
    }
}