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
    public partial class form_fornecedores : Form
    {
        string cnsql = "";
        public form_fornecedores(string cn)
        {
            cnsql = cn;
            InitializeComponent();
            
        }
        private void verificacadigual()
        {
            string sql = "SELECT * FROM fornecedores WHERE forn_id = @forn_id";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@forn_id", MySqlDbType.Int32).Value = Convert.ToInt32(txt_codforn.Text);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("Código já existente: " + txt_codforn.Text);
                txt_codforn.Clear();
                txt_codforn.Focus();

            }
            conexao.Close();

        }
        public void preenchercombo()
        {
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand query = new MySqlCommand();
            query.Connection = conexao;
            conexao.Open();

            query.CommandText = "SELECT cid_id, cid_nome FROM cidades ORDER BY cid_nome";

            MySqlDataReader tabela;
            tabela = query.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(tabela);
            cb_cidforn.DisplayMember = "cid_nome";
            cb_cidforn.ValueMember = "cid_id";

            cb_cidforn.DataSource = dt;
        }
        public void preenchercombo2()
        {
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand query = new MySqlCommand();
            query.Connection = conexao;
            conexao.Open();

            query.CommandText = "SELECT cid_id, cid_nome FROM cidades ORDER BY cid_nome";

            MySqlDataReader tabela;
            tabela = query.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(tabela);
            cb_cateforne2.DisplayMember = "cid_nome";
            cb_cateforne2.ValueMember = "cid_id";

            cb_cateforne2.DataSource = dt;
        }

        private void verificacnpj()
        {
            string cnpjforn = mktxt_cnpjforn.Text;
            string sql = "SELECT * FROM fornecedores WHERE forn_cnpj = @cnpjforn";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cnpjforn", cnpjforn);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("CNPJ já existente: " + mktxt_cnpjforn.Text);
                mktxt_cnpjforn.Clear();
                mktxt_cnpjforn.Focus();

            }
            else
            {
                cadastrar();
            }
            conexao.Close();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void preenchergridforn()
        {
            string sql;
            sql = "SELECT forn_id AS Codigo, forn_cnpj AS CNPJ, forn_nome AS Nome, forn_categoria AS Categoria, " +
            "forn_telefone AS Telefone, forn_email AS Email, forn_datacadas AS Cadastro, forn_endereco AS Endereço, cid_id AS Cidade FROM fornecedores";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();

            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            grid_buscafornecedores.DataSource = dt;


        }
        private void cadastrar() 
        { 
            int cod, cidade;
            string nome, telefone, endereco, email, cnpj, categoria, dcadastro;
            cod = Convert.ToInt32(txt_codforn.Text);
            nome = txt_nomeforn.Text;
            cidade = Convert.ToInt32(cb_cidforn.SelectedValue);
            telefone = mktxt_telforn.Text;
            endereco = txt_enderecoforn.Text;
            email = txt_emailforn.Text;
            cnpj = mktxt_cnpjforn.Text;
            dcadastro = mktxt_dataforn.Text;
            categoria = cb_categoria.Text;
            verificacadigual();
            

            if (nome == String.Empty || telefone == String.Empty || mktxt_dataforn.Text == "" || cnpj == String.Empty || categoria == String.Empty || endereco == String.Empty || email == String.Empty || txt_codforn.Text == String.Empty || cb_cidforn.Text == "" )
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //comandin de texto - M
            else
            {
                try
                {
                    string sql = "INSERT INTO fornecedores VALUES(@cod, @cnpj, @nome,  @categoria, @telefone, @email,  @dcadastro,  @endereco,  @cidade)";


                    MySqlConnection conexao = new MySqlConnection(cnsql);
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    //passar os parâmetros - M
                    comando.Parameters.AddWithValue("@cod", cod);
                    comando.Parameters.AddWithValue("@cnpj", cnpj);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@categoria", categoria);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@dcadastro", dcadastro);
                    comando.Parameters.AddWithValue("@endereco", endereco);
                    comando.Parameters.AddWithValue("@cidade", cidade);

                    comando.ExecuteNonQuery();  //executar -M

                    MessageBox.Show("Fornecedor cadastrado com sucesso!", "Fornecedor Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void limpar1()
        {
            txt_codforn.Clear();
            txt_nomeforn.Clear();
            cb_cidforn.Text = "";
            mktxt_telforn.Clear();
            txt_enderecoforn.Clear();
            txt_emailforn.Clear();
            mktxt_cnpjforn.Clear();
            mktxt_dataforn.Clear();
            cb_categoria.Text = "";
        }



        private void limpar3()
        {
            cb_buscaforne.Text = "";
            txt_buscaforne.Clear();

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {

            verificacnpj();
            preenchergridforn();
        }

        private void bt_volatcfor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void form_fornecedores_Load(object sender, EventArgs e)
        {
            preenchercombo();
            preenchergridforn();

            this.grid_buscafornecedores.DefaultCellStyle.Font = new Font("Arial", 12);
            this.grid_buscafornecedores.DefaultCellStyle.ForeColor = Color.Black;
            this.grid_buscafornecedores.DefaultCellStyle.BackColor = Color.White;

            this.grid_buscafornecedores.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);

        }

        private void bt_buscarcli_Click(object sender, EventArgs e)
        {
            pesquisarfornecedores();
        }

        private void pesquisarfornecedores()
        {
            preenchergridforn();
            string sql = "SELECT * FROM fornecedores"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão

            if (cb_buscaforne.Text == "Nome")
            {
                sql = sql + " WHERE forn_nome LIKE @nome";
                comando.Parameters.AddWithValue("@nome", txt_buscaforne.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscaforne.Text == "Categoria")
            {
                sql = sql + " WHERE forn_categoria LIKE @categoria";
                comando.Parameters.AddWithValue("@categoria", txt_buscaforne.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscaforne.Text == "")
            {
                comando.CommandText = sql;
            }
            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            grid_buscafornecedores.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }

        private void bt_alterarcid_Click(object sender, EventArgs e)
        {
            alterar();
            preenchergridforn();
        }
        
        private void alterar()
        {
            int cod, cidade;
            string nome, telefone, endereco, email, cnpj, categoria;
            DateTime dcadastro;
            cod = Convert.ToInt32(txt_codforne2.Text);
            nome = txt_nomeforne2.Text;
            cidade = Convert.ToInt32(cb_cidforne2.SelectedValue);
            telefone = mk_telforne2.Text;
            endereco = txt_endforne2.Text;
            email = txt_emailforne2.Text;
            cnpj = mk_cnpjforne2.Text;
            dcadastro = Convert.ToDateTime(mk_dataforne2.Text);
            categoria = cb_cateforne2.Text;
            verificacadigual();

            if (nome == String.Empty || telefone == String.Empty || mktxt_dataforn.Text == "" || cnpj == String.Empty || categoria == String.Empty || endereco == String.Empty || email == String.Empty || txt_codforn.Text == String.Empty || cb_cidforn.Text == "")
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string sql;
                sql = "UPDATE fornecedores SET forn_cnpj=@cnpj, forn_nome=@nome, forn_categoria=@categoria, forn_telefone=@telefone, " +
                    "forn_email=@email, forn_datacadas=@dcadastro, forn_endereco=@endereco, cid_id=@cidade WHERE forn_id = @cod  ";
                MySqlConnection conexao = new MySqlConnection(cnsql);
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();

                comando.Parameters.AddWithValue("@cod", cod);
                comando.Parameters.AddWithValue("@cnpj", cnpj);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@dcadastro", dcadastro);
                comando.Parameters.AddWithValue("@endereco", endereco);
                comando.Parameters.AddWithValue("@cidade", cidade);

                comando.ExecuteNonQuery();

                MessageBox.Show("Os dados de " + nome + " foram atualizados com sucesso!", "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar2();
                preenchergridforn();
                conexao.Close();
            }
        }
        private void limpar2()
        {
            txt_codforne2.Clear();
            txt_nomeforne2.Clear();
            cb_cidforne2.Text = "";
            mk_telforne2.Clear();
            txt_endforne2.Clear();
            txt_emailforne2.Clear();
            mk_cnpjforne2.Clear();
            mk_dataforne2.Text = "";
            cb_cateforne2.Text = "";
        }

        private void enviardadosparaoutroform()
        {
            txt_codforne2.Text = Convert.ToString(grid_buscafornecedores.CurrentRow.Cells[0].Value); // A textbox da user_altexclu receber os dados da grid de busca
            mk_cnpjforne2.Text = Convert.ToString(grid_buscafornecedores.CurrentRow.Cells[1].Value);
            txt_nomeforne2.Text = Convert.ToString(grid_buscafornecedores.CurrentRow.Cells[2].Value);
            cb_cateforne2.Text = Convert.ToString(grid_buscafornecedores.CurrentRow.Cells[3].Value);
            mk_telforne2.Text = Convert.ToString(grid_buscafornecedores.CurrentRow.Cells[4].Value);
            txt_emailforne2.Text = Convert.ToString(grid_buscafornecedores.CurrentRow.Cells[5].Value);
            mk_dataforne2.Text = Convert.ToString(grid_buscafornecedores.CurrentRow.Cells[6].Value);
            txt_endforne2.Text = Convert.ToString(grid_buscafornecedores.CurrentRow.Cells[7].Value);
            cb_cidforne2.Text = Convert.ToString(grid_buscafornecedores.CurrentRow.Cells[8].Value);
            tabControl1.SelectedTab = forne_altexclu; //fazer com que os dados vão para lá, a page certinha 
        }

        private void grid_buscafornecedores_DoubleClick(object sender, EventArgs e)
        {
            enviardadosparaoutroform();
        }
        private void excluircadastro()
        {
            int cod;
            cod = Convert.ToInt32(txt_codforne2.Text);
            DialogResult confirmar = MessageBox.Show("Deseja realmente excluir o cadastro?", "Deletar cadastro!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmar == DialogResult.Yes)
            {
                string sql;
                sql = "DELETE FROM fornecedores WHERE forn_id = @cod";
                MySqlConnection conexao = new MySqlConnection(cnsql);
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();

                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@cod", cod);
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro excluído com sucesso!", "Cadastro deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                preenchergridforn();
                conexao.Close();
                limpar2();
            }

        }
        private void bt_excluircli_Click(object sender, EventArgs e)
        {
            excluircadastro();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            limpar1();
        }

        private void bt_limparcli_Click(object sender, EventArgs e)
        {
            limpar3();
        }
    }
}
