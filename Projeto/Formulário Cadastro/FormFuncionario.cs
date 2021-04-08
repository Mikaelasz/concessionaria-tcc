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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
       
            textBoxNome.Clear();
            maskedTextBoxCpf.Clear();
            maskedTextBoxRG.Clear();
            maskedTextBoxEmissao.Clear();
            comboBoxSexo.ResetText(); ;
            comboBoxCivil.ResetText();
            maskedTextBoxNascimento.ResetText();
            maskedTextBoxCarteira.Clear();
            textBoxEndereço.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            comboBoxEstado.ResetText();
            maskedTextBoxCEP.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxCelular.Clear();
            textBoxEmail.Clear();
            textBoxCargo.Clear();
            maskedTextBoxContratação.Clear();
            textBoxSalario.Clear();
            richTextBoxObservação.Clear();


        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Projeto.Camada_de_Negócio.Funcionario fun = new Projeto.Camada_de_Negócio.Funcionario();
            Conexao con = new Conexao();


            fun.Nome = textBoxNome.Text;
            fun.Cpf = maskedTextBoxCpf.Text;
            fun.Rg = maskedTextBoxRG.Text;
            fun.Emissao = maskedTextBoxEmissao.Text;
            fun.Sexo = comboBoxSexo.Text;
            fun.Civil = comboBoxCivil.Text;
            fun.Nascimento = maskedTextBoxNascimento.Text;
            fun.Trabalho = maskedTextBoxCarteira.Text;
            fun.Endereco = textBoxEndereço.Text;
            fun.Numero = textBoxNumero.Text;
            fun.Bairro = textBoxBairro.Text;
            fun.Cidade = textBoxCidade.Text;
            fun.Uf = comboBoxEstado.Text;
            fun.Cep = maskedTextBoxCEP.Text;
            fun.Telefone = maskedTextBoxTelefone.Text;
            fun.Celular = maskedTextBoxCelular.Text;
            fun.Email = textBoxEmail.Text;
            fun.Cargo = textBoxCargo.Text;
            fun.Contratacao = maskedTextBoxContratação.Text;
            fun.Salario = textBoxSalario.Text;
            fun.Observacao = richTextBoxObservação.Text;

            con.CadasFunc(fun);

            MessageBox.Show("Cadastro Efetuado com sucesso !");

            textBoxNome.Text = "";
            maskedTextBoxCpf.Text = "";
            maskedTextBoxRG.Text = "";
            maskedTextBoxEmissao.Text = "";
            comboBoxSexo.Text = "";
            comboBoxCivil.Text = "";
            maskedTextBoxNascimento.Text = "";
            maskedTextBoxCarteira.Text = "";
            textBoxEndereço.Text = "";
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            comboBoxEstado.Text = "";
            maskedTextBoxCEP.Text = "";
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxCelular.Text = "";
            textBoxEmail.Text = "";
            textBoxCargo.Text = "";
            maskedTextBoxContratação.Text = "";
            textBoxSalario.Text = "";
            richTextBoxObservação.Text = "";


        }
    }
}
