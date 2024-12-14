
namespace soft_code
{
    partial class form_estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_estoque));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.estoq_consulta = new System.Windows.Forms.TabPage();
            this.bt_voltarest = new System.Windows.Forms.Button();
            this.bt_buscarcli = new System.Windows.Forms.Button();
            this.bt_limparcli = new System.Windows.Forms.Button();
            this.grid_estoque = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_buscafunc = new System.Windows.Forms.TextBox();
            this.cb_buscafunc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.estoq_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.estoq_consulta);
            this.tabControl1.Location = new System.Drawing.Point(12, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 500);
            this.tabControl1.TabIndex = 3;
            // 
            // estoq_consulta
            // 
            this.estoq_consulta.Controls.Add(this.bt_voltarest);
            this.estoq_consulta.Controls.Add(this.bt_buscarcli);
            this.estoq_consulta.Controls.Add(this.bt_limparcli);
            this.estoq_consulta.Controls.Add(this.grid_estoque);
            this.estoq_consulta.Controls.Add(this.label6);
            this.estoq_consulta.Controls.Add(this.txt_buscafunc);
            this.estoq_consulta.Controls.Add(this.cb_buscafunc);
            this.estoq_consulta.Controls.Add(this.label5);
            this.estoq_consulta.Controls.Add(this.button2);
            this.estoq_consulta.Location = new System.Drawing.Point(4, 22);
            this.estoq_consulta.Name = "estoq_consulta";
            this.estoq_consulta.Padding = new System.Windows.Forms.Padding(3);
            this.estoq_consulta.Size = new System.Drawing.Size(882, 474);
            this.estoq_consulta.TabIndex = 1;
            this.estoq_consulta.Text = "Consulta de Estoque";
            this.estoq_consulta.UseVisualStyleBackColor = true;
            // 
            // bt_voltarest
            // 
            this.bt_voltarest.BackColor = System.Drawing.Color.DimGray;
            this.bt_voltarest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltarest.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltarest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_voltarest.Location = new System.Drawing.Point(768, 430);
            this.bt_voltarest.Name = "bt_voltarest";
            this.bt_voltarest.Size = new System.Drawing.Size(108, 38);
            this.bt_voltarest.TabIndex = 12;
            this.bt_voltarest.Text = "Voltar";
            this.bt_voltarest.UseVisualStyleBackColor = false;
            this.bt_voltarest.Click += new System.EventHandler(this.bt_voltarest_Click);
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
            // grid_estoque
            // 
            this.grid_estoque.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grid_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_estoque.Location = new System.Drawing.Point(54, 163);
            this.grid_estoque.Name = "grid_estoque";
            this.grid_estoque.Size = new System.Drawing.Size(691, 266);
            this.grid_estoque.TabIndex = 9;
            this.grid_estoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_estoque_CellContentClick);
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
            // txt_buscafunc
            // 
            this.txt_buscafunc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscafunc.Location = new System.Drawing.Point(543, 52);
            this.txt_buscafunc.Name = "txt_buscafunc";
            this.txt_buscafunc.Size = new System.Drawing.Size(168, 25);
            this.txt_buscafunc.TabIndex = 7;
            // 
            // cb_buscafunc
            // 
            this.cb_buscafunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_buscafunc.FormattingEnabled = true;
            this.cb_buscafunc.Items.AddRange(new object[] {
            "Nome",
            "Estação",
            "Tamanho ",
            "Cor"});
            this.cb_buscafunc.Location = new System.Drawing.Point(174, 56);
            this.cb_buscafunc.Name = "cb_buscafunc";
            this.cb_buscafunc.Size = new System.Drawing.Size(168, 21);
            this.cb_buscafunc.TabIndex = 6;
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
            // form_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(915, 540);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(235, 78);
            this.Name = "form_estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "form_estoque";
            this.Load += new System.EventHandler(this.form_estoque_Load);
            this.tabControl1.ResumeLayout(false);
            this.estoq_consulta.ResumeLayout(false);
            this.estoq_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_estoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage estoq_consulta;
        private System.Windows.Forms.Button bt_buscarcli;
        private System.Windows.Forms.Button bt_limparcli;
        private System.Windows.Forms.DataGridView grid_estoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_buscafunc;
        private System.Windows.Forms.ComboBox cb_buscafunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_voltarest;
    }
}