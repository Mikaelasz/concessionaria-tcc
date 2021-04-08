using Projeto.Camada_de_Negócio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Formulário_Cadastro
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Projeto.Camada_de_Negócio.Produto prod = new Projeto.Camada_de_Negócio.Produto(); 
            Conexao con = new Conexao();

            prod.Modelo = textBoxModelo.Text;
            prod.Fabricação = textBoxFabricação.Text;
            prod.Ano = textBoxAnoModelo.Text;
            prod.Marca = comboBoxMarca.Text;
            prod.Chassi = textBoxChassi.Text;
            prod.Placa = maskedTextBoxPlaca.Text;
            prod.Combustivel = comboBoxCombustivel.Text;
            prod.Valor = Int32.Parse(textBoxVenda.Text);
                        

            con.CadasProd(prod);

            MessageBox.Show("Cadastro Efetuado com sucesso !");

            textBoxModelo.Text = "";
            textBoxFabricação.Text = "";
            textBoxAnoModelo.Text = "";
            comboBoxMarca.Text = "";
            textBoxChassi.Text = "";
            maskedTextBoxPlaca.Text = "";
            comboBoxCombustivel.Text = "";
            textBoxVenda.Text = "";


        }
    }
}
