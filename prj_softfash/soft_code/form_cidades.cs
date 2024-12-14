using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.CSharp;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace soft_code
{
   
    public partial class form_cidades : Form
    {
        string cnsql;
        public form_cidades(string cn)
        {
            
            InitializeComponent();
            cnsql = cn;
        }
        private void verificacadigual()
        {
            string sql = "SELECT * FROM cidades WHERE cid_id = @cid_id";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cid_id", MySqlDbType.Int32).Value = Convert.ToInt32(tb_cod.Text);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("Código já existente: " + tb_cod.Text);
                tb_cod.Clear();
                tb_cod.Focus();

            }
            else
            {
                cadastrar();
            }
            conexao.Close();


        }
        private void preenchergriduser()
        {
            string sql;
            sql = "SELECT cid_id AS Código, cid_nome AS Nome, cid_codigoibge AS CódigoIBGE, cid_estado AS Estado FROM cidades";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();

            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            grid_buscacidades.DataSource = dt;


        }
        private void verificacodibge()
        {
            string cdibge = tb_codibge.Text;
            string sql = "SELECT * FROM cidades WHERE cid_codigoibge = @cid_codibge";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cid_codibge", cdibge);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("Código do IBGE já existente: " + tb_codibge.Text);
                tb_codibge.Clear();
                tb_codibge.Focus();

            }
            conexao.Close();


        }

        private void limpar1()
        {
            cb_buscacid.Text = "";
            txt_buscacid.Text = "";
        }

        private void limpar3()
        {
            tb_cod.Clear();
            tb_codibge.Clear();
            txt_nome.Clear();
            cb_estados.Text = "";
        }
        private void cadastrar() // Funnção de leve para enxugar o code - M
        {
            
            int cod;
            string estado, nome, cdibge;
            cod = Convert.ToInt32(tb_cod.Text);
            nome = txt_nome.Text;
            cdibge = tb_codibge.Text;
            estado = cb_estados.Text;
            verificacodibge();

            if (nome == String.Empty || estado == String.Empty || cdibge == String.Empty || tb_cod.Text == String.Empty)
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //comandin de texto - M
            else
            {
                try
                {
                    string sql = "";
                    sql = "INSERT INTO cidades VALUES(@cod, @nome, @cdibge, @estado)";


                    MySqlConnection conexao = new MySqlConnection(cnsql);
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    //passar os parâmetros - M
                    comando.Parameters.AddWithValue("@cod", cod);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@cdibge", cdibge);
                    comando.Parameters.AddWithValue("@estado", estado);
                    comando.ExecuteNonQuery();  //executar -M

                    MessageBox.Show("Cidade cadastrada com sucesso!", "Usuário Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.Close();
                    limpar1();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
            
        }

        private void pesquisarcadastros()
        {
            preenchergriduser();
            string sql = "SELECT cid_id AS Código, cid_nome AS Nome, cid_codigoibge AS CódigoIBGE, cid_estado AS Estado FROM cidades"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão

            if (cb_buscacid.Text == "Nome")
            {
                sql = sql + " WHERE cid_nome LIKE @nome";
                comando.Parameters.AddWithValue("@nome", txt_buscacid.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscacid.Text == "Estado")
            {
                sql = sql + " WHERE cid_estado LIKE @estado";
                comando.Parameters.AddWithValue("@estado", txt_buscacid.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscacid.Text == "Código")
            {
                sql = sql + " WHERE cid_id = @cod";
                comando.Parameters.AddWithValue("@cod", MySqlDbType.Int32).Value = Convert.ToInt32(txt_buscacid.Text);
                comando.CommandText = sql;
            }
            else if (cb_buscacid.Text == "Código IBGE")
            {
                sql = sql + " WHERE cid_codigoibge = @codibge";
                comando.Parameters.AddWithValue("@codibge", MySqlDbType.Int32).Value = Convert.ToInt32(txt_buscacid.Text);
                comando.CommandText = sql;
            }
            else if (cb_buscacid.Text == "")
            {
                comando.CommandText = sql;
            }
            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            grid_buscacidades.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            verificacadigual();
            preenchergriduser();
            limpar3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_limparcid_Click(object sender, EventArgs e)
        {
            pesquisarcadastros();
        }

       

        private void txt_buscacid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void alterar()
        {
            int cod;
            string estado2, nome2, cdibge2;
            cod = Convert.ToInt32(txt_codcid2.Text);
            nome2 = txt_nomecid2.Text;
            cdibge2 = txt_codibge2.Text;
            estado2 = cb_estcid2.Text;

            if (nome2 == String.Empty || estado2 == String.Empty || cdibge2 == String.Empty || txt_codcid2.Text == String.Empty)
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                string sql;
                sql = "UPDATE cidades SET cid_nome = @nome2, cid_codigoibge = @codibge2, cid_estado = @estado2 WHERE cid_id = @cod";
                MySqlConnection conexao = new MySqlConnection(cnsql);
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();

                comando.Parameters.AddWithValue("@cod", cod);
                comando.Parameters.AddWithValue("@nome2", nome2);
                comando.Parameters.AddWithValue("@codibge2", cdibge2);
                comando.Parameters.AddWithValue("@estado2", estado2);

                comando.ExecuteNonQuery();

                MessageBox.Show("Os dados de " + nome2 + " foram atualizados com sucesso!", "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar2();
                preenchergriduser();
                conexao.Close();
            }
        }
        private void excluircadastro()
        {
            int cod;
            cod = Convert.ToInt32(txt_codcid2.Text);
            DialogResult confirmar = MessageBox.Show("Deseja realmente excluir o cadastro?", "Deletar cadastro!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmar == DialogResult.Yes)
            {
                string sql;
                sql = "DELETE FROM cidades WHERE cid_id = @cod";
                MySqlConnection conexao = new MySqlConnection(cnsql);
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();

                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@cod", cod);
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro excluído com sucesso!", "Cadastro deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                preenchergriduser();
                conexao.Close();
                limpar2();
            }
        }
        private void bt_alterarcid_Click(object sender, EventArgs e)
        {
            alterar();
        }

        private void limpar2()
        {
            txt_codcid2.Clear();
            txt_nomecid2.Clear();
            txt_codibge2.Clear();
            cb_estcid2.Text = "";
        }
        private void enviardadosparaoutroform()
        {
            var index = grid_buscacidades.CurrentCell.RowIndex;

            txt_codcid2.Text = Convert.ToString(grid_buscacidades.Rows[index].Cells[0].Value);
            txt_nomecid2.Text = Convert.ToString(grid_buscacidades.Rows[index].Cells[1].Value);
            txt_codibge2.Text = Convert.ToString(grid_buscacidades.Rows[index].Cells[2].Value);
            cb_estcid2.Text = Convert.ToString(grid_buscacidades.Rows[index].Cells[3].Value);

            tabControl1.SelectedTab = cid_altexclu;
        }

        private void grid_buscacidades_DoubleClick(object sender, EventArgs e)
        {
            enviardadosparaoutroform();
        }

        private void bt_excluircid_Click(object sender, EventArgs e)
        {
            excluircadastro();
            preenchergriduser();
        }

        private void form_cidades_Load(object sender, EventArgs e)
        {
            preenchergriduser();

            this.grid_buscacidades.DefaultCellStyle.Font = new Font("Arial", 12);
            this.grid_buscacidades.DefaultCellStyle.ForeColor = Color.Black;
            this.grid_buscacidades.DefaultCellStyle.BackColor = Color.White;

            this.grid_buscacidades.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            limpar3();
        }

        private void bt_limparcid2_Click(object sender, EventArgs e)
        {
            limpar1();
        }

        private void bt_limparcid3_Click(object sender, EventArgs e)
        {
            limpar2();
        }
    }
}
