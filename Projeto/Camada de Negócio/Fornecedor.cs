using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Camada_de_Negócio
{
    public class Fornecedor
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string razao;

        public string Razao
        {
            get { return razao; }
            set { razao = value; }
        }

        private string cnpj;

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        private string fantasia;

        public string Fantasia
        {
            get { return fantasia; }
            set { fantasia = value; }
        }

        private string estadual;

        public string Estadual
        {
            get { return estadual; }
            set { estadual = value; }
        } 


        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string celular;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string observacao;

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }
    }
}
