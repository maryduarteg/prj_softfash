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
    public partial class Form_funcionarios : Form
    {
        string cnsql;
        public Form_funcionarios(string cn)
        {
            InitializeComponent();
            cnsql = cn;
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
            cb_cidfunc.DisplayMember = "cid_nome";
            cb_cidfunc.ValueMember = "cid_id";

            cb_cidfunc.DataSource = dt;
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
            cb_cidadefunc2.DisplayMember = "cid_nome";
            cb_cidadefunc2.ValueMember = "cid_id";

            cb_cidadefunc2.DataSource = dt;
        }
        private void verificacadigual()
        {
            string sql = "SELECT * FROM funcionarios WHERE func_id = @func_id";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@func_id", MySqlDbType.Int32).Value = Convert.ToInt32(txt_codfunc.Text);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("Código já existente: " + txt_codfunc.Text);
                txt_codfunc.Clear();
                txt_codfunc.Focus();

            }
            else
            {
                verificacpf();
            }
            conexao.Close();
        }
        private void verificarg()
        {
            string rg = mktxt_rgfunc.Text;
            string sql = "SELECT * FROM funcionarios WHERE func_rg = @rg";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@rg", rg);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("RG já existente: " + mktxt_rgfunc.Text);
                mktxt_rgfunc.Clear();
                mktxt_rgfunc.Focus();

            }
            else
            {
                cadastrar();
            }
            conexao.Close();
        }
        private void verificacpf()
        {
            string cpf = mktxt_cpffunc.Text;
            string sql = "SELECT * FROM funcionarios WHERE func_cpf  = @cpf ";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cpf", cpf);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("CPF já existente: " + mktxt_cpffunc.Text);
                mktxt_cpffunc.Clear();
                mktxt_cpffunc.Focus();

            }
            else
            {
                verificarg();
            }

            conexao.Close();
        }

        private void cadastrar()
        {
            int cod, cidade;
            string nome, telefone, endereco, email, rg, cpf, funcao, salario, dnascimento, dadmissao;
            cod = Convert.ToInt32(txt_codfunc.Text);
            nome = txt_nomefunc.Text;
            cidade = Convert.ToInt32(cb_cidfunc.SelectedValue);
            telefone = mktxt_telfunc.Text;
            endereco = txt_enderecofunc.Text;
            email = txt_emailfunc.Text;
            rg = mktxt_rgfunc.Text;
            cpf = mktxt_cpffunc.Text;
            dnascimento = mktb_nasc.Text;
            funcao = txt_funcaofunc.Text;
            salario = txt_salfunc.Text;
            dadmissao =  mktxt_datafunc.Text;

            if (nome == String.Empty || cb_cidfunc.Text == "" || telefone == String.Empty || mktb_nasc.Text == String.Empty || mktxt_datafunc.Text == String.Empty || salario == String.Empty || rg == String.Empty || cpf == String.Empty || funcao == String.Empty || endereco == String.Empty || email == String.Empty || txt_codfunc.Text == "")
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //comandin de texto - M
            else
            {
                try
                {
                    string sql = "";
                    sql = "INSERT INTO funcionarios VALUES(@cod, @cpf, @rg, @nome, @endereco, @cidade, @telefone, @dadmissao, @dnascimento, @email, @funcao, @salario)";


                    MySqlConnection conexao = new MySqlConnection(cnsql);
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    //passar os parâmetros - M
                    comando.Parameters.AddWithValue("@cod", cod);
                    comando.Parameters.AddWithValue("@cpf", cpf);
                    comando.Parameters.AddWithValue("@rg", rg);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@endereco", endereco);
                    comando.Parameters.AddWithValue("@cidade", cidade);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.Parameters.AddWithValue("@dadmissao", dadmissao);
                    comando.Parameters.AddWithValue("@dnascimento", dnascimento);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@funcao", funcao);
                    comando.Parameters.AddWithValue("@salario", salario);
                    comando.ExecuteNonQuery();  //executar -M

                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
        }
        private void preenchergrifunc()
        {
            string sql;
            sql = "SELECT func_id AS Código, func_cpf AS CPF, func_rg AS RG, func_nome AS Nome, func_endereco AS Endereço," +
            " cid_id AS Cidade, func_celular AS Celular, func_dataadms AS Cadastro, func_datanasci AS Nascimento, func_email AS Email, func_funcao AS Função, func_salario AS Salário FROM funcionarios";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();

            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            grid_buscafunc.DataSource = dt;


        }

        private void Form_funcionarios_Load(object sender, EventArgs e)
        {
            preenchergrifunc();
            preenchercombo();

            this.grid_buscafunc.DefaultCellStyle.Font = new Font("Arial", 12);
            this.grid_buscafunc.DefaultCellStyle.ForeColor = Color.Black;
            this.grid_buscafunc.DefaultCellStyle.BackColor = Color.White;

            this.grid_buscafunc.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void bt_voltarcfun_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            verificacadigual();
            preenchergrifunc();
        }
        
        private void buscar()
        {
            string sql = "SELECT func_id AS Código, func_cpf AS CPF, func_rg AS RG, func_nome AS Nome, func_endereco AS Endereço, func_bairro AS Bairro," +
            " cid_id AS Cidade, func_celular AS Celular, func_dataadms AS Admissão, func_datanasci AS Nascimento, func_email AS Email, func_funcao AS Função, func_salario AS Salário FROM funcionarios"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão

            if (cb_buscafunc.Text == "Nome")
            {
                sql = sql + " WHERE user_login LIKE @login";
                comando.Parameters.AddWithValue("@login", txt_buscafunc.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscafunc.Text == "CPF")
            {
                sql = sql + " WHERE func_cpf LIKE @cpf";
                comando.Parameters.AddWithValue("@cpf", txt_buscafunc.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
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
            grid_buscafunc.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }

        private void bt_buscarcli_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void mandaroutroform()
        {
            txt_codfunc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[0].Value); // A textbox da user_altexclu receber os dados da grid de busca
            mktxt_cpffunc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[1].Value);
            mktxt_rgfunc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[2].Value);
            txt_nomefunc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[3].Value);
            txt_enderecofunc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[4].Value);
            cb_cidadefunc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[5].Value);
            mktxt_telefonefunc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[6].Value);
            mktxt_datacadfunc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[7].Value);
            mktb_nasc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[8].Value);
            txt_emailfunc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[9].Value);
            txt_funcaofunc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[10].Value);
            txt_salfunc2.Text = Convert.ToString(grid_buscafunc.CurrentRow.Cells[11].Value);
            tabControl1.SelectedTab = func_altexclu; //fazer com que os dados vão para lá, a page certinha 
    
        }

        private void alterar()
        {
            int cod, cidade;
            
            string nome, telefone, endereco, email, rg, cpf, funcao, salario, dnascimento, dadmissao;
            cod = Convert.ToInt32(txt_codfunc2.Text);
            nome = txt_nomefunc2.Text;
            cidade = Convert.ToInt32(cb_cidadefunc2.SelectedValue);
            telefone = mktxt_telefonefunc2.Text;
            endereco = txt_enderecofunc2.Text;
            email = txt_emailfunc2.Text;
            rg = mktxt_rgfunc2.Text;
            cpf = mktxt_cpffunc2.Text;
            dnascimento = mktb_nasc2.Text;
            funcao = txt_funcaofunc2.Text;
            salario = txt_salfunc2.Text;
            dadmissao = mktxt_datacadfunc2.Text;

            if (nome == String.Empty || cb_cidfunc.Text == "" || telefone == String.Empty || mktxt_datacadfunc2.Text == "" || mktb_nasc2.Text == "" || salario == String.Empty || rg == String.Empty || cpf == String.Empty || funcao == String.Empty || endereco == String.Empty || email == String.Empty || txt_codfunc.Text == "")
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //comandin de texto - M
            else
            {
                try
                {
                  string sql = "UPDATE funcionarios SET func_nome = @nome, func_endereco = @endereco, cid_id = @cidade, func_celular = @telefone, func_dataadms = @dadmissao, " +
                   "func_datanasci = @dnascimento, func_email = @email, func_funcao = @funcao, func_salario = @salario WHERE func_id = @cod ";
                   


                    MySqlConnection conexao = new MySqlConnection(cnsql);
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    //passar os parâmetros - M
                    comando.Parameters.AddWithValue("@cod", cod);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@endereco", endereco);
                    comando.Parameters.AddWithValue("@cidade", cidade);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.Parameters.AddWithValue("@dadmissao", dadmissao);
                    comando.Parameters.AddWithValue("@dnascimento", dnascimento);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@funcao", funcao);
                    comando.Parameters.AddWithValue("@salario", salario);
                    comando.ExecuteNonQuery();  //executar -M

                    MessageBox.Show("Funcionário alterado com sucesso!");
                    limpar3();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao alterar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
        }

        private void grid_buscafunc_DoubleClick(object sender, EventArgs e)
        {
            mandaroutroform();
        }
        private void verificarg2()
        {
            string rg = mktxt_rgfunc2.Text;
            string sql = "SELECT * FROM funcionarios WHERE func_rg=@rg";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@rg", rg);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("RG já existente: " + mktxt_rgfunc2.Text);
                mktxt_rgfunc2.Clear();
                mktxt_rgfunc2.Focus();

            }
            else
            {
                alterar();
            }
            conexao.Close();
        }

        private void verificacpf2()
        {
            string cpf = mktxt_cpffunc2.Text;
            string sql = "SELECT * FROM funcionarios WHERE func_cpf  = @cpf ";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cpf", cpf);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("CPF já existente: " + mktxt_cpffunc2.Text);
                mktxt_cpffunc2.Clear();
                mktxt_cpffunc2.Focus();

            }
            else
            {
                verificarg2();
            }

            conexao.Close();
        }

        private void limpar1()
        {
            txt_codfunc.Clear();
            mktxt_cpffunc.Clear();
            mktxt_rgfunc.Clear();
            txt_nomefunc.Clear();
            mktb_nasc.Clear();
            txt_emailfunc.Clear();
            mktxt_telfunc.Clear();
            cb_cidfunc.Text = "";
            txt_enderecofunc.Clear();
            mktxt_datafunc.Clear();
            txt_funcaofunc.Clear();
            txt_salfunc.Clear();
        }

        private void limpar2()
        {
            cb_buscafunc.Text = "";
            txt_buscafunc.Clear();

        }

        private void limpar3()
        {
            txt_codfunc2.Clear();
            mktxt_cpffunc2.Clear();
            mktxt_rgfunc2.Clear();
            txt_nomefunc2.Clear();
            mktb_nasc2.Clear();
            txt_emailfunc2.Clear();
            mktxt_telefonefunc2.Clear();
            cb_cidadefunc2.Text = "";
            txt_enderecofunc2.Clear();
            mktxt_datacadfunc2.Clear();
            txt_funcaofunc2.Clear();
            txt_salfunc2.Clear();
        }

        

        private void bt_alterarcid_Click(object sender, EventArgs e)
        {
            verificacpf2();
            preenchergrifunc();
        }

        private void excluircadastro()
        {
            int cod;
            cod = Convert.ToInt32(txt_codfunc2.Text);
            DialogResult confirmar = MessageBox.Show("Deseja realmente excluir o cadastro?", "Deletar cadastro!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmar == DialogResult.Yes)
            {
                string sql;
                sql = "DELETE FROM funcionarios WHERE func_id = @cod";
                MySqlConnection conexao = new MySqlConnection(cnsql);
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();

                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@cod", cod);
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro excluído com sucesso!", "Cadastro deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                preenchergrifunc();
                conexao.Close();
                limpar3();
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

        private void bt_limparcid3_Click(object sender, EventArgs e)
        {
            limpar3();
        }

        private void bt_limparcli_Click(object sender, EventArgs e)
        {
            limpar2();
        }
    }
}
