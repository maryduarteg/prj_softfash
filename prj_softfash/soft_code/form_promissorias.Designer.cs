
namespace soft_code
{
    partial class form_promissorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_promissorias));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.prom_consuprom = new System.Windows.Forms.TabPage();
            this.bt_voltarprom = new System.Windows.Forms.Button();
            this.grid_buscaprom = new System.Windows.Forms.DataGridView();
            this.bt_limparcid2 = new System.Windows.Forms.Button();
            this.bt_limparcid = new System.Windows.Forms.Button();
            this.txt_buscaitenvend = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cb_itenvenda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.venda_finalizar = new System.Windows.Forms.TabPage();
            this.txt_codvenda = new System.Windows.Forms.TextBox();
            this.txt_dataalt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_totalrestante = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mk_datacompra = new System.Windows.Forms.MaskedTextBox();
            this.mk_hora = new System.Windows.Forms.MaskedTextBox();
            this.txt_totalvenda = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_codprom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.prom_consusalda = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.prom_consuprom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_buscaprom)).BeginInit();
            this.venda_finalizar.SuspendLayout();
            this.prom_consusalda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.prom_consuprom);
            this.tabControl1.Controls.Add(this.venda_finalizar);
            this.tabControl1.Controls.Add(this.prom_consusalda);
            this.tabControl1.Location = new System.Drawing.Point(12, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 500);
            this.tabControl1.TabIndex = 5;
            // 
            // prom_consuprom
            // 
            this.prom_consuprom.Controls.Add(this.bt_voltarprom);
            this.prom_consuprom.Controls.Add(this.grid_buscaprom);
            this.prom_consuprom.Controls.Add(this.bt_limparcid2);
            this.prom_consuprom.Controls.Add(this.bt_limparcid);
            this.prom_consuprom.Controls.Add(this.txt_buscaitenvend);
            this.prom_consuprom.Controls.Add(this.label20);
            this.prom_consuprom.Controls.Add(this.cb_itenvenda);
            this.prom_consuprom.Controls.Add(this.label7);
            this.prom_consuprom.Controls.Add(this.button3);
            this.prom_consuprom.Location = new System.Drawing.Point(4, 22);
            this.prom_consuprom.Name = "prom_consuprom";
            this.prom_consuprom.Size = new System.Drawing.Size(882, 474);
            this.prom_consuprom.TabIndex = 2;
            this.prom_consuprom.Text = "Consultar Promissórias";
            this.prom_consuprom.UseVisualStyleBackColor = true;
            // 
            // bt_voltarprom
            // 
            this.bt_voltarprom.BackColor = System.Drawing.Color.DimGray;
            this.bt_voltarprom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltarprom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltarprom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_voltarprom.Location = new System.Drawing.Point(176, 100);
            this.bt_voltarprom.Name = "bt_voltarprom";
            this.bt_voltarprom.Size = new System.Drawing.Size(108, 38);
            this.bt_voltarprom.TabIndex = 45;
            this.bt_voltarprom.Text = "Voltar";
            this.bt_voltarprom.UseVisualStyleBackColor = false;
            this.bt_voltarprom.Click += new System.EventHandler(this.bt_voltarprom_Click);
            // 
            // grid_buscaprom
            // 
            this.grid_buscaprom.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_buscaprom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_buscaprom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_buscaprom.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_buscaprom.Location = new System.Drawing.Point(41, 160);
            this.grid_buscaprom.Name = "grid_buscaprom";
            this.grid_buscaprom.Size = new System.Drawing.Size(797, 266);
            this.grid_buscaprom.TabIndex = 44;
            this.grid_buscaprom.DoubleClick += new System.EventHandler(this.grid_buscaprom_DoubleClick);
            // 
            // bt_limparcid2
            // 
            this.bt_limparcid2.BackColor = System.Drawing.Color.DarkBlue;
            this.bt_limparcid2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limparcid2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limparcid2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_limparcid2.Location = new System.Drawing.Point(41, 100);
            this.bt_limparcid2.Name = "bt_limparcid2";
            this.bt_limparcid2.Size = new System.Drawing.Size(108, 38);
            this.bt_limparcid2.TabIndex = 43;
            this.bt_limparcid2.Text = "Limpar";
            this.bt_limparcid2.UseVisualStyleBackColor = false;
            // 
            // bt_limparcid
            // 
            this.bt_limparcid.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_limparcid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limparcid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limparcid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_limparcid.Location = new System.Drawing.Point(730, 42);
            this.bt_limparcid.Name = "bt_limparcid";
            this.bt_limparcid.Size = new System.Drawing.Size(108, 38);
            this.bt_limparcid.TabIndex = 42;
            this.bt_limparcid.Text = "Buscar";
            this.bt_limparcid.UseVisualStyleBackColor = false;
            this.bt_limparcid.Click += new System.EventHandler(this.bt_limparcid_Click);
            // 
            // txt_buscaitenvend
            // 
            this.txt_buscaitenvend.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscaitenvend.Location = new System.Drawing.Point(534, 48);
            this.txt_buscaitenvend.Name = "txt_buscaitenvend";
            this.txt_buscaitenvend.Size = new System.Drawing.Size(168, 25);
            this.txt_buscaitenvend.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(356, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(172, 24);
            this.label20.TabIndex = 40;
            this.label20.Text = "Digite sua busca:";
            // 
            // cb_itenvenda
            // 
            this.cb_itenvenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_itenvenda.FormattingEnabled = true;
            this.cb_itenvenda.Items.AddRange(new object[] {
            "Cliente",
            "Data"});
            this.cb_itenvenda.Location = new System.Drawing.Point(161, 50);
            this.cb_itenvenda.Name = "cb_itenvenda";
            this.cb_itenvenda.Size = new System.Drawing.Size(168, 26);
            this.cb_itenvenda.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(37, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Buscar por:";
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
            // venda_finalizar
            // 
            this.venda_finalizar.Controls.Add(this.txt_codvenda);
            this.venda_finalizar.Controls.Add(this.txt_dataalt);
            this.venda_finalizar.Controls.Add(this.label3);
            this.venda_finalizar.Controls.Add(this.txt_totalrestante);
            this.venda_finalizar.Controls.Add(this.txt_cliente);
            this.venda_finalizar.Controls.Add(this.label2);
            this.venda_finalizar.Controls.Add(this.label1);
            this.venda_finalizar.Controls.Add(this.button5);
            this.venda_finalizar.Controls.Add(this.button4);
            this.venda_finalizar.Controls.Add(this.mk_datacompra);
            this.venda_finalizar.Controls.Add(this.mk_hora);
            this.venda_finalizar.Controls.Add(this.txt_totalvenda);
            this.venda_finalizar.Controls.Add(this.label15);
            this.venda_finalizar.Controls.Add(this.label14);
            this.venda_finalizar.Controls.Add(this.label6);
            this.venda_finalizar.Controls.Add(this.label5);
            this.venda_finalizar.Controls.Add(this.txt_codprom);
            this.venda_finalizar.Controls.Add(this.label4);
            this.venda_finalizar.Controls.Add(this.button2);
            this.venda_finalizar.Location = new System.Drawing.Point(4, 22);
            this.venda_finalizar.Name = "venda_finalizar";
            this.venda_finalizar.Padding = new System.Windows.Forms.Padding(3);
            this.venda_finalizar.Size = new System.Drawing.Size(882, 474);
            this.venda_finalizar.TabIndex = 1;
            this.venda_finalizar.Text = "Alterar Promissórias";
            this.venda_finalizar.UseVisualStyleBackColor = true;
            // 
            // txt_codvenda
            // 
            this.txt_codvenda.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codvenda.Location = new System.Drawing.Point(595, 29);
            this.txt_codvenda.Name = "txt_codvenda";
            this.txt_codvenda.Size = new System.Drawing.Size(177, 25);
            this.txt_codvenda.TabIndex = 41;
            // 
            // txt_dataalt
            // 
            this.txt_dataalt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataalt.Location = new System.Drawing.Point(654, 231);
            this.txt_dataalt.Name = "txt_dataalt";
            this.txt_dataalt.Size = new System.Drawing.Size(136, 25);
            this.txt_dataalt.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(481, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Última alteração:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_totalrestante
            // 
            this.txt_totalrestante.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalrestante.Location = new System.Drawing.Point(531, 160);
            this.txt_totalrestante.Name = "txt_totalrestante";
            this.txt_totalrestante.Size = new System.Drawing.Size(152, 25);
            this.txt_totalrestante.TabIndex = 38;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(133, 91);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(236, 25);
            this.txt_cliente.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(128, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Total:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.ForestGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(765, 425);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 38);
            this.button5.TabIndex = 18;
            this.button5.Text = "Saldar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(654, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 38);
            this.button4.TabIndex = 17;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // mk_datacompra
            // 
            this.mk_datacompra.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mk_datacompra.Location = new System.Drawing.Point(553, 88);
            this.mk_datacompra.Name = "mk_datacompra";
            this.mk_datacompra.Size = new System.Drawing.Size(99, 26);
            this.mk_datacompra.TabIndex = 15;
            this.mk_datacompra.ValidatingType = typeof(System.DateTime);
            // 
            // mk_hora
            // 
            this.mk_hora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mk_hora.Location = new System.Drawing.Point(765, 89);
            this.mk_hora.Mask = "00:00";
            this.mk_hora.Name = "mk_hora";
            this.mk_hora.Size = new System.Drawing.Size(78, 26);
            this.mk_hora.TabIndex = 14;
            this.mk_hora.ValidatingType = typeof(System.DateTime);
            // 
            // txt_totalvenda
            // 
            this.txt_totalvenda.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalvenda.Location = new System.Drawing.Point(194, 157);
            this.txt_totalvenda.Name = "txt_totalvenda";
            this.txt_totalvenda.Size = new System.Drawing.Size(152, 25);
            this.txt_totalvenda.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(382, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "Total restante:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(382, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 24);
            this.label14.TabIndex = 10;
            this.label14.Text = "Data de compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(677, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Horário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(414, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código da Venda:";
            // 
            // txt_codprom
            // 
            this.txt_codprom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codprom.Location = new System.Drawing.Point(256, 32);
            this.txt_codprom.Name = "txt_codprom";
            this.txt_codprom.Size = new System.Drawing.Size(110, 25);
            this.txt_codprom.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Código da Promissória:";
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
            // prom_consusalda
            // 
            this.prom_consusalda.Controls.Add(this.dataGridView3);
            this.prom_consusalda.Controls.Add(this.button10);
            this.prom_consusalda.Controls.Add(this.button9);
            this.prom_consusalda.Controls.Add(this.textBox1);
            this.prom_consusalda.Controls.Add(this.label9);
            this.prom_consusalda.Controls.Add(this.comboBox2);
            this.prom_consusalda.Controls.Add(this.label8);
            this.prom_consusalda.Controls.Add(this.button8);
            this.prom_consusalda.Location = new System.Drawing.Point(4, 22);
            this.prom_consusalda.Name = "prom_consusalda";
            this.prom_consusalda.Size = new System.Drawing.Size(882, 474);
            this.prom_consusalda.TabIndex = 3;
            this.prom_consusalda.Text = "Consultar Promissórias Saldadas";
            this.prom_consusalda.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(41, 163);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(691, 266);
            this.dataGridView3.TabIndex = 45;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(41, 100);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(108, 38);
            this.button10.TabIndex = 44;
            this.button10.Text = "Limpar";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.ForestGreen;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(730, 42);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 38);
            this.button9.TabIndex = 43;
            this.button9.Text = "Buscar";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(533, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 25);
            this.textBox1.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(356, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 24);
            this.label9.TabIndex = 41;
            this.label9.Text = "Digite sua busca:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(161, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 26);
            this.comboBox2.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(37, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Buscar por:";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Window;
            this.button8.Enabled = false;
            this.button8.FlatAppearance.BorderSize = 4;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Crimson;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(882, 474);
            this.button8.TabIndex = 1;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // form_promissorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(915, 540);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(235, 78);
            this.Name = "form_promissorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "form_promissorias";
            this.Load += new System.EventHandler(this.form_promissorias_Load);
            this.tabControl1.ResumeLayout(false);
            this.prom_consuprom.ResumeLayout(false);
            this.prom_consuprom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_buscaprom)).EndInit();
            this.venda_finalizar.ResumeLayout(false);
            this.venda_finalizar.PerformLayout();
            this.prom_consusalda.ResumeLayout(false);
            this.prom_consusalda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage prom_consuprom;
        private System.Windows.Forms.DataGridView grid_buscaprom;
        private System.Windows.Forms.Button bt_limparcid2;
        private System.Windows.Forms.Button bt_limparcid;
        private System.Windows.Forms.TextBox txt_buscaitenvend;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cb_itenvenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage venda_finalizar;
        private System.Windows.Forms.TextBox txt_dataalt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_totalrestante;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox mk_datacompra;
        private System.Windows.Forms.MaskedTextBox mk_hora;
        private System.Windows.Forms.TextBox txt_totalvenda;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_codprom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage prom_consusalda;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txt_codvenda;
        private System.Windows.Forms.Button bt_voltarprom;
    }
}