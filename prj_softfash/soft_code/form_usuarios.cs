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
    public partial class form_usuarios : Form
    {
        //variáveis públicas - M
    
        string cnsql = "";
 
        
        public form_usuarios(string cn)
        {
            cnsql = cn;
            InitializeComponent();
        }

        private void limpar1()
        {
            txt_coduser.Clear();
            txt_loginuser.Clear();
            txt_senhauser.Clear();
            cb_carusu.Text = "";
        }

        private void limpar2()
        {
            txt_clicod2.Clear();
            txt_loginuser2.Clear();
            txt_senhauser2.Clear();
            cb_catuser2.Text = "";
        }

        private void limpar3()
        {
            cb_buscauser.Text = "";
            txt_buscauser.Clear();   
        }

        private void verificacadigual()
        {
            string sql  = "SELECT * FROM usuarios WHERE user_id = @user_id";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@user_id", MySqlDbType.Int32).Value=Convert.ToInt32(txt_coduser.Text);
            

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("Código já existente: " + txt_coduser.Text);
                txt_coduser.Clear();
                txt_coduser.Focus();

            }
            else
            {
                verificalogin();
            }
            conexao.Close();

        }
        private void verificalogin()
        {
            string login = txt_loginuser.Text;
            string sql = "SELECT user_id AS Código, user_login AS Login, user_senha AS Senha, user_categoria AS Categoria FROM usuarios WHERE user_login = @user_login";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@user_login", login);
            

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("Login já existente: " + txt_loginuser.Text);
                txt_loginuser.Clear();
                txt_loginuser.Focus();

            }
            else
            {
                cadastrar();
            }
            conexao.Close();


        }

        private void txt_coduser_MouseLeave(object sender, EventArgs e)
        {
            
        }


        private void cadastrar() // Funnção de leve para enxugar o code - M
        {
            int cod;
            string login, senha, cargo;
            cod = Convert.ToInt32(txt_coduser.Text);
            login = txt_loginuser.Text;
            senha = txt_senhauser.Text;
            cargo = cb_carusu.Text;
            verificacadigual();
            verificalogin();
            string sql = "INSERT INTO usuarios VALUES(@cod, @login, @senha, @cargo)";


            if (login == String.Empty || cargo == String.Empty || senha == String.Empty || txt_coduser.Text == String.Empty)
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //comandin de texto - M
            else
            {
                try
                {
                    MySqlConnection conexao = new MySqlConnection(cnsql);
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    //passar os parâmetros - M
                    comando.Parameters.AddWithValue("@cod", cod);
                    comando.Parameters.AddWithValue("@login", login);
                    comando.Parameters.AddWithValue("@senha", senha);
                    comando.Parameters.AddWithValue("@cargo", cargo);

                    comando.ExecuteNonQuery();  //executar -M

                    MessageBox.Show("Usuário cadastrado com sucesso!", "Usuário Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.Close();
                    limpar1();

                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
                preenchergriduser();
            }
        }
        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            verificacadigual();
            preenchergriduser();
        }
        private void pesquisarcadastros()
        {
            string sql = "SELECT user_id AS Código, user_login AS Login, user_senha AS Senha, user_categoria AS Categoria FROM usuarios"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão

            if (cb_buscauser.Text == "Login")
            {
                sql = sql + " WHERE user_login LIKE @login";
                comando.Parameters.AddWithValue("@login", txt_buscauser.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscauser.Text == "Cargo")
            {
                sql = sql + " WHERE user_categoria LIKE @cargo";
                comando.Parameters.AddWithValue("@cargo", txt_buscauser.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                     //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_buscauser.Text == "")
            {
                comando.CommandText = sql;
            }
            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            grid_buscauser.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }

        private void enviardadosparaoutroform()
        {
            txt_clicod2.Text = Convert.ToString(grid_buscauser.CurrentRow.Cells[0].Value); // A textbox da user_altexclu receber os dados da grid de busca
            txt_loginuser2.Text = Convert.ToString(grid_buscauser.CurrentRow.Cells[1].Value);
            txt_senhauser2.Text = Convert.ToString(grid_buscauser.CurrentRow.Cells[2].Value);
            cb_catuser2.Text = Convert.ToString(grid_buscauser.CurrentRow.Cells[3].Value);
            tabControl1.SelectedTab = user_altexclu; //fazer com que os dados vão para lá, a page certinha 
        }

        private void bt_buscarcli_Click(object sender, EventArgs e)
        {
            pesquisarcadastros();
        }

        private void grid_buscauser_DoubleClick(object sender, EventArgs e)
        {
            enviardadosparaoutroform();
        }
        private void preenchergriduser()
        {
            string sql;
            sql = "SELECT user_id AS Código, user_login AS Login, user_senha AS Senha, user_categoria AS Categoria FROM usuarios";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();

            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            grid_buscauser.DataSource = dt;
        }

        private void excluircadastro()
        {
            int cod;
            cod = Convert.ToInt32(txt_clicod2.Text);
            DialogResult confirmar = MessageBox.Show("Deseja realmente excluir o cadastro?", "Deletar cadastro!", MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirmar == DialogResult.Yes)
            {
                string sql;
                sql = "DELETE FROM usuarios WHERE user_id = @cod";
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

        private void bt_limparcli_Click(object sender, EventArgs e)
        {
            limpar3();
        }

        private void bt_excluircli_Click(object sender, EventArgs e)
        {
            excluircadastro();
            preenchergriduser();
        }
        private void alterar()
        {
            int cod;
            string login2, senha2, cargo2;
            cod = Convert.ToInt32(txt_clicod2.Text);
            login2 = txt_loginuser2.Text;
            senha2 = txt_senhauser2.Text;
            cargo2 = cb_catuser2.Text;

            if (login2 == String.Empty || cargo2 == String.Empty || senha2 == String.Empty || txt_clicod2.Text == String.Empty)
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                string sql;
                sql = "UPDATE usuarios SET user_login = @login, user_senha= @senha, user_categoria= @cargo WHERE user_id = @cod";
                MySqlConnection conexao = new MySqlConnection(cnsql);
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();

                comando.Parameters.AddWithValue("@cod", cod);
                comando.Parameters.AddWithValue("@login", login2);
                comando.Parameters.AddWithValue("@senha", senha2);
                comando.Parameters.AddWithValue("@cargo", cargo2);

                comando.ExecuteNonQuery();

                MessageBox.Show("Os dados de " + login2 + " foram atualizados com sucesso!", "Dados atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar2();
                preenchergriduser();
                conexao.Close();
            }
        }
        private void bt_alterarcid_Click(object sender, EventArgs e)
        {
            alterar();
        }

        private void txt_buscauser_TextChanged(object sender, EventArgs e)
        {
            pesquisarcadastros();
        }

        private void form_usuarios_Load(object sender, EventArgs e)
        {
            preenchergriduser();

            this.grid_buscauser.DefaultCellStyle.Font = new Font("Arial", 12);
            this.grid_buscauser.DefaultCellStyle.ForeColor = Color.Black;
            this.grid_buscauser.DefaultCellStyle.BackColor = Color.White;

            this.grid_buscauser.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);


        }

        private void bt_voltarcusu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpar7()
        {
            txt_coduser.Clear();
            txt_loginuser.Clear();
            txt_senhauser.Clear();
            cb_carusu.Text = "";


        }

        private void limpar8()
        {
            cb_buscauser.Text = "";
            txt_buscauser.Clear();

        }

        private void limpar9()
        {
            txt_clicod2.Clear();
            txt_loginuser2.Clear();
            txt_senhauser2.Clear();
            cb_catuser2.Text = "";

        }
        private void bt_limpar_Click(object sender, EventArgs e)
        {
            limpar7();
        }

        private void bt_limparcid3_Click(object sender, EventArgs e)
        {
            limpar9();
        }
    }
}
