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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxCpf.Text == "   ,   ,   -")
            {
                MessageBox.Show("Favor digitar o cpf");
                maskedTextBoxCpf.Focus();
            }
            else
            {

                Conexao con = new Conexao();
                Modelos mod = new Modelos();

                mod.Nome = textBoxNome.Text;
                mod.Cpf = maskedTextBoxCpf.Text;
                mod.Rg = maskedTextBoxRG.Text;
                mod.Expedicao = maskedTextBoxExpedição.Text;

                if (radioButtonMasculino.Checked)
                {
                    mod.Sexo = "Masculino";
                }
                else
                {

                    mod.Sexo = "Feminino";
                }
                mod.Nascimento = maskedTextBoxNascimento.Text;
                mod.Civil = comboBoxEstCivil.Text;

                mod.Endereço = textBoxEndereço.Text;
                mod.Cep = maskedTextBoxCEP.Text;
                mod.Numero = textBoxNumero.Text;
                mod.Bairro = textBoxBairro.Text;
                mod.Cidade = textBoxCidade.Text;
                mod.Uf = comboBoxEstado.Text;
                mod.Telefone = maskedTextBoxTelefone.Text;
                mod.Celular = maskedTextBoxCelular.Text;
                mod.Email = textBoxEmail.Text;
                mod.Observacao = richTextBoxObservacao.Text;


                con.CadCliente(mod);

                MessageBox.Show("Cadastro Efetuado com sucesso !");

                textBoxNome.Text = "";
                maskedTextBoxCpf.Text = "";
                maskedTextBoxRG.Text = "";
                maskedTextBoxExpedição.Text = "";
                radioButtonFeminino.Text = "";
                radioButtonMasculino.Text = "";
                maskedTextBoxNascimento.Text = "";
                comboBoxEstCivil.Text = "";
                textBoxEndereço.Text = "";
                maskedTextBoxCEP.Text = "";
                textBoxNumero.Text = "";
                textBoxBairro.Text = "";
                textBoxCidade.Text = "";
                comboBoxEstado.Text = "";
                maskedTextBoxTelefone.Text = "";
                maskedTextBoxCelular.Text = "";
                textBoxEmail.Text = "";
                richTextBoxObservacao.Text = "";

                this.Close();
            }
        }


        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            maskedTextBoxCpf.Clear();
            maskedTextBoxRG.Clear();
            maskedTextBoxExpedição.Clear();
            maskedTextBoxNascimento.ResetText();
            comboBoxEstCivil.ResetText();
            textBoxEndereço.Clear();
            textBoxNumero.Clear();
            maskedTextBoxCEP.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            comboBoxEstado.ResetText();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxCelular.Clear();
            textBoxEmail.Clear();
            radioButtonMasculino.Checked = false;
            radioButtonFeminino.Checked = false;
        }



    }
}