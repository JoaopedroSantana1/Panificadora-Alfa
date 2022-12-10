namespace WindowsFormsApp1
{
    partial class FormLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cadastrobtn = new System.Windows.Forms.Button();
            this.senhabox = new System.Windows.Forms.TextBox();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alfalable = new System.Windows.Forms.Label();
            this.panificadoralable = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cadastrobtn);
            this.panel2.Controls.Add(this.senhabox);
            this.panel2.Controls.Add(this.loginbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(431, 188);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 647);
            this.panel2.TabIndex = 11;
            // 
            // cadastrobtn
            // 
            this.cadastrobtn.BackColor = System.Drawing.Color.Turquoise;
            this.cadastrobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cadastrobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrobtn.Location = new System.Drawing.Point(484, 413);
            this.cadastrobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cadastrobtn.Name = "cadastrobtn";
            this.cadastrobtn.Size = new System.Drawing.Size(128, 62);
            this.cadastrobtn.TabIndex = 12;
            this.cadastrobtn.Text = "Login";
            this.cadastrobtn.UseVisualStyleBackColor = false;
            this.cadastrobtn.Click += new System.EventHandler(this.cadastrobtn_Click);
            // 
            // senhabox
            // 
            this.senhabox.BackColor = System.Drawing.Color.Azure;
            this.senhabox.Location = new System.Drawing.Point(404, 328);
            this.senhabox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senhabox.Name = "senhabox";
            this.senhabox.PasswordChar = '*';
            this.senhabox.Size = new System.Drawing.Size(309, 22);
            this.senhabox.TabIndex = 6;
            this.senhabox.TextChanged += new System.EventHandler(this.senhabox2_TextChanged);
            // 
            // loginbox
            // 
            this.loginbox.BackColor = System.Drawing.Color.Azure;
            this.loginbox.Location = new System.Drawing.Point(404, 193);
            this.loginbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(309, 22);
            this.loginbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha de Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome de Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faça seu Login!";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.alfalable);
            this.panel1.Controls.Add(this.panificadoralable);
            this.panel1.Location = new System.Drawing.Point(-52, -27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1976, 97);
            this.panel1.TabIndex = 10;
            // 
            // alfalable
            // 
            this.alfalable.AutoSize = true;
            this.alfalable.Font = new System.Drawing.Font("Swis721 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alfalable.Location = new System.Drawing.Point(289, 59);
            this.alfalable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alfalable.Name = "alfalable";
            this.alfalable.Size = new System.Drawing.Size(45, 24);
            this.alfalable.TabIndex = 1;
            this.alfalable.Text = "Alfa";
            // 
            // panificadoralable
            // 
            this.panificadoralable.AutoSize = true;
            this.panificadoralable.Font = new System.Drawing.Font("Swis721 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panificadoralable.Location = new System.Drawing.Point(187, 36);
            this.panificadoralable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panificadoralable.Name = "panificadoralable";
            this.panificadoralable.Size = new System.Drawing.Size(127, 24);
            this.panificadoralable.TabIndex = 0;
            this.panificadoralable.Text = "Panificadora";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 931);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox senhabox;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label alfalable;
        private System.Windows.Forms.Label panificadoralable;
        private System.Windows.Forms.Button cadastrobtn;
    }
}