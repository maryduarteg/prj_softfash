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
    public partial class f_devolverprod : Form
    {
        string cnsql;
        public f_devolverprod(string cn)
        {
            InitializeComponent();
            cnsql = cn;
        }

        int clid;
        double total;


        private void buscaritens()
        {
            clid = Convert.ToInt32(cb_cliente.SelectedValue);

            string sql = "SELECT Venda_ven_id AS CódigoVenda, itens_id AS CódigoItem, Produtos_prod_nome AS Produto, itens_quanti AS Quantidade, itens_prec AS Preço, itens_subtotal AS Subtotal, Produtos_prod_id AS CodigoProduto FROM itens" +
                " INNER JOIN venda ON itens.Venda_ven_id = venda.ven_id WHERE venda.Clientes_cli_id = @clid";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@clid", clid);


            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            dt_devprod.DataSource = dt;
        }
        private void f_devolverprod_Load(object sender, EventArgs e)
        {
            buscarclientes();

            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.White;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);

            this.dt_devprod.DefaultCellStyle.Font = new Font("Arial", 12);
            this.dt_devprod.DefaultCellStyle.ForeColor = Color.Black;
            this.dt_devprod.DefaultCellStyle.BackColor = Color.White;

            this.dt_devprod.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);
        }

        private void buscarclientes()
        {
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand query = new MySqlCommand();
            query.Connection = conexao;
            conexao.Open();

            query.CommandText = "SELECT cli_id, cli_nome FROM clientes";

            MySqlDataReader tabela;
            tabela = query.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(tabela);
            cb_cliente.DisplayMember = "cli_nome";
            cb_cliente.ValueMember = "cli_id";

            cb_cliente.DataSource = dt;
        }



        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buscarcliente()
        {
            string sql = "SELECT * FROM clientes WHERE cli_nome LIKE @nome"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão
            comando.Parameters.AddWithValue("@nome", textBox1.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                           //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
            comando.CommandText = sql;

            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            cb_cliente.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }

        private void buscarvendasdporcliente()
        {
            clid = Convert.ToInt32(cb_cliente.SelectedValue);

            string sql = "SELECT ven_id AS Código, ven_hora AS Hora, ven_dia AS Data, Clientes_cli_nome AS Cliente FROM venda " +
             "INNER JOIN clientes ON venda.Clientes_cli_id = clientes.cli_id WHERE clientes.cli_id = @clid";

            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão
            comando.Parameters.AddWithValue("@clid", clid);
            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            dataGridView1.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buscarcliente();
            buscarvendasdporcliente();
            buscaritens();
        }

        private void bt_voltarcprod_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscarpelocoddevenda()
        {
            int codvendaitem = Convert.ToInt32(txt_codvenda.Text);

            string sql = "SELECT Venda_ven_id AS CódigoVenda, itens_id AS CódigoItem, Produtos_prod_nome AS Produto, " +
                "itens_quanti AS Quantidade, itens_prec AS Preço, itens_subtotal AS Subtotal, Produtos_prod_id AS CodigoProduto FROM itens WHERE Venda_ven_id = @codvendaitem";

            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão
            comando.Parameters.AddWithValue("@codvendaitem", codvendaitem);
            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            dt_devprod.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }

        private void rb_dia_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscarpelocoddevenda();
        }

        private void dt_devprod_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var index = dt_devprod.CurrentCell.RowIndex;

                txt_itencod.Text = Convert.ToString(dt_devprod.Rows[index].Cells[0].Value);
                txt_codvenda.Text = Convert.ToString(dt_devprod.Rows[index].Cells[0].Value);
                txt_prodnome.Text = Convert.ToString(dt_devprod.Rows[index].Cells[1].Value);
                txt_vendaid.Text = Convert.ToString(dt_devprod.Rows[index].Cells[2].Value);
                txt_quant.Text = Convert.ToString(dt_devprod.Rows[index].Cells[3].Value);
                txt_preco.Text = Convert.ToString(dt_devprod.Rows[index].Cells[4].Value);
                txt_subtotal.Text = Convert.ToString(dt_devprod.Rows[index].Cells[5].Value);
                txt_codprod.Text = Convert.ToString(dt_devprod.Rows[index].Cells[6].Value);

                tabControl1.SelectedTab = prod_devolver;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            
        }

        private void alterarquantestoque()
        {
            int codprod = Convert.ToInt32(txt_codprod.Text);
            double quantidade;
            double quantidade1 = Convert.ToDouble(txt_quant.Text);
            
            string sql = "SELECT prod_quantidade FROM produtos WHERE prod_id = @codprod";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@codprod", codprod);
            quantidade = Convert.ToDouble(comando.ExecuteScalar());
            conexao.Close();

            double quantidade2;
            quantidade2 = quantidade + quantidade1;


            string sql5 = "UPDATE produtos SET prod_quantidade = @quantidade2 WHERE prod_id = @codprod ";
            MySqlConnection conexao5 = new MySqlConnection(cnsql);
            MySqlCommand comando5 = new MySqlCommand(sql5, conexao5);
            conexao5.Open();
            comando5.Parameters.AddWithValue("quantidade2", quantidade2);
            comando5.Parameters.AddWithValue("codprod", codprod);
           
            comando5.ExecuteNonQuery();
            conexao5.Close();

            int coditem = Convert.ToInt32(txt_itencod.Text);
            string sql6 = "DELETE FROM itens WHERE itens_id = @coditem ";

            MySqlConnection conexao6 = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando6 = new MySqlCommand(sql6, conexao6); // criar comando e ligar com o sql e conexão
            conexao6.Open(); //abrir conexão
            comando6.Parameters.AddWithValue("coditem", coditem);
            comando6.ExecuteNonQuery();
            conexao6.Close();

            int codigovenda = Convert.ToInt32(txt_codvenda.Text);

            string sql7 = "SELECT SUM(itens_subtotal) FROM itens WHERE Venda_ven_id = @codigovenda";
            MySqlConnection conexao7 = new MySqlConnection(cnsql);
            MySqlCommand comando7 = new MySqlCommand(sql7, conexao7);
            conexao7.Open();
            comando7.Parameters.AddWithValue("codigovenda", codigovenda);
            total = Convert.ToDouble(comando7.ExecuteScalar());
            conexao7.Close();

            string sql8 = "UPDATE venda SET ven_total = @total WHERE ven_id = @codigovenda";
            MySqlConnection conexao8 = new MySqlConnection(cnsql);
            MySqlCommand comando8 = new MySqlCommand(sql8, conexao8);
            conexao8.Open();
            comando8.Parameters.AddWithValue("total", total);
            comando8.Parameters.AddWithValue("codigovenda", codigovenda);
            comando8.ExecuteNonQuery();
            conexao8.Close();
            limpar2();
            buscaritens();

            MessageBox.Show("Item devolvido com sucesso!", "Devolução realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void bt_excluircli_Click(object sender, EventArgs e)
        {
            alterarquantestoque();

        }

        private void limpar2()
        {
            txt_codvenda.Clear();
            txt_itencod.Clear();
            txt_preco.Clear();
            txt_prodnome.Clear();
            txt_quant.Clear();
            txt_subtotal.Clear();
            txt_vendaid.Clear();
            txt_codvenda.Clear();
        }
    }
}
