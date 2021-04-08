namespace Projeto.Formulário_Consulta
{
    partial class FornecedorAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FornecedorAlterar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.maskedTextBoxInscrição = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelEstadual = new System.Windows.Forms.Label();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.richTextBoxObservacao = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxUF = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxInsEstadual = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFantasia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxCnpjj = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRazao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 152);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe o método da consulta !";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonConsultar);
            this.panel2.Controls.Add(this.maskedTextBoxInscrição);
            this.panel2.Controls.Add(this.maskedTextBoxCNPJ);
            this.panel2.Controls.Add(this.textBoxID);
            this.panel2.Controls.Add(this.labelEstadual);
            this.panel2.Controls.Add(this.labelCnpj);
            this.panel2.Controls.Add(this.labelID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(200, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 152);
            this.panel2.TabIndex = 2;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(275, 69);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "&Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // maskedTextBoxInscrição
            // 
            this.maskedTextBoxInscrição.Location = new System.Drawing.Point(139, 99);
            this.maskedTextBoxInscrição.Mask = "000/0000000";
            this.maskedTextBoxInscrição.Name = "maskedTextBoxInscrição";
            this.maskedTextBoxInscrição.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxInscrição.TabIndex = 2;
            this.maskedTextBoxInscrição.Click += new System.EventHandler(this.maskedTextBoxInscrição_Click);
            // 
            // maskedTextBoxCNPJ
            // 
            this.maskedTextBoxCNPJ.Location = new System.Drawing.Point(69, 73);
            this.maskedTextBoxCNPJ.Mask = "00.000.000/0000-00";
            this.maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            this.maskedTextBoxCNPJ.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCNPJ.TabIndex = 1;
            this.maskedTextBoxCNPJ.Click += new System.EventHandler(this.maskedTextBoxCNPJ_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(65, 47);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(76, 20);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxID_MouseClick);
            // 
            // labelEstadual
            // 
            this.labelEstadual.AutoSize = true;
            this.labelEstadual.Location = new System.Drawing.Point(29, 107);
            this.labelEstadual.Name = "labelEstadual";
            this.labelEstadual.Size = new System.Drawing.Size(94, 13);
            this.labelEstadual.TabIndex = 2;
            this.labelEstadual.Text = "Inscrição Estadual";
            this.labelEstadual.Click += new System.EventHandler(this.labelEstadual_Click);
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Location = new System.Drawing.Point(29, 79);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(34, 13);
            this.labelCnpj.TabIndex = 2;
            this.labelCnpj.Text = "CNPJ";
            this.labelCnpj.Click += new System.EventHandler(this.labelCnpj_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(29, 50);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonFechar);
            this.panel3.Controls.Add(this.buttonAlterar);
            this.panel3.Controls.Add(this.richTextBoxObservacao);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.textBoxEmail);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.maskedTextBoxCelular);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.maskedTextBoxTelefone);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.comboBoxUF);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBoxCidade);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBoxBairro);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.maskedTextBoxCep);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBoxNumero);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBoxEndereco);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.maskedTextBoxInsEstadual);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBoxFantasia);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.maskedTextBoxCnpjj);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBoxRazao);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 329);
            this.panel3.TabIndex = 3;
            // 
            // buttonFechar
            // 
            this.buttonFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFechar.Location = new System.Drawing.Point(364, 294);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(93, 27);
            this.buttonFechar.TabIndex = 19;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click_1);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(246, 294);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(93, 27);
            this.buttonAlterar.TabIndex = 18;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // richTextBoxObservacao
            // 
            this.richTextBoxObservacao.Location = new System.Drawing.Point(88, 208);
            this.richTextBoxObservacao.Name = "richTextBoxObservacao";
            this.richTextBoxObservacao.Size = new System.Drawing.Size(583, 68);
            this.richTextBoxObservacao.TabIndex = 17;
            this.richTextBoxObservacao.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Observação";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(424, 171);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(247, 20);
            this.textBoxEmail.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(379, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "E-mail";
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(251, 171);
            this.maskedTextBoxCelular.Mask = "(00) 00000-0000";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCelular.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(206, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Celular";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(72, 171);
            this.maskedTextBoxTelefone.Mask = "(00) 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTelefone.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Telefone";
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxUF.Location = new System.Drawing.Point(546, 134);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(68, 21);
            this.comboBoxUF.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(517, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "UF";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(357, 134);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(137, 20);
            this.textBoxCidade.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Cidade";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(57, 134);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(224, 20);
            this.textBoxBairro.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Bairro";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(540, 99);
            this.maskedTextBoxCep.Mask = "00.000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxCep.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(506, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "CEP";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(434, 99);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(48, 20);
            this.textBoxNumero.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nº";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(76, 99);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(301, 20);
            this.textBoxEndereco.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Endereço";
            // 
            // maskedTextBoxInsEstadual
            // 
            this.maskedTextBoxInsEstadual.Location = new System.Drawing.Point(531, 56);
            this.maskedTextBoxInsEstadual.Mask = "000/0000000";
            this.maskedTextBoxInsEstadual.Name = "maskedTextBoxInsEstadual";
            this.maskedTextBoxInsEstadual.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxInsEstadual.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Inscrição Estadual";
            // 
            // textBoxFantasia
            // 
            this.textBoxFantasia.Location = new System.Drawing.Point(101, 60);
            this.textBoxFantasia.Name = "textBoxFantasia";
            this.textBoxFantasia.Size = new System.Drawing.Size(298, 20);
            this.textBoxFantasia.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nome Fantasia";
            // 
            // maskedTextBoxCnpjj
            // 
            this.maskedTextBoxCnpjj.Location = new System.Drawing.Point(546, 20);
            this.maskedTextBoxCnpjj.Mask = "00.000.000/0000-00";
            this.maskedTextBoxCnpjj.Name = "maskedTextBoxCnpjj";
            this.maskedTextBoxCnpjj.Size = new System.Drawing.Size(113, 20);
            this.maskedTextBoxCnpjj.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "CNPJ";
            // 
            // textBoxRazao
            // 
            this.textBoxRazao.Location = new System.Drawing.Point(101, 20);
            this.textBoxRazao.Name = "textBoxRazao";
            this.textBoxRazao.Size = new System.Drawing.Size(356, 20);
            this.textBoxRazao.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Razão Social";
            // 
            // FornecedorAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonFechar;
            this.ClientSize = new System.Drawing.Size(698, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FornecedorAlterar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Fornecedor";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCNPJ;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelEstadual;
        private System.Windows.Forms.Label labelCnpj;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInscrição;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxRazao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCnpjj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFantasia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInsEstadual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxUF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelular;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.RichTextBox richTextBoxObservacao;
    }
}