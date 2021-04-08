using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace Projeto.Camada_de_Negócio
{
    class Cliente
    {

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        
       
        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private int expedição;

        public int Expedição
        {
            get { return expedição; }
            set { expedição = value; }
        }


        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string nascimento;

        public string Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

        private string civil;

        public string Civil
        {
            get { return civil; }
            set { civil = value; }
        }

        private string endereço;

        public string Endereço
        {
            get { return endereço; }
            set { endereço = value; }
        }

        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private int cep;

        public int Cep
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

        private string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        private int telefone;

        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private int celular;

        public int Celular
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


        public string Expedicao { get; set; }

       
    }
}
