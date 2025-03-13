namespace TN01_WFCadastroEndereco
{
    partial class FormCadastroEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroEndereco));
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            btnSalvar = new Button();
            lblLinha = new Label();
            lblCep = new Label();
            txtLogradouro = new TextBox();
            lblLogradouro = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            mtbCep = new MaskedTextBox();
            txtNumero = new TextBox();
            chkSemNumero = new CheckBox();
            txtBairro = new TextBox();
            lblUf = new Label();
            lblBairro = new Label();
            lblNumero = new Label();
            cbxUf = new ComboBox();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(37, 18);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(99, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo:";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(37, 36);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(411, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(333, 302);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 40);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblLinha
            // 
            lblLinha.BackColor = SystemColors.AppWorkspace;
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(37, 77);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(400, 1);
            lblLinha.TabIndex = 9;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(37, 92);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 10;
            lblCep.Text = "Cep:";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(37, 162);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(157, 23);
            txtLogradouro.TabIndex = 3;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(37, 144);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(72, 15);
            lblLogradouro.TabIndex = 12;
            lblLogradouro.Text = "Logradouro:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(37, 257);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(315, 23);
            txtCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(37, 239);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(47, 15);
            lblCidade.TabIndex = 16;
            lblCidade.Text = "Cidade:";
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(37, 110);
            mtbCep.Mask = "00000-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(100, 23);
            mtbCep.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(216, 162);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 4;
            // 
            // chkSemNumero
            // 
            chkSemNumero.AutoSize = true;
            chkSemNumero.Location = new Point(333, 162);
            chkSemNumero.Name = "chkSemNumero";
            chkSemNumero.Size = new Size(101, 19);
            chkSemNumero.TabIndex = 0;
            chkSemNumero.Text = "Sem Número?";
            chkSemNumero.UseVisualStyleBackColor = true;
            chkSemNumero.CheckedChanged += chkSemNumero_CheckedChanged;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(216, 208);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(232, 23);
            txtBairro.TabIndex = 6;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(364, 237);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(24, 15);
            lblUf.TabIndex = 23;
            lblUf.Text = "UF:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(223, 189);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 24;
            lblBairro.Text = "Bairro:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(217, 142);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 25;
            lblNumero.Text = "Número:";
            // 
            // cbxUf
            // 
            cbxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUf.FormattingEnabled = true;
            cbxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUf.Location = new Point(364, 257);
            cbxUf.Name = "cbxUf";
            cbxUf.Size = new Size(84, 23);
            cbxUf.TabIndex = 8;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(37, 208);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(157, 23);
            txtComplemento.TabIndex = 5;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(37, 190);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(87, 15);
            lblComplemento.TabIndex = 28;
            lblComplemento.Text = "Complemento:";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(240, 316);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(76, 26);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormCadastroEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 381);
            Controls.Add(btnVoltar);
            Controls.Add(lblComplemento);
            Controls.Add(txtComplemento);
            Controls.Add(chkSemNumero);
            Controls.Add(cbxUf);
            Controls.Add(lblNumero);
            Controls.Add(lblBairro);
            Controls.Add(lblUf);
            Controls.Add(txtBairro);
            Controls.Add(txtNumero);
            Controls.Add(mtbCep);
            Controls.Add(txtCidade);
            Controls.Add(lblCidade);
            Controls.Add(txtLogradouro);
            Controls.Add(lblLogradouro);
            Controls.Add(lblCep);
            Controls.Add(lblLinha);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroEndereco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Button btnSalvar;
        private Label lblLinha;
        private Label lblCep;
        private TextBox txtLogradouro;
        private Label lblLogradouro;
        private TextBox textBox3;
        private Label label4;
        private TextBox txtCidade;
        private Label lblCidade;
        private MaskedTextBox mtbCep;
        private TextBox txtNumero;
        private GroupBox gbxSemNumero;
        private CheckBox chkSemNumero;
        private TextBox txtBairro;
        private Label lblUf;
        private Label lblBairro;
        private Label lblNumero;
        private ComboBox cbxUf;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private Button btnVoltar;
    }
}