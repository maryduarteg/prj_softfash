
namespace soft_code
{
    partial class f_devolverprod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_devolverprod));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.prod_pesquisar = new System.Windows.Forms.TabPage();
            this.dt_devprod = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codvenda = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_voltarcprod = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.prod_devolver = new System.Windows.Forms.TabPage();
            this.txt_codprod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_prodnome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_vendaid = new System.Windows.Forms.TextBox();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.bt_excluircli = new System.Windows.Forms.Button();
            this.txt_itencod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.prod_pesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_devprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.prod_devolver.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.prod_pesquisar);
            this.tabControl1.Controls.Add(this.prod_devolver);
            this.tabControl1.Location = new System.Drawing.Point(12, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1122, 574);
            this.tabControl1.TabIndex = 5;
            // 
            // prod_pesquisar
            // 
            this.prod_pesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.prod_pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prod_pesquisar.Controls.Add(this.dt_devprod);
            this.prod_pesquisar.Controls.Add(this.dataGridView1);
            this.prod_pesquisar.Controls.Add(this.label1);
            this.prod_pesquisar.Controls.Add(this.txt_codvenda);
            this.prod_pesquisar.Controls.Add(this.button4);
            this.prod_pesquisar.Controls.Add(this.textBox1);
            this.prod_pesquisar.Controls.Add(this.cb_cliente);
            this.prod_pesquisar.Controls.Add(this.label2);
            this.prod_pesquisar.Controls.Add(this.bt_voltarcprod);
            this.prod_pesquisar.Controls.Add(this.bt_limpar);
            this.prod_pesquisar.Controls.Add(this.button1);
            this.prod_pesquisar.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_pesquisar.ForeColor = System.Drawing.Color.Transparent;
            this.prod_pesquisar.Location = new System.Drawing.Point(4, 22);
            this.prod_pesquisar.Name = "prod_pesquisar";
            this.prod_pesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.prod_pesquisar.Size = new System.Drawing.Size(1114, 548);
            this.prod_pesquisar.TabIndex = 0;
            this.prod_pesquisar.Text = "Pesquisar Produtos";
            // 
            // dt_devprod
            // 
            this.dt_devprod.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dt_devprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_devprod.Location = new System.Drawing.Point(500, 286);
            this.dt_devprod.Name = "dt_devprod";
            this.dt_devprod.Size = new System.Drawing.Size(592, 250);
            this.dt_devprod.TabIndex = 51;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(500, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 250);
            this.dataGridView1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Código de venda:";
            // 
            // txt_codvenda
            // 
            this.txt_codvenda.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codvenda.Location = new System.Drawing.Point(217, 104);
            this.txt_codvenda.Name = "txt_codvenda";
            this.txt_codvenda.Size = new System.Drawing.Size(117, 25);
            this.txt_codvenda.TabIndex = 47;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(349, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 35);
            this.button4.TabIndex = 41;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(217, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 25);
            this.textBox1.TabIndex = 39;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cb_cliente
            // 
            this.cb_cliente.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Items.AddRange(new object[] {
            "Nome",
            "Estação",
            "Tamanho",
            "Cor"});
            this.cb_cliente.Location = new System.Drawing.Point(349, 32);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(108, 28);
            this.cb_cliente.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Selecione o cliente:";
            // 
            // bt_voltarcprod
            // 
            this.bt_voltarcprod.BackColor = System.Drawing.Color.DimGray;
            this.bt_voltarcprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltarcprod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltarcprod.Location = new System.Drawing.Point(83, 230);
            this.bt_voltarcprod.Name = "bt_voltarcprod";
            this.bt_voltarcprod.Size = new System.Drawing.Size(108, 38);
            this.bt_voltarcprod.TabIndex = 35;
            this.bt_voltarcprod.Text = "Voltar";
            this.bt_voltarcprod.UseVisualStyleBackColor = false;
            this.bt_voltarcprod.Click += new System.EventHandler(this.bt_voltarcprod_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.DarkBlue;
            this.bt_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limpar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.Location = new System.Drawing.Point(217, 230);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(108, 38);
            this.bt_limpar.TabIndex = 9;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1112, 548);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // prod_devolver
            // 
            this.prod_devolver.Controls.Add(this.txt_codprod);
            this.prod_devolver.Controls.Add(this.label3);
            this.prod_devolver.Controls.Add(this.txt_prodnome);
            this.prod_devolver.Controls.Add(this.label14);
            this.prod_devolver.Controls.Add(this.txt_subtotal);
            this.prod_devolver.Controls.Add(this.txt_vendaid);
            this.prod_devolver.Controls.Add(this.txt_quant);
            this.prod_devolver.Controls.Add(this.label19);
            this.prod_devolver.Controls.Add(this.label17);
            this.prod_devolver.Controls.Add(this.label16);
            this.prod_devolver.Controls.Add(this.txt_preco);
            this.prod_devolver.Controls.Add(this.bt_excluircli);
            this.prod_devolver.Controls.Add(this.txt_itencod);
            this.prod_devolver.Controls.Add(this.label9);
            this.prod_devolver.Controls.Add(this.label7);
            this.prod_devolver.Controls.Add(this.button3);
            this.prod_devolver.Location = new System.Drawing.Point(4, 22);
            this.prod_devolver.Name = "prod_devolver";
            this.prod_devolver.Size = new System.Drawing.Size(1114, 548);
            this.prod_devolver.TabIndex = 2;
            this.prod_devolver.Text = "Devolver itens";
            this.prod_devolver.UseVisualStyleBackColor = true;
            // 
            // txt_codprod
            // 
            this.txt_codprod.Enabled = false;
            this.txt_codprod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codprod.Location = new System.Drawing.Point(470, 76);
            this.txt_codprod.Name = "txt_codprod";
            this.txt_codprod.Size = new System.Drawing.Size(66, 25);
            this.txt_codprod.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(309, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "CódigoProduto:";
            // 
            // txt_prodnome
            // 
            this.txt_prodnome.Enabled = false;
            this.txt_prodnome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prodnome.Location = new System.Drawing.Point(700, 77);
            this.txt_prodnome.Name = "txt_prodnome";
            this.txt_prodnome.Size = new System.Drawing.Size(165, 25);
            this.txt_prodnome.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(592, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 24);
            this.label14.TabIndex = 47;
            this.label14.Text = "Produto:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal.Location = new System.Drawing.Point(483, 199);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(123, 25);
            this.txt_subtotal.TabIndex = 44;
            // 
            // txt_vendaid
            // 
            this.txt_vendaid.Enabled = false;
            this.txt_vendaid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vendaid.Location = new System.Drawing.Point(313, 136);
            this.txt_vendaid.Name = "txt_vendaid";
            this.txt_vendaid.Size = new System.Drawing.Size(145, 25);
            this.txt_vendaid.TabIndex = 42;
            // 
            // txt_quant
            // 
            this.txt_quant.Enabled = false;
            this.txt_quant.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quant.Location = new System.Drawing.Point(663, 138);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(66, 25);
            this.txt_quant.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(167, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 24);
            this.label19.TabIndex = 39;
            this.label19.Text = "CódigoVenda:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(385, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 24);
            this.label17.TabIndex = 37;
            this.label17.Text = "Subtotal:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(534, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 24);
            this.label16.TabIndex = 36;
            this.label16.Text = "Quantidade:";
            // 
            // txt_preco
            // 
            this.txt_preco.Enabled = false;
            this.txt_preco.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco.Location = new System.Drawing.Point(118, 199);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(111, 25);
            this.txt_preco.TabIndex = 35;
            // 
            // bt_excluircli
            // 
            this.bt_excluircli.BackColor = System.Drawing.Color.Red;
            this.bt_excluircli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluircli.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluircli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_excluircli.Location = new System.Drawing.Point(640, 278);
            this.bt_excluircli.Name = "bt_excluircli";
            this.bt_excluircli.Size = new System.Drawing.Size(108, 38);
            this.bt_excluircli.TabIndex = 32;
            this.bt_excluircli.Text = "Devolver";
            this.bt_excluircli.UseVisualStyleBackColor = false;
            this.bt_excluircli.Click += new System.EventHandler(this.bt_excluircli_Click);
            // 
            // txt_itencod
            // 
            this.txt_itencod.Enabled = false;
            this.txt_itencod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itencod.Location = new System.Drawing.Point(194, 77);
            this.txt_itencod.Name = "txt_itencod";
            this.txt_itencod.Size = new System.Drawing.Size(66, 25);
            this.txt_itencod.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(35, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Preço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(66, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "CódigoItem:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1114, 548);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // f_devolverprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1131, 591);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(210, 78);
            this.Name = "f_devolverprod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "f_devolverprod";
            this.Load += new System.EventHandler(this.f_devolverprod_Load);
            this.tabControl1.ResumeLayout(false);
            this.prod_pesquisar.ResumeLayout(false);
            this.prod_pesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_devprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.prod_devolver.ResumeLayout(false);
            this.prod_devolver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage prod_pesquisar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage prod_devolver;
        private System.Windows.Forms.TextBox txt_prodnome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_vendaid;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Button bt_excluircli;
        private System.Windows.Forms.TextBox txt_itencod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_voltarcprod;
        private System.Windows.Forms.TextBox txt_codvenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dt_devprod;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}