using MySql.Data.MySqlClient;
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
    public partial class FuncionarioAlterar : Form
    {

        private MySqlConnection conexao;
        //CAMINHO USADO NA FUNCAO DATA GRID
        string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";
        string id;
        MySqlConnection objConect = null;
        MySqlCommand objCommand = null;

        public FuncionarioAlterar()
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

            string MySQLExibir = "SELECT * FROM tb_funcionario WHERE Func_Id=" + id + "";

            objConect = new MySqlConnection(caminho);

            objCommand = new MySqlCommand(MySQLExibir, objConect);

            MySqlDataAdapter objADP = new MySqlDataAdapter(objCommand);

            DataTable dtlista = new DataTable();

            objADP.Fill(dtlista);

            foreach (DataRow dr in dtlista.Rows)
            {

                textBoxNome.Text = dr["Func_Nome"].ToString();
                maskedTextBoxCpf1.Text = dr["Func_Cpf"].ToString();
                maskedTextBoxRG.Text = dr["Func_Rg"].ToString();
                maskedTextBoxEmissao.Text = dr["Func_Emissao"].ToString();
                comboBoxSexo.Text = dr["Func_Sexo"].ToString();
                comboBoxCivil.Text = dr["Func_Civil"].ToString();
                maskedTextBoxNascimento.Text = dr["Func_Nascimento"].ToString();
                maskedTextBoxCarteira.Text = dr["Func_Trabalho"].ToString();
                textBoxEndereço.Text = dr["Func_Endereco"].ToString();
                textBoxNumero.Text = dr["Func_Numero"].ToString();
                textBoxBairro.Text = dr["Func_Bairro"].ToString();
                textBoxCidade.Text = dr["Func_Cidade"].ToString();
                comboBoxEstado.Text = dr["Func_Uf"].ToString();
                maskedTextBoxCEP.Text = dr["Func_Cep"].ToString();
                maskedTextBoxTelefone.Text = dr["Func_Telefone"].ToString();
                maskedTextBoxCelular.Text = dr["Func_Celular"].ToString();
                textBoxEmail.Text = dr["Func_Email"].ToString();
                textBoxCargo.Text = dr["Func_Cargo"].ToString();
                maskedTextBoxContratação.Text = dr["Func_Contratacao"].ToString();
                textBoxSalario.Text = dr["Func_Salario"].ToString();
                richTextBoxObservacao.Text = dr["Func_Observacao"].ToString();
                
            }
        }
    }
}
