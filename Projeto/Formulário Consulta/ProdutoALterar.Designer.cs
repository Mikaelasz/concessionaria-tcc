namespace Projeto.Formulário_Consulta
{
    partial class ProdutoALterar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.textBoxChass = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPlac = new System.Windows.Forms.MaskedTextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxChassi = new System.Windows.Forms.TextBox();
            this.textBoxAnoModelo = new System.Windows.Forms.TextBox();
            this.textBoxFabricação = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelVeículo = new System.Windows.Forms.Label();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxVenda = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Projeto.Properties.Resources.Índice;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 186);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonConsultar);
            this.panel2.Controls.Add(this.textBoxChass);
            this.panel2.Controls.Add(this.maskedTextBoxPlac);
            this.panel2.Controls.Add(this.textBoxID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 186);
            this.panel2.TabIndex = 1;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(256, 78);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(87, 25);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "&Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // textBoxChass
            // 
            this.textBoxChass.Location = new System.Drawing.Point(58, 130);
            this.textBoxChass.Name = "textBoxChass";
            this.textBoxChass.Size = new System.Drawing.Size(200, 20);
            this.textBoxChass.TabIndex = 2;
            // 
            // maskedTextBoxPlac
            // 
            this.maskedTextBoxPlac.Location = new System.Drawing.Point(53, 104);
            this.maskedTextBoxPlac.Mask = "AAA-0000";
            this.maskedTextBoxPlac.Name = "maskedTextBoxPlac";
            this.maskedTextBoxPlac.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPlac.TabIndex = 1;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(53, 75);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Chassi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Informe o método da consulta !";
            // 
            // maskedTextBoxPlaca
            // 
            this.maskedTextBoxPlaca.Location = new System.Drawing.Point(460, 245);
            this.maskedTextBoxPlaca.Mask = "AAA-0000";
            this.maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            this.maskedTextBoxPlaca.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBoxPlaca.TabIndex = 9;
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "Alcool",
            "Gasolina",
            "Alcool/Gasolina",
            "Diesel",
            "Etanol"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(610, 245);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(75, 21);
            this.comboBoxCombustivel.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Combustível";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "Aston MArtin",
            "Audi",
            "Bentley",
            "BMW",
            "Chery",
            "Chrysler",
            "Citroen",
            "Chevrolet",
            "Dodge",
            "Ferrari",
            "Ford",
            "Fiat",
            "Hyundai",
            "Honda",
            "Jaguar",
            "Jeep",
            "Jac",
            "Kia",
            "Land Rover",
            "Lamborghini",
            "Mini",
            "Mitsubishi",
            "Mercedes Benz",
            "Nissan",
            "Porsche",
            "Peugeot",
            "Renault",
            "Suzuki",
            "Smart",
            "Toyota",
            "Volvo",
            "Volkswagen"});
            this.comboBoxMarca.Location = new System.Drawing.Point(62, 245);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(98, 21);
            this.comboBoxMarca.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Marca";
            // 
            // textBoxChassi
            // 
            this.textBoxChassi.Location = new System.Drawing.Point(215, 245);
            this.textBoxChassi.Name = "textBoxChassi";
            this.textBoxChassi.Size = new System.Drawing.Size(199, 20);
            this.textBoxChassi.TabIndex = 8;
            // 
            // textBoxAnoModelo
            // 
            this.textBoxAnoModelo.Location = new System.Drawing.Point(484, 208);
            this.textBoxAnoModelo.Name = "textBoxAnoModelo";
            this.textBoxAnoModelo.Size = new System.Drawing.Size(57, 20);
            this.textBoxAnoModelo.TabIndex = 6;
            // 
            // textBoxFabricação
            // 
            this.textBoxFabricação.Location = new System.Drawing.Point(357, 208);
            this.textBoxFabricação.Name = "textBoxFabricação";
            this.textBoxFabricação.Size = new System.Drawing.Size(57, 20);
            this.textBoxFabricação.TabIndex = 5;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(62, 208);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(213, 20);
            this.textBoxModelo.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Chassi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Placa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Modelo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fabricação";
            // 
            // labelVeículo
            // 
            this.labelVeículo.AutoSize = true;
            this.labelVeículo.Location = new System.Drawing.Point(12, 211);
            this.labelVeículo.Name = "labelVeículo";
            this.labelVeículo.Size = new System.Drawing.Size(42, 13);
            this.labelVeículo.TabIndex = 26;
            this.labelVeículo.Text = "Modelo";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(239, 309);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(96, 30);
            this.buttonAlterar.TabIndex = 12;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(341, 309);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(96, 30);
            this.buttonFechar.TabIndex = 13;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Valor da Venda ";
            // 
            // textBoxVenda
            // 
            this.textBoxVenda.Location = new System.Drawing.Point(92, 282);
            this.textBoxVenda.Name = "textBoxVenda";
            this.textBoxVenda.Size = new System.Drawing.Size(99, 20);
            this.textBoxVenda.TabIndex = 11;
            // 
            // ProdutoALterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 361);
            this.Controls.Add(this.textBoxVenda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.maskedTextBoxPlaca);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBoxCombustivel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.labelVeículo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxChassi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAnoModelo);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxFabricação);
            this.Name = "ProdutoALterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoALterar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.TextBox textBoxChass;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlac;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaca;
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxChassi;
        private System.Windows.Forms.TextBox textBoxAnoModelo;
        private System.Windows.Forms.TextBox textBoxFabricação;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelVeículo;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxVenda;
    }
}