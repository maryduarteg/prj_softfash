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
    public partial class form_vendas : Form
    {
        string cnsql = "";
        //variaiveis da tabela itens:
        double subtotal, precunic;
        int codvenda, quantidade, coditem, produto, quantidade2;
        double restante = 0, ultimopag= 0;
        string nomeprod;

        //variaiveis da tabela venda:
        int cliente;
        double total;
        string hora, dia, clinome;
        public form_vendas(string cn)
        {
            cnsql = cn;
            InitializeComponent();
        }
        private void pegarultimocod()
        {
            string sql = "SELECT MAX(ven_id) FROM venda";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
       
            codvenda = Convert.ToInt32(comando.ExecuteScalar());
            conexao.Close();
        }

        private void preenchergridvenda()
        { 

            string sql = "SELECT ven_id AS Código, Clientes_cli_id AS CódigoCliente, Clientes_cli_nome AS Cliente, ven_dia AS Data, ven_hora AS Horário, ven_total AS Total FROM venda";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();

            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            dataGridView3.DataSource = dt;
        }

        private void preenchergriditensvenda()
        {

            string sql = "SELECT Produtos_prod_nome AS Produto, itens_id AS CódigoItem, Produtos_prod_id AS CódigoProduto,  Venda_ven_id AS CódigoVenda, itens_quanti AS Quantidade, itens_prec AS Preço, itens_subtotal AS Subtotal FROM itens"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();

            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            dataGridView1.DataSource = dt;
        }
        private void preenchergriditens2()
        {

            string sql = "SELECT itens_id AS Codigo, Produtos_prod_id AS Produto, Venda_ven_id AS CodigoVenda, " +
                "itens_quanti AS Quantidade, itens_prec AS Preço, itens_subtotal AS Subtotal FROM itens ";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();

            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            dataGridView1.DataSource = dt;
        }
        private void preenchercomboclientes()
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
            cb_clientevenda.DisplayMember = "cli_nome";
            cb_clientevenda.ValueMember = "cli_id";

            cb_clientevenda.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void form_vendas_Load(object sender, EventArgs e)
        {
            preenchergriditensvenda();
            preenchercomboclientes();
            invisivel1();
            grid_itens.Rows.Clear();
            invisivelfinalizar();
            preenchergridvenda();

            this.grid_itens.DefaultCellStyle.Font = new Font("Arial", 12);
            this.grid_itens.DefaultCellStyle.ForeColor = Color.Black;
            this.grid_itens.DefaultCellStyle.BackColor = Color.White;

            this.grid_itens.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);


            this.dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.White;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);

            this.dataGridView3.DefaultCellStyle.Font = new Font("Arial", 12);
            this.dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView3.DefaultCellStyle.BackColor = Color.White;

            this.dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void venda_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            visivelfinalizar();
            alterartotal();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            verificarquantidade();
            calculartotal();
        }

        private void bt_voltarcadcli_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpar1()
        {
            cb_clientevenda.Text = "";
            mk_hora.Clear();
            mk_data.Clear();
            txt_codprod.Clear();
            txt_tecprod.Clear();
            textBox2.Clear();
            txt_buscaprod.Clear();
            txt_total.Clear();
        }

        private void resetarcampos()
        {
            cb_clientevenda.Text = "";
            mk_hora.Clear();
            mk_data.Clear();
            txt_codprod.Text = "";
            txt_tecprod.Clear();
            textBox2.Clear();
            txt_buscaprod.Clear();
            txt_total.Clear();
        }

        private void invisivel1()
        {
            txt_codprod.Visible = false;
            txt_tecprod.Visible = false;
            txt_buscaprod.Visible = false;
            cb_produtos.Visible = false;
            bt_add.Visible = false;
            bt_cadastrar.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label10.Visible = false;
            txt_total.Visible = false;
            lb_quant.Visible = false;
            txt_quantdisp.Visible = false;
            label4.Visible = false;
        }

        private void visivel1()
        {
            txt_codprod.Visible = true;
            txt_tecprod.Visible = true;
            txt_buscaprod.Visible = true;
            cb_produtos.Visible = true;
            bt_add.Visible = true;
            bt_cadastrar.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label10.Visible = true;
            txt_total.Visible = true;
            lb_quant.Visible = true;
            txt_quantdisp.Visible = true;
            label4.Visible = true;
        }

        private void blockconcluir()
        {
            textBox2.Enabled = false;
            cb_clientevenda.Enabled = false;
            mk_hora.Enabled = false;
            mk_data.Enabled = false;
            bt_concluir.Visible = false;
            bt_add.Visible = true;
            bt_cadastrar.Visible = true;
        }
        private void limpar2()
        {
            cb_itenvenda.Text = "";
            txt_buscaitenvend.Clear();
        }

        private void limpar3()
        {
            comboBox2.Text = "";
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_concluir_Click(object sender, EventArgs e)
        {
            cadastrarvenda();
            blockconcluir();
            visivel1();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            limpar1();
        }
        private void buscaritensdasvendas()
        {
            string sql = "SELECT Produtos_prod_nome AS Produto, itens_id AS CódigoItem, Produtos_prod_id AS CódigoProduto,  Venda_ven_id AS CódigoVenda, itens_quanti AS Quantidade, itens_prec AS Preço, itens_subtotal AS Subtotal FROM itens"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão

            if (cb_itenvenda.Text == "Produto")
            {
                sql = sql + " WHERE Produtos_prod_nome LIKE @nome";
                comando.Parameters.AddWithValue("@nome", txt_buscaitenvend.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                        //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_itenvenda.Text == "Código")
            {
                sql = sql + " WHERE itens_id = @cod";
                comando.Parameters.AddWithValue("@cod", txt_buscaitenvend.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
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
            dataGridView1.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            buscacliente();
        }

        private void txt_precprod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscaprod_TextChanged(object sender, EventArgs e)
        {
            buscaroupa();
            
        }

        private void cadastrarvenda()
        { 
            //variaiveis da tabela itens:
            cliente = Convert.ToInt32(cb_clientevenda.SelectedValue);
            hora = mk_hora.Text;
            dia = mk_data.Text;

            if (cb_clientevenda.Text == String.Empty || hora == String.Empty || mk_data.Text == "")
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string sq1l = "SELECT cli_nome FROM clientes WHERE cli_id = @cliente";

                    MySqlConnection conexao1 = new MySqlConnection(cnsql); //criar conexão
                    MySqlCommand comando1 = new MySqlCommand(sq1l, conexao1); // criar comando e ligar com o sql e conexão
                    conexao1.Open(); //abrir conexão
                    comando1.Parameters.AddWithValue("@cliente", cliente);
                    clinome = Convert.ToString(comando1.ExecuteScalar());
                    conexao1.Close();


                    string sql = "INSERT INTO venda( Clientes_cli_id, Clientes_cli_nome, ven_dia, ven_hora, ven_total) VALUES(@cliente, @clinome, @dia, @hora,  @total)";

                    MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
                    MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
                    conexao.Open(); //abrir conexão
                    comando.Parameters.AddWithValue("@cliente", cliente);
                    comando.Parameters.AddWithValue("@clinome", clinome);
                    comando.Parameters.AddWithValue("@dia", dia);
                    comando.Parameters.AddWithValue("@hora", hora);
                    comando.Parameters.AddWithValue("@total", total);
                    

                    comando.ExecuteNonQuery();
                    conexao.Close();
                    /////////////////////////////////grid_itens.Rows.Clear();
                    
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar venda!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
        }

        private void buscacliente()
        {
            string sql = "SELECT * FROM clientes WHERE cli_nome LIKE @nome"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão
            comando.Parameters.AddWithValue("@nome", textBox2.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                           //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
            comando.CommandText = sql;

            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            cb_clientevenda.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();

        }

        private void buscaroupa()
        {
            string sql = "SELECT prod_id, prod_nome, prod_prec FROM produtos WHERE prod_nome LIKE @nome"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão
            comando.Parameters.AddWithValue("@nome", txt_buscaprod.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras                                                                   //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
            comando.CommandText = sql;

            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            cb_produtos.DisplayMember = "prod_nome";
            cb_produtos.ValueMember = "prod_id";
            cb_produtos.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }

        private void saberovalor()
        {
            string sql1 = "SELECT prod_prec FROM produtos WHERE prod_nome LIKE @nome"; //criar sqls
            MySqlConnection conexao1 = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando1 = new MySqlCommand(sql1, conexao1); // criar comando e ligar com o sql e conexão
            conexao1.Open(); //abrir conexão
            comando1.Parameters.AddWithValue("@nome", txt_buscaprod.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras                                                                   //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
            comando1.CommandText = sql1;

            precunic = Convert.ToDouble(comando1.ExecuteScalar());
            // txt_tecprod.Text = Convert.ToString(precunic);
            conexao1.Close();
        }

        private void verificarquantidade()////
        {

            

            if (txt_tecprod.Text == "")
            {
                MessageBox.Show("Indique a quantidade!", "Quantidade vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tecprod.Clear();
                txt_tecprod.Focus();
            }
            else 
            {
                coditem = Convert.ToInt32(txt_codprod.Text);

                string sql2 = "SELECT prod_quantidade FROM produtos WHERE prod_id = @coditem"; //criar sqls
                MySqlConnection conexao2 = new MySqlConnection(cnsql); //criar conexão
                MySqlCommand comando2 = new MySqlCommand(sql2, conexao2); // criar comando e ligar com o sql e conexão
                conexao2.Open(); //abrir conexão
                comando2.Parameters.AddWithValue("@coditem", coditem); 
                comando2.CommandText = sql2;
           
                quantidade2 = Convert.ToInt32(comando2.ExecuteScalar());
                conexao2.Close();
                quantidade = Convert.ToInt32(txt_tecprod.Text);

                if (quantidade2 < quantidade)
                {
                    MessageBox.Show("A quantidade de produtos é maior que a quantidade disponível no estoque!!", "Quantidade indisponível", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_tecprod.Clear();
                    txt_tecprod.Focus();
                }
                else if (quantidade <= quantidade2)
                {
                    cadastraritemnavenda();
                    retirarprodutos();
                }
               
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bt_prom.Visible = false;
            bt_finvenda.Visible = false;
            bt_voltar.Visible = false;
            panel_finalizar.Visible = false;
        }

        private void invisivelfinalizar()
        {
            bt_prom.Visible = false;
            bt_finvenda.Visible = false;
            bt_voltar.Visible = false;
            panel_finalizar.Visible = false;
        }
        private void visivelfinalizar()
        {
            bt_prom.Visible = true;
            bt_finvenda.Visible = true;
            bt_voltar.Visible = true;
            panel_finalizar.Visible = true;
        }

        private void cb_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pegarcodproduto();
            pegarquantdoprod();
        }

        private void cb_produtos_TextChanged(object sender, EventArgs e)
        {
            pegarcodproduto();
            pegarquantdoprod();
        }

        private void cb_produtos_Click(object sender, EventArgs e)
        {
            pegarcodproduto();
            pegarquantdoprod();
        }

        private void cb_produtos_MouseClick(object sender, MouseEventArgs e)
        {
            pegarcodproduto();
            pegarquantdoprod();
        }

        private void cb_produtos_Leave(object sender, EventArgs e)
        {
            pegarcodproduto();
            pegarquantdoprod();
        }

        private void cb_produtos_SelectedValueChanged(object sender, EventArgs e)
        {
            pegarcodproduto();
            pegarquantdoprod();
        }

        private void grid_itens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void retirarprodutos()
        {
            coditem = Convert.ToInt32(txt_codprod.Text);

            int quanti2;
            string sql3 = "SELECT prod_quantidade FROM produtos WHERE prod_id  = @coditem";
            MySqlConnection conexao3 = new MySqlConnection(cnsql);
            MySqlCommand comando3 = new MySqlCommand(sql3, conexao3);
            comando3.Parameters.AddWithValue("coditem", coditem);
            conexao3.Open();
            
            quanti2 = Convert.ToInt32(comando3.ExecuteScalar());//ATTENTION!
            conexao3.Close();

            int quantidade3 = Convert.ToInt32(txt_tecprod.Text);

            int quanti4 = quanti2 - quantidade3;

            string sql5 = "UPDATE produtos SET prod_quantidade = @quanti4 WHERE prod_id = @coditem ";
            MySqlConnection conexao5 = new MySqlConnection(cnsql);
            MySqlCommand comando5 = new MySqlCommand(sql5, conexao5);
            comando5.Parameters.AddWithValue("quanti4", quanti4);
            comando5.Parameters.AddWithValue("coditem", coditem);
            conexao5.Open();
            comando5.ExecuteNonQuery();
            conexao5.Close();
        }
        private void finalizarvenda()
        {
            try
            {
                string sql = "SELECT * FROM venda";
                MySqlConnection conexao = new MySqlConnection(cnsql);
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                MySqlDataReader tabela;
                tabela = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(tabela);
                dataGridView3.DataSource = dt;
                MessageBox.Show("Venda cadastrada com sucesso!", "Venda realizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetarcampos();
                preenchergridvenda();
                invisivelfinalizar();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro", "Venda não realizada!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void bt_finvenda_Click(object sender, EventArgs e)
        {
            finalizarvenda();
        }
        private void gerarpromissoria()
        {
            try
            {
                int coddvenda;
                string sql2 = "SELECT MAX(ven_id) FROM venda";
                MySqlConnection conexao2 = new MySqlConnection(cnsql);
                MySqlCommand comando2 = new MySqlCommand(sql2, conexao2);
                conexao2.Open();
                coddvenda = Convert.ToInt32(comando2.ExecuteScalar());
                conexao2.Close();

                //////////////////////////////////////////////////////////
               
                string sql1 = "SELECT ven_id FROM Venda WHERE ven_id = @coddvenda ";
                MySqlConnection conexao1 = new MySqlConnection(cnsql);
                MySqlCommand comando1 = new MySqlCommand(sql1, conexao1);
                conexao1.Open();
                //passar os parâmetros - M
                comando1.Parameters.AddWithValue("@coddvenda", coddvenda);
                comando1.ExecuteNonQuery();
                codvenda = Convert.ToInt32(comando1.ExecuteScalar());
                conexao1.Close();

                string sql3 = "SELECT Clientes_cli_id FROM Venda WHERE ven_id = @coddvenda ";
                MySqlConnection conexao3 = new MySqlConnection(cnsql);
                MySqlCommand comando3 = new MySqlCommand(sql3, conexao3);
                conexao3.Open();
                //passar os parâmetros - M
                comando3.Parameters.AddWithValue("@coddvenda", coddvenda);
                comando3.ExecuteNonQuery();
                cliente = Convert.ToInt32(comando3.ExecuteScalar());
                conexao3.Close();

                string sql4 = "SELECT ven_dia FROM Venda WHERE ven_id = @coddvenda ";
                MySqlConnection conexao4 = new MySqlConnection(cnsql);
                MySqlCommand comando4 = new MySqlCommand(sql4, conexao4);
                conexao4.Open();
                //passar os parâmetros - M
                comando4.Parameters.AddWithValue("@coddvenda", coddvenda);
                comando4.ExecuteNonQuery();
                dia = Convert.ToString(comando4.ExecuteScalar());
                conexao4.Close();

                string sql5 = "SELECT ven_hora FROM Venda WHERE ven_id = @coddvenda ";
                MySqlConnection conexao5 = new MySqlConnection(cnsql);
                MySqlCommand comando5 = new MySqlCommand(sql5, conexao5);
                conexao5.Open();
                //passar os parâmetros - M
                comando5.Parameters.AddWithValue("@coddvenda", coddvenda);
                comando5.ExecuteNonQuery();
                hora = Convert.ToString(comando5.ExecuteScalar());
                conexao5.Close();

                string sql6 = "SELECT ven_total FROM Venda WHERE ven_id = @coddvenda ";
                MySqlConnection conexao6 = new MySqlConnection(cnsql);
                MySqlCommand comando6 = new MySqlCommand(sql6, conexao6);
                conexao6.Open();
                //passar os parâmetros - M
                comando6.Parameters.AddWithValue("@coddvenda", coddvenda);
                comando6.ExecuteNonQuery();
                total = Convert.ToDouble(comando6.ExecuteScalar());
                conexao6.Close();

                cliente = Convert.ToInt32(cb_clientevenda.SelectedValue);

                string sql9= "SELECT cli_nome FROM clientes WHERE cli_id = @cliente";

                MySqlConnection conexao9 = new MySqlConnection(cnsql); //criar conexão
                MySqlCommand comando9 = new MySqlCommand(sql9, conexao9); // criar comando e ligar com o sql e conexão
                conexao9.Open(); //abrir conexão
                comando9.Parameters.AddWithValue("@cliente", cliente);
                clinome = Convert.ToString(comando9.ExecuteScalar());
                conexao9.Close();

                //////////////////////////////////////////////////////////

                string sql = "INSERT INTO promissoria(Venda_ven_id, Venda_Clientes_cli_id, Venda_ven_data, Venda_ven_hora, prom_totalrestante, prom_ultimopagamento, prom_total, Clientes_cli_nome) " +
                    "VALUES (@codvenda, @codcli, @dia, @hora, @restante, @ultimopag, @total, @clinome)";

                MySqlConnection conexao = new MySqlConnection(cnsql);
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                //passar os parâmetros - M
                comando.Parameters.AddWithValue("@codvenda", codvenda);
                comando.Parameters.AddWithValue("@codcli", cliente);
                comando.Parameters.AddWithValue("@dia", dia);
                comando.Parameters.AddWithValue("@hora", hora);
                comando.Parameters.AddWithValue("@restante", restante);
                comando.Parameters.AddWithValue("@ultimopag", ultimopag);
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.AddWithValue("@clinome", clinome);
                comando.ExecuteNonQuery();  //executar -M
                MessageBox.Show("Promissória gerada com sucesso!", "Promissória gerada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar1();
                invisivelfinalizar();

            }

            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao adicionar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
        private void bt_prom_Click(object sender, EventArgs e)
        {
            gerarpromissoria();
        }

        private void txt_tecprod_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_finalizar_Click(object sender, EventArgs e)
        {

        }

        private void bt_limparcid_Click(object sender, EventArgs e)
        {
            buscaritensdasvendas();
        }

        private void bt_limparcid2_Click(object sender, EventArgs e)
        {
            limpar2();
        }

        private void buscarvenda()
        {
            string sql = "SELECT ven_id AS Código, Clientes_cli_id AS CódigoCliente, Clientes_cli_nome AS Cliente, ven_dia AS Data, ven_hora AS Horário, ven_total AS Total FROM venda"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão

            if (comboBox2.Text == "Cliente")
            {
                sql = sql + " WHERE Clientes_cli_nome LIKE @nome";
                comando.Parameters.AddWithValue("@nome", textBox1.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                        //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (comboBox2.Text == "Data")
            {
                sql = sql + " WHERE ven_dia LIKE @data";
                comando.Parameters.AddWithValue("@data", textBox1.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                        //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (comboBox2.Text == "Código")
            {
                sql = sql + " WHERE ven_id = @cod";
                comando.Parameters.AddWithValue("@cod", textBox1.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                       //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (comboBox2.Text == "")
            {
                comando.CommandText = sql;
            }
            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            dataGridView3.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buscarvenda();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            limpar3();
        }

        private void txt_tecprod_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pegarcodproduto()
        {
            string sql2 = "SELECT prod_id FROM produtos WHERE prod_nome LIKE @nome"; //criar sqls
            MySqlConnection conexao2 = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando2 = new MySqlCommand(sql2, conexao2); // criar comando e ligar com o sql e conexão
            conexao2.Open(); //abrir conexão
            comando2.Parameters.AddWithValue("@nome", txt_buscaprod.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras                                                                   //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
            comando2.CommandText = sql2;

            produto = Convert.ToInt32(comando2.ExecuteScalar());
            txt_codprod.Text = Convert.ToString(produto);
            conexao2.Close();
        }

        private void pegarquantdoprod()
        {
            int quantidade;
            pegarcodproduto();
            string sql2 = "SELECT prod_quantidade FROM produtos WHERE prod_id = @produto"; //criar sqls
            MySqlConnection conexao2 = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando2 = new MySqlCommand(sql2, conexao2); // criar comando e ligar com o sql e conexão
            conexao2.Open(); //abrir conexão
            comando2.Parameters.AddWithValue("@produto", produto);                  

            quantidade = Convert.ToInt32(comando2.ExecuteScalar());
            txt_quantdisp.Text = Convert.ToString(quantidade);
            conexao2.Close();

        }
        private void calcularsubtotal()
        {
            subtotal = quantidade * precunic;
        }
        private void preenchergriditens()
        {
            pegarultimocod();
            string sql = "SELECT itens_id AS CódigoItem, Produtos_prod_id AS CódigoProduto, Venda_ven_id AS CódigoVenda, itens_quanti AS Quantidade, itens_prec AS Preço, " +
            "itens_subtotal AS Subtotal FROM itens WHERE Venda_ven_id = @codvenda";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@codvenda", codvenda);
            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            grid_itens.DataSource = dt;
        }

        private void cadastraritemnavenda()
        {
            quantidade = Convert.ToInt32(txt_tecprod.Text);
            coditem = Convert.ToInt32(txt_codprod.Text);


            string sql7= "SELECT prod_nome FROM Produtos WHERE prod_id = @coditem";
            MySqlConnection conexao7 = new MySqlConnection(cnsql);
            MySqlCommand comando7= new MySqlCommand(sql7, conexao7);
            conexao7.Open();
            comando7.Parameters.AddWithValue("@coditem", coditem);
            nomeprod = Convert.ToString(comando7.ExecuteScalar());
            conexao7.Close();

            string sql1 = "SELECT MAX(ven_id) FROM venda";
            MySqlConnection conexao1 = new MySqlConnection(cnsql);
            MySqlCommand comando1 = new MySqlCommand(sql1, conexao1);
            conexao1.Open();
            codvenda = Convert.ToInt32(comando1.ExecuteScalar());
            conexao1.Close();
            saberovalor();
            calcularsubtotal();

             try
             {  
                string sql = "INSERT INTO itens(Produtos_prod_id, Produtos_prod_nome, Venda_ven_id, itens_quanti, itens_prec, itens_subtotal)" +
                    " VALUES (@produto, @nomeprod, @codvenda, @quantidade, @precunic, @subtotal)";


                    MySqlConnection conexao = new MySqlConnection(cnsql);
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    //passar os parâmetros - M
                    comando.Parameters.AddWithValue("@produto", produto);
                    comando.Parameters.AddWithValue("@nomeprod", nomeprod);
                    comando.Parameters.AddWithValue("@codvenda", codvenda);
                    comando.Parameters.AddWithValue("@quantidade", quantidade);
                    comando.Parameters.AddWithValue("@precunic", precunic);
                    comando.Parameters.AddWithValue("@subtotal", subtotal);
                    comando.ExecuteNonQuery();  //executar -M
                    preenchergriditens();
                    preenchergriditens2();
             }

             catch (SqlException ex)
             {
                MessageBox.Show("Erro ao adicionar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
             }
            

        }

        private void calculartotal()
        {
            string sql1 = "SELECT MAX(ven_id) FROM venda";
            MySqlConnection conexao1 = new MySqlConnection(cnsql);
            MySqlCommand comando1 = new MySqlCommand(sql1, conexao1);
            conexao1.Open();
            codvenda = Convert.ToInt32(comando1.ExecuteScalar());
            conexao1.Close();

            string sql = "SELECT SUM(itens_subtotal) FROM itens WHERE Venda_ven_id = @codvenda";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@codvenda", codvenda);
            double total2;
            total2 = Convert.ToDouble(comando.ExecuteScalar());
            total = total2;
            txt_total.Text = Convert.ToString(total);
        }

        private void alterartotal()
        {
            string sql1 = "SELECT MAX(ven_id) FROM venda";
            MySqlConnection conexao1 = new MySqlConnection(cnsql);
            MySqlCommand comando1 = new MySqlCommand(sql1, conexao1);
            conexao1.Open();

            codvenda = Convert.ToInt32(comando1.ExecuteScalar());
            conexao1.Close();
            calculartotal();

            string sql = "UPDATE venda SET ven_total = @total WHERE ven_id = @codvenda";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@codvenda", codvenda);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
