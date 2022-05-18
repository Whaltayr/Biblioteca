namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_nomeusuario = new System.Windows.Forms.Label();
            this.Usuário = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_logado = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requisitarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInformaçõesDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeUsuáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lb_nomeusuario);
            this.panel1.Controls.Add(this.Usuário);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_logado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 38);
            this.panel1.TabIndex = 0;
            // 
            // lb_nomeusuario
            // 
            this.lb_nomeusuario.AutoSize = true;
            this.lb_nomeusuario.Location = new System.Drawing.Point(163, 14);
            this.lb_nomeusuario.Name = "lb_nomeusuario";
            this.lb_nomeusuario.Size = new System.Drawing.Size(22, 15);
            this.lb_nomeusuario.TabIndex = 4;
            this.lb_nomeusuario.Text = "---";
            // 
            // Usuário
            // 
            this.Usuário.AutoSize = true;
            this.Usuário.Location = new System.Drawing.Point(116, 14);
            this.Usuário.Name = "Usuário";
            this.Usuário.Size = new System.Drawing.Size(53, 15);
            this.Usuário.TabIndex = 3;
            this.Usuário.Text = "Usuário :";
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(97, 14);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(13, 15);
            this.lb_acesso.TabIndex = 2;
            this.lb_acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso :";
            // 
            // pb_logado
            // 
            this.pb_logado.Image = global::Biblioteca.Properties.Resources._1;
            this.pb_logado.Location = new System.Drawing.Point(3, 4);
            this.pb_logado.Name = "pb_logado";
            this.pb_logado.Size = new System.Drawing.Size(33, 31);
            this.pb_logado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logado.TabIndex = 0;
            this.pb_logado.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.requisitarLivroToolStripMenuItem,
            this.devolverLivroToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 72);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem,
            this.logInToolStripMenuItem1,
            this.logOffToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 68);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de dados";
            // 
            // logInToolStripMenuItem1
            // 
            this.logInToolStripMenuItem1.Name = "logInToolStripMenuItem1";
            this.logInToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.logInToolStripMenuItem1.Text = "Log in";
            this.logInToolStripMenuItem1.Click += new System.EventHandler(this.logInToolStripMenuItem1_Click_1);
            // 
            // logOffToolStripMenuItem1
            // 
            this.logOffToolStripMenuItem1.Name = "logOffToolStripMenuItem1";
            this.logOffToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.logOffToolStripMenuItem1.Text = "Log off";
            this.logOffToolStripMenuItem1.Click += new System.EventHandler(this.logOffToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLivroToolStripMenuItem,
            this.verLivrosToolStripMenuItem});
            this.livrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosToolStripMenuItem.Image")));
            this.livrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(100, 68);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // addLivroToolStripMenuItem
            // 
            this.addLivroToolStripMenuItem.Name = "addLivroToolStripMenuItem";
            this.addLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addLivroToolStripMenuItem.Text = "Add livro";
            this.addLivroToolStripMenuItem.Click += new System.EventHandler(this.addLivroToolStripMenuItem_Click);
            // 
            // verLivrosToolStripMenuItem
            // 
            this.verLivrosToolStripMenuItem.Name = "verLivrosToolStripMenuItem";
            this.verLivrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verLivrosToolStripMenuItem.Text = "Ver livros";
            this.verLivrosToolStripMenuItem.Click += new System.EventHandler(this.verLivrosToolStripMenuItem_Click);
            // 
            // requisitarLivroToolStripMenuItem
            // 
            this.requisitarLivroToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.requisitarLivroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("requisitarLivroToolStripMenuItem.Image")));
            this.requisitarLivroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.requisitarLivroToolStripMenuItem.Name = "requisitarLivroToolStripMenuItem";
            this.requisitarLivroToolStripMenuItem.Size = new System.Drawing.Size(147, 68);
            this.requisitarLivroToolStripMenuItem.Text = "Requisitar livro";
            // 
            // devolverLivroToolStripMenuItem
            // 
            this.devolverLivroToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.devolverLivroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("devolverLivroToolStripMenuItem.Image")));
            this.devolverLivroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.devolverLivroToolStripMenuItem.Name = "devolverLivroToolStripMenuItem";
            this.devolverLivroToolStripMenuItem.Size = new System.Drawing.Size(155, 68);
            this.devolverLivroToolStripMenuItem.Text = "Devolver livro";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem,
            this.verInformaçõesDeAlunosToolStripMenuItem});
            this.alunosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alunosToolStripMenuItem.Image")));
            this.alunosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(106, 68);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoAlunoToolStripMenuItem.Image")));
            this.novoAlunoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(228, 56);
            this.novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            this.novoAlunoToolStripMenuItem.Click += new System.EventHandler(this.novoAlunoToolStripMenuItem_Click);
            // 
            // verInformaçõesDeAlunosToolStripMenuItem
            // 
            this.verInformaçõesDeAlunosToolStripMenuItem.Name = "verInformaçõesDeAlunosToolStripMenuItem";
            this.verInformaçõesDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(228, 56);
            this.verInformaçõesDeAlunosToolStripMenuItem.Text = "Informações de alunos";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeUsuáriosToolStripMenuItem,
            this.gestãoDeUsuáriosToolStripMenuItem1});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 68);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // gestãoDeUsuáriosToolStripMenuItem
            // 
            this.gestãoDeUsuáriosToolStripMenuItem.Name = "gestãoDeUsuáriosToolStripMenuItem";
            this.gestãoDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gestãoDeUsuáriosToolStripMenuItem.Text = "Novo usuário";
            this.gestãoDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeUsuáriosToolStripMenuItem_Click);
            // 
            // gestãoDeUsuáriosToolStripMenuItem1
            // 
            this.gestãoDeUsuáriosToolStripMenuItem1.Name = "gestãoDeUsuáriosToolStripMenuItem1";
            this.gestãoDeUsuáriosToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.gestãoDeUsuáriosToolStripMenuItem1.Text = "Gestão de usuários";
            this.gestãoDeUsuáriosToolStripMenuItem1.Click += new System.EventHandler(this.gestãoDeUsuáriosToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public PictureBox pb_logado;
        private Label label1;
        public Label lb_nomeusuario;
        public Label Usuário;
        public Label lb_acesso;
        public Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem novoAlunoToolStripMenuItem;
        private ToolStripMenuItem livrosToolStripMenuItem;
        private ToolStripMenuItem addLivroToolStripMenuItem;
        private ToolStripMenuItem verLivrosToolStripMenuItem;
        private ToolStripMenuItem requisitarLivroToolStripMenuItem;
        private ToolStripMenuItem devolverLivroToolStripMenuItem;
        private ToolStripMenuItem verInformaçõesDeAlunosToolStripMenuItem;
        private ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem logInToolStripMenuItem1;
        private ToolStripMenuItem logOffToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}