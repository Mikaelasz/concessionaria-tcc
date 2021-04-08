using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Camada_de_Negócio
{
    public class Produto
    {
        private string modelo;


        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string fabricação;

        public string Fabricação
        {
            get { return fabricação; }
            set { fabricação = value; }
        }


        private string ano;

        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        
        private string zero;

        public string Zero
        {
            get { return zero; }
            set { zero = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string chassi;

        public string Chassi
        {
            get { return chassi; }
            set { chassi = value; }
        }

        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string combustivel;

        public string Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }

        private int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

      
        
    }
}
