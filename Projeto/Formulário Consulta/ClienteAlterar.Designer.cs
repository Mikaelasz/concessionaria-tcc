namespace Projeto.Formulário_Consulta
{
    partial class ClienteAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteAlterar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCpf2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxExpedicao = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCivil = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.richTextBoxObservacao = new System.Windows.Forms.RichTextBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.maskedTextBoxNascimento = new System.Windows.Forms.MaskedTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 144);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maskedTextBoxCPF);
            this.panel2.Controls.Add(this.textBoxID);
            this.panel2.Controls.Add(this.buttonConsultar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(212, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 144);
            this.panel2.TabIndex = 1;
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(153, 66);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCPF.TabIndex = 1;
            this.maskedTextBoxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCPF_MaskInputRejected);
            this.maskedTextBoxCPF.Click += new System.EventHandler(this.maskedTextBoxCPF_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(137, 29);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(84, 20);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxID_MouseClick);
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(274, 40);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(90, 31);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.Text = "&Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "CPF";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFechar.Location = new System.Drawing.Point(375, 491);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(90, 31);
            this.buttonFechar.TabIndex = 22;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(53, 185);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(338, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // maskedTextBoxCpf2
            // 
            this.maskedTextBoxCpf2.Location = new System.Drawing.Point(496, 181);
            this.maskedTextBoxCpf2.Mask = "000.000.000-00";
            this.maskedTextBoxCpf2.Name = "maskedTextBoxCpf2";
            this.maskedTextBoxCpf2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCpf2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "RG";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTextBoxRg
            // 
            this.maskedTextBoxRg.Location = new System.Drawing.Point(58, 222);
            this.maskedTextBoxRg.Mask = "00.000.000-0";
            this.maskedTextBoxRg.Name = "maskedTextBoxRg";
            this.maskedTextBoxRg.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxRg.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data de Expedição";
            // 
            // maskedTextBoxExpedicao
            // 
            this.maskedTextBoxExpedicao.Location = new System.Drawing.Point(283, 222);
            this.maskedTextBoxExpedicao.Mask = "00/00/0000";
            this.maskedTextBoxExpedicao.Name = "maskedTextBoxExpedicao";
            this.maskedTextBoxExpedicao.Size = new System.Drawing.Size(81, 20);
            this.maskedTextBoxExpedicao.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sexo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(456, 221);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 7;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(567, 221);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 8;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Data de Nascimento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Estado Civil";
            // 
            // comboBoxCivil
            // 
            this.comboBoxCivil.FormattingEnabled = true;
            this.comboBoxCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)",
            "Viúvo(a)",
            "Separado(a)"});
            this.comboBoxCivil.Location = new System.Drawing.Point(486, 255);
            this.comboBoxCivil.Name = "comboBoxCivil";
            this.comboBoxCivil.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCivil.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Endereço";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(76, 291);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(297, 20);
            this.textBoxEndereco.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Nº";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(413, 291);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(82, 20);
            this.textBoxNumero.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(513, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "CEP";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(553, 291);
            this.maskedTextBoxCep.Mask = "00.000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBoxCep.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Bairro";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(67, 326);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(232, 20);
            this.textBoxBairro.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(367, 326);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(190, 20);
            this.textBoxCidade.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(575, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "UF";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
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
            this.comboBoxEstado.Location = new System.Drawing.Point(602, 321);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(71, 21);
            this.comboBoxEstado.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 362);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Telefone";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(72, 359);
            this.maskedTextBoxTelefone.Mask = "(00) 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxTelefone.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(179, 362);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Celular";
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(224, 359);
            this.maskedTextBoxCelular.Mask = "(00) 00000-0000";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxCelular.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(334, 362);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(386, 359);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(287, 20);
            this.textBoxEmail.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 396);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Observação";
            // 
            // richTextBoxObservacao
            // 
            this.richTextBoxObservacao.Location = new System.Drawing.Point(88, 396);
            this.richTextBoxObservacao.Name = "richTextBoxObservacao";
            this.richTextBoxObservacao.Size = new System.Drawing.Size(588, 71);
            this.richTextBoxObservacao.TabIndex = 20;
            this.richTextBoxObservacao.Text = "";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(265, 491);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(90, 31);
            this.buttonAlterar.TabIndex = 21;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBoxNascimento
            // 
            this.maskedTextBoxNascimento.Location = new System.Drawing.Point(146, 258);
            this.maskedTextBoxNascimento.Mask = "00/00/0000";
            this.maskedTextBoxNascimento.Name = "maskedTextBoxNascimento";
            this.maskedTextBoxNascimento.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxNascimento.TabIndex = 9;
            // 
            // ClienteAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonFechar;
            this.ClientSize = new System.Drawing.Size(694, 534);
            this.Controls.Add(this.maskedTextBoxNascimento);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.richTextBoxObservacao);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.maskedTextBoxCelular);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxCivil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButtonFeminino);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBoxExpedicao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxRg);
            this.Controls.Add(this.maskedTextBoxCpf2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteAlterar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxExpedicao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCivil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelular;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox richTextBoxObservacao;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNascimento;
    }
}