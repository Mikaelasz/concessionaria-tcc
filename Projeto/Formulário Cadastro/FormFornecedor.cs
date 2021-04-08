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
using Projeto.Camada_de_Negócio;

namespace Projeto.Formulário_Cadastro
{
    public partial class Fornecedor : Form
    {
        
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxCNPJ.Text == "  ,   ,   /    -  ")
            {
                MessageBox.Show("Favor digitar o cnpj");
                maskedTextBoxCNPJ.Focus();
            }

            else
            {
                
                Projeto.Camada_de_Negócio.Fornecedor forn = new Projeto.Camada_de_Negócio.Fornecedor();
                Conexao con = new Conexao();


                forn.Razao = textBoxRazão.Text;
                forn.Cnpj = maskedTextBoxCNPJ.Text;
                forn.Fantasia = textBoxFantasia.Text;
                forn.Estadual = maskedTextBoxEstadual.Text;
                forn.Endereco = textBoxEndereço.Text;
                forn.Numero = textBoxNumero.Text;
                forn.Cep = maskedTextBoxCEP.Text;
                forn.Bairro = textBoxBairro.Text;
                forn.Cidade = textBoxCidade.Text;
                forn.Estado = comboBoxEstado.Text;
                forn.Telefone = maskedTextBoxTelefone.Text;
                forn.Celular = maskedTextBoxCelular.Text;
                forn.Email = textBoxEmail.Text;
                forn.Observacao = richTextBoxComentarios.Text;

                con.CadasFornec(forn);

                MessageBox.Show("Cadastro Efetuado com sucesso !");

                textBoxRazão.Text = "";
                maskedTextBoxCNPJ.Text = "";
                textBoxFantasia.Text = "";
                maskedTextBoxEstadual.Text = "";
                textBoxEndereço.Text = "";
                textBoxNumero.Text = "";
                maskedTextBoxCEP.Text = "";
                textBoxBairro.Text = "";
                textBoxCidade.Text = "";
                comboBoxEstado.Text = "";
                maskedTextBoxTelefone.Text = "";
                maskedTextBoxCelular.Text = "";
                textBoxEmail.Text = "";
                richTextBoxComentarios.Text = "";

                this.Close();
               
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void Fornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
