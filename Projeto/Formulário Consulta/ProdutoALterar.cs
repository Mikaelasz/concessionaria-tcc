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
    public partial class ProdutoALterar : Form
    {
        private MySqlConnection conexao;
        //CAMINHO USADO NA FUNCAO DATA GRID
        string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";
        string id;
        MySqlConnection objConect = null;
        MySqlCommand objCommand = null;


        public ProdutoALterar()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
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

                textBoxModelo.Text = dr["Prod_Modelo"].ToString();
                textBoxFabricação.Text = dr["Prod_Fabricacao"].ToString();
                textBoxAnoModelo.Text = dr["Prod_Ano"].ToString();
               comboBoxMarca.Text = dr["Prod_Marca"].ToString();
                textBoxChassi.Text = dr["Prod_Chassi"].ToString();
                maskedTextBoxPlaca.Text = dr["Prod_Placa"].ToString();
                comboBoxCombustivel.Text = dr["Prod_Combustivel"].ToString();
                textBoxVenda.Text = dr["Prod_Venda"].ToString();
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
