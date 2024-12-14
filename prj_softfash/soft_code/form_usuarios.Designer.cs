
namespace soft_code
{
    partial class form_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_usuarios));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.user_cadastrar = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_carusu = new System.Windows.Forms.ComboBox();
            this.bt_voltarcusu = new System.Windows.Forms.Button();
            this.txt_senhauser = new System.Windows.Forms.TextBox();
            this.txt_loginuser = new System.Windows.Forms.TextBox();
            this.txt_coduser = new System.Windows.Forms.TextBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.user_consultar = new System.Windows.Forms.TabPage();
            this.bt_buscarcli = new System.Windows.Forms.Button();
            this.bt_limparcli = new System.Windows.Forms.Button();
            this.grid_buscauser = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_buscauser = new System.Windows.Forms.TextBox();
            this.cb_buscauser = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.user_altexclu = new System.Windows.Forms.TabPage();
            this.txt_senhauser2 = new System.Windows.Forms.TextBox();
            this.txt_loginuser2 = new System.Windows.Forms.TextBox();
            this.cb_catuser2 = new System.Windows.Forms.ComboBox();
            this.bt_excluircli = new System.Windows.Forms.Button();
            this.bt_alterarcid = new System.Windows.Forms.Button();
            this.bt_limparcid3 = new System.Windows.Forms.Button();
            this.txt_clicod2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.user_cadastrar.SuspendLayout();
            this.user_consultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_buscauser)).BeginInit();
            this.user_altexclu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.user_cadastrar);
            this.tabControl1.Controls.Add(this.user_consultar);
            this.tabControl1.Controls.Add(this.user_altexclu);
            this.tabControl1.Location = new System.Drawing.Point(12, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 500);
            this.tabControl1.TabIndex = 3;
            // 
            // user_cadastrar
            // 
            this.user_cadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.user_cadastrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_cadastrar.Controls.Add(this.label4);
            this.user_cadastrar.Controls.Add(this.cb_carusu);
            this.user_cadastrar.Controls.Add(this.bt_voltarcusu);
            this.user_cadastrar.Controls.Add(this.txt_senhauser);
            this.user_cadastrar.Controls.Add(this.txt_loginuser);
            this.user_cadastrar.Controls.Add(this.txt_coduser);
            this.user_cadastrar.Controls.Add(this.bt_cadastrar);
            this.user_cadastrar.Controls.Add(this.bt_limpar);
            this.user_cadastrar.Controls.Add(this.label3);
            this.user_cadastrar.Controls.Add(this.label2);
            this.user_cadastrar.Controls.Add(this.label1);
            this.user_cadastrar.Controls.Add(this.button1);
            this.user_cadastrar.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_cadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.user_cadastrar.Location = new System.Drawing.Point(4, 22);
            this.user_cadastrar.Name = "user_cadastrar";
            this.user_cadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.user_cadastrar.Size = new System.Drawing.Size(882, 474);
            this.user_cadastrar.TabIndex = 0;
            this.user_cadastrar.Text = "Cadastrar Usuários";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(283, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cargo:";
            // 
            // cb_carusu
            // 
            this.cb_carusu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_carusu.FormattingEnabled = true;
            this.cb_carusu.Items.AddRange(new object[] {
            "Funcionário",
            "Gerente"});
            this.cb_carusu.Location = new System.Drawing.Point(356, 101);
            this.cb_carusu.Name = "cb_carusu";
            this.cb_carusu.Size = new System.Drawing.Size(168, 28);
            this.cb_carusu.TabIndex = 22;
            // 
            // bt_voltarcusu
            // 
            this.bt_voltarcusu.BackColor = System.Drawing.Color.DimGray;
            this.bt_voltarcusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltarcusu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltarcusu.Location = new System.Drawing.Point(542, 423);
            this.bt_voltarcusu.Name = "bt_voltarcusu";
            this.bt_voltarcusu.Size = new System.Drawing.Size(108, 38);
            this.bt_voltarcusu.TabIndex = 21;
            this.bt_voltarcusu.Text = "Voltar";
            this.bt_voltarcusu.UseVisualStyleBackColor = false;
            this.bt_voltarcusu.Click += new System.EventHandler(this.bt_voltarcusu_Click);
            // 
            // txt_senhauser
            // 
            this.txt_senhauser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senhauser.Location = new System.Drawing.Point(658, 31);
            this.txt_senhauser.Name = "txt_senhauser";
            this.txt_senhauser.Size = new System.Drawing.Size(168, 25);
            this.txt_senhauser.TabIndex = 20;
            // 
            // txt_loginuser
            // 
            this.txt_loginuser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginuser.Location = new System.Drawing.Point(356, 34);
            this.txt_loginuser.Name = "txt_loginuser";
            this.txt_loginuser.Size = new System.Drawing.Size(168, 25);
            this.txt_loginuser.TabIndex = 19;
            // 
            // txt_coduser
            // 
            this.txt_coduser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coduser.Location = new System.Drawing.Point(126, 34);
            this.txt_coduser.Name = "txt_coduser";
            this.txt_coduser.Size = new System.Drawing.Size(73, 25);
            this.txt_coduser.TabIndex = 6;
            this.txt_coduser.MouseLeave += new System.EventHandler(this.txt_coduser_MouseLeave);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.Location = new System.Drawing.Point(764, 423);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(108, 38);
            this.bt_cadastrar.TabIndex = 10;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.DarkBlue;
            this.bt_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limpar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.Location = new System.Drawing.Point(653, 423);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(108, 38);
            this.bt_limpar.TabIndex = 9;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(283, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(576, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
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
            this.button1.Size = new System.Drawing.Size(882, 474);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // user_consultar
            // 
            this.user_consultar.Controls.Add(this.bt_buscarcli);
            this.user_consultar.Controls.Add(this.bt_limparcli);
            this.user_consultar.Controls.Add(this.grid_buscauser);
            this.user_consultar.Controls.Add(this.label6);
            this.user_consultar.Controls.Add(this.txt_buscauser);
            this.user_consultar.Controls.Add(this.cb_buscauser);
            this.user_consultar.Controls.Add(this.label5);
            this.user_consultar.Controls.Add(this.button2);
            this.user_consultar.Location = new System.Drawing.Point(4, 22);
            this.user_consultar.Name = "user_consultar";
            this.user_consultar.Padding = new System.Windows.Forms.Padding(3);
            this.user_consultar.Size = new System.Drawing.Size(882, 474);
            this.user_consultar.TabIndex = 1;
            this.user_consultar.Text = "Consultar Usuários";
            this.user_consultar.UseVisualStyleBackColor = true;
            // 
            // bt_buscarcli
            // 
            this.bt_buscarcli.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_buscarcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscarcli.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscarcli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_buscarcli.Location = new System.Drawing.Point(739, 43);
            this.bt_buscarcli.Name = "bt_buscarcli";
            this.bt_buscarcli.Size = new System.Drawing.Size(108, 38);
            this.bt_buscarcli.TabIndex = 11;
            this.bt_buscarcli.Text = "Buscar";
            this.bt_buscarcli.UseVisualStyleBackColor = false;
            this.bt_buscarcli.Click += new System.EventHandler(this.bt_buscarcli_Click);
            // 
            // bt_limparcli
            // 
            this.bt_limparcli.BackColor = System.Drawing.Color.DarkBlue;
            this.bt_limparcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limparcli.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limparcli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_limparcli.Location = new System.Drawing.Point(54, 100);
            this.bt_limparcli.Name = "bt_limparcli";
            this.bt_limparcli.Size = new System.Drawing.Size(108, 38);
            this.bt_limparcli.TabIndex = 10;
            this.bt_limparcli.Text = "Limpar";
            this.bt_limparcli.UseVisualStyleBackColor = false;
            this.bt_limparcli.Click += new System.EventHandler(this.bt_limparcli_Click);
            // 
            // grid_buscauser
            // 
            this.grid_buscauser.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grid_buscauser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_buscauser.Location = new System.Drawing.Point(54, 163);
            this.grid_buscauser.Name = "grid_buscauser";
            this.grid_buscauser.Size = new System.Drawing.Size(691, 266);
            this.grid_buscauser.TabIndex = 9;
            this.grid_buscauser.DoubleClick += new System.EventHandler(this.grid_buscauser_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(365, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Digite sua busca:";
            // 
            // txt_buscauser
            // 
            this.txt_buscauser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscauser.Location = new System.Drawing.Point(543, 52);
            this.txt_buscauser.Name = "txt_buscauser";
            this.txt_buscauser.Size = new System.Drawing.Size(168, 25);
            this.txt_buscauser.TabIndex = 7;
            this.txt_buscauser.TextChanged += new System.EventHandler(this.txt_buscauser_TextChanged);
            // 
            // cb_buscauser
            // 
            this.cb_buscauser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_buscauser.FormattingEnabled = true;
            this.cb_buscauser.Items.AddRange(new object[] {
            "Login",
            "Cargo"});
            this.cb_buscauser.Location = new System.Drawing.Point(174, 56);
            this.cb_buscauser.Name = "cb_buscauser";
            this.cb_buscauser.Size = new System.Drawing.Size(168, 21);
            this.cb_buscauser.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(50, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Buscar por:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(1, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(882, 474);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // user_altexclu
            // 
            this.user_altexclu.Controls.Add(this.txt_senhauser2);
            this.user_altexclu.Controls.Add(this.txt_loginuser2);
            this.user_altexclu.Controls.Add(this.cb_catuser2);
            this.user_altexclu.Controls.Add(this.bt_excluircli);
            this.user_altexclu.Controls.Add(this.bt_alterarcid);
            this.user_altexclu.Controls.Add(this.bt_limparcid3);
            this.user_altexclu.Controls.Add(this.txt_clicod2);
            this.user_altexclu.Controls.Add(this.label10);
            this.user_altexclu.Controls.Add(this.label9);
            this.user_altexclu.Controls.Add(this.label8);
            this.user_altexclu.Controls.Add(this.label7);
            this.user_altexclu.Controls.Add(this.button3);
            this.user_altexclu.Location = new System.Drawing.Point(4, 22);
            this.user_altexclu.Name = "user_altexclu";
            this.user_altexclu.Size = new System.Drawing.Size(882, 474);
            this.user_altexclu.TabIndex = 2;
            this.user_altexclu.Text = "Alterar ou Excluir Usuários";
            this.user_altexclu.UseVisualStyleBackColor = true;
            // 
            // txt_senhauser2
            // 
            this.txt_senhauser2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senhauser2.Location = new System.Drawing.Point(680, 33);
            this.txt_senhauser2.Name = "txt_senhauser2";
            this.txt_senhauser2.Size = new System.Drawing.Size(168, 25);
            this.txt_senhauser2.TabIndex = 35;
            // 
            // txt_loginuser2
            // 
            this.txt_loginuser2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginuser2.Location = new System.Drawing.Point(346, 32);
            this.txt_loginuser2.Name = "txt_loginuser2";
            this.txt_loginuser2.Size = new System.Drawing.Size(196, 25);
            this.txt_loginuser2.TabIndex = 34;
            // 
            // cb_catuser2
            // 
            this.cb_catuser2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_catuser2.FormattingEnabled = true;
            this.cb_catuser2.Location = new System.Drawing.Point(404, 104);
            this.cb_catuser2.Name = "cb_catuser2";
            this.cb_catuser2.Size = new System.Drawing.Size(168, 26);
            this.cb_catuser2.TabIndex = 33;
            // 
            // bt_excluircli
            // 
            this.bt_excluircli.BackColor = System.Drawing.Color.Red;
            this.bt_excluircli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluircli.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluircli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_excluircli.Location = new System.Drawing.Point(540, 426);
            this.bt_excluircli.Name = "bt_excluircli";
            this.bt_excluircli.Size = new System.Drawing.Size(108, 38);
            this.bt_excluircli.TabIndex = 32;
            this.bt_excluircli.Text = "Excluir";
            this.bt_excluircli.UseVisualStyleBackColor = false;
            this.bt_excluircli.Click += new System.EventHandler(this.bt_excluircli_Click);
            // 
            // bt_alterarcid
            // 
            this.bt_alterarcid.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_alterarcid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alterarcid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterarcid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_alterarcid.Location = new System.Drawing.Point(763, 426);
            this.bt_alterarcid.Name = "bt_alterarcid";
            this.bt_alterarcid.Size = new System.Drawing.Size(108, 38);
            this.bt_alterarcid.TabIndex = 31;
            this.bt_alterarcid.Text = "Alterar";
            this.bt_alterarcid.UseVisualStyleBackColor = false;
            this.bt_alterarcid.Click += new System.EventHandler(this.bt_alterarcid_Click);
            // 
            // bt_limparcid3
            // 
            this.bt_limparcid3.BackColor = System.Drawing.Color.DarkBlue;
            this.bt_limparcid3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limparcid3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limparcid3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_limparcid3.Location = new System.Drawing.Point(652, 426);
            this.bt_limparcid3.Name = "bt_limparcid3";
            this.bt_limparcid3.Size = new System.Drawing.Size(108, 38);
            this.bt_limparcid3.TabIndex = 30;
            this.bt_limparcid3.Text = "Limpar";
            this.bt_limparcid3.UseVisualStyleBackColor = false;
            this.bt_limparcid3.Click += new System.EventHandler(this.bt_limparcid3_Click);
            // 
            // txt_clicod2
            // 
            this.txt_clicod2.Enabled = false;
            this.txt_clicod2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clicod2.Location = new System.Drawing.Point(125, 35);
            this.txt_clicod2.Name = "txt_clicod2";
            this.txt_clicod2.Size = new System.Drawing.Size(90, 25);
            this.txt_clicod2.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(290, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "Categoria:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(598, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Senha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(273, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Login:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(37, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Código:";
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
            this.button3.Size = new System.Drawing.Size(882, 474);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // form_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(915, 540);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(235, 78);
            this.Name = "form_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "form_usuarios";
            this.Load += new System.EventHandler(this.form_usuarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.user_cadastrar.ResumeLayout(false);
            this.user_cadastrar.PerformLayout();
            this.user_consultar.ResumeLayout(false);
            this.user_consultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_buscauser)).EndInit();
            this.user_altexclu.ResumeLayout(false);
            this.user_altexclu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage user_cadastrar;
        private System.Windows.Forms.TextBox txt_senhauser;
        private System.Windows.Forms.TextBox txt_loginuser;
        private System.Windows.Forms.TextBox txt_coduser;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage user_consultar;
        private System.Windows.Forms.Button bt_buscarcli;
        private System.Windows.Forms.Button bt_limparcli;
        private System.Windows.Forms.DataGridView grid_buscauser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_buscauser;
        private System.Windows.Forms.ComboBox cb_buscauser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage user_altexclu;
        private System.Windows.Forms.TextBox txt_senhauser2;
        private System.Windows.Forms.TextBox txt_loginuser2;
        private System.Windows.Forms.ComboBox cb_catuser2;
        private System.Windows.Forms.Button bt_excluircli;
        private System.Windows.Forms.Button bt_alterarcid;
        private System.Windows.Forms.Button bt_limparcid3;
        private System.Windows.Forms.TextBox txt_clicod2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_voltarcusu;
        private System.Windows.Forms.ComboBox cb_carusu;
        private System.Windows.Forms.Label label4;
    }
}