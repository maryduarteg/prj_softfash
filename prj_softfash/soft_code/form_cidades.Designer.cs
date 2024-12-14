
namespace soft_code
{
    partial class form_cidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cidades));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cid_cadastrar = new System.Windows.Forms.TabPage();
            this.bt_voltarcid = new System.Windows.Forms.Button();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.tb_codibge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.cb_estados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_vtccid = new System.Windows.Forms.Button();
            this.cid_consultar = new System.Windows.Forms.TabPage();
            this.bt_buscarcid = new System.Windows.Forms.Button();
            this.bt_limparcid2 = new System.Windows.Forms.Button();
            this.grid_buscacidades = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_buscacid = new System.Windows.Forms.TextBox();
            this.cb_buscacid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cid_altexclu = new System.Windows.Forms.TabPage();
            this.txt_codibge2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_excluircid = new System.Windows.Forms.Button();
            this.bt_alterarcid = new System.Windows.Forms.Button();
            this.bt_limparcid3 = new System.Windows.Forms.Button();
            this.cb_estcid2 = new System.Windows.Forms.ComboBox();
            this.txt_nomecid2 = new System.Windows.Forms.TextBox();
            this.txt_codcid2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.cid_cadastrar.SuspendLayout();
            this.cid_consultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_buscacidades)).BeginInit();
            this.cid_altexclu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cid_cadastrar);
            this.tabControl1.Controls.Add(this.cid_consultar);
            this.tabControl1.Controls.Add(this.cid_altexclu);
            this.tabControl1.Location = new System.Drawing.Point(12, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 500);
            this.tabControl1.TabIndex = 1;
            // 
            // cid_cadastrar
            // 
            this.cid_cadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cid_cadastrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cid_cadastrar.Controls.Add(this.bt_voltarcid);
            this.cid_cadastrar.Controls.Add(this.tb_cod);
            this.cid_cadastrar.Controls.Add(this.txt_nome);
            this.cid_cadastrar.Controls.Add(this.tb_codibge);
            this.cid_cadastrar.Controls.Add(this.label11);
            this.cid_cadastrar.Controls.Add(this.bt_cadastrar);
            this.cid_cadastrar.Controls.Add(this.bt_limpar);
            this.cid_cadastrar.Controls.Add(this.cb_estados);
            this.cid_cadastrar.Controls.Add(this.label4);
            this.cid_cadastrar.Controls.Add(this.label2);
            this.cid_cadastrar.Controls.Add(this.label1);
            this.cid_cadastrar.Controls.Add(this.bt_vtccid);
            this.cid_cadastrar.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid_cadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.cid_cadastrar.Location = new System.Drawing.Point(4, 22);
            this.cid_cadastrar.Name = "cid_cadastrar";
            this.cid_cadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.cid_cadastrar.Size = new System.Drawing.Size(882, 474);
            this.cid_cadastrar.TabIndex = 0;
            this.cid_cadastrar.Text = "Cadastrar Cidades";
            // 
            // bt_voltarcid
            // 
            this.bt_voltarcid.BackColor = System.Drawing.Color.DimGray;
            this.bt_voltarcid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltarcid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltarcid.Location = new System.Drawing.Point(517, 420);
            this.bt_voltarcid.Name = "bt_voltarcid";
            this.bt_voltarcid.Size = new System.Drawing.Size(108, 38);
            this.bt_voltarcid.TabIndex = 14;
            this.bt_voltarcid.Text = "Voltar";
            this.bt_voltarcid.UseVisualStyleBackColor = false;
            this.bt_voltarcid.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_cod
            // 
            this.tb_cod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cod.Location = new System.Drawing.Point(145, 34);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(81, 25);
            this.tb_cod.TabIndex = 13;
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(156, 115);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(168, 25);
            this.txt_nome.TabIndex = 7;
            // 
            // tb_codibge
            // 
            this.tb_codibge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codibge.Location = new System.Drawing.Point(499, 33);
            this.tb_codibge.Name = "tb_codibge";
            this.tb_codibge.Size = new System.Drawing.Size(81, 25);
            this.tb_codibge.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(46, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Código:";
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.Location = new System.Drawing.Point(745, 420);
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
            this.bt_limpar.Location = new System.Drawing.Point(631, 420);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(108, 38);
            this.bt_limpar.TabIndex = 9;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // cb_estados
            // 
            this.cb_estados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_estados.FormattingEnabled = true;
            this.cb_estados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM ",
            "BA ",
            "CE",
            "DF ",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO",
            "",
            ""});
            this.cb_estados.Location = new System.Drawing.Point(531, 118);
            this.cb_estados.Name = "cb_estados";
            this.cb_estados.Size = new System.Drawing.Size(113, 21);
            this.cb_estados.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(440, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(80, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(326, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código do IBGE:";
            // 
            // bt_vtccid
            // 
            this.bt_vtccid.BackColor = System.Drawing.SystemColors.Window;
            this.bt_vtccid.Enabled = false;
            this.bt_vtccid.FlatAppearance.BorderSize = 4;
            this.bt_vtccid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_vtccid.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_vtccid.ForeColor = System.Drawing.Color.Crimson;
            this.bt_vtccid.Location = new System.Drawing.Point(-1, -1);
            this.bt_vtccid.Name = "bt_vtccid";
            this.bt_vtccid.Size = new System.Drawing.Size(882, 474);
            this.bt_vtccid.TabIndex = 0;
            this.bt_vtccid.UseVisualStyleBackColor = false;
            this.bt_vtccid.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cid_consultar
            // 
            this.cid_consultar.Controls.Add(this.bt_buscarcid);
            this.cid_consultar.Controls.Add(this.bt_limparcid2);
            this.cid_consultar.Controls.Add(this.grid_buscacidades);
            this.cid_consultar.Controls.Add(this.label6);
            this.cid_consultar.Controls.Add(this.txt_buscacid);
            this.cid_consultar.Controls.Add(this.cb_buscacid);
            this.cid_consultar.Controls.Add(this.label5);
            this.cid_consultar.Controls.Add(this.button2);
            this.cid_consultar.Location = new System.Drawing.Point(4, 22);
            this.cid_consultar.Name = "cid_consultar";
            this.cid_consultar.Padding = new System.Windows.Forms.Padding(3);
            this.cid_consultar.Size = new System.Drawing.Size(882, 474);
            this.cid_consultar.TabIndex = 1;
            this.cid_consultar.Text = "Consultar Cidades";
            this.cid_consultar.UseVisualStyleBackColor = true;
            // 
            // bt_buscarcid
            // 
            this.bt_buscarcid.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_buscarcid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscarcid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscarcid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_buscarcid.Location = new System.Drawing.Point(735, 43);
            this.bt_buscarcid.Name = "bt_buscarcid";
            this.bt_buscarcid.Size = new System.Drawing.Size(108, 38);
            this.bt_buscarcid.TabIndex = 11;
            this.bt_buscarcid.Text = "Buscar";
            this.bt_buscarcid.UseVisualStyleBackColor = false;
            this.bt_buscarcid.Click += new System.EventHandler(this.bt_limparcid_Click);
            // 
            // bt_limparcid2
            // 
            this.bt_limparcid2.BackColor = System.Drawing.Color.DarkBlue;
            this.bt_limparcid2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limparcid2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limparcid2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_limparcid2.Location = new System.Drawing.Point(54, 100);
            this.bt_limparcid2.Name = "bt_limparcid2";
            this.bt_limparcid2.Size = new System.Drawing.Size(108, 38);
            this.bt_limparcid2.TabIndex = 10;
            this.bt_limparcid2.Text = "Limpar";
            this.bt_limparcid2.UseVisualStyleBackColor = false;
            this.bt_limparcid2.Click += new System.EventHandler(this.bt_limparcid2_Click);
            // 
            // grid_buscacidades
            // 
            this.grid_buscacidades.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grid_buscacidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_buscacidades.Location = new System.Drawing.Point(54, 163);
            this.grid_buscacidades.Name = "grid_buscacidades";
            this.grid_buscacidades.Size = new System.Drawing.Size(691, 266);
            this.grid_buscacidades.TabIndex = 9;
            this.grid_buscacidades.DoubleClick += new System.EventHandler(this.grid_buscacidades_DoubleClick);
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
            // txt_buscacid
            // 
            this.txt_buscacid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscacid.Location = new System.Drawing.Point(543, 52);
            this.txt_buscacid.Name = "txt_buscacid";
            this.txt_buscacid.Size = new System.Drawing.Size(168, 25);
            this.txt_buscacid.TabIndex = 7;
            this.txt_buscacid.TextChanged += new System.EventHandler(this.txt_buscacid_TextChanged);
            // 
            // cb_buscacid
            // 
            this.cb_buscacid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_buscacid.FormattingEnabled = true;
            this.cb_buscacid.Items.AddRange(new object[] {
            "Nome",
            "Código",
            "Código IBGE",
            "Estado"});
            this.cb_buscacid.Location = new System.Drawing.Point(174, 56);
            this.cb_buscacid.Name = "cb_buscacid";
            this.cb_buscacid.Size = new System.Drawing.Size(168, 21);
            this.cb_buscacid.TabIndex = 6;
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
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(882, 474);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cid_altexclu
            // 
            this.cid_altexclu.Controls.Add(this.txt_codibge2);
            this.cid_altexclu.Controls.Add(this.label12);
            this.cid_altexclu.Controls.Add(this.bt_excluircid);
            this.cid_altexclu.Controls.Add(this.bt_alterarcid);
            this.cid_altexclu.Controls.Add(this.bt_limparcid3);
            this.cid_altexclu.Controls.Add(this.cb_estcid2);
            this.cid_altexclu.Controls.Add(this.txt_nomecid2);
            this.cid_altexclu.Controls.Add(this.txt_codcid2);
            this.cid_altexclu.Controls.Add(this.label10);
            this.cid_altexclu.Controls.Add(this.label9);
            this.cid_altexclu.Controls.Add(this.label7);
            this.cid_altexclu.Controls.Add(this.button3);
            this.cid_altexclu.Location = new System.Drawing.Point(4, 22);
            this.cid_altexclu.Name = "cid_altexclu";
            this.cid_altexclu.Size = new System.Drawing.Size(882, 474);
            this.cid_altexclu.TabIndex = 2;
            this.cid_altexclu.Text = "Alterar ou Excluir Cidades";
            this.cid_altexclu.UseVisualStyleBackColor = true;
            // 
            // txt_codibge2
            // 
            this.txt_codibge2.Enabled = false;
            this.txt_codibge2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codibge2.Location = new System.Drawing.Point(481, 33);
            this.txt_codibge2.Name = "txt_codibge2";
            this.txt_codibge2.Size = new System.Drawing.Size(114, 25);
            this.txt_codibge2.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(308, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 24);
            this.label12.TabIndex = 34;
            this.label12.Text = "Código do IBGE:";
            // 
            // bt_excluircid
            // 
            this.bt_excluircid.BackColor = System.Drawing.Color.Red;
            this.bt_excluircid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluircid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluircid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_excluircid.Location = new System.Drawing.Point(530, 418);
            this.bt_excluircid.Name = "bt_excluircid";
            this.bt_excluircid.Size = new System.Drawing.Size(108, 38);
            this.bt_excluircid.TabIndex = 33;
            this.bt_excluircid.Text = "Excluir";
            this.bt_excluircid.UseVisualStyleBackColor = false;
            this.bt_excluircid.Click += new System.EventHandler(this.bt_excluircid_Click);
            // 
            // bt_alterarcid
            // 
            this.bt_alterarcid.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_alterarcid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alterarcid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterarcid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_alterarcid.Location = new System.Drawing.Point(756, 418);
            this.bt_alterarcid.Name = "bt_alterarcid";
            this.bt_alterarcid.Size = new System.Drawing.Size(108, 38);
            this.bt_alterarcid.TabIndex = 12;
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
            this.bt_limparcid3.Location = new System.Drawing.Point(643, 418);
            this.bt_limparcid3.Name = "bt_limparcid3";
            this.bt_limparcid3.Size = new System.Drawing.Size(108, 38);
            this.bt_limparcid3.TabIndex = 11;
            this.bt_limparcid3.Text = "Limpar";
            this.bt_limparcid3.UseVisualStyleBackColor = false;
            this.bt_limparcid3.Click += new System.EventHandler(this.bt_limparcid3_Click);
            // 
            // cb_estcid2
            // 
            this.cb_estcid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_estcid2.FormattingEnabled = true;
            this.cb_estcid2.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM ",
            "BA ",
            "CE",
            "DF ",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO",
            "",
            ""});
            this.cb_estcid2.Location = new System.Drawing.Point(519, 109);
            this.cb_estcid2.Name = "cb_estcid2";
            this.cb_estcid2.Size = new System.Drawing.Size(134, 21);
            this.cb_estcid2.TabIndex = 10;
            // 
            // txt_nomecid2
            // 
            this.txt_nomecid2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomecid2.Location = new System.Drawing.Point(133, 106);
            this.txt_nomecid2.Name = "txt_nomecid2";
            this.txt_nomecid2.Size = new System.Drawing.Size(178, 25);
            this.txt_nomecid2.TabIndex = 9;
            // 
            // txt_codcid2
            // 
            this.txt_codcid2.Enabled = false;
            this.txt_codcid2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codcid2.Location = new System.Drawing.Point(133, 36);
            this.txt_codcid2.Name = "txt_codcid2";
            this.txt_codcid2.Size = new System.Drawing.Size(83, 25);
            this.txt_codcid2.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(431, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(57, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(45, 38);
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
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // form_cidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(915, 540);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(235, 78);
            this.Name = "form_cidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "v";
            this.Load += new System.EventHandler(this.form_cidades_Load);
            this.tabControl1.ResumeLayout(false);
            this.cid_cadastrar.ResumeLayout(false);
            this.cid_cadastrar.PerformLayout();
            this.cid_consultar.ResumeLayout(false);
            this.cid_consultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_buscacidades)).EndInit();
            this.cid_altexclu.ResumeLayout(false);
            this.cid_altexclu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cid_cadastrar;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox tb_codibge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.ComboBox cb_estados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_vtccid;
        private System.Windows.Forms.TabPage cid_consultar;
        private System.Windows.Forms.Button bt_buscarcid;
        private System.Windows.Forms.Button bt_limparcid2;
        private System.Windows.Forms.DataGridView grid_buscacidades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_buscacid;
        private System.Windows.Forms.ComboBox cb_buscacid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage cid_altexclu;
        private System.Windows.Forms.Button bt_excluircid;
        private System.Windows.Forms.Button bt_alterarcid;
        private System.Windows.Forms.Button bt_limparcid3;
        private System.Windows.Forms.ComboBox cb_estcid2;
        private System.Windows.Forms.TextBox txt_nomecid2;
        private System.Windows.Forms.TextBox txt_codcid2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_voltarcid;
        private System.Windows.Forms.TextBox txt_codibge2;
        private System.Windows.Forms.Label label12;
    }
}