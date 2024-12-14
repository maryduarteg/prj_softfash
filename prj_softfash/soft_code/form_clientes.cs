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
    public partial class form_clientes : Form
    {
        string cnsql;
        public form_clientes(string cn)
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
            cb_clicid.DisplayMember = "cid_nome";
            cb_clicid.ValueMember = "cid_id";

            cb_clicid.DataSource = dt;
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
            cb_clicidade2.DisplayMember = "cid_nome";
            cb_clicidade2.ValueMember = "cid_id";

            cb_clicidade2.DataSource = dt;
        }
        private void preenchergridcli()
        {
            string sql;
            sql = "SELECT cli_id AS Código, cli_cpf AS CPF, cli_rg AS RG, cli_nome AS Nome, cli_endereco AS Endereço, " +
            "cid_id AS Cidade, cli_telefone AS Telefone, cli_email AS Email, cli_datacad AS Cadastro, cli_datanasci AS Nascimento FROM clientes";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();

            MySqlDataReader tabela;
            tabela = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(tabela);
            grid_buscaclientes.DataSource = dt;
        }

        private void cid_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void form_clientes_Load(object sender, EventArgs e)
        {
            preenchercombo();
            preenchergridcli();
            preenchercombo2();

            this.grid_buscaclientes.DefaultCellStyle.Font = new Font("Arial", 12);
            this.grid_buscaclientes.DefaultCellStyle.ForeColor = Color.Black;
            this.grid_buscaclientes.DefaultCellStyle.BackColor = Color.White;

            this.grid_buscaclientes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void bt_voltarcadcli_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
           verificacod();
        }

        private void limpar1()
        {
            txt_clicod.Clear();
            mktxt_cpfcli.Clear();
            mktxt_clirg.Clear();
            txt_clinome.Clear();
            mktxt_clitel.Clear();
            cb_clicid.Text = "";
            txt_cliendereco.Clear();
            mktb_clinasc.Clear();
            tb_email.Clear();
            mktxt_clidata.Clear();
        }

        private void limpar2()
        {
            cb_clibusca.Text = "";
            txt_buscacli.Clear();

        }

        private void limpar3()
        {
            txt_clicod2.Clear();
            mktxt_clicpf2.Clear();
            mktxt_clirg2.Clear();
            txt_clinome2.Clear();
            txt_cliendereco2.Clear();
            cb_clicidade2.Text = "";
            mktxt_clitelefone2.Clear();
            txt_cliemail2.Clear();
            mktxt_datacadcli2.Clear();
            mk_nasc.Clear();

        }
        private void verificacod()
        {
            string sql = "SELECT * FROM clientes WHERE cli_id = @cli_id";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cli_id", MySqlDbType.Int32).Value = Convert.ToInt32(txt_clicod.Text);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("Código já existente: " + txt_clicod.Text);
                txt_clicod.Clear();
                txt_clicod.Focus();

            }
            else
            {
                verificacpf();
            }
            conexao.Close();
        }
        private void verificarg()
        {
            string rg = mktxt_clirg.Text;
            string sql = "SELECT * FROM clientes WHERE cli_rg  = @cli_rg";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cli_rg", rg);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("RG já existente: " + mktxt_clirg.Text);
                mktxt_clirg.Clear();
                mktxt_clirg.Focus();

            }
            else
            {
                cadastrar();
            }
            conexao.Close();
        }
        private void verificacpf()
        {
            string cpf = mktxt_cpfcli.Text;
            string sql = "SELECT * FROM clientes WHERE cli_cpf = @cli_cpf";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cli_cpf", cpf);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("CPF já existente: " + mktxt_cpfcli.Text);
                mktxt_cpfcli.Clear();
                mktxt_cpfcli.Focus();

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
            string nome, cpf, rg, telefone, endereco, email;
            DateTime dnascimento, dcadastro;
            cod = Convert.ToInt32(txt_clicod.Text);
            nome = txt_clinome.Text;
            cidade = Convert.ToInt32(cb_clicid.SelectedValue);
            cpf = mktxt_cpfcli.Text;
            rg = mktxt_clirg.Text;
            endereco = txt_cliendereco.Text;
            telefone = mktxt_clitel.Text;
            email = tb_email.Text;
            dnascimento = Convert.ToDateTime(mktb_clinasc.Text);
            dcadastro = Convert.ToDateTime(mktxt_clidata.Text);

            if (nome == String.Empty || cb_clicid.Text == "" || cpf == String.Empty || txt_clicod.Text == String.Empty || endereco == String.Empty || telefone == String.Empty || email == String.Empty || rg == String.Empty || mktb_clinasc.Text == String.Empty || mktxt_clidata.Text == String.Empty)
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //comandin de texto - M
            else
            {
                try
                {
                    string sql = "";
                    sql = "INSERT INTO clientes VALUES(@cod, @cpf, @rg, @nome, @endereco, @cidade, @telefone, @email, @dcadastro, @dnascimento)";


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
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@dcadastro", dcadastro);
                    comando.Parameters.AddWithValue("@dnascimento", dnascimento);
        
                    comando.ExecuteNonQuery();  //executar -M

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                    preenchergridcli();
                    limpar1();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }

        }

        private void bt_buscarcli_Click(object sender, EventArgs e)
        {
            pesquisardados();
        }
        private void pesquisardados()
        {
            string sql = "SELECT cli_id AS Código, cli_cpf AS CPF, cli_rg AS RG, cli_nome AS Nome, cli_endereco AS Endereço, " +
            "cid_id AS Cidade, cli_telefone AS Telefone, cli_email AS Email, cli_datacad AS Cadastro, cli_datanasci AS Nascimento FROM clientes"; //criar sqls
            MySqlConnection conexao = new MySqlConnection(cnsql); //criar conexão
            MySqlCommand comando = new MySqlCommand(sql, conexao); // criar comando e ligar com o sql e conexão
            conexao.Open(); //abrir conexão

            if (cb_clibusca.Text == "Nome")
            {
                sql = sql + " WHERE cli_nome LIKE @nome";
                comando.Parameters.AddWithValue("@nome", txt_buscacli.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                   //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_clibusca.Text == "CPF")
            {
                sql = sql + " WHERE cli_cpf LIKE @cpf";
                comando.Parameters.AddWithValue("@cpf", txt_buscacli.Text + "%"); //Aqui tem o "LIKE" e "%" porque é texto, aí pode certin pesquisar palavras
                                                                                  //que contenham algum texto da caixa de pesquisa, mesmo que não seja igual
                comando.CommandText = sql;
            }
            else if (cb_clibusca.Text == "")
            {
                comando.CommandText = sql;
            }
            MySqlDataReader leia = comando.ExecuteReader(); //lcriar a variável para ler o comando e executar ele 
            DataTable tabela = new DataTable(); //criar uma tabela para jogar os dados
            tabela.Load(leia); //quando a tabela carregar podemos jogar os dads
            grid_buscaclientes.DataSource = tabela; //a grid do layout receber os dados
            conexao.Close();
        }
        private void enviardadosparaoutroform()
        {
            txt_clicod2.Text = Convert.ToString(grid_buscaclientes.CurrentRow.Cells[0].Value); // A textbox da user_altexclu receber os dados da grid de busca
            mktxt_clicpf2.Text = Convert.ToString(grid_buscaclientes.CurrentRow.Cells[1].Value);
            mktxt_clirg2.Text = Convert.ToString(grid_buscaclientes.CurrentRow.Cells[2].Value);
            txt_clinome2.Text = Convert.ToString(grid_buscaclientes.CurrentRow.Cells[3].Value);
            txt_cliendereco2.Text = Convert.ToString(grid_buscaclientes.CurrentRow.Cells[4].Value);
            cb_clicidade2.Text = Convert.ToString(grid_buscaclientes.CurrentRow.Cells[5].Value);
            mktxt_clitelefone2.Text = Convert.ToString(grid_buscaclientes.CurrentRow.Cells[6].Value);
            txt_cliemail2.Text = Convert.ToString(grid_buscaclientes.CurrentRow.Cells[7].Value);
            mktxt_datacadcli2.Text = Convert.ToString(grid_buscaclientes.CurrentRow.Cells[8].Value);
            mk_nasc.Text = Convert.ToString(grid_buscaclientes.CurrentRow.Cells[9].Value);
            tabControl1.SelectedTab = cli_altexclu; //fazer com que os dados vão para lá, a page certinha 
        }

        private void grid_buscaclientes_DoubleClick(object sender, EventArgs e)
        {
            enviardadosparaoutroform();
        }

        private void alterar()
        {
            int cod, cidade;
            string nome, cpf, rg, telefone, endereco, email;
            DateTime dnascimento, dcadastro;
            cod = Convert.ToInt32(txt_clicod2.Text);
            nome = txt_clinome2.Text;
            cidade = Convert.ToInt32(cb_clicidade2.SelectedValue);
            cpf = mktxt_clicpf2.Text;
            rg = mktxt_clirg2.Text;
            endereco = txt_cliendereco2.Text;
            telefone = mktxt_clitelefone2.Text;
            email = txt_cliemail2.Text;
            dnascimento = Convert.ToDateTime(mk_nasc.Text);
            dcadastro = Convert.ToDateTime(mktxt_datacadcli2.Text);

            if (nome == String.Empty || cb_clicid.Text == "" || cpf == String.Empty || txt_clicod2.Text == String.Empty || endereco == String.Empty || telefone == String.Empty || email == String.Empty || rg == String.Empty || mk_nasc.Text == String.Empty || mktxt_datacadcli2.Text == String.Empty)
            {
                MessageBox.Show("Certifique de preencher todos os campos!", "Campo não preenchido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //comandin de texto - M
            else
            {
                try
                {
                    string sql = "";
                    sql = "UPDATE clientes SET cli_cpf = @cpf, cli_rg = @rg, cli_nome = @nome,cli_endereco = @endereco, cid_id = @cidade, " +
                        "cli_telefone = @telefone, cli_email = @email, cli_datacad = @dcadastro, cli_datanasci = @dnascimento WHERE cli_id = @cod  ";


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
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@dcadastro", dcadastro);
                    comando.Parameters.AddWithValue("@dnascimento", dnascimento);

                    comando.ExecuteNonQuery();  //executar -M

                    MessageBox.Show("Dados alterados com sucesso!");
                    preenchergridcli();
                    limpar3();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao alterar dados!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw ex;
                }
            }
        }
        private void verificarg2()
        {
            string rg = mktxt_clicpf2.Text;
            string sql = "SELECT * FROM clientes WHERE cli_rg  = @cli_rg";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cli_rg", rg);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("RG já existente: " + mktxt_clicpf2.Text);
                mktxt_clicpf2.Clear();
                mktxt_clicpf2.Focus();

            }
            else
            {
                alterar();
            }
            conexao.Close();
        }
        private void verificacpf2()
        {
            string cpf = mktxt_clirg2.Text;
            string sql = "SELECT * FROM clientes WHERE cli_cpf = @cli_cpf";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cli_cpf", cpf);
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                MessageBox.Show("CPF já existente: " + mktxt_clirg2.Text);
                mktxt_clirg2.Clear();
                mktxt_clirg2.Focus();

            }
            else
            {
                verificarg2();
            }

            conexao.Close();

        }

        private void bt_alterarcid_Click(object sender, EventArgs e)
        {
            verificacpf2();
            preenchergridcli();
            limpar3();
        }

        private void mktxt_cpfcli_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
                sql = "DELETE FROM clientes WHERE cli_id = @cod";
                MySqlConnection conexao = new MySqlConnection(cnsql);
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();

                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@cod", cod);
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro excluído com sucesso!", "Cadastro deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                preenchergridcli();
                conexao.Close();
                limpar3();
            }

        }

        private void bt_excluircli_Click(object sender, EventArgs e)
        {
            excluircadastro();
        }

        private void grid_buscaclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
