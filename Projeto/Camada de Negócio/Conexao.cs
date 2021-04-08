using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Camada_de_Negócio;
using MySql.Data.MySqlClient;


namespace Projeto.Camada_de_Negócio
{
    class Conexao
    {
        public MySqlConnection banco;

        private string vsql;

        #region CadastroCliente
        public void CadCliente(Modelos mod)
        {
            string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";

            try
            {
                banco = new MySqlConnection(caminho);
                banco.Open();

                vsql = "INSERT INTO tb_cliente(Cli_Nome, Cli_Cpf, Cli_Rg, Cli_Expedicao, Cli_Sexo, Cli_Nascimento, " +
                "Cli_Civil, Cli_Endereco, Cli_Numero, Cli_Cep, Cli_Cidade, Cli_Bairro, Cli_Uf, Cli_Telefone, Cli_Celular, Cli_Email, Cli_Observacao)" +
                "values ('" + mod.Nome + "', '" + mod.Cpf + "', '" + mod.Rg + "', '" + mod.Expedicao + "', '" + mod.Sexo + "', '" + mod.Nascimento + "'," +
                " '" + mod.Civil + "', '" + mod.Endereço + "', '" + mod.Numero + "', '" + mod.Cep + "', '" + mod.Bairro + "', '" + mod.Cidade + "', '" + mod.Uf + "', " +
                " '" + mod.Telefone + "', '" + mod.Celular + "', '" + mod.Email + "', '" + mod.Observacao + "')";

                MySqlCommand comandos = new MySqlCommand(vsql, banco);
                comandos.ExecuteNonQuery();
                banco.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Comandos: " + ex.Message, "AVISO");
            }

        }

        #endregion

        #region CadastroFornecedor
        public void CadasFornec(Fornecedor forn)
        {
            string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";

            try
            {
                banco = new MySqlConnection(caminho);
                banco.Open();

                vsql = "INSERT INTO tb_fornecedor (For_Razao, For_Cnpj, For_Fantasia, For_Estadual, For_Endereco,  For_Numero, For_Cep, For_Bairro, For_Cidade, For_Estado, For_Telefone, For_Celular, For_Email, For_Observacao) values ('" + forn.Razao + "', '" + forn.Cnpj + "',  '" + forn.Fantasia + "', '" + forn.Estadual + "', '" + forn.Endereco + "', '" + forn.Numero + "', '" + forn.Cep + "', '" + forn.Bairro + "', '" + forn.Cidade + "', '" + forn.Estado + "', '" + forn.Telefone + "', '" + forn.Celular + "', '" + forn.Email + "', '" + forn.Observacao + "')";

                MySqlCommand comandos = new MySqlCommand(vsql, banco);
                comandos.ExecuteNonQuery();
                banco.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Comandos: " + ex.Message, "AVISO");
            }
        }

        #endregion

        #region CadastroFuncionario
        public void CadasFunc(Funcionario fun)
        {
            string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";

            try
            {
                banco = new MySqlConnection(caminho);
                banco.Open();

                vsql = "INSERT INTO tb_funcionario (Func_Nome, Func_Cpf, Func_Rg, Func_Emissao, Func_Sexo, Func_Civil, Func_Nascimento," +
                "Func_Trabalho, Func_Endereco, Func_Numero, Func_Bairro, Func_Cidade, Func_Uf, Func_Cep, Func_Telefone, Func_Celular, Func_Email," +
                "Func_Cargo, Func_Contratacao, Func_Salario, Func_Observacao) values ('" + fun.Nome + "', '" + fun.Cpf + "', '" + fun.Rg + "', '" + fun.Emissao + "', '" + fun.Sexo + "', '" + fun.Civil + "', '" + fun.Nascimento + "', '" + fun.Trabalho + "', '" + fun.Endereco + "', '" + fun.Numero + "', '" + fun.Bairro + "', '" + fun.Cidade + "', '" + fun.Uf + "', '" + fun.Cep + "', '" + fun.Telefone + "', '" + fun.Celular + "', '" + fun.Email + "', '" + fun.Cargo + "', '" + fun.Contratacao + "', '" + fun.Salario + "', '" + fun.Observacao + "')";
                MySqlCommand comandos = new MySqlCommand(vsql, banco);
                comandos.ExecuteNonQuery();
                banco.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Comandos: " + ex.Message, "AVISO");
            }
        }
        #endregion

