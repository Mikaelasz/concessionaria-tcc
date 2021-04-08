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
    public partial class FormVenda : Form
    {

        private MySqlConnection conexao;
        //CAMINHO USADO NA FUNCAO DATA GRID
        string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";
        string id;
        string idvenda;
        string idcli;
        int valor;
        MySqlConnection objConect = null;
        MySqlCommand objCommand = null;


        public FormVenda()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            id = textBoxID.Text;

            string MySQLExibir = "SELECT * FROM tb_produto WHERE Prod_Id=" + id + "";


            objConect = new MySqlConnection(caminho);

            objCommand = new MySqlCommand(MySQLExibir, objConect);

            MySqlDataAdapter objADP = new MySqlDataAdapter(objCommand);

            DataTable dtlista = new DataTable();

            objADP.Fill(dtlista);

            foreach (DataRow dr in dtlista.Rows)
            {

                textBoIdCliente.Text = dr["Prod_Id"].ToString();
                maskedTextBoxPlaca.Text = dr["Prod_Placa"].ToString();
                textBoxChassi.Text = dr["Prod_Chassi"].ToString();
                textBoxVeiculo.Text = dr["Prod_Modelo"].ToString();
                textBoxFabricacao.Text = dr["Prod_Fabricacao"].ToString();
                textBoxModelo.Text = dr["Prod_Ano"].ToString();               
                textBoxVenda.Text = dr["Prod_Venda"].ToString();

            }
        }

        private void textBoxVeiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idvenda = textBoxIdVen.Text;

            string MySQLExibir = "SELECT * FROM tb_funcionario WHERE Func_Id=" + idvenda + "";


            objConect = new MySqlConnection(caminho);

            objCommand = new MySqlCommand(MySQLExibir, objConect);

            MySqlDataAdapter objADP = new MySqlDataAdapter(objCommand);

            DataTable dtlista = new DataTable();

            objADP.Fill(dtlista);

            foreach (DataRow dr in dtlista.Rows)
            {
                textBoxIdVen.Text = dr["Func_Id"].ToString();
                textBoxVendedor.Text = dr["Func_Nome"].ToString();
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            CVenda venda = new CVenda();
            Conexao con = new Conexao();

            venda.Placa = maskedTextBoxPlaca.Text;
            venda.Chassi = textBoxChassi.Text;
            venda.Veiculo = textBoxVeiculo.Text;
            venda.Modelo = textBoxModelo.Text;
            venda.Fabricacao = textBoxFabricacao.Text;
            venda.Valorveiculo = Int32.Parse(textBoxVenda.Text); 
            venda.Data = maskedTextBoxData.Text;
            venda.Hora = textBoxHora.Text;
            venda.Vendedor = textBoxVendedor.Text;
            venda.Comissao = Int32.Parse(textBoxComissao.Text);
            venda.Nome = textBoxNome.Text;
            venda.Cpf = maskedTextBoxCpf.Text;
            venda.Rg = maskedTextBoxRg.Text;
            venda.Expedicao = maskedTextBoxExpedicao.Text;
            venda.Nascimento = maskedTextBoxNascimento.Text;
            if (radioButtonMasculino.Checked)
            {
                venda.Sexo = "Masculino";
            }
            else
            {

                venda.Sexo = "Feminino";
            }
            venda.Civil = comboBoxCivil.Text;
            venda.Endereco = textBoxEndereco.Text;
            venda.Numero = textBoxNumero.Text;
            venda.Cep = maskedTextBoxCep.Text;
            venda.Bairro = textBoxBairro.Text;
            venda.Cidade = textBoxCidade.Text;
            venda.Estado = comboBoxUF.Text;
            venda.Telefone = maskedTextBoxTelefone.Text;
            venda.Celular = maskedTextBoxCelular.Text;
            venda.Email = textBoxEmail.Text;

            con.CadasVenda(venda);

            MessageBox.Show("Cadastro Efetuado com sucesso !");

            maskedTextBoxPlaca.Text = "";
            maskedTextBoxPlaca.Text = "";
            textBoxChassi.Text = "";
            textBoxVeiculo.Text = "";
            textBoxModelo.Text = "";
            textBoxFabricacao.Text = "";
            textBoxVenda.Text = "";
            maskedTextBoxData.Text = "";
            textBoxHora.Text = "";
            textBoxVendedor.Text = "";
            textBoxComissao.Text = "";
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

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            idcli = textBoIdCliente.Text;

            string MySQLExibir = "SELECT * FROM tb_cliente WHERE Cli_Id=" + idcli + "";


            objConect = new MySqlConnection(caminho);

            objCommand = new MySqlCommand(MySQLExibir, objConect);

            MySqlDataAdapter objADP = new MySqlDataAdapter(objCommand);

            DataTable dtlista = new DataTable();

            objADP.Fill(dtlista);

            foreach (DataRow dr in dtlista.Rows)
            {

                textBoIdCliente.Text = dr["Cli_Id"].ToString();
                textBoxNome.Text = dr["Cli_Nome"].ToString();
                maskedTextBoxCpf.Text = dr["Cli_Cpf"].ToString();
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
                maskedTextBoxNascimento.Text = dr["Cli_Nascimento"].ToString();
                comboBoxCivil.Text = dr["Cli_Civil"].ToString();
                textBoxEndereco.Text = dr["Cli_Endereco"].ToString();
                textBoxNumero.Text = dr["Cli_Numero"].ToString();
                maskedTextBoxCep.Text = dr["Cli_Cep"].ToString();
                textBoxBairro.Text = dr["Cli_Bairro"].ToString();
                textBoxCidade.Text = dr["Cli_Cidade"].ToString();
                comboBoxUF.Text = dr["Cli_Uf"].ToString();
                maskedTextBoxTelefone.Text = dr["Cli_Telefone"].ToString();
                maskedTextBoxCelular.Text = dr["Cli_Celular"].ToString();
                textBoxEmail.Text = dr["Cli_Email"].ToString();         


            }
        
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxExpedicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBoIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxIdVen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxComissao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxFabricacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBoxModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxChassi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            

            int valor1, valor2, resultado;
            resultado = int.Parse(textBoxVenda.Text) * int.Parse(textBoxComissao.Text);
            textBoxTotal.Text = @" " + resultado;
            //textBoxQuantE3
        }
    }
}
