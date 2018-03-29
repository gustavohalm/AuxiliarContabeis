namespace AuxiliarContabeis
{
    partial class Cadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.lblDeclaracao = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txbIdade = new System.Windows.Forms.MaskedTextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.mTxbDD = new System.Windows.Forms.MaskedTextBox();
            this.mTxbNumero = new System.Windows.Forms.MaskedTextBox();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbNumEndereco = new System.Windows.Forms.TextBox();
            this.txbProfissao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComo = new System.Windows.Forms.Label();
            this.txbComo = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.boxRenda = new System.Windows.Forms.ComboBox();
            this.boxDeclarou = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(68, 23);
            this.lblNome.Margin = new System.Windows.Forms.Padding(20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(65, 107);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(20);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF:";
            this.lblCpf.Click += new System.EventHandler(this.lblCpf_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(65, 169);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(20);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            this.lblEndereco.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(65, 200);
            this.lblProfissao.Margin = new System.Windows.Forms.Padding(20);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(53, 13);
            this.lblProfissao.TabIndex = 3;
            this.lblProfissao.Text = "Profissão:";
            this.lblProfissao.Click += new System.EventHandler(this.lblProfissao_Click);
            // 
            // lblDeclaracao
            // 
            this.lblDeclaracao.AutoSize = true;
            this.lblDeclaracao.Location = new System.Drawing.Point(65, 231);
            this.lblDeclaracao.Margin = new System.Windows.Forms.Padding(20);
            this.lblDeclaracao.Name = "lblDeclaracao";
            this.lblDeclaracao.Size = new System.Drawing.Size(124, 13);
            this.lblDeclaracao.TabIndex = 4;
            this.lblDeclaracao.Text = "Declarou Anteriormente?";
            this.lblDeclaracao.Click += new System.EventHandler(this.lblDeclaracao_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(65, 76);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(20);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade:";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(65, 138);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(20);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCadastrar.Location = new System.Drawing.Point(174, 433);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(195, 42);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Realizar Cadastro";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(230, 107);
            this.txbCpf.Mask = "000.000.000-00";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(106, 20);
            this.txbCpf.TabIndex = 8;
            this.txbCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txbCpf_MaskInputRejected);
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(230, 73);
            this.txbIdade.Mask = "000";
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(26, 20);
            this.txbIdade.TabIndex = 9;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(230, 20);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(217, 20);
            this.txbNome.TabIndex = 10;
            // 
            // mTxbDD
            // 
            this.mTxbDD.Location = new System.Drawing.Point(230, 138);
            this.mTxbDD.Mask = "00";
            this.mTxbDD.Name = "mTxbDD";
            this.mTxbDD.Size = new System.Drawing.Size(26, 20);
            this.mTxbDD.TabIndex = 11;
            this.mTxbDD.Text = "15";
            // 
            // mTxbNumero
            // 
            this.mTxbNumero.Location = new System.Drawing.Point(262, 138);
            this.mTxbNumero.Name = "mTxbNumero";
            this.mTxbNumero.Size = new System.Drawing.Size(97, 20);
            this.mTxbNumero.TabIndex = 12;
            // 
            // txbRua
            // 
            this.txbRua.Location = new System.Drawing.Point(230, 169);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(155, 20);
            this.txbRua.TabIndex = 13;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(441, 169);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(100, 20);
            this.txbBairro.TabIndex = 14;
            // 
            // txbNumEndereco
            // 
            this.txbNumEndereco.Location = new System.Drawing.Point(391, 169);
            this.txbNumEndereco.Name = "txbNumEndereco";
            this.txbNumEndereco.Size = new System.Drawing.Size(31, 20);
            this.txbNumEndereco.TabIndex = 15;
            // 
            // txbProfissao
            // 
            this.txbProfissao.Location = new System.Drawing.Point(230, 200);
            this.txbProfissao.Name = "txbProfissao";
            this.txbProfissao.Size = new System.Drawing.Size(155, 20);
            this.txbProfissao.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Renda:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblComo
            // 
            this.lblComo.AutoSize = true;
            this.lblComo.Location = new System.Drawing.Point(65, 387);
            this.lblComo.Name = "lblComo";
            this.lblComo.Size = new System.Drawing.Size(154, 13);
            this.lblComo.TabIndex = 21;
            this.lblComo.Text = "Como conheceu o IR da Unip?";
            // 
            // txbComo
            // 
            this.txbComo.Location = new System.Drawing.Point(230, 387);
            this.txbComo.Name = "txbComo";
            this.txbComo.Size = new System.Drawing.Size(100, 20);
            this.txbComo.TabIndex = 22;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(418, 387);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(62, 13);
            this.lblResposta.TabIndex = 23;
            this.lblResposta.Text = "lblResposta";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(230, 47);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(217, 20);
            this.txbEmail.TabIndex = 24;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(68, 47);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(20);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email:";
            // 
            // boxRenda
            // 
            this.boxRenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxRenda.FormattingEnabled = true;
            this.boxRenda.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.boxRenda.Items.AddRange(new object[] {
            "Um a Dois Salários minimos",
            "Dois a Três Salários minimos",
            "Três a Quatro Salários minimos",
            "Mais que Quatro Salários minimos"});
            this.boxRenda.Location = new System.Drawing.Point(230, 294);
            this.boxRenda.Name = "boxRenda";
            this.boxRenda.Size = new System.Drawing.Size(121, 21);
            this.boxRenda.TabIndex = 26;
            this.boxRenda.TabStop = false;
            // 
            // boxDeclarou
            // 
            this.boxDeclarou.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDeclarou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxDeclarou.FormattingEnabled = true;
            this.boxDeclarou.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.boxDeclarou.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.boxDeclarou.Location = new System.Drawing.Point(230, 231);
            this.boxDeclarou.Name = "boxDeclarou";
            this.boxDeclarou.Size = new System.Drawing.Size(121, 21);
            this.boxDeclarou.TabIndex = 27;
            this.boxDeclarou.TabStop = false;
            this.boxDeclarou.SelectedIndexChanged += new System.EventHandler(this.boxDeclarou_SelectedIndexChanged);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(573, 525);
            this.Controls.Add(this.boxDeclarou);
            this.Controls.Add(this.boxRenda);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txbComo);
            this.Controls.Add(this.lblComo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbProfissao);
            this.Controls.Add(this.txbNumEndereco);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbRua);
            this.Controls.Add(this.mTxbNumero);
            this.Controls.Add(this.mTxbDD);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblDeclaracao);
            this.Controls.Add(this.lblProfissao);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.Text = "Auxiliar - Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label lblDeclaracao;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox txbCpf;
        private System.Windows.Forms.MaskedTextBox txbIdade;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.MaskedTextBox mTxbDD;
        private System.Windows.Forms.MaskedTextBox mTxbNumero;
        private System.Windows.Forms.TextBox txbRua;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.TextBox txbNumEndereco;
        private System.Windows.Forms.TextBox txbProfissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComo;
        private System.Windows.Forms.TextBox txbComo;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox boxRenda;
        private System.Windows.Forms.ComboBox boxDeclarou;
    }
}