        #region CadastroProduto
        public void CadasProd(Produto produ)
        {
            string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";

            try
            {
                banco = new MySqlConnection(caminho);
                banco.Open();

                vsql = "INSERT INTO tb_produto (Prod_Modelo, Prod_Fabricacao, Prod_Ano, Prod_Zero, Prod_Marca, Prod_Chassi, Prod_Placa, " +
                       "Prod_Combustivel, Prod_Venda) values('" + produ.Modelo + "', '" + produ.Fabricação + "', '" + produ.Ano + "', '" + produ.Zero + "', " +
                       " '" + produ.Marca + "', '" + produ.Chassi + "', '" + produ.Placa + "', '" + produ.Combustivel + "', '" +produ.Valor+ "')";
                MySqlCommand comandos = new MySqlCommand(vsql, banco);
                comandos.ExecuteNonQuery();
                banco.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Comandos: " + ex.Message, "AVISO");
            }
        }
        #endregion

        #region CadastroVenda
        public void CadasVenda(CVenda venda)
        {
            string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";

            try
            {
                banco = new MySqlConnection(caminho);
                banco.Open();

                vsql = "INSERT INTO tb_venda (Ven_Placa, Ven_Nome, Ven_Cpf, Ven_Rg, Ven_Expedicao, Ven_Nascimento, Ven_Sexo, Ven_Civil, Ven_Endereco, " + 
                    "Ven_Numero, Ven_Cep, Ven_Bairro, Ven_Cidade, Ven_Uf, Ven_Telefone, Ven_Celular, Ven_Comissao, Ven_Data, Ven_Hora, Ven_Chassi, Ven_Veiculo, Ven_Modelo, Ven_Fabricacao) values " +
                    "('"+ venda.Nome + "', '" + venda.Cpf + "', '" + venda.Rg + "', '" + venda.Expedicao + "', '" + venda.Nascimento + "', '"+venda.Sexo +"', " +
                " '"+venda.Civil+ "', '"+venda.Endereco+"', + '" + venda.Numero + "', '" + venda.Cep + "', '" + venda.Bairro + "', '" + venda.Cidade + "', " +
                " '" + venda.Estado + "' , '" + venda.Telefone + "', '" + venda.Celular + "', '" + venda.Comissao + "', '" + venda.Data + "' , '" + venda.Hora + "', "+
                " '" + venda.Placa+"', '"+venda.Chassi+"', '"+venda.Veiculo+"' , '"+venda.Modelo+"', '" +venda.Fabricacao+ "')";
                MySqlCommand comandos = new MySqlCommand(vsql, banco);
                comandos.ExecuteNonQuery();
                banco.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Comandos: " + ex.Message, "AVISO");
            }
        }
        #endregion

        #region AlterarCliente
        public void AlterCliente(Modelos AlterCl, string clienteID)
        {
            string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";

            try
            {
                banco = new MySqlConnection(caminho);
                banco.Open();

                vsql = "UPDATE tb_cliente set cli_nome = '" + AlterCl.Nome + "', cli_cpf = '" + AlterCl.Cpf + "', cli_rg= '" + AlterCl.Rg + "', cli_expedicao= '" + AlterCl.Expedicao + "', cli_sexo= '" + AlterCl.Sexo + "', cli_nascimento= '" + AlterCl.Nascimento + "'," +
                    "cli_civil= '" + AlterCl.Civil + "', cli_endereco= '" + AlterCl.Endereço + "', cli_numero= '" + AlterCl.Numero + "', Cli_Cep= '" + AlterCl.Cep + "', Cli_Cidade= '" + AlterCl.Cidade + "', Cli_Bairro= '" + AlterCl.Bairro + "', Cli_Uf= '" + AlterCl.Uf + "', Cli_Telefone= '" + AlterCl.Telefone + "', Cli_Celular= '" + AlterCl.Celular + "'," +
                    "Cli_Email= '" + AlterCl.Email + "', Cli_Observacao= '" + AlterCl.Observacao + "' where cli_id = '" + clienteID + "'";



                System.Windows.Forms.MessageBox.Show(vsql);

                MySqlCommand comandos = new MySqlCommand(vsql, banco);
                comandos.ExecuteNonQuery();
                banco.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Comandos: " + ex.Message, "AVISO");
            }

        }
        #endregion

