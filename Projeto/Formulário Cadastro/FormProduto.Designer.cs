namespace Projeto.Formulário_Cadastro
{
    partial class FormProduto
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
            this.textBoxVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxChassi = new System.Windows.Forms.TextBox();
            this.textBoxAnoModelo = new System.Windows.Forms.TextBox();
            this.textBoxFabricação = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVeículo = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxVenda);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.maskedTextBoxPlaca);
            this.panel1.Controls.Add(this.comboBoxCombustivel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxMarca);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxChassi);
            this.panel1.Controls.Add(this.textBoxAnoModelo);
            this.panel1.Controls.Add(this.textBoxFabricação);
            this.panel1.Controls.Add(this.textBoxModelo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelVeículo);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 114);
            this.panel1.TabIndex = 0;
            // 
            // textBoxVenda
            // 
            this.textBoxVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVenda.Location = new System.Drawing.Point(741, 65);
            this.textBoxVenda.Name = "textBoxVenda";
            this.textBoxVenda.Size = new System.Drawing.Size(85, 23);
            this.textBoxVenda.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(629, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Valor da Venda";
            // 
            // maskedTextBoxPlaca
            // 
            this.maskedTextBoxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPlaca.Location = new System.Drawing.Point(548, 66);
            this.maskedTextBoxPlaca.Mask = "AAA-0000";
            this.maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            this.maskedTextBoxPlaca.Size = new System.Drawing.Size(71, 23);
            this.maskedTextBoxPlaca.TabIndex = 6;
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "Alcool",
            "Gasolina",
            "Alcool/Gasolina",
            "Diesel",
            "Etanol"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(681, 30);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(94, 24);
            this.comboBoxCombustivel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(591, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Combustível";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboBoxMarca.Location = new System.Drawing.Point(68, 65);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMarca.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Marca";
            // 
            // textBoxChassi
            // 
            this.textBoxChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChassi.Location = new System.Drawing.Point(281, 67);
            this.textBoxChassi.Name = "textBoxChassi";
            this.textBoxChassi.Size = new System.Drawing.Size(199, 23);
            this.textBoxChassi.TabIndex = 5;
            // 
            // textBoxAnoModelo
            // 
            this.textBoxAnoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnoModelo.Location = new System.Drawing.Point(514, 28);
            this.textBoxAnoModelo.MaxLength = 4;
            this.textBoxAnoModelo.Name = "textBoxAnoModelo";
            this.textBoxAnoModelo.Size = new System.Drawing.Size(57, 23);
            this.textBoxAnoModelo.TabIndex = 2;
            // 
            // textBoxFabricação
            // 
            this.textBoxFabricação.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFabricação.Location = new System.Drawing.Point(379, 28);
            this.textBoxFabricação.MaxLength = 4;
            this.textBoxFabricação.Name = "textBoxFabricação";
            this.textBoxFabricação.Size = new System.Drawing.Size(57, 23);
            this.textBoxFabricação.TabIndex = 1;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModelo.Location = new System.Drawing.Point(78, 28);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(213, 23);
            this.textBoxModelo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chassi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fabricação";
            // 
            // labelVeículo
            // 
            this.labelVeículo.AutoSize = true;
            this.labelVeículo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeículo.Location = new System.Drawing.Point(18, 31);
            this.labelVeículo.Name = "labelVeículo";
            this.labelVeículo.Size = new System.Drawing.Size(54, 17);
            this.labelVeículo.TabIndex = 0;
            this.labelVeículo.Text = "Modelo";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(265, 141);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(90, 34);
            this.buttonCadastrar.TabIndex = 8;
            this.buttonCadastrar.Text = "&Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(361, 141);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(90, 34);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "&Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Location = new System.Drawing.Point(457, 141);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(88, 34);
            this.buttonFechar.TabIndex = 10;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonFechar;
            this.ClientSize = new System.Drawing.Size(837, 194);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVeículo;
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxChassi;
        private System.Windows.Forms.TextBox textBoxAnoModelo;
        private System.Windows.Forms.TextBox textBoxFabricação;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaca;
        private System.Windows.Forms.TextBox textBoxVenda;
        private System.Windows.Forms.Label label8;
    }
}