using MySql.Data.MySqlClient;
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

namespace Projeto.Formulário_Consulta
{
    public partial class ClienteAlterar : Form
    {

        private MySqlConnection conexao;
        //CAMINHO USADO NA FUNCAO DATA GRID
        string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";
        string id;
        MySqlConnection objConect = null;
        MySqlCommand objCommand = null;


        public ClienteAlterar()
        {
            InitializeComponent();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {


            id = textBoxID.Text;
           
            string MySQLExibir = "SELECT * FROM tb_cliente WHERE Cli_Id=" + id + "";
            
            
            //"Cli_Cpf=" cpf+ "";

            objConect = new MySqlConnection(caminho);

            objCommand = new MySqlCommand(MySQLExibir, objConect);

            MySqlDataAdapter objADP = new MySqlDataAdapter(objCommand);

            DataTable dtlista = new DataTable();

            objADP.Fill(dtlista);

            foreach (DataRow dr in dtlista.Rows)
            {
                textBoxNome.Text = dr["Cli_Nome"].ToString();
                maskedTextBoxCpf2.Text = dr["Cli_Cpf"].ToString();
                maskedTextBoxRg.Text = dr["Cli_Rg"].ToString();
                maskedTextBoxExpedicao.Text = dr["Cli_Expedicao"].ToString();

                if (dr["Cli_Sexo"].ToString() == "Masculino")
                {
                    radioButtonMasculino.Checked = true;
                    //dr["Cli_Sexo"].ToString();
                }
                

                else
                {
                    radioButtonFeminino.Checked = true;
                }
                radioButtonFeminino.Text = dr["Cli_Sexo"].ToString();
                maskedTextBoxNascimento.Text = dr["Cli_Nascimento"].ToString();
                comboBoxCivil.Text = dr["Cli_Civil"].ToString();
                textBoxEndereco.Text = dr["Cli_Endereco"].ToString();
                textBoxNumero.Text = dr["Cli_Numero"].ToString();
                maskedTextBoxCep.Text = dr["Cli_Cep"].ToString();
                textBoxBairro.Text = dr["Cli_Bairro"].ToString();
                textBoxCidade.Text = dr["Cli_Cidade"].ToString();
                comboBoxEstado.Text = dr["Cli_Uf"].ToString();
                maskedTextBoxTelefone.Text = dr["Cli_Telefone"].ToString();
                maskedTextBoxCelular.Text = dr["Cli_Celular"].ToString();
                textBoxEmail.Text = dr["Cli_Email"].ToString();
                richTextBoxObservacao.Text = dr["Cli_Observacao"].ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            Modelos AlterCl = new Modelos();

            AlterCl.Nome = textBoxNome.Text;
            AlterCl.Cpf = maskedTextBoxCpf2.Text;
            AlterCl.Rg = maskedTextBoxRg.Text;
            AlterCl.Expedicao = maskedTextBoxExpedicao.Text;

            if (radioButtonMasculino.Checked)
            {
                AlterCl.Sexo = "Masculino";
            }
            else
            {

                AlterCl.Sexo = "Feminino";
            }
            AlterCl.Nascimento = maskedTextBoxNascimento.Text;
            AlterCl.Civil = comboBoxCivil.Text;

            AlterCl.Endereço = textBoxEndereco.Text;
            AlterCl.Cep = maskedTextBoxCep.Text;
            AlterCl.Numero = textBoxNumero.Text;
            AlterCl.Bairro = textBoxBairro.Text;
            AlterCl.Cidade = textBoxCidade.Text;
            AlterCl.Uf = comboBoxEstado.Text;
            AlterCl.Telefone = maskedTextBoxTelefone.Text;
            AlterCl.Celular = maskedTextBoxCelular.Text;
            AlterCl.Email = textBoxEmail.Text;
            AlterCl.Observacao = richTextBoxObservacao.Text;


            con.AlterCliente(AlterCl, textBoxID.Text);

            MessageBox.Show("Alteração Realizada com sucesso !");

            textBoxNome.Text = "";
            maskedTextBoxCpf2.Text = "";
            maskedTextBoxRg.Text = "";
            maskedTextBoxExpedicao.Text = "";
            radioButtonFeminino.Text = "";
            radioButtonMasculino.Text = "";
            maskedTextBoxNascimento.Text = "";
            comboBoxCivil.Text = "";
            textBoxEndereco.Text = "";
            maskedTextBoxCep.Text = "";
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

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBoxID_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxCPF.Visible = false;
        }

        private void maskedTextBoxCPF_Click(object sender, EventArgs e)
        {
            textBoxID.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            maskedTextBoxCPF.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBoxID.Visible = true;
        }

        public string cpf { get; set; }
    }
}
