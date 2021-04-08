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
    public partial class FornecedorAlterar : Form
    {
        
        private MySqlConnection conexao;
        //CAMINHO USADO NA FUNCAO DATA GRID
        string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";
        string id;
        string cnpj;
        string estadual;
        MySqlConnection objConect = null;
        MySqlCommand objCommand = null;

        public FornecedorAlterar()
        {
            InitializeComponent();
        }

       
        private void buttonFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            id = textBoxID.Text;

            string MySQLExibir = "SELECT * FROM tb_fornecedor WHERE For_Id=" + id + "";

            objConect = new MySqlConnection(caminho);

            objCommand = new MySqlCommand(MySQLExibir, objConect);

            MySqlDataAdapter objADP = new MySqlDataAdapter(objCommand);

            DataTable dtlista = new DataTable();

            objADP.Fill(dtlista);

            foreach (DataRow dr in dtlista.Rows)
            {

                textBoxRazao.Text = dr["For_Razao"].ToString();
                maskedTextBoxCnpjj.Text = dr["For_Cnpj"].ToString();
                textBoxFantasia.Text = dr["For_Fantasia"].ToString();
                maskedTextBoxInsEstadual.Text = dr["For_Estadual"].ToString();
                textBoxEndereco.Text = dr["For_Endereco"].ToString();
                textBoxNumero.Text = dr["For_Numero"].ToString();
                maskedTextBoxCep.Text = dr["For_Cep"].ToString();
                textBoxBairro.Text = dr["For_Bairro"].ToString();
                textBoxCidade.Text = dr["For_Cidade"].ToString();
                comboBoxUF.Text = dr["For_Estado"].ToString();
                maskedTextBoxTelefone.Text = dr["For_Telefone"].ToString();
                maskedTextBoxCelular.Text = dr["For_Celular"].ToString();
                textBoxEmail.Text = dr["For_Email"].ToString();
                richTextBoxObservacao.Text = dr["For_Observacao"].ToString();
            }
        }

        private void labelID_Click(object sender, EventArgs e)
        {
            textBoxID.Visible = true;
            maskedTextBoxInscrição.Visible = true;
        }

        private void textBoxID_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxCNPJ.Visible = false;
            maskedTextBoxInscrição.Visible = false;
        }

        private void labelCnpj_Click(object sender, EventArgs e)
        {
            maskedTextBoxCNPJ.Visible = true;
            maskedTextBoxInscrição.Visible = true;
        }

        private void maskedTextBoxCNPJ_Click(object sender, EventArgs e)
        {
            textBoxID.Visible = false;
            maskedTextBoxInscrição.Visible = false;
        }

        private void labelEstadual_Click(object sender, EventArgs e)
        {
            maskedTextBoxInscrição.Visible = true;
            maskedTextBoxCNPJ.Visible = true;
            textBoxID.Visible = true;
        }

        private void maskedTextBoxInscrição_Click(object sender, EventArgs e)
        {
            textBoxID.Visible = false;
            maskedTextBoxCNPJ.Visible = false;
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            Fornecedor AlterFor = new Fornecedor();

            AlterFor.Razao = textBoxRazao.Text;
            AlterFor.Cnpj = maskedTextBoxCnpjj.Text;
            AlterFor.Fantasia = textBoxFantasia.Text;
            AlterFor.Estadual = maskedTextBoxInsEstadual.Text;
            AlterFor.Endereco = textBoxEndereco.Text;
            AlterFor.Numero = textBoxNumero.Text;
            AlterFor.Cep = maskedTextBoxCep.Text;
            AlterFor.Bairro = textBoxBairro.Text;
            AlterFor.Cidade = textBoxCidade.Text;
            AlterFor.Estado = comboBoxUF.Text;
            AlterFor.Telefone = maskedTextBoxTelefone.Text;
            AlterFor.Celular = maskedTextBoxCelular.Text;
            AlterFor.Email = textBoxEmail.Text;
            AlterFor.Observacao = richTextBoxObservacao.Text;


            con.AlterFornec(AlterFor, textBoxID.Text);

            MessageBox.Show("Alteração Realizada com sucesso !");

            textBoxRazao.Text = "";
            maskedTextBoxCnpjj.Text = "";
            textBoxFantasia.Text = "";
            maskedTextBoxInsEstadual.Text = "" ;
            textBoxEndereco.Text = "" ;
            textBoxNumero.Text = "";
            maskedTextBoxCep.Text = "";
            textBoxBairro.Text = "" ;
            textBoxCidade.Text = "";
            comboBoxUF.Text = "" ;
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxCelular.Text = "";
            textBoxEmail.Text = "";
            richTextBoxObservacao.Text = "";


        }

        public Modelos AlterFor { get; set; }
    }
}
