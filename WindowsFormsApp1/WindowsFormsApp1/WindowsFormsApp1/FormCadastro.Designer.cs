namespace WindowsFormsApp1
{
    partial class FormCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panificadoralable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.perfilbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.atualizarbtn = new System.Windows.Forms.Button();
            this.cadastrobtn = new System.Windows.Forms.Button();
            this.senhabox = new System.Windows.Forms.TextBox();
            this.excluirbtn = new System.Windows.Forms.Button();
            this.enderecobox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.nomebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.caralhobox = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pesquisarbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caralhobox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panificadoralable);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1927, 89);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1245, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Alfa";
            // 
            // panificadoralable
            // 
            this.panificadoralable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panificadoralable.AutoSize = true;
            this.panificadoralable.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panificadoralable.Location = new System.Drawing.Point(1101, 10);
            this.panificadoralable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panificadoralable.Name = "panificadoralable";
            this.panificadoralable.Size = new System.Drawing.Size(148, 28);
            this.panificadoralable.TabIndex = 0;
            this.panificadoralable.Text = "Panificadora";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.perfilbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.atualizarbtn);
            this.panel2.Controls.Add(this.cadastrobtn);
            this.panel2.Controls.Add(this.senhabox);
            this.panel2.Controls.Add(this.excluirbtn);
            this.panel2.Controls.Add(this.enderecobox);
            this.panel2.Controls.Add(this.emailbox);
            this.panel2.Controls.Add(this.nomebox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1565, 721);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // perfilbox
            // 
            this.perfilbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.perfilbox.BackColor = System.Drawing.Color.Azure;
            this.perfilbox.Location = new System.Drawing.Point(200, 359);
            this.perfilbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.perfilbox.Name = "perfilbox";
            this.perfilbox.Size = new System.Drawing.Size(1253, 22);
            this.perfilbox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Perfil";
            // 
            // atualizarbtn
            // 
            this.atualizarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.atualizarbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.atualizarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.atualizarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizarbtn.Location = new System.Drawing.Point(400, 402);
            this.atualizarbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.atualizarbtn.Name = "atualizarbtn";
            this.atualizarbtn.Size = new System.Drawing.Size(114, 68);
            this.atualizarbtn.TabIndex = 12;
            this.atualizarbtn.Text = "Atualizar";
            this.atualizarbtn.UseVisualStyleBackColor = false;
            this.atualizarbtn.Click += new System.EventHandler(this.atualizarbtn_Click);
            // 
            // cadastrobtn
            // 
            this.cadastrobtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadastrobtn.BackColor = System.Drawing.Color.Turquoise;
            this.cadastrobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cadastrobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrobtn.Location = new System.Drawing.Point(200, 492);
            this.cadastrobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cadastrobtn.Name = "cadastrobtn";
            this.cadastrobtn.Size = new System.Drawing.Size(314, 90);
            this.cadastrobtn.TabIndex = 9;
            this.cadastrobtn.Text = "Cadastrar";
            this.cadastrobtn.UseVisualStyleBackColor = false;
            this.cadastrobtn.Click += new System.EventHandler(this.cadastrobtn_Click_1);
            // 
            // senhabox
            // 
            this.senhabox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.senhabox.BackColor = System.Drawing.Color.Azure;
            this.senhabox.Location = new System.Drawing.Point(200, 302);
            this.senhabox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senhabox.Name = "senhabox";
            this.senhabox.Size = new System.Drawing.Size(1253, 22);
            this.senhabox.TabIndex = 8;
            // 
            // excluirbtn
            // 
            this.excluirbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.excluirbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.excluirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluirbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirbtn.Location = new System.Drawing.Point(200, 402);
            this.excluirbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.excluirbtn.Name = "excluirbtn";
            this.excluirbtn.Size = new System.Drawing.Size(126, 68);
            this.excluirbtn.TabIndex = 11;
            this.excluirbtn.Text = "Excluir";
            this.excluirbtn.UseVisualStyleBackColor = false;
            this.excluirbtn.Click += new System.EventHandler(this.excluirbtn_Click);
            // 
            // enderecobox
            // 
            this.enderecobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enderecobox.BackColor = System.Drawing.Color.Azure;
            this.enderecobox.Location = new System.Drawing.Point(200, 242);
            this.enderecobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enderecobox.Name = "enderecobox";
            this.enderecobox.Size = new System.Drawing.Size(1253, 22);
            this.enderecobox.TabIndex = 7;
            // 
            // emailbox
            // 
            this.emailbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailbox.BackColor = System.Drawing.Color.Azure;
            this.emailbox.Location = new System.Drawing.Point(200, 174);
            this.emailbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(1253, 22);
            this.emailbox.TabIndex = 6;
            // 
            // nomebox
            // 
            this.nomebox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomebox.BackColor = System.Drawing.Color.Azure;
            this.nomebox.Location = new System.Drawing.Point(200, 117);
            this.nomebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomebox.Name = "nomebox";
            this.nomebox.Size = new System.Drawing.Size(1253, 22);
            this.nomebox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faça seu Cadastro!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // caralhobox
            // 
            this.caralhobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caralhobox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caralhobox.Location = new System.Drawing.Point(185, 218);
            this.caralhobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caralhobox.Name = "caralhobox";
            this.caralhobox.RowHeadersWidth = 51;
            this.caralhobox.Size = new System.Drawing.Size(932, 301);
            this.caralhobox.TabIndex = 10;
            this.caralhobox.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.caralhobox_CellDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(170, 127);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1581, 757);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pesquisarbox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.caralhobox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1573, 728);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(872, 120);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 64);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pesquisarbox
            // 
            this.pesquisarbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pesquisarbox.BackColor = System.Drawing.Color.White;
            this.pesquisarbox.Location = new System.Drawing.Point(185, 68);
            this.pesquisarbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pesquisarbox.Name = "pesquisarbox";
            this.pesquisarbox.Size = new System.Drawing.Size(932, 22);
            this.pesquisarbox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pesquisar";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1573, 728);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caralhobox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label panificadoralable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button atualizarbtn;
        private System.Windows.Forms.TextBox senhabox;
        private System.Windows.Forms.TextBox enderecobox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox nomebox;
        private System.Windows.Forms.Button cadastrobtn;
        private System.Windows.Forms.TextBox perfilbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView caralhobox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pesquisarbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button excluirbtn;
    }
}

