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
    public partial class form_promissorias : Form
    {
        string cnsql;
        public form_promissorias( string cn)
        {
            InitializeComponent();
            cnsql = cn;
        }
        private void preenchergriduser()
        {
            string sql;
            sql = "SELECT prom_id AS Código, Venda_ven_id AS CódigoVenda, Venda_Clientes_cli_id CódigoCliente, Venda_ven_data AS DataVenda, Venda_ven_hora  AS Horário," +
            " prom_totalrestante Restante, prom_ultimopagamento AS ÚltimoPagamento, prom_total AS Total, Clientes_cli_nome AS Cliente FROM promissoria";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();

            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            grid_buscaprom.DataSource = dt;


        }

        private void bt_voltarprom_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpar1()
        {
            cb_itenvenda.Text = "";
            txt_buscaitenvend.Clear();
        }

        private void limpar2()
        {
            txt_codprom.Clear();
            txt_codvenda.Clear();
            txt_cliente.Clear();
            mk_datacompra.Clear();
            mk_hora.Clear();
            txt_totalvenda.Clear();
            txt_totalrestante.Clear();
            txt_dataalt.Clear();

        }

        private void limpar3()
        {
            comboBox2.Text = "";
            textBox1.Clear();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_limparcid_Click(object sender, EventArgs e)
        {
            buscarprom();
        }

        private void grid_buscaprom_DoubleClick(object sender, EventArgs e)
        {
            var index = grid_buscaprom.CurrentCell.RowIndex;
            /////ARRUMAR LINHAS
            txt_codprom.Text = Convert.ToString(grid_buscaprom.Rows[index].Cells[0].Value);
            txt_codvenda.Text = Convert.ToString(grid_buscaprom.Rows[index].Cells[0].Value);
            txt_cliente.Text = Convert.ToString(grid_buscaprom.Rows[index].Cells[1].Value);
            mk_datacompra.Text = Convert.ToString(grid_buscaprom.Rows[index].Cells[2].Value);
            mk_hora.Text = Convert.ToString(grid_buscaprom.Rows[index].Cells[3].Value);
            txt_totalvenda.Text = Convert.ToString(grid_buscaprom.Rows[index].Cells[4].Value);
            txt_totalrestante.Text = Convert.ToString(grid_buscaprom.Rows[index].Cells[5].Value);
            txt_dataalt.Text = Convert.ToString(grid_buscaprom.Rows[index].Cells[6].Value);

            tabControl1.SelectedTab = venda_finalizar;
        }

        private void form_promissorias_Load(object sender, EventArgs e)
        {
            preenchergriduser();

            this.grid_buscaprom.DefaultCellStyle.Font = new Font("Arial", 12);
            this.grid_buscaprom.DefaultCellStyle.ForeColor = Color.Black;
            this.grid_buscaprom.DefaultCellStyle.BackColor = Color.White;

            this.grid_buscaprom.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);

            this.dataGridView3.DefaultCellStyle.Font = new Font("Arial", 12);
            this.dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView3.DefaultCellStyle.BackColor = Color.White;

            this.dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void buscarprom()
        {
            

            string sql = "SELECT Clientes_cli_nome AS Cliente, prom_id AS Promissória, Venda_ven_id AS CódigoVenda, Venda_Clientes_cli_id AS CódigoCliente, Venda_ven_data AS Data, Venda_ven_hora AS Horário, " +
                "prom_totalrestante AS TotalRestante, prom_ultimopagamento AS ÚltimoPagamento, prom_total AS Total FROM promissoria"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão

            if (cb_itenvenda.Text == "Cliente")
            {
                sql = sql + " WHERE  Clientes_cli_nome LIKE @nome";
                comando.Parameters.AddWithValue("@nome", txt_buscaitenvend.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                   //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_itenvenda.Text == "Data")
            {
                sql = sql + " WHERE Venda_ven_data LIKE @data";
                comando.Parameters.AddWithValue("@data", txt_buscaitenvend.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            
            else if (cb_itenvenda.Text == "")
            {
                comando.CommandText = sql;
            }
            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            grid_buscaprom.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }
    }
}
