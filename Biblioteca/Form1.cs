namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeusuario.Text = "---";
            pb_logado.Image = Properties.Resources._1;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    F_Gestão_de_usuário f_Gestão_De_Usuário=new F_Gestão_de_usuário();
                    f_Gestão_De_Usuário.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("È necessario ter um usuário logado");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {

            }//procedimentos, o aluno tem o menor nivel de segurança, não precisa ser verificado
 
            else
            {
                MessageBox.Show("È necessario ter um usuário logado");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    F_Novousuario f_Novousuario = new F_Novousuario();
                    f_Novousuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("È necessario ter um usuário logado");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void logInToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logOffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeusuario.Text = "---";
            pb_logado.Image = Properties.Resources._1;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void addLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addbook addbook = new Addbook();
            addbook.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sair do programa??","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                Application.Exit();
            }

            
        }

        private void verLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook viewBook = new ViewBook();
            viewBook.ShowDialog();
        }
    }
}