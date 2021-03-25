namespace DNState
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_campanhas = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletar = new System.Windows.Forms.Button();
            this.desativa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_campanhas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(79, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Ao adicionar uma nova campanha, ela será ativada todos os anos durante o período" +
    " de tempo indicado, e depois será desativada automaticamente, só se ativando out" +
    "ra vez no período do próximo ano.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suas Campanhas (Criadas por você ):";
            // 
            // dt_campanhas
            // 
            this.dt_campanhas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_campanhas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.inicio,
            this.fim,
            this.status,
            this.cod});
            this.dt_campanhas.Location = new System.Drawing.Point(12, 46);
            this.dt_campanhas.Name = "dt_campanhas";
            this.dt_campanhas.ReadOnly = true;
            this.dt_campanhas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dt_campanhas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_campanhas.Size = new System.Drawing.Size(497, 150);
            this.dt_campanhas.TabIndex = 2;
            this.dt_campanhas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_campanhas_CellClick);
            this.dt_campanhas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_campanhas_CellContentClick);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nome.Width = 150;
            // 
            // inicio
            // 
            this.inicio.HeaderText = "Data de Início";
            this.inicio.Name = "inicio";
            this.inicio.ReadOnly = true;
            // 
            // fim
            // 
            this.fim.HeaderText = "Data Final";
            this.fim.Name = "fim";
            this.fim.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // cod
            // 
            this.cod.HeaderText = "cod";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(12, 284);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(130, 23);
            this.deletar.TabIndex = 3;
            this.deletar.Text = "Deletar Campanha";
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // desativa
            // 
            this.desativa.Location = new System.Drawing.Point(320, 284);
            this.desativa.Name = "desativa";
            this.desativa.Size = new System.Drawing.Size(157, 23);
            this.desativa.TabIndex = 4;
            this.desativa.Text = "Ativar/Desativar Campanha";
            this.desativa.UseVisualStyleBackColor = true;
            this.desativa.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Inserir nova campanha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Convidar ONGS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Histórico de doações ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(195, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 391);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.desativa);
            this.Controls.Add(this.deletar);
            this.Controls.Add(this.dt_campanhas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_campanhas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dt_campanhas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fim;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.Button desativa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}