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
    public partial class form_estoque : Form
    {
        string cnsql;
        public form_estoque(string cn)
        {
            InitializeComponent();
            cnsql = cn;
        }

        private void limpar1()
        {
            cb_buscafunc.Text = "";
            txt_buscafunc.Clear();
        }

        private void bt_voltarest_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_buscarcli_Click(object sender, EventArgs e)
        {
            buscarprodutos();
        }

        private void form_estoque_Load(object sender, EventArgs e)
        {
            preencherestoque();

            this.grid_estoque.DefaultCellStyle.Font = new Font("Arial", 12);
            this.grid_estoque.DefaultCellStyle.ForeColor = Color.Black;
            this.grid_estoque.DefaultCellStyle.BackColor = Color.White;

            this.grid_estoque.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void preencherestoque()
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
            grid_estoque.DataSource = dt;
        }

        private void bt_limparcli_Click(object sender, EventArgs e)
        {
            limpar1();
        }

        private void buscarprodutos()
        {
            string sql = "SELECT prod_id AS Código, prod_nome AS Nome, prod_tecido AS Tecido, prod_quantidade AS Quantidade," +
            " prod_prec AS Preço, prod_categoria AS Categoria, prod_estacao AS Estação, prod_tamanho AS Tamanho, prod_descricao AS Descrição, prod_cor AS Cor FROM produtos"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão

            if (cb_buscafunc.Text == "Nome")
            {
                sql = sql + " WHERE prod_nome  LIKE @nome";
                comando.Parameters.AddWithValue("@nome", txt_buscafunc.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscafunc.Text == "Estação")
            {
                sql = sql + " WHERE prod_estacao LIKE @estacao";
                comando.Parameters.AddWithValue("@estacao", txt_buscafunc.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscafunc.Text == "Tamanho")
            {
                sql = sql + " WHERE prod_tamanho LIKE @tamanho";
                comando.Parameters.AddWithValue("@tamanho", txt_buscafunc.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscafunc.Text == "Cor")
            {
                sql = sql + " WHERE prod_cor LIKE @cor";
                comando.Parameters.AddWithValue("@cor", txt_buscafunc.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscafunc.Text == "")
            {
                comando.CommandText = sql;
            }
            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            grid_estoque.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }

        private void grid_estoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