        #region ALterarFornecedor
        public void AlterFornec(Fornecedor AlterFor, string fornecedorID)
        {

            string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";

            try
            {
                banco = new MySqlConnection(caminho);
                banco.Open();
                //cli_nome = '" +AlterCl.Nome+ "'

                vsql = "UPDATE tb_fornecedor set For_Razao = '" + AlterFor.Razao + "' , For_Cnpj = '" + AlterFor.Cnpj + "', For_Fantasia = '" + AlterFor.Fantasia + "', " +
                    "For_Estadual = '" + AlterFor.Estadual + "', For_Endereco = '" + AlterFor.Endereco + "', For_Numero = '" + AlterFor.Numero + "', For_Cep = '" + AlterFor.Cep + "', " +
                "For_Bairro = '" + AlterFor.Bairro + "', For_Cidade = '" + AlterFor.Cidade + "', For_Estado = '" + AlterFor.Estado + "', For_Telefone = '" + AlterFor.Telefone + "', " +
                    "For_Celular = '" + AlterFor.Celular + "', For_Email = '" + AlterFor.Email + "', For_Observacao = '" + AlterFor.Observacao + "' where For_Id = '" + fornecedorID + "'";

                System.Windows.Forms.MessageBox.Show(vsql);

                MySqlCommand comandos = new MySqlCommand(vsql, banco);
                comandos.ExecuteNonQuery();
                banco.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Comandos: " + ex.Message, "AVISO");
            }
        }
        #endregion

        #region AlterarVenda
        public void AlterarVenda(CVenda AlterVen, string vendaID)
        {

            string caminho = "SERVER=localhost; DATABASE = db_concessionaria; UID=root; PASSWORD=18051994";

            try
            {
                banco = new MySqlConnection(caminho);
                banco.Open();
                //cli_nome = '" +AlterCl.Nome+ "'


                vsql = "UPDATE tb_venda set Ven_Nome = '" + AlterVen.Nome + "' , Ven_Cpf = '" + AlterVen.Cpf + "', Ven_Rg = '" + AlterVen.Rg + "', " +
                   "Ven_Expedicao = '" + AlterVen.Expedicao + "', Ven_Nascimento = '" + AlterVen.Nascimento + "', Ven_Sexo = '" + AlterVen.Sexo + "', " +
                   "Ven_Civil = '" + AlterVen.Civil + "', Ven_Endereco = '" + AlterVen.Endereco + "', Ven_Numero = '" + AlterVen.Numero + "', Ven_Cep = '" +
                   AlterVen.Cep + "', Ven_Bairro = '" + AlterVen.Bairro + "', Ven_Cidade = '" + AlterVen.Cidade + "', Ven_Uf = '" + AlterVen.Estado + "', Ven_Telefone = '" +
                   AlterVen.Telefone + "', Ven_Celular = '" + AlterVen.Celular + "',  Ven_Email = '" + AlterVen.Email + "',  Ven_Comissao = '" + AlterVen.Comissao + "', " +
                       "Ven_Data = '" + AlterVen.Data + "', Ven_Hora = '" + AlterVen.Hora + "', Ven_Placa = '" + AlterVen.Placa + "', Ven_Veiculo = '" + AlterVen.Veiculo + "', Ven_Modelo = '" +
                           AlterVen.Modelo + "', Ven_Fabricacao = '" + AlterVen.Fabricacao + "' , Ven_Venda = '" + AlterVen.Valorveiculo + "', Ven_Vendedor = '" + AlterVen.Vendedor + "' , Ven_Chassi = '" + AlterVen.Chassi + "' where Ven_ID = '" + vendaID + "'";
                          
                
                MySqlCommand comandos = new MySqlCommand(vsql, banco);
                comandos.ExecuteNonQuery();
                banco.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Comandos: " + ex.Message, "AVISO");
            }
        }
        #endregion
    }
}



     