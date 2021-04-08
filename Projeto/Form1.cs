using Projeto.Formulário_Cadastro;
using Projeto.Formulário_Consulta;
using Projeto.Formulário_de_Venda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.MdiParent = this;
            c.Show();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fornecedor f = new Fornecedor();
            f.MdiParent = this;
            f.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteAlterar con = new ClienteAlterar();
            con.MdiParent = this;
            con.Show();

        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FornecedorAlterar consulta = new FornecedorAlterar();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormFuncionario cadastro = new FormFuncionario();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioAlterar funcalterar = new FuncionarioAlterar();
            funcalterar.MdiParent = this;
            funcalterar.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();

            dt = DateTime.Now;

            toolStripStatusLabelData.Text = dt.ToLongDateString();

            toolStripStatusLabelHora.Text = dt.ToLongTimeString();
        }

        private void cadastroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormProduto cadProduto = new FormProduto();
            cadProduto.MdiParent = this;
            cadProduto.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Deseja Realmente Sair", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            ////else
            //{
            //    new Projeto.Camada_de_Negócio.Teste("where testeid = 2");
            //}
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProdutoALterar prod = new ProdutoALterar();
            prod.MdiParent = this;
            prod.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void efetuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenda Venda = new FormVenda();
            Venda.MdiParent = this;
            Venda.Show();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VendaAlterar venAlter = new VendaAlterar();
            venAlter.MdiParent = this;
            venAlter.Show();
        }
    }
}
