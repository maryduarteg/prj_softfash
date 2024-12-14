using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace soft_code
{
    public partial class Telalogin : Form
    {
        public Telalogin()
        {
            InitializeComponent();
        }


        string cnsql = @"SERVER=localhost; DATABASE=softfash; UID=root; PASSWORD=''"; //string de conexão com o banco de dados

        private void acharlogin()
        {
            string sql = "SELECT user_login FROM usuarios ORDER BY user_login";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            
            conexao.Open();

            MySqlDataReader leia = comando.ExecuteReader();
            if (leia.HasRows)
            {
                while (leia.Read())
                {
                    cb_login.Items.Add(Convert.ToString(leia["user_login"]));
                }
            }


;       }

        private void acessar()
        {
            string login = cb_login.Text;
            string senha = txt_senha.Text;
            string sql = "SELECT user_login, user_senha FROM usuarios WHERE user_login= @login";
            MySqlConnection conexao = new MySqlConnection(cnsql);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.Add("login", MySqlDbType.VarChar).Value = login;
            conexao.Open();
            MySqlDataReader leia = comando.ExecuteReader();
            

            if (login == "")
            {
                MessageBox.Show("Login inválido. Selecione um login para continuar!", "Selecione um usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_login.Focus();
            }
            else
            {
                if (senha == "")
                {
                    MessageBox.Show("Senha não informada. Digite a senha para continuar!", "Informe a senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_senha.Focus();
                }
                else
                {
                    if (leia.Read())
                    {
                        if (Convert.ToString(leia["user_senha"]) == senha)
                        {
                            MessageBox.Show("Seja bem-vindo ao sistema, " + login + "!", "Olá :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Menu menu = new Menu(cnsql);
                            menu.Show();
                            cb_login.Text = "";
                            txt_senha.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta. Informe corretamente a senha.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cb_login.Text = "";
                            txt_senha.Clear();
                            txt_senha.Focus();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Login inválido. Informe corretamente o login.", "Login inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cb_login.Text = "";
                        txt_senha.Clear();
                        txt_senha.Focus();
                    }

                }
                

            }

        }


        private void Home_Load(object sender, EventArgs e)
        {
            acharlogin();
        }

      

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            acessar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
