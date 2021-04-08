namespace Projeto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efetuarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.alterarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "&Cliente";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "&Alterar";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1,
            this.consultaToolStripMenuItem1});
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.fornecedorToolStripMenuItem.Text = "&Fornecedor";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem1.Text = "&Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem1.Text = "&Alterar";
            this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem2,
            this.alterarToolStripMenuItem});
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.funcionárioToolStripMenuItem.Text = "&Funcionário";
            // 
            // cadastroToolStripMenuItem2
            // 
            this.cadastroToolStripMenuItem2.Name = "cadastroToolStripMenuItem2";
            this.cadastroToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.cadastroToolStripMenuItem2.Text = "&Cadastro";
            this.cadastroToolStripMenuItem2.Click += new System.EventHandler(this.cadastroToolStripMenuItem2_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alterarToolStripMenuItem.Text = "&Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem3,
            this.alterarToolStripMenuItem1});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.produtoToolStripMenuItem.Text = "&Produto";
            // 
            // cadastroToolStripMenuItem3
            // 
            this.cadastroToolStripMenuItem3.Name = "cadastroToolStripMenuItem3";
            this.cadastroToolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem3.Text = "&Cadastro";
            this.cadastroToolStripMenuItem3.Click += new System.EventHandler(this.cadastroToolStripMenuItem3_Click);
            // 
            // alterarToolStripMenuItem1
            // 
            this.alterarToolStripMenuItem1.Name = "alterarToolStripMenuItem1";
            this.alterarToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.alterarToolStripMenuItem1.Text = "&Alterar";
            this.alterarToolStripMenuItem1.Click += new System.EventHandler(this.alterarToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efetuarToolStripMenuItem,
            this.alterarToolStripMenuItem2});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.sairToolStripMenuItem.Text = "&Venda";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // efetuarToolStripMenuItem
            // 
            this.efetuarToolStripMenuItem.Name = "efetuarToolStripMenuItem";
            this.efetuarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.efetuarToolStripMenuItem.Text = "&Efetuar";
            this.efetuarToolStripMenuItem.Click += new System.EventHandler(this.efetuarToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelData,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(841, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelData
            // 
            this.toolStripStatusLabelData.Name = "toolStripStatusLabelData";
            this.toolStripStatusLabelData.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabelData.Text = "Data";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabelHora
            // 
            this.toolStripStatusLabelHora.Name = "toolStripStatusLabelHora";
            this.toolStripStatusLabelHora.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabelHora.Text = "Hora";
            // 
            // alterarToolStripMenuItem2
            // 
            this.alterarToolStripMenuItem2.Name = "alterarToolStripMenuItem2";
            this.alterarToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.alterarToolStripMenuItem2.Text = "&Alterar";
            this.alterarToolStripMenuItem2.Click += new System.EventHandler(this.alterarToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 443);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concessionária - ZP FAAT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHora;
        private System.Windows.Forms.ToolStripMenuItem efetuarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem2;
    }
}

