namespace DNState
{
    partial class Form10
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
            this.label_campanha = new System.Windows.Forms.Label();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.Label();
            this.txt_end = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_campanha
            // 
            this.label_campanha.AutoSize = true;
            this.label_campanha.Location = new System.Drawing.Point(101, 9);
            this.label_campanha.Name = "label_campanha";
            this.label_campanha.Size = new System.Drawing.Size(61, 13);
            this.label_campanha.TabIndex = 0;
            this.label_campanha.Text = "Campanha:";
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(90, 69);
            this.txt_cnpj.Mask = "99.999.999/9999-99";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(125, 20);
            this.txt_cnpj.TabIndex = 2;
            this.txt_cnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_cnpj_MaskInputRejected);
            this.txt_cnpj.TextChanged += new System.EventHandler(this.txt_cnpj_TextChanged);
            this.txt_cnpj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CNPJ da ONG:";
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Location = new System.Drawing.Point(12, 126);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(35, 13);
            this.txt_nome.TabIndex = 4;
            this.txt_nome.Text = "label2";
            // 
            // txt_numero
            // 
            this.txt_numero.AutoSize = true;
            this.txt_numero.Location = new System.Drawing.Point(12, 154);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(35, 13);
            this.txt_numero.TabIndex = 5;
            this.txt_numero.Text = "label3";
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.Location = new System.Drawing.Point(12, 179);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(35, 13);
            this.txt_email.TabIndex = 6;
            this.txt_email.Text = "label3";
            // 
            // txt_end
            // 
            this.txt_end.AutoSize = true;
            this.txt_end.Location = new System.Drawing.Point(12, 209);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(35, 13);
            this.txt_end.TabIndex = 7;
            this.txt_end.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convidar ONG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 239);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.label_campanha);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_campanha;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Label txt_numero;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.Label txt_end;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}