using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace soft_code
{
    public partial class Menu : Form
    {


        string cnsql = ""; //criando o parametro para a entrada da conexão com o banco
        public Menu(string cn) //criando a permissão de entrada do banco
        {
            cnsql = cn; //utilizando a string de conexão com o banco
            InitializeComponent();
        }
       

        private void bt_home_Click(object sender, EventArgs e)
        {
            f_devolverprod prod = new f_devolverprod(cnsql);
            prod.Show();
        }

        private void bt_home_MouseMove(object sender, MouseEventArgs e)
        {
            bt_home.BackColor = Color.Crimson;
            bt_home.ForeColor = Color.White;
        }
        private void bt_home_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void bt_home_MouseLeave_1(object sender, EventArgs e)
        {
            bt_home.BackColor = Color.White;
            bt_home.ForeColor = Color.Crimson;
        }

        private void bt_cidade_MouseMove(object sender, MouseEventArgs e)
        {
            bt_cidade.BackColor = Color.Crimson;
            bt_cidade.ForeColor = Color.White;
        }

        private void bt_cidade_MouseLeave(object sender, EventArgs e)
        {
            bt_cidade.BackColor = Color.White;
            bt_cidade.ForeColor = Color.Crimson;
        }

        private void bt_vendas_MouseMove(object sender, MouseEventArgs e)
        {
            bt_vendas.BackColor = Color.Crimson;
            bt_vendas.ForeColor = Color.White;
        }

        private void bt_vendas_MouseLeave(object sender, EventArgs e)
        {
            bt_vendas.BackColor = Color.White;
            bt_vendas.ForeColor = Color.Crimson;
        }

        private void bt_promissorias_MouseMove(object sender, MouseEventArgs e)
        {
            bt_promissorias.BackColor = Color.Crimson;
            bt_promissorias.ForeColor = Color.White;
        }

        private void bt_promissorias_MouseLeave(object sender, EventArgs e)
        {
            bt_promissorias.BackColor = Color.White;
            bt_promissorias.ForeColor = Color.Crimson;
        }

        private void bt_clientes_MouseMove(object sender, MouseEventArgs e)
        {
            bt_clientes.BackColor = Color.Crimson;
            bt_clientes.ForeColor = Color.White;
        }

        private void bt_clientes_MouseLeave(object sender, EventArgs e)
        {
            bt_clientes.BackColor = Color.White;
            bt_clientes.ForeColor = Color.Crimson;
        }

        private void bt_produto_MouseMove(object sender, MouseEventArgs e)
        {
            bt_produto.BackColor = Color.Crimson;
            bt_produto.ForeColor = Color.White;
        }

        private void bt_produto_MouseLeave(object sender, EventArgs e)
        {
            bt_produto.BackColor = Color.White;
            bt_produto.ForeColor = Color.Crimson;
        }

        private void bt_estoque_MouseMove(object sender, MouseEventArgs e)
        {
            bt_estoque.BackColor = Color.Crimson;
            bt_estoque.ForeColor = Color.White;
        }

        private void bt_estoque_MouseLeave(object sender, EventArgs e)
        {
            bt_estoque.BackColor = Color.White;
            bt_estoque.ForeColor = Color.Crimson;
        }

        private void bt_fornecedor_MouseMove(object sender, MouseEventArgs e)
        {
            bt_fornecedor.BackColor = Color.Crimson;
            bt_fornecedor.ForeColor = Color.White;
        }

        private void bt_fornecedor_MouseLeave(object sender, EventArgs e)
        {
            bt_fornecedor.BackColor = Color.White;
            bt_fornecedor.ForeColor = Color.Crimson;
        }

        private void bt_usuario_MouseMove(object sender, MouseEventArgs e)
        {
            bt_usuario.BackColor = Color.Crimson;
            bt_usuario.ForeColor = Color.White;
        }

        private void bt_usuario_MouseLeave(object sender, EventArgs e)
        {
            bt_usuario.BackColor = Color.White;
            bt_usuario.ForeColor = Color.Crimson;
        }

        private void bt_funcionario_MouseMove(object sender, MouseEventArgs e)
        {
            bt_funcionario.BackColor = Color.Crimson;
            bt_funcionario.ForeColor = Color.White;
        }

        private void bt_funcionario_MouseLeave(object sender, EventArgs e)
        {
            bt_funcionario.BackColor = Color.White;
            bt_funcionario.ForeColor = Color.Crimson;
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            button10.BackColor = Color.Crimson;
            button10.ForeColor = Color.White;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.White;
            button10.ForeColor = Color.Crimson;
        }

        private void bt_cidade_Click(object sender, EventArgs e)
        {
            form_cidades cidade = new form_cidades(cnsql);
            cidade.Show();
        }

        private void bt_vendas_Click(object sender, EventArgs e)
        {
            form_vendas vendas = new form_vendas(cnsql);
            vendas.Show();
        }

        private void bt_promissorias_Click(object sender, EventArgs e)
        {
            form_promissorias prom = new form_promissorias(cnsql);
            prom.Show();
        }

        private void bt_clientes_Click(object sender, EventArgs e)
        {
            form_clientes cliente = new form_clientes(cnsql);
            cliente.Show();
        }

        private void bt_produto_Click(object sender, EventArgs e)
        {
            form_produtos produto = new form_produtos(cnsql);
            produto.Show();
        }

        private void bt_estoque_Click(object sender, EventArgs e)
        {
            form_estoque estoque = new form_estoque(cnsql);
            estoque.Show();
        }

        private void bt_fornecedor_Click(object sender, EventArgs e)
        {
            form_fornecedores fornecedor = new form_fornecedores(cnsql);
            fornecedor.Show();
        }

        private void bt_usuario_Click(object sender, EventArgs e)
        {
            form_usuarios usuarios = new form_usuarios(cnsql);
            usuarios.Show();
        }

        private void bt_funcionario_Click(object sender, EventArgs e)
        {
            Form_funcionarios funcionario = new Form_funcionarios(cnsql);
            funcionario.Show();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void im_fechar_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_maximizar_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_duplicar_Click(object sender, EventArgs e)
        {
        }

        private void bt_fechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_devolverprod_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_devolverprod_Move(object sender, EventArgs e)
        {
           
        }

        private void bt_devolverprod_Leave(object sender, EventArgs e)
        {
           
        }
    }

}
