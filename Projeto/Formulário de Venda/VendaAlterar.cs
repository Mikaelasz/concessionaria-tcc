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

namespace Projeto.Formulário_de_Venda
{
    public partial class VendaAlterar : Form
    {

        private MySqlConnection conexao;
        //CAMINHO USADO NA FUNCAO DATA GRID
        string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";
        string id;
        MySqlConnection objConect = null;
        MySqlCommand objCommand = null;


        public VendaAlterar()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
             id = textBoxID.Text;

            string MySQLExibir = "SELECT * FROM tb_venda WHERE Ven_ID=" + id + "";

            objConect = new MySqlConnection(caminho);

            objCommand = new MySqlCommand(MySQLExibir, objConect);

            MySqlDataAdapter objADP = new MySqlDataAdapter(objCommand);

            DataTable dtlista = new DataTable();

            objADP.Fill(dtlista);

            foreach (DataRow dr in dtlista.Rows)
            {
                maskedTextBoxPlaca.Text = dr["Ven_Placa"].ToString();
                textBoxChassi.Text = dr["Ven_Veiculo"].ToString();
                textBoxVeiculo.Text = dr["Ven_Veiculo"].ToString();
                textBoxModelo.Text = dr["Ven_Modelo"].ToString();
                textBoxFabricacao.Text = dr["Ven_Fabricacao"].ToString();
                textBoxVenda.Text = dr["Ven_Venda"].ToString();
                maskedTextBoxData.Text = dr["Ven_Data"].ToString();
                textBoxHora.Text = dr["Ven_Hora"].ToString();
                textBoxVendedor.Text = dr["Ven_Vendedor"].ToString();
                textBoxComissao.Text = dr["Ven_Comissao"].ToString();
                textBoxNome.Text = dr["Ven_Nome"].ToString();
                maskedTextBoxCpf.Text = dr["Ven_Cpf"].ToString();
                maskedTextBoxRg.Text = dr["Ven_Rg"].ToString();
                maskedTextBoxExpedicao.Text = dr["Ven_Expedicao"].ToString();
                maskedTextBoxNascimento.Text = dr["Ven_Nascimento"].ToString();
                if (dr["Ven_Sexo"].ToString() == "Masculino")
                {
                    radioButtonMasculino.Checked = true;
                    //dr["Cli_Sexo"].ToString();
                }


                else
                {
                    radioButtonFeminino.Checked = true;
                }
                comboBoxCivil.Text = dr["Ven_Civil"].ToString();
                textBoxEndereco.Text = dr["Ven_Endereco"].ToString();
                textBoxNumero.Text = dr["Ven_Numero"].ToString();
                maskedTextBoxCep.Text = dr["Ven_Cep"].ToString();
                textBoxBairro.Text = dr["Ven_Bairro"].ToString();
                textBoxCidade.Text = dr["Ven_Cidade"].ToString();
                comboBoxUF.Text = dr["Ven_Uf"].ToString();
                maskedTextBoxTelefone.Text = dr["Ven_Telefone"].ToString();
                maskedTextBoxCelular.Text = dr["Ven_Celular"].ToString();
                textBoxEmail.Text = dr["Ven_Email"].ToString();
                
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            CVenda AlterVen = new CVenda();

            AlterVen.Placa = maskedTextBoxPlaca.Text;
            AlterVen.Chassi = textBoxChassi.Text;
            AlterVen.Veiculo = textBoxVeiculo.Text;
            AlterVen.Modelo = textBoxModelo.Text;
            AlterVen.Fabricacao = textBoxFabricacao.Text;
            AlterVen.Valorveiculo = Int32.Parse(textBoxVenda.Text);            
            AlterVen.Data = maskedTextBoxData.Text;
            AlterVen.Hora = textBoxHora.Text;
            AlterVen.Nome = textBoxNome.Text;
            AlterVen.Cpf = maskedTextBoxCpf.Text;
            AlterVen.Rg = maskedTextBoxRg.Text;
            AlterVen.Expedicao = maskedTextBoxExpedicao.Text;
            AlterVen.Nascimento = maskedTextBoxNascimento.Text;
            if (radioButtonMasculino.Checked)
            {
                AlterVen.Sexo = "Masculino";
            }
            else
            {

                AlterVen.Sexo = "Feminino";
            }
            AlterVen.Civil = comboBoxCivil.Text;
            AlterVen.Endereco = textBoxEndereco.Text;
            AlterVen.Numero = textBoxNumero.Text;
            AlterVen.Cep = maskedTextBoxCep.Text;
            AlterVen.Bairro = textBoxBairro.Text;
            AlterVen.Cidade = textBoxCidade.Text;
            AlterVen.Estado = comboBoxUF.Text;
            AlterVen.Telefone = maskedTextBoxTelefone.Text;
            AlterVen.Celular = maskedTextBoxCelular.Text;
            AlterVen.Email = textBoxEmail.Text;

            con.AlterarVenda(AlterVen, textBoxID.Text);

            MessageBox.Show("Alteração Realizada com sucesso !");

            maskedTextBoxPlaca.Text = "";
            textBoxChassi.Text = "";
            textBoxVeiculo.Text = "";
            textBoxModelo.Text = "";
            textBoxFabricacao.Text = "";
            textBoxVenda.Text = "";
            maskedTextBoxData.Text = "";
            textBoxHora.Text = "";
            textBoxNome.Text = "";
            maskedTextBoxCpf.Text = "";
            maskedTextBoxRg.Text = "";
            maskedTextBoxExpedicao.Text = "";
            maskedTextBoxNascimento.Text = "";
            radioButtonFeminino.Text = "";
            radioButtonMasculino.Text = "";
            comboBoxCivil.Text = "";
            textBoxEndereco.Text = "";
            textBoxNumero.Text = "";
            maskedTextBoxCep.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            comboBoxUF.Text = "";
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxCelular.Text = "";
            textBoxEmail.Text = "";

            this.Close();

        }
    }
}
