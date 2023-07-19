namespace Aula08Estoque
{
    public partial class Form1 : Form
    {
        // Variávis globais
        List<string> produto_nome = new List<string>();
        List<int> produto_quantidade = new List<int>();


        public Form1()
        {
            InitializeComponent();
        }

        // Minhas funções

        void adicionaProduto()
        {
            string nome = txtNome.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            produto_nome.Add(nome);
            produto_quantidade.Add(quantidade);
        }

        void atualizaInterface()
        {
            int quantidade_cadastrada = produto_nome.Count();
            lblCadastrados.Text = quantidade_cadastrada.ToString();
        }

        void limpaCampos()
        {
            txtNome.Clear();
            txtQuantidade.Clear();
            txtNome.Focus();
        }

        void verProduto(bool primeiro)
        {
            if (listaEstaVazia() == true)
            {
                MessageBox.Show("Você não pode ver a lista ainda...");
                return;
            }


            string nome;
            int quantidade;

            if (primeiro == true)
            {
                nome = produto_nome[0];
                quantidade= produto_quantidade[0];
            }

            else
            {
                nome = produto_nome[produto_nome.Count() - 1];
                quantidade = produto_quantidade[produto_quantidade.Count() - 1];
            }

            MessageBox.Show($"Nome: {nome}, Quantidade: {quantidade}");
        }

        void remove()
        {
            if (listaEstaVazia() == true)
            {
                MessageBox.Show("Você não pode remover");
            }
            else
            {
                produto_nome.RemoveAt(0);
                produto_quantidade.RemoveAt(0);
            }
              
        }

        bool listaEstaVazia()
        {
            if(produto_nome.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            adicionaProduto();
            atualizaInterface();
            limpaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnVerPrimeiro_Click(object sender, EventArgs e)
        {
            verProduto(true);
        }

        private void btnVerUltimo_Click(object sender, EventArgs e)
        {
            verProduto(false);
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            remove();
            atualizaInterface();

        }
    }
}