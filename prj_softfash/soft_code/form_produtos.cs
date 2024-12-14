using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace soft_code
{
    public partial class form_produtos : Form
    {
        string cnsql;
        public form_produtos(string cn)
        {
            InitializeComponent();
            cnsql = cn;

        }
        private void verificacadigual()
        {
            string sql = "SELECT * FROM produtos WHERE prod_id = @prod_id";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@prod_id", MySqlDbType.Int32).Value = Convert.ToInt32(txt_codprod.Text);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("Código já existente: " + txt_codprod.Text);
                txt_codprod.Clear();
                txt_codprod.Focus();
            }
            else
            {
                cadastrar();
            }
            conexao.Close();
        }
        private void enviardadosparaoutroform()
        {
            txt_prodcod2.Text = Convert.ToString(grid_buscaprodutos.CurrentRow.Cells[0].Value); // A textbox da user_altexclu receber os dados da grid de busca
            txt_nomeprod2.Text = Convert.ToString(grid_buscaprodutos.CurrentRow.Cells[1].Value);
            txt_tecido2.Text = Convert.ToString(grid_buscaprodutos.CurrentRow.Cells[2].Value);
            txt_quantprod2.Text = Convert.ToString(grid_buscaprodutos.CurrentRow.Cells[3].Value);
            txt_precprod2.Text = Convert.ToString(grid_buscaprodutos.CurrentRow.Cells[4].Value);
            cb_catprod2.Text = Convert.ToString(grid_buscaprodutos.CurrentRow.Cells[5].Value);
            cb_estacao2.Text = Convert.ToString(grid_buscaprodutos.CurrentRow.Cells[6].Value);
            cb_tam2.Text = Convert.ToString(grid_buscaprodutos.CurrentRow.Cells[7].Value);
            txt_desprod2.Text = Convert.ToString(grid_buscaprodutos.CurrentRow.Cells[8].Value);
            txt_corprod2.Text = Convert.ToString(grid_buscaprodutos.CurrentRow.Cells[9].Value);
            tabControl1.SelectedTab = prod_altexclu; //fazer com que os dados vão para lá, a page certinha 
        }
        private void alterar()
        {
            int cod, quantidade;
            double preco;
            string tamanho, categoria, nome, descricao, estacao, cor, tecido;
            cod = Convert.ToInt32(txt_prodcod2.Text);
            nome = txt_nomeprod2.Text;
            categoria = cb_catprod2.Text;
            tamanho = cb_tam2.Text;
            quantidade = Convert.ToInt32(txt_quantprod2.Text);
            descricao = txt_desprod2.Text;
            preco = Convert.ToDouble(txt_precprod2.Text);
            estacao = cb_estacao2.Text;
            cor = txt_corprod2.Text;
            tecido = txt_tecido2.Text;

            if (tecido == String.Empty || cb_estacao2.Text == "" || categoria == String.Empty || nome == String.Empty || descricao == String.Empty || tamanho == String.Empty || txt_quantprod2.Text == "" || txt_precprod2.Text == ""  || txt_prodcod2.Text == "")
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //comandin de texto - M
            else
            {
                try
                {
                    string sql = "UPDATE produtos SET prod_nome = @nome, prod_tecido = @tecido, prod_quantidade = @quantidade, prod_prec = @preco," +
                     " prod_categoria = @categoria, prod_estacao = @estacao, prod_tamanho = @tamanho, prod_descricao = @descricao, prod_cor= @cor WHERE prod_id = @cod ";

                    MySqlConnection conexao = new MySqlConnection(cnsql);
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    //passar os parâmetros - M
                    comando.Parameters.AddWithValue("@cod", cod);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@tecido", tecido);
                    comando.Parameters.AddWithValue("@quantidade", quantidade);
                    comando.Parameters.AddWithValue("@preco", preco);
                    comando.Parameters.AddWithValue("@categoria", categoria);
                    comando.Parameters.AddWithValue("@estacao", estacao);
                    comando.Parameters.AddWithValue("@tamanho", tamanho);
                    comando.Parameters.AddWithValue("@descricao", descricao);
                    comando.Parameters.AddWithValue("@cor", cor);
                    comando.ExecuteNonQuery();  //executar 
                    MessageBox.Show(" Dados de produto alterados com sucesso!");
                    limpar3();
                    preenchergridprod();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao alterar dados!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
        }
        private void cadastrar()
        {
            int cod, fornecedor, quantidade;
            double preco;
            string tamanho, categoria, nome, descricao, estacao, cor, tecido;
            cod = Convert.ToInt32(txt_codprod.Text);
            nome = txt_nome.Text;
            categoria = cb_catprod.Text;
            tamanho = txt_tamanho.Text;
            fornecedor = Convert.ToInt32(cb_forneprod.SelectedValue);
            quantidade = Convert.ToInt32(txt_quantprod.Text);
            descricao = tb_descriçao.Text;
            preco = Convert.ToDouble(txt_precprod.Text);
            estacao = cb_estacao.Text;
            cor = txt_corprod.Text;
            tecido = txt_tecido.Text;
            
            if (tecido == String.Empty || cb_estacao.Text == "" || categoria == String.Empty || nome == String.Empty || descricao == String.Empty || tamanho == String.Empty || txt_quantprod.Text == "" || txt_precprod.Text == "" || cb_forneprod.Text == "" || txt_codprod.Text == "")
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //comandin de texto - M
            else
            {
                try
                {
                    string sql = "";
                    sql = "INSERT INTO produtos VALUES(@cod, @nome, @tecido, @quantidade, @preco, @fornecedor, @categoria, @estacao, @tamanho, @descricao, @cor)";
                                                   
                    MySqlConnection conexao = new MySqlConnection(cnsql);
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    //passar os parâmetros - M
                    comando.Parameters.AddWithValue("@cod", cod);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@tecido", tecido);
                    comando.Parameters.AddWithValue("@quantidade", quantidade);
                    comando.Parameters.AddWithValue("@preco", preco);
                    comando.Parameters.AddWithValue("@fornecedor", fornecedor);
                    comando.Parameters.AddWithValue("@categoria", categoria);
                    comando.Parameters.AddWithValue("@estacao", estacao);
                    comando.Parameters.AddWithValue("@tamanho", tamanho);
                    comando.Parameters.AddWithValue("@descricao", descricao);
                    comando.Parameters.AddWithValue("@cor", cor);
                    comando.ExecuteNonQuery();  //executar 
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    limpar1();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
        }
        private void preenchergridprod()
        {
            string sql;
            sql = "SELECT prod_id AS Código, prod_nome AS Nome, prod_tecido AS Tecido, prod_quantidade AS Quantidade," +
            " prod_prec AS Preço, prod_categoria AS Categoria, prod_estacao AS Estação, prod_tamanho AS Tamanho, prod_descricao AS Descrição, prod_cor AS Cor FROM produtos";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();

            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            grid_buscaprodutos.DataSource = dt;

        }
        private void preenchercombo()
        {
            
                MySqlConnection conexao = new MySqlConnection(cnsql);
                MySqlCommand query = new MySqlCommand();
                query.Connection = conexao;
                conexao.Open();

                query.CommandText = "SELECT forn_id, forn_nome FROM fornecedores ORDER BY forn_nome";

                MySqlDataReader tabela;
                tabela = query.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(tabela);
                cb_forneprod.DisplayMember = "forn_nome";
                cb_forneprod.ValueMember = "forn_id";

                cb_forneprod.DataSource = dt;
            
        }

        private void limpar1()
        {
            txt_codprod.Clear();
            txt_nome.Clear();
            tb_descriçao.Clear();
            txt_precprod.Clear();
            cb_forneprod.Text = "";
            txt_quantprod.Clear();
            txt_tecido.Clear();
            txt_corprod.Clear();
            txt_tamanho.Clear();
            cb_estacao.Text = "";
            cb_catprod.Text = "";
        }

        private void limpar2()
        {
            cb_buscaprod.Text = "";
            txt_buscaprod.Clear();

        }

        private void limpar3()
        {
            txt_prodcod2.Clear();
            txt_nomeprod2.Clear();
            txt_desprod2.Clear();
            txt_precprod2.Clear();
            txt_quantprod2.Clear();
            txt_tecido2.Clear();
            txt_corprod2.Clear();
            cb_tam2.Clear();
            cb_estacao2.Text = "";
            cb_catprod2.Text = "";


        }

        
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void bt_voltarcprod_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            limpar1();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            verificacadigual();
        }

        private void bt_buscarcli_Click(object sender, EventArgs e)
        {
            buscarprodutos();
        }

        private void buscarprodutos()
        {
            string sql = "SELECT prod_id AS Código, prod_nome AS Nome, prod_tecido AS Tecido, prod_quantidade AS Quantidade," +
            " prod_prec AS Preço, prod_categoria AS Categoria, prod_estacao AS Estação, prod_tamanho AS Tamanho, prod_descricao AS Descrição, prod_cor AS Cor FROM produtos"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão

            if (cb_buscaprod.Text == "Nome")
            {
                sql = sql + " WHERE prod_nome  LIKE @nome";
                comando.Parameters.AddWithValue("@nome", txt_buscaprod.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscaprod.Text == "Estação")
            {
                sql = sql + " WHERE prod_estacao LIKE @estacao";
                comando.Parameters.AddWithValue("@estacao", txt_buscaprod.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscaprod.Text == "Tamanho")
            {
                sql = sql + " WHERE prod_tamanho LIKE @tamanho";
                comando.Parameters.AddWithValue("@tamanho", txt_buscaprod.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscaprod.Text == "Cor")
            {
                sql = sql + " WHERE prod_cor LIKE @cor";
                comando.Parameters.AddWithValue("@cor", txt_buscaprod.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscaprod.Text == "")
            {
                comando.CommandText = sql;
            }
            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            grid_buscaprodutos.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }

        private void form_produtos_Load(object sender, EventArgs e)
        {
            preenchergridprod();
            preenchercombo();

            this.grid_buscaprodutos.DefaultCellStyle.Font = new Font("Arial", 12);
            this.grid_buscaprodutos.DefaultCellStyle.ForeColor = Color.Black;
            this.grid_buscaprodutos.DefaultCellStyle.BackColor = Color.White;

            this.grid_buscaprodutos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void grid_buscaprodutos_DoubleClick(object sender, EventArgs e)
        {
            enviardadosparaoutroform();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bt_alterarcid_Click(object sender, EventArgs e)
        {
            alterar();
            preenchergridprod();
        }

        private void excluircadastro()
        {
            int cod;
            cod = Convert.ToInt32(txt_prodcod2.Text);
            DialogResult confirmar = MessageBox.Show("Deseja realmente excluir o cadastro?", "Deletar cadastro!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmar == DialogResult.Yes)
            {
                string sql;
                sql = "DELETE FROM clientes WHERE cli_id = @cod";
                MySqlConnection conexao = new MySqlConnection(cnsql);
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();

                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@cod", cod);
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro excluído com sucesso!", "Cadastro deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                preenchergridprod();
                conexao.Close();
                limpar3();
            }

        }

        private void bt_excluircli_Click(object sender, EventArgs e)
        {
            excluircadastro();
        }

        private void grid_buscaprodutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_limparcli_Click(object sender, EventArgs e)
        {
            limpar2();
        }
    }
}
